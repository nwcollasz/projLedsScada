using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using projLeds1.Models;
using projLeds1.Services;
using projLeds1.UI;
using projLeds1.Database;
using projLeds1.Core;

namespace projLeds1.Forms
{
    public partial class ControleLeds : Form
    {

        //====================
        // VARIÁVEIS DE CLASSE
        //====================

        private LedService ledService;
        private LedExportacaoService exportacaoService;
        private AlarmeService alarmeService;
        private Usuario usuario;
        private SimuladorTemperatura simulador;
        private BancoHistorico bancoHistorico;
        private LedGridHistorico gridHistorico;
        private LedGrafico grafico;
        private Button[] botoes;
        private PictureBox[] imagens;
        private Dashboard dashboard;



        //====================================================
        // CONSTRUTORES, INICIALIZAÇÃO E EVENTOS DO FORMULÁRIO
        //====================================================

        public ControleLeds() 
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer,
                     true);

            UpdateStyles();
        }
       
        public ControleLeds(LedService ledRecebido, Usuario u, Dashboard dash) : this() 
        {
            this.ledService = ledRecebido;
            usuario = u;
            dashboard = dash;
        }

        private void ControleLeds_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (IsDesignTime()) return;

            Inicializar();

            this.BackColor = Color.FromArgb(35, 35, 35);

            timer1.Interval = 100;

            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;

            timer1.Start();

            if (usuario != null)
            {
                lblNome.Text = $" User: {usuario.Nome}";
                lblEntrada.Text = $"{usuario.Entrada:dd/MM/yyyy HH:mm:ss}";
                lblFuncao.Text = $" Função: {usuario.Funcao}";
                pictureBoxUsuario.Image = usuario.Foto; 
            }
        }

        private void Inicializar() 
        {
            InicializarUI();
            InicializarLogica();
        }

        private void InicializarUI() 
        {
            botoes = new Button[] { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8 };
            imagens = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };

            for (int i = 0; i < botoes.Length; i++)
            {
                botoes[i].Click -= BotaoLed_Click;
                botoes[i].Click += BotaoLed_Click;
            }
        }

        private void InicializarLogica() 
        {
            if (IsDesignTime()) return;

            ledService = new LedService();
            simulador = new SimuladorTemperatura();
            exportacaoService = new LedExportacaoService();
            alarmeService = new AlarmeService();
            bancoHistorico = new BancoHistorico();
            gridHistorico = new LedGridHistorico(dgvHistorico);
            grafico = new LedGrafico(chart1);

            gridHistorico.Configurar();

        }

        private bool IsDesignTime() 
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                   || this.DesignMode;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            for (int i = 1; i <= 8; i++)
            {
                ledService.ApagarTodos();
            }

            atualizaInterface();

            MessageBox.Show("Sistema Resetado: Todos os LEDs foram desligados.");

        }

        private void BotaoLed_Click(object sender, EventArgs e) 
        {
            Button btn = sender as Button;

            int index = Array.IndexOf(botoes, btn) + 1;

            ledService.Toggle(index);

            atualizaInterface();
        }

       
        private void atualizaInterface() 
        {
            if (IsDesignTime()) return;

            int ativos = ledService.GetAtivos();

            byte dado = ledService.GetDado();
            txtDadoDec.Text = dado.ToString();
            txtDadoBin.Text = Convert.ToString(dado, 2).PadLeft(8, '0');
            txtDadoHex.Text = dado.ToString("X2");

            lblTemp.Text = $"{simulador.Temperatura:F1} °C";
            lblTemp.ForeColor = alarmeService.GetCor(simulador.Temperatura, ativos);

            lblStatus.Text = alarmeService.GetMensagem(simulador.Temperatura, ativos);
            lblStatus.ForeColor = alarmeService.GetCor(simulador.Temperatura, ativos);

            lblStatus.ForeColor = alarmeService.GetCor(simulador.Temperatura, ativos);
            lblAtivos.Text = $"ATIVOS: {ledService.GetAtivos()}";

            for (int i = 0; i < 8; i++)
            {
                bool estado = ledService.GetEstado(i + 1);
                botoes[i].BackColor = estado ? Color.Red : Color.FromArgb(60, 60, 60);
                botoes[i].Text = estado ? "OFF" : "ON";
                botoes[i].Enabled = true;

                if (imagens[i] != null)
                {
                    imagens[i].Image = estado 
                        ? Properties.Resources.led_aceso
                        : Properties.Resources.led_apagado;
                }
            }
        }

        //======================
        // TIMER (HORA E FADEIN)
        //======================

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ativos = ledService.GetAtivos();

            simulador.Atualizar(ativos);

            grafico.Atualizar(ativos,simulador.Temperatura);

            SistemaGlobal.TemperaturaLEDs = simulador.Temperatura;

            SistemaGlobal.LEDsAtivos = ativos;

            SistemaGlobal.StatusLEDs = ativos > 0
                ? "ONLINE"
                : "STANDBY";

            atualizaInterface();
        }

        //====================================================
        // BOTÃO PARA EXPORTAR O HISTÓRICO PARA UM ARQUIVO CSV
        //=====================================================

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            exportacaoService.ExportarCSV(SistemaGlobal.Historico.GetTodos());
        }

        //==================================================================
        // BOTÃO PARA ADICIONAR O REGISTRO ATUAL DO LOG NA TELA E NA MEMÓRIA
        //==================================================================

        private void btnExportarLog_Click(object sender, EventArgs e)
        {
            RegistroHistorico registro =
        new RegistroHistorico
        {
            DataHora = DateTime.Now,
            Temperatura = simulador.Temperatura,
            LEDs = ledService.GetAtivos()
        };

            SistemaGlobal.Historico.Adicionar(registro);

            gridHistorico.AdicionarRegistro(registro);
        }

        //====================================================================
        // BOTÃO PARA SALVAR O ÚLTIMO REGISTRO DO LOG NO BANCO DE DADOS SQLITE
        //====================================================================

        private void btnSQLite_Click(object sender, EventArgs e)
        {
            foreach (RegistroHistorico registro in SistemaGlobal.Historico.GetTodos())
            {
                string data =
                    registro.DataHora.ToString("dd/MM/yyyy");

                string hora =
                    registro.DataHora.ToString("HH:mm:ss");

                double temp =
                    registro.Temperatura;

                int leds =
                    registro.LEDs;

                if (!bancoHistorico.RegistroExiste(
                        data,
                        hora,
                        temp,
                        leds))
                {
                    bancoHistorico.Salvar(
                        data,
                        hora,
                        temp,
                        leds);
                }
            }

            MessageBox.Show(
                "Registros dos leds salvos!");

        }

        //==================================================
        // IMPEDE FECHAMENTO PELO "X" E "ALT + F4"
        // FORÇA O USO DO BOTÃO "SAIR" PARA FECHAR O SISTEMA 
        //==================================================

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                dashboard.Show();
                e.Cancel = true;
                MessageBox.Show("Use o botão SAIR para fechar o sistema.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            dashboard.Show();
            dashboard.BringToFront();
        }
    }

}

