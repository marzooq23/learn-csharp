using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Poly_runtime_methodOverRiding_eg
    {

        public class Animal // Base class (parent)
        {
            public virtual void Eat()
            {
                Console.WriteLine("eating...");
            }
        }
        public class Dog : Animal // Derived class (child)
        {
            public override void Eat()
            {
                Console.WriteLine("eating bread...");
            }
        }
        public class Program
        {
            public static void Main()
            {
                Animal a = new Dog();
                a.Eat();
                Console.ReadLine();
            }
        }
        //output eating bread...
    }
}
