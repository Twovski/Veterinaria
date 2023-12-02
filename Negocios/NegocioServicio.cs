using System.Data;
using Datos;

namespace Negocio {
    public class NegocioServicio {
        private DatoServicio _dato = new DatoServicio();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public int Execute(string query) {
            return _dato.Execute(query);
        }
    }
}