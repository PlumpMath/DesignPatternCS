/// <summary>
/// Prototye patterns is used to create a duplicate object or clone of the current object to enhance performance. 
/// This patern is used when creation of object is costly or complex.
/// For Example: An object is to be  created after a costly database operation. 
/// We can cache the objec, returns its clone on next request and update the database as and when needed thus reducing database calls
/// </summary>

namespace DesignPatterns.Creational
{
    public interface Prototype
    {
        Prototype Clone();
    }

    public class ConcretePrototypeA : Prototype
    {
        public Prototype Clone()
        {
            //Shallow Copy: only top-level objects are duplicated
            return (Prototype)MemberwiseClone();

            //Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
    }

    public class ConcretePrototypeB : Prototype
    {
        public Prototype Clone()
        {
            //Shallow Copy: only top-level objects are duplicated
            return (Prototype)MemberwiseClone();

            //Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
    }
}
