using System;

namespace Unit1.Project7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeratorOne, numeratorTwo, denominatorOne, denominatorTwo;
            Console.WriteLine("Nhap vao phan so 1");
            Console.Write("Nhap vao tu so 1: ");
            numeratorOne = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mau so 1: ");
            do
            {
                denominatorOne = int.Parse(Console.ReadLine());
            }
            while (denominatorOne == 0);
            Console.WriteLine("Nhap vao phan so 2");
            Console.Write("Nhap vao tu so 2 : ");
            numeratorTwo = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mau so 2: ");
            do
            {
                denominatorTwo = int.Parse(Console.ReadLine());
            }
            while (denominatorTwo == 0);
            Console.WriteLine("Tich 2 phan so {0}: ", MultiFraction(numeratorOne, numeratorTwo, denominatorOne, denominatorTwo));
            Console.ReadLine();
        }

        /// <summary>
        /// Tích 2 phân số
        /// </summary>
        /// <param name="numeratorOne"></param>
        /// <param name="numeratorTwo"></param>
        /// <param name="denominatorOne"></param>
        /// <param name="denominatorTwo"></param>
        /// <returns></returns>
        public static string MultiFraction(int numeratorOne, int numeratorTwo, int denominatorOne, int denominatorTwo)
        {
            string result = "";
            int numeratorResult = numeratorOne * numeratorTwo;
            int denominatorResult = denominatorOne * denominatorTwo;
            int greatestFraction = GreatestCommonDivisor(numeratorResult, denominatorResult);
            result = (numeratorResult / greatestFraction + "/" + denominatorResult / greatestFraction);
            return result;
        }

        /// <summary>
        /// Tìm ước chung lớn nhất
        /// </summary>
        /// <param name="numeratorResult"></param>
        /// <param name="denominatorResult"></param>
        /// <returns></returns>
        public static int GreatestCommonDivisor(int numeratorResult, int denominatorResult)
        {
            numeratorResult = Math.Abs(numeratorResult);
            denominatorResult = Math.Abs(denominatorResult);
            while (numeratorResult != denominatorResult && denominatorResult != 0 && numeratorResult != 0) {
                if (numeratorResult > denominatorResult)
                {
                    numeratorResult = numeratorResult - denominatorResult;
                }
                else
                {
                    denominatorResult = denominatorResult - numeratorResult;
                }
            }
            return numeratorResult;
        }
    }
}
