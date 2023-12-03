using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoDetalle {
        public DataTable GetListado(string query) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            table.Columns["VetID"].ColumnMapping = MappingType.Hidden;
            table.Columns["PacID"].ColumnMapping = MappingType.Hidden;
            table.Columns["ServID"].ColumnMapping = MappingType.Hidden;
            return table;
        }
        
        public List<EntidadPaciente> ListaPaciente() {
            List<EntidadPaciente> list = new List<EntidadPaciente>();
            SqlCommand command = new SqlCommand("SELECT * FROM Paciente", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            
            list.Add(new EntidadPaciente() {
                PacID = -1,
                Nombre = "Selecciona",
                Sexo = false,
                Color = null,
                Status = false,
                FechaNacimiento = null,
                Edad = null,
                TipoID = -1,
                CliID =-1
            });
            while (reader.Read()) 
                list.Add(new EntidadPaciente() {
                    PacID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Sexo = reader.GetBoolean(2),
                    Color = reader.GetString(3),
                    Status = reader.GetBoolean(4),
                    FechaNacimiento = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                    Edad = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6),
                    TipoID = reader.GetInt32(7),
                    CliID = reader.GetInt32(8)
                });
            
            return list;
        }
        
        public List<EntidadVeterinario> ListaVeterinario() {
            List<EntidadVeterinario> list = new List<EntidadVeterinario>();
            SqlCommand command = new SqlCommand("SELECT * FROM Veterinario WHERE Status = 1", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadVeterinario() {
                VetID = -1,
                Nombre = "Selecciona",
                ApellidoPaterno = null,
                ApellidoMaterno = null,
                RFC = null,
                Correo = null,
                Status = false
            });
            while (reader.Read()) {
                list.Add(new EntidadVeterinario() {
                    VetID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    ApellidoPaterno = reader.GetString(2),
                    ApellidoMaterno = reader.GetString(3),
                    RFC = reader.GetString(4),
                    Correo = reader.GetString(5),
                    Status = reader.GetBoolean(6)
                });
            }
            
            return list;
        }

        
        public List<EntidadServicio> ListaServicio() {
            List<EntidadServicio> list = new List<EntidadServicio>();
            SqlCommand command = new SqlCommand("SELECT * FROM Servicio", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadServicio() {
                ServID = -1,
                Nombre = "Selecciona",
                Status = false
            });
            while (reader.Read()) {
                list.Add(new EntidadServicio() {
                    ServID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Status = reader.GetBoolean(2),
                });
            }
            
            return list;
        }
        
        public List<EntidadTratamiento> ListaTratamiento() {
            List<EntidadTratamiento> list = new List<EntidadTratamiento>();
            SqlCommand command = new SqlCommand("SELECT * FROM Tratamiento", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadTratamiento() {
                TipoID = -1,
                Nombre = "Selecciona",
                Status = false,
                TraID = -1
            });
            while (reader.Read()) {
                list.Add(new EntidadTratamiento() {
                    TipoID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Status = reader.GetBoolean(2),
                    TraID = reader.GetInt32(3)
                });
            }
            
            return list;
        }
        
        public int Execute(string query) {
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            return command.ExecuteNonQuery();
        }
    }
}