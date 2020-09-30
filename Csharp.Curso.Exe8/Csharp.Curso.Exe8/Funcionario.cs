using System.Globalization;

namespace Csharp.Curso.Exe8
{
    class Funcionario
    {
        //atributos
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        //Constructor
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        //métodos
        public void AjusteSalario(double percentual)
        {
            Salario += (Salario * percentual) / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
