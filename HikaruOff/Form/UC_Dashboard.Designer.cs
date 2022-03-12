
namespace HikaruOff
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.ele_UC_Dashboard = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cht_Dashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Product = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_NumProduct = new System.Windows.Forms.Label();
            this.pic_Item = new System.Windows.Forms.PictureBox();
            this.lbl_ProductsStock = new System.Windows.Forms.Label();
            this.pnl_Sale = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_SaleTotal = new System.Windows.Forms.Label();
            this.lbl_NumSale = new System.Windows.Forms.Label();
            this.pic_Bill = new System.Windows.Forms.PictureBox();
            this.lbl_Sale = new System.Windows.Forms.Label();
            this.pnl_Customer = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_NumCustomer = new System.Windows.Forms.Label();
            this.pic_Customer = new System.Windows.Forms.PictureBox();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.lbl_ShopAnalytics = new System.Windows.Forms.Label();
            this.ele_Product = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ele_Customer = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ele_Sale = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Month = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Year = new Guna.UI2.WinForms.Guna2Button();
            this.dtm_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtm_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Fill = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Day = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_GoTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Dashboard)).BeginInit();
            this.pnl_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.pnl_Sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bill)).BeginInit();
            this.pnl_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // ele_UC_Dashboard
            // 
            this.ele_UC_Dashboard.BorderRadius = 26;
            this.ele_UC_Dashboard.TargetControl = this;
            // 
            // cht_Dashboard
            // 
            chartArea1.Name = "ChartArea1";
            this.cht_Dashboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cht_Dashboard.Legends.Add(legend1);
            this.cht_Dashboard.Location = new System.Drawing.Point(10, 330);
            this.cht_Dashboard.Name = "cht_Dashboard";
            this.cht_Dashboard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SaleDate";
            series1.YValuesPerPoint = 2;
            this.cht_Dashboard.Series.Add(series1);
            this.cht_Dashboard.Size = new System.Drawing.Size(1001, 677);
            this.cht_Dashboard.TabIndex = 0;
            this.cht_Dashboard.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "title_Sale";
            title1.Text = "Sale Curve";
            this.cht_Dashboard.Titles.Add(title1);
            // 
            // pnl_Product
            // 
            this.pnl_Product.BackColor = System.Drawing.Color.Silver;
            this.pnl_Product.Controls.Add(this.lbl_NumProduct);
            this.pnl_Product.Controls.Add(this.pic_Item);
            this.pnl_Product.Controls.Add(this.lbl_ProductsStock);
            this.pnl_Product.Location = new System.Drawing.Point(11, 58);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.Size = new System.Drawing.Size(287, 160);
            this.pnl_Product.TabIndex = 2;
            // 
            // lbl_NumProduct
            // 
            this.lbl_NumProduct.AutoSize = true;
            this.lbl_NumProduct.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumProduct.Location = new System.Drawing.Point(77, 63);
            this.lbl_NumProduct.Name = "lbl_NumProduct";
            this.lbl_NumProduct.Size = new System.Drawing.Size(76, 32);
            this.lbl_NumProduct.TabIndex = 35;
            this.lbl_NumProduct.Text = "Num";
            // 
            // pic_Item
            // 
            this.pic_Item.Image = ((System.Drawing.Image)(resources.GetObject("pic_Item.Image")));
            this.pic_Item.Location = new System.Drawing.Point(21, 63);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(50, 50);
            this.pic_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Item.TabIndex = 34;
            this.pic_Item.TabStop = false;
            // 
            // lbl_ProductsStock
            // 
            this.lbl_ProductsStock.AutoSize = true;
            this.lbl_ProductsStock.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductsStock.Location = new System.Drawing.Point(42, 11);
            this.lbl_ProductsStock.Name = "lbl_ProductsStock";
            this.lbl_ProductsStock.Size = new System.Drawing.Size(200, 32);
            this.lbl_ProductsStock.TabIndex = 5;
            this.lbl_ProductsStock.Text = "Products Stock";
            // 
            // pnl_Sale
            // 
            this.pnl_Sale.BackColor = System.Drawing.Color.Tomato;
            this.pnl_Sale.Controls.Add(this.lbl_SaleTotal);
            this.pnl_Sale.Controls.Add(this.lbl_NumSale);
            this.pnl_Sale.Controls.Add(this.pic_Bill);
            this.pnl_Sale.Controls.Add(this.lbl_Sale);
            this.pnl_Sale.Location = new System.Drawing.Point(374, 58);
            this.pnl_Sale.Name = "pnl_Sale";
            this.pnl_Sale.Size = new System.Drawing.Size(287, 160);
            this.pnl_Sale.TabIndex = 3;
            // 
            // lbl_SaleTotal
            // 
            this.lbl_SaleTotal.AutoSize = true;
            this.lbl_SaleTotal.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleTotal.Location = new System.Drawing.Point(77, 95);
            this.lbl_SaleTotal.Name = "lbl_SaleTotal";
            this.lbl_SaleTotal.Size = new System.Drawing.Size(79, 32);
            this.lbl_SaleTotal.TabIndex = 38;
            this.lbl_SaleTotal.Text = "Total";
            // 
            // lbl_NumSale
            // 
            this.lbl_NumSale.AutoSize = true;
            this.lbl_NumSale.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumSale.Location = new System.Drawing.Point(77, 63);
            this.lbl_NumSale.Name = "lbl_NumSale";
            this.lbl_NumSale.Size = new System.Drawing.Size(76, 32);
            this.lbl_NumSale.TabIndex = 37;
            this.lbl_NumSale.Text = "Num";
            // 
            // pic_Bill
            // 
            this.pic_Bill.Image = ((System.Drawing.Image)(resources.GetObject("pic_Bill.Image")));
            this.pic_Bill.Location = new System.Drawing.Point(21, 63);
            this.pic_Bill.Name = "pic_Bill";
            this.pic_Bill.Size = new System.Drawing.Size(50, 50);
            this.pic_Bill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Bill.TabIndex = 36;
            this.pic_Bill.TabStop = false;
            // 
            // lbl_Sale
            // 
            this.lbl_Sale.AutoSize = true;
            this.lbl_Sale.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale.Location = new System.Drawing.Point(114, 11);
            this.lbl_Sale.Name = "lbl_Sale";
            this.lbl_Sale.Size = new System.Drawing.Size(66, 32);
            this.lbl_Sale.TabIndex = 7;
            this.lbl_Sale.Text = "Sale";
            // 
            // pnl_Customer
            // 
            this.pnl_Customer.BackColor = System.Drawing.Color.PaleGreen;
            this.pnl_Customer.Controls.Add(this.lbl_NumCustomer);
            this.pnl_Customer.Controls.Add(this.pic_Customer);
            this.pnl_Customer.Controls.Add(this.lbl_Customer);
            this.pnl_Customer.Location = new System.Drawing.Point(725, 58);
            this.pnl_Customer.Name = "pnl_Customer";
            this.pnl_Customer.Size = new System.Drawing.Size(287, 160);
            this.pnl_Customer.TabIndex = 3;
            // 
            // lbl_NumCustomer
            // 
            this.lbl_NumCustomer.AutoSize = true;
            this.lbl_NumCustomer.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumCustomer.Location = new System.Drawing.Point(79, 63);
            this.lbl_NumCustomer.Name = "lbl_NumCustomer";
            this.lbl_NumCustomer.Size = new System.Drawing.Size(76, 32);
            this.lbl_NumCustomer.TabIndex = 36;
            this.lbl_NumCustomer.Text = "Num";
            // 
            // pic_Customer
            // 
            this.pic_Customer.Image = ((System.Drawing.Image)(resources.GetObject("pic_Customer.Image")));
            this.pic_Customer.Location = new System.Drawing.Point(23, 63);
            this.pic_Customer.Name = "pic_Customer";
            this.pic_Customer.Size = new System.Drawing.Size(50, 50);
            this.pic_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Customer.TabIndex = 35;
            this.pic_Customer.TabStop = false;
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(84, 11);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(136, 32);
            this.lbl_Customer.TabIndex = 6;
            this.lbl_Customer.Text = "Customer";
            // 
            // lbl_ShopAnalytics
            // 
            this.lbl_ShopAnalytics.AutoSize = true;
            this.lbl_ShopAnalytics.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShopAnalytics.Location = new System.Drawing.Point(397, 15);
            this.lbl_ShopAnalytics.Name = "lbl_ShopAnalytics";
            this.lbl_ShopAnalytics.Size = new System.Drawing.Size(240, 40);
            this.lbl_ShopAnalytics.TabIndex = 5;
            this.lbl_ShopAnalytics.Text = "Shop Analytics";
            // 
            // ele_Product
            // 
            this.ele_Product.BorderRadius = 20;
            this.ele_Product.TargetControl = this.pnl_Product;
            // 
            // ele_Customer
            // 
            this.ele_Customer.BorderRadius = 20;
            this.ele_Customer.TargetControl = this.pnl_Customer;
            // 
            // ele_Sale
            // 
            this.ele_Sale.BorderRadius = 20;
            this.ele_Sale.TargetControl = this.pnl_Sale;
            // 
            // btn_Month
            // 
            this.btn_Month.AutoRoundedCorners = true;
            this.btn_Month.BorderRadius = 25;
            this.btn_Month.BorderThickness = 1;
            this.btn_Month.DefaultAutoSize = true;
            this.btn_Month.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Month.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Month.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Month.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Month.FillColor = System.Drawing.Color.White;
            this.btn_Month.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Month.ForeColor = System.Drawing.Color.Black;
            this.btn_Month.Location = new System.Drawing.Point(116, 271);
            this.btn_Month.Name = "btn_Month";
            this.btn_Month.Size = new System.Drawing.Size(141, 53);
            this.btn_Month.TabIndex = 99;
            this.btn_Month.Text = "Month";
            this.btn_Month.Click += new System.EventHandler(this.btn_Month_Click);
            // 
            // btn_Year
            // 
            this.btn_Year.AutoRoundedCorners = true;
            this.btn_Year.BorderRadius = 25;
            this.btn_Year.BorderThickness = 1;
            this.btn_Year.DefaultAutoSize = true;
            this.btn_Year.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Year.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Year.FillColor = System.Drawing.Color.White;
            this.btn_Year.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Year.ForeColor = System.Drawing.Color.Black;
            this.btn_Year.Location = new System.Drawing.Point(263, 271);
            this.btn_Year.Name = "btn_Year";
            this.btn_Year.Size = new System.Drawing.Size(113, 53);
            this.btn_Year.TabIndex = 100;
            this.btn_Year.Text = "Year";
            this.btn_Year.Click += new System.EventHandler(this.btn_Year_Click);
            // 
            // dtm_From
            // 
            this.dtm_From.AutoRoundedCorners = true;
            this.dtm_From.BorderRadius = 25;
            this.dtm_From.Checked = true;
            this.dtm_From.FillColor = System.Drawing.Color.White;
            this.dtm_From.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.dtm_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_From.Location = new System.Drawing.Point(459, 271);
            this.dtm_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtm_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtm_From.Name = "dtm_From";
            this.dtm_From.Size = new System.Drawing.Size(194, 53);
            this.dtm_From.TabIndex = 137;
            this.dtm_From.Value = new System.DateTime(2022, 2, 22, 22, 31, 13, 10);
            // 
            // dtm_To
            // 
            this.dtm_To.AutoRoundedCorners = true;
            this.dtm_To.BorderRadius = 25;
            this.dtm_To.Checked = true;
            this.dtm_To.FillColor = System.Drawing.Color.White;
            this.dtm_To.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.dtm_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_To.Location = new System.Drawing.Point(722, 271);
            this.dtm_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtm_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtm_To.Name = "dtm_To";
            this.dtm_To.Size = new System.Drawing.Size(194, 53);
            this.dtm_To.TabIndex = 138;
            this.dtm_To.Value = new System.DateTime(2022, 2, 22, 22, 31, 13, 10);
            // 
            // btn_Fill
            // 
            this.btn_Fill.AutoRoundedCorners = true;
            this.btn_Fill.BorderRadius = 25;
            this.btn_Fill.BorderThickness = 1;
            this.btn_Fill.DefaultAutoSize = true;
            this.btn_Fill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Fill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Fill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Fill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Fill.FillColor = System.Drawing.Color.White;
            this.btn_Fill.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Fill.ForeColor = System.Drawing.Color.Black;
            this.btn_Fill.Location = new System.Drawing.Point(922, 271);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(89, 53);
            this.btn_Fill.TabIndex = 139;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Day
            // 
            this.btn_Day.AutoRoundedCorners = true;
            this.btn_Day.BorderRadius = 25;
            this.btn_Day.BorderThickness = 1;
            this.btn_Day.DefaultAutoSize = true;
            this.btn_Day.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Day.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Day.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Day.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Day.FillColor = System.Drawing.Color.White;
            this.btn_Day.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Day.ForeColor = System.Drawing.Color.Black;
            this.btn_Day.Location = new System.Drawing.Point(11, 271);
            this.btn_Day.Name = "btn_Day";
            this.btn_Day.Size = new System.Drawing.Size(99, 53);
            this.btn_Day.TabIndex = 140;
            this.btn_Day.Text = "Day";
            this.btn_Day.Click += new System.EventHandler(this.btn_Day_Click);
            // 
            // lbl_GoTo
            // 
            this.lbl_GoTo.AutoSize = true;
            this.lbl_GoTo.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoTo.Location = new System.Drawing.Point(659, 276);
            this.lbl_GoTo.Name = "lbl_GoTo";
            this.lbl_GoTo.Size = new System.Drawing.Size(57, 40);
            this.lbl_GoTo.TabIndex = 141;
            this.lbl_GoTo.Text = "=>";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.lbl_GoTo);
            this.Controls.Add(this.btn_Day);
            this.Controls.Add(this.btn_Fill);
            this.Controls.Add(this.dtm_To);
            this.Controls.Add(this.dtm_From);
            this.Controls.Add(this.btn_Year);
            this.Controls.Add(this.btn_Month);
            this.Controls.Add(this.lbl_ShopAnalytics);
            this.Controls.Add(this.pnl_Customer);
            this.Controls.Add(this.pnl_Sale);
            this.Controls.Add(this.pnl_Product);
            this.Controls.Add(this.cht_Dashboard);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1023, 1024);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Dashboard)).EndInit();
            this.pnl_Product.ResumeLayout(false);
            this.pnl_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.pnl_Sale.ResumeLayout(false);
            this.pnl_Sale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bill)).EndInit();
            this.pnl_Customer.ResumeLayout(false);
            this.pnl_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_UC_Dashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Dashboard;
        private Guna.UI2.WinForms.Guna2Panel pnl_Product;
        private System.Windows.Forms.Label lbl_ShopAnalytics;
        private Guna.UI2.WinForms.Guna2Panel pnl_Customer;
        private System.Windows.Forms.Label lbl_Customer;
        private Guna.UI2.WinForms.Guna2Panel pnl_Sale;
        private System.Windows.Forms.Label lbl_Sale;
        private System.Windows.Forms.Label lbl_ProductsStock;
        private System.Windows.Forms.PictureBox pic_Customer;
        private System.Windows.Forms.PictureBox pic_Bill;
        private System.Windows.Forms.PictureBox pic_Item;
        private System.Windows.Forms.Label lbl_NumCustomer;
        private System.Windows.Forms.Label lbl_NumSale;
        private System.Windows.Forms.Label lbl_NumProduct;
        private Guna.UI2.WinForms.Guna2Elipse ele_Product;
        private Guna.UI2.WinForms.Guna2Elipse ele_Customer;
        private Guna.UI2.WinForms.Guna2Elipse ele_Sale;
        private System.Windows.Forms.Label lbl_SaleTotal;
        private Guna.UI2.WinForms.Guna2Button btn_Year;
        private Guna.UI2.WinForms.Guna2Button btn_Month;
        private System.Windows.Forms.Label lbl_GoTo;
        private Guna.UI2.WinForms.Guna2Button btn_Day;
        private Guna.UI2.WinForms.Guna2Button btn_Fill;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtm_To;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtm_From;
    }
}
