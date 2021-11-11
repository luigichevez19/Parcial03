using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial03.Models
{
    public class Clientes
    {
        [Key]
        public int id_Clie { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage ="Debe ingresar el nombre")]
        public string nombres { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string apellidos { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Debe ingresar el dui")]
        public string dui { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="dd/MM/yyyy")]
        public DateTime fechaNaci { get; set; }
    }
}