using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Typy

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Diary diary = new Diary();
            diary.AddRaiting(9f);
            diary.AddRaiting(1f);
            diary.AddRaiting(6f);
            diary.AddRaiting(7f);
            diary.AddRaiting(12f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(12f, stats.MaxGrade);
        }
        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";
            SetName(diary);
            Assert.AreEqual("Marcin", diary.Name);

        }

        private void SetName(Diary diary)
        {
            diary.Name = "Marcin";
        }

        [TestMethod]
        public void PassByInt()
        {
            int x1 = 5;
            IncrementNumber(x1);
            Assert.AreEqual(5,x1);

        }

        private void IncrementNumber(int number)
        {
            number = number + 15;
            
        }
        [TestMethod]
        public void PassByRefInt()
        {
            int x1 = 5;
            IncrementNumberRef(ref x1);
            Assert.AreEqual(20, x1);


        }

        private void IncrementNumberRef(ref int x1)
        {
            x1 = x1 + 15;
        }
    }

}
