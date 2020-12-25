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
    public partial class Ve : System.Web.UI.Page
    {
        string csdl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        public void loaddulieu()
        {
            SqlConnection sqlC = new SqlConnection(csdl);
            sqlC.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Ve", sqlC);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection sqlC = new SqlConnection(csdl);
                sqlC.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Ve", sqlC);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;
                Label_thongbao.Text = "";
                Button_co.Visible = false;
                Button_khong.Visible = false;

                TextBox_mv.Enabled = false;
                TextBox_loaive.Enabled = false;
                TextBox_giave.Enabled = false;
                TextBox_NgayDi.Enabled = false;
                TextBox_mnd.Enabled = false;
                TextBox_matx.Enabled = false;

                TextBox_mv.Text = dt.Rows[0]["MaVe"].ToString();
                TextBox_loaive.Text = dt.Rows[0]["LoaiVe"].ToString();
                TextBox_giave.Text = dt.Rows[0]["GiaVe"].ToString();
                TextBox_NgayDi.Text = dt.Rows[0]["NgayDi"].ToString();
                TextBox_mnd.Text =dt.Rows[0]["MaNguoiDung"].ToString();
                TextBox_matx.Text = dt.Rows[0]["MaTx"].ToString();
                ViewState["flag"] = false;
                
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            string sql = "Select * From Ve";
            SqlDataAdapter da = new SqlDataAdapter(sql, csdl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            TextBox_mv.Text = dt.Rows[dong][0].ToString();
            TextBox_loaive.Text = dt.Rows[dong][1].ToString();
            TextBox_giave.Text = dt.Rows[dong][2].ToString();
            TextBox_NgayDi.Text = dt.Rows[dong][3].ToString();
            TextBox_mnd.Text = dt.Rows[dong][4].ToString();
            TextBox_matx.Text = dt.Rows[dong][5].ToString();
        }

        protected void Button_them_Click(object sender, EventArgs e)
        {
            TextBox_mv.Text = "";
            TextBox_mv.Focus();
            TextBox_loaive.Text="";
            TextBox_giave.Text="";
            TextBox_NgayDi.Text="";
            TextBox_mnd.Text="";
            TextBox_matx.Text="";
            TextBox_loaive.Enabled=true;
            TextBox_giave.Enabled= true;
            TextBox_NgayDi.Enabled= true;
            TextBox_mnd.Enabled= true;
            TextBox_matx.Enabled= true;

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
            TextBox_mv.Focus();
            TextBox_loaive.Enabled = true;
            TextBox_giave.Enabled = true;
            TextBox_NgayDi.Enabled = true;
            TextBox_mnd.Enabled = true;
            TextBox_matx.Enabled = true;

            Button_ghi.Enabled = true;
            Button_khghi.Enabled = true;

            Button_them.Enabled = false;
            Button_xoa.Enabled = false;
            Button_sua.Enabled = false;
            ViewState["flag"] = true;
        }

        protected void Button_co_Click(object sender, EventArgs e)
        {
            DAL.CommonClass kn = new DAL.CommonClass();
            int kq = kn.xulydukieu("DELETE Ve WHERE MaVe='" + TextBox_mv.Text + "'");
            if (kq > 0)
            {
                Label_thongbao.Text = "Bạn đã xóa thành công!";

                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Ve", sqlCon);
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
            if (TextBox_mv.Text == "" || TextBox_loaive.Text == "" || TextBox_giave.Text == "" || TextBox_NgayDi.Text == "" || TextBox_mnd.Text == "" || TextBox_matx.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để sửa!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("UPDATE TaiXe set LoaiVe='" + TextBox_loaive.Text + "', GiaVe='" + TextBox_giave.Text + "', NgayDi='" + TextBox_NgayDi.Text + "', MaNguoiDung='" + TextBox_mnd.Text + "', MaTx='" + TextBox_matx.Text + "' WHERE MaVe='" + TextBox_mv.Text + "'");
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
            if (TextBox_mv.Text == "" || TextBox_loaive.Text == "" || TextBox_giave.Text == "" || TextBox_NgayDi.Text == "" || TextBox_mnd.Text == "" || TextBox_matx.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để thêm!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("INSERT INTO TaiXe(Mave, LoaiVe, GiaVe, NgayDi, MaNguoiDung, MaTx) VALUES('" + TextBox_mv.Text + "', '" + TextBox_loaive.Text + "', '" + TextBox_giave.Text + "', '" + TextBox_NgayDi.Text + "', '" + TextBox_mnd.Text + "', '" + TextBox_matx.Text + "' ");
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

        protected void Button_ghi_Click(object sender, EventArgs e)
        {
            if((bool)ViewState["flag"] == true)
            {
                them();
                TextBox_mv.Enabled = false;
                TextBox_loaive.Enabled = false;
                TextBox_giave.Enabled = false;
                TextBox_NgayDi.Enabled = false;
                TextBox_mnd.Enabled = false;
                TextBox_matx.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
            else
            {
                sua();
                TextBox_mv.Enabled = false;
                TextBox_loaive.Enabled = false;
                TextBox_giave.Enabled = false;
                TextBox_NgayDi.Enabled = false;
                TextBox_mnd.Enabled = false;
                TextBox_matx.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
        }

        protected void Button_khghi_Click(object sender, EventArgs e)
        {
            TextBox_mv.Enabled = false;
            TextBox_loaive.Enabled = false;
            TextBox_giave.Enabled = false;
            TextBox_NgayDi.Enabled = false;
            TextBox_mnd.Enabled = false;
            TextBox_matx.Enabled = false;

            Button_ghi.Enabled = false;
            Button_khghi.Enabled = false;

            Button_them.Enabled = true;
            Button_xoa.Enabled = true;
            Button_sua.Enabled = true;
        }
    }
}