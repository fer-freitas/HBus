using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using UBus.Application.Interfaces;

namespace UBus.UI.Portal.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoAppService _veiculoAppService;
        private readonly IRotaAppService _rotaAppService;

        public VeiculoController(IVeiculoAppService veiculoAppService,
                                 IRotaAppService rotaAppService)
        {
            _veiculoAppService = veiculoAppService;
            _rotaAppService = rotaAppService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Rotas = _rotaAppService.ObterTodos().Select(x =>
                            new SelectListItem
                            {
                                Text = $"{x.Origem} - {x.Destino}",
                                Value = x.Id.ToString()
                            });

            return View(_veiculoAppService.ObterTodos());
        }
        
        [HttpPost]
        public IActionResult Index(Guid id)
        {
            ViewBag.Rotas = _rotaAppService.ObterTodos().Select(x =>
                            new SelectListItem
                            {
                                Text = $"{x.Origem} - {x.Destino}",
                                Value = x.Id.ToString()
                            });

            return View(_veiculoAppService.ObterItensAdicionaisPorRota(id));
        }

    }
}
