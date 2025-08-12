namespace Simulador_de_procesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerSimulacion = new System.Windows.Forms.Timer(this.components);
            this.tabLog = new System.Windows.Forms.TabPage();
            this.Resumen = new System.Windows.Forms.ListBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabCrearProceso = new System.Windows.Forms.TabPage();
            this.btnCrearProceso = new System.Windows.Forms.Button();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nudTamanio = new System.Windows.Forms.NumericUpDown();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.lblNomProceso = new System.Windows.Forms.Label();
            this.txtNombreProceso = new System.Windows.Forms.TextBox();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_teams = new System.Windows.Forms.Button();
            this.btn_discord = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.ListBox();
            this.lblDisco = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.progressDisco = new System.Windows.Forms.ProgressBar();
            this.progressMemoria = new System.Windows.Forms.ProgressBar();
            this.progressCPU = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLog.SuspendLayout();
            this.tabCrearProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).BeginInit();
            this.tabSimulacion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSimulacion
            // 
            this.timerSimulacion.Enabled = true;
            this.timerSimulacion.Interval = 1000;
            this.timerSimulacion.Tick += new System.EventHandler(this.timerSimulacion_Tick_1);
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabLog.Controls.Add(this.Resumen);
            this.tabLog.Controls.Add(this.btnReporte);
            this.tabLog.Location = new System.Drawing.Point(4, 27);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(768, 395);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            // 
            // Resumen
            // 
            this.Resumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.Resumen.ForeColor = System.Drawing.SystemColors.Menu;
            this.Resumen.FormattingEnabled = true;
            this.Resumen.ItemHeight = 18;
            this.Resumen.Location = new System.Drawing.Point(6, 6);
            this.Resumen.Name = "Resumen";
            this.Resumen.Size = new System.Drawing.Size(756, 256);
            this.Resumen.TabIndex = 8;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(248, 276);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(240, 52);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // tabCrearProceso
            // 
            this.tabCrearProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabCrearProceso.Controls.Add(this.btnCrearProceso);
            this.tabCrearProceso.Controls.Add(this.nudDuracion);
            this.tabCrearProceso.Controls.Add(this.lblDuracion);
            this.tabCrearProceso.Controls.Add(this.nudTamanio);
            this.tabCrearProceso.Controls.Add(this.lblTamanio);
            this.tabCrearProceso.Controls.Add(this.lblNomProceso);
            this.tabCrearProceso.Controls.Add(this.txtNombreProceso);
            this.tabCrearProceso.Location = new System.Drawing.Point(4, 27);
            this.tabCrearProceso.Name = "tabCrearProceso";
            this.tabCrearProceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearProceso.Size = new System.Drawing.Size(768, 395);
            this.tabCrearProceso.TabIndex = 1;
            this.tabCrearProceso.Text = "Crear Proceso";
            // 
            // btnCrearProceso
            // 
            this.btnCrearProceso.Location = new System.Drawing.Point(170, 185);
            this.btnCrearProceso.Name = "btnCrearProceso";
            this.btnCrearProceso.Size = new System.Drawing.Size(75, 23);
            this.btnCrearProceso.TabIndex = 6;
            this.btnCrearProceso.Text = "Crear";
            this.btnCrearProceso.UseVisualStyleBackColor = true;
            this.btnCrearProceso.Click += new System.EventHandler(this.btnCrearProceso_Click_1);
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(170, 101);
            this.nudDuracion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(120, 24);
            this.nudDuracion.TabIndex = 5;
            this.nudDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(76, 103);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(68, 18);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración";
            // 
            // nudTamanio
            // 
            this.nudTamanio.Location = new System.Drawing.Point(170, 136);
            this.nudTamanio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTamanio.Name = "nudTamanio";
            this.nudTamanio.Size = new System.Drawing.Size(120, 24);
            this.nudTamanio.TabIndex = 3;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(24, 140);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(146, 18);
            this.lblTamanio.TabIndex = 2;
            this.lblTamanio.Text = "Tamaño en memoria";
            // 
            // lblNomProceso
            // 
            this.lblNomProceso.AutoSize = true;
            this.lblNomProceso.Location = new System.Drawing.Point(41, 67);
            this.lblNomProceso.Name = "lblNomProceso";
            this.lblNomProceso.Size = new System.Drawing.Size(123, 18);
            this.lblNomProceso.TabIndex = 1;
            this.lblNomProceso.Text = "Nombre Proceso";
            // 
            // txtNombreProceso
            // 
            this.txtNombreProceso.Location = new System.Drawing.Point(170, 64);
            this.txtNombreProceso.Name = "txtNombreProceso";
            this.txtNombreProceso.Size = new System.Drawing.Size(120, 24);
            this.txtNombreProceso.TabIndex = 0;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabSimulacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabSimulacion.Controls.Add(this.btn_excel);
            this.tabSimulacion.Controls.Add(this.btn_teams);
            this.tabSimulacion.Controls.Add(this.btn_discord);
            this.tabSimulacion.Controls.Add(this.Log);
            this.tabSimulacion.Controls.Add(this.lblDisco);
            this.tabSimulacion.Controls.Add(this.lblMemoria);
            this.tabSimulacion.Controls.Add(this.lblCPU);
            this.tabSimulacion.Controls.Add(this.progressDisco);
            this.tabSimulacion.Controls.Add(this.progressMemoria);
            this.tabSimulacion.Controls.Add(this.progressCPU);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 27);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(857, 420);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "Simulación ";
            // 
            // btn_excel
            // 
            this.btn_excel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_excel.Image = global::Simulador_de_procesos.Properties.Resources.excel;
            this.btn_excel.Location = new System.Drawing.Point(179, 339);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(83, 57);
            this.btn_excel.TabIndex = 12;
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_teams
            // 
            this.btn_teams.Image = global::Simulador_de_procesos.Properties.Resources.Microsoft_Teams_6228c4fb14083__1_;
            this.btn_teams.Location = new System.Drawing.Point(90, 340);
            this.btn_teams.Name = "btn_teams";
            this.btn_teams.Size = new System.Drawing.Size(83, 57);
            this.btn_teams.TabIndex = 11;
            this.btn_teams.UseVisualStyleBackColor = true;
            this.btn_teams.Click += new System.EventHandler(this.btn_teams_Click);
            // 
            // btn_discord
            // 
            this.btn_discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(246)))));
            this.btn_discord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_discord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_discord.Image = global::Simulador_de_procesos.Properties.Resources.Discord_New_Logo;
            this.btn_discord.Location = new System.Drawing.Point(1, 340);
            this.btn_discord.Name = "btn_discord";
            this.btn_discord.Size = new System.Drawing.Size(83, 57);
            this.btn_discord.TabIndex = 10;
            this.btn_discord.UseVisualStyleBackColor = false;
            this.btn_discord.Click += new System.EventHandler(this.btn_discord_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.SystemColors.Menu;
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 16;
            this.Log.Location = new System.Drawing.Point(501, 6);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(311, 352);
            this.Log.TabIndex = 6;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(47, 112);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(47, 18);
            this.lblDisco.TabIndex = 5;
            this.lblDisco.Text = "Disco";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(47, 83);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(67, 18);
            this.lblMemoria.TabIndex = 4;
            this.lblMemoria.Text = "Memoria";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(47, 54);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(40, 18);
            this.lblCPU.TabIndex = 3;
            this.lblCPU.Text = "CPU";
            // 
            // progressDisco
            // 
            this.progressDisco.Location = new System.Drawing.Point(236, 112);
            this.progressDisco.Name = "progressDisco";
            this.progressDisco.Size = new System.Drawing.Size(100, 23);
            this.progressDisco.TabIndex = 2;
            // 
            // progressMemoria
            // 
            this.progressMemoria.Location = new System.Drawing.Point(236, 83);
            this.progressMemoria.Name = "progressMemoria";
            this.progressMemoria.Size = new System.Drawing.Size(100, 23);
            this.progressMemoria.TabIndex = 1;
            // 
            // progressCPU
            // 
            this.progressCPU.Location = new System.Drawing.Point(236, 54);
            this.progressCPU.Name = "progressCPU";
            this.progressCPU.Size = new System.Drawing.Size(100, 23);
            this.progressCPU.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimulacion);
            this.tabControl1.Controls.Add(this.tabCrearProceso);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Simulador de procesos";
            this.tabLog.ResumeLayout(false);
            this.tabCrearProceso.ResumeLayout(false);
            this.tabCrearProceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).EndInit();
            this.tabSimulacion.ResumeLayout(false);
            this.tabSimulacion.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSimulacion;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ListBox Resumen;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TabPage tabCrearProceso;
        private System.Windows.Forms.Button btnCrearProceso;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown nudTamanio;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.Label lblNomProceso;
        private System.Windows.Forms.TextBox txtNombreProceso;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_teams;
        private System.Windows.Forms.Button btn_discord;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ProgressBar progressDisco;
        private System.Windows.Forms.ProgressBar progressMemoria;
        private System.Windows.Forms.ProgressBar progressCPU;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

