using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint3.Task1.V19.Lib;

namespace Tyuiu.TarasovVD.Sprint3.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int StopValue = 9;

            double res = ds.GetMultiplySeries(value, startValue, StopValue);

            double wait = 5.729;
            Assert.AreEqual(wait, res);
        }
    }
}
