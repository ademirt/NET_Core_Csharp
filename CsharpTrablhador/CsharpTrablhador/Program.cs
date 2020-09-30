using CsharpTrablhador.Entities;
using CsharpTrablhador.Entities.Enums;
using System;
using System.Globalization;

namespace CsharpTrablhador
{
    class Program
    {
        static void Main()
        {
            Console.Write("Informe o nome do departamento: ");
            string deptoNome = Console.ReadLine();

            Console.Write("\nInforme os dados do colaborador:");
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
                        
            Console.Write("\nNível ({0}): " , ListarNiveis());
            ColaboradorLevel nivel = Enum.Parse<ColaboradorLevel>(Console.ReadLine());

            Console.Write("\nSalário base: ");
            double baseSalario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departamento depto = new Departamento(deptoNome);
            Colaborador colaborador = new Colaborador(nome, nivel, baseSalario, depto);            


            Console.Write("\nInforme a quantidade de contratos para este trabalhor: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nDigite os dados do contrato -> {i}");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor hora: ");
                double valorHora = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);

                Console.Write("Duração(horas): ");
                int horas = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(data, valorHora, horas);
                colaborador.AdicionaContrato(contrato);
            }

            Console.Write("\nInforme o Mês/Ano para calcular o ganho (MM/AAAA): ");
            string mesAno = Console.ReadLine();

            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.Write("\nNome: " + colaborador.Nome);
            Console.Write("\nDepartamento: " + colaborador.Departamento.Nome);
            Console.Write("\nGanho em: " + mesAno + ": " + colaborador.Ganho(ano,mes).ToString("F2",CultureInfo.InvariantCulture));
        }

        static string ListarNiveis()
        {
            string niveis = "";
            foreach (string s in Enum.GetNames(typeof(ColaboradorLevel)))
                niveis = niveis + s + "/";

            return niveis;
        }

    }
}
