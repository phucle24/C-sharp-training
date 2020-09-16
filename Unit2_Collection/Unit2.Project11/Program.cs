using System;
namespace Unit2.Project11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection(new object[] { "Hello", 3, 6, 73, 2, });
            do
            {
                Console.WriteLine(collection.Current);
            } while (collection.Next());
            Console.ReadLine();
        }
    }
}
