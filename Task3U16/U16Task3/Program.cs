using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using U16Task3.Forms;

namespace U16Task3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Enables visual styles for the application
            Application.SetCompatibleTextRenderingDefault(false); // Sets the application to use compatible text rendering
            Application.Run(new Main()); // Runs the application by creating an instance of the Main form
        }
    }
}
