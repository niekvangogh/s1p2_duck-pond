using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanNiekvanGogh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STORY TIME!");
            Console.WriteLine("Welcome to the pond, in this pond there are 6 ducks and 10 frogs, please be nice to them, they won't hurt you.");
            Console.WriteLine("(press enter to continue)");
            Console.ReadLine();
            Console.WriteLine("As I said, please don't hurt the inhabitants of the pond, they won't hurt you.");
            Console.WriteLine("Except the stork, they like to kill the frogs in the pond. It's called natural selection.");
            Console.WriteLine("(press enter to continue)");
            Console.ReadLine();


            var pond = new Pond();
            Console.WriteLine("The pond has been created, the inhabitants are:");
            foreach (Animal animal in pond.Inhabitants)
            {
                Console.WriteLine("- " + animal.ToString());
            }
            Console.WriteLine("(press enter to continue)");

            Stork stork = (Stork) pond.Inhabitants.Find(inhabitant => inhabitant.GetType() == typeof(Stork));
            Console.WriteLine("As you can see, " + stork.ToString() + " is the evil one here, he will eat the frogs sadly.");

            Console.WriteLine("Every night " + stork.ToString() + " will eat one frog, until there are none left!");
            Console.WriteLine("(press enter to continue to the first night)");
            Console.ReadLine();


            var night = 0;
            Random random = new Random();
            while (pond.Inhabitants.FindAll(inhabitant => inhabitant.GetType() == typeof(Frog)).Count != 0)
            {
                var frogs = pond.Inhabitants.FindAll(inhabitant => inhabitant.GetType() == typeof(Frog)).Cast<Frog>().ToList(); ;
                night++;
                Console.WriteLine("Night: #" + night);
                var killed = frogs[random.Next(frogs.Count)];
                Console.WriteLine(killed.ToString() + " has been killed in the night!");
                stork.EatFrog(killed);

                Console.WriteLine("(press enter to continue)");
                Console.ReadLine();

            }

            Console.WriteLine("The end! " + stork + " has killed all the frogs");
            Console.ReadLine();
        }
    }
}
