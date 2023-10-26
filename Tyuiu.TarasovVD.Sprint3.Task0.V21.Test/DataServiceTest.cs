using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint3.Task0.V21.Lib;

namespace Tyuiu.TarasovVD.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int StopValue = 13;

            double res = ds.GetSumSeries(value, startValue, StopValue);

            double wait = 580.932;
            Assert.AreEqual(wait, res);
        }
    }
}
