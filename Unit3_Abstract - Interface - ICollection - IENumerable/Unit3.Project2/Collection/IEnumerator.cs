using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public interface IEnumerator
    {
        public bool MoveNext();
        public void Reset();
        public object Current
        {
            get;
        }
    }
}
