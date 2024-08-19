using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required DateTime FechaDeLanzamiento { get; set; }

        [Required]
        public int AutorId { get; set; }
        public Autor Autor { get; set; } = null!;

        [Required]
        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; } = null!;
    }
}
