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
        public LogIn_Form()
        {
            InitializeComponent();
        }

      private void LoginButton_Click(object sender, EventArgs e)
      {
         string email = emailTextBox.Text;
         string password = PasswordTextBox.Text;
         ProfileChangements.LogIn(email, password);
      }

      private void SigUpButton_Click(object sender, EventArgs e)
      {
         string email = emailTextBox.Text;
         string password = PasswordTextBox.Text;
         ProfileChangements.SignUp(email, password);
      }
   }
}
