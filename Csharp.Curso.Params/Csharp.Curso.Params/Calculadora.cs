namespace Csharp.Curso.Params
{
    class Calculadora
    {
        public int Soma(params int[] valores)
        {
            int soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            return soma;
        }
    }
}
