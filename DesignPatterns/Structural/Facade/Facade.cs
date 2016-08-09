using System;

/// <summary>
/// 
/// Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system.
/// This pattern involves a single wrapper class which contains a set of members which are required by client.These members access the system on behalf of the facade client and hide the implementation details.
/// The facade design pattern is particularly used when a system is very complex or difficult to understand because system has a large number of interdependent classes or its source code is unavailable.
/// 
/// 1. Complex System - A library of subsystems.
/// 2. SubsystemA, SubsystemB, SubsystemC - These are classes within complex system and offer detailed operations.
/// 3. Façade - This is a wrapper class which wrapper class which contains a set of members which are required by client.
/// 4. Client - This is a class which calls the high-level operations in the Façade.
///
/// What is it for? 
/// 
/// A simple interface is required to access to a complex system.
/// The abstractions and implementations of a subsystem are tightly coupled.
/// Need an entry point to each level of layered software.
/// The facade design pattern is particularly used when a system is very complex or difficult to understand because system has a large number of interdependent classes or its source code is unavailable
/// 
/// </summary>

namespace DesignPatterns.Structural.Facade
{
    class SubsystemA
    {
        public string OperationA1()
        {
            return "Subsystem A, Method A1\n";
        }
        public string OperationA2()
        {
            return "Subsystem A, Method A2\n";
        }
    }
    class SubsystemB
    {
        public string OperationB1()
        {
            return "Subsystem B, Method B1\n";
        }

        public string OperationB2()
        {
            return "Subsystem B, Method B2\n";
        }
    }
    class SubsystemC
    {
        public string OperationC1()
        {
            return "Subsystem C, Method C1\n";
        }

        public string OperationC2()
        {
            return "Subsystem C, Method C2\n";
        }
    }

    public class Facade
    {
        SubsystemA a = new SubsystemA();
        SubsystemB b = new SubsystemB();
        SubsystemC c = new SubsystemC();
        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
            a.OperationA1() +
            a.OperationA2() +
            b.OperationB1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
            b.OperationB2() +
            c.OperationC1() +
            c.OperationC2());
        }
    }
}
