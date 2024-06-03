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
        public Manager_Form()
        {
            // start invisible manager form
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ShowInTaskbar = false;
            Visible = false;            
            InitializeComponent();

            var form2 = new SplashScreen_Form();
            form2.Show();
        }
    }
}
