using BackendCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendCS.Event;

namespace UserInterface
{
    public partial class Home_Form : Form
    {
        private bool _normalRun;
        public Home_Form(bool normalRun)
        {
            InitializeComponent();
            lblLoginName.Text = "You are logged in as " + "LOGINNAME_TODO";
            lblCurPatientName.Text = "PATIENTNAME_TODO" + "'s Health Data";

            _normalRun = normalRun;
        }

        private void btnMssgAllContacts_Click(object sender, EventArgs e)
        {
            var formSendMail = new SendMail_Form();
            formSendMail.ShowDialog();
        }

        private void btnSelectDiffPatient_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnViewMotionData_Click(object sender, EventArgs e)
        {
            if (_normalRun)
            {
                this.Hide();
            }
        }

        private void btnRealTimeMonitoring_Click(object sender, EventArgs e)
        {
            if (_normalRun)
            {
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
