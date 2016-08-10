<a href="https://github.com/frgrz/DesignPatternCS">Back</a>

### Prototype

Prototye patterns is used to create a duplicate object or clone of the current object to enhance performance. This patern is used when creation of object is costly or complex.

For Example: An object is to be  created after a costly database operation. We can cache the objec, returns its clone on next request and update the database as and when needed thus reducing database calls

1. **Prototype** This is an interface which is used for the types of object that can be cloned itself.
2. **ConcretePrototype** This is a class which implements the Prototype interface for cloning itself.
<p align="center">
![alt tag](https://github.com/frgrz/DesignPatternCS/blob/master/DesignPatterns/Creational/Prototype/Prototype.PNG)
</p>

###### When to use it?
* The creation of each object is costly or complex.
* A limited number of state combinations exist in an object.
