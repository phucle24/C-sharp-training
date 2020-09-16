using System;
using System.Collections.Generic;
using System.Text;

namespace Unit2.Project16
{
    public class Counter
    {
        public int count;
        private static Counter counter;

        public int Current
        {
            get { return count; }
            set { count = value; }
        }

        public static Counter Instance()
        {
            if (counter == null)
            {
                counter = new Counter();
            }
            return counter;
        }
    }
}
