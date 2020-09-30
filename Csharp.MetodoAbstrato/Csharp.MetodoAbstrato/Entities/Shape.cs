using Csharp.MetodoAbstrato.Entities.Enum;

namespace Csharp.MetodoAbstrato.Entities
{
    abstract class Shape
    {
        /*
         * Classe abastrata
         */

        //propertie
        public Cor Cores { get; set; }


        //construtores
        public Shape()
        {
        }

        public Shape(Cor cores)
        {
            Cores = cores;
        }

        //método abastrato
        public abstract double Area();
    }
}
