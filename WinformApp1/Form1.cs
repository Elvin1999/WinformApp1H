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


            Label label = new Label();
            label.Text = "New Label";
            label.ForeColor = Color.Red;
            label.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);
            label.Location = new Point(10, 150);
            label.AutoSize = true;
            this.Controls.Add(label);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            titleLbl.ForeColor = Color.White;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show($"X : {e.Location.X}   Y : {e.Location.Y}");
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.AntiqueWhite;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.SpringGreen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Dispose();

            //var btn=sender as Button;
            //btn.Dispose();

            //Button button = new Button();
            //button.Text = "Click Me";
            //button.ForeColor = Color.Black;
            //button.Font = new Font("Comic Sans MS", 22, FontStyle.Italic);

            //Random random = new Random();

            //int x = random.Next(0, this.Width - 100);
            //int y = random.Next(0, this.Height - 100);

            //button.Location = new Point(x, y);
            //button.AutoSize = true;

            //button.Click += button1_Click;

            //this.Controls.Add(button);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
        }
    }
}
