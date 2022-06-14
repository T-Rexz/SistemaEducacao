using CursoProfessor.Servico;
using CursoProfessor.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("professor")]
    public class ProfessorController : ControllerBase
    {
        private DisciplinaServico _disciplinaServico = new DisciplinaServico();

        [HttpPost]
        public ActionResult CadastrarProfessor([FromBody] ProfessorViewModel professorRecebido)
        {
            string nomeCurso = professorRecebido.NomeCurso;

            if (professorRecebido == null)
            {
                return BadRequest("Professor não cadastrado. Favor efetuar o cadastro de professor.");
            }
            if (string.IsNullOrEmpty(nomeCurso))
            {
                return BadRequest("Nome do professor não informado.");
            }

            Professor professorCriado = _disciplinaServico.CadastrarCurso(professorRecebido);
            return Created("curso", professorRecebido);
        }
    }
}
