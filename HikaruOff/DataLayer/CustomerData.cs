using System.Data;
using System.Data.SqlClient;
using HikaruOff.Class;
using System;

namespace HikaruOff.DataLayer
{
    class CustomerData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT CustomerId ",
                from = "FROM CustomerTbl ",
                orderBy = "ORDER BY CustomerId DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm lấy danh sách.
        public DataSet PullListCustomer()
        {
            string select = "SELECT * ",
                from = "FROM CustomerTbl ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.PullData(cmd);
        }

        //Hàm kiểm tra tên đã tồn tại chưa.
        public bool CheckCustomerName(string cusName)
        {
            string select = "SELECT * ",
                from = "FROM CustomerTbl ",
                where = "WHERE CustomerName = N'" + cusName + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.CheckInfo(cmd);
        }

        //Hàm kiểm tra email đã tồn tại chưa.
        public bool CheckCustomerEmail(string cusEmail)
        {
            string select = "SELECT * ",
                from = "FROM CustomerTbl ",
                where = "WHERE CustomerName = N'" + cusEmail + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.CheckInfo(cmd);
        }

        //Hàm kiểm tra sdt đã tồn tại chưa.
        public bool CheckCustomerPhone(string cusPhone)
        {
            string select = "SELECT * ",
                from = "FROM CustomerTbl ",
                where = "WHERE CustomerName = N'" + cusPhone + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.CheckInfo(cmd);
        }

        //Hàm xử lý thêm mới.
        public int AddCustomer(string cusName, string cusEmail, DateTime cusBirthDay, string cusGender, string cusPhone, string cusNotes)
        {
            string insertInto = "INSERT INTO CustomerTbl(CustomerName, CustomerEmail, CustomerBirthDay, CustomerGender, CustomerPhone, CustomerNotes) ",
                values = "VALUES (@cusName, @cusEmail, @cusBirthDay, @cusGender, @cusPhone, @cusNotes)";
            SqlCommand cmd = new SqlCommand(insertInto + values);

            cmd.Parameters.Add("cusName", SqlDbType.NVarChar).Value = cusName;
            cmd.Parameters.Add("cusEmail", SqlDbType.VarChar).Value = cusEmail;
            cmd.Parameters.Add("cusBirthDay", SqlDbType.DateTime).Value = cusBirthDay;
            cmd.Parameters.Add("cusGender", SqlDbType.NVarChar).Value = cusGender;
            cmd.Parameters.Add("cusPhone", SqlDbType.VarChar).Value = cusPhone;
            cmd.Parameters.Add("cusNotes", SqlDbType.NVarChar).Value = cusNotes;

            return cls.UpdateData(cmd);
        }

        //Hàm xử lý xóa.
        public int DeleteCustomer(int cusId)
        {
            string deleteFrom = "DELETE FROM CustomerTbl ",
                where = "WHERE CustomerId = @cusId";
            SqlCommand cmd = new SqlCommand(deleteFrom + where);

            cmd.Parameters.Add("cusId", SqlDbType.Int).Value = cusId;

            return cls.UpdateData(cmd);
        }

        //Hàm xử lý cập nhật.
        public int UpdateCustomer(int cusId, string cusName, string cusEmail, DateTime cusBirthDay, string cusGender, string cusPhone, string cusNotes)
        {
            string update = "UPDATE CustomerTbl ",
                set = "SET CustomerName = @cusName, CustomerEmail = @cusEmail, CustomerBirthDay = @cusBirthDay, CustomerGender = @cusGender, CustomerPhone = @cusPhone, CustomerNotes = @cusNotes ",
                where = "WHERE CustomerId = @cusId";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("cusId", SqlDbType.Int).Value = cusId;
            cmd.Parameters.Add("cusName", SqlDbType.NVarChar).Value = cusName;
            cmd.Parameters.Add("cusEmail", SqlDbType.VarChar).Value = cusEmail;
            cmd.Parameters.Add("cusBirthDay", SqlDbType.DateTime).Value = cusBirthDay;
            cmd.Parameters.Add("cusGender", SqlDbType.NVarChar).Value = cusGender;
            cmd.Parameters.Add("cusPhone", SqlDbType.VarChar).Value = cusPhone;
            cmd.Parameters.Add("cusNotes", SqlDbType.NVarChar).Value = cusNotes;

            return cls.UpdateData(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet SearchCustomer(string key)
        {
            string select = "SELECT * ",
                from = "FROM CustomerTbl ",
                where = "WHERE CustomerName like N'%" + key + "%' OR CustomerId like '%" + key + "%' OR CustomerPhone like '%" + key + "%'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.PullData(cmd);
        }
    }
}
