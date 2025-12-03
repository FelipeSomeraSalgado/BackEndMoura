using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NovoCrudMoura.Models;

namespace NovoCrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

      public IActionResult MinhaAcao()
    {
        return View();//retorne a página MinhaAção.cshtml
    }

    public IActionResult ListaNomes()
    {
        //Cria um array de nomes já prenchido
        string[] nomes = {"Felipe Somera", "João", "Arthur", "Torolho"};
        ViewBag.Teste = "Olá, eu vim da ViewBag";
        ViewBag.nomes = nomes;//guarda os nomes na ViewBag


        return View();//chama a view passando os dados
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
