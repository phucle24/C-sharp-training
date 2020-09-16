using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public class Generic
    {
        public static void Swap<T>(ref T firstItem, ref T secondItem)
        {
            T temp;
            temp = firstItem;
            firstItem = secondItem;
            secondItem = temp;
        }
        public static void Run()
        {
            Console.WriteLine("Xin moi ban nhap gia tri Item 1:");
            int item1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi ban nhap gia tri Item 2:");
            int item2 = int.Parse(Console.ReadLine());
            Swap<int>(ref item1, ref item2);
            Console.WriteLine("Gia tri sau khi hoan vi: Iteam 1: {0} - Iteam 2: {1}", item1, item2);
        }
    }
}
