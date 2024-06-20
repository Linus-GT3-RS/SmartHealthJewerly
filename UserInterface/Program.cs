using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    enum RunSettings
    {
        Normal = 0,
        SplashScreen_Only,
        LogIn_Only,
        Home_Only
    };

    internal static class Program
    {
        // configure FREE TO USE
        static RunSettings CurRunSettings = RunSettings.SplashScreen_Only;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form StartForm = null;

            switch(CurRunSettings)
            {
                case RunSettings.Normal:
                    StartForm = new Manager_Form();
                    break;

                case RunSettings.SplashScreen_Only:
                    StartForm = new SplashScreen_Form(true);
                    break;

                case RunSettings.LogIn_Only:
                    StartForm = new LogIn_Form();
                    break;

                case RunSettings.Home_Only:
                    StartForm = new Home_Form();
                    break;

                default:
                    throw new Exception("error");
            }

            Application.Run(StartForm);

        }





    }
}
