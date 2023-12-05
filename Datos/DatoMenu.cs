using System;
using System.Data.SqlClient;

namespace Datos {
    public class DatoMenu {
        public string ObtenerNotificacion() {
            SqlCommand command = new SqlCommand("SELECT TOP 1 Mensaje FROM VW_Notificacion", SQL.Connection);
            SqlDataReader reader = command.ExecuteReader();
            string mensaje = null;
            if (reader.Read()) {
                mensaje = reader.GetString(0);
            }

            return mensaje;
        }
    }
}