using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint4.Task1.V19.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int wait = 32;
            int res = ds.Calculate(nArray);

            Assert.AreEqual(wait, res);

        }
    }
}
