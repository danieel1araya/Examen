using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CitaMedica
    {
        public int IDCita { get; set; } 
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public int IDPaciente { get; set; } 
        public int IDMedico { get; set; } 
        public string Motivo { get; set; }
        public string Estado { get; set; } 
        public string Observaciones { get; set; }
        public string Tipo { get; set; } 

        public CitaMedica(int idCita, DateTime fechaHoraInicio, DateTime fechaHoraFin, int idPaciente, int idMedico,
                          string motivo, string estado, string observaciones, string tipo)
        {
            IDCita = idCita;
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraFin = fechaHoraFin;
            IDPaciente = idPaciente;
            IDMedico = idMedico;
            Motivo = motivo;
            Estado = estado;
            Observaciones = observaciones;
            Tipo = tipo;
        }
    }

}
