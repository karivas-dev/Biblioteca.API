using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Entities.DTO
{
    public class EditorialDto
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string NombreEditorial { get; set; } = string.Empty;
    }
}
