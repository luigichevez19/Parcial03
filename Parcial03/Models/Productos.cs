using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial03.Models
{
    public class Productos
    {
        [Key]
        public int id_Pro { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        public string nombre { get; set; }

       [Required(ErrorMessage ="Ingrese la cantidad de producto")]
        public int stock { get; set; }

        [Required(ErrorMessage ="Ingrese el valor del producto")]
        public double valor { get; set; }

        public static List<Productos> listar() 
        { 
            var listadoProd = new List<Productos>();
            listadoProd.Add(new Productos()
            {
                id_Pro =1,
                nombre="Edwin Crack",
                stock=15,
                valor=10.55
            }
            );
            return listadoProd;
        }
    }
}