using System;
using System.Data.SqlClient;

namespace Datos {
    public class SQL {
        public static readonly SqlConnection Connection = new SqlConnection();
        
        private string _server ="localhost";
        private string _DB="VetReza";
        private string _user="sa";
        private string _password ="SQL_2021";
        private string _port ="1433";

        public void StartConexion() {
            try {
                Connection.ConnectionString = "Data Source=" + 
                                              _server + "," + _port + ";" + 
                                              "user id=" + _user + ";" + 
                                              "password=" + _password + ";" + 
                                              "Initial Catalog=" + _DB + ";" + 
                                              "Persist Security Info=true; MultipleActiveResultSets=true";
                Connection.Open();
            }
            catch (SqlException e) {
                Console.WriteLine(e);
            }
        }
    }
}