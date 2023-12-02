using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioPaciente {
        private readonly DatoPaciente _dato = new DatoPaciente();
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public List<EntidadCliente> ListaCliente() {
            return _dato.ListaCliente();
        }

        public List<EntidadTipo> ListaTipo() {
            return _dato.ListaTipo();
        }
        
        public int Execute(string query) {
            return _dato.Execute(query);
        }

    }
}