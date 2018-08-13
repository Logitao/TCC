<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, maximum-scale=1"/>
	<title>Homepage</title>
    <link rel="icon" href="favicon.jpg" type="image/png"/>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
    <link href="css/style.css" rel="stylesheet" type="text/css"/>
    <link href="css/linecons.css" rel="stylesheet" type="text/css"/>
    <link href="css/font-awesome.css" rel="stylesheet" type="text/css"/>
    <link href="css/responsive.css" rel="stylesheet" type="text/css"/>
    <link href="css/animate.css" rel="stylesheet" type="text/css"/>

    <link href='https://fonts.googleapis.com/css?family=Lato:400,900,700,700italic,400italic,300italic,300,100italic,100,900italic' rel='stylesheet' type='text/css'/>
    <link href='https://fonts.googleapis.com/css?family=Dosis:400,500,700,800,600,300,200' rel='stylesheet' type='text/css'/>

</head>
<body>
    <form id="form1" runat="server">
    <div class="col-lg-6 wow fadeInUp delay-06s" >

								<div class="form-group">
									<input type="text" name="name" class="form-control input-text" id="usuario" placeholder="Usuario" runat="server" style="color:black"/>
									<div class="validation"></div>
								</div>
								<div class="form-group">
									<input type="password" class="form-control input-text" name="email" id="senha" placeholder="Senha" runat="server" style="color:black" />
									<div class="validation"></div>
								</div>

								<button id="btnLogar" type="submit" class="btn input-btn" runat="server" onserverclick="Login">Login</button>
                                <br />
                                <br />
                                <asp:Label ID="lblMens" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                                <br />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM TB_USUARIO"></asp:SqlDataSource>
    </form>
</body>
</html>
