using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp1
{
    public partial class Form1 : Form
    {

        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            titleLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void titleLbl_Click(object sender, EventArgs e)
        {
            titleLbl.ForeColor = Color.Red;
            timer.Stop();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            titleLbl.ForeColor = Color.White;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"X : {e.Location.X}   Y : {e.Location.Y}");
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.AntiqueWhite;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.SpringGreen;
            }
        }
    }
}
