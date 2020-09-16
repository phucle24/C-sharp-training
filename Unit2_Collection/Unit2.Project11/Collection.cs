using System;
using System.Collections.Generic;
using System.Text;

namespace Unit2.Project11
{
    public class Collection
    {
        private object[] _array;
        private int _count;

        public object Current
        {
            get
            {
                if (_count >= _array.Length)
                {
                    return null;
                }
                return _array[_count];
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

        /// <summary>
        /// Kiểm tra vị trí tiếp theo của phần tử trong mảng
        /// </summary>
        /// <returns></returns>
        public bool Next()
        {
            _count++;
            return _count < _array.Length;
        }
    }
}
