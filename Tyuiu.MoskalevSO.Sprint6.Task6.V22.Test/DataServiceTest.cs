using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint6.Task6.V22.Lib;

namespace Tyuiu.MoskalevSO.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "один два три\nThe quick brown\n   hello world\n\nend");

            string res = ds.CollectTextFromFile(path);
            string wait = "один The hello end";

            Assert.AreEqual(wait, res);
        }
    }
}
