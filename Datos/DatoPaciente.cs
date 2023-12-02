using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos {
    public class DatoPaciente {
        public DataTable GetListado(string query) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            table.Columns["CliID"].ColumnMapping = MappingType.Hidden;
            table.Columns["TipoID"].ColumnMapping = MappingType.Hidden;
            return table;
        }

        public List<EntidadTipo> ListaTipo() {
            List<EntidadTipo> list = new List<EntidadTipo>();
            SqlCommand command = new SqlCommand("SELECT * FROM Tipo", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadTipo() {
                TipoID = -1,
                Nombre = "Selecciona"
            });
            while (reader.Read()) {
                list.Add(new EntidadTipo() {
                    TipoID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                });
            }
            
            return list;
        }
        
        public List<EntidadCliente> ListaCliente() {
            List<EntidadCliente> list = new List<EntidadCliente>();
            SqlCommand command = new SqlCommand("SELECT * FROM Cliente", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadCliente() {
                VetID = -1,
                Nombre = "Selecciona",           
                Status = false,
                Direccion = null,
                Celular = null,
                Correo = null,
                Telefono = null,
                ApellidoMaterno = null,
                ApellidoPaterno = null,
                CliID = -1,
                IFE = null
            });
            while (reader.Read()) {
                list.Add(new EntidadCliente() {
                    CliID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    ApellidoPaterno = reader.GetString(2),
                    ApellidoMaterno = reader.GetString(3),
                    Direccion = reader.GetString(4),
                    IFE = reader.GetString(5),
                    Status = reader.GetBoolean(6),
                    Correo = reader.IsDBNull(7) ? null : reader.GetString(7),
                    Telefono = reader.IsDBNull(8) ? null : reader.GetString(8),
                    Celular = reader.IsDBNull(9) ? null : reader.GetString(9),
                    VetID = reader.GetInt32(10) 
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