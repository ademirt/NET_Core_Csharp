using System;
using System.Linq;

namespace Csharp.Linq_exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 4, 8, 9, 10, 12, 15 };

            var res = num
                     .Where(x => x % 2 == 0)
                     .Select(x => x * 10);

            foreach (int x in res)
            {
                Console.WriteLine(x);
            }
        }
    }
}
