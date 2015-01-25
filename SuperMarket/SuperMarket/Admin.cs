using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public Admin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Admin_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;
            this.label1.Text = x.ToString();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             String AdminID = textBox1.Text;
             String password = textBox2.Text;
             String AdminPass="";
            try
             {
              
              con.Open();
              SqlCommand com = new SqlCommand(@"SELECT adminPassword from Admin_info where adminID = '" + AdminID + "'", con);
              SqlDataReader DR1 = com.ExecuteReader();
              if (DR1.Read())
              {
                   AdminPass= DR1.GetValue(0).ToString();
                   if(AdminPass==password)
                   {
                       StreamWriter x = new StreamWriter("admin.txt");
                       x.Write(AdminID);
                       x.Close();
                       Login_Successfully obj = new Login_Successfully();
                       this.Hide();
                       obj.Show();
                   }
                   else
                   {
                       label1.Hide();
                       label2.Text = "There is some thing error in the UserName or Password, retry again";
                   }
              }

              con.Close();
             }
             catch
             {
              MessageBox.Show("There is error Somewhere"); 
             }
             
            /*
            StreamReader input = new StreamReader("adminpass.txt");
            String password = input.ReadLine();
            input.Close();
            if(password==textBox2.Text)
            {
                Login_Successfully obj = new Login_Successfully();
                this.Hide();
                obj.Show();
            }
             * */
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier x = new Cashier();
            this.Hide();
            x.Show();
        }
 
    }
}
