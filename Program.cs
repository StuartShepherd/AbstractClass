using System;

namespace AbstractClass
{
    class Program
    {
        public abstract class Vehicle
        {
            public abstract string Display();
        }

        public class Bus : Vehicle
        {
            public override string Display()
            {
                return "bus";
            }
        }

        public class Car : Vehicle
        {
            public override string Display()
            {
                return "car";
            }
        }

        public class Motorcycle : Vehicle
        {
            public override string Display()
            {
                return "motorcycle";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class");
            Console.WriteLine("An abstract class is used to define what is known as a base class. A base class is a class which has the most basic definition of a particular requirement.");
            Console.WriteLine();

            var bus = new Bus();
            Console.WriteLine($"This vehicle is a {bus.Display()}");

            var car = new Car();
            Console.WriteLine($"This vehicle is a {car.Display()}");

            var motorcycle = new Motorcycle();
            Console.WriteLine($"This vehicle is a {motorcycle.Display()}");
        }
    }
}