<%@ Page Language="C#" AutoEventWireup="true" CodeFile="relatoriovendames.aspx.cs" Inherits="relatoriovendasmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/animation.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/font-awesome.css" rel="stylesheet" />
    <link href="css/linecons.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <header id="header_outer">
		<div class="container">
			<div class="header_section">
				<div class="logo"><a href="javascript:void(0)"><img src="img/logo.jpg" width="49" height="45" alt=""></a></div>
				<nav class="nav" id="nav">
					<ul class="toggle">
						<li><a href="relatorios.aspx">Relatório de vendas</a></li>
                        <li><a href="relatoriosvendames.aspx">Relatório de vendas/Mês</a></li>
                        <li><a href="relatorioevento.aspx">Relatório de Eventos</a></li>
			            <li><a href="graficos.aspx">Gráficos</a></li>
					</ul>
					<ul class="">
						<li><a href="relatorios.aspx">Relatório de vendas</a></li>
                        <li><a href="relatoriovendames.aspx">Relatório de vendas/Mês</a></li>
                        <li><a href="relatorioevento.aspx">Relatório de Eventos</a></li>
                        <li><a href="graficos.aspx">Gráficos</a></li>
                        <li><a href="" runat="server"  id="login" onserverclick="login_ServerClick">Logout</a></li>
					</ul>
				</nav>
				
				<a class="res-nav_click animated wobble wow" href="javascript:void(0)"><i class="fa-bars"></i></a> </div>
		</div>
	</header>
	<!--Header_section-->

    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="VwMes" Font-Size="115%" Width="598px" ForeColor="Black" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="MES" HeaderText="MES" SortExpression="MES" />
                    <asp:BoundField DataField="TOTAL" HeaderText="TOTAL" SortExpression="TOTAL" />
                </Columns>
        </asp:GridView>
            <br />
        <div style="text-align:center">
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        
        <asp:SqlDataSource ID="VwMes" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM VW_RELATORIO_VENDA"></asp:SqlDataSource>
        
    </form>
</body>
</html>
