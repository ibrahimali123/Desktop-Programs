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
    public partial class Buy : Form
    {
        
        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        { 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s;
            s = Convert.ToDouble(textBox2.Text);
            s = double.Parse(textBox2.Text);
            SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
            try
            {

                con.Open();
                SqlCommand insert = new SqlCommand(@"insert into Buy values ('" +
                    textBox1.Text + "','" + textBox3.Text + "','" + s + "','" + textBox4.Text + "')", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Successfully x = new Login_Successfully();
            this.Hide();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
            try
            {
            con.Open();
            SqlCommand com = new SqlCommand(@"SELECT SUM(ProductSalary) from Buy", con);
            SqlDataReader DR1 = com.ExecuteReader();
            if (DR1.Read())
            {
                String name = DR1.GetValue(0).ToString();
                MessageBox.Show( name);
            }

            con.Close();
            }
            catch 
            {
                MessageBox.Show("there is error"); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
            try
            {  
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(@"select * from Buy", con); 
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuyReport x = new BuyReport();
            this.Hide();
            x.Show();
        }
    }
}
