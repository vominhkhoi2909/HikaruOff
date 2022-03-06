using System.Data;
using System.Data.SqlClient;
using HikaruOff.Class;
using HikaruOff.BUS;

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
        public bool CheckCategoryName(string categoryName)
        {
            string select = "SELECT * ",
                from = "FROM CategoryTbl ",
                where = "WHERE CategoryName = N'" + categoryName + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý thêm mới.
        public int AddCategory(Category category)
        {
            string insertInto = "INSERT INTO CategoryTbl(CategoryId, CategoryName) ",
                values = "VALUES (@cId, @cName)";
            SqlCommand cmd = new SqlCommand(insertInto + values);

            cmd.Parameters.Add("cId", SqlDbType.Int).Value = category.CategoryId;
            cmd.Parameters.Add("cName", SqlDbType.NVarChar).Value = category.CategoryName;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa.
        public int DeleteCategory(int categoryId)
        {
            string deleteFrom = "DELETE FROM CategoryTbl ",
                where = "WHERE CategoryId = @cId";
            SqlCommand cmd = new SqlCommand(deleteFrom + where);

            cmd.Parameters.Add("cId", SqlDbType.Int).Value = categoryId;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int UpdateCategory(Category category)
        {
            string update = "UPDATE CategoryTbl ",
                set = "SET CategoryName = @cName ",
                where = "WHERE CategoryId = @cId";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("cId", SqlDbType.Int).Value = category.CategoryId;
            cmd.Parameters.Add("cName", SqlDbType.NVarChar).Value = category.CategoryName;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet SearchCategory(string key)
        {
            string select = "SELECT * ",
                from = "FROM CategoryTbl ",
                where = "WHERE CategoryName like N'%" + key + "%' AND CategoryId like '%" + key + "%'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
