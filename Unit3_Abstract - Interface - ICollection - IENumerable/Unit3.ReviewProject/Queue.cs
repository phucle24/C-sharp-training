using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3.ReviewProject
{
    public class Queue
    {
        public object[] _queue = new object[10];
        public int _currentIndex = -1;
        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
        }
        public void Enqueue(object item)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if (_currentIndex >= _queue.Length)
            {
                object[] _temp = new object[2 * _queue.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _queue[i];
                }
                _temp = _queue;
                _queue[_currentIndex] = item;
            }
            _queue[_currentIndex] = item;
        }
        public object Peek()
        {
            return _queue[0];
        }
        public object Dequeue()
        {
            if(_currentIndex > 0)
            {
                for (int i = 0; i < _currentIndex; i++)
                {
                    _queue[i] = _queue[i + 1];
                }
                _currentIndex--;
            }
            object lastQueue = Peek();
            return lastQueue;
        }
    }
}
