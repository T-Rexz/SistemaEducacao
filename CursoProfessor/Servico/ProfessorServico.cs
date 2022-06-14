using CursoProfessor.Modelo;
using CursoProfessor.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Servico
{
    public class ProfessorServico
    {
        private List<Professor> _listaProfessores = new List<Professor>();

        public List<Professor> ListarProfessor()
        {
            return _listaProfessores;
        }
    }
}
