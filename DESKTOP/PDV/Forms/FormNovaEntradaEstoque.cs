using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Classes;
using PDV.Conexão;
using PDV.Forms.Venda;

namespace PDV.Forms
{
    public partial class FormNovaEntradaEstoque : Form
    {

        Conn cn = new Conn();
        private List<KeyValuePair<int, long>> Dicionario = new List<KeyValuePair<int, long>>();
        private DataTable ProdQuantPreco;
        public FormNovaEntradaEstoque()
        {
            InitializeComponent();
        }

        private void FormNovaEntradaEstoque_Load(object sender, EventArgs e)
        {
            cn.Connect();
            ProdQuantPreco = new DataTable();

            DataColumn dt1 = new DataColumn("IDPRODUTO", typeof(long));
            DataColumn dt2 = new DataColumn("QUANTIDADE", typeof(int));
            DataColumn dt3 = new DataColumn("PRECO", typeof(decimal));
            ProdQuantPreco.Columns.Add(dt1);
            ProdQuantPreco.Columns.Add(dt2);
            ProdQuantPreco.Columns.Add(dt3);
            dgvProd.DataSource = ProdQuantPreco;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != "" && Regex.IsMatch(txtCodProduto.Text, @"^\d+$"))
            {
                long idprod = long.Parse(txtCodProduto.Text);
                Dicionario.Add(new KeyValuePair<int, long>(dgvProd.Columns.Count,idprod));

                Produto P = new Produto(idprod, 0, cn);
                if (string.IsNullOrEmpty(P.Nomeproduto))
                {
                    MessageBox.Show("Codigo invalido");
                    return;
                }
                Categoria C = new Categoria(P.Idcategoria, cn);

                DataRow R = ProdQuantPreco.NewRow();
                R[0] = idprod;
                R[1] = Convert.ToInt32(numericEntrada.Value);
                R[2] = P.Valorvenda;
                ProdQuantPreco.Rows.Add(R);


                txtDesc.Text = P.Nomeproduto;
                txtCategoria.Text = C.Descricao;
                txtUnidade.Text = P.Unidade;
                lblQuantAtual.Text = P.Qtatual.ToString();
                lblValorUnit.Text = P.Valorvenda.ToString("R$ 0.00");

                Total();
            }
            else MessageBox.Show("Codigo invalido");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows[0].Index != -1)
                ProdQuantPreco.Rows.RemoveAt(dgvProd.SelectedRows[0].Index);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ProdQuantPreco.Rows.Count > 0)
            {
                int quant = ProdQuantPreco.AsEnumerable().Sum(x => x.Field<int>("QUANTIDADE"));
                
                cn.ExecuteInsertTB_MVESTOQUE("E", quant);


                for (int i = 0; i < ProdQuantPreco.Rows.Count; i++)
                {
                    long idprod = (long) ProdQuantPreco.Rows[i]["IDPRODUTO"];
                    int idquantUni = (int) ProdQuantPreco.Rows[i]["QUANTIDADE"];
                    cn.ExecuteInsertTB_PRODUTO_MVESTOQUE(idprod,
                        Convert.ToInt32(cn.Query("SELECT * FROM TB_MVESTOQUE WHERE IDMOV = (SELECT MAX(IDMOV) FROM TB_MVESTOQUE)").Rows[0][0]), idquantUni);
                    cn.UpdateTB_PRODUTOQUANTIDADE(idprod, idquantUni);
                }
                cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 4, FormLogin.caixa);
                MessageBox.Show("Produtos inseridos no estoque com sucesso");
                this.Close();
            }

        }

        private void Total()
        {
            decimal i = ProdQuantPreco.AsEnumerable().Sum(x => x.Field<decimal>("PRECO") * x.Field<int>("QUANTIDADE"));
            lblValorTotal.Text = i.ToString("R$ 0.00");
        }

        

    }
}
