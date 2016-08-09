using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// In Factory pattern, we create object without exposing the creation logic. 
/// In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. 
/// The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.
/// 
/// 1- Product - This is an interface for creating the objects.
/// 2- ConcreteProduct - This is a class which implements the Product interface.
/// 3- Creator - This is an abstract class and declares the factory method, which returns an object of type Product.
/// 4 - ConcreteCreator - This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
/// 
/// When to use it?
/// Subclasses figure out what objects should be created.
/// Parent class allows later instantiation to subclasses means the creation of object is done when it is required.
/// The process of objects creation is required to centralize within the application.
/// A class (creator) will not know what classes it will be required to create.
/// 
/// </summary>

namespace DesignPatterns.Creational.FactoryMethod
{
    interface Product
    {

    }

    class ConcreteProductA : Product
    {

    }

    class ConcreteProductB : Product
    {

    }

    abstract class Creator
    {
        public abstract Product FactoryMethod(string type);
    }

    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new ConcreteProductA();
                case "B": return new ConcreteProductB();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
