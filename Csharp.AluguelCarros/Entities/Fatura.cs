using System;
using System.Globalization;

namespace Csharp.AluguelCarros.Entities
{
    class Fatura
    {
        public double PagtoBasico { get; set; }
        public double Taxa {get;set;}

        //csontrutores        
        public Fatura(double pagtobasico, double taxa)
        {
            PagtoBasico = pagtobasico;
            Taxa = taxa;
        }

        public double TotalPagamento 
        {
            get {return PagtoBasico + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento Básico: "
                    + PagtoBasico.ToString("F2",CultureInfo.InvariantCulture)
                    +"\nTaxa: "
                    + Taxa.ToString("F2",CultureInfo.InvariantCulture)
                    + "\nTotal Pagamento: "
                    + TotalPagamento.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
