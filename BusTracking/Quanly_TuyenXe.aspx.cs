using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BusTracking
{
    public partial class Quanly_TuyenXe : System.Web.UI.Page
    {
        string csdl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        BLL.BLLAdmin BLLAdm = new BLL.BLLAdmin();
        public void loaddulieu()
        {
            SqlConnection sqlCon = new SqlConnection(csdl);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TuyenXe", sqlCon);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TuyenXe", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;
                Label_thongbao.Text = "";
                Button_co.Visible = false;
                Button_khong.Visible = false;

                TextBox_mt.Enabled = false;
                TextBox_mdv.Enabled = false;
                TextBox_tentuyen.Enabled = false;
                TextBox_tgbd.Enabled = false;
                TextBox_tgkt.Enabled = false;
                TextBox_tggc.Enabled = false;
                TextBox_ltld.Enabled = false;
                TextBox_ltlv.Enabled = false;
                TextBox_loaituyen.Enabled = false;

                TextBox_mt.Text = dt.Rows[0]["MaTuyen"].ToString();
                TextBox_mdv.Text = dt.Rows[0]["MaDonVi"].ToString();
                TextBox_tentuyen.Text = dt.Rows[0]["TenTuyen"].ToString();
                TextBox_tgbd.Text = dt.Rows[0]["ThoiGianBatDau"].ToString();
                TextBox_tgkt.Text = dt.Rows[0]["ThoiGianKetThuc"].ToString();
                TextBox_tggc.Text = dt.Rows[0]["ThoiGianGianCach"].ToString();
                TextBox_ltld.Text = dt.Rows[0]["LoTrinhLuotDi"].ToString();
                TextBox_ltlv.Text = dt.Rows[0]["LoTrinhLuotVe"].ToString();
                TextBox_loaituyen.Text = dt.Rows[0]["LoaiTuyen"].ToString();
                ViewState["flag"] = false;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            string sql = "SELECT * FROM TuyenXe";
            SqlDataAdapter da = new SqlDataAdapter(sql, csdl);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox_mt.Text = dt.Rows[dong][0].ToString();
            TextBox_mdv.Text = dt.Rows[dong][1].ToString();
            TextBox_tentuyen.Text = dt.Rows[dong][2].ToString();
            TextBox_tgbd.Text = dt.Rows[dong][3].ToString();
            TextBox_tgkt.Text = dt.Rows[dong][4].ToString();
            TextBox_tggc.Text = dt.Rows[dong][5].ToString();
            TextBox_ltld.Text = dt.Rows[dong][6].ToString();
            TextBox_ltlv.Text = dt.Rows[dong][7].ToString();
            TextBox_loaituyen.Text = dt.Rows[dong][8].ToString();
        }

        protected void Button_them_Click(object sender, EventArgs e)
        {
            TextBox_mt.Text = "";
            TextBox_mt.Focus();
            TextBox_mdv.Text = "";
            TextBox_tentuyen.Text = "";
            TextBox_tgbd.Text = "";
            TextBox_tgkt.Text = "";
            TextBox_tggc.Text = "";
            TextBox_ltld.Text = "";
            TextBox_ltlv.Text = "";
            TextBox_loaituyen.Text = "";
            TextBox_mt.Enabled = true;
            TextBox_mdv.Enabled = true;
            TextBox_tentuyen.Enabled = true;
            TextBox_tgbd.Enabled = true;
            TextBox_tgkt.Enabled = true;
            TextBox_tggc.Enabled = true;
            TextBox_ltld.Enabled = true;
            TextBox_ltlv.Enabled = true;
            TextBox_loaituyen.Enabled = true;

            Button_ghi.Enabled = true;
            Button_khghi.Enabled = true;

            Button_them.Enabled = false;
            Button_xoa.Enabled = false;
            Button_sua.Enabled = false;
            ViewState["flag"] = true;
        }

        protected void Button_xoa_Click(object sender, EventArgs e)
        {
            Label_thongbao.Text = "Bạn có muốn xóa không?";
            Button_co.Visible = true;
            Button_khong.Visible = true;
        }

        protected void Button_sua_Click(object sender, EventArgs e)
        {
            TextBox_mt.Focus();
            TextBox_mt.Enabled = true;
            TextBox_mdv.Enabled = true;
            TextBox_tentuyen.Enabled = true;
            TextBox_tgbd.Enabled = true;
            TextBox_tgkt.Enabled = true;
            TextBox_tggc.Enabled = true;
            TextBox_ltld.Enabled = true;
            TextBox_ltlv.Enabled = true;
            TextBox_loaituyen.Enabled = true;

            Button_ghi.Enabled = true;
            Button_khghi.Enabled = true;

            Button_them.Enabled = false;
            Button_xoa.Enabled = false;
            Button_sua.Enabled = false;
            ViewState["flag"] = false;
        }

        protected void Button_co_Click(object sender, EventArgs e)
        {
            DAL.CommonClass kn = new DAL.CommonClass();
            int kq = kn.xulydukieu("DELETE TuyenXe WHERE MaTuyen='" + TextBox_mt.Text + "'");
            if (kq > 0)
            {
                Label_thongbao.Text = "Bạn đã xóa thành công!";

                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TuyenXe", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Button_co.Visible = false;
                Button_khong.Visible = false;
            }
        }

        protected void Button_khong_Click(object sender, EventArgs e)
        {
            Button_co.Visible = false;
            Button_khong.Visible = false;
            Label_thongbao.Text = "";
        }
        private void sua()
        {
            if (TextBox_mt.Text == "" || TextBox_mdv.Text == "" || TextBox_tentuyen.Text == "" || TextBox_tgbd.Text == "" || TextBox_tgkt.Text == "" || TextBox_tggc.Text == "" || TextBox_ltld.Text == "" || TextBox_ltlv.Text == "" || TextBox_loaituyen.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để sửa!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("UPDATE TuyenXe set MaDonVi='" + TextBox_mdv.Text + "', TenTuyen='" + TextBox_tentuyen.Text + "', ThoiGianBatDau='" + TextBox_tgbd.Text + "', ThoiGianKetThuc='" + TextBox_tgkt.Text + "', ThoiGianGianCach='" + TextBox_tggc.Text + "', LoTrinhLuotDi='" + TextBox_ltld.Text + "', LoTrinhLuotVe='" + TextBox_ltlv.Text + "', LoaiTuyen='" + TextBox_loaituyen.Text + "' WHERE MaTuyen='" + TextBox_mt.Text + "'");
                if (kq > 0)
                {
                    Label_thongbao.Text = "Bạn đã sửa thành công!";
                    loaddulieu();
                }
                else
                {
                    Label_thongbao.Text = "Sửa không thành công!, vui lòng kiểm tra lại!";
                }
            }
        }
        private void them()
        {
            if (TextBox_mt.Text == "" || TextBox_mdv.Text == "" || TextBox_tentuyen.Text == "" || TextBox_tgbd.Text == "" || TextBox_tgkt.Text == "" || TextBox_tggc.Text == "" || TextBox_ltld.Text == "" || TextBox_ltlv.Text == "" || TextBox_loaituyen.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để thêm!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("INSERT INTO TuyenXe(MaTuyen,MaDonVi,TenTuyen,ThoiGianBatDau,ThoiGianKetThuc,ThoiGianGianCach,LoTrinhLuotDi,LoTrinhLuotVe,LoaiTuyen) VALUES( '" + TextBox_mt.Text + "','" + TextBox_mdv.Text + "', '" + TextBox_tentuyen.Text + "', '" + TextBox_tgbd.Text + "', '" + TextBox_tgkt.Text + "', '" + TextBox_tggc.Text + "', '" + TextBox_ltld.Text + "', '" + TextBox_ltlv.Text + "', '" + TextBox_loaituyen.Text + "')");
                if (kq > 0)
                {
                    Label_thongbao.Text = "Bạn đã thêm thành công!";
                    loaddulieu();
                }
                else
                {
                    Label_thongbao.Text = "Thêm không thành công!, vui lòng kiểm tra lại!";
                }
            }
        }

        protected void Button_ghi_Click(object sender, EventArgs e)
        {
            if ((bool)ViewState["flag"] == true)
            {
                them();
                TextBox_mt.Enabled = false;
                TextBox_mdv.Enabled = false;
                TextBox_tentuyen.Enabled = false;
                TextBox_tgbd.Enabled = false;
                TextBox_tgkt.Enabled = false;
                TextBox_tggc.Enabled = false;
                TextBox_ltld.Enabled = false;
                TextBox_ltlv.Enabled = false;
                TextBox_loaituyen.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
            else
            {
                sua();
                TextBox_mt.Enabled = false;
                TextBox_mdv.Enabled = false;
                TextBox_tentuyen.Enabled = false;
                TextBox_tgbd.Enabled = false;
                TextBox_tgkt.Enabled = false;
                TextBox_tggc.Enabled = false;
                TextBox_ltld.Enabled = false;
                TextBox_ltlv.Enabled = false;
                TextBox_loaituyen.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
        }

        protected void Button_khghi_Click(object sender, EventArgs e)
        {
            Button_them.Enabled = true;
            Button_sua.Enabled = true;
            Button_xoa.Enabled = true;
            Button_khghi.Enabled = false;
            Button_ghi.Enabled = false;

            TextBox_mt.Enabled = false;
            TextBox_mdv.Enabled = false;
            TextBox_tentuyen.Enabled = false;
            TextBox_tgbd.Enabled = false;
            TextBox_tgkt.Enabled = false;
            TextBox_tggc.Enabled = false;
            TextBox_ltld.Enabled = false;
            TextBox_ltlv.Enabled = false;
            TextBox_loaituyen.Enabled = false;
        }
    }
}