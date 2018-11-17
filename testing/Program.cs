using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.WriteLine("podaj imie");
            imie = Console.ReadLine();

            animal animal = new animal(imie);
            
            Console.WriteLine(animal._name);
            Console.ReadKey();


        }
    }
}
