using System.Data;
using System.Data.SqlClient;
using HikaruOff.Class;

namespace HikaruOff.DataLayer
{
    class CategoryData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT CategoryId ",
                from = "FROM CategoryTbl ",
                orderBy = "ORDER BY CategoryId DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm lấy danh sách.
        public DataSet PullListCategory()
        {
            string select = "SELECT * ",
                from = "FROM CategoryTbl ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }

        //Hàm kiểm tra tên đã tồn tại chưa.
        public bool CheckCategoryName(string cName)
        {
            string select = "SELECT * ",
                from = "FROM CategoryTbl ",
                where = "WHERE CategoryName = N'" + cName + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý thêm mới.
        public int AddCategory(string cName)
        {
            string insertInto = "INSERT INTO CategoryTbl(CategoryName) ",
                values = "VALUES (@cName)";
            SqlCommand cmd = new SqlCommand(insertInto + values);

            cmd.Parameters.Add("cName", SqlDbType.NVarChar).Value = cName;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa.
        public int DeleteCategory(int cId)
        {
            string deleteFrom = "DELETE FROM CategoryTbl ",
                where = "WHERE CategoryId = @cId";
            SqlCommand cmd = new SqlCommand(deleteFrom + where);

            cmd.Parameters.Add("cId", SqlDbType.Int).Value = cId;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int UpdateCategory(int cId, string cName)
        {
            string update = "UPDATE CategoryTbl ",
                set = "SET CategoryName = @cName ",
                where = "WHERE CategoryId = @cId";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("cId", SqlDbType.Int).Value = cId;
            cmd.Parameters.Add("cName", SqlDbType.NVarChar).Value = cName;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet SearchCategory(string key)
        {
            string select = "SELECT * ",
                from = "FROM CategoryTbl ",
                where = "WHERE CategoryName like N'%" + key + "%' OR CategoryId like '%" + key + "%'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
