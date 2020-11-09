using System;


namespace Csharp.TratamentoExcecao01.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
