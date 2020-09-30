using System;

namespace Csharp.Curso.Exe1
{
    class Pessoa
    {
        //atributos
        public string nome;
        public int idade;

        //método
        public void ExibirDados()
        {
            Console.WriteLine("Nome: {0}, idade: {1}", this.nome, this.idade);
        }
    }
}
