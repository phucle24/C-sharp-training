using Collection;
using System;
using System.ComponentModel;

namespace Unit3.Project2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List list = new List(new object[8]);
            list.Add(10);
            list.Add(2);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Co ton tai phan tu trong List ha khong : {0}", list.Contains(5));
            Console.WriteLine("----------------------");
            Console.WriteLine("Tra ve vi tri : {0}", list.IndexOf(1));
            Console.WriteLine("----------------------");
            list.Insert(1, 100);
            Console.WriteLine("Danh sach sau khi them phan tu");
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Tra ve vi tri : {0}", list.IndexOf(1));
            Console.WriteLine("----------------------");
            list.Remove(2);
            Console.WriteLine("Danh sach sau khi xoa phan tu");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Vi tri xuat hien cuoi cung cua phan tu: {0}", list.LastIndexOf(1));
            Console.WriteLine("----------------------");
            list.RemoveAt(1);
            Console.WriteLine("Danh sach sau khi xoa phan tu");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------Stack----------");
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            foreach (var itm in myStack)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Xuat ra phan tu dau tien cua Stack: {0}", myStack.Peek());
            Console.WriteLine("Xoa phan tu dau tien cua Stack: {0}", myStack.Pop());
            Console.WriteLine("----------------------");
            foreach (var itm in myStack)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine("Xuat ra phan tu dau tien cua Stack: {0}", myStack.Peek());
            Console.WriteLine("Tong so phan tu con lai trong Stack: {0}", myStack.Count);
            Console.WriteLine("--------Queue--------");
            Queue myQueue = new Queue();
            myQueue.Enqueue("Hi");
            myQueue.Enqueue(100);
            myQueue.Enqueue(200);
            myQueue.Enqueue(300);
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            Console.WriteLine("Xuat ra phan tu dau tien cua Queue: {0} ", myQueue.Peek());
            Console.WriteLine("----------");
            Console.WriteLine("Xoa phan tu dau tien cua Queue: {0} ", myQueue.Dequeue());
            Console.WriteLine("----------");
            Console.WriteLine("Danh sach sau khi xoa phan tu dau tien:");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
