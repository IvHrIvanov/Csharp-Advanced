﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Stack<string> backUp = new Stack<string>();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];

                if (command == "1")
                {
                    builder.Append(input[1]);
                    backUp.Push(builder.ToString());
                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    builder.Remove(builder.Length - count, count);
                    backUp.Push(builder.ToString());
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    
                    Console.WriteLine(builder[index - 1]);
                }
                else if (command == "4")
                {
                    if (backUp.Count > 1)
                    {
                        backUp.Pop();
                        builder = new StringBuilder();
                        builder.Append(backUp.Peek());
                    }
                    else
                    {
                        backUp.Pop();
                        builder = new StringBuilder();
                    }
                }
            }
        }
    }
}