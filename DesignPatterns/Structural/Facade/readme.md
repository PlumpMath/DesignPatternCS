### Facade

Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system. This pattern involves a single wrapper class which contains a set of members which are required by client.These members access the system on behalf of the facade client and hide the implementation details.

The facade design pattern is particularly used when a system is very complex or difficult to understand because system has a large number of interdependent classes or its source code is unavailable.

1. **Complex System** - A library of subsystems.
2. **SubsystemA, SubsystemB, SubsystemC** - These are classes within complex system and offer detailed operations.
3. **Façade** - This is a wrapper class which wrapper class which contains a set of members which are required by client.
4. **Client** - This is a class which calls the high-level operations in the Façade.
<p align="center">
![alt tag](https://github.com/frgrz/DesignPatternCS/blob/master/DesignPatterns/Structural/Facade/Facade.PNG)
</p>

###### What is it for? 
* A simple interface is required to access to a complex system.
* The abstractions and implementations of a subsystem are tightly coupled.
* Need an entry point to each level of layered software.
* The facade design pattern is particularly used when a system is very complex or difficult to understand because system has a large number of interdependent classes or its source code is unavailable
