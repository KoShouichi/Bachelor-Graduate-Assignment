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

public partial class AddTopic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Alert.AlertAndRedirect("对不起您还没有登录", "Login.aspx");
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
 SqlHelper data = new SqlHelper();
        data.RunSql("insert into Topic(Topic,AddUser,Contents)values('" + tb_title.Text + "','" + Session["User"].ToString() + "','" + ArticleContent.Value + "')");
        Alert js = new Alert();
        js.Alertjs("发布成功");
        Response.Redirect("LyList.aspx");
    }
}
