using System;
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
    }
}