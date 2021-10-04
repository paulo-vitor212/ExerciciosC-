using System;
using System.Collections.Generic;
using System.Text;
using EX01.Entities;

namespace EX01.Services
{
    class ContratoServico
    {
        public void processarContrato(Contrato contrato, int meses)
        {

            double valorPorMes = contrato.ValorTotal / meses;
            PaypalServico paypal = new PaypalServico();
            for(int i = 1; i <= 3; i++)
            {
                double valor = valorPorMes + paypal.Juros(valorPorMes, i);
                valor += paypal.TaxaPagamento(valor);
                Parcela parcela = new Parcela
                {
                    DataVencimento = contrato.Data.AddMonths(i),
                    Valor = valor
                };
                contrato.AdicionarParcela(parcela);
            }
        }
    }
}
