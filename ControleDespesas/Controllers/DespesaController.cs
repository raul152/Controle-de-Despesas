using ControleDespesas.DTOs;
using ControleDespesas.IServices;
using ControleDespesas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleDespesas.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ILogger<DespesaController> _logger;
        private readonly IDespesasService _despesasService;

        public DespesaController(ILogger<DespesaController> logger, IDespesasService despesasService)
        {
            _logger = logger;
            _despesasService = despesasService;
        }

        public async Task<IActionResult> Index()
        {
            var listarDespesasDTO = new ListarDespesasDTO();
            listarDespesasDTO.Items = await _despesasService.FindBy(listarDespesasDTO.DataInicial, 
                                                                    listarDespesasDTO.DataFinal);
            return View(listarDespesasDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ListarDespesasDTO listarDespesasDTO)
        {
            try
            {
                listarDespesasDTO.Items = await _despesasService.FindBy(listarDespesasDTO.DataInicial,
                                                                    listarDespesasDTO.DataFinal);
                return View(listarDespesasDTO);

            }
            catch (Exception e)
            {

                ModelState.AddModelError("CustomError", e.Message);
                return View(listarDespesasDTO);
            }
        }

        public async Task<IActionResult> Create()
        {
            var criarDespesasDTO = new CriarDespesasDTO();
            
            return View(criarDespesasDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CriarDespesasDTO criarDespesasDTO)
        {
            try
            {
                await _despesasService.Create(criarDespesasDTO);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CustomError", ex.Message);
                return View(criarDespesasDTO);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}