﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class Admin_Modify_CourseInfo : System.Web.UI.Page
{

    SqlHelper data = new SqlHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlDataReader dr = data.GetDataReader("select * from Course where id=" + Request.QueryString["id"].ToString());
            if (dr.Read())
            {

                txtUser.Text = dr["name"].ToString();
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        data.RunSql("update Course set  name='" + txtUser.Text + "'where id=" + Request.QueryString["id"].ToString());
        Alert.AlertAndRedirect("修改成功", "CourseManger.aspx");
    }
}
