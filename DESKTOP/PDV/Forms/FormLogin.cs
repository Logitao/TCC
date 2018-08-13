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
using PDV.Forms;
using PDV.Forms.Venda;

namespace PDV
{
    public partial class FormLogin : Form
    {
        Conn cn = new Conn();
        public static string usuario, senha;
        public static int caixa = 1, idusuario;
        public FormLogin()
        {
            cn.Connect();
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Login L = new Login(txtUsuario.Text, txtSenha.Text, cn);
            if (L.LoginSucesso)
            {
                MessageBox.Show("Logado como " + L.Usuario);
                usuario = L.Usuario;
                senha = L.Senha;
                idusuario = L.IdUsuario;

                cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 1, FormLogin.caixa);
                if (L.IdPermissao < 2)
                {
                    FormPrincipalVenda frm = new FormPrincipalVenda(L.Usuario);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();

                }
                else if (L.IdPermissao >= 2)
                {
                    FormPrincipal frm = new FormPrincipal();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    FuncForm.LimparTextBox(this);
                }

                cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 2, FormLogin.caixa);
            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            usuario = "";
            senha = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
