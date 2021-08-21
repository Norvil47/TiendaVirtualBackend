using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TiendaVirtual.Persistencia;
using TiendaVirtual.Entidades;
using System.Threading;

namespace TiendaVirtual.Infraestructura.Categoria
{
    public class GetCategorias
    {
        public class Request : IRequest<List<TiendaVirtual.Entidades.Categoria>>
        { }

        public class CommandHandle : IRequestHandler<Request, List<TiendaVirtual.Entidades.Categoria>>
        {

            private readonly Persistencia.ModelContext db;

            public CommandHandle(ModelContext context)
            {
                db = context;


            }


            async Task<List<Entidades.Categoria>> IRequestHandler<Request, List<Entidades.Categoria>>.Handle(Request request, CancellationToken cancellationToken)
            {
                var data = await db.categoria.Where(x => x.estado != "ELIMINADO").ToListAsync();
                return data;
            }
        }
    }
}
