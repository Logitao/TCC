using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Conexão;
using PDV.Forms.Venda;

namespace PDV.Forms
{
    public partial class FormPrincipal : Form
    {
        private Conn cn;
        public FormPrincipal()
        {
            cn = new Conn();
            cn.Connect();
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoProduto frm = new FormNovoProduto();
            frm.ShowDialog(this);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaCategoria frm = new FormNovaCategoria();
            frm.ShowDialog(this);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor frm = new FormNovoFornecedor();
            frm.ShowDialog(this);
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoFuncionario frm = new FormNovoFuncionario();
            frm.ShowDialog(this); 
        }

        private void definirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefinirLogin frm = new FormDefinirLogin();
            frm.ShowDialog(this);
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM TB_PRODUTO"), new FormNovoProduto(), true);
            frm.ShowDialog(this);
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM TB_CATEGORIA"), new FormNovaCategoria(), true);
            frm.ShowDialog(this);
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM TB_FORNECEDOR"), new FormNovoFornecedor());
            frm.ShowDialog(this);
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM TB_FUNCIONARIO"), new FormNovoFuncionario());
            frm.ShowDialog(this);
        }

        private void abrirVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipalVenda frm = new FormPrincipalVenda(FormLogin.usuario);
            this.Hide();
            frm.ShowDialog(this);
        }

        private void entradaNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaEntradaEstoque frm = new FormNovaEntradaEstoque();
            frm.ShowDialog(this);
            
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM VW_ESTOQUE"), null, false);
            frm.ShowDialog(this);
        }

        private void consultaDeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM VW_LOG"), null, false);
            frm.ShowDialog(this);
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio frm = new FormRelatorio();
            frm.ShowDialog(this);
        }

        private void produtosEVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta frm = new FormConsulta(cn.Query("SELECT * FROM VW_PRODUTO_VENDA"), null, false);
            frm.ShowDialog(this);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            UserControlRelatorio usr = new UserControlRelatorio();
            
            painel.Controls.Add(usr);
        }

      
    }

    internal static class FuncForm
    {
        public static void LimparTextBox(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    var textBox = control as TextBox;
                    if (textBox != null) textBox.Clear();
                }
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    var textBox = control as MaskedTextBox;
                    if (textBox != null) textBox.Clear();
                }
                if (control.GetType() == typeof(NumericUpDown))
                {
                    var numericUpDown = control as NumericUpDown;
                    if (numericUpDown != null) numericUpDown.Value = 0;
                }
                if (control.GetType() == typeof(ComboBox))
                {
                    var comboBox = control as ComboBox;
                    if (comboBox != null) comboBox.SelectedIndex = -1;
                }
            }
        }
    }
    
}
