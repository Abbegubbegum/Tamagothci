using System;
using System.Collections.Generic;

namespace Tamagothci
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;

        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random r = new();
        public string name;

        public void Feed()
        {
            hunger--;
        }

        public void Hi()
        {
            Console.WriteLine(words[r.Next(words.Count)]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();

        }

        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {

            if (isAlive == true)
            {
                Console.WriteLine($"Your Pet {name} has {hunger} Hunger and {boredom} Boredom!");
            }
            else
            {
                Console.WriteLine($"Your Pet {name} is DEAD");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom--;
        }
    }
}