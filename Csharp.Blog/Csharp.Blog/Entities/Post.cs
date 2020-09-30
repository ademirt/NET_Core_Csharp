using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Blog.Entities
{
    class Post
    {
        //atributos
        public  DateTime DataPost{ get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        //construtor
        public Post()
        {
        }

        //Construtor
        public Post(DateTime dataPost, string titulo, string conteudo, int likes)
        {
            DataPost = dataPost;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }
        public void RmvComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.AppendLine(Likes + " Likes - " + DataPost.ToString("d/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");

            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}
