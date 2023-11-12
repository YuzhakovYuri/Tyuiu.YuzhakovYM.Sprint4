using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint4.Task5.V4.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] randArray = { { -4, -1, -3, 5, 2 }, { -4, -1, -3, -3, -1 }, { -4, -1, -3, 5, 2 }, { -4, -1, -3, 5, 2 }, { -4, -1, -3, 5, 2 } };

            int wait = 8;
            int res = ds.Calculate(randArray);
            Assert.AreEqual(wait, res);
        }
    }
}
