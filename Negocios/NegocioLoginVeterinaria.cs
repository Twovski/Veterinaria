using Datos;

namespace Negocio {
    public class NegocioLoginVeterinaria {
        private SQL _sql = new SQL();
        
        public void StartConexion() {
            _sql.StartConexion();
        }
    }
}