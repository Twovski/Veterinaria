using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoCitaDetalle {
        public DataTable GetListado(string query) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            table.Columns["TraID"].ColumnMapping = MappingType.Hidden;
            return table;
        }
        
        public List<EntidadTratamiento> ListaVacuna() {
            List<EntidadTratamiento> list = new List<EntidadTratamiento>();
            SqlCommand command = new SqlCommand("SELECT * FROM Tratamiento WHERE TipoID = 1 AND Status = 1", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadTratamiento() {
                TipoID = -1,
                Nombre = "Selecciona",
                Status = false,
                TraID = -1
            });
            while (reader.Read()) {
                list.Add(new EntidadTratamiento() {
                    TraID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Status = reader.GetBoolean(2),
                    TipoID = reader.GetInt32(3)
                });
            }
            
            return list;
        }
        
        public List<EntidadTratamiento> ListaDesparasitante() {
            List<EntidadTratamiento> list = new List<EntidadTratamiento>();
            SqlCommand command = new SqlCommand("SELECT * FROM Tratamiento WHERE TipoID = 2 AND Status = 2", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadTratamiento() {
                TipoID = -1,
                Nombre = "Selecciona",
                Status = false,
                TraID = -1
            });
            while (reader.Read()) {
                list.Add(new EntidadTratamiento() {
                    TraID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Status = reader.GetBoolean(2),
                    TipoID = reader.GetInt32(3)
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