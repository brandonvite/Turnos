using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad{ get; set; }
        [Required (ErrorMessage = "Este campo no puede ir vacio.")]
        [StringLength(200, ErrorMessage = "El campo descripcion debe tener como máximo 200 caracteres")]
        [Display (Name = "Descripción", Prompt = "Ingrese una especialidad")]
        public string Descripcion { get; set; }
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
    }
}