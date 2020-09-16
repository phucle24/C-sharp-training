using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit4.Project3
{
    public class List<T>
    {
        private T[] _list = new T[10];
        private int _currentIndex = -1;

        public int Count
        {
            get
            {
                return _currentIndex + 1;
            }
        }

        // IList Memembers
        /// <summary>
        /// Thêm phần tử vào
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if (_currentIndex >= _list.Length)
            {
                T[] _temp = new T[2 * _list.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _list[i];
                }
                _list = _temp;
                _list[_currentIndex] = item;
            }
            _list[_currentIndex] = item;
        }

        /// <summary>
        /// Trả chỉ số count về 0
        /// </summary>
        public void Clear()
        {
            _currentIndex = -1;
        }

        /// <summary>
        /// Kiểm tra phần tử có tồn tại hay không
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            for (int i = _currentIndex; i > 0; i--)
            {
                if (_list[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Trả về phần tử xuất hiện đầu tiên trong danh sách
        /// </summary>
        /// <param name="item"></param>
        /// <returns>
        /// Không tìm thấy phần tử trả về -1
        /// </returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i <= _currentIndex; i++)
            {
                if (_list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Chèn vào phần tử với chỉ số index đưa vào
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, T item)
        {
            if ((_currentIndex > _list.Length) && (index < 0))
            {
                return;
            }
            else
            {
                _currentIndex++;
                for (int i = _currentIndex; i > index; i--)
                {
                    _list[i] = _list[i - 1];
                }
                _list[index] = item;
            }
        }

        /// <summary>
        /// Xóa phần tử có trong mảng
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            for (int i = _currentIndex; i > 0; i--)
            {
                if (_list[i].Equals(item))
                {
                    _list[i] = default(T);
                }
                _currentIndex--;
            }
        }

        /// <summary>
        /// Xóa phần tử với chỉ số cho trước
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index <= _currentIndex))
            {
                for (int i = index; i < _currentIndex; i++)
                {
                    _list[i] = _list[i + 1];
                }
                _currentIndex--;
            }
            else
            {
                return ;
            }
        }


        /// <summary>
        /// Trả về phần tử xuất hiện cuối cùng trong danh sách
        /// </summary>
        /// <returns>
        /// Nếu không có phần tử trả về  - 1
        /// </returns>
        public int LastIndexOf(T item)
        {
            for (int i = _currentIndex; i >= 0; i--)
            {
                if (_list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
