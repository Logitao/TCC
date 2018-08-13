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
    public partial class FormNovoCargo : Form
    {

        private int m = 0;
        private DataRow R;

        public FormNovoCargo(int modo = 0, DataRow r = null)
        {
            m = modo;
            R = r;
        }
        public FormNovoCargo()
        {
            InitializeComponent();
        }

        private void FormNovoCargo_Load(object sender, EventArgs e)
        {
            


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Conn cn = new Conn();
            cn.Connect();

            if (m == 0)
            {
                if (cn.ExecuteInsertTB_CARGO(txtDesc.Text, numericSalario.Value))
                {
                    MessageBox.Show("Cargo cadastrado");
                    cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 5, FormLogin.caixa);
                }
                else MessageBox.Show("Falha ao cadastrar");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
