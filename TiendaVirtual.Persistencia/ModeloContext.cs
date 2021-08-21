using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVirtual.Entidades;
namespace TiendaVirtual.Persistencia
{
    public class ModelContext : DbContext
    {
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Orden> orden { get; set; }
        public DbSet<DetalleOrden> detalleorden { get; set; }



        public ModelContext(DbContextOptions<ModelContext> options)
         : base(options)
        {
          
        }

      
        
    }
}
