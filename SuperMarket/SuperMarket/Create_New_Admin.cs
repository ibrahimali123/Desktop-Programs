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
namespace SuperMarket
{
    public partial class Create_New_Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public Create_New_Admin()
        {
            InitializeComponent();
        }

        private void Create_New_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Successfully x = new Login_Successfully();
            this.Hide();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                con.Open();
                SqlCommand insert = new SqlCommand(@"insert into Admin_info values ('" +
                    textBox1.Text  + "','"   + textBox3.Text + "','" + textBox2.Text + "')", con);
                insert.ExecuteNonQuery();
                MessageBox.Show("Your Data Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
