﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] cupCapacity = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> cup = new Queue<int>(cupCapacity);
            Stack<int> bottles = new Stack<int>(filledBottles);

            int wastedWater = 0;

            while (cup.Count > 0 && bottles.Count > 0)
            {
                int currCup = cup.Peek();

                while (currCup > 0)
                {
                    int currBottle = bottles.Pop();
                    currCup -= currBottle;

                    if (currCup == 0)
                    {
                        cup.Dequeue();
                    }
                    else if (currCup < 0)
                    {
                        cup.Dequeue();
                        wastedWater += Math.Abs(currCup);
                    }


                }

            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");

            }
            else if (cup.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cup)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}