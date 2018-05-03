using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticaLibrary;

namespace StatisticaLibrary.Test
{
    [TestClass]
    public class StatisticaTest
    {
        [TestMethod]
        public void TestPositivo()
        {
            double a = 3;
            bool ris = true;

            bool resp = Statistica.IsPositivo(a, ris);
            Assert.AreEqual(ris, resp);
        }
        [TestMethod]
        public void TestNegativo()
        {
            double a = -3;
            bool ris = false;

            bool resp = Statistica.IsPositivo(a, ris);
            Assert.AreEqual(ris, resp);
        }
        [TestMethod]
        public void TestNeutro()
        {
            double a = 0;
            bool ris = false;

            bool resp = Statistica.IsPositivo(a, ris);
            Assert.AreEqual(ris, resp);
        }

        [TestMethod]
        public void TestCaricaPositiva()
        {
            int[] a = new int []{ 1, -3 , 5 , -6 };
            int ctr = 2;

            int resp = Statistica.CaricaPositiva(a, ctr);
            Assert.AreEqual(resp, ctr);
        }
        [TestMethod]
        public void TestPositivi()
        {
            int[] a = new int[] { 1, -3, 5, -6, 0 };
            int[] b = new int[] { 1,5 };
             

            int[] resp = Statistica.Positivi(a, b);
            CollectionAssert.AreEqual(b, resp);
        }
    }
}
