using System;

namespace Unit2.Project13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection(new object[,] {
                                                                    {"Xin Chao", 2, 6, 73, 2, },
                                                                    {"Hi", 4, 6, 73, 2, },
                                                                    {"Friend", 98, 6, 73, 2, },
                                                                 });
            Console.WriteLine(collection[2, 2]);
            Console.ReadLine();
        }
    }
}
