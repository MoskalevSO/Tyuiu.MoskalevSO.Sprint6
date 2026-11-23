using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task2.V24.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            Assert.HasCount(11, res);
            Assert.AreEqual(1, res[5]);   // x = 0
            Assert.AreEqual(0, res[7]);   // x = 2, деление на ноль
        }
    }
}
