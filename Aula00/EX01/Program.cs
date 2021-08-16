using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Contas a Pagar***************\n\n");
            Console.WriteLine("**************Calculador de Pagamento***************");

            Boleto boleto = new Boleto();

            Console.Write($"Digite o nome do Cedente: ");
            boleto.Cedente = Console.ReadLine();
            Console.Write($"Descrição do Serviço: ");
            boleto.Descricao= Console.ReadLine();
            Console.Write($"Valor do Serviço: ");
            boleto.ValorServico = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\n**************");
            Console.WriteLine($"Cedente: {boleto.Cedente}");
            Console.WriteLine($"Descrição do Serviço: {boleto.Descricao}");
            Console.WriteLine($"Valor do Serviço: {boleto.ValorServico:C2}");
            Console.WriteLine($"Data de Emissão: {boleto.DataEmissao}");
            Console.WriteLine($"Data de Vencimento: {boleto.DataVencimento}");
            Console.WriteLine("**************");

            Console.Write("Digite a data do pagamento:");
            boleto.DataPagamento = Convert.ToDateTime(Console.ReadLine());

            double valor = boleto.Calcular();

            Console.WriteLine($"Valor a Pagar: {valor:C2}");
            if(boleto.DiasAtrasados > 0)
            {
                Console.WriteLine($"O boleto foi pago com {boleto.DiasAtrasados} de atraso");
            }



        }
    }
}
