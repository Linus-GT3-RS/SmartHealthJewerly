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
        SplashScreen_Only, LogIn_Only, Home_Only, HealthData_Only,
        Skip2Home       // todo
    };

    internal static class Program
    {
        // ---------------------------------- Start CONFIG : Free to use ----------------------------------

        static RunSettings CurRunSettings = RunSettings.LogIn_Only;

        // ---------------------------------- END CONFIG -----------------------------------------------------


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
                    StartForm = new Home_Form(false);
                    break;

                case RunSettings.HealthData_Only:
                    StartForm = new HealthData_Form(false);
                    break;

                default:
                    throw new Exception("error: this shouldnt happen");
            }

            Application.Run(StartForm);

        }





    }
}
