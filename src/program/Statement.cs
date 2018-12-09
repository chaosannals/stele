using System;
using Stele.Runtime;

namespace Stele.Program
{
    public abstract class Statement
    {
        public abstract object Evaluate(Scope scope);
    }
}
