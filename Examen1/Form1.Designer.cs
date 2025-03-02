namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPaginaPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaginaPrincipal
            // 
            this.lblPaginaPrincipal.AutoSize = true;
            this.lblPaginaPrincipal.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaPrincipal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPaginaPrincipal.Location = new System.Drawing.Point(237, 65);
            this.lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            this.lblPaginaPrincipal.Size = new System.Drawing.Size(0, 37);
            this.lblPaginaPrincipal.TabIndex = 1;
            this.lblPaginaPrincipal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaginaPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPaginaPrincipal;
    }
}

