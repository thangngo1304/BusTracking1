﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BusTracking
{
    public partial class Login1 : System.Web.UI.Page
    {
        BLL.BLLAdmin BLLAdm = new BLL.BLLAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string ten = TextBox1.Text;
            string matkhau = TextBox2.Text;
            DataTable dt = BLLAdm.login(ten, matkhau);
            if (dt.Rows.Count > 0)
            {
                Response.Cookies["TENDANGNHAP"].Value = ten;
                Response.Cookies["MATKHAU"].Value = matkhau;
                Response.Cookies["TENDANGNHAP"].Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies["MATKHAU"].Expires = DateTime.Now.AddMinutes(1);
                Server.Transfer("quanlynhansu.aspx");
            }
            else
            {
                this.Label1.Text = "Tên đăng nhập hoặc mật khẩu sai";
            }
        }
    }
}