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
    public partial class quanlynhansu : System.Web.UI.Page
    {
        string csdl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        BLL.BLLAdmin BLLAdm = new BLL.BLLAdmin();
        public void loaddulieu()
        {
            SqlConnection sqlCon = new SqlConnection(csdl);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TaiKhoan", sqlCon);
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TaiKhoan", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;
                Label_thongbao.Text = "";
                Button_co.Visible = false;
                Button_khong.Visible = false;

                TextBox_mtk.Enabled = false;
                TextBox_tentk.Enabled = false;
                TextBox_mk.Enabled = false;
                TextBox_tendaydu.Enabled = false;
                TextBox_ngaythangns.Enabled = false;
                TextBox_sdt.Enabled = false;
                TextBox_chucvu.Enabled = false;

                TextBox_mtk.Text = dt.Rows[0]["MataiKhoan"].ToString();
                TextBox_tentk.Text = dt.Rows[0]["TenTaiKhoan"].ToString();
                TextBox_mk.Text = dt.Rows[0]["MatKhau"].ToString();
                TextBox_tendaydu.Text = dt.Rows[0]["TenDayDu"].ToString();
                TextBox_ngaythangns.Text = dt.Rows[0]["NgayThangNamSinh"].ToString();
                TextBox_sdt.Text = dt.Rows[0]["SoDienThoai"].ToString();
                TextBox_chucvu.Text = dt.Rows[0]["ChucVu"].ToString();

                ViewState["flag"] = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("index.aspx");
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label_thongbao.Text = "Bạn có muốn xóa không?";
            Button_co.Visible = true;
            Button_khong.Visible = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            string sql = "SELECT * FROM TaiKhoan";
            SqlDataAdapter da = new SqlDataAdapter(sql, csdl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TextBox_mtk.Text = dt.Rows[dong][0].ToString();
            TextBox_tentk.Text = dt.Rows[dong][1].ToString();
            TextBox_mk.Text = dt.Rows[dong][2].ToString();
            TextBox_tendaydu.Text = dt.Rows[dong][3].ToString();
            TextBox_ngaythangns.Text = dt.Rows[dong][4].ToString();
            TextBox_sdt.Text = dt.Rows[dong][5].ToString();
            TextBox_chucvu.Text = dt.Rows[dong][6].ToString();
        }

        protected void Button_them_Click(object sender, EventArgs e)
        {
            TextBox_mtk.Text = "";
            TextBox_mtk.Focus();
            TextBox_tentk.Text = "";
            TextBox_tentk.Enabled = true;
            TextBox_mk.Text = "";
            TextBox_mk.Enabled = true;
            TextBox_tendaydu.Text = "";
            TextBox_tendaydu.Enabled = true;
            TextBox_ngaythangns.Text = "";
            TextBox_ngaythangns.Enabled = true;
            TextBox_sdt.Text = "";
            TextBox_sdt.Enabled = true;
            TextBox_chucvu.Text = "";
            TextBox_chucvu.Enabled = true;
            TextBox_mtk.Enabled = true;

            Button_ghi.Enabled = true;
            Button_khghi.Enabled = true;

            Button_them.Enabled = false;
            Button1.Enabled = false;
            Button_sua.Enabled = false;
            ViewState["flag"] = true;
        }

        protected void Button_co_Click(object sender, EventArgs e)
        {
            DAL.CommonClass kn = new DAL.CommonClass();
            int kq = kn.xulydukieu("DELETE TaiKhoan WHERE MaTaiKhoan='" + TextBox_mtk.Text + "'");
            if (kq > 0)
            {
                Label_thongbao.Text = "Bạn đã xóa thành công!";

                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From TaiKhoan", sqlCon);
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

        protected void Button_sua_Click(object sender, EventArgs e)
        {
            TextBox_mtk.Focus();
            TextBox_tentk.Enabled = true;            
            TextBox_mk.Enabled = true;
            TextBox_tendaydu.Enabled = true;
            TextBox_ngaythangns.Enabled = true;
            TextBox_sdt.Enabled = true;
            TextBox_chucvu.Enabled = true;
            TextBox_mtk.Enabled = true;

            Button_ghi.Enabled = true;
            Button_khghi.Enabled = true;

            Button_sua.Enabled = false;
            Button1.Enabled = false;
            Button_them.Enabled = false;
            ViewState["flag"] = false;
        }
        public void sua()
        {
            if (TextBox_mtk.Text == "" || TextBox_tentk.Text == "" || TextBox_mk.Text == "" || TextBox_tendaydu.Text == "" || TextBox_ngaythangns.Text == "" || TextBox_sdt.Text == "" || TextBox_chucvu.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để sửa!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("UPDATE TaiKhoan set TenTaiKhoan='" + TextBox_tentk.Text + "', MatKhau='" + TextBox_mk.Text + "', TenDayDu='" + TextBox_tendaydu.Text + "', NgayThangNamSinh='" + TextBox_ngaythangns.Text + "', SoDienThoai='" + TextBox_sdt.Text + "', ChucVu='" + TextBox_chucvu.Text + "' WHERE MaTaiKhoan='" + TextBox_mtk.Text + "'");
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
            if (TextBox_mtk.Text == "" || TextBox_tentk.Text == "" || TextBox_mk.Text == "" || TextBox_tendaydu.Text == "" || TextBox_ngaythangns.Text == "" || TextBox_sdt.Text == "" || TextBox_chucvu.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để thêm!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, TenDayDu, NgayThangNamSinh, SoDienThoai, ChucVu) VALUES( '" + TextBox_mtk.Text + "','" + TextBox_tentk.Text + "', '" + TextBox_mk.Text + "', '" + TextBox_tendaydu.Text + "', '" + TextBox_ngaythangns.Text + "', '" + TextBox_sdt.Text + "', '" + TextBox_chucvu.Text + "')");
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
            if((bool)ViewState["flag"] == true)
            {
                them();
                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_sua.Enabled = true;
                Button1.Enabled = true;

                TextBox_mtk.Enabled = false;
                TextBox_tentk.Enabled = false;
                TextBox_mk.Enabled = false;
                TextBox_tendaydu.Enabled = false;
                TextBox_ngaythangns.Enabled = false;
                TextBox_sdt.Enabled = false;
                TextBox_chucvu.Enabled = false;
            }
            else
            {
                sua();
                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_sua.Enabled = true;
                Button1.Enabled = true;

                TextBox_mtk.Enabled = false;
                TextBox_tentk.Enabled = false;
                TextBox_mk.Enabled = false;
                TextBox_tendaydu.Enabled = false;
                TextBox_ngaythangns.Enabled = false;
                TextBox_sdt.Enabled = false;
                TextBox_chucvu.Enabled = false;
            }
        }

        protected void Button_khghi_Click(object sender, EventArgs e)
        {
            Button_them.Enabled = true;
            Button_sua.Enabled = true;
            Button1.Enabled = true;
            Button_khghi.Enabled = false;
            Button_ghi.Enabled = false;

            TextBox_mtk.Enabled = false;
            TextBox_tentk.Enabled = false;
            TextBox_mk.Enabled = false;
            TextBox_tendaydu.Enabled = false;
            TextBox_ngaythangns.Enabled = false;
            TextBox_sdt.Enabled = false;
            TextBox_chucvu.Enabled = false;
        }
    }
}