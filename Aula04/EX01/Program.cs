using System;
using EX01.entities;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********SISTEMA**********");

            Cliente cliente = new Cliente();
            
            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Email: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            cliente.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\n\nDados do Pedido:");

            Pedido pedido = new Pedido();
            pedido.Status = (PedidoStatus)0;
            pedido.Data = DateTime.Now;

            Console.WriteLine($"\nStatus: {pedido.Status}");
            Console.Write($"Quantidade de pedidos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"\n--Produto #{i}--");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                pedido.AdicionarProduto(nomeProduto, precoProduto, quantidadeProduto);
            }

            Console.WriteLine("\n\nResumo do Pedido: ");
            Console.WriteLine($"Data do pedido: {pedido.Data}");
            Console.WriteLine($"Status: {pedido.Status}");
            Console.WriteLine($"Cliente: {cliente.Nome}, ({cliente.DataNascimento:d}), {cliente.Email}");

            Console.WriteLine("\n\nResumo dos Produtos:");
            pedido.ItemPedido.ForEach(itemPedido => {
                Console.WriteLine($"{itemPedido.Produto.Nome}, {itemPedido.Produto.Preco:C2}, Qtd: {itemPedido.Quantidade}, Subtotal: {itemPedido.SubTotal():C2}");
            });

            Console.WriteLine($"\nPreço Total: {pedido.Total():C2}");
            Console.WriteLine($"Status do Pedido: {pedido.Status}");

        }
    }
}
