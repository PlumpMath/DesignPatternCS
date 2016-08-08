using System;

namespace DesignPatterns.Creational.Sample
{

    public interface VehiculeFactory
    {
        Bike GetBike(string Bike);
        Scooter GetScooter(string Scooter);
    }

    public class HondaFactory : VehiculeFactory
    {
        public Bike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicule '{0}' cannot be created", Bike));
            }
        }

        public Scooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicule '{0}' cannot be created", Scooter));
            }
        }
    }


    public class HeroFactory : VehiculeFactory
    {
        public Bike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicule '{0}' cannot be created", Bike));
            }
        }

        public Scooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicule '{0}' cannot be created", Scooter));
            }
        }
    }

    public interface Bike
    {
        string Name();
    }

    public interface Scooter
    {
        string Name();
    }

    public class RegularBike : Bike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }

    public class SportsBike : Bike
    {
        public string Name()
        {
            return "Sport Bike- Name";
        }
    }

    public class RegularScooter : Scooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }

    public class Scooty : Scooter
    {
        public string Name()
        {
            return "Scooty Scooter- Name";
        }
    }

    public class VehiculeClient
    {
        Bike bike;
        Scooter scooter;

        public VehiculeClient(VehiculeFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
