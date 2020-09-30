using System;
using System.Globalization;


namespace Csharp.Curso.Exe4
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcNotas()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void ResultadoFinal()
        {
            double _notaFinal = CalcNotas();
            if (_notaFinal >= 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM " + (60.00 - _notaFinal).ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }
        }

        public override string ToString()
        {              
            return "NOTA FINAL = " + CalcNotas().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
