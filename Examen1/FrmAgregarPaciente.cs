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
    public partial class FrmAgregarPaciente: Form
    {

        private Conexion _conexion = null;

        private Paciente objPaciente = null;
        private string NombreCompleto;
        private DateTime fechaNacimiento;
        private string Genero;
        private string Telefono;
        private string Foto;
        private string Direccion;
        private string Estado;
        private PictureBox pbFotoPaciente;
        private string rutaFoto;
        public FrmAgregarPaciente()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            // Inicializar pbFotoMedico
            pbFotoPaciente = new PictureBox();
            pbFotoPaciente.Name = "pbFotoPaciente";
            pbFotoPaciente.Size = new Size(120, 120);
            pbFotoPaciente.Location = new Point(20, 20);
            pbFotoPaciente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoPaciente.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(pbFotoPaciente); // Agregar al formulario
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreCompleto_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



       

        private void btnSeleccionarFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = openFileDialog.FileName;

                if (pbFotoPaciente != null)  // 🔹 Evitar error de referencia nula
                {
                    pbFotoPaciente.Image = Image.FromFile(rutaFoto); // Mostrar la imagen en el PictureBox
                }
                else
                {
                    MessageBox.Show("Error: El PictureBox no está inicializado.");
                }
            }
        }

        private void btnAgregarPaciente_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombreCompletoPaciente.Text))
                {
                    MessageBox.Show("El nombre completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime fechaNacimiento = dateTimePicker1.Value;

                if (cbGeneroPaciente.SelectedItem == null || string.IsNullOrWhiteSpace(cbGeneroPaciente.SelectedItem.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefonoPaciente.Text.Trim(), @"^\+\d{1,3}\s\d{7,15}$"))
                {
                    MessageBox.Show("El teléfono debe tener el formato: +Código de país + número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si el teléfono ya está registrado
                if (TelefonoYaRegistradoPaciente(txtTelefonoPaciente.Text.Trim()))
                {
                    MessageBox.Show("El teléfono ya está registrado en otro paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbEstadoPaciente.SelectedItem == null || string.IsNullOrWhiteSpace(cbEstadoPaciente.SelectedItem.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtDireccionPaciente.Text))
                {
                    if (txtDireccionPaciente.Text.Length < 20 || txtDireccionPaciente.Text.Length > 500)
                    {
                        MessageBox.Show("La dirección debe tener entre 20 y 500 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Creación del objeto Paciente
                Paciente objPaciente = new Paciente(
                    txtNombreCompletoPaciente.Text.Trim(),
                    fechaNacimiento,
                    cbGeneroPaciente.SelectedItem.ToString(),
                    txtTelefonoPaciente.Text.Trim(),
                    cbEstadoPaciente.SelectedItem.ToString(),
                    txtDireccionPaciente.Text.Trim(),
                    rutaFoto
                );

                // Guardar en la base de datos
                _conexion.GuardarPaciente(objPaciente);

                MessageBox.Show("Paciente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario actual
                this.Close();

                // Crear y mostrar el formulario de inicio de médicos
                FrmInicioPaciente frmInicioPaciente= new FrmInicioPaciente();
                frmInicioPaciente.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el paciente: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public bool TelefonoYaRegistradoPaciente(string telefono)
        {
            // Consulta SQL para contar la cantidad de registros con ese teléfono
            string query = "SELECT COUNT(*) FROM Pacientes WHERE Telefono = @Telefono";

            // Parámetros para la consulta
            var parametros = new Dictionary<string, object>
    {
        { "@Telefono", telefono }
    };

            // Usar el método EjecutarConsultaEscalar para obtener el resultado
            int count = _conexion.EjecutarConsultaEscalar(query, parametros);

            // Si el conteo es mayor que 0, el teléfono ya está registrado
            return count > 0;
        }



        private void btnRegresarInicioPaciente_Click(object sender, EventArgs e)
        {
            FrmInicioPaciente frmInicioPaciente = new FrmInicioPaciente();
            this.Hide();
            frmInicioPaciente.Show();
        }
    }
}
