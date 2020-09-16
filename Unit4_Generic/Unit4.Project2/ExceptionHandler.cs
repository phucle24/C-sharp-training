using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public class ExceptionHandler
    {
        public static void Run()
        {
            Console.WriteLine("Xin vui long nhap so tuoi cua ban:  ");
            string yearOldIn = Console.ReadLine();
            try
            {
                int yearOldOut = Convert.ToInt32(yearOldIn);
                if (yearOldOut <= 0)
                {
                    Console.WriteLine("Khong duoc nhap so nho hon 0");
                }
                else
                {
                    Console.WriteLine("So tuoi cua ban : {0}", yearOldOut);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Dinh dang tuoi khong hop le");
            }
            catch (OverflowException)
            {
                Console.WriteLine("So tuoi vuot qua muc cho phep");
            }
        }
    }
}
