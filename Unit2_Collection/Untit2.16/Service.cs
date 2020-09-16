using System;
using System.Collections.Generic;
using System.Text;

namespace Unit2.Project16
{
    public class Service
    {
        private Counter counter;
        public Service(Counter counter)
        {
            this.counter = counter;
        }

        /// <summary>
        /// Đếm khi phương phức Alert() được gọi
        /// </summary>
        public void Alert()
        {
            counter.Current += 1;
        }
    }
}
