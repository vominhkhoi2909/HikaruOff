using HikaruOff.DataLayer;
using System;
using System.Windows.Forms;

namespace HikaruOff.Controller
{
    class CustomerCtrl
    {
        //Khởi tạo biến giá trị.
        CustomerData customerData = new CustomerData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return customerData.GetID();
        }

        //Hàm kiểm tra tên có bị trùng.
        public bool CheckName(string cusName)
        {
            return customerData.CheckCustomerName(cusName);
        }

        //Hàm kiểm tra email có bị trùng.
        public bool CheckEmail(string cusEmail)
        {
            return customerData.CheckCustomerEmail(cusEmail);
        }

        //Hàm kiểm tra sdt có bị trùng.
        public bool CheckPhone(string cusPhone)
        {
            return customerData.CheckCustomerPhone(cusPhone);
        }

        //Hàm hiển thị datagridview.
        public void ShowDgv(DataGridView dgv)
        {
            dgv.DataSource = customerData.PullListCustomer().Tables[0];
        }

        //Hàm hiển thị combobox.
        public void ShowCbo(ComboBox cbo)
        {
            cbo.DataSource = customerData.PullListCustomer().Tables[0];
            cbo.DisplayMember = "CustomerName";
            cbo.ValueMember = "CustomerId";
        }

        //Hàm xử lý thêm mới.
        public int Add(string cusName, string cusEmail, DateTime cusBirthDay, string cusGender, string cusPhone, string cusNotes)
        {
            return customerData.AddCustomer(cusName, cusEmail, cusBirthDay, cusGender, cusPhone, cusNotes);
        }

        //Hàm xử lý xóa.
        public int Delete(int cusId)
        {
            return customerData.DeleteCustomer(cusId);
        }

        //Hàm xử lý cập nhật.
        public int Update(int cusId, string cusName, string cusEmail, DateTime cusBirthDay, string cusGender, string cusPhone, string cusNotes)
        {
            return customerData.UpdateCustomer(cusId, cusName, cusEmail, cusBirthDay, cusGender, cusPhone, cusNotes);
        }

        //Hàm xử lý tìm kiếm.
        public void Search(DataGridView dgv, string key)
        {
            dgv.DataSource = customerData.SearchCustomer(key).Tables[0];
        }

        //Hàm xử lý đếm dữ liệu.
        public int Count()
        {
            return customerData.CountCustomer();
        }
    }
}
