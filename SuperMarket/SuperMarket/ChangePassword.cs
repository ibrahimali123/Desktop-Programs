using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace SuperMarket
{
    public partial class ChangePassword : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader x = new StreamReader("admin.txt");
            String AdminID = x.ReadToEnd(); 
            x.Close(); 
            String password = textBox1.Text;
            String AdminPass = "";
            try
            {

                con.Open();
                SqlCommand com = new SqlCommand(@"SELECT adminPassword from Admin_info where adminID = '" + AdminID + "'", con);
                SqlDataReader DR1 = com.ExecuteReader();
                if (DR1.Read())
                {
                    AdminPass = DR1.GetValue(0).ToString();
                    if (AdminPass == password)
                    { 
                        fun(AdminID);
                    }
                    else
                    {
                         
                        label3.Text = "error in Current Password";
                    }
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("There is error Somewhere");
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
        private void fun(String AdminID)
        {
            String x = textBox2.Text;
            try
            {
                SqlConnection conn = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
                conn.Open(); 
                string sql = "update Admin_info set adminPassword ='" + x +
                 "'where adminID ='" + AdminID + "'"; 
                        SqlCommand Update = new SqlCommand(sql, conn);
                        Update.ExecuteNonQuery();
                        MessageBox.Show("Saved Sucessfully");
                   
                conn.Close();
            }
            catch
            {
                MessageBox.Show("There is error");
            }
        }

        private void form_close(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Successfully ob = new Login_Successfully();
            this.Hide();
            ob.Show();
        }
    }
}
