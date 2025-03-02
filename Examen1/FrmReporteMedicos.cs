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
    public partial class FrmReporteMedicos: Form
    {
        public FrmReporteMedicos()
        {
            InitializeComponent();
        }

        private void btnRegresarReporteMedicos_Click(object sender, EventArgs e)
        {
            FrmInicioMedicos frmInicioMedicos = new FrmInicioMedicos();
            this.Hide();
            frmInicioMedicos.Show();
        }
    }
}
