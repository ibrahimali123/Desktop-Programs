namespace SuperMarket
{
    partial class BuyReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Super_MarketDataSet = new SuperMarket.Super_MarketDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BuyTableAdapter = new SuperMarket.Super_MarketDataSetTableAdapters.BuyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Super_MarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyBindingSource
            // 
            this.BuyBindingSource.DataMember = "Buy";
            this.BuyBindingSource.DataSource = this.Super_MarketDataSet;
            // 
            // Super_MarketDataSet
            // 
            this.Super_MarketDataSet.DataSetName = "Super_MarketDataSet";
            this.Super_MarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BuyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SuperMarket.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // BuyTableAdapter
            // 
            this.BuyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SuperMarket.Properties.Resources.go_back_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 73);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BuyReport";
            this.Text = "BuyReport";
            this.Load += new System.EventHandler(this.BuyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Super_MarketDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BuyBindingSource;
        private Super_MarketDataSet Super_MarketDataSet;
        private Super_MarketDataSetTableAdapters.BuyTableAdapter BuyTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}