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
    public partial class Quanlydonvi : System.Web.UI.Page
    {
        string csdl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Capstone 1\Website\BusTracking\BusTracking\App_Data\Database1.mdf;Integrated Security=True";
        BLL.BLLAdmin BLLAdm = new BLL.BLLAdmin();
        public void loaddulieu()
        {
            SqlConnection sqlCon = new SqlConnection(csdl);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From DonViQLXe", sqlCon);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
            SqlConnection sqlCon = new SqlConnection(csdl);
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From DonViQLXe", sqlCon);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            Button_ghi.Enabled = false;
            Button_khghi.Enabled = false;
            Label_thongbao.Text = "";
            Button_co.Visible = false;
            Button_khong.Visible = false;

            TextBox_mdv.Enabled = false;
            TextBox_tendv.Enabled = false;
            TextBox_diachi.Enabled = false;
            TextBox_sdt.Enabled = false;
            TextBox_email.Enabled = false;

            TextBox_mdv.Text = dt.Rows[0]["MaDonVi"].ToString();
            TextBox_tendv.Text = dt.Rows[0]["TenDonVi"].ToString();
            TextBox_diachi.Text = dt.Rows[0]["DiaChi"].ToString();
            TextBox_sdt.Text = dt.Rows[0]["SoDienThoai"].ToString();
            TextBox_email.Text = dt.Rows[0]["Email"].ToString();

            ViewState["flag"] = false;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            string sql = "SELECT * FROM DonViQLXe";
            SqlDataAdapter da = new SqlDataAdapter(sql, csdl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TextBox_mdv.Text = dt.Rows[dong][0].ToString();
            TextBox_tendv.Text = dt.Rows[dong][1].ToString();
            TextBox_diachi.Text = dt.Rows[dong][2].ToString();
            TextBox_sdt.Text = dt.Rows[dong][3].ToString();
            TextBox_email.Text = dt.Rows[dong][4].ToString();
        }

        protected void Button_them_Click(object sender, EventArgs e)
        {
            TextBox_mdv.Text = "";
            TextBox_mdv.Focus();
            TextBox_mdv.Enabled = true;
            TextBox_tendv.Text = "";
            TextBox_tendv.Enabled = true;
            TextBox_diachi.Text = "";
            TextBox_diachi.Enabled = true;
            TextBox_sdt.Text = "";
            TextBox_sdt.Enabled = true;
            TextBox_email.Text = "";
            TextBox_email.Enabled = true;

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
            TextBox_mdv.Focus();
            TextBox_mdv.Enabled = true;
            TextBox_tendv.Enabled = true;
            TextBox_diachi.Enabled = true;
            TextBox_sdt.Enabled = true;
            TextBox_email.Enabled = true;

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
            int kq = kn.xulydukieu("DELETE DonViQLXe WHERE MaDonVi='" + TextBox_mdv.Text + "'");
            if (kq > 0)
            {
                Label_thongbao.Text = "Bạn đã xóa thành công!";

                SqlConnection sqlCon = new SqlConnection(csdl);
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From DonViQLXe", sqlCon);
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
            if (TextBox_mdv.Text == "" || TextBox_tendv.Text == "" || TextBox_diachi.Text == "" || TextBox_sdt.Text == "" || TextBox_email.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để sửa!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("UPDATE DonViQLXe set TenDonVi='" + TextBox_tendv.Text + "', DiaChi='" + TextBox_diachi.Text + "', SoDienThoai='" + TextBox_sdt.Text + "', Email='" + TextBox_email.Text + "' Where MaDonVi='" + TextBox_mdv.Text + "'");
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
            if (TextBox_mdv.Text == "" || TextBox_tendv.Text == "" || TextBox_diachi.Text == "" || TextBox_sdt.Text == "" || TextBox_email.Text == "")
            {
                Label_thongbao.Text = "Bạn chưa nhập dữ liệu để thêm!";
            }
            else
            {
                DAL.CommonClass DALCom = new DAL.CommonClass();
                int kq = DALCom.xulydukieu("INSERT INTO DonViQLXe (MaDonVi,TenDonVi,DiaChi,SoDienThoai,Email) VALUES( '" + TextBox_mdv.Text + "', '" + TextBox_tendv.Text + "','" + TextBox_diachi.Text + "','" + TextBox_sdt.Text + "', '" + TextBox_email.Text + "')");
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
                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_sua.Enabled = true;
                Button_xoa.Enabled = true;

                TextBox_mdv.Enabled = false;
                TextBox_tendv.Enabled = false;
                TextBox_diachi.Enabled = false;
                TextBox_sdt.Enabled = false;
                TextBox_email.Enabled = false;
            }
            else
            {
                sua();
                Button_ghi.Enabled = false;
                Button_khghi.Enabled = false;

                Button_them.Enabled = true;
                Button_sua.Enabled = true;
                Button_xoa.Enabled = true;

                TextBox_mdv.Enabled = false;
                TextBox_tendv.Enabled = false;
                TextBox_diachi.Enabled = false;
                TextBox_sdt.Enabled = false;
                TextBox_email.Enabled = false;
            }
        }

        protected void Button_khghi_Click(object sender, EventArgs e)
        {
            Button_them.Enabled = true;
            Button_sua.Enabled = true;
            Button_xoa.Enabled = true;
            Button_khghi.Enabled = false;
            Button_ghi.Enabled = false;

            TextBox_mdv.Enabled = false;
            TextBox_tendv.Enabled = false;
            TextBox_diachi.Enabled = false;
            TextBox_sdt.Enabled = false;
            TextBox_email.Enabled = false;
        }
    }
}