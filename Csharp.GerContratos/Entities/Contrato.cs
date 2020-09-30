using System;
using System.Collections.Generic;

namespace Csharp.GerContratos.Entities
{
    public class Contrato
    {
        public int NrContrato { get; set; }
        public DateTime DtContrato { get; set; }
        public double VlrContrato { get; set; }
        public List<Parcela> Parcela { get; set; }


        //construtor
        public Contrato(int nrContrato, DateTime dtContrato, double vlrContrato)
        {
            NrContrato = nrContrato;
            DtContrato = dtContrato;
            VlrContrato = vlrContrato;
            Parcela = new List<Parcela>();
        }

        //método para adicionar parcela..
        public void AddParcela(Parcela parcela)
        {
            Parcela.Add(parcela);
        }
    }
}