using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPopular.Models
{
    public class Prestamos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int IdPrestamo { get; set; }
        public string? TipoPrestamo { get; set; }
    }
}
