### Command

In this pattern a request is wrapped nder an object as a command and passed to invoker object. Invoker object ass the command to the appropriate object which can handle it and that object executes the command.

This handles the request in traditional ways like as queuing and callbacks. This pattern s commonly used in the menu systems of many applications

1. **Client** This is the class that creates and executes the command object
2. **Invoker** Asks the command to carry out the action
3. **Command** This is an interface which specifies the Execute operation
4. **ConcreteComman** This is a class that implements the Execute operation by invoking operations on the receiver
5. **Receiver** This is a class that performs the Action associated with the request
<p align="center">
![alt tag](https://github.com/frgrz/DesignPatternCS/blob/master/DesignPatterns/Behavioral/Command/Command.PNG)
</p>

###### When to use it?
* Need to implement callback functionalities.
* Need to support Redo and Undo functionality for commands.
* Sending requests to different receivers which can handle it in different ways.
* Need for auditing and logging of all changes via commands.
