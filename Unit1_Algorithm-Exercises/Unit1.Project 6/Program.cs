using System;

namespace Unit1.Project6
{
    public class Program
    {
        static void Main(string[] args)
        {
            float x, y, a, b, c;
            Console.Write("Nhap gia tri x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri y: ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri c: ");
            c = float.Parse(Console.ReadLine());
            Console.Write("khoang cach tu M den duong thang: {0}", RangeToStraightLine(x, y, a, b, c));
            Console.ReadLine();
        }

        /// <summary>
        /// Tính khoảng cách từ điểm M đến đường thẳng
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float RangeToStraightLine(float x, float y, float a, float b, float c)
        {
            float range = 0;
            range = (float)(Math.Abs(a * x + b * y + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            return range;
        }

    }
}
