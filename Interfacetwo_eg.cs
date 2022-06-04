using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Interfacetwo_eg
    {

        interface IShape //interface
        {
            //By default, members of an interface are abstract and public. 
            void draw();
            //interface method //with no body. 

            /* string msg= "helo"; */
            //throws error because Interfaces cannot contain fields. while abstract can contain fields
        }
        public class Rectangle : IShape //Rectangle implements the Shape interface 
        {
            public void draw() //definition of interface method inside derived class //body
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        public class Circle : IShape //derived class
        {
            public void draw() //do not have to use the override keyword
            {
                Console.WriteLine("drawing circle...");
            }
        }
        public class Program
        {
            public static void Main()
            {
                //Snape myshape = new Snape(); //it is not possible to create an IShape object
                IShape s = new Rectangle();
                s.draw(); //implementation of the abstract method by derived class
                s = new Circle();
                s.draw();
                Console.ReadLine();
            }
        }
        //output drawing rectangle... 
        //drawing circle...

    }
}
