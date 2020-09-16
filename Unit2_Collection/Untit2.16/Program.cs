using System;
using Unit2.Project16;

namespace Untit2.Project16
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service1 = new Service(Counter.Instance());
            Service service2 = new Service(Counter.Instance());
            for (int i = 0; i < 10; i++)
            {
                service1.Alert();
                if (i % 2 == 0) service2.Alert();
            }
            Counter counter = Counter.Instance();
            Console.WriteLine(counter.Current);
            Console.ReadLine();
        }
    }
}
