using System;

public class Paciente
{
    public int? IDPaciente { get; set; }  // Puede ser nulo al agregar
    public string NombreCompleto { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Genero { get; set; } 
    public string Telefono { get; set; } 
    public string Estado { get; set; } 
    public string Direccion { get; set; }
    public string Foto { get; set; }

    public Paciente(int? idPaciente, string nombreCompleto , DateTime fechaNacimiento, string genero,
                    string telefono, string estado, string direccion, string foto)
    {
        IDPaciente = idPaciente;
        NombreCompleto = nombreCompleto;
        FechaNacimiento = fechaNacimiento;
        Genero = genero;
        Telefono = telefono;
        Estado = estado;
        Direccion = direccion;
        Foto = foto;
    }
    public Paciente(string nombreCompleto, DateTime fechaNacimiento, string genero,
                string telefono, string estado, string direccion, string foto)
    {
        this.NombreCompleto = nombreCompleto;
        this.FechaNacimiento = fechaNacimiento;
        this.Genero = genero;
        this.Telefono = telefono;
        this.Estado = estado;
        this.Direccion = direccion;
        this.Foto = foto;
    }

}
