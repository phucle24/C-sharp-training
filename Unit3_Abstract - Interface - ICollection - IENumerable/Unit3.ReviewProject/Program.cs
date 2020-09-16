using System;

namespace Unit3.ReviewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Peek());
            myStack.Pop();
            myStack.Pop();
            Console.WriteLine(" Phan tu dinh Stack: {0}", myStack.Peek());
            myStack.Pop();
            myStack.Pop();
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack.Count);
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
            Console.WriteLine(" Phan tu dinh Queue: {0}", myQueue.Peek());
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", myQueue.Count);
        }
    }
}
