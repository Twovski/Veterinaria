namespace Entidades {
    public class EntidadCliente {
        public int CliID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string? Telefono { get; set; }
        public string? Celular { get; set; }
        public string IFE { get; set; }
        public bool Status { get; set; }
        public string Direccion { get; set; }
        public string? Correo { get; set; }
        public int VetID { get; set; }
    }
}