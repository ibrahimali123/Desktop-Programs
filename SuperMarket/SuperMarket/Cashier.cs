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
    public partial class Cashier : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public Cashier()
        {
            InitializeComponent();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String AdminID = textBox1.Text;
            String password = textBox2.Text;
            String AdminPass = "";
            try
            {

                con.Open();
                SqlCommand com = new SqlCommand(@"SELECT CashierPassword from Cashier_info where CashierID = '" + AdminID + "'", con);
                SqlDataReader DR1 = com.ExecuteReader();
                if (DR1.Read())
                {
                    AdminPass = DR1.GetValue(0).ToString();
                    if (AdminPass == password)
                    {
                        StreamWriter x = new StreamWriter("cash.txt");
                        x.Write(AdminID);
                        x.Close();
                        Bills obj = new Bills();
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
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            this.Hide();
            x.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Admin x = new Admin();
            this.Hide();
            x.Show();
        }
    }
}
