using System;
using System.Globalization;

namespace Unit1.Project3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Vui long nhap nam: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Am lich la nam : {0}", ConvertLunaYear(year));
        }

        /// <summary>
        /// Chuyển năm dương lịch sang năm âm lịch
        /// </summary>
        /// <param name="year"></param>
        /// <returns>
        /// Trả về đoạn thông báo nếu năm nhập vào là số âm
        /// </returns>
        public static string ConvertLunaYear(int year)
        {
            if (year <= 0)
            {
                return "Vui long nhap lai nam";
            }
            string[] strCan = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đính", "Mậu", "Kỉ" };
            string[] strChi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            return strCan[year % 10] + " " + strChi[year % 12];
        }
    }
}
