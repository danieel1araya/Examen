namespace Examen1
{
    partial class FrmInicioMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioMedicos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.picturaBoxMedicos = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridMedicos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarInicioMedicos = new System.Windows.Forms.Button();
            this.btnRegistroMedicos = new System.Windows.Forms.Button();
            this.btnRegresarInicioMedicos = new System.Windows.Forms.Button();
            this.btEliminarMedico = new System.Windows.Forms.Button();
            this.btEditarMedico = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxMedicos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblMedicos);
            this.panel2.Controls.Add(this.picturaBoxMedicos);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 354);
            this.panel2.TabIndex = 2;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMedicos.Location = new System.Drawing.Point(39, 189);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(176, 39);
            this.lblMedicos.TabIndex = 0;
            this.lblMedicos.Text = "Medicos";
            // 
            // picturaBoxMedicos
            // 
            this.picturaBoxMedicos.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxMedicos.Image")));
            this.picturaBoxMedicos.Location = new System.Drawing.Point(24, 58);
            this.picturaBoxMedicos.Name = "picturaBoxMedicos";
            this.picturaBoxMedicos.Size = new System.Drawing.Size(205, 128);
            this.picturaBoxMedicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxMedicos.TabIndex = 1;
            this.picturaBoxMedicos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridMedicos);
            this.panel1.Location = new System.Drawing.Point(292, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 354);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridMedicos
            // 
            this.dataGridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicos.Location = new System.Drawing.Point(3, 3);
            this.dataGridMedicos.Name = "dataGridMedicos";
            this.dataGridMedicos.RowHeadersWidth = 51;
            this.dataGridMedicos.RowTemplate.Height = 24;
            this.dataGridMedicos.Size = new System.Drawing.Size(624, 348);
            this.dataGridMedicos.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btEditarMedico);
            this.panel3.Controls.Add(this.btEliminarMedico);
            this.panel3.Controls.Add(this.btnAgregarInicioMedicos);
            this.panel3.Controls.Add(this.btnRegistroMedicos);
            this.panel3.Controls.Add(this.btnRegresarInicioMedicos);
            this.panel3.Location = new System.Drawing.Point(13, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 121);
            this.panel3.TabIndex = 4;
            // 
            // btnAgregarInicioMedicos
            // 
            this.btnAgregarInicioMedicos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarInicioMedicos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicioMedicos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInicioMedicos.Location = new System.Drawing.Point(239, 68);
            this.btnAgregarInicioMedicos.Name = "btnAgregarInicioMedicos";
            this.btnAgregarInicioMedicos.Size = new System.Drawing.Size(205, 36);
            this.btnAgregarInicioMedicos.TabIndex = 2;
            this.btnAgregarInicioMedicos.Text = "Agregar";
            this.btnAgregarInicioMedicos.UseVisualStyleBackColor = false;
            this.btnAgregarInicioMedicos.Click += new System.EventHandler(this.btnAgregarInicioMedicos_Click);
            // 
            // btnRegistroMedicos
            // 
            this.btnRegistroMedicos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistroMedicos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroMedicos.ForeColor = System.Drawing.Color.White;
            this.btnRegistroMedicos.Location = new System.Drawing.Point(9, 14);
            this.btnRegistroMedicos.Name = "btnRegistroMedicos";
            this.btnRegistroMedicos.Size = new System.Drawing.Size(205, 36);
            this.btnRegistroMedicos.TabIndex = 1;
            this.btnRegistroMedicos.Text = "Reporte";
            this.btnRegistroMedicos.UseVisualStyleBackColor = false;
            this.btnRegistroMedicos.Click += new System.EventHandler(this.btnRegistroMedicos_Click);
            // 
            // btnRegresarInicioMedicos
            // 
            this.btnRegresarInicioMedicos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarInicioMedicos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarInicioMedicos.ForeColor = System.Drawing.Color.White;
            this.btnRegresarInicioMedicos.Location = new System.Drawing.Point(9, 68);
            this.btnRegresarInicioMedicos.Name = "btnRegresarInicioMedicos";
            this.btnRegresarInicioMedicos.Size = new System.Drawing.Size(205, 36);
            this.btnRegresarInicioMedicos.TabIndex = 0;
            this.btnRegresarInicioMedicos.Text = "Regresar";
            this.btnRegresarInicioMedicos.UseVisualStyleBackColor = false;
            this.btnRegresarInicioMedicos.Click += new System.EventHandler(this.btnRegresarInicioMedicos_Click);
            // 
            // btEliminarMedico
            // 
            this.btEliminarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEliminarMedico.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarMedico.ForeColor = System.Drawing.Color.White;
            this.btEliminarMedico.Location = new System.Drawing.Point(464, 68);
            this.btEliminarMedico.Name = "btEliminarMedico";
            this.btEliminarMedico.Size = new System.Drawing.Size(205, 36);
            this.btEliminarMedico.TabIndex = 3;
            this.btEliminarMedico.Text = "Eliminar";
            this.btEliminarMedico.UseVisualStyleBackColor = false;
            this.btEliminarMedico.Click += new System.EventHandler(this.btEliminarMedico_Click);
            // 
            // btEditarMedico
            // 
            this.btEditarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEditarMedico.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarMedico.ForeColor = System.Drawing.Color.White;
            this.btEditarMedico.Location = new System.Drawing.Point(686, 68);
            this.btEditarMedico.Name = "btEditarMedico";
            this.btEditarMedico.Size = new System.Drawing.Size(205, 36);
            this.btEditarMedico.TabIndex = 4;
            this.btEditarMedico.Text = "Editar";
            this.btEditarMedico.UseVisualStyleBackColor = false;
            // 
            // FrmInicioMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(934, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmInicioMedicos";
            this.Text = "FrmInicioMedicos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxMedicos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.PictureBox picturaBoxMedicos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridMedicos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgregarInicioMedicos;
        private System.Windows.Forms.Button btnRegistroMedicos;
        private System.Windows.Forms.Button btnRegresarInicioMedicos;
        private System.Windows.Forms.Button btEditarMedico;
        private System.Windows.Forms.Button btEliminarMedico;
    }
}