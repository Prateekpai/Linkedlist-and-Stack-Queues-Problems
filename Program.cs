using System;
using System.Collections.Generic;
namespace StackDemoProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("..............");

            foreach (int element in stack)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine("...............");

        }
    }
}
