using System;

using DesignPatterns.Behavioral.ChainOfResponsability.Sample;
using DesignPatterns.Behavioral.Command.Sample;

using DesignPatterns.Creational.AbstractFactory.Sample;
using DesignPatterns.Creational.Builder.Sample;
using DesignPatterns.Creational.FactoryMethod.Sample;
using DesignPatterns.Creational.Prototype.Sample;
using DesignPatterns.Creational.Singleton.Sample;

using DesignPatterns.Structural.Proxy.Sample;
using DesignPatterns.Structural.Flyweight.Sample;
using DesignPatterns.Structural.Facade.Sample;

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

            //2- Chain of responsability
            // Setup Chain of Responsibility
            Approver rohit = new Clerk();
            Approver rahul = new AssistantManager();
            Approver manoj = new Manager();
            rohit.Successor = rahul;
            rahul.Successor = manoj;
            var loan = new Loan { Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan" };
            rohit.ProcessRequest(loan);
            loan = new Loan { Number = 2035, Amount = 42000.10, Purpose = "Bike Loan" };
            rohit.ProcessRequest(loan);
            loan = new Loan { Number = 2036, Amount = 156200.00, Purpose = "House Loan" };
            rohit.ProcessRequest(loan);
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
            DesignPatterns.Creational.AbstractFactory.Sample.VehiculeFactory honda = new HondaFactory();
            VehiculeClient hondaclient = new VehiculeClient(honda, "Regular");
            Console.WriteLine("****** Honda ******");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());
            VehiculeClient hondaclient2 = new VehiculeClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());
            DesignPatterns.Creational.AbstractFactory.Sample.VehiculeFactory hero = new HondaFactory();
            VehiculeClient heroclient = new VehiculeClient(hero, "Regular");
            Console.WriteLine("****** Hero ******");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());
            VehiculeClient heroclient2 = new VehiculeClient(hero, "Sports");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());
            Console.ReadKey();

            //4- Factory Method
            DesignPatterns.Creational.FactoryMethod.Sample.VehiculeFactory factory = new ConcreteVehiculeFactory();
            IFactory scooter = factory.GetVehicule("Scooter");
            scooter.Drive(10);
            IFactory bike = factory.GetVehicule("Bike");
            bike.Drive(20);
            Console.ReadKey();

            //5- Builder
            var vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
            Console.WriteLine("---------------------------------------------");
            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
            Console.ReadKey();

            //Structural
            //1 - Proxy
            ProxyClient proxy = new ProxyClient();
            Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
            Console.ReadKey();

            //2 - Flyweight
            ShapeObjectFactory sof = new ShapeObjectFactory();
            IShape shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            int NumObjs = sof.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);
            Console.ReadKey();

            //3 - Facade
            CarFacade facade = new CarFacade();
            facade.CreateCompleteCar();
            Console.ReadKey();
        }
    }
}
