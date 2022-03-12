using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace HikaruOff.Class
{
    class DataProvider
    {
        //Lấy thông tin kết nối csdl.
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BV\Documents\HikaruOff_Db.mdf;Integrated Security=True;Connect Timeout=30");

        //Hàm khơi tạo mặc định.
        public DataProvider()
        {
            Connection();
        }

        //Hàm thực hiện kết nối.
        void Connection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        //Truy vấn lấy ds dữ liệu dạng dataset.
        public DataSet PullData(SqlCommand sqlcmd)
        {
            DataSet ds = new DataSet();
            sqlcmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            da.Fill(ds);

            return ds;
        }

        //Truy vấn lấy ds dữ liệu dạng datatable.
        public DataTable PullDataDt(SqlCommand sqlcmd)
        {
            DataTable dt = new DataTable();
            sqlcmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            da.Fill(dt);

            return dt;
        }

        //Thực hiện không truy vấn.
        public int UpdateData(SqlCommand sqlcmd)
        {
            sqlcmd.Connection = conn;

            return sqlcmd.ExecuteNonQuery();
        }

        //Hàm lấy ra 1 giá trị ở cột đầu dữ liệu được truy vấn.
        public int GetID(SqlCommand sqlcmd)
        {
            int id = 1;
            SqlCommand cmd = sqlcmd;
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            dr.Close();

            return id;
        }

        //Hàm kiểm tra dữ liệu đã tộn tại chưa.
        public bool CheckInfo(SqlCommand sqlcmd)
        {
            bool kTra = false;
            SqlCommand cmd = sqlcmd;
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                kTra = true;
            }
            dr.Close();

            return kTra;
        }
    }
}
