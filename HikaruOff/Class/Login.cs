using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HikaruOff.BUS;

namespace HikaruOff.Class
{
    class Login
    {
        //Khởi tạo các biến lưu trữ và kết nối.
        DataProvider cls = new DataProvider();

        //Hàm xử lý đăng nhập và lưu giá trị
        public bool DangNhap(string email, string password, LoginBUS log)
        {
            string select = "SELECT * ",
                from = "FROM UserTbl ",
                where = "WHERE UserEmail = @uEmail and UserPassword = @uPassword";
            SqlCommand cmd = new SqlCommand(select + from + where);

            cmd.Parameters.Add("uEmail", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("uPassword", SqlDbType.VarChar).Value = password;

            DataSet ds = cls.LayDuLieu(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                log.UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["UserId"]);
                log.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                log.UserEmail = ds.Tables[0].Rows[0]["UserEmail"].ToString();
                log.UserOffice = ds.Tables[0].Rows[0]["UserOffice"].ToString();
                return true;
            }

            return false;
        }

        public int DoiMatKhau(string password, string email)
        {
            string update = "UPDATE UserTbl ",
                set = "SET UserPassword = @uPassword ",
                where = "WHERE UserEmail = @uEmail";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("uEmail", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("uPassword", SqlDbType.VarChar).Value = password;

            return cls.CapNhatDL(cmd);
        }

        public bool XacThuc(int phone, string email)
        {

            string select = "SELECT * ",
                from = "FROM UserTbl ",
                where = "WHERE UserPhone = @uPhone AND UserEmail = @uEmail";
            SqlCommand cmd = new SqlCommand(select + from + where);

            cmd.Parameters.Add("uEmail", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("uPhone", SqlDbType.Int).Value = phone;

            return cls.KiemTra(cmd);
        }
    }
}
