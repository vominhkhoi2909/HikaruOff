using System;
using System.Data;
using System.Data.SqlClient;
using HikaruOff.Class;

namespace HikaruOff.DataLayer
{
    class SaleData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT SaleNum ",
                from = "FROM SaleTbl ",
                orderBy = "ORDER BY SaleNum DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm lấy danh sách dạng dataset.
        public DataSet PullListSale()
        {
            string select = "SELECT SaleNum, SaleAmount, SaleDate, CustomerName, UserName ",
                from = "FROM SaleTbl, UserTbl, CustomerTbl ",
                where = "WHERE SaleTbl.SaleUser = UserId AND SaleTbl.SaleCustomer = CustomerId";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.PullData(cmd);
        }

        //Hàm lấy danh sách Sale dạng datatable.
        public DataTable PullListSaleDt(int style, DateTime frm, DateTime to)
        {
            string select = "", from = "", where = "";
            switch (style)
            {
                //Dashboard theo day.
                case 1:
                    select = "SELECT DAY(SaleDate) as date, SUM(SaleAmount) as total ";
                    from = "FROM SaleTbl ";
                    where += "GROUP BY SaleDate ORDER BY date ASC";
                    break;
                //Dashboard theo month.
                case 2:
                    select = "SELECT MONTH(SaleDate) as date, sum(SaleAmount) as total ";
                    from = "FROM SaleTbl ";
                    where += "GROUP BY SaleDate ORDER BY date ASC";
                    break;
                //Dashboard theo year.
                case 3:
                    select = "SELECT (year(SaleDate)) as date ,sum(SaleAmount) as total ";
                    from = "FROM SaleTbl ";
                    where += "GROUP BY SaleDate ORDER BY date ASC";
                    break;
                //Dashboard theo from date to date.
                case 4:
                    select = "SELECT (day(SaleDate)) as date, sum(SaleAmount) as total ";
                    from = "FROM SaleTbl ";
                    where = "WHERE SaleDate between '" + frm + "' and '" + to + "' ";
                    where += "GROUP BY SaleDate ORDER BY date ASC";
                    break;
                default:
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.PullDataDt(cmd);
        }

        //Hàm xử lý thêm mới.
        public int AddSale(int sCustomer, int sUser, int sAmount, DateTime sDate)
        {
            string insertInto = "INSERT INTO SaleTbl(SaleCustomer, SaleUser, SaleAmount, SaleDate) ",
                values = "VALUES (@sCustomer, @sUser, @sAmount, @sDate)";
            SqlCommand cmd = new SqlCommand(insertInto + values);

            cmd.Parameters.Add("sCustomer", SqlDbType.Int).Value = sCustomer;
            cmd.Parameters.Add("sUser", SqlDbType.Int).Value = sUser;
            cmd.Parameters.Add("sAmount", SqlDbType.Int).Value = sAmount;
            cmd.Parameters.Add("sDate", SqlDbType.DateTime).Value = sDate;

            return cls.UpdateData(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet SearchSale(string key)
        {
            string select = "SELECT SaleNum, SaleAmount, SaleDate, CustomerName, UserName ",
                from = "FROM SaleTbl, UserTbl, CustomerTbl ",
                where = "WHERE SaleTbl.SaleUser = UserId AND SaleTbl.SaleCustomer = CustomerId AND (SaleNum like N'%" + key + "%' OR CustomerName like N'%" + key + "%' OR UserName like '%" + key + "%')";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.PullData(cmd);
        }

        //Hàm xử lý đếm sale.
        public int CountSale()
        {
            string select = "SELECT count(*) ",
                from = "FROM SaleTbl ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.GetID(cmd);
        }

        //Hàm xử lý tính tổng doanh thu.
        public int SumSale()
        {
            string select = "SELECT sum(SaleAmount) ",
                from = "FROM SaleTbl ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.GetID(cmd);
        }
    }
}
