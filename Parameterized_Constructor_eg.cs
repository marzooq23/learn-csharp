using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Parameterized_Constructor_eg
    {

        class Car
        {
            public string model; public string color;
            public Car(string model, string color)
            {
                this.model = model;
                this.color = color;
            }
            static void Main(string[] args)
            {
                Car Volvo = new Car("v", "white"); Car Ford = new Car("Mustang", "Yellow");
                Console.WriteLine(Volvo.model); // output: v
                Console.WriteLine(Volvo.color); // output: white
                Console.WriteLine(Ford.model); // output: Mustang
                Console.WriteLine(Ford.color); // output: Yellow
                Console.ReadLine();
            }
        }

    }
}
