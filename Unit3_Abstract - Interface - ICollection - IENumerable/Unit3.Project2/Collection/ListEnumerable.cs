using System;
namespace Collection
{
    public class ListEnumerable : IEnumerable
    {
        private object[] _contents;
        public ListEnumerable(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                _contents[i] = array[i];
            }
        }

        IEnumerable IEnumerable.GetEnumerator()
        {
            return new ListEnumerable(_contents);
        }
    }
}
