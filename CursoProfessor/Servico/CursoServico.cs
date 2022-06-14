using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Servico
{
    public class CursoServico
    {
        private List<Curso> _listaCursos = new List<Curso>();

        public List<Curso> ListarCurso()
        {
            return _listaCursos;
        }
    }
}
