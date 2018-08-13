using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Conexão;

namespace PDV
{
    public partial class FormRelatorio : Form
    {
        Conn cn = new Conn();
        private DataTable vendas, totalprodutos;
        public FormRelatorio()
        {
            InitializeComponent();
            cn.Connect();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable P = cn.Query("SELECT * FROM TB_PRODUTO");
                DataTable M = cn.Query("SELECT * FROM WWV_FLOW_MONTHS_MONTH");
                DataTable V = cn.Query("SELECT * FROM VW_TOTAL_VENDAS");
                cmbProduto.DisplayMember = "NOMEPRODUTO";
                cmbProduto.ValueMember = "IDPRODUTO";
                cmbProduto.DataSource = P;

                cmbMes.DisplayMember = "MONTH_DISPLAY";
                cmbMes.ValueMember = "MONTH_VALUE";
                cmbMes.DataSource = M;
                txtTotalVenda.Text = V.Rows[0]["QUANT"].ToString();
            }
            catch
            {
                MessageBox.Show("Test");
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtQuant.Text = "0";
                txtValor.Text = "R$ 0.00";
                string selected = cmbProduto.GetItemText(cmbProduto.SelectedValue);
                DataTable T =
                    cn.Query("SELECT * FROM VW_QUANT_VENDIDO WHERE IDPRODUTO = " + selected);


                if (T.Rows.Count != 0)
                    if (T.Rows[0]["QUANT"] is DBNull)
                        txtQuant.Text = "0";
                    else
                        txtQuant.Text = T.Rows[0]["QUANT"].ToString();
                DataTable B = cn.Query("SELECT IDPRODUTO, QUANT, VALORVENDA * QUANT VALOR FROM VW_QUANT_VENDIDO WHERE IDPRODUTO = " + selected);
                if (B.Rows.Count > 0)
                    txtValor.Text = Convert.ToDecimal(B.Rows[0]["VALOR"]).ToString("R$ 0.00");
                
                txtTotalVendas.Text = Convert.ToDecimal(cn.Query("SELECT * FROM VW_VALOR_VENDAS").Rows[0]["QUANT"]).ToString("R$ 0.00");
            }
            catch
            {
                txtQuant.Text = "0";
                txtValor.Text = "R$ 0.00";
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            string sql2 = "";
            switch (cmbMes.SelectedIndex )
            {
                case 0:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_JAN";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_JAN";
                    break;
                case 1:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_FEV";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_FEV";
                    break;
                case 2:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_MAR";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_MAR";
                    break;
                case 3:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_ABR";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_ABR";
                    break;
                case 4:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_MAI";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_MAI";
                    break;
                case 5:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_JUN";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_JUN";
                    break;
                case 6:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_JUL";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_JUL";
                    break;
                case 7:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_AGO";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_AGO";
                    break;
                case 8:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_SET";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_SET";
                    break;
                case 9:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_OUT";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_OUT";
                    break;
                case 10:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_NOV";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_NOV";
                    break;
                case 11:
                    sql = "SELECT * FROM VW_TOTAL_VENDAS_DEZ";
                    sql2 = "SELECT * FROM VW_VALOR_VENDAS_DEZ";
                    break;
                default:
                    sql = "SELECT * FROM DUAL";
                    break;

            }
            DataTable C = cn.Query(sql);
            DataTable M = cn.Query(sql2);
            txtTotalMes.Text = C.Rows[0]["QUANT"].ToString();
            if (M.Rows[0]["QUANT"] is DBNull)
                txtValorTotalMes.Text = "R$ 0.00";
            else
                txtValorTotalMes.Text = Convert.ToDecimal(M.Rows[0]["QUANT"]).ToString("R$ 0.00") ?? "R$ 0.00";
            
        }

    }
}
