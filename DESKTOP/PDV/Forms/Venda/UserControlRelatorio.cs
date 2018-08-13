using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Conexão;

namespace PDV.Forms.Venda
{
    public partial class UserControlRelatorio : UserControl
    {
        Conn cn = new Conn();
        private DataTable vendas, totalprodutos;
        public UserControlRelatorio()
        {
            InitializeComponent();
            cn.Connect();
        }
        
        private void UserControlRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                vendas = cn.Query("SELECT * FROM VW_RELATORIO_VENDA");
                totalprodutos = cn.Query("SELECT * FROM VW_TOTAL_VENDIDOS");
                decimal lucroTotal = Convert.ToDecimal(cn.Query("SELECT * FROM VW_VALOR_TOTAL_VENDAS ").Rows[0]["TOTAL"]);
                int quantProd = Convert.ToInt32(cn.Query("SELECT * FROM VW_TOTAL_PRODUTOS_VENDIDOS").Rows[0]["TOTAL"]);
                graficoVendas.DataSource = vendas;
                graficoVendas.Series["serieValorTotal"].XValueMember = "MES";
                graficoVendas.Series["serieValorTotal"].YValueMembers = "TOTAL";
                graficoVendas.Series["serieValorTotal"].IsValueShownAsLabel = true;
                graficoVendas.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                graficoVendas.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                graficoVendas.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                graficoVendas.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
  
                graficoVendas.Series[0].Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);

                graficoProdutos.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                graficoProdutos.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);

                graficoProdutos.Series[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

                graficoProdutos.DataSource = totalprodutos;
                graficoProdutos.Series["serieValor"].XValueMember = "MES";
                graficoProdutos.Series["serieValor"].YValueMembers = "TOTAL";
                lblLucro.Text = "VALOR TOTAL : " + lucroTotal.ToString("R$ 0.00");
                lblTotal.Text = "TOTAL VENDIDO : " + quantProd.ToString();
            }
            catch
            {
                
            }
        }
    }
}
