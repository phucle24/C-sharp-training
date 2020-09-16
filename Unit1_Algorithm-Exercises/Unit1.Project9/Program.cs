using System;

namespace Unit1.Project9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vui long nhap so nguyen duong : ");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Giai thua bang: {0}", Factorial(number));
        }

        /// <summary>
        /// Tính giai thừa
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Factorial(int number)
        {
            int factorial = 1;
            if (number < 0)
            {
                return -1;
            }
            for (int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
