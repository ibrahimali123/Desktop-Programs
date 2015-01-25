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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SuperMarket
{
    public partial class Bills : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLSERVER;Database=Super_Market;trusted_connection=True");
        public Bills()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier x = new Cashier();
            this.Hide();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q;
            q = Convert.ToInt32(textBox1.Text);
            q = Int32.Parse(textBox1.Text);

            double s;
            s = Convert.ToDouble(textBox3.Text);
            s = double.Parse(textBox3.Text); 

            try
            {
                con.Open();
                SqlCommand insert = new SqlCommand(@"insert into Bills values ('" +
                    q + "','" + textBox2.Text + "','" + s + "','" + textBox4.Text + "')", con);
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

        private void Bills_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = "Welcome Customer ... \n\n" + "Qantity        : " + textBox1.Text + "\n" + "Product       : " + textBox2.Text + "\n" +
                "Total Salary : " + textBox3.Text + "\n" + "Date           : " + textBox2.Text + "\n";
            Document myDocument = new Document(iTextSharp.text.PageSize.LETTER,20,20,42,35);
            PdfWriter wri = PdfWriter.GetInstance(myDocument, new FileStream("Bill.pdf", FileMode.Truncate));
            myDocument.Open();
            Paragraph myparagraph = new Paragraph(s);
            myDocument.Add(myparagraph);
            myDocument.Close();
        }
    }
}
