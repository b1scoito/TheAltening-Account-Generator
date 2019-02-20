using System;
using System.Net;
using System.Windows.Forms;

namespace TAccountGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (CheckForInternetConnection()) { Application.Run(new MainWindow()); } else { MessageBox.Show("No internet connection, try again.", "TheAltening Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
