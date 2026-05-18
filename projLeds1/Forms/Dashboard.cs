using projLeds1.Core;
using projLeds1.Models;
using projLeds1.Services;
using System;
using System.Windows.Forms;

namespace projLeds1.Forms
{
    public partial class Dashboard : Form
    {
        private Usuario usuario;
        private ControleLeds telaLED;
        private MotorForm telaMotor;

        private LedService ledService;
        private MotorService motor;

        public Dashboard(Usuario u)
        {
            InitializeComponent();

            usuario = u;

            this.Load += Dashboard_Load;

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblNome.Text = $"Usuário: {usuario.Nome}";

            lblFuncao.Text = $"Função: {usuario.Funcao}";

            lblEntrada.Text = $"{usuario.Entrada:dd/MM/yyyy HH:mm:ss}";

            picturePerfil.Image = usuario.Foto;

            lblStatus.Text = "🟢 SISTEMA ONLINE";

            motor = new MotorService();
            ledService = new LedService();

            timerHora.Start();

            timerDashboard.Start();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy  HH:mm:ss");
        }

        private void BtnAbrirLED_Click(object sender, EventArgs e)
        {
            if (telaLED == null || telaLED.IsDisposed)
            {
                telaLED = new ControleLeds(ledService, usuario, this);
            }

            telaLED.Show();

            telaLED.BringToFront();
        }

        private void BtnAbrirMotor_Click(object sender, EventArgs e)
        {
            if (telaMotor == null || telaMotor.IsDisposed)
            {
                telaMotor = new MotorForm(motor, usuario, this);
            }
            telaMotor.Show();
            telaMotor.BringToFront();
        }

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

        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            lblTempLED.Text =
                $"TEMP: {ledService.Dados.Temperatura:F1} °C";

            lblAtivosLED.Text =
                $"ATIVOS: {ledService.Dados.LEDsAtivos}";

            lblStatusLED.Text =
                $"STATUS: {ledService.Dados.Status}";

          
            lblStatusMotor.Text =
                $"STATUS: {motor.Dados.Status}";

            lblRPMMotor.Text =
                $"RPM: {motor.Dados.RPM:F2}";

            lblCorrenteMotor.Text =
                $"CORRENTE: {motor.Dados.Corrente:F2} A";

            lblTempMotor.Text =
                $"TEMP: {motor.Dados.Temperatura:F1} °C";
        }

     
    }
}
