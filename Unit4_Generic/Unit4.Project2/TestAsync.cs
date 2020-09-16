using System;
using System.Threading.Tasks;

namespace Unit4.Project2
{
    public class TestAsync
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Khoi chay Method 1");
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" Khoi chay Method 2");
            }
        }
        public static void RunAsync()
        {
            Console.WriteLine("Khoi chay bat dong bo");
               Method1();
               Method2();
        }
    }
}
