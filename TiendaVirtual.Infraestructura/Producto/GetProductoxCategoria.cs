using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TiendaVirtual.Persistencia;

namespace TiendaVirtual.Infraestructura.Producto
{
   public  class GetProductoxCategoria
    {
        public class Request : IRequest<List<TiendaVirtual.Entidades.Producto>>
        {
            public int idcategoria { get; set; }
        }

        public class CommandHandle : IRequestHandler<Request, List<TiendaVirtual.Entidades.Producto>>
        {

            private readonly Persistencia.ModelContext db;

            public CommandHandle(ModelContext context)
            {
                db = context;


            }


            async Task<List<Entidades.Producto>> IRequestHandler<Request, List<Entidades.Producto>>.Handle(Request request, CancellationToken cancellationToken)
            {

                var data = await db.producto.Where(x => x.estado != "ELIMINADO" && x.idcategoria==request.idcategoria).ToListAsync();
                return data;
            }
        }
    }
}
