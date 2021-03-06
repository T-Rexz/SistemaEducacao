using CursoProfessor.Modelo;
using CursoProfessor.Servico;
using CursoProfessor.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            string nomeProfessor = professorRecebido.NomeProfessor;

            if (professorRecebido == null)
            {
                return BadRequest("Professor não cadastrado. Favor efetuar o cadastro de professor.");
            }
            if (string.IsNullOrEmpty(nomeProfessor))
            {
                return BadRequest("Nome do professor não informado.");
            }

            Professor professorCriado = _disciplinaServico.CadastrarProfessor(professorRecebido);
            return Created("curso", professorRecebido);
        }

        [HttpGet]
        public IActionResult ObterListaProfessor()
        {
            List<Professor> listaProfessor = _disciplinaServico.ListarProfessores();
            return Ok(listaProfessor);
        }

        [HttpGet("{id}")]
        public IActionResult ObterProfessorViaID(string id)
        {
            Professor professor = _disciplinaServico.ObterProfessor(id);
            if (professor == null)
            {
                return NotFound();
            }
            return Ok(professor);
        }

        // Fazer PUT (atualizar) do Professor por ID
        //[HttpPut("{id}")]

        // Faze DELETE (deletar) do Professor por ID
        //[HttpDelete("{id}")]
    }
}
