using System;
namespace VeggieLand
{
    class Game
    {

        public static void Run()
        {
            string input;

            Console.Title = "VeggieLand";
            Console.WriteLine("Welcome to your VeggieLand stay!");

            Location Forest = new Location("Celery Stick Forest", 50, 0,"A dismal forest full of negative calories, gets slightly better with peanutbutter.");
            Location Palace = new Location("Potato Palace", 5, 50, "Only our very best veggies get to stay here. Keep growing towards perfection to earn your way in here.");
            Location Swamp = new Location("Spinach Swamp", 100, 2, "We believe that Dreamworks got their inspiration for \"Shrek\" here.");

            Console.WriteLine("You can choose any of these three places to explore! Type forest, palace, or swamp:");
            input = Console.ReadLine();
            input = input.ToLower();

            if (input == "forest")
            {
                Forest.About();
            }
            else if (input == "palace")
            {
                Palace.About();
            }
            else
            {
                Swamp.About();
            }


            Console.ReadKey();

        }
    }
}
