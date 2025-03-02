using System;

namespace Examen1
{
    partial class FrmAgregarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMedico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.picturaBoxMedicos = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.cbEstadoMedico = new System.Windows.Forms.ComboBox();
            this.txtLimiteCitasMedico = new System.Windows.Forms.TextBox();
            this.txtHoraAtencionMedico = new System.Windows.Forms.TextBox();
            this.txtTelefonoMedico = new System.Windows.Forms.TextBox();
            this.txtNombreCompletoMedico = new System.Windows.Forms.TextBox();
            this.lblEstadoMedico = new System.Windows.Forms.Label();
            this.lblLimiteCitasMedico = new System.Windows.Forms.Label();
            this.lblHorarioAtencionMedico = new System.Windows.Forms.Label();
            this.lblTelefonoMedico = new System.Windows.Forms.Label();
            this.lblEspecialidadMedico = new System.Windows.Forms.Label();
            this.lblNombreCompletoMedico = new System.Windows.Forms.Label();
            this.lblIngresarDatosCita = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarMedico = new System.Windows.Forms.Button();
            this.btnRegresarAgregarMedico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxMedicos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPacientes);
            this.panel1.Controls.Add(this.picturaBoxMedicos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 316);
            this.panel1.TabIndex = 2;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPacientes.Location = new System.Drawing.Point(43, 185);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(176, 39);
            this.lblPacientes.TabIndex = 5;
            this.lblPacientes.Text = "Medicos";
            // 
            // picturaBoxMedicos
            // 
            this.picturaBoxMedicos.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxMedicos.Image")));
            this.picturaBoxMedicos.Location = new System.Drawing.Point(32, 53);
            this.picturaBoxMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturaBoxMedicos.Name = "picturaBoxMedicos";
            this.picturaBoxMedicos.Size = new System.Drawing.Size(200, 128);
            this.picturaBoxMedicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxMedicos.TabIndex = 4;
            this.picturaBoxMedicos.TabStop = false;
            this.picturaBoxMedicos.Click += new System.EventHandler(this.picturaBoxPacientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSeleccionarFoto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbEspecialidadMedico);
            this.panel2.Controls.Add(this.cbEstadoMedico);
            this.panel2.Controls.Add(this.txtLimiteCitasMedico);
            this.panel2.Controls.Add(this.txtHoraAtencionMedico);
            this.panel2.Controls.Add(this.txtTelefonoMedico);
            this.panel2.Controls.Add(this.txtNombreCompletoMedico);
            this.panel2.Controls.Add(this.lblEstadoMedico);
            this.panel2.Controls.Add(this.lblLimiteCitasMedico);
            this.panel2.Controls.Add(this.lblHorarioAtencionMedico);
            this.panel2.Controls.Add(this.lblTelefonoMedico);
            this.panel2.Controls.Add(this.lblEspecialidadMedico);
            this.panel2.Controls.Add(this.lblNombreCompletoMedico);
            this.panel2.Controls.Add(this.lblIngresarDatosCita);
            this.panel2.Location = new System.Drawing.Point(292, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 315);
            this.panel2.TabIndex = 3;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(229, 159);
            this.btnSeleccionarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(212, 28);
            this.btnSeleccionarFoto.TabIndex = 29;
            this.btnSeleccionarFoto.Text = "Seleccionar archivo";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(159, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Foto";
            // 
            // cbEspecialidadMedico
            // 
            this.cbEspecialidadMedico.FormattingEnabled = true;
            this.cbEspecialidadMedico.Items.AddRange(new object[] {
            "Pediatría",
            "Cardiología",
            "Medicina General"});
            this.cbEspecialidadMedico.Location = new System.Drawing.Point(229, 84);
            this.cbEspecialidadMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEspecialidadMedico.Name = "cbEspecialidadMedico";
            this.cbEspecialidadMedico.Size = new System.Drawing.Size(211, 24);
            this.cbEspecialidadMedico.TabIndex = 27;
            // 
            // cbEstadoMedico
            // 
            this.cbEstadoMedico.FormattingEnabled = true;
            this.cbEstadoMedico.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "Vacaciones",
            "Licencia médica"});
            this.cbEstadoMedico.Location = new System.Drawing.Point(229, 276);
            this.cbEstadoMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoMedico.Name = "cbEstadoMedico";
            this.cbEstadoMedico.Size = new System.Drawing.Size(211, 24);
            this.cbEstadoMedico.TabIndex = 26;
            // 
            // txtLimiteCitasMedico
            // 
            this.txtLimiteCitasMedico.Enabled = false;
            this.txtLimiteCitasMedico.Location = new System.Drawing.Point(229, 236);
            this.txtLimiteCitasMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimiteCitasMedico.Name = "txtLimiteCitasMedico";
            this.txtLimiteCitasMedico.Size = new System.Drawing.Size(211, 22);
            this.txtLimiteCitasMedico.TabIndex = 25;
            this.txtLimiteCitasMedico.TextChanged += new System.EventHandler(this.txtLimiteCitasMedico_TextChanged);
            // 
            // txtHoraAtencionMedico
            // 
            this.txtHoraAtencionMedico.Location = new System.Drawing.Point(229, 193);
            this.txtHoraAtencionMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraAtencionMedico.Name = "txtHoraAtencionMedico";
            this.txtHoraAtencionMedico.Size = new System.Drawing.Size(211, 22);
            this.txtHoraAtencionMedico.TabIndex = 24;
            this.txtHoraAtencionMedico.TextChanged += new System.EventHandler(this.txtHoraAtencionMedico_TextChanged_1);
            // 
            // txtTelefonoMedico
            // 
            this.txtTelefonoMedico.Location = new System.Drawing.Point(229, 123);
            this.txtTelefonoMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoMedico.Name = "txtTelefonoMedico";
            this.txtTelefonoMedico.Size = new System.Drawing.Size(211, 22);
            this.txtTelefonoMedico.TabIndex = 23;
            // 
            // txtNombreCompletoMedico
            // 
            this.txtNombreCompletoMedico.Location = new System.Drawing.Point(229, 47);
            this.txtNombreCompletoMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCompletoMedico.Name = "txtNombreCompletoMedico";
            this.txtNombreCompletoMedico.Size = new System.Drawing.Size(211, 22);
            this.txtNombreCompletoMedico.TabIndex = 22;
            // 
            // lblEstadoMedico
            // 
            this.lblEstadoMedico.AutoSize = true;
            this.lblEstadoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEstadoMedico.Location = new System.Drawing.Point(135, 276);
            this.lblEstadoMedico.Name = "lblEstadoMedico";
            this.lblEstadoMedico.Size = new System.Drawing.Size(67, 20);
            this.lblEstadoMedico.TabIndex = 21;
            this.lblEstadoMedico.Text = "Estado";
            this.lblEstadoMedico.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblLimiteCitasMedico
            // 
            this.lblLimiteCitasMedico.AutoSize = true;
            this.lblLimiteCitasMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCitasMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLimiteCitasMedico.Location = new System.Drawing.Point(65, 236);
            this.lblLimiteCitasMedico.Name = "lblLimiteCitasMedico";
            this.lblLimiteCitasMedico.Size = new System.Drawing.Size(137, 20);
            this.lblLimiteCitasMedico.TabIndex = 20;
            this.lblLimiteCitasMedico.Text = "Limite de Citas";
            // 
            // lblHorarioAtencionMedico
            // 
            this.lblHorarioAtencionMedico.AutoSize = true;
            this.lblHorarioAtencionMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioAtencionMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHorarioAtencionMedico.Location = new System.Drawing.Point(51, 196);
            this.lblHorarioAtencionMedico.Name = "lblHorarioAtencionMedico";
            this.lblHorarioAtencionMedico.Size = new System.Drawing.Size(151, 20);
            this.lblHorarioAtencionMedico.TabIndex = 19;
            this.lblHorarioAtencionMedico.Text = "Horario Atencion";
            // 
            // lblTelefonoMedico
            // 
            this.lblTelefonoMedico.AutoSize = true;
            this.lblTelefonoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTelefonoMedico.Location = new System.Drawing.Point(121, 126);
            this.lblTelefonoMedico.Name = "lblTelefonoMedico";
            this.lblTelefonoMedico.Size = new System.Drawing.Size(81, 20);
            this.lblTelefonoMedico.TabIndex = 18;
            this.lblTelefonoMedico.Text = "Telefono";
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(85, 84);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(116, 20);
            this.lblEspecialidadMedico.TabIndex = 17;
            this.lblEspecialidadMedico.Text = "Especialidad";
            // 
            // lblNombreCompletoMedico
            // 
            this.lblNombreCompletoMedico.AutoSize = true;
            this.lblNombreCompletoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompletoMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNombreCompletoMedico.Location = new System.Drawing.Point(43, 47);
            this.lblNombreCompletoMedico.Name = "lblNombreCompletoMedico";
            this.lblNombreCompletoMedico.Size = new System.Drawing.Size(159, 20);
            this.lblNombreCompletoMedico.TabIndex = 16;
            this.lblNombreCompletoMedico.Text = "Nombre Completo";
            // 
            // lblIngresarDatosCita
            // 
            this.lblIngresarDatosCita.AutoSize = true;
            this.lblIngresarDatosCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosCita.Location = new System.Drawing.Point(135, 14);
            this.lblIngresarDatosCita.Name = "lblIngresarDatosCita";
            this.lblIngresarDatosCita.Size = new System.Drawing.Size(229, 24);
            this.lblIngresarDatosCita.TabIndex = 15;
            this.lblIngresarDatosCita.Text = "Ingresa los Datos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnAgregarMedico);
            this.panel3.Controls.Add(this.btnRegresarAgregarMedico);
            this.panel3.Location = new System.Drawing.Point(13, 356);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 82);
            this.panel3.TabIndex = 4;
            // 
            // btnAgregarMedico
            // 
            this.btnAgregarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarMedico.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMedico.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedico.Location = new System.Drawing.Point(544, 25);
            this.btnAgregarMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarMedico.Name = "btnAgregarMedico";
            this.btnAgregarMedico.Size = new System.Drawing.Size(205, 36);
            this.btnAgregarMedico.TabIndex = 1;
            this.btnAgregarMedico.Text = "Agregar";
            this.btnAgregarMedico.UseVisualStyleBackColor = false;
            this.btnAgregarMedico.Click += new System.EventHandler(this.btnAgregarMedico_Click);
            // 
            // btnRegresarAgregarMedico
            // 
            this.btnRegresarAgregarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarAgregarMedico.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarAgregarMedico.ForeColor = System.Drawing.Color.White;
            this.btnRegresarAgregarMedico.Location = new System.Drawing.Point(27, 25);
            this.btnRegresarAgregarMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarAgregarMedico.Name = "btnRegresarAgregarMedico";
            this.btnRegresarAgregarMedico.Size = new System.Drawing.Size(205, 36);
            this.btnRegresarAgregarMedico.TabIndex = 0;
            this.btnRegresarAgregarMedico.Text = "Regresar";
            this.btnRegresarAgregarMedico.UseVisualStyleBackColor = false;
            this.btnRegresarAgregarMedico.Click += new System.EventHandler(this.btnRegresarAgregarMedico_Click);
            // 
            // FrmAgregarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAgregarMedico";
            this.Text = "FrmAgregarMedico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxMedicos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void picturaBoxPacientes_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewMethod()
        {
            this.picturaBoxMedicos.TabStop = false;
        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.PictureBox picturaBoxMedicos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIngresarDatosCita;
        private System.Windows.Forms.Label lblEstadoMedico;
        private System.Windows.Forms.Label lblLimiteCitasMedico;
        private System.Windows.Forms.Label lblHorarioAtencionMedico;
        private System.Windows.Forms.Label lblTelefonoMedico;
        private System.Windows.Forms.Label lblEspecialidadMedico;
        private System.Windows.Forms.Label lblNombreCompletoMedico;
        private System.Windows.Forms.TextBox txtNombreCompletoMedico;
        private System.Windows.Forms.ComboBox cbEspecialidadMedico;
        private System.Windows.Forms.ComboBox cbEstadoMedico;
        private System.Windows.Forms.TextBox txtLimiteCitasMedico;
        private System.Windows.Forms.TextBox txtHoraAtencionMedico;
        private System.Windows.Forms.TextBox txtTelefonoMedico;
        private System.Windows.Forms.Button btnAgregarMedico;
        private System.Windows.Forms.Button btnRegresarAgregarMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarFoto;
    }
}
#endregion