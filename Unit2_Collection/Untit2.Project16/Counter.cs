using System;
using System.Collections.Generic;
using System.Text;

namespace Untit2.Project16
{
    public class Counter
    {
        public int _count;
        private static Counter _counter;

        public int Current
        {
            get { return _count; }
            set { _count = value; }
        }

        public static Counter Instance()
        {
            if (_counter == null)
            {
                _counter = new Counter();
            }
            return _counter;
        }
    }
}
