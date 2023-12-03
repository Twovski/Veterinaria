using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoCliente {
        public DataTable GetListado(string query) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            table.Columns["VetID"].ColumnMapping = MappingType.Hidden;
            return table;
        }

        public List<EntidadVeterinaria> ListaVeterinaria() {
            List<EntidadVeterinaria> list = new List<EntidadVeterinaria>();
            SqlCommand command = new SqlCommand("SELECT * FROM Veterinaria WHERE Status = 1", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadVeterinaria() {
                VetID = -1,
                Nombre = "Selecciona",
                Status = false,
                Direccion = null,
                RFC = null
            });
            while (reader.Read()) {
                list.Add(new EntidadVeterinaria() {
                    VetID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Direccion = reader.GetString(2),
                    Status = reader.GetBoolean(3),
                    RFC = reader.GetString(4)
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