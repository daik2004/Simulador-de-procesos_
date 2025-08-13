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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabCrearProceso = new System.Windows.Forms.TabPage();
            this.btnCrearProceso = new System.Windows.Forms.Button();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nudTamanio = new System.Windows.Forms.NumericUpDown();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.lblNomProceso = new System.Windows.Forms.Label();
            this.txtNombreProceso = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.github = new System.Windows.Forms.PictureBox();
            this.sql_server = new System.Windows.Forms.PictureBox();
            this.Visual_code = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.PictureBox();
            this.Visual_Studio = new System.Windows.Forms.PictureBox();
            this.pinterest = new System.Windows.Forms.PictureBox();
            this.excel = new System.Windows.Forms.PictureBox();
            this.discord = new System.Windows.Forms.PictureBox();
            this.teams = new System.Windows.Forms.PictureBox();
            this.Log = new System.Windows.Forms.ListBox();
            this.lblDisco = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.progressDisco = new System.Windows.Forms.ProgressBar();
            this.progressMemoria = new System.Windows.Forms.ProgressBar();
            this.progressCPU = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabCrearProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabSimulacion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql_server)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Studio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teams)).BeginInit();
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
            this.tabLog.Controls.Add(this.pictureBox5);
            this.tabLog.Location = new System.Drawing.Point(4, 27);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(838, 406);
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
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(268, 288);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(229, 40);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Simulador_de_procesos.Properties.Resources.Capturee1;
            this.pictureBox5.Location = new System.Drawing.Point(248, 276);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(278, 81);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
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
            this.tabCrearProceso.Controls.Add(this.pictureBox1);
            this.tabCrearProceso.Controls.Add(this.pictureBox2);
            this.tabCrearProceso.Controls.Add(this.pictureBox3);
            this.tabCrearProceso.Controls.Add(this.pictureBox4);
            this.tabCrearProceso.Location = new System.Drawing.Point(4, 27);
            this.tabCrearProceso.Name = "tabCrearProceso";
            this.tabCrearProceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearProceso.Size = new System.Drawing.Size(838, 406);
            this.tabCrearProceso.TabIndex = 1;
            this.tabCrearProceso.Text = "Crear Proceso";
            // 
            // btnCrearProceso
            // 
            this.btnCrearProceso.BackColor = System.Drawing.Color.White;
            this.btnCrearProceso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProceso.Location = new System.Drawing.Point(370, 319);
            this.btnCrearProceso.Name = "btnCrearProceso";
            this.btnCrearProceso.Size = new System.Drawing.Size(79, 43);
            this.btnCrearProceso.TabIndex = 6;
            this.btnCrearProceso.Text = "Crear";
            this.btnCrearProceso.UseVisualStyleBackColor = false;
            this.btnCrearProceso.Click += new System.EventHandler(this.btnCrearProceso_Click_1);
            // 
            // nudDuracion
            // 
            this.nudDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDuracion.Location = new System.Drawing.Point(170, 108);
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
            this.nudDuracion.Size = new System.Drawing.Size(155, 20);
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
            this.lblDuracion.Location = new System.Drawing.Point(74, 114);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(68, 18);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración";
            // 
            // nudTamanio
            // 
            this.nudTamanio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTamanio.Location = new System.Drawing.Point(170, 172);
            this.nudTamanio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTamanio.Name = "nudTamanio";
            this.nudTamanio.Size = new System.Drawing.Size(145, 20);
            this.nudTamanio.TabIndex = 3;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(12, 174);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(146, 18);
            this.lblTamanio.TabIndex = 2;
            this.lblTamanio.Text = "Tamaño en memoria";
            // 
            // lblNomProceso
            // 
            this.lblNomProceso.AutoSize = true;
            this.lblNomProceso.Location = new System.Drawing.Point(32, 67);
            this.lblNomProceso.Name = "lblNomProceso";
            this.lblNomProceso.Size = new System.Drawing.Size(123, 18);
            this.lblNomProceso.TabIndex = 1;
            this.lblNomProceso.Text = "Nombre Proceso";
            // 
            // txtNombreProceso
            // 
            this.txtNombreProceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProceso.Location = new System.Drawing.Point(170, 64);
            this.txtNombreProceso.Name = "txtNombreProceso";
            this.txtNombreProceso.Size = new System.Drawing.Size(155, 17);
            this.txtNombreProceso.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulador_de_procesos.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(148, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Simulador_de_procesos.Properties.Resources.Capture1;
            this.pictureBox2.Location = new System.Drawing.Point(160, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Simulador_de_procesos.Properties.Resources.Capture1;
            this.pictureBox3.Location = new System.Drawing.Point(160, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Simulador_de_procesos.Properties.Resources.Capturee;
            this.pictureBox4.Location = new System.Drawing.Point(336, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 81);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabSimulacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabSimulacion.Controls.Add(this.panel1);
            this.tabSimulacion.Controls.Add(this.Log);
            this.tabSimulacion.Controls.Add(this.lblDisco);
            this.tabSimulacion.Controls.Add(this.lblMemoria);
            this.tabSimulacion.Controls.Add(this.lblCPU);
            this.tabSimulacion.Controls.Add(this.progressDisco);
            this.tabSimulacion.Controls.Add(this.progressMemoria);
            this.tabSimulacion.Controls.Add(this.progressCPU);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 27);
            this.tabSimulacion.Margin = new System.Windows.Forms.Padding(0);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(838, 406);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "Simulación ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.github);
            this.panel1.Controls.Add(this.sql_server);
            this.panel1.Controls.Add(this.Visual_code);
            this.panel1.Controls.Add(this.word);
            this.panel1.Controls.Add(this.Visual_Studio);
            this.panel1.Controls.Add(this.pinterest);
            this.panel1.Controls.Add(this.excel);
            this.panel1.Controls.Add(this.discord);
            this.panel1.Controls.Add(this.teams);
            this.panel1.Location = new System.Drawing.Point(-2, 356);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 54);
            this.panel1.TabIndex = 17;
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.Color.White;
            this.github.Image = global::Simulador_de_procesos.Properties.Resources.imagen_2025_08_12_005519144;
            this.github.Location = new System.Drawing.Point(200, -2);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(43, 42);
            this.github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.github.TabIndex = 24;
            this.github.TabStop = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // sql_server
            // 
            this.sql_server.BackColor = System.Drawing.Color.White;
            this.sql_server.Image = global::Simulador_de_procesos.Properties.Resources.imagen_2025_08_12_005409742;
            this.sql_server.Location = new System.Drawing.Point(151, 0);
            this.sql_server.Name = "sql_server";
            this.sql_server.Size = new System.Drawing.Size(43, 42);
            this.sql_server.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sql_server.TabIndex = 23;
            this.sql_server.TabStop = false;
            this.sql_server.Click += new System.EventHandler(this.sql_server_Click);
            // 
            // Visual_code
            // 
            this.Visual_code.BackColor = System.Drawing.Color.White;
            this.Visual_code.Image = global::Simulador_de_procesos.Properties.Resources.imagen_2025_08_12_005212383;
            this.Visual_code.Location = new System.Drawing.Point(102, 0);
            this.Visual_code.Name = "Visual_code";
            this.Visual_code.Size = new System.Drawing.Size(43, 42);
            this.Visual_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Visual_code.TabIndex = 22;
            this.Visual_code.TabStop = false;
            this.Visual_code.Click += new System.EventHandler(this.Visual_code_Click);
            // 
            // word
            // 
            this.word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.word.Image = global::Simulador_de_procesos.Properties.Resources.imagen_2025_08_12_003831629;
            this.word.Location = new System.Drawing.Point(249, -4);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(44, 43);
            this.word.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.word.TabIndex = 21;
            this.word.TabStop = false;
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // Visual_Studio
            // 
            this.Visual_Studio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Visual_Studio.Image = global::Simulador_de_procesos.Properties.Resources.imagen_2025_08_12_003359819;
            this.Visual_Studio.Location = new System.Drawing.Point(49, 0);
            this.Visual_Studio.Name = "Visual_Studio";
            this.Visual_Studio.Size = new System.Drawing.Size(44, 43);
            this.Visual_Studio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Visual_Studio.TabIndex = 20;
            this.Visual_Studio.TabStop = false;
            this.Visual_Studio.Click += new System.EventHandler(this.Visual_Studio_Click);
            // 
            // pinterest
            // 
            this.pinterest.BackColor = System.Drawing.Color.White;
            this.pinterest.Image = global::Simulador_de_procesos.Properties.Resources.pinterest;
            this.pinterest.Location = new System.Drawing.Point(395, 0);
            this.pinterest.Name = "pinterest";
            this.pinterest.Size = new System.Drawing.Size(46, 37);
            this.pinterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pinterest.TabIndex = 19;
            this.pinterest.TabStop = false;
            this.pinterest.Click += new System.EventHandler(this.pinterest_Click);
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.White;
            this.excel.Image = global::Simulador_de_procesos.Properties.Resources.sobresalir;
            this.excel.Location = new System.Drawing.Point(299, 0);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(38, 41);
            this.excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.excel.TabIndex = 18;
            this.excel.TabStop = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // discord
            // 
            this.discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.discord.Image = global::Simulador_de_procesos.Properties.Resources.discorddd;
            this.discord.Location = new System.Drawing.Point(343, -4);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(46, 44);
            this.discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.discord.TabIndex = 14;
            this.discord.TabStop = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // teams
            // 
            this.teams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.teams.Image = global::Simulador_de_procesos.Properties.Resources.images;
            this.teams.Location = new System.Drawing.Point(3, 3);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(40, 37);
            this.teams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.teams.TabIndex = 15;
            this.teams.TabStop = false;
            this.teams.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.SystemColors.Menu;
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 16;
            this.Log.Location = new System.Drawing.Point(393, 6);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(421, 352);
            this.Log.TabIndex = 6;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(47, 147);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(47, 18);
            this.lblDisco.TabIndex = 5;
            this.lblDisco.Text = "Disco";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(44, 89);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(67, 18);
            this.lblMemoria.TabIndex = 4;
            this.lblMemoria.Text = "Memoria";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(47, 30);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(40, 18);
            this.lblCPU.TabIndex = 3;
            this.lblCPU.Text = "CPU";
            // 
            // progressDisco
            // 
            this.progressDisco.Location = new System.Drawing.Point(47, 168);
            this.progressDisco.Name = "progressDisco";
            this.progressDisco.Size = new System.Drawing.Size(226, 30);
            this.progressDisco.TabIndex = 2;
            // 
            // progressMemoria
            // 
            this.progressMemoria.Location = new System.Drawing.Point(47, 110);
            this.progressMemoria.Name = "progressMemoria";
            this.progressMemoria.Size = new System.Drawing.Size(226, 30);
            this.progressMemoria.TabIndex = 1;
            // 
            // progressCPU
            // 
            this.progressCPU.Location = new System.Drawing.Point(47, 51);
            this.progressCPU.Name = "progressCPU";
            this.progressCPU.Size = new System.Drawing.Size(226, 30);
            this.progressCPU.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimulacion);
            this.tabControl1.Controls.Add(this.tabCrearProceso);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Image = global::Simulador_de_procesos.Properties.Resources.exit_5440572;
            this.btn_cerrar.Location = new System.Drawing.Point(780, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(38, 38);
            this.btn_cerrar.TabIndex = 18;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Simulador de procesos";
            this.tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabCrearProceso.ResumeLayout(false);
            this.tabCrearProceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabSimulacion.ResumeLayout(false);
            this.tabSimulacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql_server)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Studio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teams)).EndInit();
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
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ProgressBar progressDisco;
        private System.Windows.Forms.ProgressBar progressMemoria;
        private System.Windows.Forms.ProgressBar progressCPU;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox discord;
        private System.Windows.Forms.PictureBox teams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox excel;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.PictureBox pinterest;
        private System.Windows.Forms.PictureBox word;
        private System.Windows.Forms.PictureBox Visual_Studio;
        private System.Windows.Forms.PictureBox Visual_code;
        private System.Windows.Forms.PictureBox sql_server;
        private System.Windows.Forms.PictureBox github;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

