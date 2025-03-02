using System;

namespace Examen1
{
    partial class FrmAgregarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarPaciente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.picturaBoxPacientes = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbGeneroPaciente = new System.Windows.Forms.ComboBox();
            this.cbEstadoPaciente = new System.Windows.Forms.ComboBox();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombreCompletoPaciente = new System.Windows.Forms.TextBox();
            this.lblDireccionPaciente = new System.Windows.Forms.Label();
            this.lblEstadoPaciente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            this.lblGeneroPaciente = new System.Windows.Forms.Label();
            this.lblFechaNacimientoPaciente = new System.Windows.Forms.Label();
            this.lblNombreCompletoPaciente = new System.Windows.Forms.Label();
            this.lblIngresarDatosCita = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRegresarInicioPaciente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxPacientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPacientes);
            this.panel1.Controls.Add(this.picturaBoxPacientes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 316);
            this.panel1.TabIndex = 1;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPacientes.Location = new System.Drawing.Point(25, 187);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(207, 39);
            this.lblPacientes.TabIndex = 5;
            this.lblPacientes.Text = "Pacientes";
            this.lblPacientes.Click += new System.EventHandler(this.lblPacientes_Click);
            // 
            // picturaBoxPacientes
            // 
            this.picturaBoxPacientes.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxPacientes.Image")));
            this.picturaBoxPacientes.Location = new System.Drawing.Point(32, 53);
            this.picturaBoxPacientes.Name = "picturaBoxPacientes";
            this.picturaBoxPacientes.Size = new System.Drawing.Size(200, 128);
            this.picturaBoxPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxPacientes.TabIndex = 4;
            this.picturaBoxPacientes.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSeleccionarFoto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbGeneroPaciente);
            this.panel2.Controls.Add(this.cbEstadoPaciente);
            this.panel2.Controls.Add(this.txtDireccionPaciente);
            this.panel2.Controls.Add(this.txtTelefonoPaciente);
            this.panel2.Controls.Add(this.txtNombreCompletoPaciente);
            this.panel2.Controls.Add(this.lblDireccionPaciente);
            this.panel2.Controls.Add(this.lblEstadoPaciente);
            this.panel2.Controls.Add(this.lblTelefonoPaciente);
            this.panel2.Controls.Add(this.lblGeneroPaciente);
            this.panel2.Controls.Add(this.lblFechaNacimientoPaciente);
            this.panel2.Controls.Add(this.lblNombreCompletoPaciente);
            this.panel2.Controls.Add(this.lblIngresarDatosCita);
            this.panel2.Location = new System.Drawing.Point(289, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 335);
            this.panel2.TabIndex = 2;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(220, 303);
            this.btnSeleccionarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(175, 28);
            this.btnSeleccionarFoto.TabIndex = 30;
            this.btnSeleccionarFoto.Text = "Seleccionar archivo";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(107, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Foto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // cbGeneroPaciente
            // 
            this.cbGeneroPaciente.FormattingEnabled = true;
            this.cbGeneroPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cbGeneroPaciente.Location = new System.Drawing.Point(220, 130);
            this.cbGeneroPaciente.Name = "cbGeneroPaciente";
            this.cbGeneroPaciente.Size = new System.Drawing.Size(174, 24);
            this.cbGeneroPaciente.TabIndex = 25;
            // 
            // cbEstadoPaciente
            // 
            this.cbEstadoPaciente.FormattingEnabled = true;
            this.cbEstadoPaciente.Items.AddRange(new object[] {
            "Disponible",
            "En consulta"});
            this.cbEstadoPaciente.Location = new System.Drawing.Point(220, 223);
            this.cbEstadoPaciente.Name = "cbEstadoPaciente";
            this.cbEstadoPaciente.Size = new System.Drawing.Size(174, 24);
            this.cbEstadoPaciente.TabIndex = 24;
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Location = new System.Drawing.Point(220, 266);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(174, 22);
            this.txtDireccionPaciente.TabIndex = 23;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(219, 177);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(174, 22);
            this.txtTelefonoPaciente.TabIndex = 22;
            // 
            // txtNombreCompletoPaciente
            // 
            this.txtNombreCompletoPaciente.Location = new System.Drawing.Point(220, 51);
            this.txtNombreCompletoPaciente.Name = "txtNombreCompletoPaciente";
            this.txtNombreCompletoPaciente.Size = new System.Drawing.Size(174, 22);
            this.txtNombreCompletoPaciente.TabIndex = 20;
            // 
            // lblDireccionPaciente
            // 
            this.lblDireccionPaciente.AutoSize = true;
            this.lblDireccionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDireccionPaciente.Location = new System.Drawing.Point(111, 266);
            this.lblDireccionPaciente.Name = "lblDireccionPaciente";
            this.lblDireccionPaciente.Size = new System.Drawing.Size(90, 20);
            this.lblDireccionPaciente.TabIndex = 19;
            this.lblDireccionPaciente.Text = "Direccion";
            // 
            // lblEstadoPaciente
            // 
            this.lblEstadoPaciente.AutoSize = true;
            this.lblEstadoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEstadoPaciente.Location = new System.Drawing.Point(130, 223);
            this.lblEstadoPaciente.Name = "lblEstadoPaciente";
            this.lblEstadoPaciente.Size = new System.Drawing.Size(67, 20);
            this.lblEstadoPaciente.TabIndex = 18;
            this.lblEstadoPaciente.Text = "Estado";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(119, 179);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(81, 20);
            this.lblTelefonoPaciente.TabIndex = 17;
            this.lblTelefonoPaciente.Text = "Telefono";
            // 
            // lblGeneroPaciente
            // 
            this.lblGeneroPaciente.AutoSize = true;
            this.lblGeneroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGeneroPaciente.Location = new System.Drawing.Point(130, 134);
            this.lblGeneroPaciente.Name = "lblGeneroPaciente";
            this.lblGeneroPaciente.Size = new System.Drawing.Size(70, 20);
            this.lblGeneroPaciente.TabIndex = 16;
            this.lblGeneroPaciente.Text = "Genero";
            // 
            // lblFechaNacimientoPaciente
            // 
            this.lblFechaNacimientoPaciente.AutoSize = true;
            this.lblFechaNacimientoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimientoPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFechaNacimientoPaciente.Location = new System.Drawing.Point(37, 92);
            this.lblFechaNacimientoPaciente.Name = "lblFechaNacimientoPaciente";
            this.lblFechaNacimientoPaciente.Size = new System.Drawing.Size(160, 20);
            this.lblFechaNacimientoPaciente.TabIndex = 15;
            this.lblFechaNacimientoPaciente.Text = "Fecha Nacimiento";
            // 
            // lblNombreCompletoPaciente
            // 
            this.lblNombreCompletoPaciente.AutoSize = true;
            this.lblNombreCompletoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompletoPaciente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNombreCompletoPaciente.Location = new System.Drawing.Point(41, 53);
            this.lblNombreCompletoPaciente.Name = "lblNombreCompletoPaciente";
            this.lblNombreCompletoPaciente.Size = new System.Drawing.Size(159, 20);
            this.lblNombreCompletoPaciente.TabIndex = 6;
            this.lblNombreCompletoPaciente.Text = "Nombre Completo";
            this.lblNombreCompletoPaciente.Click += new System.EventHandler(this.lblNombreCompleto_Click);
            // 
            // lblIngresarDatosCita
            // 
            this.lblIngresarDatosCita.AutoSize = true;
            this.lblIngresarDatosCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosCita.Location = new System.Drawing.Point(141, 9);
            this.lblIngresarDatosCita.Name = "lblIngresarDatosCita";
            this.lblIngresarDatosCita.Size = new System.Drawing.Size(229, 24);
            this.lblIngresarDatosCita.TabIndex = 14;
            this.lblIngresarDatosCita.Text = "Ingresa los Datos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnRegresarInicioPaciente);
            this.panel3.Controls.Add(this.btnAgregarPaciente);
            this.panel3.Location = new System.Drawing.Point(12, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 85);
            this.panel3.TabIndex = 3;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(543, 27);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(205, 36);
            this.btnAgregarPaciente.TabIndex = 1;
            this.btnAgregarPaciente.Text = "Agregar";
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRegresarInicioPaciente
            // 
            this.btnRegresarInicioPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarInicioPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarInicioPaciente.ForeColor = System.Drawing.Color.White;
            this.btnRegresarInicioPaciente.Location = new System.Drawing.Point(32, 27);
            this.btnRegresarInicioPaciente.Name = "btnRegresarInicioPaciente";
            this.btnRegresarInicioPaciente.Size = new System.Drawing.Size(205, 36);
            this.btnRegresarInicioPaciente.TabIndex = 2;
            this.btnRegresarInicioPaciente.Text = "Regresar";
            this.btnRegresarInicioPaciente.UseVisualStyleBackColor = false;
            this.btnRegresarInicioPaciente.Click += new System.EventHandler(this.btnRegresarInicioPaciente_Click);
            // 
            // FrmAgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAgregarPaciente";
            this.Text = "FrmAgregarPaciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxPacientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIngresarDatosCita;
        private System.Windows.Forms.PictureBox picturaBoxPacientes;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblNombreCompletoPaciente;
        private System.Windows.Forms.Label lblEstadoPaciente;
        private System.Windows.Forms.Label lblTelefonoPaciente;
        private System.Windows.Forms.Label lblGeneroPaciente;
        private System.Windows.Forms.Label lblFechaNacimientoPaciente;
        private System.Windows.Forms.ComboBox cbGeneroPaciente;
        private System.Windows.Forms.ComboBox cbEstadoPaciente;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.TextBox txtNombreCompletoPaciente;
        private System.Windows.Forms.Label lblDireccionPaciente;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRegresarInicioPaciente;
    }
}