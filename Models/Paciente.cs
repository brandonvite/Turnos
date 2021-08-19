using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Required (ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }

        [Required (ErrorMessage = "Debe ingresar un apellido")]
        public string Apellido { get; set; }

        [Required (ErrorMessage = "Debe ingresar una dirección")]
        [Display (Name = "Dirección")]
        public string Direccion { get; set; }

        [Required (ErrorMessage = "Debe ingresar un télefono")]
        [Display (Name = "Télefono")]
        public string Telefono { get; set; }

        [Required (ErrorMessage = "Debe ingresar un email")]
        [EmailAddress (ErrorMessage = "Debe ingresar un email valido, por ejemplo: juan@email.com")]
        public string Email { get; set; }

        public List<Turno> Turno { get; set; }
    }
}