using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class relatorios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
            Response.Redirect("index.aspx");
    }

    protected void logout_ServerClick(object sender, EventArgs e)
    {
        Session["id"] = null;
        Response.Redirect("index.aspx");
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}