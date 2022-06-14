using CursoProfessor.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Modelo
{
    public class Professor
    {
        public Guid IdProfessor { get; set; }
        public string NomeProfessor { get; set; }
        public int IdadeProfessor { get; set; }

        public Professor (ProfessorViewModel professorRecebido)
        {
            IdProfessor = Guid.NewGuid();
            NomeProfessor = professorRecebido.NomeProfessor;
            IdadeProfessor = professorRecebido.IdadeProfessor;
        }
    }
}
