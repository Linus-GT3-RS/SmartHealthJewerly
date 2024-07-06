using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendCS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UserInterface
{
    public partial class LogIn_Form : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        ProfileChangements _profileChangements;

        public event EventHandler OnLoginSucces;



        public LogIn_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            _profileChangements = new ProfileChangements();
        }


      //check if textboxes are empty
      private bool checkTextBoxes()
      {
         bool isFine = true;

         //"email" == empty
         if (usernameTextBox.Text == "Username" 
                || usernameTextBox.Text == "" 
                || usernameTextBox.Text == "Fill Field" 
                || usernameTextBox.Text == "Username already used" 
                || usernameTextBox.Text == "No User with this Username")
         {
            usernameTextBox.ForeColor = DesignColors.Error;
            usernameTextBox.Text = "Fill Field";
            isFine = false;
         }

         //"password" == empty
         if (PasswordTextBox.Text == "Password" 
                || PasswordTextBox.Text == "" 
                || PasswordTextBox.Text == "Fill Field" 
                || PasswordTextBox.Text == "Wrong Password")
         {
            PasswordTextBox.ForeColor = DesignColors.Error;
            PasswordTextBox.Text = "Fill Field";
            isFine = false;
         }
         return isFine;
      }

      private void LoginButton_Click(object sender, EventArgs e)
      {
         if (checkTextBoxes())
         {
            string email = usernameTextBox.Text;
            string password = PasswordTextBox.Text;
            
            int erfolgreich = _profileChangements.LogIn(email, password);

            if (erfolgreich == 0)   // log in erfolgreich
            {               
               if(OnLoginSucces != null)
               {
                   OnLoginSucces(this, EventArgs.Empty);
               }
            }
            else if (erfolgreich == 1)      //password falsch
            {
               PasswordTextBox.ForeColor = DesignColors.Error;
               PasswordTextBox.Text = "Wrong Password";
            }
            else       //email nicht vorhanden
            {  
               usernameTextBox.ForeColor = DesignColors.Error;
               usernameTextBox.Text = "No User with this Username";
            }
         }
      }

      private void labelSignIn_Click(object sender, EventArgs e)
      {
         if (checkTextBoxes())
         {
            string loginname = usernameTextBox.Text;
            string password = PasswordTextBox.Text;
            
            if (_profileChangements.SignIn(loginname, password))     //sign in erfolgreich
            {
                    OnLoginSucces?.Invoke(this, EventArgs.Empty);        
            }
            else     //email wird schon genutzt
            {                
                PasswordTextBox.ForeColor = DesignColors.Error;
                usernameTextBox.Text = "Username already used";
            }
         }
      }



      //events
      private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
      {
         PasswordTextBox.ForeColor = DesignColors.Text;
         PasswordTextBox.Text = "";
      }

      private void emailTextBox_MouseClick(object sender, MouseEventArgs e)
      {
         usernameTextBox.ForeColor = DesignColors.Text;
         usernameTextBox.Text = "";
      }

      private void emailTextBox_Leave(object sender, EventArgs e)
      {
         if (usernameTextBox.Text == "")
         {
            usernameTextBox.ForeColor = DesignColors.Text;
            usernameTextBox.Text = "Username";
         }
      }

      private void PasswordTextBox_Leave(object sender, EventArgs e)
      {
         if (PasswordTextBox.Text == "")
         {
            PasswordTextBox.ForeColor = DesignColors.Text;
            PasswordTextBox.Text = "Password";
         }
      }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
