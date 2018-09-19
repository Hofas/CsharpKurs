using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0) 
            {
                Console.WriteLine("Witam Swiecie ");
            }
            else
            {
                //string name = args[0];
                foreach (var item in args)
                {
                    Console.WriteLine("Witaj " + item);
                     
                }
            }
        }
    }
}
