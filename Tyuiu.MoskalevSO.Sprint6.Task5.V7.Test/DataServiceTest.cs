using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task5.V7.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "3 6.5 10\n-2 5 7,25 5.0001");

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 6.5, 10, 7.25 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidLoadAllValuesRounding()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "3.14159 12");

            double[] res = ds.LoadAllValues(path);
            double[] wait = { 3.142, 12 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
