namespace Csharp.GerContratos.Services
{
    public interface IPagtoOnlineService
    {
        double Juros(int nrParcela, double vlrParcela);
        double Taxa(double vlrParcela);
    }
}