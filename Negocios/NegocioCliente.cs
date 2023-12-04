using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioCliente {
        private readonly DatoCliente _dato = new DatoCliente();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public List<EntidadVeterinaria> ListaVeterinaria() {
            return _dato.ListaVeterinaria();
        }

        public int Execute(string query) {
            return _dato.Execute(query);
        }

        public int ScopeIdentity() {
            return _dato.ScopeIdentity();
        }
    }
}