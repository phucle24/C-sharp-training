using System;

namespace Collection
{
    class List : IList
    {
        private object[] _list = new object[10];
        private int _currentIndex = -1;

        public List(object[] list)
        {
            _list = list;
        }

        /// <summary>
        /// ICollection member
        /// </summary>
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
        public void Add(object item)
        {
            if (_currentIndex < -1) return;
            _currentIndex++;
            if (_currentIndex >= _list.Length)
            {
                object[] _temp = new object[2 * _list.Length];
                for (int i = 0; i < _currentIndex; i++)
                {
                    _temp[i] = _list[i + 1];
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
        public bool Contains(object item)
        {
            for (int i = 0; i <= _currentIndex; i++)
            {
                if (_list[_currentIndex].Equals(item))
                {
                    return true;
                }
                _currentIndex++;
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
        public int IndexOf(object item)
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
        public void Insert(int index, object item)
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
                    _list[i] = _list[i-1];
                }
                _list[index] = item;
            }
        }

        /// <summary>
        /// Xóa phần tử có trong mảng
        /// </summary>
        /// <param name="item"></param>
        public void Remove(object item)
        {
            RemoveAt(IndexOf(item));
        }

        /// <summary>
        /// Xóa phần tử với chỉ số cho trước
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < _currentIndex))
            {
                for (int i = index; i < _currentIndex; i++)
                {
                    _list[i] = _list[i + 1];
                }
                _list[_currentIndex] = null;
                _currentIndex--;
            }
            else
            {
                return;
            }
        }
        public object this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        /// <summary>
        /// Trả về phần tử xuất hiện cuối cùng trong danh sách
        /// </summary>
        /// <returns></returns>
        public int LastIndexOf(object item)
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

        public IEnumerator GetEnumerator()
        {
            return new ListEnumerator(_list);
        }

        IEnumerable IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
