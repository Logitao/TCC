﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class graficos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
            Response.Redirect("index.aspx");
    }


    protected void login_ServerClick(object sender, EventArgs e)
    {
        Session["id"] = null;
        Response.Redirect("index.aspx");
    }
}