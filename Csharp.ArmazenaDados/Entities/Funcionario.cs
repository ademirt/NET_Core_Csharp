using System;
namespace Csharp.ArmazenaDados.Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vet = csvFuncionario.Split(',');
            Nome = vet[0];
            Salario = double.Parse(vet[1]);
        }

        public override string ToString()
        {
            return Nome.PadRight(20,'.') + ": $" + Salario.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro de comparação: argumento não é Funcionario!");
            }

            Funcionario outro =  obj as Funcionario;
            return Salario.CompareTo(outro.Salario);
        }
    }
}