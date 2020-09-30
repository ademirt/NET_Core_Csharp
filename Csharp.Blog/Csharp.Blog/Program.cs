using Csharp.Blog.Entities;
using System;

namespace Csharp.Blog
{
    class Program
    {
        static void Main()
        {
            Post p1 = new Post(DateTime.Now,"Altas viagens top!","aqui é o conteúdo das altas viagens",13);
            Comentario a1 = new Comentario("#foda!!");
            Comentario a2 = new Comentario("#MuitaFoda!!");

            p1.AddComentario(a1);
            p1.AddComentario(a2);

            Post p2 = new Post(DateTime.Now,"Muita loucura nas viagens!!", "aqui é o conteúdo de muita loucura", 55);
            Comentario b1 = new Comentario("#foda!!");
            Comentario b2 = new Comentario("#MuitaFoda!!");

            p2.Comentarios.Add(b1);
            p2.Comentarios.Add(b2);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
