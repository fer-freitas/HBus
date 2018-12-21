using Microsoft.AspNetCore.Mvc;
using System;
using UBus.Application.Interfaces;
using UBus.Application.ViewModels;

namespace UBus.UI.Portal.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioAppService _funcionarioAppService;

        public FuncionarioController(IFuncionarioAppService funcionarioAppService)
        {
            _funcionarioAppService = funcionarioAppService;
        }

        public IActionResult Index()
        {
            return View(_funcionarioAppService.ObterTodos());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FuncionarioViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            try
            {
                _funcionarioAppService.Register(model);
            }
            catch (Exception)
            {
                return View(model);
            }
            
            return RedirectToAction("Index");
        }
    }
}