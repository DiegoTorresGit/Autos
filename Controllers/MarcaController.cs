using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autos.Controllers
{
    public class MarcaController : Controller
    {
        private readonly Domain.Interfaces.IMarcaRepository tcr;

        public MarcaController(Domain.Interfaces.IMarcaRepository context)
        {
            tcr = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<marca>>> Get()
        {
            return await tcr.GetAll();
        }

    }
}
