using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;

namespace Negocio {
    public class NegocioCita {
        private DatoCita _dato = new DatoCita();
        
        public DataTable GetListado(string query) {
            return _dato.GetListado(query);
        }

        public List<EntidadVeterinario> ListaVeterinaria(EntidadVeterinario veterinario) {
            return _dato.ListaVeterinario(veterinario);
        }
        
        public List<EntidadPaciente> ListaPaciente(EntidadPaciente paciente) {
            return _dato.ListaPaciente(paciente);
        }

        public List<EntidadServicio> ListaServicio() {
            return _dato.ListaServicio();
        }
        
        public int Execute(string query) {
            return _dato.Execute(query);
        }
        
        public int ScopeIdentity() {
            return _dato.ScopeIdentity();
        }
        
    }
}