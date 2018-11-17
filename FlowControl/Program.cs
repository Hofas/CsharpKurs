using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj swoj wiek");
            age = int.Parse(Console.ReadLine());
            if (age <= 10)
            {
                Method1();

            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();

            }

        }

        private static void Method4()
        {
            Console.WriteLine("Masz 30 lub więcej lat a dokładnie: " + age);
        }

        private static void Method3()
        {
            Console.WriteLine("twoj wiek jest wiekszy od 20 ale mniejszy od 30 i wynosi: " + age);
        }

        private static void Method2()
        {
            Console.WriteLine("twoj wiek jest wiekszy od 10 ale mniejszy od 20 i wynosi: " + age);
        }

        private static void Method1()
        {
            Console.WriteLine("Masz 10 lub mniej lat a dokładnie: " + age);
        }
    }
}
