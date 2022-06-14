using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Servico
{
    public class CursoServico
    {
        public Curso CadastrarCurso()
        {
            Curso curso = new Curso();
            Armazenamento.Cursos.Add(curso);

            return curso;
        }
    }
}
