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

namespace PDV.Forms.Venda
{
    public partial class FormConfirmar : Form
    {
        public FormConfirmar()
        {
            InitializeComponent();
        }

        public Login L;
        private int Id;

        Conn cn = new Conn();
        public FormConfirmar(int formId)
        {
            InitializeComponent();
            Id = formId;
            cn.Connect();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            L = new Login(txtUsuario.Text, txtSenha.Text, cn);

            if (L.LoginSucesso && L.IdPermissao == 1)
            {
                MessageBox.Show("Usuario não possui permissão");
                Limpar();
                return;
            }
            else if (!L.LoginSucesso)
            {
                MessageBox.Show("Usuario/Senha incorretos");
                Limpar();
                return;
            }

            switch (Id)
            {

                case 1:
                    lblTexto.Text = "CONFIRMAR CANCELAMENTO";
                    if (L.LoginSucesso && L.IdPermissao == 2)
                    {
                        MessageBox.Show("Cancelamento confirmado");
                        FormCancelamentoItem.cancelamentoConfirmado = true;
                        this.Close();

                    }
                    break;

                case 2:
                    lblTexto.Text = "CANCELAR VENDA";
                    if (L.LoginSucesso && L.IdPermissao == 2)
                    {
                        MessageBox.Show("Cancelamento de venda confirmado");
                        FormPrincipalVenda.cancelarVenda = true;
                        this.Close();

                    }
                    break;

            }
        }
        private void Limpar()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }
    }
}
