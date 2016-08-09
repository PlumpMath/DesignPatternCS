
using System;
/// <summary>
/// 
/// Decorator pattern is used to add new functionality to an existing object without changing its structure.
/// This pattern creates a decorator class which wraps the original class and add new behaviors/operations to an object at run-time.
/// 
/// 1. Component - This is an interface containing members that will be implemented by ConcreteClass and Decorator.
/// 2. ConcreteComponent - This is a class which implements the Component interface.
/// 3. Decorator - This is an abstract class which implements the Component interface and contains the reference to a Component instance.This class also acts as base class for all decorators for components.
/// 4. ConcreteDecorator - This is a class which inherits from Decorator class and provides a decorator for components.
/// 
/// When to use it?
/// Add additional state or behavior to an object dynamically.
/// Make changes to some objects in a class without affecting others.
/// 
/// </summary>
namespace DesignPatterns.Structural.Decorator
{
    public interface Component
    {
        void Operation();
    }

    public class ConcreteComponent : Component
    {
        public void Operation()
        {
            Console.WriteLine("Component Operation");
        }
    }

    public abstract class Decorator : Component
    {
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public virtual void Operation()
        {
            _component.Operation();
        }
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Override Decorator Operation");
        }
    }
}
