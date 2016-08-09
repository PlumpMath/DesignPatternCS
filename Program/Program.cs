using System;

using DesignPatterns.Behavioral.ChainOfResponsability.Sample;
using DesignPatterns.Behavioral.Command.Sample;
using DesignPatterns.Behavioral.Memento.Samples;

using DesignPatterns.Creational.AbstractFactory.Sample;
using DesignPatterns.Creational.Builder.Sample;
using DesignPatterns.Creational.FactoryMethod.Sample;
using DesignPatterns.Creational.Prototype.Sample;
using DesignPatterns.Creational.Singleton.Sample;

using DesignPatterns.Structural.Proxy.Sample;
using DesignPatterns.Structural.Flyweight.Sample;
using DesignPatterns.Structural.Facade.Sample;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Adapter.Sample;
using DesignPatterns.Structural.Decorator.Sample;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Behavioral Patterns
            Console.WriteLine("Behavioral");
            // Wait for user
            Console.ReadKey();

                //1 - Command
                Console.WriteLine("Command");
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
                    // Wait for user
                    Console.ReadKey();

                //2 - Chain of responsability
                Console.WriteLine("Chain of responsability");
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
                    // Wait for user
                    Console.ReadKey();

                //3 - Memento
                Console.WriteLine("Memento");
                    SalesProspect sp = new SalesProspect();
                    sp.Name = "Noel van Halen";
                    sp.Phone = "(412) 256-0990";
                    sp.Budget = 25000.0;
                    // Store internal state
                    ProspectMemory m = new ProspectMemory();
                    m.Memento = sp.SaveMemento();
                    // Continue changing originator
                    sp.Name = "Leo Welch";
                    sp.Phone = "(310) 209-7111";
                    sp.Budget = 1000000.0;
                    // Restore saved state
                    sp.RestoreMemento(m.Memento);
                    // Wait for user
                    Console.ReadKey();


            //Creational Patterns
            Console.WriteLine("Creational");
            // Wait for user
            Console.ReadKey();

                //1-Singleton
                Console.WriteLine("Singleton");
                    Singleton.Instance.Show();
                    // Wait for user
                    Console.ReadKey();

                //2-Prototype
                Console.WriteLine("Prototype");
                    Developper dev = new Developper { Name = "Antoine", Role = "Team Leader", PrefferedLanguage = "C#", WordsPerMinute = 42 };
                    Typist typ = new Typist { Name = "Casper", Role = "Typist", WordsPerMinute = 175 };
                    Console.WriteLine(typ.GetDetails());
                    Console.WriteLine(dev.GetDetails());
                    // Wait for user
                    Console.ReadKey();

                //3-AbstractFactory
                Console.WriteLine("Abstract Factory");
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
                    // Wait for user
                    Console.ReadKey();

                //4- Factory Method
                Console.WriteLine("Factory Method");
                    DesignPatterns.Creational.FactoryMethod.Sample.VehiculeFactory factory = new ConcreteVehiculeFactory();
                    IFactory scooter = factory.GetVehicule("Scooter");
                    scooter.Drive(10);
                    IFactory bike = factory.GetVehicule("Bike");
                    bike.Drive(20);
                    // Wait for user
                    Console.ReadKey();

                //5- Builder
                Console.WriteLine("Builder");
                    var vehicleCreator = new VehicleCreator(new HeroBuilder());
                    vehicleCreator.CreateVehicle();
                    var vehicle = vehicleCreator.GetVehicle();
                    vehicle.ShowInfo();
                    Console.WriteLine("---------------------------------------------");
                    vehicleCreator = new VehicleCreator(new HondaBuilder());
                    vehicleCreator.CreateVehicle();
                    vehicle = vehicleCreator.GetVehicle();
                    vehicle.ShowInfo();
                    // Wait for user
                    Console.ReadKey();

            //Structural
            Console.WriteLine("Structural");
            // Wait for user
            Console.ReadKey();

                //1 - Proxy
                Console.WriteLine("Proxy");
                    ProxyClient proxy = new ProxyClient();
                    Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
                    // Wait for user
                    Console.ReadKey();

                //2 - Flyweight
                Console.WriteLine("Flyweight");
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
                    // Wait for user
                    Console.ReadKey();

                //3 - Facade
                Console.WriteLine("Facade");
                    CarFacade facade = new CarFacade();
                    facade.CreateCompleteCar();
                    // Wait for user
                    Console.ReadKey();

                //4 - Bridge
                Console.WriteLine("Bridge");
                    IMessageSender email = new EmailSender();
                    IMessageSender queue = new MSMQSender();
                    IMessageSender web = new WebServiceSender();
                    Message message = new SystemMessage();
                    message.Subject = "Test Message";
                    message.Body = "Hi, This is a Test Message";
                    message.MessageSender = email;
                    message.Send();
                    message.MessageSender = queue;
                    message.Send();
                    message.MessageSender = web;
                    message.Send();
                    UserMessage usermsg = new UserMessage();
                    usermsg.Subject = "Test Message";
                    usermsg.Body = "Hi, This is a Test Message";
                    usermsg.UserComments = "I hope you are well";
                    usermsg.MessageSender = email;
                    usermsg.Send();
                    // Wait for user
                    Console.ReadKey();

                //5 - Adapter
                Console.WriteLine("Adapter");
                    ITarget Itarget = new EmployeeAdapter();
                    ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
                    client.ShowEmployeeList();
                    // Wait for user
                    Console.ReadKey();

                //6 - Decorator
                Console.WriteLine("Decorator");
                    HondaCity car = new HondaCity();
                    Console.WriteLine("Honda City base price are : {0}", car.Price);
                    SpecialOffer offer = new SpecialOffer(car);
                    offer.DiscountPercentage = 25;
                    offer.Offer = "25 % discount";
                    Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);
                    // Wait for user
                    Console.ReadKey();
        }
    }
}
