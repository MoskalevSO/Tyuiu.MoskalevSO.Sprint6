using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevSO.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<string> words = new List<string>();

            foreach (string line in lines)
            {
                string[] lineWords = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Первое слово каждой строки
                if (lineWords.Length > 0)
                {
                    words.Add(lineWords[0]);
                }
            }

            return string.Join(" ", words);
        }
    }
}
