﻿using System;
using System.Linq;

namespace _05.Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 2;
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];
            int[,] mattrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    mattrix[i, j] = input[j];
                }

            }


            int isBigRow = 0;
            int isBigCol = 0;
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    if (col + 1 >= cols || row + 1 >= rows)
                    {
                        break;
                    }

                    int one = mattrix[row, col];
                    int two = mattrix[row, col + 1];
                    int three = mattrix[row + 1, col];
                    int four = mattrix[row + 1, col + 1];
                    int currentSum = one + two + three + four;

                    if (sum < currentSum)
                    {
                        isBigRow = row;
                        isBigCol = col;
                        sum = currentSum;
                    }
                }
            }

            for (int i = isBigRow; i < isBigRow + N; i++)
            {

                for (int j = isBigCol; j < isBigCol + N; j++)
                {
                    Console.Write(mattrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}