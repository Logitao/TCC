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
    public partial class FormNovaCategoria : Form
    {
        private int modo = 0;
        private DataRow R;

        public FormNovaCategoria(int modo = 0, DataRow r = null)
        {
            InitializeComponent();
            this.modo = modo;
            R = r;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Conn cn = new Conn();
            cn.Connect();

            if (modo == 0)
            {
                if (cn.ExecuteInsertTB_CATEGORIA(txtDesc.Text))
                {
                    MessageBox.Show("Catergoria cadastrada");
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 5, FormLogin.caixa);
                }
                else
                    MessageBox.Show("Falha ao cadastrar");

                FuncForm.LimparTextBox(this);
            }
            else
            {
                int id = Convert.ToInt32(R["IDCATEGORIA"]);
                if (cn.ExecuteUpdateTB_CATEGORIA(id, txtDesc.Text))
                {
                    MessageBox.Show("Catergoria atualizada");
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 6, FormLogin.caixa);
                    this.Close();
                }
                else
                    MessageBox.Show("Falha ao atualizar");

            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNovaCategoria_Load(object sender, EventArgs e)
        {
            if (modo == 1)
                txtDesc.Text = R["DESCRICAO"].ToString();

        }
    }
}
