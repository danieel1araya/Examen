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
    public partial class FrmReporteCitas: Form
    {
        public FrmReporteCitas()
        {
            InitializeComponent();
        }

        private void btnRegresarReporteCitas_Click(object sender, EventArgs e)
        {
            FrmInicioCitas frmInicioCitas = new FrmInicioCitas();
            this.Hide();
            frmInicioCitas.Show();
        }
    }
}
