using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoVeterinario {
        public DataTable GetListado(string query) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            table.Columns["Status"].ColumnMapping = MappingType.Hidden;
            return table;
        }

        public List<EntidadVeterinario> ListaVeterinario() {
            List<EntidadVeterinario> list = new List<EntidadVeterinario>();
            SqlCommand command = new SqlCommand($"SELECT * FROM Veterinario WHERE Status = 1", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            
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
        public int Execute(string query) {
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            return command.ExecuteNonQuery();
        }

        public EntidadVeterinario Login(string query) {
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            EntidadVeterinario veterinario = null;
            if (reader.Read())
                veterinario = new EntidadVeterinario() {
                    VetID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    ApellidoPaterno = reader.GetString(2),
                    ApellidoMaterno = reader.GetString(3),
                    RFC = reader.GetString(4),
                    Correo = reader.GetString(5),
                    Status = reader.GetBoolean(6) 
                };
            
            return veterinario;
        }
        
        public int ScopeIdentity() {
            SqlCommand command = new SqlCommand("SELECT SCOPE_IDENTITY()", SQL.Connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}