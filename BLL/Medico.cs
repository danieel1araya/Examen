public class Medico
{
    public int? IDMedico { get; set; }  // Puede ser nulo al agregar
    public string NombreCompleto { get; set; }
    public string Especialidad { get; set; }
    public string Telefono { get; set; }
    public string Foto { get; set; }
    public string HorarioAtencion { get; set; }
    public int LimiteCitas { get; set; }
    public string Estado { get; set; }

    public Medico() { }

    public Medico(int? idMedico, string nombreCompleto, string especialidad, string telefono,
                  string foto, string horarioAtencion, int limiteCitas, string estado)
    {
        IDMedico = idMedico;
        NombreCompleto = nombreCompleto;
        Especialidad = especialidad;
        Telefono = telefono;
        Foto = foto;
        HorarioAtencion = horarioAtencion;
        LimiteCitas = limiteCitas;
        Estado = estado;
    }
}
