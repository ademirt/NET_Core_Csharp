namespace Csharp.Blog.Entities
{
    class Comentario
    {
        //atributo
        public string Texto { get; set; }

        //Construtor
        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
