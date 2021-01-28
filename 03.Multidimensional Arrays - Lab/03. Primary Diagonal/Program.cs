﻿using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int[,] mattrix = new int[N, N];

            for (int row = 0; row < N; row++)
            {

                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < N; col++)
                {

                    mattrix[row, col] = numbers[col];

                }
            }

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    if(j==i)
                    {
                        sum += mattrix[i,j];
                    }

                }
            }
            Console.WriteLine(sum);


        }
    }
}
