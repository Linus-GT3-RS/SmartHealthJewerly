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
        // public static Manager_Form manager;


        public Manager_Form()
        {
            // manager = this;

            // start invisible manager form
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ShowInTaskbar = false;
            Visible = false;            
            InitializeComponent();

            var splashScreen = new SplashScreen_Form();
            splashScreen.FormClosing += SplashScreen_OnFormClosing;
            splashScreen.Show();
        }

        private void SplashScreen_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            var f = new MainScreen_Form();
            f.Show();
        }
    }
}
