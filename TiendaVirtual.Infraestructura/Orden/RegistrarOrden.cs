using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TiendaVirtual.Persistencia;

namespace TiendaVirtual.Infraestructura.Orden
{
    public class RegistrarOrden
    {
        public class Request : IRequest<object>
        {
            public TiendaVirtual.Entidades.Orden orden { get; set; }
            public List<TiendaVirtual.Entidades.DetalleOrden> detalle { get; set; }
        }

        public class CommandHandle : IRequestHandler<Request, object>
        {

            private readonly Persistencia.ModelContext db;

            public CommandHandle(ModelContext context)
            {
                db = context;


            }

            public async Task<object> Handle(Request request, CancellationToken cancellationToken)
            {
                try
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        var orden = request.orden;
                        var detalle = request.detalle;
                        orden.fecha = DateTime.Now;
                        await db.AddAsync(orden);
                        await db.SaveChangesAsync();

                        detalle.ForEach(x => x.idorden = orden.idorden);

                        await db.AddRangeAsync(detalle);
                        await db.SaveChangesAsync();

                        List<TiendaVirtual.Entidades.Producto> productos = new List<TiendaVirtual.Entidades.Producto>();
                        foreach (var item in detalle)
                        {
                            var producto = db.producto.Find(item.idproducto);
                            producto.stock -= item.cantidad;
                            productos.Add(producto);
                        }
                        db.UpdateRange(productos);
                        await db.SaveChangesAsync();
                        transaction.Commit();
                    }


                    return new { mensaje="ok"};
                }
                catch (Exception e)
                {

                    return new { mensaje = e.Message };

                }

            }


        }
    }
}
