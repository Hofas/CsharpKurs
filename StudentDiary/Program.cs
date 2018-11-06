using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diary DiaryPawel = new Diary();
            //DiaryPawel.AddRaiting(5);
            //DiaryPawel.AddRaiting(1.5f);
            //DiaryPawel.AddRaiting(5.523f);
            //DiaryPawel.AddRaiting(2.35f);
            //DiaryPawel.AddRaiting(9.5f);

            //float avg = DiaryPawel.CalculateAverage();
            //float Max = DiaryPawel.GiveMaxRating();
            //float Min = DiaryPawel.GiveMinRating();


            //DiaryPawel.ClearDiary();


            //for (; ; )
            //{
            //    Console.Write("wprowadz ocenę dla Pawła 1-10:");
            //    //float raiting;
            //    bool result = float.TryParse(Console.ReadLine(), out float raiting);


            //    if (raiting == 11)
            //    {
            //        break;
            //    }
            //    if (raiting > 0 && raiting < 11)
            //    {
            //        DiaryPawel.AddRaiting(raiting);
            //    }

            //}

            //DiaryStatistics stats = DiaryPawel.ComputeStatistics();
            ////Console.WriteLine("liczba ocen:" + DiaryPawel.Count());
            ////Console.WriteLine("średnia ocen:" + DiaryPawel.CalculateAverage());
            ////Console.WriteLine("Najlepsza ocena:" + DiaryPawel.GiveMaxRating());
            ////Console.WriteLine("Najgorsza ocena:" + DiaryPawel.GiveMinRating());
            ////Console.ReadKey();
            //Console.WriteLine("SRTEDNIA:" + stats.avg);
            //Console.WriteLine("lICZba ocen:" + stats.count);

            SpeechSynthesizer speek = new SpeechSynthesizer();
            speek.Speak("dupa");
            //Console.ReadKey();


            
        }


    }
}
