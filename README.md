# SOLID Principles

* Five agile principles that should guide you every time you need to write code.
1. Single Responsibility (SRP)
1. Open/Closed (OCP)
1. Liskov's Substitution 
1. Interface Segregation 
1. Dependency Inversion


### Single responsibility principle(SRP)
* A class should have only single responsibility.
* A Class should have only one reason to change.
* Yes, it is quite important for a class to have no more than one task.

<hr />
![alt text](https://github.com/shahedbd/SOLIDPrinciples/blob/master/Sln.SOLIDPrinciples/SOLID/Resources/SRP01.jpg)
<hr />
![alt text](https://github.com/shahedbd/SOLIDPrinciples/blob/master/Sln.SOLIDPrinciples/SOLID/Resources/SRP02.jpg)




### Open/closed principle(OCP)
* Software entities should be open for extension, but closed for modification. 
```
Software entities: classes, modules, functions, etc.
```
* Write your code so that you will be able to add new functionality without changing the existing code.

* It uses interfaces instead of superclasses.



### Liskov substitution principle(LSP)
* Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.

* If S is a subtype of T, then objects of type T may be replaced with objects of type S (in other words, objects of type S may substitute objects of type T) without altering any of the desirable properties of that program (correctness, task performed, and so on).



### Interface segregation principle(ISP)
* Many client-specific interfaces are better than one general-purpose interface.

* The interface-segregation principle states that no client should be forced to depend on methods it does not use.

### Dependency inversion principle(DIP)
* One should depend upon abstractions, not concretions.

* High-level modules should not depend on low-level modules. 
* Both should depend on abstractions.
* Abstractions should not depend on details. * Details should depend on abstractions.

* So High-level and low-level modules And Details depends on Abstractions 

> High-level + Low-level modules + Details: Abstractions








