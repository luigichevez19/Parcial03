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
        public DateTime fechaNaci { get; set; }
        public static List<Clientes> listar()
        {
            var listadoClie = new List<Clientes>();
            listadoClie.Add(new Clientes()
            {
                id_Clie=1,
                nombres="Luis",
                apellidos="Chevez",
                dui="01234567-8",
                fechaNaci = Convert.ToDateTime("03/19/1998")
            }
            );
            return listadoClie;
        }
    }
}