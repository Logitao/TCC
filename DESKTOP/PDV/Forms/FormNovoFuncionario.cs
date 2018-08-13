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
    public partial class FormNovoFuncionario : Form
    {
        Conn cn = new Conn();
        private DataTable cargo;
        int modo;
        DataRow R;
        public FormNovoFuncionario(int modo = 0, DataRow R = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.R = R;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                int idcarg = Convert.ToInt32(cmbCargo.SelectedValue);
                string sexo = (rdioSexoM.Checked) ? "M" : "F";
                if (cn.ExecuteInsertTB_FUNCIONARIO(idcarg, txtNome.Text, sexo, Convert.ToDateTime(txtDataNasc.Text),
                    txtRG.Text, txtCPF.Text, txtNumRes.Text, txtCEP.Text, txtTel.Text, txtEmail.Text, txtCompl.Text))
                {
                    MessageBox.Show("Funcionario cadastrado");
                    FuncForm.LimparTextBox(this);
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 5, FormLogin.caixa);
                }
                else MessageBox.Show("Falha ao cadastrar");
            }
            else
            {
                int idcarg = Convert.ToInt32(cmbCargo.SelectedValue);
                int idfunc = Convert.ToInt32(R["IDFUNCIONARIO"]);
                string sexo = (rdioSexoM.Checked) ? "M" : "F";
                
                if (cn.ExecuteUpdateTB_FUNCIONARIO(idfunc, idcarg, txtNome.Text, sexo, Convert.ToDateTime(txtDataNasc.Text),
                    txtRG.Text, txtCPF.Text, txtNumRes.Text, txtCEP.Text, txtTel.Text, txtEmail.Text, txtCompl.Text))
                {
                    MessageBox.Show("Funcionario Atualizado");
                    FuncForm.LimparTextBox(this);
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 6, FormLogin.caixa);
                    this.Close();
                }
            }
        }

        private void FormNovoFuncionario_Load(object sender, EventArgs e)
        {
            try
            { 
            cn.Connect();

            cargo = cn.Query("SELECT * FROM TB_CARGO");
            cmbCargo.DataSource = cargo;
            cmbCargo.DisplayMember = "DESCRICAO";
            cmbCargo.ValueMember = "IDCARGO";

                if (modo == 1)
                {
                    txtNome.Text = R["NOME"].ToString();
                    txtDataNasc.Text = R["DT_NASC"].ToString();
                    txtCPF.Text = R["CPF"].ToString();
                    txtTel.Text = R["TELEFONE"].ToString();
                    txtRG.Text = R["RG"].ToString();

                    rdioSexoM.Checked = (R["SEXO"].ToString() == "M");

                    txtEmail.Text = R["EMAIL"].ToString();
                    txtCEP.Text = R["CEP"].ToString();
                    txtNumRes.Text = R["NUM_RESID"].ToString();
                    txtCompl.Text = R["COMPLEMENTO"].ToString();

                    for (int i = 0; i < cmbCargo.Items.Count; i++)
                    {
                        cmbCargo.SelectedIndex = i;
                        if (cmbCargo.SelectedValue.ToString() == R["IDCARGO"].ToString())
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormNovoCargo frm = new FormNovoCargo();
            this.Hide();
            frm.ShowDialog(this);
            this.Show();

            CarregarCombo();

        }
        private void CarregarCombo()
        {
            cmbCargo.DataSource = null;
            cargo = cn.Query("SELECT * FROM TB_CARGO");
            cmbCargo.DataSource = cargo;
            cmbCargo.DisplayMember = "DESCRICAO";
            cmbCargo.ValueMember = "IDCARGO";
        }
       
    }
}
