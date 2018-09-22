using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(2, "Jarek");
            Person person3 = new Person(3, "Tomek", "Brodaty");
            Person person4 = new Person(4, "Jasiu", "Stary", "ul. arcadi 5", 22, "inna");
            

             
        }
    }
}
