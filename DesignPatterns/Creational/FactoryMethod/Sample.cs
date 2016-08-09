using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Sample
{
    public interface IFactory
    {
        void Drive(int miles);
    }

    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the scooter: " + miles.ToString() + "km");
        }
    }

    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the bike: " + miles.ToString() + "km");
        }
    }

    public abstract class VehiculeFactory
    {
        public abstract IFactory GetVehicule(string Vehicule);
    }

    public class ConcreteVehiculeFactory : VehiculeFactory
    {
        public override IFactory GetVehicule(string Vehicule)
        {
            switch (Vehicule)
            {
                case "Scooter": return new Scooter();
                case "Bike": return new Bike();
                default: throw new ApplicationException(string.Format("Vehicule '{0}' cannot be created", Vehicule));
            }
        }
    }
}
