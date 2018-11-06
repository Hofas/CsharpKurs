using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        

        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Dzienniczek Stefana";
            
        }

        static void IncrementNumber(out int number)
        {

            number =+ 1 ;
        }

        static void Main(string[] args)
        {
            //  PassByValueAndRef();

            //immutable();
            //string name1 = "Marcin";
            //string name2 = "Marcin";

            //bool areEqual = name1.Equals(name2, StringComparison.CurrentCulture);
            //Console.WriteLine(areEqual);
            //Console.ReadKey();

            Array();
            Console.ReadLine();
            
        }

        private static void Array()
        {
            float[] ratings;
            ratings = new float[5];
            AddRatings(ratings);


            foreach (var raiting in ratings)
            {
                Console.WriteLine(raiting);
            }


        }

        private static void AddRatings(float[] ratings)
        {
            int a = ratings.Length;

            ratings[0] = 1f;
            ratings[1] = 2f;
            ratings[2] = 3f;
            ratings[3] = 4f;
            ratings[4] = 5f;
            Console.WriteLine(a);

        }

        private static void immutable()
        {
            string name = " Marcin ";
               name =  name.Trim();

            DateTime dateTime = new DateTime(2018, 11, 4, 18 , 10, 45);
            //dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            


            Console.WriteLine(name);
            Console.ReadKey();

                }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;
            GiveName(ref d2);
            Console.WriteLine(d2.Name);
            Console.ReadKey();

            int x1;

            IncrementNumber(out x1);
            Console.WriteLine(x1);
            Console.ReadKey();
        }
    }
}
