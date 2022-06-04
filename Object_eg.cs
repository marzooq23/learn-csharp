using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Object_eg
    {
        class Car
        {
            string color;
            int maxSpeed;
            public void fullThrottle()
            {
                Console.WriteLine(" 0 to 100 kmph in 5.6 s ");
            }
            static void Main(string[] args)
            {
                Car Volvo = new Car(); //instantiating obj
                Volvo.color = "red"; //accessing instance variables
                Volvo.maxSpeed = 200;
                Console.WriteLine(Volvo.color); // output: red
                Console.WriteLine(Volvo.maxSpeed); // output: 200
                Volvo.fullThrottle(); //accessing instance method
            }
        }
        // output: 0 to 100 kmph in 5.6 s

    }
}
