namespace SuperMarket
{
    partial class The_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.super_MarketDataSet1 = new SuperMarket.Super_MarketDataSet1();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsTableAdapter = new SuperMarket.Super_MarketDataSet1TableAdapters.BillsTableAdapter();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billsDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantityDataGridViewTextBoxColumn,
            this.billsNameDataGridViewTextBoxColumn,
            this.totalSalaryDataGridViewTextBoxColumn,
            this.billsDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SuperMarket.Properties.Resources.go_back_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 89);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(416, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // super_MarketDataSet1
            // 
            this.super_MarketDataSet1.DataSetName = "Super_MarketDataSet1";
            this.super_MarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "Bills";
            this.billsBindingSource.DataSource = this.super_MarketDataSet1;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // billsNameDataGridViewTextBoxColumn
            // 
            this.billsNameDataGridViewTextBoxColumn.DataPropertyName = "BillsName";
            this.billsNameDataGridViewTextBoxColumn.HeaderText = "BillsName";
            this.billsNameDataGridViewTextBoxColumn.Name = "billsNameDataGridViewTextBoxColumn";
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "TotalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            // 
            // billsDateDataGridViewTextBoxColumn
            // 
            this.billsDateDataGridViewTextBoxColumn.DataPropertyName = "BillsDate";
            this.billsDateDataGridViewTextBoxColumn.HeaderText = "BillsDate";
            this.billsDateDataGridViewTextBoxColumn.Name = "billsDateDataGridViewTextBoxColumn";
            // 
            // The_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "The_Report";
            this.Text = "The_Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.Load += new System.EventHandler(this.The_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Super_MarketDataSet1 super_MarketDataSet1;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private Super_MarketDataSet1TableAdapters.BillsTableAdapter billsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billsDateDataGridViewTextBoxColumn;
    }
}