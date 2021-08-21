using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaVirtual.Entidades;
using TiendaVirtual.Infraestructura.Categoria;
namespace TiendaVirtual.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : baseController
    {
        [HttpGet]
        public async Task<List<Categoria>> Listar()
        {
            return await _mediator.Send(new GetCategorias.Request());
        }
    }
}
