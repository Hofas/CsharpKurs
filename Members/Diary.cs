using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members

{
    class Diary
    {
        //pola
        public List<float> raitings;

        private string _name;
        public string Name
        {
            get
            {
               
               return _name.ToUpper();
            }
            set
            {

                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);

                        

                    }

                    _name = value;
                }
            }

        }
        //delegate field
        public event NameChangedDelegate NameChanged;

        //delegate type? object?
        public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);



        



        //konstruktor
        public Diary()
        {
            raitings = new List<float>();
        }

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

        public delegate float DajMaxa();
        

        

    }
}
