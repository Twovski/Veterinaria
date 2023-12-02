using System.Data;
using Datos;

namespace Negocio {
    public class NegocioTipoTratamiento {
        private DatoTipoTratamiento _dato = new DatoTipoTratamiento();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public int Execute(string query) {
            return _dato.Execute(query);
        }
    }
}