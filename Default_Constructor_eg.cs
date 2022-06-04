using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Default_Constructor_eg
    {
        class Car
        {
            public string color; // Create a field 
            public Car()// Create a class constructor for the Car class
            {
                color = "red"; // Set the initial value for model
            }
            static void Main(string[] args)
            {
                Car Volvo = new Car(); // Create an obj (this will call the constructor)
                Console.Write(Volvo.color); // Call the field // Print the value of model 
                Console.ReadLine();
            }
        }
        // output: red


    }
}
