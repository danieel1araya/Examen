using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BLL;
using System.Data;

namespace DAL
{
    public class Conexion
    {
        private string StringConexion;

        private SqlConnection _connection;

        private SqlCommand _command;

        private SqlDataReader _reader;

        public Conexion(string pStringCnx)
        {
            StringConexion = pStringCnx; 
        }

        // INICIO CRUD CITAS

        public void GuardarCita(CitaMedica cita)
        {
            try
            {
                // Se instancia la conexión con la base de datos utilizando la cadena de conexión definida.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el objeto SqlCommand para ejecutar el procedimiento almacenado.
                _command = new SqlCommand();
                // Se asigna la conexión establecida al comando SQL.
                _command.Connection = _connection;
                // Se especifica que el comando es un procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Ins_Citas]";

                // Se agregan los parámetros necesarios para el procedimiento almacenado, tomando los valores del objeto 'cita'.
                _command.Parameters.AddWithValue("@FechaHoraInicio", cita.FechaHoraInicio); // Asigna la fecha y hora de inicio de la cita.
                _command.Parameters.AddWithValue("@FechaHoraFin", cita.FechaHoraFin); // Asigna la fecha y hora de finalización de la cita.
                _command.Parameters.AddWithValue("@IDPaciente", cita.IDPaciente); // Asigna el ID del paciente.
                _command.Parameters.AddWithValue("@IDMedico", cita.IDMedico); // Asigna el ID del médico.
                _command.Parameters.AddWithValue("@MotivoCita", cita.Motivo); // Asigna el motivo de la cita.
                _command.Parameters.AddWithValue("@EstadoCita", cita.Estado); // Asigna el estado de la cita ("Programada", "Cancelada", "Completada").
                _command.Parameters.AddWithValue("@Observaciones", cita.Observaciones); // Asigna las observaciones.
                _command.Parameters.AddWithValue("@Tipo", cita.Tipo); // Asigna el tipo de cita (ej. Pediatría, Cardiología).

                // Se ejecuta el comando SQL sin devolver ningún valor, ya que solo es una operación de inserción.
                _command.ExecuteNonQuery();

                // Se cierra la conexión a la base de datos después de la ejecución.
                _connection.Close();
                // Se liberan los recursos asociados con la conexión.
                _connection.Dispose();
                // Se liberan los recursos asociados con el comando SQL.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se lanza de nuevo para que pueda ser manejada externamente.
                throw ex;
            }
        }

        public void ModificarCita(CitaMedica cita)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();
                // Se asigna la conexión al comando.
                _command.Connection = _connection;
                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Upd_Citas]";

