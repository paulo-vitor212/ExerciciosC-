using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Services
{
    class PaypalServico: IOnlineServicoPagamento
    {
        public double TaxaPagamento(double valor)
        {
            return valor * 0.02;
        }

        public double Juros(double valor, int meses)
        {
            return valor * 0.01 * meses;
        }
    }
}
