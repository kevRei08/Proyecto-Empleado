using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Empleado.Models
{
    public class Empleado
    {
        //Atributos
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Los nombres son obligatorios")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El tipo de documento es obligatorio")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El documento es obligatorio")]
        [Display(Name = "Documento")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El área es obligatorio")]
        public string Area { get; set; }
    }
}
