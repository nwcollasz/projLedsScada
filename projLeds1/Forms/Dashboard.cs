using projLeds1.Core;
using projLeds1.Models;
using System;
using System.Windows.Forms;

namespace projLeds1.Forms
{
    public partial class Dashboard : Form
    {
        private Usuario usuario;
        private ControleLeds telaLED;

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

            lblEntrada.Text = $"Entrada: {usuario.Entrada:dd/MM/yyyy HH:mm:ss}";

            picturePerfil.Image = usuario.Foto;

            lblStatus.Text = "🟢 SISTEMA ONLINE";

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
                telaLED = new ControleLeds(usuario, this);
            }

            telaLED.Show();

            telaLED.BringToFront();
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
                $"TEMP: {SistemaGlobal.TemperaturaLEDs:F1} °C";

            lblAtivosLED.Text =
                $"ATIVOS: {SistemaGlobal.LEDsAtivos}";

            lblStatusLED.Text =
                $"STATUS: {SistemaGlobal.StatusLEDs}";
        }

     
    }
}
