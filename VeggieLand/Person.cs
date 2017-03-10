using System;

namespace VeggieLand
{
    class Person
    {
        string Name;
        double Age;
        string Species;
        bool Alive;

        public Person(string name, double age, string species, bool alive)
        {
            Name = name;
            Age = age;
            Species = species;
            Alive = alive;
        }

        public void About()
        {
            Console.WriteLine("This is " + Name + ". They are " + Age + " years old and is a(n) " + Species + " who is " + Alive + "alive.");
        }

        public void Sleep()
        {
            if (Alive)
            {
                Console.WriteLine(Name + " falls asleep");
            }
            else
            {
                Console.WriteLine(Name + " can't sleep because they aren't alive :(");
            }
        }

        public void Vegetate()
        {

        }

        public void Sow()
        {
           
        }

        public void Talk()
        {
            if (Alive)
            {
                Console.WriteLine(Name + " says something interesting to you!");
            }
            else
            {
                Console.WriteLine(Name + " says something interesting to you but in a ghostly voice!");
            }
        }
    }
}
