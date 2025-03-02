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
        private DataTable _dtPacientes;

        public FrmInicioPaciente()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dataGridPacientes.DataSource = _conexion.ObtenerPacientes();
            CargarPacientes();
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

        private void CargarPacientes()
        {
            _dtPacientes = _conexion.ObtenerPacientes(); // Obtener los pacientes de la BD
            dataGridPacientes.DataSource = _dtPacientes;
        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            FiltrarPacientes(txtBuscarPaciente.Text);
        }

        private void FiltrarPacientes(string nombre)
        {
            if (_dtPacientes != null)
            {
                DataView dv = _dtPacientes.DefaultView;
                dv.RowFilter = $"NombreCompleto LIKE '%{nombre}%'";
                dataGridPacientes.DataSource = dv;
            }
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

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridPacientes.SelectedRows.Count > 0)
            {
                int idPaciente = Convert.ToInt32(dataGridPacientes.SelectedRows[0].Cells["IDPaciente"].Value);
                FrmEditarPaciente frmEditar = new FrmEditarPaciente(idPaciente);
                this.Hide();
                frmEditar.Show();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
