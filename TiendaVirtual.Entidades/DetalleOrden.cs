using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Entidades
{
    [Table("DetalleOrden")]

    public class DetalleOrden
    {
        [Key]
        public int iddetalle { get; set; }
        public int idorden { get; set; }
        public int idproducto { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
    }
}
