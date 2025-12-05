using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NovoCrudMoura.Models;

namespace NovoCrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly CrudMouraContext _context;//representa nosso banco de dados

        //construtor
        public AlunoController(ILogger<AlunoController> logger, CrudMouraContext context)
        {
            
            _logger = logger;
            _context = context;
        }

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{ID = 1, Nome = "Felipe Gomes", CPF = "928.609.130-33", Idade = 17, EMail = "FelipeGomes@gmail"},
            new Aluno{ID = 2, Nome = "Felipe Salgado", CPF = "928.609.130-32", Idade = 16, EMail = "FelipeSalgado@gmail"},
            new Aluno{ID = 3, Nome = "Rafael Moura",  CPF = "173.029.150-32", Idade = 16, EMail = "RafaelMoura@gmail.com"}, 
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