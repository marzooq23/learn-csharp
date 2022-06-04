using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Copy_Constructor_eg
    {
        class Car
        {
            public string model;
            public string color;
            public Car(string model, string color) // Instance constructor
            {
                this model = model;
                this.color = color;
            }
            public Car(Car C) // declaring Copy constructor
            {
                model = C.model;
                color = C.color;
            }
            public string Details // Get details of Copied Car
            {
                get { return "Model = " + model + "\t Color =" + color; }
            }
            static void Main(string[] args)
            {
                Car Volvo = new Car("v", "white"); //parameterized const
                Console.WriteLine("Instance constructor: " + "Model: " + Volvo.model + " Color: " + Volvo.color);
                // output Instance constructor: Model: v Color: white
                Car Copy_Volvo = new Car(Volvo);
                Console.WriteLine("Copy construcor: " + Copy_Volvo.Details);
                //output Copy construcor: Model = v Color white
                Console.ReadLine();
            }
        }

    }
}
