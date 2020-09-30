using System;
using System.Globalization;

namespace Csharp.GerContratos.Entities
{
    public class Parcela
    {
        //property
        public DateTime DtVencimento { get; set; }
        public double VlrParcela { get; set; }


        //construtor
        public Parcela(DateTime dtVencimento, double vlrParcela)
        {
            DtVencimento = dtVencimento;
            VlrParcela = vlrParcela;
        }

        //exibir dados na tela....
        public override string ToString()
        {  
            return DtVencimento.ToString("dd/MM/yyyy") 
                      + " - $" 
                      + VlrParcela.ToString("F2",CultureInfo.InvariantCulture);
                      
        }
    }
}