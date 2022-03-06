using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class Sale
    {
        //Khởi tạo các biến giá trị.
        int _saleNum, _saleCustomer, _saleUser, _saleAmount;
        DateTime _saleDate;

        //Khởi tạo mặc định.
        public Sale()
        {

        }

        //Hàm xử lý getter, setter.
        public int SaleNum { get => _saleNum; set => _saleNum = value; }
        public int SaleCustomer { get => _saleCustomer; set => _saleCustomer = value; }
        public int SaleUser { get => _saleUser; set => _saleUser = value; }
        public int SaleAmount { get => _saleAmount; set => _saleAmount = value; }
        public DateTime SaleDate { get => _saleDate; set => _saleDate = value; }
    }
}
