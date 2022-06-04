using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Inheritance_Single_eg
    {
        class Vehicle // base class (parent)
        {
            public string brand = "Ford"; // Vehicle field
            public void honk() // Vehicle method.
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }
        class Car : Vehicle // derived class (child)
        {
            public string modelName = "Mustang"; // Car field
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car myCar = new Car();
                myCar.honk(); // Call the hank() method (From the Vehicle class) on the myCar object
                              //Display the value of the brand field from the vehicle class) and the value of the modelName from the car class
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
                Console.ReadLine();
            }
        }
        //output Tuut, tuut! Ford Mustang
    }
}
