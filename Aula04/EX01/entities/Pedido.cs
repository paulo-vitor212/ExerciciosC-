using System;
using EX01.entities;
using System.Collections.Generic;

namespace EX01
{
    class Pedido
    {
        private DateTime data;
        private PedidoStatus status;
        private List<ItemPedido> itemPedido = new List<ItemPedido>();

        public DateTime Data { get => data; set => data = value; }
        public PedidoStatus Status { get => status; set => status = value; }
        internal List<ItemPedido> ItemPedido { get => itemPedido; set => itemPedido = value; }

        public void AdicionarProduto(string nome, double preco, int quantidade)
        {
            this.status = (PedidoStatus)1;

            Produto produto = new Produto();
            produto.Nome = nome;
            produto.Preco = preco;

            ItemPedido itemPedido = new ItemPedido(quantidade, preco, produto);
            //double subTotal = itemPedido.subTotal();
            this.itemPedido.Add(itemPedido);
        }

        public void RemoverProduto(string nome)
        {
            ItemPedido itemPedidoToRemove = itemPedido.Find(item =>
            {
                return item.Produto.Nome == nome;
            });

            itemPedido.Remove(itemPedidoToRemove);
        }

        public double Total() 
        {
            double sum = 0;
            this.ItemPedido.ForEach(item => {
                sum += item.SubTotal();
            });
            this.Status = (PedidoStatus)3;
            return sum;
        }
    }
}
