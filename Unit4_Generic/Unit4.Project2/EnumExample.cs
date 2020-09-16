using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public class EnumExample
    {
        public enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        public static void GetDay()
        {
            Console.WriteLine("In cac ngay trong tuan");
            Console.WriteLine("Moi ban nhap tu 0 - 6");
            int chosse = int.Parse(Console.ReadLine());

            switch (chosse)
            {
                case (int)WeekDay.Monday:
                    Console.WriteLine("Hom nay la thu Hai");
                    break;
                case (int)WeekDay.Tuesday:
                    Console.WriteLine("Hom nay la thu Ba");
                    break;
                case (int)WeekDay.Wednesday:
                    Console.WriteLine("Hom nay la thu Tu");
                    break;
                case (int)WeekDay.Thursday:
                    Console.WriteLine("Hom nay la thu Nam");
                    break;
                case (int)WeekDay.Friday:
                    Console.WriteLine("Hom nay la thu Ba");
                    break;
                case (int)WeekDay.Saturday:
                    Console.WriteLine("Hom nay la thu Bay");
                    break;
                case (int)WeekDay.Sunday:
                    Console.WriteLine("Hom nay la chu nhat");
                    break;
                default:
                    break;
            }
        }
    }
}
