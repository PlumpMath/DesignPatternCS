# DesignPatternCS

#### From. http://www.dotnet-tricks.com, http://www.tutorialspoint.com

## Summary
1. **Behavioral**
 1. **Command**: Encapsulate a method call as an object containing all necessary information
 2. **Chain of Responsibility**: Pass requests between command and processing objects within a chain of objects
 3. ~~**Interpreter**: Include language elements and evaluate sentences in a given language~~
 4. ~~**Iterator**: Give sequential access to elements in a collection~~
 5. ~~**Mediator**: Encapsulates and simplifies communication between objects~~
 6. ~~**Memento**: Undo modifications and restore an object to its initial state~~
 7. ~~**Observer**: Notify dependent objects of state changes~~
 8. ~~**State**: Change object behavior depending on its state~~
 9. ~~**Strategy**: Encapsulate algorithms within a class and make them interchangeable~~
 10. ~~**Template** Method: Define an algorithm skeleton and delegate algorithm steps to subclasses so that they may be overridden~~
 11. ~~**Visitor**: Add new operations to classes without modifying them~~
2. **Creational**
 1. **Singleton**: Class with only one single possible instance
 2. **Prototype**: Clone or copy initialized instances
 3. **Abstract factory**: Create instances of classes belonging to different families
 4. **Factory Method**: Create instances of derived classes
 5. **Builder**: Separate representation and object construction
3. **Structural**
 1. ~~**Adapter**: Match interfaces of classes with different interfaces~~
 2. ~~**Bridge**: Separate implementation and object interfaces~~
 3. ~~**Composite**: Simple and composite objects tree~~
 4. ~~**Decorator**: Dynamically add responsibilities to objects~~
 5. ~~**Facade**: Class that represents subclasses and subsystems~~
 6. **Flyweight**: Minimize memory usage by sharing as much data as possible with similar objects
 7. **Proxy**: Object that represents another object
 
## Behavioral Patterns

### Command

In this pattern a request is wrapped nder an object as a command and passed to invoker object. Invoker object ass the command to the appropriate object which can handle it and that object executes the command.

This handles the request in traditional ways like as queuing and callbacks. This pattern s commonly used in the menu systems of many applications

1. **Client** This is the class that creates and executes the command object
2. **Invoker** Asks the command to carry out the action
3. **Command** This is an interface which specifies the Execute operation
4. **ConcreteComman** This is a class that implements the Execute operation by invoking operations on the receiver
5. **Receiver** This is a class that performs the Action associated with the request

###### When to use it?
* Need to implement callback functionalities.
* Need to support Redo and Undo functionality for commands.
* Sending requests to different receivers which can handle it in different ways.
* Need for auditing and logging of all changes via commands.

### Chain of Responsibility

The chain of responsibility pattern is used to process a list or chain of various types of request and each of them may be handle by a different handler. This pattern decouples sender and receiver of a request vased on type of request.

In this pattern, normaly each receiver(handler) contains reference to anoher reeiver. If one receiver cannot handle the request then it passes to the next receiver and so on
 
1. **Client** This is the class that generates the request and passes it to the first handler in the chain of responsibility
2. **Handler** This is the bastract class that contains a member that holds the next handler in the chain and an associated metho to set this successor. It also has an abstract method that must be implemented by concrete classes to handle the request or pass it tot the next object in the pipeline
3. **ConcreteHandler** These are concrete handlers classes inheried from Handler class. These include the functionality to handle some request and ass others to the next item in the chain of request

###### When to use it?
* A set of handlers to handle a request.
* A scenario within you need to pass a request to one handler among a list of handlers at run-time based on certain conditions.
* Exception handling system in C# is the good example of this pattern. Since an exception thrown by a piece of code in C# is handled by a set of try-catch block. Here catch blocks act as possible handlers to handle the exception.

## Creational Patterns

### Singleton 

Singleton pattern is one of the simplest patterns. This ensures that a class has only one instance and provides a global point of access to it

1. **Singleton** This is a class which is responsible for creating and maintaining its own unique instance.

