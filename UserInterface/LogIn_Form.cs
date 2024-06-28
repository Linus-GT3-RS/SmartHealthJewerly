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
using BackendCS;

namespace UserInterface
{
    public partial class LogIn_Form : Form
    {
        private Form s;
        

        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var username = username_textbox.Text;
            var password = password_textbox.Text;

            

            if (Backend.Login(username, password))
            {
                s = new SplashScreen_Form(true);
                s.FormClosed += justTests;

                this.Hide();

                s.Show();

            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void justTests(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
