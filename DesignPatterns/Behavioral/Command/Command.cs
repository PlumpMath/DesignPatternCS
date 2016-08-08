using System;

/// <summary>
/// In this pattern a request is wrapped nder an object as a command and passed to invoker object. Invoker object ass the command to the appropriate object which can handle it and that object executes the command.
/// This handles the request in traditional ways like as queuing and callbacks
/// This pattern s commonly used in the menu systems of many applications
/// 
/// Client - This is the class that creates and executes the command object
/// Invoker - Asks the command to carry out the action
/// Command - This is an interface which specifies the Execute operation
/// ConcreteComman - This is a class that implements the Execute operation by invoking operations on the receiver
/// Receiver - This is a class that performs the Action associated with the request
/// </summary>

namespace DesignPatterns.Behavioral
{ 
    public class Client
    {
        public void RunCommand()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            command.Parameter = "YO";
            invoker.Command = command;
            invoker.ExecuteCommand();
        }
    }

    public class Receiver
    {
        public void Action(string Message)
        {
            Console.WriteLine("Action called with message: {0}", Message);
        }
    }
    
    public class Invoker
    {
        public ICommand Command { get; set; }
        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class ConcreteCommand : ICommand
    {
        protected Receiver _receiver;
        public string Parameter { get; set; }
        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Action(Parameter);
        }
    }
}


