using System.ComponentModel.DataAnnotations;
namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage ="Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Correo es obligatorio")]
        public string? Correo { get; set;}
    }
}
