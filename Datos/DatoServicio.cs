using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class DatoServicio {
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
        
        public int ScopeIdentity() {
            SqlCommand command = new SqlCommand("SELECT SCOPE_IDENTITY()", SQL.Connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}