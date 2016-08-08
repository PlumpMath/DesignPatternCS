using DesignPatterns.Behavioral.Sample;
using DesignPatterns.Creational.Sample;

using System;


namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Behavioral Patterns
            Console.WriteLine("Behavioral");
            Console.ReadKey();

            //1-Command
            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = Console.ReadLine();

            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);
            Switch s = new Switch();

            if(cmd == "ON")
                s.StoreAndExecute(switchUp);
            else if (cmd == "OFF")
                s.StoreAndExecute(switchDown);
            else
                Console.WriteLine("Command \"ON\" or \"OFF\" is required");
            Console.ReadKey();
        


            //Creational Patterns
            Console.WriteLine("Creational");
            Console.ReadKey();
            
            //1-Singleton
            Singleton.Instance.Show();
            Console.ReadKey();

            //2-Prototype
            Developper dev = new Developper { Name = "Antoine", Role = "Team Leader", PrefferedLanguage = "C#", WordsPerMinute = 42 };
            Typist typ = new Typist { Name = "Casper", Role = "Typist", WordsPerMinute = 175 };
            Console.WriteLine(typ.GetDetails());
            Console.WriteLine(dev.GetDetails());
            Console.ReadKey();

            //3-AbstractFactory
            VehiculeFactory honda = new HondaFactory();
            VehiculeClient hondaclient = new VehiculeClient(honda, "Regular");

            Console.WriteLine("****** Honda ******");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            VehiculeClient hondaclient2 = new VehiculeClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            VehiculeFactory hero = new HondaFactory();
            VehiculeClient heroclient = new VehiculeClient(hero, "Regular");

            Console.WriteLine("****** Honda ******");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            VehiculeClient heroclient2 = new VehiculeClient(hero, "Sports");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            Console.ReadKey();
        }
    }
}
