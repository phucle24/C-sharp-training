using System;

namespace Unit1.Project8
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 3, 3, 5, 6 };
            Console.Write("Trung binh cong cua mang da cho: {0}", Average(numbers));
            Console.ReadLine();
        }

        /// <summary>
        /// Tính trung bình cộng số đã cho trong mảng
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Average(int[] numbers)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                count++;
            }
            return (sum / count);
        }
    }
}
