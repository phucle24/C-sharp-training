using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public interface IMenuChild
    {
        public string OptionMenu { get; set; }
        IEnumerable<IMenuChild> MenuChildren { get; }
    }
}
