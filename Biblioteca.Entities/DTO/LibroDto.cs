using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Entities.DTO
{
    public class LibroDto
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string NombreLibro { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de lanzamiento es requerida")]
        public DateTime FechaLanzamiento { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El código del autor es requerido")]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "El código de la editorial es requerido")]
        public int EditorialId { get; set; }

        public string AutorNombre { get; set; } = string.Empty;
        public string EditorialNombre { get; set; } = string.Empty;
    }

}
