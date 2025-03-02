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
    public partial class FrmReportePacientes: Form
    {
        public FrmReportePacientes()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresarReportePacientes_Click(object sender, EventArgs e)
        {
            FrmInicioPaciente frmInicioPaciente = new FrmInicioPaciente();
            this.Hide();
            frmInicioPaciente.Show();
        }
    }
}
