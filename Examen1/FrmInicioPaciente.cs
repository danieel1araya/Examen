using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class FrmInicioPaciente: Form
    {
       
        public FrmInicioPaciente()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dataGridPacientes.DataSource = _conexion.ObtenerPacientes();
        }

        private void FrmInicioPaciente_Load(object sender, EventArgs e)
        {

        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {

        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnAgregarInicioPaciente_Click(object sender, EventArgs e)
        {
            FrmAgregarPaciente frmAgregarPaciente = new FrmAgregarPaciente();
            this.Hide();
            frmAgregarPaciente.Show();

        }

        private void btnReportePacientes_Click(object sender, EventArgs e)
        {
            FrmReportePacientes frmReportePacientes = new FrmReportePacientes();
            this.Hide();
            frmReportePacientes.Show();
        }

        private void btnRegresarInicioPacientes_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
