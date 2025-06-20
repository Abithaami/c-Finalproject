using finalproject;
using finalproject.view;

namespace c_finalproject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Tablecreator.Table();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}