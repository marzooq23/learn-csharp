using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Poly_compiletime_methodOverloading_eg
    {
        public class Cal
        {
            public static int add(int a, int b)
            {
                return a + b;
            }
            public static int add(int a, int b, int c)
            {
                return a + b + c;
            }
        }
        public class Program
        {
            public static void Main()
            {
                Console.WriteLine(Cal.add(12, 23));
                Console.WriteLine(Cal.add(12, 23, 25));
                Console.ReadLine();
            }
        }
        //output 35 60
    }

    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Cal.add(12, 23));
            Console.WriteLine(Cal.add(12.4f, 21.3f));
            Console.ReadLine();
        }
    }
    //output 35 33.7

}

