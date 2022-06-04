using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Abstraction_eg
    {

        public abstract class Shape //abstract class
        {
            public abstract void draw(); //abstract method //with no body //declared inside the abstract class
            public void erase() //non abstract method //regular method
            {
                Console.WriteLine("Erased!");
            }
        }
        public class Rectangle : Shape //derived class
        {
            public override void draw() // definition of abstract method inside derived class
            {
                Console.WriteLine("drawing rectangle..."); //body
            }
        }
        public class Circle : Shape //derived class
        {
            public override void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
        public class Program
        {
            public static void Main()
            {
                //Shape myshape = new Snape(); 
                //it is not possible to create an object of the shape (abstract) class
                Shape s = new Rectangle();
                s.draw();
                //implementation of the abstract method by derived class 
                s = new Circle();
                s.draw();
                s.erase();
                Console.ReadLine();
            }
        }
        //output drawing ractangle...
        //drawing circle...
        //Erased!

    }
}
