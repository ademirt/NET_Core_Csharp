using System;

namespace Csharp.AluguelCarros.Entities
{
    class Aluguel
    {
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Veiculo Veiculo  { get; set; }
        public Fatura Fatura   { get; set; }

        //csontrutores        
        public Aluguel(DateTime inicio, DateTime termino, Veiculo veiculo)
        {
            Inicio = inicio;
            Termino = termino;
            Veiculo = veiculo;
        }
    }
}
