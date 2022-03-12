using HikaruOff.DataLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HikaruOff.Controller
{
    class SaleCtrl
    {
        //Khởi tạo biến giá trị.
        SaleData saleData = new SaleData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return saleData.GetID();
        }

        //Hàm hiển thị datagridview.
        public void ShowDgv(DataGridView dgv)
        {
            dgv.DataSource = saleData.PullListSale().Tables[0];
        }

        //Hàm xử lý thêm mới.
        public int Add(int sCustomer, int sUser, int sAmount, DateTime sDate)
        {
            return saleData.AddSale(sCustomer, sUser, sAmount, sDate);
        }

        //Hàm xử lý tìm kiếm.
        public void Search(DataGridView dgv, string key)
        {
            dgv.DataSource = saleData.SearchSale(key).Tables[0];
        }

        //Hàm xử lý đếm dữ liệu.
        public int Count()
        {
            return saleData.CountSale();
        }

        //Hàm xử lý tính tổng giá trị tất cả bill.
        public int Sum()
        {
            return saleData.SumSale();
        }

        //Hàm lấy dữ liệu bảng dạng datatable.
        public DataTable PullListDt()
        {
            return saleData.PullListSaleDt();
        }
    }
}
