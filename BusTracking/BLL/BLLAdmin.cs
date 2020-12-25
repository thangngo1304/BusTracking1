using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BusTracking.BLL
{
    public class BLLAdmin
    {
        DAL.CommonClass DALCon = new DAL.CommonClass();
        public DataTable loadQLTX()
        {
            string sql = "SELECT * FROM TaiXe";
            return DALCon.LoadData(sql);
        }
        public DataTable loadTaikhoan()
        {
            string sql = "SELECT * FROM TaiKhoan";
            return DALCon.LoadData(sql);
        }
        public DataTable loadQLDV()
        {
            string sql = "SELECT * FROM DonViQLXe";
            return DALCon.LoadData(sql);
        }
        public DataTable loadQLXe()
        {
            string sql = "SELECT * FROM Xe";
            return DALCon.LoadData(sql);
        }
        public DataTable loadQLTyenXe()
        {
            string sql = "SELECT * FROM TuyenXe";
            return DALCon.LoadData(sql);
        }
        public DataTable loadVe()
        {
            string sql = "SELECT * FROM Ve";
            return DALCon.LoadData(sql);
        }
        public DataTable login(string ten, string matkhau)
        {
            string sql = "SELECT * FROM LOGIN WHERE TENDANGNHAP='" + ten + "' AND MATKHAU='" + matkhau + "'";
            return DALCon.LoadData(sql);
        }
    }
}