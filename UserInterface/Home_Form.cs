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

            _normalRun = normalRun;

            AdjustFont(lblCurPatientName, lblCurPatientName.Font.Size);
        }


        private void AdjustFont(Control control, float baseFontSize)
        {
            using (Graphics g = control.CreateGraphics())
            {
                float dpi = g.DpiX;
                float scaleFactor = dpi / 125.0f; // 96 ist die Standard-DPI in Windows
                control.Font = new Font(control.Font.FontFamily, baseFontSize / scaleFactor, control.Font.Style);
            }

            //foreach (Control childControl in control.Controls)
            //{
            //    AdjustFont(childControl, baseFontSize);
            //}
        }


        private void btnMssgAllContacts_Click(object sender, EventArgs e)
        {
            var formSendMail = new SendMail_Form();
            formSendMail.ShowDialog();
        }

        private void btnSelectDiffPatient_Click(object sender, EventArgs e)
        {
            var formSelectDiffPatient = new SelectDiffPatient_Form();
            formSelectDiffPatient.ShowDialog();
            Update_lblCurPatientName();
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

        public void Update_lblLoggingName()
        {
            lblLoginName.Text = "You are logged in as " + Backend.Instance().GetProfile();
        }

        public void Update_lblCurPatientName()
        {
            lblCurPatientName.Text = Backend.Instance().GetProfile().GetPatient() + "'s Health Data";
        }
    }
}
