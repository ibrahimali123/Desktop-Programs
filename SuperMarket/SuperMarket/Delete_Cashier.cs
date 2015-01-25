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
    public partial class Delete_Cashier : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public Delete_Cashier()
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String Cashier_ID = textBox1.Text;
                con.Open();
                SqlCommand Delete =
                    new SqlCommand(@"delete from Cashier_info where CashierID ='"
                        + Cashier_ID + "'", con);
                Delete.ExecuteNonQuery();
                MessageBox.Show("this admin deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Successfully x = new Login_Successfully();
            this.Hide();
            x.Show();
        }
    }
}
