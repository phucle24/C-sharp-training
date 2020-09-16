using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project3
{
    public class Stack<T> where T : class
    {
        private T[] _stack = new T[5];
        private int _currentIndex = -1;
        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
        }
        public void Push(T value)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if (_currentIndex >= _stack.Length)
            {
                T[] _temp = new T[2 * _stack.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _stack[i];
                }
                _stack = _temp;
                _stack[_currentIndex] = value;
            }
            _stack[_currentIndex] = value;
        }

        public T Peek()
        {
            if (_currentIndex < 0) return null; // vì ở trên tham chiếu với ràng buộc lớp T, nên mới có thể trả về null
            T top = _stack[_currentIndex];
              return top;
        }
        public T Pop()
        {
            T topStack = Peek();
            if (_currentIndex > -1)
            {
                _currentIndex--;
            }
            return topStack;
        }
    }
}
