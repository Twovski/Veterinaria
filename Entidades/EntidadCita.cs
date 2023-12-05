using System;

namespace Entidades {
    public class EntidadCita {
        public int CitaID { get; set; }
        public string Motivo { get; set; }
        public string Anotaciones { get; set; }
        public int VetID { get; set; }
        public int PacID { get; set; }
        public int ServID { get; set; }
        public DateTime Fecha { get; set; }
    }   
}