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
    }
}