using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioCitaDetalle {
        private DatoCitaDetalle _dato = new DatoCitaDetalle();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public List<EntidadTratamiento> ListaVacuna() {
            return _dato.ListaVacuna();
        }

        public List<EntidadTratamiento> ListaDesparasitante() {
            return _dato.ListaDesparasitante();
        }
        
        public int Execute(string query) {
            return _dato.Execute(query);
        }
        
        public int ScopeIdentity() {
            return _dato.ScopeIdentity();
        }
        
    }
}