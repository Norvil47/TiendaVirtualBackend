using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaVirtual.Infraestructura.Orden;

namespace TiendaVirtual.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : baseController
    {
        [HttpPost]
        public async Task<object> GuardarOrden([FromBody]RegistrarOrden.Request obj)
        {
            return await _mediator.Send(obj);
        }
    }
}
