using DAL;
using System;
using System.Windows.Forms;

namespace Examen1
{
    
    partial class FrmInicioPaciente
    {

        private Conexion _conexion = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioPaciente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.picturaBoxPacientes = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnRegresarInicioPacientes = new System.Windows.Forms.Button();
            this.btnAgregarInicioPaciente = new System.Windows.Forms.Button();
            this.btnReportePacientes = new System.Windows.Forms.Button();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxPacientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPacientes);
            this.panel1.Controls.Add(this.picturaBoxPacientes);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 286);
            this.panel1.TabIndex = 2;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPacientes.Location = new System.Drawing.Point(16, 159);
            this.lblPacientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(169, 32);
            this.lblPacientes.TabIndex = 0;
            this.lblPacientes.Text = "Pacientes";
            this.lblPacientes.Click += new System.EventHandler(this.lblPacientes_Click);
            // 
            // picturaBoxPacientes
            // 
            this.picturaBoxPacientes.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxPacientes.Image")));
            this.picturaBoxPacientes.Location = new System.Drawing.Point(21, 44);
            this.picturaBoxPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturaBoxPacientes.Name = "picturaBoxPacientes";
            this.picturaBoxPacientes.Size = new System.Drawing.Size(150, 104);
            this.picturaBoxPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxPacientes.TabIndex = 1;
            this.picturaBoxPacientes.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtBuscarPaciente);
            this.panel2.Controls.Add(this.dataGridPacientes);
            this.panel2.Location = new System.Drawing.Point(219, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 342);
            this.panel2.TabIndex = 3;
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(2, 20);
            this.dataGridPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.RowHeadersWidth = 51;
            this.dataGridPacientes.RowTemplate.Height = 24;
            this.dataGridPacientes.Size = new System.Drawing.Size(663, 320);
            this.dataGridPacientes.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnEditarPaciente);
            this.panel3.Controls.Add(this.btnEliminarPaciente);
            this.panel3.Controls.Add(this.btnRegresarInicioPacientes);
            this.panel3.Controls.Add(this.btnAgregarInicioPaciente);
            this.panel3.Controls.Add(this.btnReportePacientes);
            this.panel3.Location = new System.Drawing.Point(30, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 101);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnEditarPaciente.Location = new System.Drawing.Point(521, 60);
            this.btnEditarPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(154, 28);
            this.btnEditarPaciente.TabIndex = 9;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.UseVisualStyleBackColor = false;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(352, 60);
            this.btnEliminarPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(154, 28);
            this.btnEliminarPaciente.TabIndex = 8;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnRegresarInicioPacientes
            // 
            this.btnRegresarInicioPacientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarInicioPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarInicioPacientes.ForeColor = System.Drawing.Color.White;
            this.btnRegresarInicioPacientes.Location = new System.Drawing.Point(9, 60);
            this.btnRegresarInicioPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresarInicioPacientes.Name = "btnRegresarInicioPacientes";
            this.btnRegresarInicioPacientes.Size = new System.Drawing.Size(154, 28);
            this.btnRegresarInicioPacientes.TabIndex = 7;
            this.btnRegresarInicioPacientes.Text = "Regresar";
            this.btnRegresarInicioPacientes.UseVisualStyleBackColor = false;
            this.btnRegresarInicioPacientes.Click += new System.EventHandler(this.btnRegresarInicioPacientes_Click);
            // 
            // btnAgregarInicioPaciente
            // 
            this.btnAgregarInicioPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarInicioPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicioPaciente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInicioPaciente.Location = new System.Drawing.Point(183, 60);
            this.btnAgregarInicioPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarInicioPaciente.Name = "btnAgregarInicioPaciente";
            this.btnAgregarInicioPaciente.Size = new System.Drawing.Size(154, 28);
            this.btnAgregarInicioPaciente.TabIndex = 6;
            this.btnAgregarInicioPaciente.Text = "Agregar";
            this.btnAgregarInicioPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarInicioPaciente.Click += new System.EventHandler(this.btnAgregarInicioPaciente_Click);
            // 
            // btnReportePacientes
            // 
            this.btnReportePacientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReportePacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePacientes.ForeColor = System.Drawing.Color.White;
            this.btnReportePacientes.Location = new System.Drawing.Point(9, 15);
            this.btnReportePacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportePacientes.Name = "btnReportePacientes";
            this.btnReportePacientes.Size = new System.Drawing.Size(154, 28);
            this.btnReportePacientes.TabIndex = 5;
            this.btnReportePacientes.Text = "Reporte";
            this.btnReportePacientes.UseVisualStyleBackColor = false;
            this.btnReportePacientes.Click += new System.EventHandler(this.btnReportePacientes_Click);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Location = new System.Drawing.Point(0, 0);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(662, 20);
            this.txtBuscarPaciente.TabIndex = 1;
            this.txtBuscarPaciente.TextChanged += new System.EventHandler(this.txtBuscarPaciente_TextChanged);
            // 
            // FrmInicioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(922, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInicioPaciente";
            this.Text = "FrmInicioPaciente";
            this.Load += new System.EventHandler(this.FrmInicioPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxPacientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.PictureBox picturaBoxPacientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReportePacientes;
        private System.Windows.Forms.Button btnAgregarInicioPaciente;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.Button btnRegresarInicioPacientes;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private Button btnEditarPaciente;
        private TextBox txtBuscarPaciente;
    }
}