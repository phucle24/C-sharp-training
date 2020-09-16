using System;

namespace Collection
{
    public class Stack : ICollection
    {
        private object[] _stack = new object[5];
        private int _currentIndex = -1;
        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
            set { }
        }
        public void Push(object item)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if (_currentIndex >= _stack.Length)
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
            if (_currentIndex < -1) return null;
            return _stack[_currentIndex];
        }
        public object Pop()
        {
            object topStack = Peek();
            if (_currentIndex >= 0)
            {
                _stack[_currentIndex] = null;      
            }
            _currentIndex--;
            return topStack;
        }

        public IEnumerator GetEnumerator()
        {
            return new StackEnumerator(_stack);
        }

        IEnumerable IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
