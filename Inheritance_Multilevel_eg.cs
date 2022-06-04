using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Inheritance_Multilevel_eg
    {
        class Vehicle // base class for Car (parent)
        {
            public string brand = "Ford"; // Vehicle field
            public void honk() // Vehicle method
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }
        class Car : Vehicle // derived class (child) & // base class for Sports Car (parent)
        {
            public string modelName = "Mustang"; // Car field 
            public int speed = 189; // car field
        }
        class SportsCar : Car // derived class (child)
        {
            public void CheckSpeed()
            {
                if (speed >= 180)
                {
                    Console.WriteLine("Sports Car");
                }
                else
                {
                    Console.WriteLine("not a sports car ");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                SportsCar myCar = new SportsCar();
                myCar.honk(); // call the honk() method (From the vehicle class) on the myCar object
                myCar.CheckSpeed(); // call the checkSpeed() method (From the Vehicle class) on the myCar object

                // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
                Console.ReadLine();
            }
        }

        //output

        //Tuut, tuut!

        //Sports Car

        //Ford Mustang

    }
}
