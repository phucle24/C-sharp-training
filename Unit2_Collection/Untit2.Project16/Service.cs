using System;
using System.Collections.Generic;
using System.Text;

namespace Untit2.Project16
{
    public class Service
    {
        private Counter _counter;
        public Service(Counter counter)
        {
            this._counter = counter;
        }

        /// <summary>
        /// Đếm khi phương phức Alert() được gọi
        /// </summary>
        public void Alert()
        {
            this._counter.Current += 1;
        }
    }
}
