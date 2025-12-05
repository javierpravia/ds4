using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPasaportes.Models
{
    [Table("JP_Pasaportes")]
    public class Pasaporte
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre Completo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La cédula es requerida")]
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Estado del Pasaporte")]
        public string EstadoPasaporte { get; set; }

        [Required]
        [Display(Name = "Fecha de Solicitud")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaSolicitud { get; set; }
    }
}