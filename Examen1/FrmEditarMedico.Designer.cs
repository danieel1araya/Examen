namespace Examen1
{
    partial class FrmEditarMedico
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarMedico = new System.Windows.Forms.Button();
            this.btnRegresarAgregarMedico = new System.Windows.Forms.Button();
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
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnEditarMedico);
            this.panel3.Controls.Add(this.btnRegresarAgregarMedico);
            this.panel3.Location = new System.Drawing.Point(5, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 67);
            this.panel3.TabIndex = 6;
            // 
            // btnEditarMedico
            // 
            this.btnEditarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarMedico.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMedico.ForeColor = System.Drawing.Color.White;
            this.btnEditarMedico.Location = new System.Drawing.Point(408, 20);
            this.btnEditarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarMedico.Name = "btnEditarMedico";
            this.btnEditarMedico.Size = new System.Drawing.Size(154, 29);
            this.btnEditarMedico.TabIndex = 1;
            this.btnEditarMedico.Text = "Editar";
            this.btnEditarMedico.UseVisualStyleBackColor = false;
            this.btnEditarMedico.Click += new System.EventHandler(this.btnEditarMedico_Click);
            // 
            // btnRegresarAgregarMedico
            // 
            this.btnRegresarAgregarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarAgregarMedico.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarAgregarMedico.ForeColor = System.Drawing.Color.White;
            this.btnRegresarAgregarMedico.Location = new System.Drawing.Point(20, 20);
            this.btnRegresarAgregarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresarAgregarMedico.Name = "btnRegresarAgregarMedico";
            this.btnRegresarAgregarMedico.Size = new System.Drawing.Size(154, 29);
            this.btnRegresarAgregarMedico.TabIndex = 0;
            this.btnRegresarAgregarMedico.Text = "Regresar";
            this.btnRegresarAgregarMedico.UseVisualStyleBackColor = false;
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
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 256);
            this.panel2.TabIndex = 5;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(172, 129);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(159, 23);
            this.btnSeleccionarFoto.TabIndex = 29;
            this.btnSeleccionarFoto.Text = "Seleccionar archivo";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(119, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
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
            this.cbEspecialidadMedico.Location = new System.Drawing.Point(172, 68);
            this.cbEspecialidadMedico.Margin = new System.Windows.Forms.Padding(2);
            this.cbEspecialidadMedico.Name = "cbEspecialidadMedico";
            this.cbEspecialidadMedico.Size = new System.Drawing.Size(159, 21);
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
            this.cbEstadoMedico.Location = new System.Drawing.Point(172, 224);
            this.cbEstadoMedico.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoMedico.Name = "cbEstadoMedico";
            this.cbEstadoMedico.Size = new System.Drawing.Size(159, 21);
            this.cbEstadoMedico.TabIndex = 26;
            // 
            // txtLimiteCitasMedico
            // 
            this.txtLimiteCitasMedico.Enabled = false;
            this.txtLimiteCitasMedico.Location = new System.Drawing.Point(172, 192);
            this.txtLimiteCitasMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimiteCitasMedico.Name = "txtLimiteCitasMedico";
            this.txtLimiteCitasMedico.Size = new System.Drawing.Size(159, 20);
            this.txtLimiteCitasMedico.TabIndex = 25;
            // 
            // txtHoraAtencionMedico
            // 
            this.txtHoraAtencionMedico.Location = new System.Drawing.Point(172, 157);
            this.txtHoraAtencionMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraAtencionMedico.Name = "txtHoraAtencionMedico";
            this.txtHoraAtencionMedico.Size = new System.Drawing.Size(159, 20);
            this.txtHoraAtencionMedico.TabIndex = 24;
            // 
            // txtTelefonoMedico
            // 
            this.txtTelefonoMedico.Location = new System.Drawing.Point(172, 100);
            this.txtTelefonoMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoMedico.Name = "txtTelefonoMedico";
            this.txtTelefonoMedico.Size = new System.Drawing.Size(159, 20);
            this.txtTelefonoMedico.TabIndex = 23;
            // 
            // txtNombreCompletoMedico
            // 
            this.txtNombreCompletoMedico.Location = new System.Drawing.Point(172, 38);
            this.txtNombreCompletoMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCompletoMedico.Name = "txtNombreCompletoMedico";
            this.txtNombreCompletoMedico.Size = new System.Drawing.Size(159, 20);
            this.txtNombreCompletoMedico.TabIndex = 22;
            // 
            // lblEstadoMedico
            // 
            this.lblEstadoMedico.AutoSize = true;
            this.lblEstadoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEstadoMedico.Location = new System.Drawing.Point(101, 224);
            this.lblEstadoMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoMedico.Name = "lblEstadoMedico";
            this.lblEstadoMedico.Size = new System.Drawing.Size(58, 17);
            this.lblEstadoMedico.TabIndex = 21;
            this.lblEstadoMedico.Text = "Estado";
            // 
            // lblLimiteCitasMedico
            // 
            this.lblLimiteCitasMedico.AutoSize = true;
            this.lblLimiteCitasMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCitasMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLimiteCitasMedico.Location = new System.Drawing.Point(49, 192);
            this.lblLimiteCitasMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimiteCitasMedico.Name = "lblLimiteCitasMedico";
            this.lblLimiteCitasMedico.Size = new System.Drawing.Size(115, 17);
            this.lblLimiteCitasMedico.TabIndex = 20;
            this.lblLimiteCitasMedico.Text = "Limite de Citas";
            // 
            // lblHorarioAtencionMedico
            // 
            this.lblHorarioAtencionMedico.AutoSize = true;
            this.lblHorarioAtencionMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioAtencionMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHorarioAtencionMedico.Location = new System.Drawing.Point(38, 159);
            this.lblHorarioAtencionMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorarioAtencionMedico.Name = "lblHorarioAtencionMedico";
            this.lblHorarioAtencionMedico.Size = new System.Drawing.Size(130, 17);
            this.lblHorarioAtencionMedico.TabIndex = 19;
            this.lblHorarioAtencionMedico.Text = "Horario Atencion";
            // 
            // lblTelefonoMedico
            // 
            this.lblTelefonoMedico.AutoSize = true;
            this.lblTelefonoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTelefonoMedico.Location = new System.Drawing.Point(91, 102);
            this.lblTelefonoMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoMedico.Name = "lblTelefonoMedico";
            this.lblTelefonoMedico.Size = new System.Drawing.Size(72, 17);
            this.lblTelefonoMedico.TabIndex = 18;
            this.lblTelefonoMedico.Text = "Telefono";
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(64, 68);
            this.lblEspecialidadMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(100, 17);
            this.lblEspecialidadMedico.TabIndex = 17;
            this.lblEspecialidadMedico.Text = "Especialidad";
            // 
            // lblNombreCompletoMedico
            // 
            this.lblNombreCompletoMedico.AutoSize = true;
            this.lblNombreCompletoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompletoMedico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNombreCompletoMedico.Location = new System.Drawing.Point(32, 38);
            this.lblNombreCompletoMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCompletoMedico.Name = "lblNombreCompletoMedico";
            this.lblNombreCompletoMedico.Size = new System.Drawing.Size(136, 17);
            this.lblNombreCompletoMedico.TabIndex = 16;
            this.lblNombreCompletoMedico.Text = "Nombre Completo";
            // 
            // lblIngresarDatosCita
            // 
            this.lblIngresarDatosCita.AutoSize = true;
            this.lblIngresarDatosCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosCita.Location = new System.Drawing.Point(101, 11);
            this.lblIngresarDatosCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresarDatosCita.Name = "lblIngresarDatosCita";
            this.lblIngresarDatosCita.Size = new System.Drawing.Size(185, 20);
            this.lblIngresarDatosCita.TabIndex = 15;
            this.lblIngresarDatosCita.Text = "Ingresa los Datos";
            // 
            // FrmEditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 345);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEditarMedico";
            this.Text = "FrmEditarMedico";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditarMedico;
        private System.Windows.Forms.Button btnRegresarAgregarMedico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecialidadMedico;
        private System.Windows.Forms.ComboBox cbEstadoMedico;
        private System.Windows.Forms.TextBox txtLimiteCitasMedico;
        private System.Windows.Forms.TextBox txtHoraAtencionMedico;
        private System.Windows.Forms.TextBox txtTelefonoMedico;
        private System.Windows.Forms.TextBox txtNombreCompletoMedico;
        private System.Windows.Forms.Label lblEstadoMedico;
        private System.Windows.Forms.Label lblLimiteCitasMedico;
        private System.Windows.Forms.Label lblHorarioAtencionMedico;
        private System.Windows.Forms.Label lblTelefonoMedico;
        private System.Windows.Forms.Label lblEspecialidadMedico;
        private System.Windows.Forms.Label lblNombreCompletoMedico;
        private System.Windows.Forms.Label lblIngresarDatosCita;
    }
}