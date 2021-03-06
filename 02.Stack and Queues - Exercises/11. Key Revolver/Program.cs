﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {

            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBare = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());


            Queue<int> locks = new Queue<int>(locksInput);
            Stack<int> bulletShot = new Stack<int>(bullets);

            int magazine = sizeGunBare;
            int shootedBulled = 0;
            while (locks.Count > 0 && bulletShot.Count > 0)
            {

                int currBullet = bulletShot.Pop();
                shootedBulled++;
                magazine--;
                int currLock = locks.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (magazine == 0 && bulletShot.Count > 0)
                {
                    magazine = sizeGunBare;
                    Console.WriteLine("Reloading!");
                }
            }
            if (locks.Count == 0)
            {
                int moneyleft = intelligence - (priceBullet * shootedBulled);
                Console.WriteLine($"{bulletShot.Count} bullets left. Earned ${moneyleft}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}