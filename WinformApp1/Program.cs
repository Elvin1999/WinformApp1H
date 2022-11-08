using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp1
{
    internal static class Program
    {
        static DialogResult GetDialogResult()
        {
            DialogResult result;
            string message = "Window displaying a text message";
            string caption = "C# Language";
            //result=MessageBox.Show(message,caption,MessageBoxButtons.YesNo);
            result=MessageBox.Show(message,caption,MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);

            return result;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //var result = GetDialogResult();
            //if (result == DialogResult.Abort)
            //{
            //    MessageBox.Show("Abort");
            //}
            //else if (result == DialogResult.Retry)
            //{
            //    MessageBox.Show("Retry");
            //}
            //else
            //{
            //    MessageBox.Show("Ignore");
            //}

            //var result=GetDialogResult();
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("OK");
            //}
            //else
            //{
            //    MessageBox.Show("No");
            //}

        }
    }
}
