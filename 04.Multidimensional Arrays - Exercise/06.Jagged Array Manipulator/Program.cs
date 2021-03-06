﻿using System;
using System.Linq;
using System.Numerics;

namespace _06.Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggetMatrix = new double[n][];

            for (int i = 0; i < n; i++)
            {

                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggetMatrix[i] = new double[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jaggetMatrix[i][j] = input[j];
                }

            }

            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArray = jaggetMatrix[row];
                double[] secondArray = jaggetMatrix[row + 1];

                if (firstArray.Length == secondArray.Length)
                {
                    jaggetMatrix[row] = firstArray.Select(e => e * 2).ToArray();
                    jaggetMatrix[row + 1] = secondArray.Select(e => e * 2).ToArray();
                }
                else
                {
                    jaggetMatrix[row] = firstArray.Select(e => e / 2).ToArray();
                    jaggetMatrix[row + 1] = secondArray.Select(e => e / 2).ToArray();
                }
            }

            string[] command = Console.ReadLine().Split(" ");
            while (command[0] != "End")
            {
                string curComand = command[0];
                int currRow = int.Parse(command[1]);
                int currCol = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (curComand == "Add" && currRow < n && currRow >= 0)
                {
                    if (currCol < jaggetMatrix[currRow].Length && currCol >= 0)
                    {
                        jaggetMatrix[currRow][currCol] += value;
                    }
                }
                else if (curComand == "Subtract" && currRow < n && currRow >= 0)
                {

                    if (currCol < jaggetMatrix[currRow].Length && currCol >= 0)
                    {
                        jaggetMatrix[currRow][currCol] -= value;
                    }

                }

                command = Console.ReadLine().Split(" ");
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jaggetMatrix[row].Length; col++)
                {
                    Console.Write(jaggetMatrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}