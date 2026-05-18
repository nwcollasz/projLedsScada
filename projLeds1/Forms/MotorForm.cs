using projLeds1.Core;
using projLeds1.Database;
using projLeds1.Models;
using projLeds1.Services;
using projLeds1.UI;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace projLeds1.Forms
{
    public partial class MotorForm : Form
    {
        private MotorService motor;

        private MotorLogService logService;

        private BancoHistorico bancoHistorico;

        private MotorSemaforo semaforoUI;

        private LedExportacaoService exportacaoService;

        private MotorGridHistorico gridUI;

        private Usuario usuario;

        private Dashboard dashboard;

        private Image gifLigado;

        private Image gifDesligado;

        public MotorForm(MotorService motorRecebido, Usuario u, Dashboard dash)
        {
            InitializeComponent();

            this.Load += MotorForm_Load;

            motor = motorRecebido;

            usuario = u;

            dashboard = dash;

            logService = new MotorLogService();

            bancoHistorico = new BancoHistorico();

            semaforoUI = new MotorSemaforo();

            exportacaoService = new LedExportacaoService();

            gridUI = new MotorGridHistorico();

            this.DoubleBuffered = true;
        }

        private void MotorForm_Load(object sender, EventArgs e)
        {
            gifLigado = Properties.Resources.motorGiro2;

            gifDesligado = Properties.Resources.giroMotor2_off;

            pictureMotor.Image = gifDesligado;

            pictureMotor.SizeMode = PictureBoxSizeMode.StretchImage;

            progressTemp.Maximum = 150;

            progressCorrente.Maximum = 50;

            trackRPM.Minimum = 0;
            trackRPM.Maximum = 60;

            progressRPM.Maximum = 3600;

            gridUI.Configurar(dgvEventos);

            timerMotor.Interval = 100;

            timerMotor.Start();

            if (usuario != null)
            {
                lblNome.Text = $"Usuário: {usuario.Nome}";

                lblFuncao.Text = $"Função: {usuario.Funcao}";

                lblEntrada.Text = $"{usuario.Entrada:dd/MM/yyyy HH:mm:ss}";

                pictureBoxUsuario.Image = usuario.Foto;
            }
        }

        private void timerMotor_Tick(object sender, EventArgs e)
        {
            motor.Atualizar();

            lblRPM.Text = $"RPM: {motor.Dados.RPM:F0}";

            lblTemp.Text = $"TEMP: {motor.Dados.Temperatura:F1} °C";

            lblCorrente.Text = $"CORRENTE: {motor.Dados.Corrente:F1} A";

            lblHz.Text = $"FREQ: {motor.Dados.FrequenciaHz:F1} Hz";

            progressRPM.Value = (int)Math.Max(0, Math.Min(motor.Dados.RPM, progressRPM.Maximum));

            progressTemp.Value = (int)Math.Max(0, Math.Min(motor.Dados.Temperatura, progressTemp.Maximum));

            progressCorrente.Value = (int)Math.Max(0, Math.Min(motor.Dados.Corrente, progressCorrente.Maximum));

            semaforoUI.AtualizarSemaforo(
                panelVerde,
                panelAmarelo,
                panelVermelho,
                motor.Dados.Status);
        }

        private void RegistrarEvento(string eventoTexto)
        {
            RegistroHistorico registro = SistemaGlobal.Historico.RegistrarMotor(motor.Dados, eventoTexto);
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            motor.Ligar();

            motor.DefinirFrequencia(60);

            trackRPM.Value = 60;

            if (pictureMotor.Image != gifLigado)
            {
                pictureMotor.Image = gifLigado;
            }

            RegistrarEvento("LIGADO");
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            motor.Desligar();

            trackRPM.Value = 0;

            pictureMotor.Image = Properties.Resources.giroMotor2_off;

            RegistrarEvento("DESLIGADO");
        }

        private void trackRPM_Scroll(object sender, EventArgs e)
        {
            motor.DefinirFrequencia(trackRPM.Value);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            dashboard.Show();

            dashboard.BringToFront();
        }

        private void btnExportarLog_Click(object sender, EventArgs e)
        {
            RegistroHistorico registro = new RegistroHistorico
            {
                DataHora = DateTime.Now,

                Equipamento = "Motor",

                RPM = motor.Dados.RPM,

                Temperatura = motor.Dados.Temperatura,

                Corrente = motor.Dados.Corrente,

                Evento = motor.Dados.Status
            };

            SistemaGlobal.Historico.Adicionar(registro);

            gridUI.AdicionarRegistro(registro);

            if (dgvEventos.Rows.Count > 0)
            {
                dgvEventos.FirstDisplayedScrollingRowIndex = dgvEventos.Rows.Count - 1;
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            var registrosMotor = SistemaGlobal.Historico.GetTodos()
                    .Where(r => r.Equipamento == "Motor")
                    .ToList();

            exportacaoService.ExportarCSV(registrosMotor);
        }

        private void btnSalvarSQLite_Click(object sender, EventArgs e)
        {
            foreach (RegistroHistorico registro in SistemaGlobal.Historico.GetTodos())
            {
                if (registro.Equipamento == "Motor")
                {
                    string data = registro.DataHora.ToString("dd/MM/yyyy");

                    string hora = registro.DataHora.ToString("HH:mm:ss");

                    double temp = registro.Temperatura;

                    int rpm = (int)registro.RPM;

                    int corrente = (int)registro.Corrente;

                    if (!bancoHistorico.RegistroMotorExiste(data, hora, temp, rpm))
                    {
                        bancoHistorico.SalvarMotor(
                            data,
                            hora,
                            temp,
                            rpm,
                            corrente,
                            registro.Evento);
                    }
                }
            }

            MessageBox.Show("Registros do motor salvos!");
        }
    }
}
