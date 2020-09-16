using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project3
{
    public class Queue<T> where T : class
    {

        private T[] _queue = new T[5];
        private int _currentIndex = -1;
        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
        }
        public void Enqueue(T value)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if (_currentIndex >= _queue.Length)
            {
                T[] _temp = new T[2 * _queue.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _queue[i];
                }
                _queue = _temp;
                _queue[_currentIndex] = value;
            }
            _queue[_currentIndex] = value;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Trả về giá trị mặc định của (T) = 0, nếu danh sách không chưa phần tử
        /// </returns>
        public T Peek()
        {
            if (_currentIndex < 0) return null;
            return _queue[0];
        }

        public T Dequeue()
        {
            T lastQueue = Peek();
            if (_currentIndex > -1)
            {
                for (int i = 0; i < _currentIndex; i++)
                {
                    _queue[i] = _queue[i + 1];
                }
                _currentIndex--;
            }
            return lastQueue;
        }
    }
}
