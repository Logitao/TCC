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
    public partial class FormNovoFornecedor : Form
    {

        private int modo = 0;
        private DataRow R;
        private Conn cn;

        public FormNovoFornecedor(int modo = 0, DataRow r = null)
        {
            InitializeComponent();
            this.modo = modo;
            R = r;
        }

        private void FormNovoFornecedor_Load(object sender, EventArgs e)
        {
            cn = new Conn();
            cn.Connect();

            if (modo == 1)
            {
                txtDesc.Text = R["DESCRICAO"].ToString();
                txtTel.Text = R["TELEFONE"].ToString();
                txtEmail.Text = R["EMAIL"].ToString();
                txtCEP.Text = R["CEP"].ToString();
                txtComp.Text = R["COMPLEMENTO"].ToString();
                txtCPFCNPJ.Text = R["CPF_CNPJ"].ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            if (modo == 0)
            {
                if (cn.ExecuteInsertTB_FORNECEDOR(txtCPFCNPJ.Text, txtComp.Text, txtCEP.Text, txtEmail.Text, txtTel.Text,
                    txtDesc.Text))
                {
                    MessageBox.Show("Fornecedor Cadastrado");
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 5, FormLogin.caixa);
                }
                else MessageBox.Show("Falha ao cadastrar");
            }
            else
            {
                int forn = Convert.ToInt32(R["IDFORNECEDOR"]);
                if (cn.ExecuteUpdateTB_FORNECEDOR(forn, txtCPFCNPJ.Text, txtComp.Text, txtCEP.Text, txtEmail.Text, txtTel.Text,
                    txtDesc.Text))
                {
                    MessageBox.Show("Fornecedor Atualizado");
      
                }
                else MessageBox.Show("Falha ao atualizar");

            }

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
