using System;

namespace Csharp.Generics_PrintService.Services
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        
        public void AddValor(T valor)
        {
            if (_count == 10) 
            {
                throw new InvalidOperationException("Fila print service está cheia!");
            }
            _values[_count] = valor;
            _count++;
        }

        public T First()
        {
            if (_count == 0) 
            {
                throw new InvalidOperationException("Fila print service está vazia!");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("\n[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");                
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);                
            }
            Console.Write("]");
        }
    }
}