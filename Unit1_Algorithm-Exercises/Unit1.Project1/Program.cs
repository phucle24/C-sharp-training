using System;

namespace Unit1.Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 52, 16, 19, 20, 233, 228 };
            foreach (var number in numbers)
            {
                if (CheckEven(number))
                {
                    Console.WriteLine("Cac so chan trong mang: {0}", number);
                }
            }
            Console.WriteLine("So lon nhat trong mang : {0}", CheckMax(numbers));
            Console.WriteLine("So nho nhat trong mang: {0}", CheckMin(numbers));
            Console.ReadLine();
        }

        /// <summary>
        /// Kiểm tra số chẳn
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckEven(int number)
        {
            return (number % 2 == 0);
        }

        /// <summary>
        /// Kiểm tra số lớn nhất
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int CheckMax(int[] numbers)
        {
            int max = numbers[0];
            int count = 0;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                    count++;
                }
            }
            return max;
        }

        /// <summary>
        /// Kiểm tra số nhỏ nhất
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int CheckMin(int[] numbers)
        {
            int min = numbers[0];
            int count = 0;
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                    count++;
                }
            }
            return min;
        }
    }
}
