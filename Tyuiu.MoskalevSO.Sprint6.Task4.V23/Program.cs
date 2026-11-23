namespace Tyuiu.MoskalevSO.Sprint6.Task4.V23
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}