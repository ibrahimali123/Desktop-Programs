using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace SuperMarket
{
    public partial class Login_Successfully : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public Login_Successfully()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void form_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void s(object sender, EventArgs e)
        {
            StreamReader x = new StreamReader("admin.txt");
            String name = x.ReadToEnd();
            textBox2.Text = name;
            x.Close();
             
            con.Open();
            SqlCommand com = new SqlCommand(@"SELECT adminName from Admin_info where adminID = '" + name + "'", con);
            SqlDataReader DR1 = com.ExecuteReader();
            if (DR1.Read())
            {
                  name = DR1.GetValue(0).ToString();
                  textBox1.Text = name;
            }

            con.Close(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;
            this.textBox3.Text = x.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangePassword x = new ChangePassword();
            this.Hide();
            x.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin x = new Admin();
            this.Hide();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_New_Admin x = new Create_New_Admin();
            this.Hide();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_New_Cashier x = new Create_New_Cashier();
            this.Hide();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Admin x = new Delete_Admin();
            this.Hide();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_Cashier x = new Delete_Cashier();
            this.Hide();
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            The_Report x = new The_Report();
            this.Hide();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buy x = new Buy();
            this.Hide();
            x.Show();
        }
    }
}
