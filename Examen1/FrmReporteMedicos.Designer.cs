namespace Examen1
{
    partial class FrmReporteMedicos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegresarReporteMedicos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 344);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRegresarReporteMedicos
            // 
            this.btnRegresarReporteMedicos.BackColor = System.Drawing.Color.White;
            this.btnRegresarReporteMedicos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarReporteMedicos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresarReporteMedicos.Location = new System.Drawing.Point(10, 24);
            this.btnRegresarReporteMedicos.Name = "btnRegresarReporteMedicos";
            this.btnRegresarReporteMedicos.Size = new System.Drawing.Size(205, 36);
            this.btnRegresarReporteMedicos.TabIndex = 1;
            this.btnRegresarReporteMedicos.Text = "Regresar";
            this.btnRegresarReporteMedicos.UseVisualStyleBackColor = false;
            this.btnRegresarReporteMedicos.Click += new System.EventHandler(this.btnRegresarReporteMedicos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegresarReporteMedicos);
            this.panel2.Location = new System.Drawing.Point(3, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 79);
            this.panel2.TabIndex = 1;
            // 
            // FrmReporteMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporteMedicos";
            this.Text = "FrmReporteMedicos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegresarReporteMedicos;
        private System.Windows.Forms.Panel panel2;
    }
}