using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Pair<S, T>
    {
        public S Name { get; private set; }
        public T Id { get; private set; }

        public Pair(S name, T id)
            {
            Name = name;
            Id = id;
            }
    }
}
