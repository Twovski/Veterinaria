using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioDetalles {
        private DatoDetalle _dato = new DatoDetalle();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public List<EntidadVeterinario> ListaVeterinaria() {
            return _dato.ListaVeterinario();
        }
        
        public List<EntidadPaciente> ListaPaciente() {
            return _dato.ListaPaciente();
        }
        
        public List<EntidadTratamiento> ListaTratamiento() {
            return _dato.ListaTratamiento();
        }

        public List<EntidadServicio> ListaServicio() {
            return _dato.ListaServicio();
        }
        
        public int Execute(string query) {
            return _dato.Execute(query);
        }
    }
}