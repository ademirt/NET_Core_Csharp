namespace Csharp.GerContratos.Services
{
    public class PayPalService : IPagtoOnlineService
    {
        public double Juros(int nrParcela, double vlrParcela)
        {
            //calcular juros...
            return vlrParcela * 1/100 * nrParcela;
        }

        public double Taxa(double vlrParcela)    
        {
            //calcular taxa...
            return vlrParcela * 2/100;
        }
    }
}