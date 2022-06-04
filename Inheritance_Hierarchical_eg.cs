using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Inheritance_Hierarchical_eg
    {
        public class Vehicle // Super class
        {
            public string Honk() // Vehicle method
            {
                return "Tuut, tuut!";
            }
        }

        class Car : Vehicle // derived class (child)
        {
            public string CarName = "Mustang"; // Car field
        }
        class Bike : Vehicle // derived class (child)
        {
            public string BikeName = "pulsar"; //bike field
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car obj1 = new Car();
                Console.WriteLine("my vehicle is " + obj1.CarName + " and it horns..." + obj1.Honk());
                Bike obj2 = new Bike();
                Console.WriteLine("my vehicle is " + obj2.BikeName + " and it horns..." + obj2.Honk());
                Console.ReadLine();
            }

        }
        //output my vehicle is Mustang and it horns...Tuut, tuut!
        //my vehicle is pulsar and it horns...Tuut, tuut!

    }
}
