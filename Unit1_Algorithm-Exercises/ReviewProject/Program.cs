using System;

namespace ReviewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertLunarYear(2020));
        }
        public static string ConvertLunarYear(int year)
        {
            string[] strCan = { "Giap", "At", "Binh", "Dinh", "Mau", "Ky", "Canh", "Tan", "Nham", "Quy" };
            string[] strChi = { "Ty", "Su", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui", "Tha", "Dau", "Tuat", "hoi" };
            return strCan[year % 10] + " " + strChi[year % 12];
        }
    }
}
