﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int greenLights = int.Parse(Console.ReadLine());
            int freeWindows = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int carPassed = 0;

            while (input != "END")
            {
                if (input == "green")
                {
                    int greenLight = greenLights;
                    int freePass = freeWindows;
                    int counter = cars.Count;
                    for (int i = 0; i < counter; i++)
                    {
                        if (greenLight >= cars.Peek().Length && cars.Any())
                        {
                            greenLight -= cars.Dequeue().Length;
                            carPassed++;
                        }
                        else if (greenLight < cars.Peek().Length && cars.Any())
                        {
                            int timeLeft = greenLight + freePass;
                            if (greenLight <= 0)
                            {
                                continue;
                            }
                            else if (timeLeft > 0 && timeLeft >= cars.Peek().Length)
                            {
                                cars.Dequeue();
                                carPassed++;                 
                            }
                            else if (timeLeft > 0 && timeLeft < cars.Peek().Length)
                            {
                                string car = cars.Dequeue();

                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[timeLeft]}.");
                                return;
                            }
                        }
                    }

                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carPassed} total cars passed the crossroads.");

        }
    }
}