using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Services
{
    interface IOnlineServicoPagamento
    {
        double TaxaPagamento(double valor);
        double Juros(double valor, int meses);
    }
}
