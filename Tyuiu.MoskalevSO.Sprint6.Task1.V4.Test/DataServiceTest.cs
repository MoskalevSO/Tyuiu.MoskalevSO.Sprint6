using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task1.V4.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task1.V4.Test
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
            Assert.AreEqual(0, res[5]);      // x = 0
            Assert.AreEqual(-3.3, res[6]);   // x = 1
        }
    }
}
