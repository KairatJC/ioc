using System;
using ioc.Problem;

namespace ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            /* As far as I understand:
            Class Flower doesn't work without Electricity and Lamp Classes.
            And if I want to change Lamp to another class (ex. Sun),
            that mean I need to modify Flower class 
            (which doesn't recommended by Open-Closed Principle)

            Flow of program controled by me
            inverse of control: me controled by program? ಠ╭╮ಠ

            Flow controled by program
            inverse: Program will be controled by flow
            */
            var myFlower = new Flower();
            myFlower.StartPhotosynthesis();
        }
    }
}