###### When to use it?
* Exactly one instance of a class is required.
* Controlled access to a single object is necessary.

### Prototype

Prototye patterns is used to create a duplicate object or clone of the current object to enhance performance. This patern is used when creation of object is costly or complex.

For Example: An object is to be  created after a costly database operation. We can cache the objec, returns its clone on next request and update the database as and when needed thus reducing database calls

1. **Prototype** This is an interface which is used for the types of object that can be cloned itself.
2. **ConcretePrototype** This is a class which implements the Prototype interface for cloning itself.

###### When to use it?
* The creation of each object is costly or complex.
* A limited number of state combinations exist in an object.

### Abstract Factory

Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories. 

In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

1. **Abstract Factory** This is an interface which is used to create abstract product
2. **Concreate Factory** This is a class which implements the AbstractFactory interfacee to create concrete products
3. **AbstractProduct** This is an interface which declares a type of product
4. **ConcreteProduct** THis is a class which which implements AbstractProduct interface to create product
5. **Client** THis is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects

###### When to use it?
* Create a set of related objects, or dependent objects which must be used together.
* System should be configured to work with multiple families of products.
* The creation of objects should be independent from the utilizing system.
* Concrete classes should be decoupled from clients.

### Factory Method

In Factory pattern, we create object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. 

The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.
 
1. **Product** This is an interface for creating the objects.
2. **ConcreteProduct** This is a class which implements the Product interface.
3. **Creator** This is an abstract class and declares the factory method, which returns an object of type Product.
4. **ConcreteCreator** This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

###### When to use it?
* Subclasses figure out what objects should be created.
* Parent class allows later instantiation to subclasses means the creation of object is done when it is required.
* The process of objects creation is required to centralize within the application.
/// A class (creator) will not know what classes it will be required to create.


## Structural Patterns

### Proxy

The proxy design pattern is used to provide a surrogate object, which references to other object.

Proxy pattern involves a class, called proxy class, which represents functionality of another class.

1. **Subject** This is an interface having members that will be implemented by RealSubject and Proxy class
2. **RealSubject** This is a class which we want to use more efficiently by using proxy class.
3. **Proxy** This is a class which holds the instance of RealSubject class and can access RealSubject class members as required.

There are various kinds of proxies, some of them are as follows:
* Virtual proxies : Hand over the creation of an object to another object
* Authentication proxies : Checks the access permissions for a request
* Remote proxies : Encodes requests and send them across a network
* Smart proxies : Change requests before sending them across a network

###### When to use it?
* Objects need to be created on demand means when their operations are requested.
* Access control for the original object is required.
* Allow to access a remote object by using a local object(it will refer to a remote object).

### Flyweight

Flyweight pattern is used to reduce the number of objects created, to decrease memory and resource usage. bAs a result it increase performance. Flyweight pattern try to reuse already existing similar kind objects by storing them and creates new object when no matching object is found.

The flyweight pattern uses the concepts of intrinsic and extrinsic data.
Intrinsic data is held in the properties of the shared flyweight objects.This information is stateless and generally remains unchanged, if any change occurs it would be reflected among all of the objects that reference the flyweight.
Extrinsic data is computed on the fly means at runtime and it is held outside of a flyweight object. Hence it can be stateful.

1. **Flyweight** This is an interface which defines the members of the flyweight objects.
2. ConcreteFlyweight** This is a class which Inherits from the Flyweight class.
3. **UnsharedFlyweight** This is a class which Inherits from the Flyweight class and enables sharing of information, it is possible to create instances of concrete flyweight classes that are not shared. 
4. **FlyweightFactory** This is a class which holds the references of already created flyweight objects. When the GetFlyweight method is called from client code, these references are checked to determine if an appropriate flyweight object is already present or not. If present, it is returned. Otherwise a new object is generated, added to the collection and returned.

###### When to use it?
* Flyweight is used when there is a need to create a large number of objects of almost similar nature and storage cost is high.
* A few shared objects can replace many unshared ones.
* Most of the state can be kept on disk or calculated at runtime.
