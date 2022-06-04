using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Constructor_eg
    {
        class Car
        {
            string color; // field
            static void Main(string[] args)
            {
                Car Volvo = new Car();
                Console.Write(Volvo.color); // Call the field
            }
        }
    }
}
