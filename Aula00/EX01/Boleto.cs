using System;
using System.Collections.Generic;
using System.Text;

namespace EX01
{
    class Boleto
    {
        private string cedente;
        private string descricao;
        private double valorServico;
        private DateTime dataEmissao = DateTime.Now;
        private DateTime dataVencimento = DateTime.Now.Date.AddDays(7);
        private DateTime dataPagamento;
        private int diasAtrasados = 0;

        public string Cedente { get => cedente; set => cedente = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double ValorServico { get => valorServico; set => valorServico = value; }
        public DateTime DataEmissao { get => dataEmissao; set => dataEmissao = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public DateTime DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public int DiasAtrasados { get => diasAtrasados; set => diasAtrasados = value; }


        public double Calcular()
        {
            double valor = ValorServico;

            if(DataPagamento > DataVencimento)
            {
                //boleto com atraso
                valor += 100;
                TimeSpan dias = DataPagamento - DataVencimento;

                if(dias.Days > 0)
                {
                    DiasAtrasados = dias.Days;
                    var jurosDiarios = DiasAtrasados / 100f;
                    valor = ValorServico * Convert.ToDouble(jurosDiarios) + valor;
                }
            }

            return valor;
        }
    }
}
