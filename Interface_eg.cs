using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Interface_eg
    {
        interface ICar
        {
            void Cars();
        }
        class Car : ICar // parent class 1
        {
            public void Cars() // Providing the implementation of Cars() method
            {
                ArrayList My_list = new ArrayList();
                My_list.Add("Audi");
                My_list.Add("BMW");
                My_list.Add("Jaguar");
                My_list.Add("Mercedes");

                Console.WriteLine("Cars Sold by showroom: ");
                foreach (var elements in My_list)
                {
                    Console.WriteLine(elements);
                }
            }
        }

        interface IBike
        {
            void Bikes();
        }
        class Bike : IBike // Parent class 2
        {
            public void Bikes() // Providing the implementation of Bike () method
            {
                ArrayList My_list = new ArrayList();
                My_list.Add("Hero");
                My_list.Add("Royal Enfield");
                My_list.Add("TVS");
                My_list.Add("Yamaha");

                Console.WriteLine("Bikes Sold by showroom:");
                foreach (var elements in My_list)
                {
                    Console.WriteLine(elements);
                }
            }
        }

        class Vehicle : ICar, IBike // child class
        {
            Car listofcars = new Car(); // Creating objects of Car & Bike 
            Bike listofbikes = new Bike();
            public void Cars()
            {
                listofcars.Cars();
            }
            public void Bikes()
            {
                listofbikes.Bikes();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Vehicle selling = new Vehicle();
                selling.Cars();
                selling.Bikes();
                Console.ReadLine();
            }
        }
        //output
        //Cars Sold by showroom:
        //Audi
        //BMW
        //Jaguar
        //Mercedes
        //Bikes Sold by showroom:
        //Hero
        //Royal Enfield
        //TVS
        //Yamaha
    }
}
