using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using CursoProfessor.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoProfessor.Servico
{
    public class DisciplinaServico
    {
        private List<Curso> _listaCurso = Armazenamento.Cursos;
        private List<Professor> _listaProfessor = Armazenamento.Professores;

        public Professor CadastrarProfessor(ProfessorViewModel professorRecebido)
        {
            Professor professor = new Professor(professorRecebido);

            professor.NomeProfessor = professorRecebido.NomeProfessor;
            professor.IdadeProfessor = professorRecebido.IdadeProfessor;

            _listaProfessor.Add(professor);
            return professor;
        }

        public List<Professor> ListarProfessores()
        {
            List<Professor> listaProfessor = new List<Professor>();

            listaProfessor.AddRange(_listaProfessor);
            return listaProfessor;
        }

        public Professor ObterProfessor(string idPRecebido)
        {
            List<Professor> listaP = ListarProfessores();
            if (listaP.Any(u => u.IdProfessor.ToString() == idPRecebido))
            {
                Professor professor = listaP
                   .Where(u => u.IdProfessor.ToString() == idPRecebido)
                   .First();
                return professor;
            }
            return null;
        }

        public Curso CadastrarCurso(CursoViewModel cursoRecebido)
        {
            Curso curso = new Curso(cursoRecebido);

            curso.NomeCurso = cursoRecebido.NomeCurso;

            _listaCurso.Add(curso);
            return curso;
        }

        public List<Curso> ListarCursos()
        {
            List<Curso> listaCurso = new List<Curso>();

            listaCurso.AddRange(_listaCurso);
            return listaCurso;
        }

        public Curso ObterCurso(string idCRecebido)
        {
            List<Curso> listaC = ListarCursos();
            if (listaC.Any(u => u.IdCurso.ToString() == idCRecebido))
            {
                Curso curso = listaC
                   .Where(u => u.IdCurso.ToString() == idCRecebido)
                   .First();
                return curso;
            }
            return null;
        }

        // resolver método de deletar professor
        public Professor RemoveProfessor(Professor IdProf)
        {
            // codificar
            return IdProf;
        }


    }
}
