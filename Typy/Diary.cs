using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Diary
    {
        public Diary()
        {
            raitings = new List<float>();
        }
        //pola
        List<float> raitings;
        public string Name;
        //zachowania
        /// <summary>
        /// Dodaje kolejne oceny
        /// </summary>
        /// <param name="raiting"></param>
        public void AddRaiting(float raiting)
        {
            raitings.Add(raiting);
        }
        /// <summary>
        /// Oblicza średnią ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var raiting in raitings)
            {
                sum += raiting;
            }
            avg = sum / raitings.Count();

            return avg;


        }

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0;

            foreach (var raiting in raitings)
            {
                sum += raiting;
            }
            stats.avg = sum / raitings.Count();
            stats.MaxGrade = raitings.Max();
            stats.MinGrade = raitings.Min();
            stats.count = raitings.Count();
                                   
            return stats;
        }

        /// <summary>
        /// Wyciąga Najwyższą ocene
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return raitings.Max();
        }
        /// <summary>
        /// Wyciąga Najniższą ocene
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return raitings.Min();
        }
        /// <summary>
        /// Czyścci Tablicę ocen
        /// </summary>
        public void ClearDiary()
        {
            raitings.Clear();

        }
        /// <summary>
        /// Zlicza Oceny
        /// </summary>
        public float Count()
        {
            return raitings.Count();

        }
    }
}
