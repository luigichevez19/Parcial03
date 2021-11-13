using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial03.Models
{
    public class Pedidos
    {
       [Key]
       public int id { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime fechaPedido { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime fechaEntrega { get; set; }

        public int? id_Pro { get; set; }
        public virtual Productos productos { get; set; }
        public int? id_Clie { get; set; }
        public virtual Clientes clientes { get; set; }
        public static List<Pedidos> listar()
        {
            var listadoProd = new List<Pedidos>();
            listadoProd.Add(new Pedidos()
            {
                fechaEntrega= Convert.ToDateTime("11/12/2021"),
                fechaPedido= Convert.ToDateTime("11/13/2021"),
                id=1,
                id_Clie=2,
                id_Pro=2
            }
            );
            return listadoProd;
        }
    }
}