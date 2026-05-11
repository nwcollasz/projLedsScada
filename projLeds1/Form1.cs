
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static projLeds1.PID;

namespace projLeds1
{
    public partial class ControleLeds : Form
    {

        //====================
        // VARIÁVEIS DE CLASSE
        //====================

        private Leds leds;
        private Button[] botoes;
        private PictureBox[] imagens;
        private Usuario usuario;

        bool modoPID = false;
        string banco = "Data Source=historico.db";

        double temperatura = 25.0;

        PIDController pid;


        //===========================
        // CONSTRUTORES DO FORMULÁRIO
        //===========================

        private void Inicializar()
        {
            InicializarUI();
            InicializarGrafico();
            InicializarLogica();
        }

        private void BotaoLed_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            int index = Array.IndexOf(botoes, btn) + 1;

            ToggleLed(index);
        }

        private void InicializarUI()
        {
            this.Font = new Font("Times New Roman", 10);
            botoes = new Button[] { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8 };
            imagens = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };

            for (int i = 0; i < botoes.Length; i++)
            {
                botoes[i].Click -= BotaoLed_Click;
                botoes[i].Click += BotaoLed_Click;
            }
        }

        public ControleLeds()
        {
            InitializeComponent();
        }

        private void ControleLeds_Load(object sender, EventArgs e)
        {
            if (IsDesignTime()) return;

            Inicializar();

            timer1.Interval = 100;

            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;

            timer1.Start();

            if (usuario != null)
            {
                lblNome.Text = $" User: {usuario.Nome}";
                lblEntrada.Text = $"Entrada: {usuario.Entrada:dd/MM/yyyy HH:mm:ss}";
                lblFuncao.Text = $" Função: {usuario.Funcao}";
                pictureBoxUsuario.Image = usuario.Foto;
            }
        }

        public ControleLeds(Usuario u) : this()
        {
            usuario = u;
        }

        private bool IsDesignTime()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                   || this.DesignMode;
        }

        private void InicializarGrafico()
        {

            if (IsDesignTime()) return;
           
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea area = new ChartArea("Principal");

            chart1.ChartAreas.Add(area);


            area.BackColor = Color.Black;

            area.AxisX.LineColor = Color.Transparent;
            area.AxisY.LineColor = Color.Yellow;
            area.AxisY2.LineColor = Color.Cyan;

            area.AxisX.LabelStyle.ForeColor = Color.Transparent;
            area.AxisY.LabelStyle.ForeColor = Color.Yellow;
            area.AxisY2.LabelStyle.ForeColor = Color.Cyan;

            area.AxisX.MajorGrid.LineColor = Color.FromArgb(40, 40, 40);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(40, 40, 40);

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 120;
            area.AxisY.Interval = 10;

            area.AxisY2.Enabled = AxisEnabled.True;

            area.AxisY2.Minimum = 0;
            area.AxisY2.Maximum = 8;
            area.AxisY2.Interval = 1;
            
            Series s1 = new Series("LEDs")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Cyan,
                BorderWidth = 2,
                ChartArea = "Principal",
                YAxisType = AxisType.Secondary
            };

            Series s2 = new Series("Temp")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Yellow,
                BorderWidth = 3,
                ChartArea = "Principal"
            };


            chart1.Series.Add(s1);
            chart1.Series.Add(s2);

            chart1.BackColor = Color.Black;
            chart1.BorderlineColor = Color.Transparent;
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;


            chart1.Legends.Clear();

        }

        private void InicializarLogica()
        {
            if (IsDesignTime()) return;

            CriarBanco();

            leds = new Leds();

            pid = new PIDController(2.0, 0.4, 0.8);
      
            timer1.Interval = 100;
        }


        //==============================================================
        // MÉTODO PARA LIGAR OU DESLIGAR UM LED QUANDO O BOTÃO É CLICADO
        //==============================================================

        private void ToggleLed(int led)
        {
            if (leds == null) return;

            if (modoPID) return;

            if (leds.getLed(led))
                leds.apagar(led);
            else
                leds.acender(led);

            atualizaInterface();
        }
        private void atualizaInterface()
        {
            if (IsDesignTime()) return;

            int ativos = GetAtivos();

            if (leds == null)
            {
                txtDadoDec.Text = "0";
                txtDadoBin.Text = "00000000";
                txtDadoHex.Text = "00";
                lblTemp.Text = $"{temperatura:F1} °C";
                lblAtivos.Text = "ATIVOS: 0";
                return;
            }

            byte dado = leds.getDado();
            txtDadoDec.Text = dado.ToString();
            txtDadoBin.Text = Convert.ToString(dado, 2).PadLeft(8, '0');
            txtDadoHex.Text = dado.ToString("X2");

            lblTemp.Text = $"{temperatura:F1} °C";

            if (temperatura > 90) { lblStatus.Text = "🔥 ALERTA CRÍTICO"; lblStatus.ForeColor = Color.Red; }
            else if (ativos > 0) { lblStatus.Text = "SISTEMA EM OPERAÇÃO"; lblStatus.ForeColor = Color.Yellow; }
            else { lblStatus.Text = "SISTEMA STANDBY"; lblStatus.ForeColor = Color.Lime; }

            lblAtivos.Text = $"ATIVOS: {GetAtivos()}";

            for (int i = 0; i < 8; i++)
            {
                bool estado = leds.getLed(i + 1);
                botoes[i].BackColor = estado ? Color.Red : Color.FromArgb(60, 60, 60);
                botoes[i].Text = estado ? "OFF" : "ON";
                botoes[i].Enabled = !modoPID;

                if (imagens[i] != null)
                {
                    imagens[i].Image = estado
                        ? Properties.Resources.WhatsApp_Image_2025_10_19_at_10_14_03__1_
                        : Properties.Resources.WhatsApp_Image_2025_10_19_at_10_14_03;
                }
            }
        }

        //======
        // TIMER 
        //=======

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ativos = GetAtivos();

            if (ativos > 4)
            {
                temperatura += (ativos * 0.4);
            }
            else
            {
                if (temperatura > 25) temperatura -= 0.5;
            }

            temperatura = Math.Max(25, Math.Min(120, temperatura));

            try
            {
                chart1.Series["LEDs"].Points.AddY(ativos);
                chart1.Series["Temp"].Points.AddY(temperatura);

                if (chart1.Series["LEDs"].Points.Count > 30)
                {
                    chart1.Series["LEDs"].Points.RemoveAt(0);
                    chart1.Series["Temp"].Points.RemoveAt(0);
                }

                chart1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            atualizaInterface();
        }

        private int GetAtivos()
        {
            if (leds == null)
                return 0;

            int ativos = 0;

            for (int i = 1; i <= 8; i++)
            {
                if (leds.getLed(i))
                    ativos++;
            }

            return ativos;
        }

        //===================================================
        // BOTÃO PARA RESETAR O SISTEMA (APAGA TODOS OS LEDs)
        //===================================================

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; i++)
            {
                leds.apagar(i);
            }

            atualizaInterface();

            MessageBox.Show("Sistema Resetado: Todos os LEDs foram desligados.");

            atualizaInterface();
        }

        //=======================================================
        // MÉTODO PARA EXPORTAR O LOG PARA UM ARQUIVO CSV (EXCEL)
        //=======================================================

        private void ExportarCSV()
        {
            SaveFileDialog salvar = new SaveFileDialog();

            salvar.Filter = "Arquivo CSV (*.csv)|*.csv";
            salvar.Title = "Salvar histórico";
            salvar.FileName = "historico.csv";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(salvar.FileName))
                {
                    sw.WriteLine("Hora;Temperatura;LEDs");

                    foreach (var item in listBoxHistorico.Items)
                    {
                        string linha = item.ToString();

                        string[] partes = linha.Split('|');

                        if (partes.Length >= 3)
                        {
                            string hora = partes[0].Trim();

                            string temp = partes[1]
                                .Replace("Temp:", "")
                                .Trim();

                            string leds = partes[2]
                                .Replace("LEDs:", "")
                                .Trim();

                            sw.WriteLine($"{hora};{temp};{leds}");
                        }
                    }
                }

                MessageBox.Show("Histórico exportado para Excel!");
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            ExportarCSV();
        }

        //====================================================
        // BOTÃO QUE EXIBE O ÚLTIMO REGISTRO DO LOG NA LISTBOX
        //====================================================

        private void btnExportarLog_Click(object sender, EventArgs e)
        {
            string registro = $"{DateTime.Now:HH:mm:ss} | Temp: {temperatura:F1} | LEDs: {GetAtivos()}";

            listBoxHistorico.Items.Add(registro);

            listBoxHistorico.SelectedIndex = listBoxHistorico.Items.Count - 1;
        }

        //===============================================================
        // MÉTODO PARA CRIAR O BANCO DE DADOS E A TABELA SE NÃO EXISTIREM
        //===============================================================

        private void CriarBanco()
        {
            using (SQLiteConnection conexao = new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
                      CREATE TABLE IF NOT EXISTS Historico (
                      Id INTEGER PRIMARY KEY AUTOINCREMENT,
                      Data TEXT,
                      Hora TEXT,
                      Temperatura REAL,
                      LEDs INTEGER
                      )";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
        }

        //=================================================
        // MÉTODO PARA SALVAR UM REGISTRO NO BANCO DE DADOS
        //=================================================

        private void SalvarSQLite(string data, string hora, double temperatura, int leds)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
                      INSERT INTO Historico
                     (Data, Hora, Temperatura, LEDs)
                      VALUES
                      (@data, @hora, @temp, @leds)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@leds", leds);

                cmd.ExecuteNonQuery();
            }
        }

        //====================================================================================
        // MÉTODO PARA VERIFICAR SE UM REGISTRO JÁ EXISTE NO BANCO DE DADOS (EVITA DUPLICATAS)
        //====================================================================================

        private bool RegistroExiste(
                string data,
                string hora,
                double temperatura,
                int leds)
        {
            using (SQLiteConnection conexao =
                    new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM Historico
                WHERE
                Data = @data AND
                Hora = @hora AND
                Temperatura = @temp AND
                LEDs = @leds";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@leds", leds);

                int count = Convert.ToInt32(
                    cmd.ExecuteScalar());

                return count > 0;
            }
        }

        //====================================================================
        // BOTÃO PARA SALVAR O ÚLTIMO REGISTRO DO LOG NO BANCO DE DADOS SQLITE
        //====================================================================

        private void btnSQLite_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxHistorico.Items)
            {
                string linha = item.ToString();
                string[] partes = linha.Split('|');

                if (partes.Length >= 3)
                {
                    string data =
                        DateTime.Now.ToString("dd/MM/yyyy");

                    string hora =
                        partes[0].Trim();

                    double temp = Convert.ToDouble(
                        partes[1]
                        .Replace("Temp:", "")
                        .Trim()
                    );

                    int leds = Convert.ToInt32(
                        partes[2]
                        .Replace("LEDs:", "")
                        .Trim()
                    );

                    if (!RegistroExiste(
                        data,
                        hora,
                        temp,
                        leds))
                    {
                        SalvarSQLite(
                            data,
                            hora,
                            temp,
                            leds);
                    }
                }
            }
            MessageBox.Show(
                "Novos registros salvos!");

            System.Diagnostics.Process.Start(
                "explorer.exe",
                Application.StartupPath);
        }

        //=============================================================
        // MÉTODOS PARA IMPEDIR O FECHAMENTO DO FORMULÁRIO PELO USUÁRIO
        // IMPEDE FECHAMENTO PELO "X" E "ALT + F4"
        // FORÇA O USO DO BOTÃO "SAIR" PARA FECHAR O SISTEMA 
        //=============================================================

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
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
    }

}

