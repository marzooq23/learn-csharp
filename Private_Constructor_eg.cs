using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Private_Constructor_eg
    {
        class Car
        {
            private Car() // declare private Constructor 
            {
            }
            public static int price = 50; // declare static variable field

            static void Main(string[] args)
            {

                /*Car Volvo = new Car(); 
                  Console.WriteLine(Car.price);*/
                //Error if the uncomment the above code and exec. 
                //'Car.price' cannot be accessed with an instance reference;
                Console.WriteLine("Price of the car = {0} Lakhs INR", Car.price);
                Console.ReadLine();
            }
        }
        //output: Price of the car = 50 Lakhs INR
    }
}
