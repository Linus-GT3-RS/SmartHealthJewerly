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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UserInterface
{
    public partial class LogIn_Form : Form
    {
        ProfileChangements _profileChangements;

        public event EventHandler OnLoginSucces;

        public LogIn_Form()
        {
            InitializeComponent(); 
            _profileChangements = new ProfileChangements();
        }


      //check if textboxes are empty
      private bool checkTextBoxes()
      {
         bool isFine = true;
         //"email" == empty
         if (emailTextBox.Text == "e-mail" || emailTextBox.Text == "" || emailTextBox.Text == "fill field" || emailTextBox.Text == "e-mail already used" || emailTextBox.Text == "no user with this e-mail")
         {
            emailTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            emailTextBox.ForeColor = System.Drawing.Color.Red;
            emailTextBox.Text = "fill field";
            isFine = false;
         }
         //"password" == empty
         if (PasswordTextBox.Text == "password" || PasswordTextBox.Text == "" || PasswordTextBox.Text == "fill field" || PasswordTextBox.Text == "wrong password")
         {
            PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            PasswordTextBox.ForeColor = System.Drawing.Color.Red;
            PasswordTextBox.Text = "fill field";
            isFine = false;
         }
         return isFine;
      }

      private void LoginButton_Click(object sender, EventArgs e)
      {
         if (checkTextBoxes())
         {
            string email = emailTextBox.Text;
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
               PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
               PasswordTextBox.ForeColor = System.Drawing.Color.Red;
               PasswordTextBox.Text = "wrong password";
            }
            else       //email nicht vorhanden
            {               
               emailTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
               emailTextBox.ForeColor = System.Drawing.Color.Red;
               emailTextBox.Text = "no user with this e-mail";
            }
         }
      }

      private void labelSignIn_Click(object sender, EventArgs e)
      {
         if (checkTextBoxes())
         {
            //get strings
            string email = emailTextBox.Text;
            string password = PasswordTextBox.Text;
            //sign in erfolgreich?
           if (_profileChangements.SignIn(email, password))
           {
               //sign in erfolgreich
               this.Close(); //form schließen
           }
           else
           {
               //email wird schon genutzt
               emailTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
               emailTextBox.ForeColor = System.Drawing.Color.Red;
               emailTextBox.Text = "e-mail already used";
           }
         }
      }



      //events
      private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
      {
         PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular);
         PasswordTextBox.ForeColor = System.Drawing.Color.Black;
         PasswordTextBox.Text = "";
      }

      private void emailTextBox_MouseClick(object sender, MouseEventArgs e)
      {
         emailTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular);
         emailTextBox.ForeColor = System.Drawing.Color.Black;
         emailTextBox.Text = "";
      }

      private void emailTextBox_Leave(object sender, EventArgs e)
      {
         if (emailTextBox.Text == "")
         {
            emailTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            emailTextBox.ForeColor = System.Drawing.Color.LightGray;
            emailTextBox.Text = "e-mail";
         }
      }

      private void PasswordTextBox_Leave(object sender, EventArgs e)
      {
         if (PasswordTextBox.Text == "")
         {
            PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            PasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
            PasswordTextBox.Text = "password";
         }
      }

   }
}
