using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX01.Entities
{
    class Curso
    {
        public List<int> alunos { get; set; }

        public Curso(List<int> alunos)
        {
            this.alunos = alunos;
        }

        public List<int> Merge(List<int> listA, List<int> listB)
        {
            List<int> merge = new List<int>(alunos.Union(new List<int>(listA.Union(listB))));

            return merge;
        }


    }
}
