using System;
using System.Collections.Generic;
using System.Text;

namespace EX02.Entities
{
    class Candidato : IEnumerable
    {
        private string nome;
        private int votos;

        public string Nome { get => nome; set => nome = value; }
        public int Votos { get => votos; set => votos = value; }
    }

    internal interface IEnumerable
    {

    }
}
