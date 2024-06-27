using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendCS;

namespace UserInterface
{
    public partial class LogIn_Form : Form
    {
        ProfileChangements _profileChangements;
        public LogIn_Form()
        {
            InitializeComponent(); 
            _profileChangements = new ProfileChangements();
        }

      private void LoginButton_Click(object sender, EventArgs e)
      {
         string email = emailTextBox.Text;
         string password = PasswordTextBox.Text;
         bool bLogin = _profileChangements.LogIn(email, password);
         
      }

      private void labelSignIn_Click(object sender, EventArgs e)
      {
         string email = emailTextBox.Text;
         string password = PasswordTextBox.Text;
         bool bSignIn = _profileChangements.SignUp(email, password);
         
      }
    }
}
