using Datos;

namespace Negocio {
    public class NegocioMenu {
        private SQL _sql = new SQL();

        public void StartConexion() {
            _sql.StartConexion();
        }
    }
}