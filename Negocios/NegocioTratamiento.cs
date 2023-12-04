using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioTratamiento {
        private DatoTratamiento _dato = new DatoTratamiento();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public List<EntidadTipoTratamiento> ListaTipoTratamientos() {
            return _dato.ListaTipoTratamientos();
        }

        public int Execute(string query) {
            return _dato.Execute(query);
        }
        
        public int ScopeIdentity() {
            return _dato.ScopeIdentity();
        }
        
    }
}