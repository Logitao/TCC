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
    public partial class FormConsulta : Form
    {
        private DataTable T;
        private Form altera;
        Conn cn = new Conn();
        bool visivel;
        public FormConsulta(DataTable Mostrar, Form alterar, bool v = true)
        {
            T = Mostrar;

            InitializeComponent();
            altera = alterar;

            cn.Connect();
            visivel = v;
            btnAlterar.Visible = btnExcluir.Visible = visivel;
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            dgv.DataSource = T;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesq.Text == "")
                return;
            List<DataRow> LDR = new List<DataRow>();
            foreach (DataRow r in T.Rows)
                foreach (var c in r.ItemArray)     
                    if (c.ToString().Contains(txtPesq.Text))        
                        LDR.Add(r);
                    
            DataTable B = T.Clone();
            LDR.ForEach(r => B.Rows.Add(r.ItemArray));
            dgv.DataSource = B;
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if (txtPesq.Text == "")
                dgv.DataSource = T;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (altera.GetType() == typeof(FormNovoFuncionario))
            {
                DataRow r = ((DataRowView)dgv.SelectedRows[0].DataBoundItem).Row;
                FormNovoFuncionario f = new FormNovoFuncionario(1, r);
                f.ShowDialog(this);
                T = cn.Query("SELECT * FROM TB_FUNCIONARIO");
                dgv.DataSource = T;
                
            }
            if (altera.GetType() == typeof(FormNovoProduto))
            {
                DataRow r = ((DataRowView)dgv.SelectedRows[0].DataBoundItem).Row;
                FormNovoProduto f = new FormNovoProduto(1, r);
                f.ShowDialog(this);
                T = cn.Query("SELECT * FROM TB_PRODUTO");
                dgv.DataSource = T;

            }

            if (altera.GetType() == typeof(FormNovoFornecedor))
            {
                DataRow r = ((DataRowView)dgv.SelectedRows[0].DataBoundItem).Row;
                FormNovoFornecedor f = new FormNovoFornecedor(1, r);
                f.ShowDialog(this);
                T = cn.Query("SELECT * FROM TB_FORNECEDOR");
                dgv.DataSource = T;
            }

            if (altera.GetType() == typeof(FormNovaCategoria))
            {
                DataRow r = ((DataRowView)dgv.SelectedRows[0].DataBoundItem).Row;
                FormNovaCategoria f = new FormNovaCategoria(1, r);
                f.ShowDialog(this);
                T = cn.Query("SELECT * FROM TB_CATEGORIA");
                dgv.DataSource = T;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("Deseja realmente excluir", "", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    int columnIndex = dgv.CurrentRow.Cells[0].ColumnIndex;
                    string columnname = dgv.Columns[columnIndex].Name.ToString();

                    string table = columnname.Replace("ID", "TB_");
                    cn.Query("DELETE FROM " + table + " WHERE " + columnname + " = " + dgv.CurrentRow.Cells[0].Value, 1);
                    MessageBox.Show("Deletado com sucesso");
                    dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                }
            }
            catch(Exception ex)
            {
            }
        }
    }
}
