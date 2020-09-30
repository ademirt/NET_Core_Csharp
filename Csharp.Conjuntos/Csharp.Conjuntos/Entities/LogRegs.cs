using System;

namespace Csharp.Conjuntos.Entities
{
    class LogRegs
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRegs))
            {
                return false;
            }
            LogRegs o = obj as LogRegs;

            return Nome.Equals(o.Nome);
        }

    }
}
