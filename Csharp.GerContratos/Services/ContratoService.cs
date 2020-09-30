using Csharp.GerContratos.Entities;
using System;

namespace Csharp.GerContratos.Services
{
    public class ContratoService
    {        
        private IPagtoOnlineService _pagtoOnline;

        public ContratoService(IPagtoOnlineService pagtoOnlineService)
        {
            _pagtoOnline = pagtoOnlineService;
        }

        //
        //Gerar e calcular as parcelas p/ pagamento online....        
        //
        public void GerarParcela(Contrato contrato,int nrParcela)
        {
            double vlParcela = contrato.VlrContrato / nrParcela;

            for (int i = 1; i <= nrParcela; i++)
            {
                //deduzir data de vencimento da parcela...
                DateTime dtVencParc = contrato.DtContrato.AddMonths(i);

                //Calcular valor + juros...
                double vlJuros = vlParcela + _pagtoOnline.Juros(i ,vlParcela);

                //Calcular valor juros + taxa
                double vlParcelaFinal = vlJuros + _pagtoOnline.Taxa(vlJuros);

                contrato.AddParcela(new Parcela(dtVencParc ,vlParcelaFinal));
            }
        }
    }
}