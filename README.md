# My attempt at understanding what is IoC, DIP, DI
I used this [resource](https://www.tutorialsteacher.com/ioc/) for learning.

## First:
IoC (Inversion of Control) and DIP (Dependency Inversion Principle) are **principles**    
DI (Dependency Injection) - **Pattern**   
IoC Container - **Framework**   

## Scope of work:   
**Problem:** Tightly Coupled Classes     
**Goal:** Loosely Coupled Classes   
   
 - [x] Implement problem situation
 - [x] Implement IoC using Factory Pattern
 - [x] Implement DIP by creating abstraction
 - [ ] Implement DI
 - [ ] Use IoC Container

## What is Done:
1. Simulated problem when we need to use IoC.
2. Implemented Factory for creating objects.

## Factory method:
Can read [here](https://refactoring.guru/design-patterns/factory-method)
   
Basic idea: pull the object creation outside of the clas

## Dependency Inversion Principle
DIP is one of the SOLID object-oriented principle   
   
**DIP Definition**   
- High-level modules should not depend on low-level modules. Both should depend on the abstraction.
- Abstractions should not depend on details. Details should depend on abstractions.