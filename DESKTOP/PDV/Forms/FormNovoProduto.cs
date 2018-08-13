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

namespace PDV.Forms
{
    public partial class FormNovoProduto : Form
    {
        Conn cn = new Conn();
        private DataTable categoria;
        private DataTable fornecedor;

        private int modo = 0;
        private DataRow R;

        public FormNovoProduto(int modo = 0, DataRow r = null)
        {
            InitializeComponent();
            this.modo = modo;
            R = r;
        }

        private void FormNovoProduto_Load(object sender, EventArgs e)
        {
            cn.Connect();
            categoria = cn.Query("SELECT * FROM TB_CATEGORIA");
            fornecedor = cn.Query("SELECT * FROM TB_FORNECEDOR");

            cmbCategoria.DataSource = categoria;
            cmbCategoria.DisplayMember = "DESCRICAO";
            cmbCategoria.ValueMember = "IDCATEGORIA";

            cmbFornecedor.DataSource = fornecedor;
            cmbFornecedor.DisplayMember = "DESCRICAO";
            cmbFornecedor.ValueMember = "IDFORNECEDOR";

            if (modo == 1)
            {
                txtDesc.Text = R["NOMEPRODUTO"].ToString();
                numericVenda.Value = Convert.ToDecimal(R["VALORVENDA"]);
                txtUnidade.Text = R["UNIDADE"].ToString();


                for (int i = 0; i < cmbCategoria.Items.Count; i++)
                {
                    cmbCategoria.SelectedIndex = i;
                    if (cmbCategoria.SelectedValue.ToString() == R["IDCATEGORIA"].ToString())
                        break;
                }

                for (int i = 0; i < cmbFornecedor.Items.Count; i++)
                {
                    cmbFornecedor.SelectedIndex = i;
                    if (cmbFornecedor.SelectedValue.ToString() == R["IDFORNECEDOR"].ToString())
                        break;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                if (txtCod.Text == "")
                {

                    int idforn = Convert.ToInt32(cmbFornecedor.SelectedValue);
                    int idcat = Convert.ToInt32(cmbCategoria.SelectedValue);
                    if (cn.ExecuteInsertTB_PRODUTO(idforn, idcat, txtDesc.Text, txtUnidade.Text, numericVenda.Value))
                    {
                        MessageBox.Show("Produto cadastrado");
                        cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 5, FormLogin.caixa);
                    }
                    else MessageBox.Show("Falha ao cadastrar");

                    this.Close();
                }
                else
                {
                    long idproduto = Convert.ToInt64(txtCod.Text);
                    int idforn = Convert.ToInt32(cmbFornecedor.SelectedValue);
                    int idcat = Convert.ToInt32(cmbCategoria.SelectedValue);
                    if (cn.ExecuteInsertTB_PRODUTO(idproduto, idforn, idcat, txtDesc.Text, txtUnidade.Text, numericVenda.Value))
                    {
                        MessageBox.Show("Produto cadastrado");
                        cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 5, FormLogin.caixa);
                    }
                    else MessageBox.Show("Falha ao cadastrar");

                    this.Close();
                }
            }
            else
            {
                int idforn = Convert.ToInt32(cmbFornecedor.SelectedValue);
                int idcat = Convert.ToInt32(cmbCategoria.SelectedValue);
                long idprod = Convert.ToInt32(R["IDPRODUTO"]);
                if (cn.ExecuteUpdateTB_PRODUTO(idprod, idforn, idcat, txtDesc.Text, txtUnidade.Text, numericVenda.Value))
                {
                    MessageBox.Show("Produto atualizado");
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 6, FormLogin.caixa);
                    this.Close();
                }
                else MessageBox.Show("Falha ao Atualizar");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovaCat_Click(object sender, EventArgs e)
        {
            FormNovaCategoria frm = new FormNovaCategoria();
            this.Hide();
            frm.ShowDialog(this);
            this.Show();
            CarregarCombo();

        }

        private void btnNovoForn_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor frm = new FormNovoFornecedor();
            this.Hide();
            frm.ShowDialog(this);
            this.Show();

            CarregarCombo();
        }


        private void CarregarCombo()
        {

            categoria = cn.Query("SELECT * FROM TB_CATEGORIA");
            fornecedor = cn.Query("SELECT * FROM TB_FORNECEDOR");

            cmbCategoria.DataSource = categoria;
            cmbCategoria.DisplayMember = "DESCRICAO";
            cmbCategoria.ValueMember = "IDCATEGORIA";

            cmbFornecedor.DataSource = fornecedor;
            cmbFornecedor.DisplayMember = "DESCRICAO";
            cmbFornecedor.ValueMember = "IDFORNECEDOR";
        }

       
    }

   
}
