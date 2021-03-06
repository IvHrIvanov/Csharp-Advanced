﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(input);

            string[] command = Console.ReadLine().ToLower().Split(" ");

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    numbers.Push(int.Parse(command[1]));
                    numbers.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    int count = int.Parse(command[1]);
                    if (count <= numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }


                command = Console.ReadLine().ToLower().Split(" ");

            }
            int sum = 0;
            int countStack = numbers.Count;
            for (int i = 0; i < countStack; i++)
            {
                sum += numbers.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
