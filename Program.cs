using System;
using ioc._01_ProblemSituation;
using ioc._02_FabricMethod;
using ioc._03_Abstraction;
using ioc._04_DependecyInjection;

namespace ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Problem logs: ");
            Console.WriteLine("---------------------------------------");
            /* As far as I understand:
            Problem:
            Class Flower doesn't work without Electricity and Lamp Classes.
            And if I want to change Lamp to another class (ex. Sun),
            that mean I need to modify Flower class 
            (which doesn't recommended by Open-Closed Principle)

            Also if I want to test Flower class with simulation of light (mock lamp)
            I can't do this.
            */
            var myFlower = new Flower();
            myFlower.StartPhotosynthesis();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Fabric method logs:");
            Console.WriteLine("---------------------------------------");

            /* As far as I understand:
            We pulled the water object out of the Rose class
            That mean if I want to use mockWater, I can use WaterFactory for that
            */
            var myRoses = new Rose();
            myRoses.StartGrowing();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Add abstraction logs:");
            Console.WriteLine("---------------------------------------");

            /* As far as I understand:
            I implemented Dependency Injection Principle:
            High-level Sunflower not depend on Low-level Sun
            Both depend on Interface
            */

            var myShinySunflower = new Sunflower();
            myShinySunflower.Shining();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Use Injector class:");
            Console.WriteLine("---------------------------------------");

            /* As far as I understand:
            Injector class decline coupling between Poppy (Some Business Logic) and Wind (Data Source)
            */

            var myLovelyPoppy = new PoppyService();
            myLovelyPoppy.Disperse();
        }
    }
}
