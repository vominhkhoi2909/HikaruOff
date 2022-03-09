using System.Data;
using System.Data.SqlClient;
using HikaruOff.Class;
using System;

namespace HikaruOff.DataLayer
{
    class UserData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT UserId ",
                from = "FROM UserTbl ",
                orderBy = "ORDER BY UserId DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm lấy danh sách.
        public DataSet PullListUser()
        {
            string select = "SELECT * ",
                from = "FROM UserTbl ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }

        //Hàm kiểm tra tên đã tồn tại chưa.
        public bool CheckUserName(string uName)
        {
            string select = "SELECT * ",
                from = "FROM UserTbl ",
                where = "WHERE UserName = N'" + uName + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm kiểm tra email đã tồn tại chưa.
        public bool CheckUserEmail(string uEmail)
        {
            string select = "SELECT * ",
                from = "FROM UserTbl ",
                where = "WHERE UserName = N'" + uEmail + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm kiểm tra sdt đã tồn tại chưa.
        public bool CheckUserPhone(string uPhone)
        {
            string select = "SELECT * ",
                from = "FROM UserTbl ",
                where = "WHERE UserName = N'" + uPhone + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý thêm mới.
        public int AddUser(string uName, string uEmail, DateTime uBirthDay, string uGender, string uPhone, string uPassword, string uOffice, string uNotes)
        {
            string insertInto = "INSERT INTO UserTbl(UserName, UserEmail, UserBirthDay, UserGender, UserPhone, UserPassword, UserOffice, UserNotes) ",
                values = "VALUES (@uName, @uEmail, @uBirthDay, @uGender, @uPhone, @uPassword, @uOffice, @uNotes)";
            SqlCommand cmd = new SqlCommand(insertInto + values);

            cmd.Parameters.Add("uName", SqlDbType.NVarChar).Value = uName;
            cmd.Parameters.Add("uEmail", SqlDbType.VarChar).Value = uEmail;
            cmd.Parameters.Add("uBirthDay", SqlDbType.DateTime).Value = uBirthDay;
            cmd.Parameters.Add("uGender", SqlDbType.NVarChar).Value = uGender;
            cmd.Parameters.Add("uPhone", SqlDbType.VarChar).Value = uPhone;
            cmd.Parameters.Add("uPassword", SqlDbType.VarChar).Value = uPassword;
            cmd.Parameters.Add("uOffice", SqlDbType.VarChar).Value = uOffice;
            cmd.Parameters.Add("uNotes", SqlDbType.NVarChar).Value = uNotes;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa.
        public int DeleteUser(int uId)
        {
            string deleteFrom = "DELETE FROM UserTbl ",
                where = "WHERE UserId = @uId";
            SqlCommand cmd = new SqlCommand(deleteFrom + where);

            cmd.Parameters.Add("uId", SqlDbType.Int).Value = uId;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int UpdateUser(int uId, string uName, string uEmail, DateTime uBirthDay, string uGender, string uPhone, string uPassword, string uOffice, string uNotes)
        {
            string update = "UPDATE UserTbl ",
                set = "SET UserName = @uName, UserEmail = @uEmail, UserBirthDay = @uBirthDay, UserGender = @uGender, UserPhone = @uPhone, UserPassword = @uPassword, UserOffice = @uOffice, UserNotes = @uNotes ",
                where = "WHERE UserId = @uId";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("uId", SqlDbType.Int).Value = uId;
            cmd.Parameters.Add("uName", SqlDbType.NVarChar).Value = uName;
            cmd.Parameters.Add("uEmail", SqlDbType.VarChar).Value = uEmail;
            cmd.Parameters.Add("uBirthDay", SqlDbType.DateTime).Value = uBirthDay;
            cmd.Parameters.Add("uGender", SqlDbType.NVarChar).Value = uGender;
            cmd.Parameters.Add("uPhone", SqlDbType.VarChar).Value = uPhone;
            cmd.Parameters.Add("uPassword", SqlDbType.VarChar).Value = uPassword;
            cmd.Parameters.Add("uOffice", SqlDbType.VarChar).Value = uOffice;
            cmd.Parameters.Add("uNotes", SqlDbType.NVarChar).Value = uNotes;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet SearchUser(string key)
        {
            string select = "SELECT * ",
                from = "FROM UserTbl ",
                where = "WHERE UserName like N'%" + key + "%' OR UserId like '%" + key + "%' OR UserPhone like '%" + key + "%'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
