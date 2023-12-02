using System.Data;
using System.Data.SqlClient;

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
    }
}