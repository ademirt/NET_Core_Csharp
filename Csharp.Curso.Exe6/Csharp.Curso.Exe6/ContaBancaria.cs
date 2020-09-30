using System.Globalization;

namespace Csharp.Curso.Exe6
{
    class ContaBancaria
    {
        //atributos        
        private string _titular;                
        private double _taxa = 5.60;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        //constructor
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            _titular = titular;
            Saldo = 0;
        }
        public ContaBancaria(int numero, string titular, double valor) : this(numero, titular) 
        {
            /* Nota: não popular o atributo Saldo no construtor, mas chamar o método Depositar
                     em atenção as regras de negócio implementadas no método.
            */
            Depositar(valor);
        }

        //Properties
        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _titular = value;
                }
            }
        }

        //métodos
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor + _taxa;
        }

        //Sobreposição
        public override string ToString()
        {
            return "Conta " + Numero
                   + ", Titular: " + Titular
                   + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}