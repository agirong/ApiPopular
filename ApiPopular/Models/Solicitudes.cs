namespace ApiPopular.Models
{
    public class Solicitudes
    {
        public int NoSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public double MontoSolicitud { get; set; }
        public string PlazoSolicitud { get; set; }
        public string NombreCliente { get; set; }
        public string DocIdentidad { get; set; }
        public string DireccionCliente { get; set; }
        public int IdEstado { get; set; }
        public int IdPrestamo { get; set; }
        public int CodigoAsesor { get; set; }
    }
}
