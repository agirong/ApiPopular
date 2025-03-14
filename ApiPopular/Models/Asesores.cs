using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPopular.Models
{
    public class Asesores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoAsesor { get; set; }
        public string? NombreAsesor { get; set; }
    }
}
