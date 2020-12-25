using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BusTracking.BLL
{
    public class BBLMaster
    {
        DAL.CommonClass DALCom = new DAL.CommonClass();
        public DataTable button2(string TenDangNhap,string MatKhau)
        {
            string sql = "SELECT * FROM LOGIN TENDANGNHAP='"+ TenDangNhap +"' AND MATKHAU='"+ MatKhau +"'";
            return DALCom.LoadData(sql);
        }
    }
    public class BLLQuanlynv
    {
        public DataTable docDL()
        {
            DAL.CommonClass DALCom = new DAL.CommonClass();
            string sql = "SELECT * FROM TaiKhoan";
            return DALCom.LoadData(sql);
        }
    }

}