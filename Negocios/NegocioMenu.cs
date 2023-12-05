using Datos;

namespace Negocio {
    public class NegocioMenu {
        private SQL _sql = new SQL();
        private DatoMenu _dato = new DatoMenu();

        public void StartConexion() {
            _sql.StartConexion();
        }

        public string ObtenerNotificacion() {
            return _dato.ObtenerNotificacion();
        }
    }
}