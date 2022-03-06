using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class User
    {
        //Khởi tạo các biến giá trị.
        int _userId, _userPhone;
        string _userName, _userEmail, _userGender, _userPassword, _userOffice;
        DateTime _userBirthDay;

        //Khởi tạo mặc định.
        public User()
        {

        }        
        
        //Hàm xử lý getter, setter.
        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserEmail { get => _userEmail; set => _userEmail = value; }
        public string UserGender { get => _userGender; set => _userGender = value; }
        public string UserPassword { get => _userPassword; set => _userPassword = value; }
        public DateTime UserBirthDay { get => _userBirthDay; set => _userBirthDay = value; }
        public string UserOffice { get => _userOffice; set => _userOffice = value; }
        public int UserPhone { get => _userPhone; set => _userPhone = value; }
    }
}
