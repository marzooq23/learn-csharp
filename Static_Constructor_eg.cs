using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Static_Constructor_eg
    {
        class Car
        {
            static Car()
            {
                // The following statement produces the first line of output, 
                // and the line occurs only once.
                Console.WriteLine("Welcome!");
            }
            public Car(int i)  // Instance constructor
            {
                Console.WriteLine("offer" + i);
            }
            public string Car_Offers(string brand, string model) // Instance method
            {
                return "Brand: " + brand + "Model: " + model;
            }
            static void Main(string[] args)
            {
                // Here Both Static and instance 
                // constructors are invoked for
                // first instance

                Car Volvo = new Car(1);
                Console.WriteLine(Volvo.Car_Offers("Volvo", "x"));
                Car Ford = new Car(2);
                Console.WriteLine(Ford.Car_Offers("Ford", "Mustang"));
                Console.ReadLine();
            }
        }
        // output

        // Welcome!

        //Offer 1

        //Brand: VolvoModel: x

        //offer 2

        //Brand: FordModel: Mustang
    }
}
