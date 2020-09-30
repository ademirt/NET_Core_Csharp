using System;

namespace Csharp.SisPedido.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }

        //Construtores
        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dtNascimento)
        {
            Nome = nome;
            Email = email;
            DtNascimento = dtNascimento;
        }

        public override string ToString()
        {
            return Nome
                + ", ("
                + DtNascimento.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
