using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities.Models
{
    internal class Libro
    {
        [Key]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string FechaDeLanzamiento { get; set; }
        public required string CodigoAutor { get; set; }
        public required string CodigoEditorial { get; set; }
    }
}
