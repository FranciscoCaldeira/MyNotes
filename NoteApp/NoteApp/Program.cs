using System;



namespace NoteApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Singleton.GetInstance();
        }
    }
}
