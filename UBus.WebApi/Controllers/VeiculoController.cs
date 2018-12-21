using Microsoft.AspNetCore.Mvc;
using System;
using UBus.Application.Interfaces;

namespace UBus.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoAppService _veiculoAppService;

        public VeiculoController(IVeiculoAppService veiculoAppService)
        {
            _veiculoAppService = veiculoAppService;
        }

        // GET api/values/5
        [HttpGet]
        public IActionResult Get(Guid rotaId)
        {
            return new ObjectResult(_veiculoAppService.ObterItensAdicionaisPorRota(rotaId));
        }

    }
}
