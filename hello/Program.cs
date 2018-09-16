
using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args)
            {

            }
           string name = args[0];
           Console.WriteLine("Witam Swiecie" + name);

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}

        }
    }
}
