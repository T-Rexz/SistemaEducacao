using CursoProfessor.Servico;
using CursoProfessor.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("curso")]
    public class CursoController : ControllerBase
    {
        private DisciplinaServico _disciplinaServico = new DisciplinaServico();

        [HttpPost]
        public ActionResult CadastrarCurso([FromBody] CursoViewModel cursoRecebido)
        {
            string nomeCurso = cursoRecebido.NomeCurso;
            
            if (cursoRecebido == null)
            {
                return BadRequest("Curso não cadastrado. Favor efetuar o cadastro de curso.");
            }
            if(string.IsNullOrEmpty(nomeCurso))
            {
                return BadRequest("Nome do curso não informado.");
            }

            Curso cursoCriado = _disciplinaServico.CadastrarCurso(cursoRecebido);
            return Created("curso", cursoRecebido);
        }
    }
}
