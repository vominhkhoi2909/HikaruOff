using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class Customer
    {
        //Khởi tạo các biến giá trị.
        int _customerId, _customerPhone;
        string _customerName, _customerEmail, _customerGender;
        DateTime _customerBirthDay;

        //Khởi tạo mặc định.
        public Customer()
        {

        }

        //Hàm xử lý getter, setter.
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string CustomerEmail { get => _customerEmail; set => _customerEmail = value; }
        public string CustomerGender { get => _customerGender; set => _customerGender = value; }
        public DateTime CustomerBirthDay { get => _customerBirthDay; set => _customerBirthDay = value; }
        public int CustomerPhone { get => _customerPhone; set => _customerPhone = value; }
    }
}
