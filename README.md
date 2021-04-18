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
 - [ ] Use IoC Container

## What is Done:
1. Simulated problem when we need to use IoC.
2. Fabric Method for creating objects implemented.
3. DIP implemented by using Interface.

## Factory method:
Can read [here](https://refactoring.guru/design-patterns/factory-method)
   
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
   
**Basic idea:** Creating dependent class outside dependency class