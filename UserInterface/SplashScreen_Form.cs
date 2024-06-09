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
using System.Runtime.InteropServices;

namespace UserInterface
{
    public partial class SplashScreen_Form : Form
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




        private Random _randNumbGen;

        public SplashScreen_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 32, 32));

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

                //this.Hide();                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
