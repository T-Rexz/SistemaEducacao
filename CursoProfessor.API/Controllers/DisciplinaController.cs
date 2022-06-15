using Microsoft.AspNetCore.Mvc;

namespace CursoProfessor.API.Controllers
{
    public class DisciplinaController : Controller
    {
        public IActionResult Inicio()
        {
            return Ok("Teste - Disciplina");
        }
    }
}
