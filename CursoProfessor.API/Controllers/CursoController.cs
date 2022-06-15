using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using CursoProfessor.Servico;
using CursoProfessor.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoProfessor.API.Controllers
{
    [ApiController]
    [Route("curso")]
    public class CursoController : ControllerBase
    {
        // teste: era private por enquanto
        public DisciplinaServico _disciplinaServico = new DisciplinaServico();
        public Armazenamento _armazenamento = new Armazenamento();

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

        [HttpGet]
        public IActionResult ObterListaCurso()
        {
            List<Curso> listaCurso = _disciplinaServico.ListarCursos();
            return Ok(listaCurso);
        }

        [HttpGet("{id}")]
        public IActionResult ObterCursoViaID(string id)
        {
            Curso curso = _disciplinaServico.ObterCurso(id);
            if (curso == null)
            {
                return NotFound();
            }
            return Ok(curso);
        }

        // Fazer PUT (atualizar) do Curso por ID
        //[HttpPut("{id}")]

        // Faze DELETE (deletar) do Curso por ID
        //[HttpDelete("{id}")]
    }
}
