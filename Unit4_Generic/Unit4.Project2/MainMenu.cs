using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public class MainMenu : IMainMenu
    {
        public event UpdateTitleHandler TitleChanged;
        public IEnumerable<IMenuChild> _menuChild;
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                if(TitleChanged != null) { TitleChanged(Title); }
            }
        }

        public IEnumerable<IMenuChild> MenuChild
        {

            get
            {
                // Toán tử ?? : nếu như vế 1 null thì thi hành vế 2
                return _menuChild ??= new List<IMenuChild>();
            }

        }
        public void Add(IMenuChild menuChild)
        {
            if (MenuChild is List<IMenuChild> children && children.Contains(menuChild) == false)
            {
                children.Add(menuChild);
            }
        }
    }
}
