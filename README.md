# My attempt at understanding what is IoC, DIP, DI
I used this [resource](https://www.tutorialsteacher.com/ioc/) for learning.

## Definitions:
IoC (Inversion of Control) and DIP (Dependency Inversion Principle) are **principles**    
DI (Dependency Injection) - **Pattern**   
IoC Container - **Framework**   

## Scope of work:   
**Problem:** Tightly Coupled Classes     
**Goal:** Loosely Coupled Classes   
   
 - [x] Implement problem situation
 - [x] Implement IoC using Factory Pattern
 - [x] Implement DIP by creating abstraction
 - [x] Implement DI

## What is Done:
1. Simulated problem when we need to use IoC.
2. Implemented the Fabric method for creating objects.
3. DIP implemented using the Interface.
4. DI implemented using the Constructor injection.

## Dependency Inversion Principle
DIP is one of the SOLID object-oriented principle   
   
**DIP Definition**   
- High-level modules should not depend on low-level modules. Both should depend on the abstraction.
- Abstractions should not depend on details. Details should depend on abstractions.

## Dependency Injection:
There is 3 types of classes:
- **Client** - dependent class
- **Service** - dependency
- **Injector** - injects the service class object into the client class.
   
Three ways to inject:
- **Constructor**
- **Property**
- **Method**
   
**Basic idea:** Creating an object of dependency class outside the dependent class

## IoC Container:
[The best explanation](https://stackoverflow.com/a/1532254) why I need to use IoC Containers
   
## Additional Materials:
- About DI [LifeCycle](https://dotnetcoretutorials.com/2017/03/25/net-core-dependency-injection-lifetimes-explained/)
- DI container from [Microsoft](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0)
- [Factory](https://refactoring.guru/design-patterns/factory-method) Pattern