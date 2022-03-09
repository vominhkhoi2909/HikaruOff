using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class LoginBUS
    {
        //Khởi tạo các biến giá trị.
        int _userId;
        string _userName, _userEmail, _userOffice;

        //Khởi tạo mặc định của class.
        public LoginBUS()
        {
            this.UserId = 0;
            this.UserEmail = "vmkhoi@gmail.com";
            this.UserName = "Vo Minh Khoi";
            this.UserOffice = "Staff";
        }

        public LoginBUS(LoginBUS log)
        {
            this.UserId = log.UserId;
            this.UserEmail = log.UserEmail;
            this.UserName = log.UserName;
            this.UserOffice = log.UserOffice;
        }

        //Hàm xử lý getter, setter.
        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserEmail { get => _userEmail; set => _userEmail = value; }
        public string UserOffice { get => _userOffice; set => _userOffice = value; }

        //Hàm gán giá trị user sau khi đăng xuất.
        public void dangXuat()
        {
            this.UserId = -1;
            this.UserEmail = "";
            this.UserName = "";
            this.UserOffice = "";
        }
    }
}
