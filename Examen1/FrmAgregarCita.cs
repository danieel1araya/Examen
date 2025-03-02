using BLL;
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
    public partial class FrmAgregarCita: Form
    {

        private Conexion _conexion = null;
        private CitaMedica objCita = null;
        public FrmAgregarCita()
        {
            InitializeComponent();
            dtFechaCita.Format = DateTimePickerFormat.Custom;
            dtFechaCita.CustomFormat = "dd/MM/yyyy HH:mm";
            dtFechaCita.ShowUpDown = true; // Permite ajustar la hora con flechas
            dtFechaCita.MinDate = DateTime.Now; // Evita fechas pasadas
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            CargarComboPacientes();
        }

        private void btnRegresarCitas_Click(object sender, EventArgs e)
        {
            FrmInicioCitas frmInicioCitas = new FrmInicioCitas();
            this.Hide();
            frmInicioCitas.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool VerificarDisponibilidadMedico(int idMedico, DateTime fecha)
        {
            // Consultar si ya existe una cita programada para este médico en esta fecha y hora
            string query = "SELECT COUNT(*) FROM Citas WHERE IDMedico = @Medico AND EstadoCita = 'Programada' AND FechaHoraInicio = @FechaHoraInicio";
            var parametros = new Dictionary<string, object> { { "@Medico", idMedico }, { "@FechaHoraInicio", fecha } };
            int count = Convert.ToInt32(_conexion.EjecutarConsulta(query, parametros).Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("El médico ya tiene una cita en este horario.");
                return false;
            }
            return true;
        }

        private bool VerificarDisponibilidadPaciente(int idPaciente, DateTime fecha)
        {
            // Consultar si el paciente ya tiene una cita programada para esta fecha y hora
            string query = "SELECT COUNT(*) FROM Citas WHERE IDPaciente = @Paciente AND EstadoCita = 'Programada' AND FechaHoraInicio = @FechaHoraInicio";
            var parametros = new Dictionary<string, object> { { "@Paciente", idPaciente }, { "@FechaHoraInicio", fecha } };
            int count = Convert.ToInt32(_conexion.EjecutarConsulta(query, parametros).Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("El paciente ya tiene una cita en este horario.");
                return false;
            }
            return true;
        }

        private bool VerificarLimiteCitasDiarias(int idMedico, DateTime fecha)
        {
            // Traer el límite de citas diarias del médico
            string queryLimite = "SELECT LimiteCitas FROM Medicos WHERE IDMedico = @Medico";
            var parametrosLimite = new Dictionary<string, object> { { "@Medico", idMedico } };
            int limiteCitasDiarias = Convert.ToInt32(_conexion.EjecutarConsulta(queryLimite, parametrosLimite).Rows[0][0]);

            // Verificar cuántas citas tiene el médico en ese día
            string queryCitas = "SELECT COUNT(*) FROM Citas WHERE IDMedico = @Medico AND EstadoCita = 'Programada' AND CAST(FechaHoraInicio AS DATE) = @Fecha";
            var parametrosCitas = new Dictionary<string, object> { { "@Medico", idMedico }, { "@Fecha", fecha.Date } };
            int citasDiarias = Convert.ToInt32(_conexion.EjecutarConsulta(queryCitas, parametrosCitas).Rows[0][0]);

            // Verificar si el límite de citas diarias se ha alcanzado
            if (citasDiarias >= limiteCitasDiarias)
            {
                MessageBox.Show("El médico ha alcanzado el límite de citas diarias.");
                return false;
            }

            return true;
        }

        private bool VerificarHorarioMedico(int idMedico, DateTime fecha)
        {
            string query = "SELECT HorarioAtencion FROM Medicos WHERE IDMedico = @Medico";
            var parametros = new Dictionary<string, object> { { "@Medico", idMedico } };
            string horario = _conexion.EjecutarConsulta(query, parametros).Rows[0][0].ToString();
            string[] partes = horario.Split('-');
            DateTime inicioHorario = DateTime.Parse(partes[0]);
            DateTime finHorario = DateTime.Parse(partes[1]);

            if (fecha.TimeOfDay < inicioHorario.TimeOfDay || fecha.TimeOfDay >= finHorario.TimeOfDay)
            {
                MessageBox.Show("El médico no atiende en este horario.");
                return false;
            }
            return true;
        }

        private bool VerificarEdadPaciente(int idPaciente, string tipoCita)
        {
            string query = "SELECT FechaNacimiento FROM Pacientes WHERE IDPaciente = @Paciente";
            var parametros = new Dictionary<string, object> { { "@Paciente", idPaciente } };
            DateTime fechaNacimiento = Convert.ToDateTime(_conexion.EjecutarConsulta(query, parametros).Rows[0][0]);
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Now.AddYears(-edad)) edad--;

            if (tipoCita == "Pediatría" && edad >= 18)
            {
                MessageBox.Show("El paciente es mayor de edad y no puede agendar una cita en Pediatría.");
                return false;
            }
            if (tipoCita == "Cardiología" && edad < 18)
            {
                MessageBox.Show("El paciente debe ser mayor de 18 años para una cita en Cardiología.");
                return false;
            }
            return true;
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un paciente
            if (comboBoxPacientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un médico
            if (comboBoxMedicos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un estado para la cita
            if (cbEstadoCita.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado para la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un tipo de cita
            if (cbTipoCita.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores después de validar que no son nulos
            DateTime fechaHoraInicio = dtFechaCita.Value;
            DateTime fechaHoraFin = fechaHoraInicio.AddMinutes(30);
            var pacienteSeleccionado = (KeyValuePair<int, string>)comboBoxPacientes.SelectedItem;
            var medicoSeleccionado = (KeyValuePair<int, string>)comboBoxMedicos.SelectedItem;
            string tipoCita = cbTipoCita.SelectedItem.ToString();

            // Validaciones lógicas
            if (!VerificarDisponibilidadMedico(medicoSeleccionado.Key, fechaHoraInicio)) return;
            if (!VerificarDisponibilidadPaciente(pacienteSeleccionado.Key, fechaHoraInicio)) return;
            if (!VerificarHorarioMedico(medicoSeleccionado.Key, fechaHoraInicio)) return;
            if (!VerificarLimiteCitasDiarias(medicoSeleccionado.Key, fechaHoraInicio)) return;
            if (!VerificarEdadPaciente(pacienteSeleccionado.Key, tipoCita)) return;

            // Crear la cita médica con valores validados
            CitaMedica objCita = new CitaMedica(
                fechaHoraInicio,               // Fecha y hora de inicio
                fechaHoraFin,                  // Fecha y hora de finalización (30 min después)
                pacienteSeleccionado.Key,      // ID Paciente
                medicoSeleccionado.Key,        // ID Médico
                txtMotivoCita.Text.Trim(),     // Motivo de la cita
                cbEstadoCita.SelectedItem.ToString(), // Estado de la cita
                txtObservacionesCita.Text.Trim(), // Observaciones
                tipoCita                       // Tipo de cita
            );

            // Guardar la cita en la base de datos
            _conexion.GuardarCita(objCita);
            MessageBox.Show("Cita agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario actual
            this.Close();

            // Crear y mostrar el formulario de inicio de médicos
            FrmInicioCitas frmInicioCitas = new FrmInicioCitas();
            frmInicioCitas.Show();

        }




        private void btnRegresarAgregarCita_Click(object sender, EventArgs e)
        {
            FrmInicioCitas frmInicioCitas = new FrmInicioCitas();
            this.Hide();
            frmInicioCitas.Show();
        }

        private void lblIngresarDatosCita_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaCita_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtFechaCita.Value;

            // Redondear los minutos a los 30 minutos más cercanos hacia arriba
            int minutos = selectedDate.Minute;
            int minutosRedondeados = (int)Math.Ceiling(minutos / 30.0) * 30;

            // Si el redondeo de minutos pasa de 59, incrementar la hora y poner minutos en 0
            if (minutosRedondeados == 60)
            {
                minutosRedondeados = 0;
                selectedDate = selectedDate.AddHours(1);  // Aumentar la hora en 1
            }

            // Crear la nueva fecha con los minutos redondeados
            DateTime nuevaFecha = new DateTime(
                selectedDate.Year, selectedDate.Month, selectedDate.Day,
                selectedDate.Hour, minutosRedondeados, 0
            );

            // Establecer la nueva fecha solo si está dentro del rango permitido por el DateTimePicker
            if (nuevaFecha >= dtFechaCita.MinDate && nuevaFecha <= dtFechaCita.MaxDate)
            {
                dtFechaCita.Value = nuevaFecha;
            }
            else
            {
                // Si la fecha redondeada está fuera del rango, no hacer nada o establecer el valor en el mínimo permitido
                MessageBox.Show("La hora seleccionada está fuera del rango permitido.");
                dtFechaCita.Value = dtFechaCita.MinDate;
            }

            DateTime fechaHoraInicio = dtFechaCita.Value;

            // Sumar 30 minutos a la fecha y hora de inicio
            DateTime fechaHoraFin = fechaHoraInicio.AddMinutes(30);

            // Actualizar el TextBox de fecha de fin con el valor calculado
            txtFechaFinalCita.Text = fechaHoraFin.ToString("dd/MM/yyyy HH:mm");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarComboPacientes()
        {
            string query = "SELECT IDPaciente, NombreCompleto FROM Pacientes WHERE Estado = 'Disponible'";

            var parametros = new Dictionary<string, object>();

            // Ejecutar la consulta y obtener la lista de pacientes
            DataTable pacientes = _conexion.EjecutarConsulta(query, parametros);

            // Limpiar el ComboBox antes de agregar nuevos elementos
            comboBoxPacientes.Items.Clear();

            // Agregar los pacientes al ComboBox
            foreach (DataRow row in pacientes.Rows)
            {
                comboBoxPacientes.Items.Add(new KeyValuePair<int, string>((int)row["IDPaciente"], (string)row["NombreCompleto"]));
            }

            // Configurar el display miembro y el valor miembro para el ComboBox
            comboBoxPacientes.DisplayMember = "Value";
            comboBoxPacientes.ValueMember = "Key";
        }


        private void CargarComboMedicos(string especialidad)
        {
            string query = "";

            // Si la especialidad es "Emergencia", cargar todos los médicos
            if (especialidad == "Emergencia")
            {
                query = "SELECT IDMedico, NombreCompleto FROM Medicos WHERE Estado = 'Disponible'";
            }
            else
            {
                query = "SELECT IDMedico, NombreCompleto FROM Medicos WHERE Estado = 'Disponible' AND Especialidad = @Especialidad";
            }

            // Crear los parámetros para la consulta
            var parametros = new Dictionary<string, object>
    {
        { "@Especialidad", especialidad }
    };

            // Ejecutar la consulta y obtener la lista de médicos
            DataTable medicos = _conexion.EjecutarConsulta(query, parametros);

            // Limpiar el ComboBox antes de agregar nuevos elementos
            comboBoxMedicos.Items.Clear();

            // Agregar los médicos al ComboBox
            foreach (DataRow row in medicos.Rows)
            {
                comboBoxMedicos.Items.Add(new KeyValuePair<int, string>((int)row["IDMedico"], (string)row["NombreCompleto"]));
            }

            // Configurar el display miembro y el valor miembro para el ComboBox
            comboBoxMedicos.DisplayMember = "Value";
            comboBoxMedicos.ValueMember = "Key";
        }

        private void cbTipoCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar la selección del ComboBox de médicos
            comboBoxMedicos.SelectedIndex = -1;

            // Limpiar cualquier otro campo si es necesario
            txtFechaFinalCita.Clear();

            // Obtener la especialidad seleccionada
            string especialidadSeleccionada = cbTipoCita.SelectedItem.ToString();

            // Llamar al método para cargar los médicos basados en la especialidad seleccionada
            CargarComboMedicos(especialidadSeleccionada);
        }
    }
}
