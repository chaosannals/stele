using System;
using System.Collections.Generic;
using System.Text;

namespace Stele.Runtime
{
    public class Scope
    {
        private Dictionary<string, object> data;
        public Scope Parent { get; private set; }

        public Scope() : this(null) { }

        public Scope(Scope parent)
        {
            Parent = parent;
            data = new Dictionary<string, object>();
        }

        public bool Has(string name)
        {
            return data.ContainsKey(name) ||
                (Parent != null && Parent.Has(name));
        }

        public object Get(string name)
        {
            if (data.ContainsKey(name))
            {
                return data[name];
            }
            if (Parent != null)
            {
                return Parent.Get(name);
            }
            return null;
        }

        public void Set(string name, object value)
        {
            if (data.ContainsKey(name))
            {
                data[name] = value;
            }
            else if (Parent.Has(name))
            {
                Parent.Set(name, value);
            }
            else
            {
                data[name] = value;
            }
        }

        public void Let(string name, object value)
        {
            data[name] = value;
        }
    }
}
