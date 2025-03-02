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
    public partial class FrmAgregarCita: Form
    {
        public FrmAgregarCita()
        {
            InitializeComponent();
            dtFechaCita.Format = DateTimePickerFormat.Custom;
            dtFechaCita.CustomFormat = "dd/MM/yyyy HH:mm";
            dtFechaCita.ShowUpDown = true; // Permite ajustar la hora con flechas
            dtFechaCita.MinDate = DateTime.Now; // Evita fechas pasadas
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

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {

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

    }
}
