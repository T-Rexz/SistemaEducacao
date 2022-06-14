using Microsoft.AspNetCore.Mvc;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("educacao")]
    public class EducacaoController : Controller
    {
        public string Inicio()
        {
            return "==== SISTEMA DE ENSINO ====" +
                   "\n\nAtribuição de Curso por Professor.";
        }
    }
}
