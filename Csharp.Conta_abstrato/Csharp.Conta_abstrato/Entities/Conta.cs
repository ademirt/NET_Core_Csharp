namespace Csharp.Conta_abstrato.Entities
{
    abstract class Conta
    {
        //Classe Conta -> super classe (clase base)
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //método
        public virtual void Sacar(double valor)
        {
            Saldo -= valor + 5.0;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
