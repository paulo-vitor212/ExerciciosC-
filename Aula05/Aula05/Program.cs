using System;
using EX01.Entities;
using EX01.Services;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Processando Contratos*************");
            Console.WriteLine("Dados do Contrato");
            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Valor do Contrato: ");
            double valorTotal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Número de prestações: ");
            int numeroPrestacoes = Convert.ToInt32(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valorTotal);

            ContratoServico contratoServico = new ContratoServico();
            contratoServico.processarContrato(contrato, numeroPrestacoes);

            Console.WriteLine("\nParcelas:");
            contrato.Parcelas.ForEach(parcela =>
            {
                Console.WriteLine($"{parcela.DataVencimento:d} - {parcela.Valor:C2}");
            });
        }
    }
}
