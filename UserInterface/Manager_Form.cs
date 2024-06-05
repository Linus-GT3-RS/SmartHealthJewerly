using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            // start invisible manager form
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ShowInTaskbar = false;
            Visible = false;            
            InitializeComponent();


            var logInScreen = new LogIn_Form();            
            logInScreen.FormClosing += LogInScreen_OnFormClosing;
            logInScreen.Show();
        }

        private void SplashScreen_OnFormHiding(object sender, EventArgs e)
        {
            var homeScreen = new Home_Form();
            homeScreen.FormClosed += HomeScreen_OnFormClosed;
            homeScreen.Show();
        }

        private void LogInScreen_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            var splashScreen = new SplashScreen_Form();
            splashScreen.Show();
            splashScreen.VisibleChanged += SplashScreen_OnFormHiding;
        }

        private void HomeScreen_OnFormClosed(Object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
