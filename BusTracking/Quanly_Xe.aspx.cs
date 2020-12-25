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
    public partial class Quanly_Xe : System.Web.UI.Page
    {
        string csdl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        BLL.BLLAdmin BLLAdm = new BLL.BLLAdmin();
        public void loaddulieu()
        {
            SqlConnection sqlCon = new SqlConnection(csdl);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Xe", sqlCon);
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Xe", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;
                Label_thongbao.Text = "";
                Button_co.Visible = false;
                Button_khong.Visible = false;

                TextBox_mx.Enabled = false;
                TextBox_bs.Enabled = false;
                TextBox_lx.Enabled = false;
                TextBox_sg.Enabled = false;
                TextBox_cs.Enabled = false;
                TextBox_nsx.Enabled = false;
                TextBox_ckbh.Enabled = false;
                TextBox_mt.Enabled = false;

                TextBox_mx.Text = dt.Rows[0]["MaXe"].ToString();
                TextBox_bs.Text = dt.Rows[0]["BienSo"].ToString();
                TextBox_lx.Text = dt.Rows[0]["LoaiXe"].ToString();
                TextBox_sg.Text = dt.Rows[0]["SoGhe"].ToString();
                TextBox_cs.Text = dt.Rows[0]["CongSuat"].ToString();
                TextBox_nsx.Text = dt.Rows[0]["NgaySX"].ToString();
                TextBox_ckbh.Text = dt.Rows[0]["ChuKiBaoHanh"].ToString();
                TextBox_mt.Text = dt.Rows[0]["MaTuyen"].ToString();
                ViewState["flag"] = false;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            string sql = "SELECT * FROM Xe";
            SqlDataAdapter da = new SqlDataAdapter(sql, csdl);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox_mx.Text = dt.Rows[dong][0].ToString();
            TextBox_bs.Text = dt.Rows[dong][1].ToString();
            TextBox_lx.Text = dt.Rows[dong][2].ToString();
            TextBox_sg.Text = dt.Rows[dong][3].ToString();
            TextBox_cs.Text = dt.Rows[dong][4].ToString();
            TextBox_nsx.Text = dt.Rows[dong][5].ToString();
            TextBox_ckbh.Text = dt.Rows[dong][6].ToString();
            TextBox_mt.Text = dt.Rows[dong][7].ToString();
        }

        protected void Button_them_Click(object sender, EventArgs e)
        {
            TextBox_mx.Text = "";
            TextBox_mx.Focus();
            TextBox_bs.Text = "";
            TextBox_lx.Text = "";
            TextBox_sg.Text = "";
            TextBox_cs.Text = "";
            TextBox_nsx.Text = "";
            TextBox_ckbh.Text = "";
            TextBox_mt.Text = "";
            TextBox_mx.Enabled = true;
            TextBox_bs.Enabled = true;
            TextBox_lx.Enabled = true;
            TextBox_sg.Enabled = true;
            TextBox_cs.Enabled = true;
            TextBox_nsx.Enabled = true;
            TextBox_ckbh.Enabled = true;
            TextBox_mt.Enabled = true;

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
            TextBox_mx.Focus();
            TextBox_mx.Enabled = true;
            TextBox_bs.Enabled = true;
            TextBox_lx.Enabled = true;
            TextBox_sg.Enabled = true;
            TextBox_cs.Enabled = true;
            TextBox_nsx.Enabled = true;
            TextBox_ckbh.Enabled = true;
            TextBox_mt.Enabled = true;

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
            int kq = kn.xulydukieu("DELETE Xe WHERE MaXe='" + TextBox_mx.Text + "'");
            if (kq > 0)
            {
                Label_thongbao.Text = "Bạn đã xóa thành công!";

                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Xe", sqlCon);
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
            if (TextBox_mx.Text == "" || TextBox_bs.Text == "" || TextBox_lx.Text == "" || TextBox_sg.Text == "" || TextBox_cs.Text == "" || TextBox_nsx.Text == "" || TextBox_ckbh.Text == "" || TextBox_mt.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để sửa!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("UPDATE Xe set BienSo='" + TextBox_bs.Text + "', LoaiXe='" + TextBox_lx.Text + "', SoGhe='" + TextBox_sg.Text + "', CongSuat='" + TextBox_cs.Text + "', NgaySX='" + TextBox_nsx.Text + "', ChuKiBaoHanh='" + TextBox_ckbh.Text + "', MaTuyen='" + TextBox_mt.Text + "' WHERE MaXe='" + TextBox_mx.Text + "'");
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
            if (TextBox_mx.Text == "" || TextBox_bs.Text == "" || TextBox_lx.Text == "" || TextBox_sg.Text == "" || TextBox_cs.Text == "" || TextBox_nsx.Text == "" || TextBox_ckbh.Text == "" || TextBox_mt.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để thêm!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("INSERT INTO Xe(MaXe,BienSo,LoaiXe,SoGhe,CongSuat,NgaySX,ChuKiBaoHanh,MaTuyen) VALUES('" + TextBox_mx.Text + "', '" + TextBox_bs.Text + "', '" + TextBox_lx.Text + "', '" + TextBox_sg.Text + "', '" + TextBox_cs.Text + "', '" + TextBox_nsx.Text + "', '" + TextBox_ckbh.Text + "', '" + TextBox_mt.Text + "')");
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
                TextBox_mx.Enabled = false;
                TextBox_bs.Enabled = false;
                TextBox_lx.Enabled = false;
                TextBox_sg.Enabled = false;
                TextBox_cs.Enabled = false;
                TextBox_nsx.Enabled = false;
                TextBox_ckbh.Enabled = false;
                TextBox_mt.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
            else
            {
                sua();
                TextBox_mx.Enabled = false;
                TextBox_bs.Enabled = false;
                TextBox_lx.Enabled = false;
                TextBox_sg.Enabled = false;
                TextBox_cs.Enabled = false;
                TextBox_nsx.Enabled = false;
                TextBox_ckbh.Enabled = false;
                TextBox_mt.Enabled = false;

                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_xoa.Enabled = true;
                Button_sua.Enabled = true;
            }
        }

        protected void Button_khghi_Click(object sender, EventArgs e)
        {
            TextBox_mx.Enabled = false;
            TextBox_bs.Enabled = false;
            TextBox_lx.Enabled = false;
            TextBox_sg.Enabled = false;
            TextBox_cs.Enabled = false;
            TextBox_nsx.Enabled = false;
            TextBox_ckbh.Enabled = false;
            TextBox_mt.Enabled = false;

            Button_ghi.Enabled = false;
            Button_khghi.Enabled = false;

            Button_them.Enabled = true;
            Button_xoa.Enabled = true;
            Button_sua.Enabled = true;
        }
    }
}