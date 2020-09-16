using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class QueueEnumerable : IEnumerable
    {

        private object[] _contents;
        public QueueEnumerable(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                _contents[i] = array[i];
            }
        }

        IEnumerable IEnumerable.GetEnumerator()
        {
            return new QueueEnumerable(_contents);
        }
    }
}
