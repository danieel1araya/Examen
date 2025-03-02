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
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnRegresarInicioPacientes = new System.Windows.Forms.Button();
            this.btnAgregarInicioPaciente = new System.Windows.Forms.Button();
            this.btnReportePacientes = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 352);
            this.panel1.TabIndex = 2;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPacientes.Location = new System.Drawing.Point(21, 196);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(207, 39);
            this.lblPacientes.TabIndex = 0;
            this.lblPacientes.Text = "Pacientes";
            this.lblPacientes.Click += new System.EventHandler(this.lblPacientes_Click);
            // 
            // picturaBoxPacientes
            // 
            this.picturaBoxPacientes.Image = ((System.Drawing.Image)(resources.GetObject("picturaBoxPacientes.Image")));
            this.picturaBoxPacientes.Location = new System.Drawing.Point(28, 54);
            this.picturaBoxPacientes.Name = "picturaBoxPacientes";
            this.picturaBoxPacientes.Size = new System.Drawing.Size(200, 128);
            this.picturaBoxPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturaBoxPacientes.TabIndex = 1;
            this.picturaBoxPacientes.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridPacientes);
            this.panel2.Location = new System.Drawing.Point(292, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 355);
            this.panel2.TabIndex = 3;
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(3, 3);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.RowHeadersWidth = 51;
            this.dataGridPacientes.RowTemplate.Height = 24;
            this.dataGridPacientes.Size = new System.Drawing.Size(627, 349);
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
            this.panel3.Location = new System.Drawing.Point(12, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 124);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(470, 74);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(206, 35);
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
            this.btnRegresarInicioPacientes.Location = new System.Drawing.Point(12, 74);
            this.btnRegresarInicioPacientes.Name = "btnRegresarInicioPacientes";
            this.btnRegresarInicioPacientes.Size = new System.Drawing.Size(205, 35);
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
            this.btnAgregarInicioPaciente.Location = new System.Drawing.Point(244, 74);
            this.btnAgregarInicioPaciente.Name = "btnAgregarInicioPaciente";
            this.btnAgregarInicioPaciente.Size = new System.Drawing.Size(206, 35);
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
            this.btnReportePacientes.Location = new System.Drawing.Point(12, 18);
            this.btnReportePacientes.Name = "btnReportePacientes";
            this.btnReportePacientes.Size = new System.Drawing.Size(205, 35);
            this.btnReportePacientes.TabIndex = 5;
            this.btnReportePacientes.Text = "Reporte";
            this.btnReportePacientes.UseVisualStyleBackColor = false;
            this.btnReportePacientes.Click += new System.EventHandler(this.btnReportePacientes_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarPaciente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnEditarPaciente.Location = new System.Drawing.Point(695, 74);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(206, 35);
            this.btnEditarPaciente.TabIndex = 9;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.UseVisualStyleBackColor = false;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            // 
            // FrmInicioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(934, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInicioPaciente";
            this.Text = "FrmInicioPaciente";
            this.Load += new System.EventHandler(this.FrmInicioPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturaBoxPacientes)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridPacientes.SelectedRows.Count > 0)
                {
                    // Obtener el ID del paciente de la fila seleccionada
                    int idPaciente = Convert.ToInt32(dataGridPacientes.SelectedRows[0].Cells["IDPaciente"].Value);

                    // Obtener el nombre del paciente
                    string nombrePaciente = dataGridPacientes.SelectedRows[0].Cells["NombreCompleto"].Value.ToString();

                    // Mostrar mensaje de confirmación con el nombre del paciente
                    var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al paciente {nombrePaciente}?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Llamar al método EliminarPaciente de la clase Conexion
                        _conexion.EliminarPaciente(idPaciente);  // Aquí estamos utilizando el método de tu clase Conexion

                        
                        MessageBox.Show("Paciente eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridPacientes.DataSource = _conexion.ObtenerPacientes();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un paciente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
    }
}