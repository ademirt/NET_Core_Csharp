using System.Globalization;

namespace Csharp.Curso.Exe3
{
    class Pessoa
    {
        public string Nome;
        public double SalBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalBruto - Imposto;
        }

        public void AumentarSalPerc(double _prc)
        {
            SalBruto += SalBruto * (_prc / 100);
        }

        public override string ToString()
        {
            return Nome 
                     + ", $ " 
                     + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
