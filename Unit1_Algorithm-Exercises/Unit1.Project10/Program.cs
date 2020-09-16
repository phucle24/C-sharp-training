using System;

namespace Unit1.Project10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Vui long nhap nam : ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nam {0} co {1} ngay thu 6 ngay 13", year, CountFriday13th(year));
            Console.ReadLine();
        }

        /// <summary>
        /// Kiểm tra có phải ngày thứ 6 của tuần đấy không
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static bool CheckFriday(DateTime day)
        {
            return day.DayOfWeek == DayOfWeek.Friday;
        }

        /// <summary>
        /// Đếm số ngày thứ 6 ngày 13 trong năm
        /// </summary>
        /// <param name="year"></param>
        /// <returns>
        /// Trả về -1 nếu năm nhập vào nhỏ hơn hoặc bằng 0
        /// </returns>
        public static int CountFriday13th(int year)
        {
            if (year <= 0) return -1;
            int count = 0;
            for (int i = 1; i <= 12; i++)
            {
                DateTime day = new DateTime(year, i, 13);
                if (CheckFriday(day))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
