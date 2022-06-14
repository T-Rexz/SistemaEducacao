using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using CursoProfessor.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Servico
{
    public class DisciplinaServico
    {
        private List<Curso> _listaCurso = Armazenamento.Cursos;
        private List<Professor> _listaProfessor = Armazenamento.Professores;

        public List<object> ListarDisciplina()
        {
            List<object> listaDisciplina = new List<object>();

            listaDisciplina.AddRange(_listaCurso);
            listaDisciplina.AddRange(_listaProfessor);
            return listaDisciplina;
        }

        public Curso CadastrarCurso(CursoViewModel cursoRecebido)
        {
            Curso curso = new Curso();

            curso.idCurso = cursoRecebido.idCurso;
            curso.nomeCurso = cursoRecebido.nomeCurso;

            _listaCurso.Add(curso);
            return curso;
        }

        //public List<Curso> ListarCurso()
        //{
        //    return _listaCurso;
        //}

        public Professor CadastrarProfessor(ProfessorViewModel professorRecebido)
        {
            Professor professor = new Professor();

            professor.idProfessor = professorRecebido.idProfessor;
            professor.nomeProfessor = professorRecebido.nomeProfessor;

            _listaProfessor.Add(professor);
            return professor;
        }

        //public List<Professor> ListarProfessor()
        //{
        //    return _listaProfessor;
        //}
    }
}
