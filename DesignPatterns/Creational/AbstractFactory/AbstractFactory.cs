/// <summary>
/// Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories.
/// In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.
/// 
/// Abstract Factory - This is an interface which is used to create abstract product
/// Concreate Factory - This is a class which implements the AbstractFactory interfacee to create concrete products
/// AbstractProduct - This is an interface which declares a type of product
/// ConcreteProduct - THis is a class which which implements AbstractProduct interface to create product
/// Client - THis is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects
/// </summary>

namespace DesignPatterns.Creational
{
    public interface AbsractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }

    public class ConcreteFactoryA : AbsractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactoryB : AbsractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public interface AbstractProductA { }
    public class ProductA1 : AbstractProductA { }
    public class ProductA2 : AbstractProductA { }

    public interface AbstractProductB { }
    public class ProductB1 : AbstractProductB { }
    public class ProductB2 : AbstractProductB { }

    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public Client(AbsractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();

        }
    }
}
