﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint4.Task0.V4.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] nArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int wait = 32;
            int res = ds.GetMultEvenArrEl(nArray);

            Assert.AreEqual(wait, res);

        }
    }
}
