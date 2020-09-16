
using System;

namespace Unit2.Project14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(2, 3), f2 = new Fraction(6, 7);
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.ReadLine();
            Fraction f3 = new Fraction(2, 1);
        }
    }
}
