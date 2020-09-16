using System;

namespace Unit4.Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Huong");
            myStack.Push("Viet");
            myStack.Push("Group");
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Peek());
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Pop());
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Peek());
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Pop());
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Pop());
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Pop());
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Console.WriteLine(" --------Queue-------");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Huong");
            myQueue.Enqueue("Viet");
            myQueue.Enqueue("Group");
            Console.WriteLine(" Phan tu dinh Queue: {0}", myQueue.Peek());
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Queue: {0}", myQueue.Dequeue());
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Queue: {0}", myQueue.Dequeue());
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Queue: {0}", myQueue.Dequeue());
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
            Console.WriteLine(" ----------------");
            Console.WriteLine(" Phan tu dinh Queue: {0}", myQueue.Dequeue());
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
            Console.WriteLine(" --------List-------");
            List<string> list = new List<string>();
            list.Add("Huong");
            list.Add("Viet");
            list.Add("Group");
            Console.WriteLine("Co ton tai phan tu hay khong: {0}", list.Contains("Viet"));
            Console.WriteLine("Vi tri xuat hien cuoi cung cua phan tu: {0}", list.LastIndexOf("Viet"));
            Console.WriteLine("Tra ve vi tri : {0}", list.IndexOf("Huong"));
            list.Insert(1, "Phuc");
            list.Remove("Huong");
            Console.WriteLine("Tra ve vi tri : {0}", list.IndexOf("Huong"));
            list.Remove("Viet");
            Console.WriteLine("Tra ve vi tri : {0}", list.IndexOf("Viet"));

        }
    }
}
