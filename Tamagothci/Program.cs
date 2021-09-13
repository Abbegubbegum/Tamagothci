using System;
using System.Collections.Generic;

namespace Tamagothci
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi pet = new Tamagotchi();


            string playerInput;

            Console.WriteLine("What is the pets name?");

            pet.name = Console.ReadLine();

            while (pet.GetAlive())
            {
                Console.WriteLine($"What do you want to do with {pet.name}?4");
                Console.WriteLine("1-Feed, 2-Greet, 3-Teach, 4-stats");
                playerInput = Console.ReadLine();

                while (!PlayerChoice(playerInput, pet))
                {
                    Console.WriteLine("Invalid Input");
                    playerInput = Console.ReadLine();
                }

                pet.Tick();

            }
            Console.WriteLine("You Fail");
            Console.ReadLine();

        }

        static bool PlayerChoice(string input, Tamagotchi p)
        {
            switch (input)
            {
                case "1":
                    p.Feed();
                    return true;

                case "2":
                    p.Hi();
                    return true;

                case "3":
                    Console.WriteLine("What do you want to teach?");
                    p.Teach(Console.ReadLine());
                    return true;

                case "4":
                    p.PrintStats();
                    return true;

                default:
                    return false;
            }

        }
    }
}
