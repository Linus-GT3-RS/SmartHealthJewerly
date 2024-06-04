using Microsoft.SqlServer.Server;
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
    public partial class SplashScreen_Form : Form
    {
        private Random _randNumbGen;

        public SplashScreen_Form()
        {
            InitializeComponent();

            circProgressBar.Value = 0;
            _randNumbGen = new Random();
        }

        private void SplashScreen_Form_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nextVal = circProgressBar.Value + _randNumbGen.Next(2, 10);

            if (nextVal > 100)
            { 
                nextVal = 100;
            }

            circProgressBar.Value = nextVal;
            circProgressBar.Text = circProgressBar.Value.ToString() + "%";

            if(circProgressBar.Value == 100)
            {
                timer1.Enabled = false;

                this.Hide();                
            }
        }
    }
}
