using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Collection
{
    public interface IList : ICollection
    {
        public void Add(object item);
        public void Remove(object item);
        public void Insert(int index, object item);
        public int IndexOf(object item);
        public int LastIndexOf(object item);
        public void Clear();
        public bool Contains(object item);
        public void RemoveAt(int index);
    }
}
