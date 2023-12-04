using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoCita {
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
        
        public List<EntidadPaciente> ListaPaciente(EntidadPaciente paciente) {
            List<EntidadPaciente> list = new List<EntidadPaciente>();
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
            
            string query;
            if (paciente == null) 
                query = "SELECT * FROM Paciente WHERE Status = 1";
            else {
                list.Add(paciente);
                query = $"SELECT * FROM Paciente WHERE PacID != {paciente.PacID} AND Status = 1";
            }
            
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            
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
        
        public List<EntidadVeterinario> ListaVeterinario(EntidadVeterinario veterinario) {
            List<EntidadVeterinario> list = new List<EntidadVeterinario>();
            SqlCommand command = new SqlCommand($"SELECT * FROM Veterinario WHERE Status = 1 AND VetID != {veterinario.VetID}", SQL.Connection);
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
            list.Add(veterinario);
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
        
        public int Execute(string query) {
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            return command.ExecuteNonQuery();
        }
        
        public int ScopeIdentity() {
            SqlCommand command = new SqlCommand("SELECT SCOPE_IDENTITY()", SQL.Connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}