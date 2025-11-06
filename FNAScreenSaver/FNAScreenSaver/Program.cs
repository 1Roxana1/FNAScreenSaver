using FNAScreenSaver.Services;

namespace FNAScreenSaver
{
    /// <summary>
    /// Класс запуска программы
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Точка входа программы
        /// </summary>
        public static void Main(string[] args)
        {
            using (GameEngine game = new GameEngine())
            {
                game.Run();
            }
        }
    }

}
