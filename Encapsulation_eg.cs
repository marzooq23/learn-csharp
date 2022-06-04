using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Encapsulation_eg
    {
        class Person
        {
            private string name;        //private attribute
            public string Name        // property
            {
                get { return name; } // get method
                set { name = value; } // set method
            }
        }



        class Car
        {
            private string model; // field
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car Volvo = new Car();
                /*
                Volvo.model = "X";
                Console.WriteLine(Volvo.model);
                */
                //Error 'Car.model' is inaccessible due to its protection level
            }
        }
        //output X
    }


    class Car2
    {
        private string model; // field
        public string Model // property
        {
            get { return model; }
            set { model = value; }
        }
    }
    class Programtwo
    {
        static void Main(string[] args)
        {
            Car2 Volvo = new Car2();
            Volvo.Model = "X";
            Console.WriteLine(Volvo.Model);
            Console.ReadLine();
        }
    }
}
