using System;
namespace Unit4.Project2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMainMenu menu = new MainMenu();
            menu.Title = "Menu C#"; // Ban dau minh gan Title: "Menu C#"
            menu.TitleChanged += (title) => { };  // lambda expression -> Đang ki su kien TitleChanged
            Console.WriteLine("Xin moi ban nhap ten menu cua ban: ");
            menu.Title = Console.ReadLine();
            IMenuChild menu1 = new MenuChild("TestAsync");
            IMenuChild menu2 = new MenuChild("Exception");
            IMenuChild menu3 = new MenuChild("Event_Delegate");
            IMenuChild menu4 = new MenuChild("Enum");
            IMenuChild menu5 = new MenuChild("Generic");
            menu.Add(menu1);
            menu.Add(menu2);
            menu.Add(menu3);
            menu.Add(menu4);
            menu.Add(menu5);
            MenuManager menuManager = new MenuManager(menu);
            menuManager.ShowHomeMenu();
            menuManager.Run();
            Generic.Run();
            Console.ReadLine();
        }
    }
}
