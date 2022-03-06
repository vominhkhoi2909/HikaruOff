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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BV\Documents\HikaruOff_Db.mdf;Integrated Security=True;Connect Timeout=30");

        public DataProvider()
        {
            Connection();
        }

        void Connection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public DataSet LayDuLieu(SqlCommand sqlcmd)
        {
            DataSet ds = new DataSet();
            sqlcmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            da.Fill(ds);

            return ds;
        }

        public int CapNhatDL(SqlCommand sqlcmd)
        {
            sqlcmd.Connection = conn;

            return sqlcmd.ExecuteNonQuery();
        }

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

        public bool KiemTra(SqlCommand sqlcmd)
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
