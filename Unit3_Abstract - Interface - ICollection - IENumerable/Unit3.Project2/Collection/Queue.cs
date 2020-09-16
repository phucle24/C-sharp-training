using System;
using System.Collections;

namespace Collection
{
    public class Queue : ICollection
    {
        private object[] _queue = new object[5];
        private int _currentIndex= -1;

        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
        }

        /// <summary>
        /// Thêm 1 phần tử vào Queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(object item)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if(_currentIndex >= _queue.Length)
            {
                object[] _temp = new object[2 * _queue.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _queue[i];
                }
                _queue = _temp;
                _queue[_currentIndex] = item;
            }
            _queue[_currentIndex] = item;
        }

        /// <summary>
        /// Trả về giá trị của đối tượng tại vị trí đầu trong Queue
        /// Không xóa phần tử
        /// </summary>
        /// <returns></returns>
        public object Peek()
        {
            return _queue[0];
        }

        /// <summary>
        /// Lấy và xóa đi phần tử đầu tiên của Queue
        /// </summary>
        /// <returns></returns>
        public object Dequeue()
        {
            object firstItem = Peek();
            if (_currentIndex < 0) return null;
            _queue[0] = null;
            for (int i = 0; i <= _currentIndex; i++)
            {
                _queue[i] = _queue[i + 1];
            }
            _currentIndex--;
            return firstItem;
        }

        /// <summary>
        /// Loại bỏ các phần tử trong Queue
        /// </summary>
        public void Clear()
        {
            _currentIndex = 0;
            _queue = null;
        }

        IEnumerable IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public IEnumerator GetEnumerator()
        {
            return new QueueEnumerator(_queue);
        }
    }
}
