using System;
using Stele.Runtime;

namespace Stele.Program
{
    public abstract class Expression : Statement
    {
        public override object Evaluate(Scope scope)
        {
            return null;
        }
    }
}
