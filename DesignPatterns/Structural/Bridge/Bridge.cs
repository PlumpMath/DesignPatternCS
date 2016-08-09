

using System;
/// <summary>
/// 
/// Bridge pattern is used to separate an abstraction from its implementation so that both can be modified independently.
/// This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class. Both types of classes can be modified without affecting to each other.
///
/// 1. Abstraction - This is an abstract class and containing members that define an abstract business object and its functionality.It contains a reference to an object of type Bridge. It can also acts as the base class for other abstractions.
/// 2. Redefined Abstraction - This is a class which inherits from the Abstraction class. It extends the interface defined by Abstraction class.
/// 3. Bridge - This is an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class.
/// 4. ImplementationA & ImplementationB - These are classes which implement the Bridge interface and also provide the implementation details for the associated Abstraction class.
/// 
/// When to use it?
/// Abstractions and implementations should be modified independently.
/// Changes in the implementation of an abstraction should have no impact on clients.
/// The Bridge pattern is used when a new version of a software or system is brought out, but the older version of the software still running for its existing client.There is no need to change the client code, but the client need to choose which version he wants to use.
/// 
/// </summary>
namespace DesignPatterns.Structural.Bridge
{
    public abstract class Abstraction
    {
        public Bridge Implementer { get; set; }

        public virtual void Operation()
        {
            Console.WriteLine("ImplementationBase:Operation()");
            Implementer.OperationImplementation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            Implementer.OperationImplementation();
        }
    }

    public interface Bridge
    {
        void OperationImplementation();
    }

    public class ImplementationA : Bridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ImplementationA:OperationImplementation()");
        }
    }

    public class ImplementationB : Bridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ImplementationB:OperationImplementation()");
        }
    }
}
