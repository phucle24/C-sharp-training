using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public delegate void UpdateTitleHandler(string title);
    public interface IMainMenu
    {
        public event UpdateTitleHandler TitleChanged;
        public string Title { get; set; }
        IEnumerable<IMenuChild> MenuChild { get; }
        public void Add(IMenuChild menuChild);
    }
}
