using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Manager_Form : Form
    {
        private Home_Form _homeForm;
        private HealthData_Form _healthDataForm;


        public Manager_Form()
        {
            // start invisible manager form
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ShowInTaskbar = false;
            Visible = false;            
            InitializeComponent();

            // start Log-In
            var logInScreen = new LogIn_Form();            
            logInScreen.FormClosing += LogInScreen_OnFormClosing;
            logInScreen.Show();

            // create Home- and HealthData-Form in background
            _homeForm = new Home_Form(true);
            _homeForm.VisibleChanged += HomeForm_OnVisibleChanged;
            _homeForm.FormClosed += HomeForm_OnFormClosed;

            _healthDataForm = new HealthData_Form(true);
            _healthDataForm.VisibleChanged += HealthDataForm_OnVisibleChanged;
            _healthDataForm.FormClosed += HealthDataForm_OnFormClosed;
        }

        private void LogInScreen_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            var splashScreen = new SplashScreen_Form(false);
            splashScreen.Show();
            splashScreen.VisibleChanged += SplashScreen_OnFormHiding;
        }

        private void SplashScreen_OnFormHiding(object sender, EventArgs e)
        {
            _homeForm.Show();
        }

        private void HomeForm_OnVisibleChanged(object sender, EventArgs e)
        {
            if (!_homeForm.Visible)
            {
                Thread.Sleep(150);
                _healthDataForm.Show();                
            }
        }

        private void HealthDataForm_OnVisibleChanged(object sender, EventArgs e)
        {
            if(!_healthDataForm.Visible)
            {
                _homeForm.Show();
            }
        }

        // is needed because SplashScreen is still open  ---- maybe fixxed later
        private void HealthDataForm_OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // is needed because SplashScreen is still open   ---- maybe fixxed later
        private void HomeForm_OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
