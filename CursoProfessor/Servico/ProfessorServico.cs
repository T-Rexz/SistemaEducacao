using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Servico
{
    public class ProfessorServico
    {
        public Professor CadastrarProfessor()
        {
            Professor professor = new Professor();
            Armazenamento.Professores.Add(professor);

            return professor;
        }
    }
}
