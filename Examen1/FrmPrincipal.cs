using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class FrmPrincipal: Form
    {   

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show(this,"¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnInicioMedicos_Click(object sender, EventArgs e)
        {
            FrmInicioMedicos frmInicioMedicos = new FrmInicioMedicos();
            this.Hide();
            frmInicioMedicos.Show();
        }

        private void btnInicioCitas_Click(object sender, EventArgs e)
        {
            FrmInicioCitas frmInicioCitas = new FrmInicioCitas();
            this.Hide();
            frmInicioCitas.Show();

        }

        private void btnInicioPacientes_Click(object sender, EventArgs e)
        {
            FrmInicioPaciente frmInicioPaciente = new FrmInicioPaciente();
            this.Hide();
            frmInicioPaciente.Show();
        }
    }
}
