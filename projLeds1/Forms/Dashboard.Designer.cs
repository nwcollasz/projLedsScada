namespace projLeds1.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.panelLed = new System.Windows.Forms.Panel();
            this.btnAbrirLED = new System.Windows.Forms.Button();
            this.lblAtivosLED = new System.Windows.Forms.Label();
            this.lblTempLED = new System.Windows.Forms.Label();
            this.lblStatusLED = new System.Windows.Forms.Label();
            this.lblSetorNome = new System.Windows.Forms.Label();
            this.panelMotor = new System.Windows.Forms.Panel();
            this.lblCorrenteMotor = new System.Windows.Forms.Label();
            this.btnAbrirMotor = new System.Windows.Forms.Button();
            this.lblTempMotor = new System.Windows.Forms.Label();
            this.lblSetorNome3 = new System.Windows.Forms.Label();
            this.lblRPMMotor = new System.Windows.Forms.Label();
            this.lblStatusMotor = new System.Windows.Forms.Label();
            this.panelTanque = new System.Windows.Forms.Panel();
            this.btnAbrirTanque = new System.Windows.Forms.Button();
            this.lblPressaoTanque = new System.Windows.Forms.Label();
            this.lblNivelTanque = new System.Windows.Forms.Label();
            this.lblStatusTanque = new System.Windows.Forms.Label();
            this.lblSetorNome2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.panelLed.SuspendLayout();
            this.panelMotor.SuspendLayout();
            this.panelTanque.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblEntrada.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEntrada.Location = new System.Drawing.Point(132, 151);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(72, 19);
            this.lblEntrada.TabIndex = 49;
            this.lblEntrada.Text = "ENTRADA:";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncao.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblFuncao.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFuncao.Location = new System.Drawing.Point(132, 77);
            this.lblFuncao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(68, 19);
            this.lblFuncao.TabIndex = 48;
            this.lblFuncao.Text = "FUNÇÃO:";
            this.lblFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblNome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNome.Location = new System.Drawing.Point(132, 58);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 19);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "NOME:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Location = new System.Drawing.Point(9, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 23);
            this.label12.TabIndex = 46;
            this.label12.Text = "Dashboard";
            // 
            // picturePerfil
            // 
            this.picturePerfil.BackColor = System.Drawing.Color.Transparent;
            this.picturePerfil.Image = global::projLeds1.Properties.Resources.usedefault;
            this.picturePerfil.Location = new System.Drawing.Point(13, 58);
            this.picturePerfil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(111, 112);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePerfil.TabIndex = 45;
            this.picturePerfil.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHora.Location = new System.Drawing.Point(10, 340);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(147, 39);
            this.lblHora.TabIndex = 50;
            this.lblHora.Text = "DataHora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(967, 356);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 51;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(301, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 15);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "STATUSISTEMA";
            // 
            // timerDashboard
            // 
            this.timerDashboard.Enabled = true;
            this.timerDashboard.Interval = 500;
            this.timerDashboard.Tick += new System.EventHandler(this.timerDashboard_Tick);
            // 
            // panelLed
            // 
            this.panelLed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLed.Controls.Add(this.btnAbrirLED);
            this.panelLed.Controls.Add(this.lblAtivosLED);
            this.panelLed.Controls.Add(this.lblTempLED);
            this.panelLed.Controls.Add(this.lblStatusLED);
            this.panelLed.Controls.Add(this.lblSetorNome);
            this.panelLed.Location = new System.Drawing.Point(295, 58);
            this.panelLed.Name = "panelLed";
            this.panelLed.Size = new System.Drawing.Size(213, 269);
            this.panelLed.TabIndex = 53;
            // 
            // btnAbrirLED
            // 
            this.btnAbrirLED.Location = new System.Drawing.Point(69, 224);
            this.btnAbrirLED.Name = "btnAbrirLED";
            this.btnAbrirLED.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirLED.TabIndex = 4;
            this.btnAbrirLED.Text = "Abrir";
            this.btnAbrirLED.UseVisualStyleBackColor = true;
            this.btnAbrirLED.Click += new System.EventHandler(this.BtnAbrirLED_Click);
            // 
            // lblAtivosLED
            // 
            this.lblAtivosLED.AutoSize = true;
            this.lblAtivosLED.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivosLED.ForeColor = System.Drawing.Color.White;
            this.lblAtivosLED.Location = new System.Drawing.Point(16, 134);
            this.lblAtivosLED.Name = "lblAtivosLED";
            this.lblAtivosLED.Size = new System.Drawing.Size(53, 15);
            this.lblAtivosLED.TabIndex = 3;
            this.lblAtivosLED.Text = "ATIVOS:";
            this.lblAtivosLED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTempLED
            // 
            this.lblTempLED.AutoSize = true;
            this.lblTempLED.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempLED.ForeColor = System.Drawing.Color.White;
            this.lblTempLED.Location = new System.Drawing.Point(16, 97);
            this.lblTempLED.Name = "lblTempLED";
            this.lblTempLED.Size = new System.Drawing.Size(101, 15);
            this.lblTempLED.TabIndex = 2;
            this.lblTempLED.Text = "TEMPERATURA:";
            this.lblTempLED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusLED
            // 
            this.lblStatusLED.AutoSize = true;
            this.lblStatusLED.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLED.ForeColor = System.Drawing.Color.White;
            this.lblStatusLED.Location = new System.Drawing.Point(16, 60);
            this.lblStatusLED.Name = "lblStatusLED";
            this.lblStatusLED.Size = new System.Drawing.Size(54, 15);
            this.lblStatusLED.TabIndex = 1;
            this.lblStatusLED.Text = "STATUS:";
            this.lblStatusLED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSetorNome
            // 
            this.lblSetorNome.AutoSize = true;
            this.lblSetorNome.BackColor = System.Drawing.Color.Transparent;
            this.lblSetorNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetorNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSetorNome.Location = new System.Drawing.Point(15, 13);
            this.lblSetorNome.Name = "lblSetorNome";
            this.lblSetorNome.Size = new System.Drawing.Size(89, 19);
            this.lblSetorNome.TabIndex = 0;
            this.lblSetorNome.Text = "Sistema LED";
            // 
            // panelMotor
            // 
            this.panelMotor.BackColor = System.Drawing.Color.Black;
            this.panelMotor.Controls.Add(this.lblCorrenteMotor);
            this.panelMotor.Controls.Add(this.btnAbrirMotor);
            this.panelMotor.Controls.Add(this.lblTempMotor);
            this.panelMotor.Controls.Add(this.lblSetorNome3);
            this.panelMotor.Controls.Add(this.lblRPMMotor);
            this.panelMotor.Controls.Add(this.lblStatusMotor);
            this.panelMotor.Location = new System.Drawing.Point(514, 58);
            this.panelMotor.Name = "panelMotor";
            this.panelMotor.Size = new System.Drawing.Size(213, 269);
            this.panelMotor.TabIndex = 54;
            // 
            // lblCorrenteMotor
            // 
            this.lblCorrenteMotor.AutoSize = true;
            this.lblCorrenteMotor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrenteMotor.ForeColor = System.Drawing.Color.White;
            this.lblCorrenteMotor.Location = new System.Drawing.Point(16, 172);
            this.lblCorrenteMotor.Name = "lblCorrenteMotor";
            this.lblCorrenteMotor.Size = new System.Drawing.Size(74, 15);
            this.lblCorrenteMotor.TabIndex = 8;
            this.lblCorrenteMotor.Text = "CORRENTE:";
            this.lblCorrenteMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAbrirMotor
            // 
            this.btnAbrirMotor.Location = new System.Drawing.Point(69, 224);
            this.btnAbrirMotor.Name = "btnAbrirMotor";
            this.btnAbrirMotor.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirMotor.TabIndex = 7;
            this.btnAbrirMotor.Text = "Abrir";
            this.btnAbrirMotor.UseVisualStyleBackColor = true;
            this.btnAbrirMotor.Click += new System.EventHandler(this.BtnAbrirMotor_Click);
            // 
            // lblTempMotor
            // 
            this.lblTempMotor.AutoSize = true;
            this.lblTempMotor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMotor.ForeColor = System.Drawing.Color.White;
            this.lblTempMotor.Location = new System.Drawing.Point(16, 97);
            this.lblTempMotor.Name = "lblTempMotor";
            this.lblTempMotor.Size = new System.Drawing.Size(101, 15);
            this.lblTempMotor.TabIndex = 6;
            this.lblTempMotor.Text = "TEMPERATURA:";
            this.lblTempMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSetorNome3
            // 
            this.lblSetorNome3.AutoSize = true;
            this.lblSetorNome3.BackColor = System.Drawing.Color.Transparent;
            this.lblSetorNome3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetorNome3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSetorNome3.Location = new System.Drawing.Point(15, 13);
            this.lblSetorNome3.Name = "lblSetorNome3";
            this.lblSetorNome3.Size = new System.Drawing.Size(98, 19);
            this.lblSetorNome3.TabIndex = 2;
            this.lblSetorNome3.Text = "Motor Elétrico";
            // 
            // lblRPMMotor
            // 
            this.lblRPMMotor.AutoSize = true;
            this.lblRPMMotor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPMMotor.ForeColor = System.Drawing.Color.White;
            this.lblRPMMotor.Location = new System.Drawing.Point(16, 134);
            this.lblRPMMotor.Name = "lblRPMMotor";
            this.lblRPMMotor.Size = new System.Drawing.Size(37, 15);
            this.lblRPMMotor.TabIndex = 5;
            this.lblRPMMotor.Text = "RPM:";
            this.lblRPMMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusMotor
            // 
            this.lblStatusMotor.AutoSize = true;
            this.lblStatusMotor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMotor.ForeColor = System.Drawing.Color.White;
            this.lblStatusMotor.Location = new System.Drawing.Point(16, 60);
            this.lblStatusMotor.Name = "lblStatusMotor";
            this.lblStatusMotor.Size = new System.Drawing.Size(54, 15);
            this.lblStatusMotor.TabIndex = 4;
            this.lblStatusMotor.Text = "STATUS:";
            this.lblStatusMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTanque
            // 
            this.panelTanque.BackColor = System.Drawing.Color.Black;
            this.panelTanque.Controls.Add(this.btnAbrirTanque);
            this.panelTanque.Controls.Add(this.lblPressaoTanque);
            this.panelTanque.Controls.Add(this.lblNivelTanque);
            this.panelTanque.Controls.Add(this.lblStatusTanque);
            this.panelTanque.Controls.Add(this.lblSetorNome2);
            this.panelTanque.Location = new System.Drawing.Point(733, 58);
            this.panelTanque.Name = "panelTanque";
            this.panelTanque.Size = new System.Drawing.Size(213, 269);
            this.panelTanque.TabIndex = 55;
            // 
            // btnAbrirTanque
            // 
            this.btnAbrirTanque.Location = new System.Drawing.Point(69, 224);
            this.btnAbrirTanque.Name = "btnAbrirTanque";
            this.btnAbrirTanque.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirTanque.TabIndex = 10;
            this.btnAbrirTanque.Text = "Abrir";
            this.btnAbrirTanque.UseVisualStyleBackColor = true;
            // 
            // lblPressaoTanque
            // 
            this.lblPressaoTanque.AutoSize = true;
            this.lblPressaoTanque.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressaoTanque.ForeColor = System.Drawing.Color.White;
            this.lblPressaoTanque.Location = new System.Drawing.Point(16, 134);
            this.lblPressaoTanque.Name = "lblPressaoTanque";
            this.lblPressaoTanque.Size = new System.Drawing.Size(35, 15);
            this.lblPressaoTanque.TabIndex = 9;
            this.lblPressaoTanque.Text = "label7";
            this.lblPressaoTanque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNivelTanque
            // 
            this.lblNivelTanque.AutoSize = true;
            this.lblNivelTanque.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelTanque.ForeColor = System.Drawing.Color.White;
            this.lblNivelTanque.Location = new System.Drawing.Point(16, 97);
            this.lblNivelTanque.Name = "lblNivelTanque";
            this.lblNivelTanque.Size = new System.Drawing.Size(35, 15);
            this.lblNivelTanque.TabIndex = 8;
            this.lblNivelTanque.Text = "label8";
            this.lblNivelTanque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusTanque
            // 
            this.lblStatusTanque.AutoSize = true;
            this.lblStatusTanque.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTanque.ForeColor = System.Drawing.Color.White;
            this.lblStatusTanque.Location = new System.Drawing.Point(16, 60);
            this.lblStatusTanque.Name = "lblStatusTanque";
            this.lblStatusTanque.Size = new System.Drawing.Size(35, 15);
            this.lblStatusTanque.TabIndex = 7;
            this.lblStatusTanque.Text = "label9";
            this.lblStatusTanque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSetorNome2
            // 
            this.lblSetorNome2.AutoSize = true;
            this.lblSetorNome2.BackColor = System.Drawing.Color.Transparent;
            this.lblSetorNome2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetorNome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSetorNome2.Location = new System.Drawing.Point(15, 13);
            this.lblSetorNome2.Name = "lblSetorNome2";
            this.lblSetorNome2.Size = new System.Drawing.Size(53, 19);
            this.lblSetorNome2.TabIndex = 2;
            this.lblSetorNome2.Text = "Tanque";
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 388);
            this.Controls.Add(this.panelMotor);
            this.Controls.Add(this.panelTanque);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.picturePerfil);
            this.Controls.Add(this.panelLed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.panelLed.ResumeLayout(false);
            this.panelLed.PerformLayout();
            this.panelMotor.ResumeLayout(false);
            this.panelMotor.PerformLayout();
            this.panelTanque.ResumeLayout(false);
            this.panelTanque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerDashboard;
        private System.Windows.Forms.Panel panelLed;
        private System.Windows.Forms.Panel panelMotor;
        private System.Windows.Forms.Panel panelTanque;
        private System.Windows.Forms.Label lblSetorNome;
        private System.Windows.Forms.Label lblSetorNome2;
        private System.Windows.Forms.Label lblSetorNome3;
        private System.Windows.Forms.Label lblAtivosLED;
        private System.Windows.Forms.Label lblTempLED;
        private System.Windows.Forms.Label lblStatusLED;
        private System.Windows.Forms.Label lblTempMotor;
        private System.Windows.Forms.Label lblRPMMotor;
        private System.Windows.Forms.Label lblStatusMotor;
        private System.Windows.Forms.Label lblPressaoTanque;
        private System.Windows.Forms.Label lblNivelTanque;
        private System.Windows.Forms.Label lblStatusTanque;
        private System.Windows.Forms.Button btnAbrirLED;
        private System.Windows.Forms.Button btnAbrirMotor;
        private System.Windows.Forms.Button btnAbrirTanque;
        private System.Windows.Forms.Label lblCorrenteMotor;
    }
}