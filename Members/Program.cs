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
            diary.AddRaiting(3.53232f);
            diary.AddRaiting(5.4f);
            diary.AddRaiting(8.4f);

            DiaryStatistics stats = diary.ComputeStatistics();
            DiaryStatistics staty = new DiaryStatistics();


            //WriteResult("Średnia", stats.avg, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //WriteResult("Liczba Ocen", (int)stats.count);
            //WriteResult("Najwyższa Ocena", (long)stats.MaxGrade);
            //WriteResult("Najniższa ocena", stats.MinGrade);
            //WriteResult("Najniższa ocena", stats.MinGrade,"dupa");
            //WriteResult("nnn",diary.GiveMaxRating());

            diary.NameChanged += OnNameChanged;
            diary.NameChanged += new Diary.NameChangedDelegate(OnNameChanged2);

            diary.Name = "Dziennik Hofasa";
            diary.Name = "dziennik macieja";

            //diary.Name = "a";
            Console.WriteLine(diary.Name);
          
            Console.ReadKey();
            
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("druga metoda");
            Console.WriteLine("  ");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("UWAGA NAZWA ZMIENIONA");
            Console.WriteLine($"old name was:{args.ExistingName} new name is:{args.NewName}");
        }

        private static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result[0]);

        }
        private static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ":+int+ " + result);
        }
        private static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ":+long+ " + result);
        }
        private static void WriteResult(string description, float result,string test)
        {
            Console.WriteLine($"{description} {result:C5} {test} "+ "sss:");
                    }
        
    }
}
