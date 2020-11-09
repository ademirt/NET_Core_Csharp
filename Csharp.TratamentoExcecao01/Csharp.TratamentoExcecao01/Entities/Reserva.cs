using Csharp.TratamentoExcecao01.Exceptions;
using System;

namespace Csharp.TratamentoExcecao01.Entities
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {
        }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Data de saída não poderá ser igual ou inferior a data de entrada!!!");
            }

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //método para retornar duração de dias entre checkin e checkout
        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizaDatas(DateTime checkin, DateTime checkout)
        {
            DateTime atual = DateTime.Now;
            if (checkin < atual || checkout < atual)
            {
                throw new DomainException("Datas das reservas devem ser futuras!!!");
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Data de saída não poderá ser igual ou inferior a data de entrada!!!");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Quarto "
                  + NumeroQuarto
                  + ", Check-IN: "
                  + CheckIn.ToString("dd/MM/yyyy")
                  + ", check-OUT: "
                  + CheckOut.ToString("dd/MM/yyyy")
                  + ", duração dias: " + Duracao();
        }

    }
}
