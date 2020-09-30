using CsharpTrablhador.Entities.Enums;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CsharpTrablhador.Entities
{
    class Colaborador
    {
        //atributos
        public string Nome { get; set; }
        public ColaboradorLevel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        //construtores
        public Colaborador()
        {
        }

        public Colaborador(string nome, ColaboradorLevel nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        //métodos
        public void AdicionaContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoveContrato(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach (HoraContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.TotalHoras();
                }
            }

            return soma;
        }
    }
}
