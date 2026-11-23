using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task4.V23.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task4.V23.Test
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
            Assert.AreEqual(2.5, res[5]);   // x = 0
            Assert.AreEqual(0, res[6]);     // x = 1, деление на ноль
        }

        [TestMethod]
        public void CheckedSaveToFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V23.txt");

            ds.SaveToFile(-5, 5, path);

            Assert.IsTrue(File.Exists(path));
            Assert.HasCount(11, File.ReadAllLines(path));
        }
    }
}
