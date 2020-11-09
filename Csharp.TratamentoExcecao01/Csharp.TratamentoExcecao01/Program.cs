using Csharp.TratamentoExcecao01.Entities;
using Csharp.TratamentoExcecao01.Exceptions;
using System;

namespace Csharp.TratamentoExcecao01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de tratamento de exceção personalizado....

            try
            {
                Console.Clear();
                Console.Write("Informe o número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                Console.Write("Data Check-IN: ");
                DateTime dtCheckIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data Check-OUT: ");
                DateTime dtCheckOut = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(numeroQuarto, dtCheckIn, dtCheckOut);
                Console.WriteLine(reserva);

                Console.WriteLine("\nAtualização de data de reserva:");

                Console.Write("Data Check-IN: ");
                dtCheckIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data Check-OUT: ");
                dtCheckOut = DateTime.Parse(Console.ReadLine());

                reserva.AtualizaDatas(dtCheckIn, dtCheckOut);
                Console.WriteLine("Reservas: " + reserva);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado! " + e.Message);
            }

        }
    }
}
