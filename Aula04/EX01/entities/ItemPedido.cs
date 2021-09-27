using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.entities
{
    class ItemPedido
    {
        private int quantidade;
        private double preco;
        private Produto produto;

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            this.quantidade = quantidade;
            this.preco = preco;
            this.produto = produto;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Preco { get => preco; set => preco = value; }
        internal Produto Produto { get => produto; set => produto = value; }

        public double SubTotal()
        {
            return this.preco * this.quantidade;
        }
    }
}
