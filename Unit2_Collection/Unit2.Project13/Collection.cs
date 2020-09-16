using System;
using System.Collections.Generic;
using System.Text;

namespace Unit2.Project13
{
    public class Collection
    {

        private object[,] _array;
        public object this[int index1, int index2]
        {
            get
            {
                try
                {
                    return _array[index1, index2];
                }
                catch (Exception e)
                {
                    Console.Write("Chi so nhap vao khong hop le");
                    return null;
                }
            }
            set { }
        }

        /// <summary>
        /// Gắn phần tử vào _arry
        /// </summary>
        /// <param name="array"></param>
        public Collection(object[,] array)
        {
            _array = array;
        }
    }
}
