using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SuperMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            timer1.Start();

            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin x = new Admin();
            this.Hide();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier x = new Cashier();
            this.Hide();
            x.Show();
        }

        private void Form1Closing_click(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;
            this.label1.Text = x.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
