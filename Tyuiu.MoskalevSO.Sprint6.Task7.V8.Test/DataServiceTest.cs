using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task7.V8.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "1;2;3;4;5;6;7;5;9\n1;2;3;4;5;6;7;9;9\n0;0;0;0;0;0;0;-3;0");

            int[,] res = ds.GetMatrix(path);
            int[,] wait =
            {
                { 1, 2, 3, 4, 5, 6, 7, 5, 9 },
                { 1, 2, 3, 4, 5, 6, 7, -1, 9 },
                { 0, 0, 0, 0, 0, 0, 0, -1, 0 }
            };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedSaveMatrix()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.csv");
            int[,] matrix = { { 1, -1 }, { 5, 3 } };

            ds.SaveMatrix(matrix, path);

            Assert.AreEqual("1;-1" + Environment.NewLine + "5;3" + Environment.NewLine, File.ReadAllText(path));
        }
    }
}
