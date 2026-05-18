namespace projLeds1.Forms
{
    partial class MotorForm
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
            this.progressRPM = new System.Windows.Forms.ProgressBar();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.progressTemp = new System.Windows.Forms.ProgressBar();
            this.lblCorrente = new System.Windows.Forms.Label();
            this.progressCorrente = new System.Windows.Forms.ProgressBar();
            this.trackRPM = new System.Windows.Forms.TrackBar();
            this.panelVerde = new System.Windows.Forms.Panel();
            this.panelAmarelo = new System.Windows.Forms.Panel();
            this.panelVermelho = new System.Windows.Forms.Panel();
            this.pictureMotor = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.timerMotor = new System.Windows.Forms.Timer(this.components);
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.btnSQLite = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnExportarLog = new System.Windows.Forms.Button();
            this.lblHz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblEntrada.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEntrada.Location = new System.Drawing.Point(131, 151);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(69, 19);
            this.lblEntrada.TabIndex = 49;
            this.lblEntrada.Text = "ENTRADA";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncao.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblFuncao.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFuncao.Location = new System.Drawing.Point(131, 82);
            this.lblFuncao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(65, 19);
            this.lblFuncao.TabIndex = 48;
            this.lblFuncao.Text = "FUNÇÃO";
            this.lblFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblNome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNome.Location = new System.Drawing.Point(131, 58);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "NOME";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Location = new System.Drawing.Point(9, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 27);
            this.label12.TabIndex = 46;
            this.label12.Text = "Motor Elétrico";
            // 
            // progressRPM
            // 
            this.progressRPM.Location = new System.Drawing.Point(310, 214);
            this.progressRPM.Name = "progressRPM";
            this.progressRPM.Size = new System.Drawing.Size(160, 23);
            this.progressRPM.TabIndex = 51;
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblRPM.ForeColor = System.Drawing.Color.Azure;
            this.lblRPM.Location = new System.Drawing.Point(306, 192);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(38, 19);
            this.lblRPM.TabIndex = 52;
            this.lblRPM.Text = "RPM";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblTemp.ForeColor = System.Drawing.Color.Azure;
            this.lblTemp.Location = new System.Drawing.Point(306, 256);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(44, 19);
            this.lblTemp.TabIndex = 54;
            this.lblTemp.Text = "TEMP";
            // 
            // progressTemp
            // 
            this.progressTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressTemp.Location = new System.Drawing.Point(310, 278);
            this.progressTemp.Name = "progressTemp";
            this.progressTemp.Size = new System.Drawing.Size(160, 23);
            this.progressTemp.TabIndex = 53;
            // 
            // lblCorrente
            // 
            this.lblCorrente.AutoSize = true;
            this.lblCorrente.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblCorrente.ForeColor = System.Drawing.Color.Azure;
            this.lblCorrente.Location = new System.Drawing.Point(306, 321);
            this.lblCorrente.Name = "lblCorrente";
            this.lblCorrente.Size = new System.Drawing.Size(76, 19);
            this.lblCorrente.TabIndex = 56;
            this.lblCorrente.Text = "CORRENTE";
            // 
            // progressCorrente
            // 
            this.progressCorrente.Location = new System.Drawing.Point(310, 343);
            this.progressCorrente.Name = "progressCorrente";
            this.progressCorrente.Size = new System.Drawing.Size(160, 23);
            this.progressCorrente.TabIndex = 55;
            // 
            // trackRPM
            // 
            this.trackRPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.trackRPM.Location = new System.Drawing.Point(496, 214);
            this.trackRPM.Name = "trackRPM";
            this.trackRPM.Size = new System.Drawing.Size(123, 45);
            this.trackRPM.TabIndex = 57;
            this.trackRPM.Scroll += new System.EventHandler(this.trackRPM_Scroll);
            // 
            // panelVerde
            // 
            this.panelVerde.Location = new System.Drawing.Point(496, 278);
            this.panelVerde.Name = "panelVerde";
            this.panelVerde.Size = new System.Drawing.Size(123, 23);
            this.panelVerde.TabIndex = 58;
            // 
            // panelAmarelo
            // 
            this.panelAmarelo.Location = new System.Drawing.Point(496, 311);
            this.panelAmarelo.Name = "panelAmarelo";
            this.panelAmarelo.Size = new System.Drawing.Size(123, 23);
            this.panelAmarelo.TabIndex = 59;
            // 
            // panelVermelho
            // 
            this.panelVermelho.Location = new System.Drawing.Point(496, 343);
            this.panelVermelho.Name = "panelVermelho";
            this.panelVermelho.Size = new System.Drawing.Size(123, 23);
            this.panelVermelho.TabIndex = 60;
            // 
            // pictureMotor
            // 
            this.pictureMotor.Image = global::projLeds1.Properties.Resources.giroMotor2_off;
            this.pictureMotor.Location = new System.Drawing.Point(310, 14);
            this.pictureMotor.Name = "pictureMotor";
            this.pictureMotor.Size = new System.Drawing.Size(309, 156);
            this.pictureMotor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMotor.TabIndex = 50;
            this.pictureMotor.TabStop = false;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsuario.Image = global::projLeds1.Properties.Resources.usedefault;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(13, 58);
            this.pictureBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(111, 112);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 45;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(310, 447);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(75, 23);
            this.btnLigar.TabIndex = 61;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(395, 447);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(75, 23);
            this.btnDesligar.TabIndex = 62;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(13, 447);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.Text = "←";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // timerMotor
            // 
            this.timerMotor.Tick += new System.EventHandler(this.timerMotor_Tick);
            // 
            // dgvEventos
            // 
            this.dgvEventos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(12, 192);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(225, 150);
            this.dgvEventos.TabIndex = 65;
            // 
            // btnSQLite
            // 
            this.btnSQLite.BackColor = System.Drawing.Color.DarkGray;
            this.btnSQLite.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLite.ForeColor = System.Drawing.Color.Black;
            this.btnSQLite.Image = global::projLeds1.Properties.Resources.icons8_database_export_50;
            this.btnSQLite.Location = new System.Drawing.Point(168, 348);
            this.btnSQLite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSQLite.Name = "btnSQLite";
            this.btnSQLite.Size = new System.Drawing.Size(69, 64);
            this.btnSQLite.TabIndex = 68;
            this.btnSQLite.UseVisualStyleBackColor = false;
            this.btnSQLite.Click += new System.EventHandler(this.btnSalvarSQLite_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.DarkGray;
            this.btnHistorico.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Black;
            this.btnHistorico.Image = global::projLeds1.Properties.Resources.icons8_xls_50;
            this.btnHistorico.Location = new System.Drawing.Point(91, 348);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(69, 64);
            this.btnHistorico.TabIndex = 67;
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnExportarLog
            // 
            this.btnExportarLog.BackColor = System.Drawing.Color.DarkGray;
            this.btnExportarLog.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarLog.ForeColor = System.Drawing.Color.Black;
            this.btnExportarLog.Image = global::projLeds1.Properties.Resources.icons8_activity_history_50;
            this.btnExportarLog.Location = new System.Drawing.Point(14, 348);
            this.btnExportarLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportarLog.Name = "btnExportarLog";
            this.btnExportarLog.Size = new System.Drawing.Size(69, 64);
            this.btnExportarLog.TabIndex = 66;
            this.btnExportarLog.UseVisualStyleBackColor = false;
            this.btnExportarLog.Click += new System.EventHandler(this.btnExportarLog_Click);
            // 
            // lblHz
            // 
            this.lblHz.AutoSize = true;
            this.lblHz.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblHz.ForeColor = System.Drawing.Color.Azure;
            this.lblHz.Location = new System.Drawing.Point(502, 192);
            this.lblHz.Name = "lblHz";
            this.lblHz.Size = new System.Drawing.Size(45, 19);
            this.lblHz.TabIndex = 69;
            this.lblHz.Text = "FREQ:";
            // 
            // MotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(681, 482);
            this.Controls.Add(this.lblHz);
            this.Controls.Add(this.btnSQLite);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnExportarLog);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.panelVermelho);
            this.Controls.Add(this.panelAmarelo);
            this.Controls.Add(this.panelVerde);
            this.Controls.Add(this.trackRPM);
            this.Controls.Add(this.lblCorrente);
            this.Controls.Add(this.progressCorrente);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.progressTemp);
            this.Controls.Add(this.lblRPM);
            this.Controls.Add(this.progressRPM);
            this.Controls.Add(this.pictureMotor);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBoxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotorForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.trackRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.PictureBox pictureMotor;
        private System.Windows.Forms.ProgressBar progressRPM;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.ProgressBar progressTemp;
        private System.Windows.Forms.Label lblCorrente;
        private System.Windows.Forms.ProgressBar progressCorrente;
        private System.Windows.Forms.TrackBar trackRPM;
        private System.Windows.Forms.Panel panelVerde;
        private System.Windows.Forms.Panel panelAmarelo;
        private System.Windows.Forms.Panel panelVermelho;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer timerMotor;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Button btnSQLite;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnExportarLog;
        private System.Windows.Forms.Label lblHz;
    }
}