using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.entities
{
    class Produto
    {
        private string nome;
        private double preco;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
    }
}
