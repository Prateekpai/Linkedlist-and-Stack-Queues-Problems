﻿using System;
using System.Collections.Generic;
namespace QuesueDemoProblem
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue (56) ;
            queue.Enqueue (30);
            queue.Enqueue (70);

                foreach(int element in queue)
                {
                    Console.WriteLine(element);
                }

                Console.WriteLine("..............");
        }
    }
}
