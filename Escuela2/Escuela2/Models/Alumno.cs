using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escuela2.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        public Alumno()
        {
            this.bStatus = true;
        }

        [Key]
        public int pkAlumno { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string sNombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string sApellido { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string sGrupo { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string sImagen { get; set; }
        public Boolean bStatus { get; set; }
    }
}