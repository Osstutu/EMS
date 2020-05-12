using System;
using System.Windows.Forms;

namespace EMS.DesktopUI
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

            Login log = new Login();
            DialogResult open = log.ShowDialog();

            if (open == DialogResult.OK)
            {
                Application.Run(new StudentDetails());
            }

        }
    }
}
