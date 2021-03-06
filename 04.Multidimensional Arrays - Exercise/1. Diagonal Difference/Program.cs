﻿using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mattrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    mattrix[i, j] = input[j];
                }
            }

            int primaryDiagonal = 0;
            int secondDiagonal = 0;
            for (int row = 0; row < n; row++)
            {

                for (int col = row; col <= row; col++)
                {

                    primaryDiagonal += mattrix[row, col];

                }
            }
            int count = n-1;

            for (int secRow = 0; secRow < n; secRow++)
            {
                for (int secCol = n-1-secRow; secCol >= count; secCol--)
                {

                    secondDiagonal += mattrix[secRow, secCol];
                }
                count--;
            }
            int totalSum = Math.Abs(primaryDiagonal - secondDiagonal);
            Console.WriteLine(totalSum);
        }
    }
}