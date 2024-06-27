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
    public partial class Home_Form : Form
    {
        private bool _normalRun;

        public Home_Form(bool normalRun)
        {
            InitializeComponent();
            _normalRun = normalRun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_normalRun)
            {
                this.Hide();
            }            

        }
    }
}
