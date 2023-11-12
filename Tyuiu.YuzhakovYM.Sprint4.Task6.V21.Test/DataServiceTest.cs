using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint4.Task6.V21.Lib;

namespace Tyuiu.YuzhakovYM.Sprint4.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int wait = 2;
            var names = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int res = ds.Calculate(names);

            Assert.AreEqual(wait, res);
        }
    }
}
