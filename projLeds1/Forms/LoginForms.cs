using System;
using System.Windows.Forms;

using projLeds1.Models;

namespace projLeds1.Forms
{
    public partial class LoginForms : Form
    {

        public LoginForms()
        {
            InitializeComponent();
            this.Opacity = 0;
            timerFade.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnEntrar;
        }

        private string GerarSenha(string nome)
        {
            nome = nome.ToLower();

            if (nome == "nicollas")
                return "adm123";

            if (nome.Length < 3)
            {
                MessageBox.Show("O nome do funcionário deve ter pelo menos 3 caracteres!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return "";
            }

            string senha = "func" + nome;

            int len = nome.Length;

            char c1 = nome[len - 3];
            char c2 = nome[len - 2];
            char c3 = nome[len - 1];

            senha += LetraParaNumero(c1);
            senha += LetraParaNumero(c2);
            senha += LetraParaNumero(c3);

            return senha;
        }

        int LetraParaNumero(char c)
        {
            return (c - 'a') + 1;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtFuncionario.Text.Trim();
            string senhaDigitada = txtSenha.Text;

            string senhaCorreta = GerarSenha(nome);

            if (string.IsNullOrEmpty(senhaCorreta))
                return;

            if (senhaDigitada == senhaCorreta)
            {
                Usuario u = new Usuario();

                u.Nome = nome;
                u.Entrada = DateTime.Now;
                u.Foto = picturePerfil.Image;

                if (nome.ToLower() == "nicollas")
                    u.Funcao = "Administrador";
                else
                    u.Funcao = "Funcionário";

                Dashboard tela = new Dashboard(u);

                tela.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Senha incorreta!",
                    "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy  HH:mm:ss");
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                timerFade.Stop();
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            string nome =
        txtFuncionario.Text.ToLower();

            if (nome == "nicollas") 
             picturePerfil.Image = Properties.Resources.lonepfp;
           
            else 
                picturePerfil.Image = Properties.Resources.usedefault;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MessageBox.Show("Use o botão SAIR para fechar a aba.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
