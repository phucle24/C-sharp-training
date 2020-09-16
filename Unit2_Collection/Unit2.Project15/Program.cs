using System;

namespace Unit2.Project15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(4, 2), f2 = new Fraction(1, 2);
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.ReadLine();
        }
    }
}
