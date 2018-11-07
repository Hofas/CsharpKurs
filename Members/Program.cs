using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRaiting(3.5f);
            diary.AddRaiting(5.4f);
            diary.AddRaiting(8.4f);

            DiaryStatistics stats = diary.ComputeStatistics();
            DiaryStatistics staty = new DiaryStatistics();


            WriteResult("Średnia", stats.avg);
            WriteResult("Liczba Ocen", stats.count);
            WriteResult("Najwyższa Ocena", stats.MaxGrade);
            WriteResult("Najniższa ocena", stats.MinGrade);
                 
            Console.ReadKey();
                                                  }

        private static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
