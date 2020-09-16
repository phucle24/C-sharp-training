using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit4.Project2
{
    class MenuManager
    {

        private IMainMenu _menu;
        public MenuManager(IMainMenu menu)
        {
            _menu = menu;
        }

        public void PrintMenu(IEnumerable<IMenuChild> children)
        {
            int count = children.Count();
            for (int i = 0; i < count; i++)
            {
                // ElementAt(i) : lấy ra menu option tại vị trí i
                Console.WriteLine($"{i + 1}.  {children.ElementAt(i).OptionMenu}");
            }
        }
        public void ShowHomeMenu()
        {
            Console.WriteLine("Ten menu cua ban la: {0}",_menu.Title);
            PrintMenu(_menu.MenuChild);
        }
        public void Run()
        {
            Console.WriteLine("Nhap lua chon menu");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    TestAsync.RunAsync();
                    break;
                case 2:
                    ExceptionHandler.Run();
                    break;
                case 3:
                    Event_Delegate.Run();
                    break;
                case 4:
                    EnumExample.GetDay();
                    break;
                case 5:
                    Generic.Run();
                    break;
            }
        }
    }
}
