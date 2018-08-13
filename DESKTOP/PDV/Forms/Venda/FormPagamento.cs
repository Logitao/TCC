using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Conexão;

namespace PDV.Forms.Venda
{
    public partial class FormPagamento : Form
    {
        private bool pressDot = false;
        public static DataTable pgtoVenda;
        private double total = FormPrincipalVenda.total;
        public static double totalpago = 0;
        public static bool vendaFinalizada = false;
        const string formatoDoValor = "R$ 0.00";

        public Conn cn = new Conn();
        private void FormPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtAdicionar.Text = "0";
                pressDot = false;

            }
        }
        private void FormPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar)) return;

            //Adiciona caractere na txtbox "focada"

            if (char.IsDigit(e.KeyChar))
            {
                if (txtAdicionar.Text == "0") txtAdicionar.Clear();
                txtAdicionar.Text += (txtAdicionar.Text.Length <= 9)
                    ? e.KeyChar.ToString()
                    : "";

            }
            else if (e.KeyChar == '.' && !pressDot)
            {

                if (txtAdicionar.Text == "0") txtAdicionar.Clear();
                txtAdicionar.Text += (txtAdicionar.Text.Length <= 9)
                    ? e.KeyChar.ToString()
                    : "";

                pressDot = true;
            }
        }
        public FormPagamento()
        {
            InitializeComponent();
            cn.Connect();
         
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {

            pgtoVenda = new DataTable();
            pgtoVenda.Columns.Add("FORMA", typeof(string));
            pgtoVenda.Columns.Add("VALOR", typeof(string));
            pgtoVenda.Clear();

            Recalcular();
            
            txtTotalPagar.Text = total.ToString(formatoDoValor);
            
            DataTable T = cn.Query("SELECT * FROM TB_FORMAPGTO");

            for (int i = 0; i < T.Rows.Count; i++)
                lstFormasPagamento.Items.Add(T.Rows[i][1].ToString());

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstFormasPagamento.SelectedIndex != -1)
                {
                    string s = lstFormasPagamento.SelectedItem.ToString();
                    
                    lstRecebimentos.Items.Add(s + " -  R$ " + txtAdicionar.Text.Replace(".", ","));

                    DataRow next = pgtoVenda.NewRow();
                    next["FORMA"] = s;
                    next["VALOR"] = txtAdicionar.Text;

                    pgtoVenda.Rows.Add(next);

                    Recalcular();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstRecebimentos.SelectedIndex != -1)
            {
                //PGTOVENDA ESPELHA O INDICE EM LSTRECEBIMENTOS
                string s = lstRecebimentos.SelectedItem.ToString();
                pgtoVenda.Rows.RemoveAt(lstRecebimentos.SelectedIndex);
                lstRecebimentos.Items.Remove(s);


                Recalcular();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (totalpago >= total)
            {
                double troco = totalpago - total;
                MessageBox.Show("Venda Finalizada \n Troco : " + troco.ToString(formatoDoValor), "Concluido");
                FormPrincipalVenda.confirmarVenda = true;

                btnVoltar.PerformClick();
            }
        }

        private void Recalcular()
        {
            if (pgtoVenda != null)
            {
                
                totalpago = pgtoVenda.
                    AsEnumerable()
                    .Select(r => Convert.ToDouble(r.Field<string>("Valor").Replace(".", ",")))
                    .ToList()
                    .Sum(x => x);

                txtTotalPago.Text = totalpago.ToString(formatoDoValor);

                txtAdicionar.Text = "0";
                lstFormasPagamento.SelectedIndex = -1;
                lstRecebimentos.SelectedIndex = -1;
                pressDot = false;

            }

        }
    }
}
