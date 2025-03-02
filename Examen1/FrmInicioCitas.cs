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
    public partial class FrmInicioCitas: Form
    {
        private Conexion _conexion = null;
        public FrmInicioCitas()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dataGridCitas.DataSource = _conexion.ObtenerCitas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarCitas_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Hide();
            frmPrincipal.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBoxLogoCitas_Click(object sender, EventArgs e)
        {

        }

        private void lblMedControl_Click(object sender, EventArgs e)
        {

        }

        private void picturaBoxCitas_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarInicoCitas_Click(object sender, EventArgs e)
        {
            FrmAgregarCita frmAgregarCita = new FrmAgregarCita();
            this.Hide();
            frmAgregarCita.Show();
        }

        private void btnReporteCitas_Click(object sender, EventArgs e)
        {
            FrmReporteCitas frmReporteCitas = new FrmReporteCitas();
            this.Hide();
            frmReporteCitas.Show();
        }

        private void btEliminarCita_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridCitas.SelectedRows.Count > 0)
                {
                    // Obtener el ID de la cita de la fila seleccionada
                    int idCita = Convert.ToInt32(dataGridCitas.SelectedRows[0].Cells["IDCita"].Value);

                   

                    // Mostrar mensaje de confirmación con el nombre del medico
                    var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar la cita ?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {

                        _conexion.EliminarCita(idCita);


                        MessageBox.Show("Cita eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridCitas.DataSource = _conexion.ObtenerCitas();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una cita para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
