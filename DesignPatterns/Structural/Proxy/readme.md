### Proxy

The proxy design pattern is used to provide a surrogate object, which references to other object.

Proxy pattern involves a class, called proxy class, which represents functionality of another class.

1. **Subject** This is an interface having members that will be implemented by RealSubject and Proxy class
2. **RealSubject** This is a class which we want to use more efficiently by using proxy class.
3. **Proxy** This is a class which holds the instance of RealSubject class and can access RealSubject class members as required.
<p align="center">
![alt tag](https://github.com/frgrz/DesignPatternCS/blob/master/DesignPatterns/Structural/Proxy/Proxy.PNG)
</p>

There are various kinds of proxies, some of them are as follows:
* Virtual proxies : Hand over the creation of an object to another object
* Authentication proxies : Checks the access permissions for a request
* Remote proxies : Encodes requests and send them across a network
* Smart proxies : Change requests before sending them across a network

###### When to use it?
* Objects need to be created on demand means when their operations are requested.
* Access control for the original object is required.
* Allow to access a remote object by using a local object(it will refer to a remote object).
