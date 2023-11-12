using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint4.Task4.V30.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] wait = { { 0, 4, 6, 6, 0 }, { 6, 0, 6, 0, 0 }, { 0, 0, 0, 0, 6 }, { 6, 4, 0, 6, 6 }, { 0, 4, 0, 4, 0 } };
            int[,] nMatrix = new int[5, 5] { { 3, 4, 6, 6, 5 }, { 6, 7, 6, 3, 5 }, { 5, 3, 5, 7, 6 }, { 6, 4, 7, 6, 6 }, { 7, 4, 3, 4, 5 } };

            int[,] res = ds.Calculate(nMatrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
