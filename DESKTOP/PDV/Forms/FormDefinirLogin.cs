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
    public partial class FormDefinirLogin : Form
    {
        Conn cn = new Conn();
        public FormDefinirLogin()
        {
            InitializeComponent();
            cn.Connect();
        }

        private void FormDefinirLogin_Load(object sender, EventArgs e)
        {
            LstFuncionario.DisplayMember = "NOME";
            LstFuncionario.ValueMember = "IDFUNCIONARIO";
            LstFuncionario.DataSource = cn.Query("SELECT * FROM TB_FUNCIONARIO LEFT JOIN TB_USUARIO USING(IDFUNCIONARIO) WHERE IDUSUARIO IS NULL");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfSenha.Text == txtSenha.Text)
                {
                    MessageBox.Show("Usuario Definido : " + txtLogin.Text);
                    int id = Convert.ToInt32(LstFuncionario.SelectedValue);
                    if (cn.ExecuteInsertTB_USUARIO(id, txtLogin.Text, txtSenha.Text, 1, cmbNivel.SelectedIndex + 1))
                    {
                        
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Verifique a confimação da senha");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
