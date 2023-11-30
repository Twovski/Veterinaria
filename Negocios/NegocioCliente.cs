using System.Data;
using Datos;

namespace Negocio {
    public class NegocioCliente {
        private readonly DatoCliente _dato = new DatoCliente();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }
    }
}