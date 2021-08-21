using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Entidades
{
    [Table("Orden")]

    public class Orden
    {
        [Key]
        public int idorden { get; set; }
        public DateTime fecha { get; set; }
        public string dnicliente { get; set; }
        public string nombres { get; set; }

    }
}
