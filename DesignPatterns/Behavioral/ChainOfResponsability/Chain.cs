using System;

/// <summary>
/// 
/// The chain of responsibility pattern is used to process a list or chain of various types of request and each of them may be handle by a different handler.
/// This pattern decouples sender and receiver of a request vased on type of request.
/// In this pattern, normaly each receiver(handler) contains reference to anoher reeiver.
/// If one receiver cannot handle the request then it passes to the next receiver and so on
/// 
/// 1-Client - This is the class that generates the request and passes it to the first handler in the chain of responsibility
/// 2-Handler - This is the bastract class that contains a member that holds the next handler in the chain and an associated metho to set this successor.
/// It alsa has an abstract method that must be implemented by concrete classes to handle the request or pass it tot the next object in the pipeline
/// 3-ConcreteHandler - These are concrete handlers classes inheried from Handler class. These include the functionality to handle some request and ass others to the next item in the chain of request
/// 
/// When to use it?
/// A set of handlers to handle a request.
/// A scenario within you need to pass a request to one handler among a list of handlers at run-time based on certain conditions.
/// Exception handling system in C# is the good example of this pattern. Since an exception thrown by a piece of code in C# is handled by a set of try-catch block. Here catch blocks act as possible handlers to handle the exception.
/// 
/// </summary>

namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler _successor;
        public abstract void HandleRequest(int request);
        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }
    }

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
                Console.WriteLine("Handled by ConcreteHandlerA");
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 10)
                Console.WriteLine("Handled by ConcreteHandlerB");
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }

}
