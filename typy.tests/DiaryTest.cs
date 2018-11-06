using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Typy.Tests
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool value = true;
            Assert.IsTrue(value);
        }
        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRaiting(9f);
            diary.AddRaiting(1f);
            diary.AddRaiting(6f);
            diary.AddRaiting(7f);
            diary.AddRaiting(3f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(9f, stats.MaxGrade);







        }
    }
}
