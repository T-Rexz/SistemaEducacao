using CursoProfessor.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Modelo
{
    public class Curso
    {
        public Guid IdCurso { get; set; }
        public string NomeCurso { get; set; }

        public Curso(CursoViewModel cursoRecebido)
        {
            IdCurso = Guid.NewGuid();
            NomeCurso = cursoRecebido.NomeCurso;
        }
    }
}
