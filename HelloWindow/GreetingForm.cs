using System.IO;
using System;
using System.Windows.Forms;

namespace HelloWindow
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void Greet(object sender, EventArgs e)
        {
            //StreamWriter s = File.CreateText(@"C:\Users\Admin\Desktop\abc.txt");
            //s.Close();

            //DialogResult dr = MessageBox.Show("Yes or no", "yes or no", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)
            //{
            //    File.Delete(@"C:\Users\Admin\Desktop\abc.txt");
            //}
            //MessageBox.Show(textBox1.Text);
            MessageBox.Show("Nyan cat has entered your system, since you clicked\n\n" + ((Button) sender).Text,"YOU HAVE BEEN HACKED", MessageBoxButtons.AbortRetryIgnore ,MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
