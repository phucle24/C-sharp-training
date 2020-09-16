using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public interface ICollection : IEnumerable
    {
        public int Count { get;}
    }
}
