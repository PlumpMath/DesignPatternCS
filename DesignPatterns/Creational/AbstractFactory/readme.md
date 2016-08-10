### Abstract Factory

Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories. 

In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

1. **Abstract Factory** This is an interface which is used to create abstract product
2. **Concreate Factory** This is a class which implements the AbstractFactory interfacee to create concrete products
3. **AbstractProduct** This is an interface which declares a type of product
4. **ConcreteProduct** THis is a class which which implements AbstractProduct interface to create product
5. **Client** THis is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects
<p align="center">
![alt tag](https://github.com/frgrz/DesignPatternCS/blob/master/DesignPatterns/Creational/AbstractFactory/AbstractFactory.PNG)
</p>

###### When to use it?
* Create a set of related objects, or dependent objects which must be used together.
* System should be configured to work with multiple families of products.
* The creation of objects should be independent from the utilizing system.
* Concrete classes should be decoupled from clients.
