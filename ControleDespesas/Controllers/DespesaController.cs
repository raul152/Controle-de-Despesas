using ControleDespesas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleDespesas.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ILogger<DespesaController> _logger;

        public DespesaController(ILogger<DespesaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}