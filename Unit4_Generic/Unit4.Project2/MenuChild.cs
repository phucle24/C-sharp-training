using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public class MenuChild : IMenuChild
    {
        public List<IMenuChild> _menuChildren = new List<IMenuChild>();

        public string OptionMenu { get; set; }
        public IEnumerable<IMenuChild> MenuChildren
        {
            get
            {
                return _menuChildren;
            }
        }
        public MenuChild() { }
        public MenuChild(string optionMenu)
        {
            OptionMenu = optionMenu;
        }
 
    }
}
