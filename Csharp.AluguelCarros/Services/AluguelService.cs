using System;
using Csharp.AluguelCarros.Entities;

namespace Csharp.AluguelCarros.Services
{
    class AluguelService
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        //antes,  sem interface,  alta dependencia
        //private BrasilTaxaService _brasilTaxaService = new BrasilTaxaService();

        //com interface, baixo acoplamento...
        private ITaxaService _taxaService;


        //construtor
        public AluguelService(double precohora, double precodia, ITaxaService taxaService)
        {
            PrecoHora = precohora;
            PrecoDia = precodia;
            _taxaService = taxaService;
        }


        //método
        public void ProcessaFatura(Aluguel aluguel)
        {
            TimeSpan duracao = aluguel.Termino.Subtract(aluguel.Inicio);  
            Console.WriteLine("Duracao ---> "+duracao);

            double pgtoBasico = duracao.TotalHours <= 12.0 ? PrecoHora * Math.Ceiling(duracao.TotalHours) 
                                                             : PrecoDia * Math.Ceiling(duracao.TotalDays);

            double taxa = _taxaService.Taxa(pgtoBasico);

            aluguel.Fatura = new Fatura(pgtoBasico,taxa);

        }

    }
}
