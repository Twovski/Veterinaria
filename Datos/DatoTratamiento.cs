using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoTratamiento {
        public DataTable GetListado(string query) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            table.Columns["Status"].ColumnMapping = MappingType.Hidden;
            table.Columns["TipoID"].ColumnMapping = MappingType.Hidden;
            return table;
        }

        public List<EntidadTipoTratamiento> ListaTipoTratamientos() {
            List<EntidadTipoTratamiento> list = new List<EntidadTipoTratamiento>();
            SqlCommand command = new SqlCommand("SELECT * FROM TipoTratamiento", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadTipoTratamiento() {
                TipoID = -1,
                Nombre = "Selecciona"
            });
            while (reader.Read()) {
                list.Add(new EntidadTipoTratamiento() {
                    TipoID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
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