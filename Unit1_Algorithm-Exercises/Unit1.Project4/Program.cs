using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Unit1.Project4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vui long nhap vao chuoi : ");
            string str = Console.ReadLine().ToLower();
            Console.WriteLine("Cac so nguyen am trong chuoi la: {0}", CountVowel(str));
            Console.WriteLine("Cac so phu am trong chuoi la: {0}", CountConsonant(str));
        }

        /// <summary>
        /// Đếm số nguyên âm
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountVowel(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Đếm số phụ âm
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountConsonant(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u')
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}
