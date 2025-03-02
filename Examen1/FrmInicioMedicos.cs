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
using DAL;

namespace Examen1
{
    public partial class FrmInicioMedicos: Form
    {
        private Conexion _conexion = null;
        public FrmInicioMedicos()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dataGridMedicos.DataSource = _conexion.ObtenerMedicos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresarInicioMedicos_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnRegistroMedicos_Click(object sender, EventArgs e)
        {
            FrmReporteMedicos frmReporteMedicos = new FrmReporteMedicos();
            this.Hide();
            frmReporteMedicos.Show();
        }

        private void btnAgregarInicioMedicos_Click(object sender, EventArgs e)
        {
            FrmAgregarMedico frmAgregarMedico = new FrmAgregarMedico();
            this.Hide();
            frmAgregarMedico.Show();
        }

        private void btEliminarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridMedicos.SelectedRows.Count > 0)
                {
                    // Obtener el ID del medico de la fila seleccionada
                    int idMedico = Convert.ToInt32(dataGridMedicos.SelectedRows[0].Cells["IDMedico"].Value);

                    // Obtener el nombre del medico
                    string nombreMedico = dataGridMedicos.SelectedRows[0].Cells["NombreCompleto"].Value.ToString();

                    // Mostrar mensaje de confirmación con el nombre del medico
                    var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al medico {nombreMedico}?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {

                        _conexion.EliminarMedico(idMedico);


                        MessageBox.Show("Paciente eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridMedicos.DataSource = _conexion.ObtenerMedicos();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un medico para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el medico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