                // Se añaden los parámetros del procedimiento almacenado con los valores del objeto 'cita'.
                _command.Parameters.AddWithValue("@FechaHoraInicio", cita.FechaHoraInicio); // Asigna la nueva fecha y hora de inicio.
                _command.Parameters.AddWithValue("@FechaHoraFin", cita.FechaHoraFin); // Asigna la nueva fecha y hora de finalización.
                _command.Parameters.AddWithValue("@IDPaciente", cita.IDPaciente); // Asigna el nuevo ID del paciente.
                _command.Parameters.AddWithValue("@IDMedico", cita.IDMedico); // Asigna el nuevo ID del médico.
                _command.Parameters.AddWithValue("@MotivoCita", cita.Motivo); // Asigna el nuevo motivo de la cita.
                _command.Parameters.AddWithValue("@EstadoCita", cita.Estado); // Asigna el nuevo estado de la cita.
                _command.Parameters.AddWithValue("@Observaciones", cita.Observaciones); // Asigna las nuevas observaciones.
                _command.Parameters.AddWithValue("@Tipo", cita.Tipo); // Asigna el nuevo tipo de cita.

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se ejecuta la actualización).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();
                // Se liberan los recursos de la conexión.
                _connection.Dispose();
                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }

        public void EliminarCita(int idCita)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();
                // Se asigna la conexión al comando.
                _command.Connection = _connection;
                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Del_Citas]";

                // Se añade el parámetro del procedimiento almacenado con el valor del ID de la cita.
                _command.Parameters.AddWithValue("@IDCita", idCita);

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se realiza la eliminación).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();
                // Se liberan los recursos de la conexión.
                _connection.Dispose();
                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }

        public DataTable ObtenerCitas()
        {
            DataTable dtCitas = new DataTable();

            try
            {
                using (_connection = new SqlConnection(StringConexion))
                {
                    _connection.Open();
                    using (_command = new SqlCommand("[Sp_Get_Citas]", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(_command))
                        {
                            adapter.Fill(dtCitas); // Llenar el DataTable con los datos de la BD
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de citas: " + ex.Message);
            }

            return dtCitas;
        }


        // FIN CRUD CITAS

        // INICIO CRUD PACIENTES

        public void GuardarPaciente(Paciente paciente)
        {
            try
            {
                // Se instancia la conexión con la base de datos utilizando la cadena de conexión definida.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el objeto SqlCommand para ejecutar el procedimiento almacenado.
                _command = new SqlCommand();
                // Se asigna la conexión establecida al comando SQL.
                _command.Connection = _connection;
                // Se especifica que el comando es un procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Ins_Pacientes]";

                // Se agregan los parámetros necesarios para el procedimiento almacenado, tomando los valores del objeto 'paciente'.
                _command.Parameters.AddWithValue("@NombreComp", paciente.NombreCompleto); // Asigna el nombre completo del paciente.
                _command.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento); // Asigna la fecha de nacimiento del paciente.
                _command.Parameters.AddWithValue("@Genero", paciente.Genero); // Asigna el género del paciente.
                _command.Parameters.AddWithValue("@Telefono", paciente.Telefono); // Asigna el teléfono del paciente.
                _command.Parameters.AddWithValue("@Estado", paciente.Estado); // Asigna el estado del paciente ("Disponible", "En consulta").
                _command.Parameters.AddWithValue("@Direccion", paciente.Direccion); // Asigna la dirección del paciente.
                _command.Parameters.AddWithValue("@FotoPaciente", paciente.Foto); // Asigna la foto del paciente (ruta o URL).

                // Se ejecuta el comando SQL sin devolver ningún valor, ya que solo es una operación de inserción.
                _command.ExecuteNonQuery();

                // Se cierra la conexión a la base de datos después de la ejecución.
                _connection.Close();
                // Se liberan los recursos asociados con la conexión.
                _connection.Dispose();
                // Se liberan los recursos asociados con el comando SQL.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se lanza de nuevo para que pueda ser manejada externamente.
                throw ex;
            }
        }

        public void ModificarPaciente(Paciente paciente)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();
                // Se asigna la conexión al comando.
                _command.Connection = _connection;
                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Upd_Pacientes]";

                // Se añaden los parámetros del procedimiento almacenado con los valores del objeto 'paciente'.
                _command.Parameters.AddWithValue("@IDPaciente", paciente.IDPaciente);
                _command.Parameters.AddWithValue("@NombreComp", paciente.NombreCompleto); // Asigna el nombre completo del paciente.
                _command.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento); // Asigna la fecha de nacimiento.
                _command.Parameters.AddWithValue("@Genero", paciente.Genero); // Asigna el género del paciente.
                _command.Parameters.AddWithValue("@Telefono", paciente.Telefono); // Asigna el teléfono.
                _command.Parameters.AddWithValue("@Estado", paciente.Estado); // Asigna el estado ("Disponible", "En consulta").
                _command.Parameters.AddWithValue("@Direccion", paciente.Direccion); // Asigna la dirección.
                _command.Parameters.AddWithValue("@Foto", paciente.Foto); // Asigna la foto del paciente (ruta o URL).

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se ejecuta la actualización).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();
                // Se liberan los recursos de la conexión.
                _connection.Dispose();
                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }

        public void EliminarPaciente(int idPaciente)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();
                // Se asigna la conexión al comando.
                _command.Connection = _connection;
                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Del_Pacientes]";

                // Se añade el parámetro del procedimiento almacenado con el valor del ID del paciente.
                _command.Parameters.AddWithValue("@IDPaciente", idPaciente);

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se realiza la eliminación).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();
                // Se liberan los recursos de la conexión.
                _connection.Dispose();
                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }

        public DataTable ObtenerPacientes()
        {
            DataTable dtPacientes = new DataTable();

            try
            {
                using (_connection = new SqlConnection(StringConexion))
                {
                    _connection.Open();
                    using (_command = new SqlCommand("[Sp_Get_Pacientes]", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(_command))
                        {
                            adapter.Fill(dtPacientes); // Llenar el DataTable con los datos de la BD
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de pacientes: " + ex.Message);
            }

            return dtPacientes;
        }


        // FIN CRUD PACIENTES

        // INICIO CRUD MEDICOS

        public void GuardarMedico(Medico medico)
        {
            try
            {
                // Se instancia la conexión con la base de datos utilizando la cadena de conexión definida.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el objeto SqlCommand para ejecutar el procedimiento almacenado.
                _command = new SqlCommand();
                // Se asigna la conexión establecida al comando SQL.
                _command.Connection = _connection;
                // Se especifica que el comando es un procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Ins_Medicos]";

                // Se agregan los parámetros necesarios para el procedimiento almacenado, tomando los valores del objeto 'medico'.
                _command.Parameters.AddWithValue("@NombreCompleto", medico.NombreCompleto); // Asigna el nombre completo del médico.
                _command.Parameters.AddWithValue("@Especialidad", medico.Especialidad); // Asigna la especialidad del médico.
                _command.Parameters.AddWithValue("@Telefono", medico.Telefono); // Asigna el teléfono del médico.
                _command.Parameters.AddWithValue("@FotoMedico", medico.Foto); // Asigna la foto del médico.
                _command.Parameters.AddWithValue("@HorarioAtencion", medico.HorarioAtencion); // Asigna el horario de atención del médico.
                _command.Parameters.AddWithValue("@LimiteCitas", medico.LimiteCitas); // Asigna el límite de citas del médico.
                _command.Parameters.AddWithValue("@Estado", medico.Estado); // Asigna el estado del médico.

                // Se ejecuta el comando SQL sin devolver ningún valor, ya que solo es una operación de inserción.
                _command.ExecuteNonQuery();

                // Se cierra la conexión a la base de datos después de la ejecución.
                _connection.Close();
                // Se liberan los recursos asociados con la conexión.
                _connection.Dispose();
                // Se liberan los recursos asociados con el comando SQL.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se lanza de nuevo para que pueda ser manejada externamente.
                throw ex;
            }
        }


        public void ModificarMedico(Medico medico)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();
                // Se asigna la conexión al comando.
                _command.Connection = _connection;
                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Upd_Medicos]";


                _command.Parameters.AddWithValue("@IDMedico", medico.IDMedico);
                _command.Parameters.AddWithValue("@NombreComp", medico.NombreCompleto); // Asigna el nombre completo del médico.
                _command.Parameters.AddWithValue("@Especialidad", medico.Especialidad); // Asigna la especialidad.
                _command.Parameters.AddWithValue("@Telefono", medico.Telefono); // Asigna el teléfono.
                _command.Parameters.AddWithValue("@FotoMedico", medico.Foto); // Asigna la foto del médico.
                _command.Parameters.AddWithValue("@HorarioAtencion", medico.HorarioAtencion); // Asigna el horario de atención.
                _command.Parameters.AddWithValue("@LimiteCitas", medico.LimiteCitas); // Asigna el límite de citas.
                _command.Parameters.AddWithValue("@Estado", medico.Estado); // Asigna el estado del médico.

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se ejecuta la actualización).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();
                // Se liberan los recursos de la conexión.
                _connection.Dispose();
                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }


        public void EliminarMedico(int idMedico)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);
                // Se abre la conexión a la base de datos.
                _connection.Open();
                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();
                // Se asigna la conexión al comando.
                _command.Connection = _connection;
                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;
                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Del_Medicos]"; // Corregido aquí: añadir el corchete de cierre

                // Se añade el parámetro del procedimiento almacenado con el valor del ID del médico.
                _command.Parameters.AddWithValue("@IDMedico", idMedico);

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se realiza la eliminación).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();
                // Se liberan los recursos de la conexión.
                _connection.Dispose();
                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }


        public DataTable ObtenerMedicos()
        {
            DataTable dtMedicos = new DataTable();

            try
            {
                using (_connection = new SqlConnection(StringConexion))
                {
                    _connection.Open();
                    using (_command = new SqlCommand("[Sp_Get_Medicos]", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(_command))
                        {
                            adapter.Fill(dtMedicos); // Llenar el DataTable con los datos de la BD
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de médicos: " + ex.Message);
            }

            return dtMedicos;
        }

        // FIN CRUD MEDICOS


        public int EjecutarConsultaEscalar(string query, Dictionary<string, object> parametros)
        {
            using (SqlConnection conn = new SqlConnection(StringConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar los parámetros a la consulta
                foreach (var parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    // Si el resultado no es null, lo retornamos convertido a int
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    throw new Exception("Error al ejecutar la consulta.", ex);
                }
            }
        }



    }
}
