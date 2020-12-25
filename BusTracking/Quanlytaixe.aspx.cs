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
    public partial class Quanlytaixe : System.Web.UI.Page
    {
        string csdl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        public void loaddulieu()
        {
            SqlConnection sqlCon = new SqlConnection(csdl);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TaiXe", sqlCon);
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TaiXe", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;
                Label_thongbao.Text = "";
                Button_co.Visible = false;
                Button_khong.Visible = false;

                TextBox_mtx.Enabled = false;
                TextBox_hvt.Enabled = false;
                TextBox_ngaysinh.Enabled = false;
                TextBox_gt.Enabled = false;
                TextBox_diachi.Enabled = false;
                TextBox_quequan.Enabled = false;
                TextBox_ngaybdhopdong.Enabled = false;
                TextBox_luong.Enabled = false;
                TextBox_banglai.Enabled = false;
                TextBox_maxe.Enabled = false;

                TextBox_mtx.Text = dt.Rows[0]["MaTx"].ToString();
                TextBox_hvt.Text = dt.Rows[0]["HoVaTen"].ToString();
                TextBox_ngaysinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                TextBox_gt.Text = dt.Rows[0]["GioiTinh"].ToString();
                TextBox_diachi.Text = dt.Rows[0]["DiaChi"].ToString();
                TextBox_quequan.Text = dt.Rows[0]["QueQuan"].ToString();
                TextBox_ngaybdhopdong.Text = dt.Rows[0]["NgayBDHopDong"].ToString();
                TextBox_luong.Text = dt.Rows[0]["Luong"].ToString();
                TextBox_banglai.Text = dt.Rows[0]["BangLai"].ToString();
                TextBox_maxe.Text = dt.Rows[0]["MaXe"].ToString();
                ViewState["flag"] = false;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            string sql = "SELECT * FROM TaiXe";
            SqlDataAdapter da = new SqlDataAdapter(sql, csdl);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox_mtx.Text = dt.Rows[dong][0].ToString();
            TextBox_hvt.Text = dt.Rows[dong][1].ToString();
            TextBox_ngaysinh.Text = dt.Rows[dong][2].ToString();
            TextBox_gt.Text = dt.Rows[dong][3].ToString();
            TextBox_diachi.Text = dt.Rows[dong][4].ToString();
            TextBox_quequan.Text = dt.Rows[dong][5].ToString();
            TextBox_ngaybdhopdong.Text = dt.Rows[dong][6].ToString();
            TextBox_luong.Text = dt.Rows[dong][7].ToString();
            TextBox_banglai.Text = dt.Rows[dong][8].ToString();
            TextBox_maxe.Text = dt.Rows[dong][9].ToString();
        }

        protected void Button_them_Click(object sender, EventArgs e)
        {
            TextBox_mtx.Text = "";
            TextBox_mtx.Focus();
            TextBox_hvt.Text = "";
            TextBox_ngaysinh.Text = "";
            TextBox_gt.Text = "";
            TextBox_diachi.Text = "";
            TextBox_quequan.Text = "";
            TextBox_ngaybdhopdong.Text = "";
            TextBox_luong.Text = "";
            TextBox_banglai.Text = "";
            TextBox_maxe.Text = "";
            TextBox_mtx.Enabled = true;
            TextBox_hvt.Enabled = true;
            TextBox_ngaysinh.Enabled = true;
            TextBox_gt.Enabled = true;
            TextBox_diachi.Enabled = true;
            TextBox_quequan.Enabled = true;
            TextBox_ngaybdhopdong.Enabled = true;
            TextBox_luong.Enabled = true;
            TextBox_banglai.Enabled = true;
            TextBox_maxe.Enabled = true;

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
            TextBox_mtx.Focus();
            TextBox_mtx.Enabled = true;
            TextBox_hvt.Enabled = true;
            TextBox_ngaysinh.Enabled = true;
            TextBox_gt.Enabled = true;
            TextBox_diachi.Enabled = true;
            TextBox_quequan.Enabled = true;
            TextBox_ngaybdhopdong.Enabled = true;
            TextBox_luong.Enabled = true;
            TextBox_banglai.Enabled = true;
            TextBox_maxe.Enabled = true;

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
            int kq = kn.xulydukieu("DELETE TaiXe WHERE MaTx='" + TextBox_mtx.Text + "'");
            if (kq > 0)
            {
                Label_thongbao.Text = "Bạn đã xóa thành công!";

                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TaiXe", sqlCon);
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
        public void sua()
        {
            if (TextBox_mtx.Text == "" || TextBox_hvt.Text == "" || TextBox_ngaysinh.Text == "" || TextBox_gt.Text == "" || TextBox_diachi.Text == "" || TextBox_quequan.Text == ""|| TextBox_ngaybdhopdong.Text == "" || TextBox_luong.Text == "" || TextBox_banglai.Text == "" || TextBox_maxe.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để sửa!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("UPDATE TaiXe set HoVaTen='" + TextBox_hvt.Text + "', NgaySinh='" + TextBox_ngaysinh.Text + "', GioiTinh='" + TextBox_gt.Text + "', DiaChi='" + TextBox_diachi.Text + "', QueQuan='" + TextBox_quequan.Text + "', NgayBDHopDong='" + TextBox_ngaybdhopdong.Text + "', Luong='" + TextBox_luong.Text + "', BangLai='" + TextBox_banglai.Text + "', MaXe='" + TextBox_maxe.Text + "' WHERE MaTx='" + TextBox_mtx.Text + "'");
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
        public void them()
        {
            if (TextBox_mtx.Text == "" || TextBox_hvt.Text == "" || TextBox_ngaysinh.Text == "" || TextBox_gt.Text == "" || TextBox_diachi.Text == "" || TextBox_quequan.Text == "" || TextBox_ngaybdhopdong.Text == "" || TextBox_luong.Text == "" || TextBox_banglai.Text == "" || TextBox_maxe.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để thêm!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("INSERT INTO TaiXe(MaTx,HoVaTen,NgaySinh,GioiTinh,DiaChi,QueQuan,NgayBDHopDong,Luong,BangLai,MaXe) VALUES('" + TextBox_mtx.Text + "', '" + TextBox_hvt.Text + "', '" + TextBox_ngaysinh.Text + "', '" + TextBox_gt.Text + "', '" + TextBox_diachi.Text + "', '" + TextBox_quequan.Text + "', '" + TextBox_ngaybdhopdong.Text + "', '" + TextBox_luong.Text + "', '" + TextBox_banglai.Text + "', '" + TextBox_maxe.Text + "')");
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
                TextBox_mtx.Enabled = false;
                TextBox_hvt.Enabled = false;
                TextBox_ngaysinh.Enabled = false;
                TextBox_gt.Enabled = false;
                TextBox_diachi.Enabled = false;
                TextBox_quequan.Enabled = false;
                TextBox_ngaybdhopdong.Enabled = false;
                TextBox_luong.Enabled = false;
                TextBox_banglai.Enabled = false;
                TextBox_maxe.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
            else
            {
                sua();
                TextBox_mtx.Enabled = false;
                TextBox_hvt.Enabled = false;
                TextBox_ngaysinh.Enabled = false;
                TextBox_gt.Enabled = false;
                TextBox_diachi.Enabled = false;
                TextBox_quequan.Enabled = false;
                TextBox_ngaybdhopdong.Enabled = false;
                TextBox_luong.Enabled = false;
                TextBox_banglai.Enabled = false;
                TextBox_maxe.Enabled = false;

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

            TextBox_mtx.Enabled = false;
            TextBox_hvt.Enabled = false;
            TextBox_ngaysinh.Enabled = false;
            TextBox_gt.Enabled = false;
            TextBox_diachi.Enabled = false;
            TextBox_quequan.Enabled = false;
            TextBox_ngaybdhopdong.Enabled = false;
            TextBox_luong.Enabled = false;
            TextBox_banglai.Enabled = false;
            TextBox_maxe.Enabled = false;
        }
    }
}