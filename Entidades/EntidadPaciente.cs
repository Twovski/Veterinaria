using System;

namespace Entidades {
    public class EntidadPaciente {
        public int PacID { get; set; }
        public string Nombre { get; set; }
        public bool Sexo { get; set; }
        public string Color { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Status { get; set; }
        public int Edad { get; set; }
        public int TipoID { get; set; }
        public int CliID { get; set; }
    }
}