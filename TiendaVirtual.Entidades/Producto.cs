using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Entidades
{
    [Table("Producto")]
    public class Producto
    {
        [Key]

        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
        public string estado { get; set; }
        public string imagen { get; set; }
        public decimal? precio { get; set; }
        public int? stock { get; set; }
        public int? idcategoria { get; set; }
    }
}
