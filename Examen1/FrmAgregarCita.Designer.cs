namespace Examen1
{
    partial class FrmAgregarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCitas = new System.Windows.Forms.Label();
            this.picturaBoxCitas = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacionesCita = new System.Windows.Forms.TextBox();
            this.comboBoxPacientes = new System.Windows.Forms.ComboBox();
            this.comboBoxMedicos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblIngresarDatosCita = new System.Windows.Forms.Label();
            this.cbTipoCita = new System.Windows.Forms.ComboBox();
            this.cbEstadoCita = new System.Windows.Forms.ComboBox();
            this.txtObservacionCita = new System.Windows.Forms.TextBox();
            this.txtMotivoCita = new System.Windows.Forms.TextBox();
            this.txtFechaFinalCita = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinalCita = new System.Windows.Forms.Label();
            this.lblMotivoCita = new System.Windows.Forms.Label();
            this.lblEstadoCita = new System.Windows.Forms.Label();
            this.lblTipoCita = new System.Windows.Forms.Label();
            this.lblObservacionCita = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegresarAgregarCita = new System.Windows.Forms.Button();
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxCitas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCitas);
            this.panel1.Controls.Add(this.picturaBoxCitas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 396);
            this.panel1.TabIndex = 0;
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCitas.Location = new System.Drawing.Point(62, 188);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(119, 39);
            this.lblCitas.TabIndex = 3;
            this.lblCitas.Text = "Citas";
            // 
            // picturaBoxCitas
            // 
            this.picturaBoxCitas.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxCitas.Image")));
            this.picturaBoxCitas.Location = new System.Drawing.Point(22, 57);
            this.picturaBoxCitas.Name = "picturaBoxCitas";
            this.picturaBoxCitas.Size = new System.Drawing.Size(205, 128);
            this.picturaBoxCitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxCitas.TabIndex = 2;
            this.picturaBoxCitas.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtObservacionesCita);
            this.panel2.Controls.Add(this.comboBoxPacientes);
            this.panel2.Controls.Add(this.comboBoxMedicos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtFechaCita);
            this.panel2.Controls.Add(this.lblIngresarDatosCita);
            this.panel2.Controls.Add(this.cbTipoCita);
            this.panel2.Controls.Add(this.cbEstadoCita);
            this.panel2.Controls.Add(this.txtObservacionCita);
            this.panel2.Controls.Add(this.txtMotivoCita);
            this.panel2.Controls.Add(this.txtFechaFinalCita);
            this.panel2.Controls.Add(this.lblFechaInicio);
            this.panel2.Controls.Add(this.lblFechaFinalCita);
            this.panel2.Controls.Add(this.lblMotivoCita);
            this.panel2.Controls.Add(this.lblEstadoCita);
            this.panel2.Controls.Add(this.lblTipoCita);
            this.panel2.Controls.Add(this.lblObservacionCita);
            this.panel2.Location = new System.Drawing.Point(289, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 396);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(474, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Observaciones";
            // 
            // txtObservacionesCita
            // 
            this.txtObservacionesCita.Location = new System.Drawing.Point(455, 276);
            this.txtObservacionesCita.Multiline = true;
            this.txtObservacionesCita.Name = "txtObservacionesCita";
            this.txtObservacionesCita.Size = new System.Drawing.Size(174, 105);
            this.txtObservacionesCita.TabIndex = 19;
            // 
            // comboBoxPacientes
            // 
            this.comboBoxPacientes.FormattingEnabled = true;
            this.comboBoxPacientes.Items.AddRange(new object[] {
            "Pediatría",
            "Cardiología",
            "Medicina General",
            "Emergencia"});
            this.comboBoxPacientes.Location = new System.Drawing.Point(206, 357);
            this.comboBoxPacientes.Name = "comboBoxPacientes";
            this.comboBoxPacientes.Size = new System.Drawing.Size(199, 24);
            this.comboBoxPacientes.TabIndex = 18;
            // 
            // comboBoxMedicos
            // 
            this.comboBoxMedicos.FormattingEnabled = true;
            this.comboBoxMedicos.Location = new System.Drawing.Point(206, 318);
            this.comboBoxMedicos.Name = "comboBoxMedicos";
            this.comboBoxMedicos.Size = new System.Drawing.Size(199, 24);
            this.comboBoxMedicos.TabIndex = 17;
            this.comboBoxMedicos.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedicos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(96, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pacientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(109, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Medicos";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtFechaCita
            // 
            this.dtFechaCita.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            this.dtFechaCita.Location = new System.Drawing.Point(206, 57);
            this.dtFechaCita.MinDate = new System.DateTime(2025, 3, 2, 0, 0, 0, 0);
            this.dtFechaCita.Name = "dtFechaCita";
            this.dtFechaCita.Size = new System.Drawing.Size(199, 22);
            this.dtFechaCita.TabIndex = 14;
            this.dtFechaCita.ValueChanged += new System.EventHandler(this.dtFechaCita_ValueChanged);
            // 
            // lblIngresarDatosCita
            // 
            this.lblIngresarDatosCita.AutoSize = true;
            this.lblIngresarDatosCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosCita.Location = new System.Drawing.Point(143, 11);
            this.lblIngresarDatosCita.Name = "lblIngresarDatosCita";
            this.lblIngresarDatosCita.Size = new System.Drawing.Size(229, 24);
            this.lblIngresarDatosCita.TabIndex = 13;
            this.lblIngresarDatosCita.Text = "Ingresa los Datos";
            this.lblIngresarDatosCita.Click += new System.EventHandler(this.lblIngresarDatosCita_Click);
            // 
            // cbTipoCita
            // 
            this.cbTipoCita.FormattingEnabled = true;
            this.cbTipoCita.Items.AddRange(new object[] {
            "Pediatría",
            "Cardiología",
            "Medicina General",
            "Emergencia"});
            this.cbTipoCita.Location = new System.Drawing.Point(206, 276);
            this.cbTipoCita.Name = "cbTipoCita";
            this.cbTipoCita.Size = new System.Drawing.Size(199, 24);
            this.cbTipoCita.TabIndex = 12;
            this.cbTipoCita.SelectedIndexChanged += new System.EventHandler(this.cbTipoCita_SelectedIndexChanged);
            // 
            // cbEstadoCita
            // 
            this.cbEstadoCita.FormattingEnabled = true;
            this.cbEstadoCita.Items.AddRange(new object[] {
            "Programada",
            "Cancelada",
            "Completada"});
            this.cbEstadoCita.Location = new System.Drawing.Point(206, 188);
            this.cbEstadoCita.Name = "cbEstadoCita";
            this.cbEstadoCita.Size = new System.Drawing.Size(199, 24);
            this.cbEstadoCita.TabIndex = 11;
            this.cbEstadoCita.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtObservacionCita
            // 
            this.txtObservacionCita.Location = new System.Drawing.Point(206, 232);
            this.txtObservacionCita.Name = "txtObservacionCita";
            this.txtObservacionCita.Size = new System.Drawing.Size(199, 22);
            this.txtObservacionCita.TabIndex = 10;
            // 
            // txtMotivoCita
            // 
            this.txtMotivoCita.Location = new System.Drawing.Point(206, 143);
            this.txtMotivoCita.Name = "txtMotivoCita";
            this.txtMotivoCita.Size = new System.Drawing.Size(199, 22);
            this.txtMotivoCita.TabIndex = 8;
            // 
            // txtFechaFinalCita
            // 
            this.txtFechaFinalCita.Enabled = false;
            this.txtFechaFinalCita.Location = new System.Drawing.Point(206, 98);
            this.txtFechaFinalCita.Name = "txtFechaFinalCita";
            this.txtFechaFinalCita.Size = new System.Drawing.Size(199, 22);
            this.txtFechaFinalCita.TabIndex = 7;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFechaInicio.Location = new System.Drawing.Point(77, 56);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(111, 20);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.Click += new System.EventHandler(this.lblFechaInicio_Click);
            // 
            // lblFechaFinalCita
            // 
            this.lblFechaFinalCita.AutoSize = true;
            this.lblFechaFinalCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalCita.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFechaFinalCita.Location = new System.Drawing.Point(81, 98);
            this.lblFechaFinalCita.Name = "lblFechaFinalCita";
            this.lblFechaFinalCita.Size = new System.Drawing.Size(107, 20);
            this.lblFechaFinalCita.TabIndex = 4;
            this.lblFechaFinalCita.Text = "Fecha Final";
            // 
            // lblMotivoCita
            // 
            this.lblMotivoCita.AutoSize = true;
            this.lblMotivoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCita.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMotivoCita.Location = new System.Drawing.Point(124, 143);
            this.lblMotivoCita.Name = "lblMotivoCita";
            this.lblMotivoCita.Size = new System.Drawing.Size(64, 20);
            this.lblMotivoCita.TabIndex = 3;
            this.lblMotivoCita.Text = "Motivo";
            // 
            // lblEstadoCita
            // 
            this.lblEstadoCita.AutoSize = true;
            this.lblEstadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCita.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEstadoCita.Location = new System.Drawing.Point(121, 188);
            this.lblEstadoCita.Name = "lblEstadoCita";
            this.lblEstadoCita.Size = new System.Drawing.Size(67, 20);
            this.lblEstadoCita.TabIndex = 2;
            this.lblEstadoCita.Text = "Estado";
            // 
            // lblTipoCita
            // 
            this.lblTipoCita.AutoSize = true;
            this.lblTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCita.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTipoCita.Location = new System.Drawing.Point(143, 276);
            this.lblTipoCita.Name = "lblTipoCita";
            this.lblTipoCita.Size = new System.Drawing.Size(45, 20);
            this.lblTipoCita.TabIndex = 1;
            this.lblTipoCita.Text = "Tipo";
            // 
            // lblObservacionCita
            // 
            this.lblObservacionCita.AutoSize = true;
            this.lblObservacionCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionCita.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblObservacionCita.Location = new System.Drawing.Point(74, 232);
            this.lblObservacionCita.Name = "lblObservacionCita";
            this.lblObservacionCita.Size = new System.Drawing.Size(114, 20);
            this.lblObservacionCita.TabIndex = 0;
            this.lblObservacionCita.Text = "Observacion";
            this.lblObservacionCita.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnRegresarAgregarCita);
            this.panel3.Controls.Add(this.btnAgregarCita);
            this.panel3.Location = new System.Drawing.Point(12, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 114);
            this.panel3.TabIndex = 2;
            // 
            // btnRegresarAgregarCita
            // 
            this.btnRegresarAgregarCita.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarAgregarCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarAgregarCita.ForeColor = System.Drawing.Color.White;
            this.btnRegresarAgregarCita.Location = new System.Drawing.Point(31, 29);
            this.btnRegresarAgregarCita.Name = "btnRegresarAgregarCita";
            this.btnRegresarAgregarCita.Size = new System.Drawing.Size(205, 36);
            this.btnRegresarAgregarCita.TabIndex = 3;
            this.btnRegresarAgregarCita.Text = "Regresar";
            this.btnRegresarAgregarCita.UseVisualStyleBackColor = false;
            this.btnRegresarAgregarCita.Click += new System.EventHandler(this.btnRegresarAgregarCita_Click);
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCita.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCita.Location = new System.Drawing.Point(545, 29);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(205, 36);
            this.btnAgregarCita.TabIndex = 2;
            this.btnAgregarCita.Text = "Agregar";
            this.btnAgregarCita.UseVisualStyleBackColor = false;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // FrmAgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(961, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAgregarCita";
            this.Text = "FrmAgregarCita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxCitas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.Label lblObservacionCita;
        private System.Windows.Forms.Label lblTipoCita;
        private System.Windows.Forms.Label lblEstadoCita;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinalCita;
        private System.Windows.Forms.Label lblMotivoCita;
        private System.Windows.Forms.TextBox txtObservacionCita;
        private System.Windows.Forms.TextBox txtMotivoCita;
        private System.Windows.Forms.TextBox txtFechaFinalCita;
        private System.Windows.Forms.ComboBox cbTipoCita;
        private System.Windows.Forms.ComboBox cbEstadoCita;
        private System.Windows.Forms.Button btnRegresarAgregarCita;
        private System.Windows.Forms.Label lblIngresarDatosCita;
        private System.Windows.Forms.PictureBox picturaBoxCitas;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.DateTimePicker dtFechaCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMedicos;
        private System.Windows.Forms.ComboBox comboBoxPacientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacionesCita;
    }
}