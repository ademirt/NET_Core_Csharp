using System;

namespace Csharp.Curso.Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Informe o nome da pessoa:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            p2.idade = int.Parse(Console.ReadLine());

            p1.ExibirDados();
            p2.ExibirDados();

            Console.WriteLine("Pessoa mais velha: " + ((p1.idade > p2.idade) ? p1.nome : p2.nome ) );
            /*if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }*/

        }
    }
}
