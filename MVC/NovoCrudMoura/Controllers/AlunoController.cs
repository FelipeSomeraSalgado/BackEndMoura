using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NovoCrudMoura.Models;

namespace NovoCrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{ID = 1, Nome = "Felipe Gomes", CPF = 12345678901, Idade = 17, EMail = "FelipeGomes@gmail"},
            new Aluno{ID = 2, Nome = "Felipe Salgado", CPF = 12345678902, Idade = 16, EMail = "FelipeSalgado@gmail"},
            new Aluno{ID = 3, Nome = "Felipe Torolho",  CPF = 12345678903, Idade = 16, EMail = "FelipeTorolho@gmail"},
        };

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarAlunos()
        {
            ViewBag.Aluno = ListaDeAlunos;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAluno(Aluno alunocadastrado)
        {
            alunocadastrado.ID = ListaDeAlunos.Max(f => f.ID) + 1;

            ListaDeAlunos.Add(alunocadastrado);

            return RedirectToAction(nameof(ListarAlunos));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}