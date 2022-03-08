using HikaruOff.DataLayer;
using System;
using System.Windows.Forms;

namespace HikaruOff.Controller
{
    class ItemCtrl
    {
        //Khởi tạo biến giá trị.
        ItemData itemData = new ItemData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return itemData.GetID();
        }

        //Hàm kiểm tra tên có bị trùng.
        public bool checkName(string iName)
        {
            return itemData.CheckItemName(iName);
        }

        //Hàm xử lý hiển thị ds thiết bị lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = itemData.PullListItem().Tables[0];
        }

        //Hàm xử lý thêm mới.
        public int Add(string iName, string iDetails, int iCategory, int iQuantily, int iBuyPrice, int iSellPrice, int iProfit, DateTime iAddDate)
        {
            return itemData.AddItem(iName, iDetails, iCategory, iQuantily, iBuyPrice, iSellPrice, iProfit, iAddDate);
        }

        //Hàm xử lý xóa.
        public int Delete(int iId)
        {
            return itemData.DeleteItem(iId);
        }

        //Hàm xử lý cập nhật.
        public int Update(int iId, string iName, string iDetails, int iCategory, int iQuantily, int iBuyPrice, int iSellPrice, int iProfit)
        {
            return itemData.UpdateItem(iId, iName, iDetails, iCategory, iQuantily, iBuyPrice, iSellPrice, iProfit);
        }

        //Hàm xử lý tìm kiếm.
        public void Search(DataGridView dgv, string key)
        {
            dgv.DataSource = itemData.SearchItem(key).Tables[0];
        }
    }
}
