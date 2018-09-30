using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {

        static void GiveName(Diary diary)
        {
            diary.Name = "Dzienniczek Stefana";
        }

        static void IncrementNumber(int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            Diary d1 = new Diary();
            Diary d2 = d1;
            GiveName(d1);
            Console.WriteLine(d2.Name);
            Console.ReadKey();

            int x1 = 4;

            IncrementNumber(x1);
            Console.WriteLine(x1);
            Console.ReadKey();
            
        }
    }
}
