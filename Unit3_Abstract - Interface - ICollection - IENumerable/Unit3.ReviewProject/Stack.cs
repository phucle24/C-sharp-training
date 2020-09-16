using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3.ReviewProject
{
    public class Stack
    {
        public object[] _stack = new object[2];
        public int _currentIndex = -1;
        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
        }
        public void Push(object item)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if(_currentIndex >= _stack.Length)
            {
                object[] _temp = new object[2 * _stack.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _stack[i];
                }
                _stack = _temp;
                _stack[_currentIndex] = item;
            }
            _stack[_currentIndex] = item;
           
        }
        public object Peek()
        {
            if (_currentIndex < 0) return null;
            return _stack[_currentIndex];
        }
        public object Pop()
        {
            if(_currentIndex >=0)
            {
                for (int i = 0; i < _currentIndex; i++)
                {
                    _stack[i] = _stack[i + 1];
                }
                _currentIndex--;
            }
            object topStack = Peek();
            return topStack;
        }
    }
}
