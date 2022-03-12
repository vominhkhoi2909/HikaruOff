using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HikaruOff.Controller;
using HikaruOff.BUS;

namespace HikaruOff
{
    public partial class UC_Dashboard : UserControl
    {
        ItemCtrl item = new ItemCtrl();
        CustomerCtrl customer = new CustomerCtrl();
        SaleCtrl sale = new SaleCtrl();

        public UC_Dashboard()
        {
            InitializeComponent();
            refresh();
        }

        //Hàm hỗ trợ.
        //Hàm làm lại form.
        private void refresh()
        {
            lbl_NumProduct.Text = item.Count().ToString() + " Items";
            lbl_NumCustomer.Text = customer.Count().ToString() + " People";
            lbl_NumSale.Text = sale.Count().ToString() + " Bill";
            lbl_SaleTotal.Text = sale.Sum().ToString() + "đ";
            showChart();
        }

        private void showChart()
        {
            DataTable dt = new DataTable();
            dt = sale.PullListDt();
            List<double> data = new List<double>();
            List<string> label = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                //MessageBox.Show(dr["SaleDate"].ToString() + dr["SaleAmount"].ToString());
                cht_Dashboard.Series["SaleCurve"].Points.AddXY(dr["SaleDate"].ToString(), dr["SaleAmount"]);
            }
        }

    }
}
