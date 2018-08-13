<%@ Page Language="C#" AutoEventWireup="true" CodeFile="relatorios.aspx.cs" Inherits="relatorios" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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
                        <li><a href="graficos.aspx" runat="server" onserverclick="logout_ServerClick">Logout</a></li>
					</ul>
				</nav>
				
				<a class="res-nav_click animated wobble wow" href="javascript:void(0)"><i class="fa-bars"></i></a> </div>
		</div>
	</header>
	<!--Header_section-->

    <form id="form1" runat="server">
        <div style="text-align:center">
            <br />
        <div style="text-align:center">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="VwVenda" Font-Size="115%" Width="598px" ForeColor="Black" HorizontalAlign="Center" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="CUPOM" HeaderText="CUPOM" SortExpression="CUPOM" />
                    <asp:BoundField DataField="DATA_EMISSAO" HeaderText="DATA_EMISSAO" SortExpression="DATA_EMISSAO" />
                    <asp:BoundField DataField="VALOR" HeaderText="VALOR" SortExpression="VALOR" />
                    <asp:BoundField DataField="VALOR_PAGO" HeaderText="VALOR_PAGO" SortExpression="VALOR_PAGO" />
                    <asp:BoundField DataField="FUNCIONARIO" HeaderText="FUNCIONARIO" SortExpression="FUNCIONARIO" />
                </Columns>
        </asp:GridView>
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
        <asp:SqlDataSource ID="VwVenda" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM VW_VENDA"></asp:SqlDataSource>
        
    </form>
</body>
</html>
