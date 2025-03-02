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
    public partial class FrmEditarMedico : Form
    {
        private Conexion _conexion = null;
        private int _idMedico;
        private string rutaFoto;
        private PictureBox pbFotoMedico;

        public FrmEditarMedico(int idMedico)
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            _idMedico = idMedico;

            // Inicializar pbFotoMedico
            pbFotoMedico = new PictureBox();
            pbFotoMedico.Name = "pbFotoMedico";
            pbFotoMedico.Size = new Size(120, 120);
            pbFotoMedico.Location = new Point(20, 20);
            pbFotoMedico.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoMedico.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(pbFotoMedico);
        }

        // Método para verificar si el número de teléfono ya está registrado
        private bool TelefonoYaRegistrado(string telefono)
        {
            string query = "SELECT COUNT(*) FROM Medicos WHERE Telefono = @Telefono";
            var parametros = new Dictionary<string, object>
            {
                { "@Telefono", telefono }
            };

            int count = _conexion.EjecutarConsultaEscalar(query, parametros);
            return count > 0;
        }

        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCompletoMedico.Text))
                {
                    MessageBox.Show("El nombre completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbEspecialidadMedico.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una especialidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string telefono = txtTelefonoMedico.Text.Trim();

                if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\+\d{1,3}\s\d{7,15}$"))
                {
                    MessageBox.Show("El teléfono debe tener el formato: +Código de país + número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TelefonoYaRegistrado(telefono))
                {
                    MessageBox.Show("El número de teléfono ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtHoraAtencionMedico.Text.Trim(), @"^\d{2}:\d{2}-\d{2}:\d{2}$"))
                {
                    MessageBox.Show("El horario de atención debe tener el formato hh:mm-hh:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🔹 Recalcular el límite de citas ANTES de guardarlo
                string[] horas = txtHoraAtencionMedico.Text.Split('-');
                TimeSpan horaInicio = TimeSpan.Parse(horas[0]);
                TimeSpan horaFin = TimeSpan.Parse(horas[1]);

                if (horaInicio >= horaFin)
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int totalMinutos = (int)(horaFin - horaInicio).TotalMinutes - 60; // Se resta la hora de descanso
                int limiteCitas = totalMinutos / 30;

                // 🔹 Asegurar que txtLimiteCitasMedico tenga el valor correcto
                txtLimiteCitasMedico.Text = limiteCitas.ToString();

                if (cbEstadoMedico.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un estado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Medico objMedico = new Medico
                {
                    IDMedico = _idMedico,
                    NombreCompleto = txtNombreCompletoMedico.Text.Trim(),
                    Especialidad = cbEspecialidadMedico.SelectedItem.ToString(),
                    Telefono = telefono,
                    Foto = rutaFoto,
                    HorarioAtencion = txtHoraAtencionMedico.Text.Trim(),
                    LimiteCitas = int.Parse(txtLimiteCitasMedico.Text), // Ahora sí es el valor calculado
                    Estado = cbEstadoMedico.SelectedItem.ToString()
                };

                _conexion.ModificarMedico(objMedico);

                MessageBox.Show("Médico actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                FrmInicioMedicos frmInicioMedicos = new FrmInicioMedicos();
                frmInicioMedicos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el médico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = openFileDialog.FileName;
                pbFotoMedico.Image = Image.FromFile(rutaFoto);
            }
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
                totalMinutos = totalMinutos - 60;
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
