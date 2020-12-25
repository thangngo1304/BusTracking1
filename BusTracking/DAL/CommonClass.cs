using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BusTracking.DAL
{
    public class CommonClass
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection sqlC = new SqlConnection();
        public CommonClass()
        {
            sqlC = new SqlConnection(address);
        }

        public void Mo()
        {
            if (sqlC.State != ConnectionState.Open)
            {
                sqlC.Open();
            }
        }

        public void Dong()
        {
            if(sqlC.State != ConnectionState.Closed)
            {
                sqlC.Close();
            }
        }

        public DataTable LoadData(string sql)
        {
            SqlDataAdapter sqlD = new SqlDataAdapter(sql,sqlC);
            DataTable dt = new DataTable();
            sqlD.Fill(dt);
            return dt;
        }

        public int ExcuteNonquery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlC);
            Mo();
            int ketqua = cmd.ExecuteNonQuery();
            Dong();
            return ketqua;
        }
        public int xulydukieu(string sql)
        {
            int kq = 0;
            try
            {
                Mo();
                SqlCommand sqlCom = new SqlCommand(sql, sqlC);
                kq = sqlCom.ExecuteNonQuery();
            }catch(Exception ex)
            {
                //thông báo lỗi.
                kq = 0;
            }
            finally
            {
                Dong();
            }
            return kq;
        }
    }
}