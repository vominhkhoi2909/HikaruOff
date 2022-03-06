using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class Item
    {
        //Khởi tạo các biến giá trị.
        int _itemId, _itemCategory, _itemQuantily, _itemBuyPrice, _itemSellPrice, _itemProfit;
        string _itemName, _itemDetails;
        DateTime _itemAddDate;

        //Khởi tạo mặc định.
        public Item()
        {

        }

        //Hàm xử lý getter, setter.
        public int ItemId { get => _itemId; set => _itemId = value; }
        public int ItemCategory { get => _itemCategory; set => _itemCategory = value; }
        public int ItemQuantily { get => _itemQuantily; set => _itemQuantily = value; }
        public int ItemBuyPrice { get => _itemBuyPrice; set => _itemBuyPrice = value; }
        public int ItemSellPrice { get => _itemSellPrice; set => _itemSellPrice = value; }
        public int ItemProfit { get => _itemProfit; set => _itemProfit = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string ItemDetails { get => _itemDetails; set => _itemDetails = value; }
        public DateTime ItemAddDate { get => _itemAddDate; set => _itemAddDate = value; }
    }
}
