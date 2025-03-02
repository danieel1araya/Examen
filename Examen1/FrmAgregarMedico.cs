using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DAL;

namespace Examen1
{
    public partial class FrmAgregarMedico: Form
    {
        private Conexion _conexion = null;

        private Medico objMedico = null;
        private string NombreCompleto;
        private string Especialidad;
        private string Telefono;
        private string Foto;
        private string horarioAtencion;
        private int limiteCitas;
        private string Estado;
        private PictureBox pbFotoMedico;
        private string rutaFoto;

        public FrmAgregarMedico()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            // Inicializar pbFotoMedico
            pbFotoMedico = new PictureBox();
            pbFotoMedico.Name = "pbFotoMedico";
            pbFotoMedico.Size = new Size(120, 120);
            pbFotoMedico.Location = new Point(20, 20);
            pbFotoMedico.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoMedico.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(pbFotoMedico); // Agregar al formulario
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarAgregarMedico_Click(object sender, EventArgs e)
        {
            FrmInicioMedicos frmInicioMedicos = new FrmInicioMedicos();
            this.Hide();
            frmInicioMedicos.Show();
        }

    
        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombreCompletoMedico.Text))
                {
                    MessageBox.Show("El nombre completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbEspecialidadMedico.SelectedItem == null ||
                    !new[] { "Pediatría", "Cardiología", "Medicina General" }.Contains(cbEspecialidadMedico.SelectedItem.ToString()))
                {
                    MessageBox.Show("Debe seleccionar una especialidad válida (Pediatría, Cardiología, Medicina General).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefonoMedico.Text.Trim(), @"^\+\d{1,3}\s\d{7,15}$"))
                {
                    MessageBox.Show("El teléfono debe tener el formato: +Código de país + número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TelefonoYaRegistrado(txtTelefonoMedico.Text.Trim())) // Verificamos si el teléfono ya está registrado
                {
                    MessageBox.Show("El número de teléfono ya está registrado en otro médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtHoraAtencionMedico.Text.Trim(), @"^\d{2}:\d{2}-\d{2}:\d{2}$"))
                {
                    MessageBox.Show("El horario de atención debe tener el formato hh:mm-hh:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar que el campo de límite de citas tenga un valor
                if (string.IsNullOrWhiteSpace(txtLimiteCitasMedico.Text))
                {
                    MessageBox.Show("El límite de citas debe ser calculado y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de estado
                if (cbEstadoMedico.SelectedItem == null ||
                    !new[] { "Disponible", "Ocupado", "Vacaciones", "Licencia médica" }.Contains(cbEstadoMedico.SelectedItem.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un estado válido (Disponible, Ocupado, Vacaciones, Licencia médica).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Creación del objeto Medico
                Medico objMedico = new Medico
                {
                    NombreCompleto = txtNombreCompletoMedico.Text.Trim(),
                    Especialidad = cbEspecialidadMedico.SelectedItem.ToString(),
                    Telefono = txtTelefonoMedico.Text.Trim(),
                    Foto = rutaFoto,
                    HorarioAtencion = txtHoraAtencionMedico.Text.Trim(),
                    LimiteCitas = int.Parse(txtLimiteCitasMedico.Text), // Usamos el valor calculado
                    Estado = cbEstadoMedico.SelectedItem.ToString()
                };

                // Guardar en la base de datos
                _conexion.GuardarMedico(objMedico);

                MessageBox.Show("Médico agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                // Cerrar el formulario actual
                this.Close();

                // Crear y mostrar el formulario de inicio de médicos
                FrmInicioMedicos frmInicioMedicos = new FrmInicioMedicos();
                frmInicioMedicos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el médico: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar si el número de teléfono ya está registrado
        private bool TelefonoYaRegistrado(string telefono)
        {
            // Realizamos una consulta para verificar si el número de teléfono ya existe
            string query = "SELECT COUNT(*) FROM Medicos WHERE Telefono = @Telefono";
            var parametros = new Dictionary<string, object>
    {
        { "@Telefono", telefono }
    };

            int count = _conexion.EjecutarConsultaEscalar(query, parametros);
            return count > 0; // Si el número de teléfono ya existe, retornamos true
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = openFileDialog.FileName;

                if (pbFotoMedico != null)  // 🔹 Evitar error de referencia nula
                {
                    pbFotoMedico.Image = Image.FromFile(rutaFoto); // Mostrar la imagen en el PictureBox
                }
                else
                {
                    MessageBox.Show("Error: El PictureBox no está inicializado.");
                }
            }
        }

        private void PicturaBoxPacientes_Click(object sender, EventArgs e)
        {

        }

        private void txtLimiteCitasMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoraAtencionMedico_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Validación del formato del horario de atención
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtHoraAtencionMedico.Text.Trim(), @"^\d{2}:\d{2}-\d{2}:\d{2}$"))
                {
                    // Limpiar el límite de citas si el formato no es válido
                    txtLimiteCitasMedico.Text = "";
                    return;
                }

                // Dividir el horario de atención en hora de inicio y hora de fin
                string[] horas = txtHoraAtencionMedico.Text.Split('-');
                TimeSpan horaInicio = TimeSpan.Parse(horas[0]);
                TimeSpan horaFin = TimeSpan.Parse(horas[1]);

                if (horaInicio >= horaFin)
                {
                    // Limpiar el límite de citas si la hora de inicio no es menor que la de fin
                    txtLimiteCitasMedico.Text = "";
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cálculo del límite de citas basado en un intervalo de 30 minutos
                int totalMinutos = (int)(horaFin - horaInicio).TotalMinutes;
                //se le resta la hora de descanso
                totalMinutos= totalMinutos - 60;
                int limiteCitas = totalMinutos / 30;

                // Actualizar el campo de límite de citas con el valor calculado
                txtLimiteCitasMedico.Text = limiteCitas.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el límite de citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
