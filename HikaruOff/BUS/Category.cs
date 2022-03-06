using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class Category
    {
        //Khởi tạo các biến giá trị.
        int _categoryId;
        string _categoryName;

        //Khởi tạo mặc định.
        public Category()
        {

        }

        //Hàm xử lý getter, setter.
        public int CategoryId { get => _categoryId; set => _categoryId = value; }
        public string CategoryName { get => _categoryName; set => _categoryName = value; }
    }
}
