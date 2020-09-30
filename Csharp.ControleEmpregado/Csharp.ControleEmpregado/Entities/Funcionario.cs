using System.Text;

namespace Csharp.ControleEmpregado.Entities
{
    class Funcionario
    {
        //atributos
        public string Nome { get; set; }
        public int HorasTrab { get; set; }
        public double ValorHora { get; set; }


        //construtores
        public Funcionario()
        {
        }
        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            HorasTrab = horas;
            ValorHora = valorHora;
        }

        //método - virtual-> indica que permite sobreposição de método
        public virtual double Pagamento()
        {
            return HorasTrab * ValorHora;
        }
    }
}
