using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPopular.Models
{
    public class Solicitudes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int NoSolicitud { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public double MontoSolicitud { get; set; }
        public string? PlazoSolicitud { get; set; }
        public string? NombreCliente { get; set; }
        public string? DocIdentidad { get; set; }
        public string? DireccionCliente { get; set; }
        public int IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public Estados? Estados { get; set; }
        public int IdPrestamo { get; set; }
        [ForeignKey("IdPrestamo")]
        public Prestamos? Prestamos { get; set; }
        public int CodigoAsesor { get; set; }
        [ForeignKey("CodigoAsesor")]
        public Asesores? Asesores { get; set; }
    }
}
