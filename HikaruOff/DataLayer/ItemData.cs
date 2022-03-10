using System;
using System.Data;
using System.Data.SqlClient;
using HikaruOff.Class;

namespace HikaruOff.DataLayer
{
    class ItemData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT ItemId ",
                from = "FROM ItemTbl ",
                orderBy = "ORDER BY ItemId DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm lấy danh sách.
        public DataSet PullListItem()
        {
            string select = "SELECT * ",
                from = "FROM ItemTbl, CategoryTbl ",
                where = "WHERE ItemCategory = CategoryId";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm kiểm tra tên đã tồn tại chưa.
        public bool CheckItemName(string iName)
        {
            string select = "SELECT * ",
                from = "FROM ItemTbl ",
                where = "WHERE ItemName = N'" + iName + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý thêm mới.
        public int AddItem(string iName, string iDetails, int iCategory, int iQuantily, int iBuyPrice, int iSellPrice, int iProfit, DateTime iAddDate)
        {
            string insertInto = "INSERT INTO ItemTbl(ItemName, ItemCategory, ItemQuantily, ItemBuyPrice, ItemSellPrice, ItemProfit, ItemDetails, ItemAddDate) ",
                values = "VALUES (@iName, @iCategory, @iQuantily, @iBuyPrice, @iSellPrice, @iProfit, @iDetails, @iAddDate)";
            SqlCommand cmd = new SqlCommand(insertInto + values);

            cmd.Parameters.Add("iName", SqlDbType.NVarChar).Value = iName;
            cmd.Parameters.Add("iCategory", SqlDbType.Int).Value = iCategory;
            cmd.Parameters.Add("iQuantily", SqlDbType.Int).Value = iQuantily;
            cmd.Parameters.Add("iBuyPrice", SqlDbType.Int).Value = iBuyPrice;
            cmd.Parameters.Add("iSellPrice", SqlDbType.Int).Value = iSellPrice;
            cmd.Parameters.Add("iProfit", SqlDbType.Int).Value = iProfit;
            cmd.Parameters.Add("iDetails", SqlDbType.NVarChar).Value = iDetails;
            cmd.Parameters.Add("iAddDate", SqlDbType.DateTime).Value = iAddDate;

            return cls.CapNhatDL(cmd);
        }
        
        //Hàm xử lý xóa.
        public int DeleteItem(int iId)
        {
            string deleteFrom = "DELETE FROM ItemTbl ",
                where = "WHERE ItemId = @iId";
            SqlCommand cmd = new SqlCommand(deleteFrom + where);

            cmd.Parameters.Add("iId", SqlDbType.Int).Value = iId;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int UpdateItem(int iId, string iName, string iDetails, int iCategory, int iQuantily, int iBuyPrice, int iSellPrice, int iProfit)
        {
            string update = "UPDATE ItemTbl ",
                set = "SET ItemName = @iName, ItemCategory = @iCategory, ItemQuantily = @iQuantily, ItemBuyPrice = @iBuyPrice, ItemSellPrice = @iSellPrice, ItemProfit = @iProfit, ItemDetails = @iDetails ",
                where = "WHERE ItemId = @iId";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("iId", SqlDbType.Int).Value = iId;
            cmd.Parameters.Add("iName", SqlDbType.NVarChar).Value = iName;
            cmd.Parameters.Add("iCategory", SqlDbType.Int).Value = iCategory;
            cmd.Parameters.Add("iQuantily", SqlDbType.Int).Value = iQuantily;
            cmd.Parameters.Add("iBuyPrice", SqlDbType.Int).Value = iBuyPrice;
            cmd.Parameters.Add("iSellPrice", SqlDbType.Int).Value = iSellPrice;
            cmd.Parameters.Add("iProfit", SqlDbType.Int).Value = iProfit;
            cmd.Parameters.Add("iDetails", SqlDbType.NVarChar).Value = iDetails;

            return cls.CapNhatDL(cmd);
        }

        //Cap nhat ton kho.
        public int UpdateStockItem(int iId,  int iQuantily)
        {
            string update = "UPDATE ItemTbl ",
                set = "SET ItemQuantily = @iQuantily ",
                where = "WHERE ItemId = @iId";
            SqlCommand cmd = new SqlCommand(update + set + where);

            cmd.Parameters.Add("iId", SqlDbType.Int).Value = iId;
            cmd.Parameters.Add("iQuantily", SqlDbType.Int).Value = iQuantily;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet SearchItem(string key)
        {
            string select = "SELECT * ",
                from = "FROM ItemTbl, CategoryTbl ",
                where = "WHERE ItemCategory = CategoryId AND (CategoryName like N'%" + key + "%' OR ItemName like N'%" + key + "%' OR ItemId like '%" + key + "%')";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
