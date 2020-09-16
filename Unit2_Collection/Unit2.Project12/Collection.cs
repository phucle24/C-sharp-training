using System;
using System.Collections.Generic;
using System.Text;

namespace Unit2.Project12
{
    public class Collection
    {
        private object[] _array;
        public object this[int index]
        {
            get
            {
                if (index >= _array.Length)
                {
                    return null;
                }
                return _array[index];
            }
        }

        /// <summary>
        /// Gắn phần tử vào _arry
        /// </summary>
        /// <param name="array"></param>
        public Collection(object[] array)
        {
            _array = array;
        }
    }
}
