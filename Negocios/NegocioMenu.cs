using Datos;

namespace Negocio {
    public class NegocioMenu {
        private DatoMenu _dato = new DatoMenu();

        public string ObtenerNotificacion() {
            return _dato.ObtenerNotificacion();
        }
    }
}