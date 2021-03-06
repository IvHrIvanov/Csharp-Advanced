﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuanity = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine().Split(" ")
                                            .Select(int.Parse)
                                            .ToArray();

            Queue<int> queue = new Queue<int>(order);

            Console.WriteLine(queue.Max());

            int sumOrder = 0;
            bool flag = true;

            while (queue.Count > 0)
            {
                int current  = queue.Dequeue();
                sumOrder += current;

                if (sumOrder > foodQuanity)
                {
                    Console.WriteLine($"Orders left: {current} {string.Join(" ", queue)}");
                    flag = false;
                    break;
                }

            }
            if (flag)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}