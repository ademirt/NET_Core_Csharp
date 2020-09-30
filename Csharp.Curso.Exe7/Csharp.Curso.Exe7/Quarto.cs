
namespace Csharp.Curso.Exe7
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Nrquarto { get; set; }

        public override string ToString()
        {
            return Nrquarto + ": " + Nome + ", " + Email;
        }
    }
}
