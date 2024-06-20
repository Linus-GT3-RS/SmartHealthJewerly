﻿using Microsoft.SqlServer.Server;
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
using System.Drawing.Drawing2D;

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

        private bool _closeIfDone;

        public SplashScreen_Form(bool closeIfDone)
        {
            _randNumbGen = new Random();
            _closeIfDone = closeIfDone;

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            circProgressBar.Value = 0;
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

                if(_closeIfDone)
                {
                    this.Close();
                }
                else
                {
                    this.Hide();
                }
                             
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        // idk what this does but it prevents the form corners / edges from bugging out weirdly
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 32;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
            }

            base.OnPaint(e);
        }
    }
}
