using System;
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
            table.Columns["Status"].ColumnMapping = MappingType.Hidden;
            return table;
        }

        public List<EntidadTipoAnimal> ListaTipoAnimal() {
            List<EntidadTipoAnimal> list = new List<EntidadTipoAnimal>();
            SqlCommand command = new SqlCommand("SELECT * FROM TipoAnimal", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();

            list.Add(new EntidadTipoAnimal() {
                TipoID = -1,
                Nombre = "Selecciona"
            });
            while (reader.Read()) {
                list.Add(new EntidadTipoAnimal() {
                    TipoID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                });
            }
            
            return list;
        }
        
        public List<EntidadCliente> ListaCliente() {
            List<EntidadCliente> list = new List<EntidadCliente>();
            SqlCommand command = new SqlCommand("SELECT * FROM Cliente WHERE Status = 1", SQL.Connection);
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

        public EntidadPaciente GetPaciente(string query) {
            SqlCommand command = new SqlCommand(query, SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            EntidadPaciente paciente = null;
            if (reader.Read()) 
                paciente = new EntidadPaciente() {
                    PacID = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Sexo = Convert.ToChar(reader.GetString(2)),
                    Color = reader.GetString(3),
                    Status = reader.GetBoolean(4),
                    FechaNacimiento = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                    Edad = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6),
                    CliID = reader.GetInt32(7),
                    TipoID = reader.GetInt32(9)
                };
            
            return paciente;
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