
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPopular.Models
{
    public class Estados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstado { get; set; }
        public string? NombreEstado { get; set; }
        public Solicitudes? Solicitudes { get; set; }
    }
}
