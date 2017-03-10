using System;

namespace VeggieLand
{
    class Location
    {
        string Name;
        double Size;
        int Population;
        string Description;
        string[] items = { " ", " ", " " };
        Person thePerson;
       
        /*cleaner way to create constructer*/
        public Location()
        {

        }

        public Location(string name, double size, int population,string description)
        {
            Name = name;
            Size = size;
            Population = population;
            Description = description;

            if (name == "Celery Stick Forest")
            {
                items[0] = "Celery";
                items[1] = "Peanutbutter";
                items[2] = "Raisins";

                if (population > 0)
                {
                    thePerson = new Person("Jolly Green Giant", 367, "giant", true);
                    thePerson.About();
                }
            }
            else if (name == "Potato Palace")
            {
                items[0] = "Potatoes";
                items[1] = "Butter";
                items[2] = "Sour Cream";

                if (population > 0)
                {
                    thePerson = new Person("Mr. Potato Head", 39, "astral potato ghost", false);
                }
            }
            else
            {
                items[0] = "Crackers";
                items[1] = "Forks";
                items[2] = "Napkins";

                if (population > 0)
                {
                    thePerson = new Person("Shrek", 26, "ogre", true);
                }
            }

        }

        public void About()
        {
            Console.WriteLine(Name + " is a " + Size + " acre feature of veggie land, population " + Population + ".");
            Console.WriteLine(Description);
            Console.WriteLine("If you are lucky, you might be able to find the following here: ");
            for(int i=0; i<items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
