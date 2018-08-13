using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.Forms.Venda
{
    public partial class FormCancelamentoItem : Form
    {
        public static bool cancelamentoConfirmado = false;
        List<int> idInternos = new List<int>();
        List<int> selectedInternos = new List<int>();

        private List<Produto> ListaProdutoStatus1 = new List<Produto>();
        public FormCancelamentoItem()
        {
            InitializeComponent();
        }

        private void FormCancelamentoItem_Load(object sender, EventArgs e)
        {
            ListaProdutoStatus1 = FormPrincipalVenda.ListaProduto
                .Where(x => x.Status == 1)
                .ToList();

            ListaProdutoStatus1.ForEach(x =>
            {
                listBoxListaItens.Items.Add(x.Nomeproduto + " ITEM " + x.Idinterno.ToString());
                idInternos.Add(x.Idinterno);
            });
            idInternos = FormPrincipalVenda.ListaProduto.Where(x => x.Status == 1).Select(x => x.Idinterno).ToList();
            listBoxListaItens.SelectedIndex = -1;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            if (listBoxItensCancelados.Items.Count > 1)
            {
                selectedInternos.Clear();
                listBoxItensCancelados.Items.Clear();
            }
            listBoxListaItens.SelectedIndices.OfType<int>().ToList().ForEach(x =>
            {
                selectedInternos.Add(idInternos.ElementAt(x));
                listBoxItensCancelados.Items.Add(listBoxListaItens.Items[x]);
            });

        }

        private void btnRemoverCancelado_Click(object sender, EventArgs e)
        {

            listBoxItensCancelados.Items.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormConfirmar frm = new FormConfirmar(1);
            frm.ShowDialog();

            if (cancelamentoConfirmado)
            {

                for (int i = 0; i < selectedInternos.Count; i++)
                {
                    var i1 = i;
                    FormPrincipalVenda.ListaProduto.
                        Where(p => p.Idinterno == selectedInternos[i1]).
                        ToList().
                        ForEach(p => p.Status = 0);
                }


                this.Close();
            }
            else MessageBox.Show("Cancelamento negado");

        }

           
    }
}
