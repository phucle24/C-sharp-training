using System;

namespace Unit2.Project12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection(new object[] { "Hello", 3, 6, 73, 2, });
            Console.WriteLine(collection[0]);
            Console.ReadLine();
        }
    }
}
