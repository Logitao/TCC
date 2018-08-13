using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["id"] = null;
    }

    protected void Login(object sender, EventArgs e)
    {
        DataTable T = ((DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty)).Table;
        string usuario = Request.Form["usuario"];
        string senha = Request.Form["senha"];

        bool login = T.Select().Any(x => x.ItemArray[3].ToString() == Request.Form["usuario"].Trim() 
        && x.ItemArray[4].ToString() == Request.Form["senha"].Trim() && x.ItemArray[2].ToString() == 2.ToString());

        Session["id"] = 1;
        if (login)
            Response.Redirect("relatorios.aspx");
        else
            lblMens.Text = "Usuario Senha/Incorretos";

    }
}