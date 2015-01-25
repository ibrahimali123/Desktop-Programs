using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class BuyReport : Form
    {
        public BuyReport()
        {
            InitializeComponent();
        }

        private void BuyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Super_MarketDataSet.Buy' table. You can move, or remove it, as needed.
            this.BuyTableAdapter.Fill(this.Super_MarketDataSet.Buy);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Successfully x = new Login_Successfully();
            this.Hide();
            x.Show();
        }
    }
}
