# DesignPatternCS

#### From. http://www.dotnet-tricks.com

## Behavioral Patterns

### Command

In this pattern a request is wrapped nder an object as a command and passed to invoker object. Invoker object ass the command to the appropriate object which can handle it and that object executes the command.

This handles the request in traditional ways like as queuing and callbacks. This pattern s commonly used in the menu systems of many applications

1. **Client** This is the class that creates and executes the command object
2. **Invoker** Asks the command to carry out the action
3. **Command** This is an interface which specifies the Execute operation
4. **ConcreteComman** This is a class that implements the Execute operation by invoking operations on the receiver
5. **Receiver** This is a class that performs the Action associated with the request

### Chain of command

The chain of responsibility pattern is used to process a list or chain of various types of request and each of them may be handle by a different handler. This pattern decouples sender and receiver of a request vased on type of request.

In this pattern, normaly each receiver(handler) contains reference to anoher reeiver. If one receiver cannot handle the request then it passes to the next receiver and so on
 
1. **Client** This is the class that generates the request and passes it to the first handler in the chain of responsibility
2. **Handler** This is the bastract class that contains a member that holds the next handler in the chain and an associated metho to set this successor. It also has an abstract method that must be implemented by concrete classes to handle the request or pass it tot the next object in the pipeline
3. **ConcreteHandler** These are concrete handlers classes inheried from Handler class. These include the functionality to handle some request and ass others to the next item in the chain of request

## Creational Patterns

### Singleton 

Singleton pattern is one of the simplest patterns. This ensures that a class has only one instance and provides a global point of access to it

1. **Singleton** This is a class which is responsible for creating and maintaining its own unique instance.


### Prototype

Prototye patterns is used to create a duplicate object or clone of the current object to enhance performance. This patern is used when creation of object is costly or complex.

For Example: An object is to be  created after a costly database operation. We can cache the objec, returns its clone on next request and update the database as and when needed thus reducing database calls

1. **Prototype** This is an interface which is used for the types of object that can be cloned itself.
2. **ConcretePrototype** This is a class which implements the Prototype interface for cloning itself.

### Abstract Factory

Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories. 

In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

1. **Abstract Factory** This is an interface which is used to create abstract product
2. **Concreate Factory** This is a class which implements the AbstractFactory interfacee to create concrete products
3. **AbstractProduct** This is an interface which declares a type of product
4. **ConcreteProduct** THis is a class which which implements AbstractProduct interface to create product
5. **Client** THis is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects
