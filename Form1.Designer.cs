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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.Log = new System.Windows.Forms.ListBox();
            this.lblDisco = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.progressDisco = new System.Windows.Forms.ProgressBar();
            this.progressMemoria = new System.Windows.Forms.ProgressBar();
            this.progressCPU = new System.Windows.Forms.ProgressBar();
            this.tabCrearProceso = new System.Windows.Forms.TabPage();
            this.btnCrearProceso = new System.Windows.Forms.Button();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nudTamanio = new System.Windows.Forms.NumericUpDown();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.lblNomProceso = new System.Windows.Forms.Label();
            this.txtNombreProceso = new System.Windows.Forms.TextBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.Resumen = new System.Windows.Forms.ListBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.timerSimulacion = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabSimulacion.SuspendLayout();
            this.tabCrearProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).BeginInit();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimulacion);
            this.tabControl1.Controls.Add(this.tabCrearProceso);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Controls.Add(this.Log);
            this.tabSimulacion.Controls.Add(this.lblDisco);
            this.tabSimulacion.Controls.Add(this.lblMemoria);
            this.tabSimulacion.Controls.Add(this.lblCPU);
            this.tabSimulacion.Controls.Add(this.progressDisco);
            this.tabSimulacion.Controls.Add(this.progressMemoria);
            this.tabSimulacion.Controls.Add(this.progressCPU);
            this.tabSimulacion.Location = new System.Drawing.Point(4, 22);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(768, 400);
            this.tabSimulacion.TabIndex = 0;
            this.tabSimulacion.Text = "Simulación ";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.FormattingEnabled = true;
            this.Log.Location = new System.Drawing.Point(451, 6);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(311, 381);
            this.Log.TabIndex = 6;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(47, 112);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(34, 13);
            this.lblDisco.TabIndex = 5;
            this.lblDisco.Text = "Disco";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(34, 83);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(47, 13);
            this.lblMemoria.TabIndex = 4;
            this.lblMemoria.Text = "Memoria";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(52, 54);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(29, 13);
            this.lblCPU.TabIndex = 3;
            this.lblCPU.Text = "CPU";
            // 
            // progressDisco
            // 
            this.progressDisco.Location = new System.Drawing.Point(184, 112);
            this.progressDisco.Name = "progressDisco";
            this.progressDisco.Size = new System.Drawing.Size(100, 23);
            this.progressDisco.TabIndex = 2;
            // 
            // progressMemoria
            // 
            this.progressMemoria.Location = new System.Drawing.Point(184, 83);
            this.progressMemoria.Name = "progressMemoria";
            this.progressMemoria.Size = new System.Drawing.Size(100, 23);
            this.progressMemoria.TabIndex = 1;
            // 
            // progressCPU
            // 
            this.progressCPU.Location = new System.Drawing.Point(184, 54);
            this.progressCPU.Name = "progressCPU";
            this.progressCPU.Size = new System.Drawing.Size(100, 23);
            this.progressCPU.TabIndex = 0;
            // 
            // tabCrearProceso
            // 
            this.tabCrearProceso.Controls.Add(this.btnCrearProceso);
            this.tabCrearProceso.Controls.Add(this.nudDuracion);
            this.tabCrearProceso.Controls.Add(this.lblDuracion);
            this.tabCrearProceso.Controls.Add(this.nudTamanio);
            this.tabCrearProceso.Controls.Add(this.lblTamanio);
            this.tabCrearProceso.Controls.Add(this.lblNomProceso);
            this.tabCrearProceso.Controls.Add(this.txtNombreProceso);
            this.tabCrearProceso.Location = new System.Drawing.Point(4, 22);
            this.tabCrearProceso.Name = "tabCrearProceso";
            this.tabCrearProceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearProceso.Size = new System.Drawing.Size(768, 400);
            this.tabCrearProceso.TabIndex = 1;
            this.tabCrearProceso.Text = "Crear Proceso";
            this.tabCrearProceso.UseVisualStyleBackColor = true;
            // 
            // btnCrearProceso
            // 
            this.btnCrearProceso.Location = new System.Drawing.Point(151, 195);
            this.btnCrearProceso.Name = "btnCrearProceso";
            this.btnCrearProceso.Size = new System.Drawing.Size(75, 23);
            this.btnCrearProceso.TabIndex = 6;
            this.btnCrearProceso.Text = "Crear";
            this.btnCrearProceso.UseVisualStyleBackColor = true;
            this.btnCrearProceso.Click += new System.EventHandler(this.btnCrearProceso_Click_1);
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(133, 103);
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
            this.nudDuracion.Size = new System.Drawing.Size(120, 20);
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
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración";
            // 
            // nudTamanio
            // 
            this.nudTamanio.Location = new System.Drawing.Point(133, 138);
            this.nudTamanio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTamanio.Name = "nudTamanio";
            this.nudTamanio.Size = new System.Drawing.Size(120, 20);
            this.nudTamanio.TabIndex = 3;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(24, 140);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(103, 13);
            this.lblTamanio.TabIndex = 2;
            this.lblTamanio.Text = "Tamaño en memoria";
            // 
            // lblNomProceso
            // 
            this.lblNomProceso.AutoSize = true;
            this.lblNomProceso.Location = new System.Drawing.Point(41, 67);
            this.lblNomProceso.Name = "lblNomProceso";
            this.lblNomProceso.Size = new System.Drawing.Size(86, 13);
            this.lblNomProceso.TabIndex = 1;
            this.lblNomProceso.Text = "Nombre Proceso";
            // 
            // txtNombreProceso
            // 
            this.txtNombreProceso.Location = new System.Drawing.Point(133, 67);
            this.txtNombreProceso.Name = "txtNombreProceso";
            this.txtNombreProceso.Size = new System.Drawing.Size(120, 20);
            this.txtNombreProceso.TabIndex = 0;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.Resumen);
            this.tabLog.Controls.Add(this.btnReporte);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(768, 400);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // Resumen
            // 
            this.Resumen.FormattingEnabled = true;
            this.Resumen.Location = new System.Drawing.Point(6, 6);
            this.Resumen.Name = "Resumen";
            this.Resumen.Size = new System.Drawing.Size(756, 264);
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
            // timerSimulacion
            // 
            this.timerSimulacion.Enabled = true;
            this.timerSimulacion.Interval = 1000;
            this.timerSimulacion.Tick += new System.EventHandler(this.timerSimulacion_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Simulador de procesos";
            this.tabControl1.ResumeLayout(false);
            this.tabSimulacion.ResumeLayout(false);
            this.tabSimulacion.PerformLayout();
            this.tabCrearProceso.ResumeLayout(false);
            this.tabCrearProceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanio)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSimulacion;
        private System.Windows.Forms.TabPage tabCrearProceso;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ProgressBar progressDisco;
        private System.Windows.Forms.ProgressBar progressMemoria;
        private System.Windows.Forms.ProgressBar progressCPU;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Timer timerSimulacion;
        private System.Windows.Forms.Label lblNomProceso;
        private System.Windows.Forms.TextBox txtNombreProceso;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown nudTamanio;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.Button btnCrearProceso;
        private System.Windows.Forms.ListBox Resumen;
        private System.Windows.Forms.Button btnReporte;
    }
}

