using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task0.V6.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(3);
            double wait = 0.866;

            Assert.AreEqual(wait, res);
        }
    }
}
