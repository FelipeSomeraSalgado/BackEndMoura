
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NovoCrudMoura.Models;

namespace NovoCrudMoura.Controllers
{

    public class FrutaController : Controller
    {
        private readonly ILogger<FrutaController> _logger;

        public static List<Fruta> listaDeFrutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Banana", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{ Id = 3, Nome = "Limão", Preco = 2.95f, Quantidade = 100, Categoria = "Cítrica"}

        };

        public FrutaController(ILogger<FrutaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ListarFrutas()
        {
            ViewBag.Frutas = listaDeFrutas;
            return View();
        }

        //Mostra a tela de cadastrar
        public IActionResult Create()
        {
            return View();
        }

        //Salvar a fruta na nossa lista
        //Em seguida, redireciona para lista/tela de ListarFrutas
        [HttpPost]
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            //criar id novo
            frutaCadastrada.Id = listaDeFrutas.Max(f => f.Id) + 1;
            //salvar os dados da fruta na listaDeFruta
            listaDeFrutas.Add(frutaCadastrada);
            //voltar para tela de listagem de frutas  
            return RedirectToAction(nameof(ListarFrutas));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}