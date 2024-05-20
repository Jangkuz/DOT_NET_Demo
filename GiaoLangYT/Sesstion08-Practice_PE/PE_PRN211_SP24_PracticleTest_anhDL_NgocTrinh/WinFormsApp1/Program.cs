using BookManager_anhDL;

namespace WinFormsApp1
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
            ApplicationConfiguration.Initialize();
            Application.Run(new formBookManager());
            //new màn hình chính, từ chính mới new 
            //mà hình detail.
            //Application.Run(new BookDetailForm());
        }
    }
}