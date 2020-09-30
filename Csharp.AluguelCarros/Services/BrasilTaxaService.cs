namespace Csharp.AluguelCarros.Services
{
    class BrasilTaxaService : ITaxaService
    {
        public double Taxa(double valor)
        {
            return valor <= 100.0 ? valor * 0.2 : valor * 0.15;
        }
    }
}
