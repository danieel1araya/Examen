namespace Examen1
{
    partial class FrmInicioCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioCitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCitas = new System.Windows.Forms.DataGridView();
            this.lblCitas = new System.Windows.Forms.Label();
            this.picturaBoxCitas = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresarCitas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarInicoCitas = new System.Windows.Forms.Button();
            this.btnReporteCitas = new System.Windows.Forms.Button();
            this.btEliminarCita = new System.Windows.Forms.Button();
            this.btEditarCita = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxCitas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridCitas);
            this.panel1.Location = new System.Drawing.Point(292, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 362);
            this.panel1.TabIndex = 0;
            // 
            // dataGridCitas
            // 
            this.dataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCitas.Location = new System.Drawing.Point(3, 3);
            this.dataGridCitas.Name = "dataGridCitas";
            this.dataGridCitas.RowHeadersWidth = 51;
            this.dataGridCitas.RowTemplate.Height = 24;
            this.dataGridCitas.Size = new System.Drawing.Size(604, 356);
            this.dataGridCitas.TabIndex = 0;
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCitas.Location = new System.Drawing.Point(66, 189);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(119, 39);
            this.lblCitas.TabIndex = 0;
            this.lblCitas.Text = "Citas";
            this.lblCitas.Click += new System.EventHandler(this.label1_Click);
            // 
            // picturaBoxCitas
            // 
            this.picturaBoxCitas.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxCitas.Image")));
            this.picturaBoxCitas.Location = new System.Drawing.Point(24, 58);
            this.picturaBoxCitas.Name = "picturaBoxCitas";
            this.picturaBoxCitas.Size = new System.Drawing.Size(205, 128);
            this.picturaBoxCitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxCitas.TabIndex = 1;
            this.picturaBoxCitas.TabStop = false;
            this.picturaBoxCitas.Click += new System.EventHandler(this.picturaBoxCitas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCitas);
            this.panel2.Controls.Add(this.picturaBoxCitas);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 362);
            this.panel2.TabIndex = 1;
            // 
            // btnRegresarCitas
            // 
            this.btnRegresarCitas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarCitas.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCitas.ForeColor = System.Drawing.Color.White;
            this.btnRegresarCitas.Location = new System.Drawing.Point(13, 67);
            this.btnRegresarCitas.Name = "btnRegresarCitas";
            this.btnRegresarCitas.Size = new System.Drawing.Size(205, 36);
            this.btnRegresarCitas.TabIndex = 0;
            this.btnRegresarCitas.Text = "Regresar";
            this.btnRegresarCitas.UseVisualStyleBackColor = false;
            this.btnRegresarCitas.Click += new System.EventHandler(this.btnRegresarCitas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btEditarCita);
            this.panel3.Controls.Add(this.btEliminarCita);
            this.panel3.Controls.Add(this.btnAgregarInicoCitas);
            this.panel3.Controls.Add(this.btnReporteCitas);
            this.panel3.Controls.Add(this.btnRegresarCitas);
            this.panel3.Location = new System.Drawing.Point(12, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 112);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnAgregarInicoCitas
            // 
            this.btnAgregarInicoCitas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarInicoCitas.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicoCitas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInicoCitas.Location = new System.Drawing.Point(233, 67);
            this.btnAgregarInicoCitas.Name = "btnAgregarInicoCitas";
            this.btnAgregarInicoCitas.Size = new System.Drawing.Size(205, 36);
            this.btnAgregarInicoCitas.TabIndex = 2;
            this.btnAgregarInicoCitas.Text = "Agregar";
            this.btnAgregarInicoCitas.UseVisualStyleBackColor = false;
            this.btnAgregarInicoCitas.Click += new System.EventHandler(this.btnAgregarInicoCitas_Click);
            // 
            // btnReporteCitas
            // 
            this.btnReporteCitas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporteCitas.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCitas.ForeColor = System.Drawing.Color.White;
            this.btnReporteCitas.Location = new System.Drawing.Point(13, 17);
            this.btnReporteCitas.Name = "btnReporteCitas";
            this.btnReporteCitas.Size = new System.Drawing.Size(205, 36);
            this.btnReporteCitas.TabIndex = 1;
            this.btnReporteCitas.Text = "Reporte";
            this.btnReporteCitas.UseVisualStyleBackColor = false;
            this.btnReporteCitas.Click += new System.EventHandler(this.btnReporteCitas_Click);
            // 
            // btEliminarCita
            // 
            this.btEliminarCita.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEliminarCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btEliminarCita.Location = new System.Drawing.Point(460, 67);
            this.btEliminarCita.Name = "btEliminarCita";
            this.btEliminarCita.Size = new System.Drawing.Size(205, 36);
            this.btEliminarCita.TabIndex = 3;
            this.btEliminarCita.Text = "Eliminar";
            this.btEliminarCita.UseVisualStyleBackColor = false;
            this.btEliminarCita.Click += new System.EventHandler(this.btEliminarCita_Click);
            // 
            // btEditarCita
            // 
            this.btEditarCita.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEditarCita.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarCita.ForeColor = System.Drawing.Color.White;
            this.btEditarCita.Location = new System.Drawing.Point(682, 67);
            this.btEditarCita.Name = "btEditarCita";
            this.btEditarCita.Size = new System.Drawing.Size(205, 36);
            this.btEditarCita.TabIndex = 4;
            this.btEditarCita.Text = "Editar";
            this.btEditarCita.UseVisualStyleBackColor = false;
            // 
            // FrmInicioCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(914, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInicioCitas";
            this.Text = "FrmInicioCitas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxCitas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Button btnRegresarCitas;
        private System.Windows.Forms.PictureBox picturaBoxCitas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridCitas;
        private System.Windows.Forms.Button btnAgregarInicoCitas;
        private System.Windows.Forms.Button btnReporteCitas;
        private System.Windows.Forms.Button btEditarCita;
        private System.Windows.Forms.Button btEliminarCita;
    }
}