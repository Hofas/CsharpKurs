using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0) 
            {
                ValueTypes();

                for (; ; )
                {
                    
                    string name;
                    int wiek;
                    ClearHost();
                    Getdata(out name, out wiek);
                    writedata(name, wiek);

                }
            }
            else
            {
                //string name = args[0];
                foreach (var item in args)
                {
                    Console.WriteLine("Witaj " + item);
                    Console.ReadKey();
                }
            }
        }

        private static void ValueTypes()
        {
            int MaxV = int.MaxValue;
            int MinV = int.MinValue;
            long MaxLongV = long.MaxValue;
            long MinLongV = long.MaxValue;
            Console.WriteLine("Max Int to:" + MaxV);
            Console.WriteLine("Min Int to:" + MinV);
            Console.WriteLine("Max Long to:" + MaxLongV);
            Console.WriteLine("Min Long to:" + MinLongV);
            Console.ReadKey();
        }

        /// <summary>
        /// wypisuje info o użytkoniku
        /// </summary>
        /// <param name="name"></param>
        /// <param name="wiek"></param>
        private static void writedata(string name, int wiek)
        {
            if (wiek > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("To może piwo? " + name);

            }
            else if (wiek == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("nie rozrozniasz literek od cyferek? " + name);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("To może mleko? " + name);
            }

            Console.ReadKey();
        }
        /// <summary>
        /// pobiera dane o użytkowniku
        /// </summary>
        /// <param name="name"></param>
        /// <param name="wiek"></param>
        static void Getdata(out string name, out int wiek)
        {
            Console.Write("Podaj imie:");
            name = Console.ReadLine();

            Console.Write("podaj wiek:");
             bool result = int.TryParse(Console.ReadLine(), out wiek);
        }   
        /// <summary>
        /// czyści host
        /// </summary>
        private static void ClearHost()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
