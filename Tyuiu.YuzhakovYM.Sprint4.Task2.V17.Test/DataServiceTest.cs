using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint4.Task2.V17.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nArray = { 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            int res = ds.Calculate(nArray);
            int wait = 19683;

            Assert.AreEqual(wait, res);
        }
    }
}
