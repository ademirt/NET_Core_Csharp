using System;
//using Csharp.Extension_Methods.Extensions;

namespace Csharp.Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            DateTime dt = new DateTime(2020,09,22,8,10,45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Testando extension methods...";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
