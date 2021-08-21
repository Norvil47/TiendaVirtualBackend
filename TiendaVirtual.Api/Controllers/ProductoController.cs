using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaVirtual.Entidades;
using TiendaVirtual.Infraestructura.Producto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TiendaVirtual.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : baseController
    {
        [HttpGet]
        public async Task<List<Producto>> Listar([FromQuery]GetProductoxCategoria.Request obj)
        {
            return await _mediator.Send(obj);
        }
    }
}
