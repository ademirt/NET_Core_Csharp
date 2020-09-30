using System;

namespace Csharp.Curso.Exe7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Quantos quartos serão alugados ? ");
            int qtde = int.Parse(Console.ReadLine());

            Quarto[] q = new Quarto[9];//10 quartos

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("\nAluguel #" + (i+1));

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Nr. Quarto: ");
                int nrquarto = int.Parse(Console.ReadLine());

                q[i] = new Quarto { Nome = nome, Email = email, Nrquarto = nrquarto };
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] != null ) { Console.WriteLine(q[i]); }
                //Console.WriteLine("Indice vetor["+i+"] " + q[i]);
            }
        }
    }
}
