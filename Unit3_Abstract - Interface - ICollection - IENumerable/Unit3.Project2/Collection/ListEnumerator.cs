using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class ListEnumerator : IEnumerator
    {
        public object[] _contents;
        private int _count = -1;

        public ListEnumerator(object[] list)
        {
            _contents = list;
        }

        public bool MoveNext()
        {
            _count++;
            return (_count < _contents.Length);
        }

        public void Reset()
        {
            _count = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public object Current
        {
            get
            {
                return _contents[_count];
            }
        }
    }
}
