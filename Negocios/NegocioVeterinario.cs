using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioVeterinario {
        private DatoVeterinario _dato = new DatoVeterinario();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public int Execute(string query) {
            return _dato.Execute(query);
        }

        public EntidadVeterinario Login(string query) {
            return _dato.Login(query);
        }
    }
}