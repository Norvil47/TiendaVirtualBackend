using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaVirtual.Entidades
{
    [Table("Categoria")]

    public class Categoria
    {
        [Key]
        public int idcategoria { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
