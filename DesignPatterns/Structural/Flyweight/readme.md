<a href="https://github.com/frgrz/DesignPatternCS">Back</a>

### Flyweight

Flyweight pattern is used to reduce the number of objects created, to decrease memory and resource usage. bAs a result it increase performance. Flyweight pattern try to reuse already existing similar kind objects by storing them and creates new object when no matching object is found.

The flyweight pattern uses the concepts of intrinsic and extrinsic data.
Intrinsic data is held in the properties of the shared flyweight objects.This information is stateless and generally remains unchanged, if any change occurs it would be reflected among all of the objects that reference the flyweight.
Extrinsic data is computed on the fly means at runtime and it is held outside of a flyweight object. Hence it can be stateful.

1. **Flyweight** This is an interface which defines the members of the flyweight objects.
2. ConcreteFlyweight** This is a class which Inherits from the Flyweight class.
3. **UnsharedFlyweight** This is a class which Inherits from the Flyweight class and enables sharing of information, it is possible to create instances of concrete flyweight classes that are not shared. 
4. **FlyweightFactory** This is a class which holds the references of already created flyweight objects. When the GetFlyweight method is called from client code, these references are checked to determine if an appropriate flyweight object is already present or not. If present, it is returned. Otherwise a new object is generated, added to the collection and returned.
<p align="center">
![alt tag](https://github.com/frgrz/DesignPatternCS/blob/master/DesignPatterns/Structural/Flyweight/Flyweight.PNG)
</p>


###### When to use it?
* Flyweight is used when there is a need to create a large number of objects of almost similar nature and storage cost is high.
* A few shared objects can replace many unshared ones.
* Most of the state can be kept on disk or calculated at runtime.
