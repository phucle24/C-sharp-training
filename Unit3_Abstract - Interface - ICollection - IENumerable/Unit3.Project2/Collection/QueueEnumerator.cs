using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class QueueEnumerator : IEnumerator
    {

        public object[] _contents;
        private int _count = -1;

        public QueueEnumerator(object[] list)
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
                try
                {
                    return _contents[_count];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
