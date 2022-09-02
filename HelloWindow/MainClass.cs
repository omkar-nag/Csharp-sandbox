using System;
using System.Windows.Forms;

namespace HelloWindow
{
    internal static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GreetingForm());
        }
    }
}