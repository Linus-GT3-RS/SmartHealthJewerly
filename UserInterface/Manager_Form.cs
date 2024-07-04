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
using System.Drawing.Text;

namespace UserInterface
{
    public partial class Manager_Form : Form
    {
        private LogIn_Form _loginForm;
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
            _loginForm = new LogIn_Form();
            _loginForm.OnLoginSucces += LoginScreen_OnLoginSuccess;
            _loginForm.FormClosed += LoginScreen_OnFormClosed;
            _loginForm.Show();

            // create Home- and HealthData-Form in background
            _homeForm = new Home_Form(true);
            _homeForm.VisibleChanged += HomeForm_OnVisibleChanged;
            _homeForm.FormClosed += HomeForm_OnFormClosed;

            _healthDataForm = new HealthData_Form(true);
            _healthDataForm.VisibleChanged += HealthDataForm_OnVisibleChanged;
            _healthDataForm.FormClosed += HealthDataForm_OnFormClosed;

            /*
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Fonts\Red_Hat_Display\RedHatDisplay-VariableFont_wght.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            */
        }

        private void LoginScreen_OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_OnLoginSuccess(object sender, EventArgs e)
        {
            var splashScreen = new SplashScreen_Form(false);
            _loginForm.Hide();
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

    }
}
