namespace Examen1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInicioPacientes = new System.Windows.Forms.Button();
            this.btnInicioMedicos = new System.Windows.Forms.Button();
            this.btnInicioCitas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoPrincipal)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.pictureBoxLogoPrincipal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 348);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(748, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(211, 244);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(359, 39);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Pagina Principal";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxLogoPrincipal
            // 
            this.pictureBoxLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPrincipal.Image")));
            this.pictureBoxLogoPrincipal.Location = new System.Drawing.Point(258, 25);
            this.pictureBoxLogoPrincipal.Name = "pictureBoxLogoPrincipal";
            this.pictureBoxLogoPrincipal.Size = new System.Drawing.Size(266, 235);
            this.pictureBoxLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoPrincipal.TabIndex = 0;
            this.pictureBoxLogoPrincipal.TabStop = false;
            this.pictureBoxLogoPrincipal.UseWaitCursor = true;
            this.pictureBoxLogoPrincipal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnInicioPacientes);
            this.panel2.Controls.Add(this.btnInicioMedicos);
            this.panel2.Controls.Add(this.btnInicioCitas);
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 78);
            this.panel2.TabIndex = 1;
            // 
            // btnInicioPacientes
            // 
            this.btnInicioPacientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicioPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioPacientes.ForeColor = System.Drawing.Color.White;
            this.btnInicioPacientes.Location = new System.Drawing.Point(516, 14);
            this.btnInicioPacientes.Name = "btnInicioPacientes";
            this.btnInicioPacientes.Size = new System.Drawing.Size(159, 51);
            this.btnInicioPacientes.TabIndex = 2;
            this.btnInicioPacientes.Text = "Pacientes";
            this.btnInicioPacientes.UseVisualStyleBackColor = false;
            this.btnInicioPacientes.Click += new System.EventHandler(this.btnInicioPacientes_Click);
            // 
            // btnInicioMedicos
            // 
            this.btnInicioMedicos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicioMedicos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioMedicos.ForeColor = System.Drawing.Color.White;
            this.btnInicioMedicos.Location = new System.Drawing.Point(270, 14);
            this.btnInicioMedicos.Name = "btnInicioMedicos";
            this.btnInicioMedicos.Size = new System.Drawing.Size(159, 51);
            this.btnInicioMedicos.TabIndex = 1;
            this.btnInicioMedicos.Text = "Medicos";
            this.btnInicioMedicos.UseVisualStyleBackColor = false;
            this.btnInicioMedicos.Click += new System.EventHandler(this.btnInicioMedicos_Click);
            // 
            // btnInicioCitas
            // 
            this.btnInicioCitas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicioCitas.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioCitas.ForeColor = System.Drawing.Color.White;
            this.btnInicioCitas.Location = new System.Drawing.Point(16, 14);
            this.btnInicioCitas.Name = "btnInicioCitas";
            this.btnInicioCitas.Size = new System.Drawing.Size(159, 51);
            this.btnInicioCitas.TabIndex = 0;
            this.btnInicioCitas.Text = "Citas";
            this.btnInicioCitas.UseVisualStyleBackColor = false;
            this.btnInicioCitas.Click += new System.EventHandler(this.btnInicioCitas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoPrincipal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogoPrincipal;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInicioCitas;
        private System.Windows.Forms.Button btnInicioPacientes;
        private System.Windows.Forms.Button btnInicioMedicos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}