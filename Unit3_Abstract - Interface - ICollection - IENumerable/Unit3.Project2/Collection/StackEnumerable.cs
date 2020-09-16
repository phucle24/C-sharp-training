using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class StackEnumerable : IEnumerable
    {
        private object[] _contents;
        public StackEnumerable(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                _contents[i] = array[i];
            }
        }

        IEnumerable IEnumerable.GetEnumerator()
        {
            return new StackEnumerable(_contents);
        }

        public StackEnumerator GetEnumerator()
        {
            return new StackEnumerator(_contents);
        }
    }
}
