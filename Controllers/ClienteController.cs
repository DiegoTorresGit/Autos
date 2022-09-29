using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autos.Controllers
{
    /// <summary>
    /// Controlador de clientes
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Domain.Interfaces.IClienteRepository tcr;

        public ClienteController(Domain.Interfaces.IClienteRepository context)
        {

            tcr = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<cliente>>> Get()
        {
            return await tcr.GetAll();
        }
    }
}
