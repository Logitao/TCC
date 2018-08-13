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
    public partial class FormPrincipalVenda : Form
    {
        //Painel principal
        //Foco da txtCodigo e Quant
        private bool CodFocus = true;
        public static double total = 0;
        public static bool cancelarVenda = false;
        public static bool confirmarVenda = false;
        //Lista de produtos
        public static List<Produto> ListaProduto = new List<Produto>();
        private string usuario;
        Conn cn = new Conn();
        public FormPrincipalVenda(string usuario)
        {
            this.usuario = usuario;
            cn.Connect();
            InitializeComponent();
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timerHora.Start();

        }

        private void FormPrincipalVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;

            //Adiciona caractere na txtbox "focada"
            if (CodFocus)
                txtCodigo.Text += (txtCodigo.Text.Length <= 14)
                    ? e.KeyChar.ToString()
                    : "";
            else
                txtQuant.Text += (txtQuant.Text.Length <= 14)
                    ? e.KeyChar.ToString()
                    : "";
        }

        private void FormPrincipalVenda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Sair da Aplicação (esc)
                case Keys.Escape:
                    ListaProduto.Clear();
                    this.Close();
                    break;

                //Mudar Foco (f1)
                case Keys.F1:
                    MudarFoco();
                    break;
                case Keys.F4:
                    FormCancelamentoItem frmCancItem = new FormCancelamentoItem();

                    frmCancItem.ShowDialog();
                    if (FormCancelamentoItem.cancelamentoConfirmado)
                    {
                        CalcularPrecos();
                        FormCancelamentoItem.cancelamentoConfirmado = false;

                    }
                    break;
                //Apaga caractere da txtbox "focada"
                case Keys.Back:
                    if (CodFocus)
                        txtCodigo.Text = (txtCodigo.Text.Length > 0)
                            ? txtCodigo.Text.Remove(txtCodigo.Text.Length - 1)
                            : txtCodigo.Text;
                    else

                        txtQuant.Text = (txtQuant.Text.Length > 0)
                            ? txtQuant.Text.Remove(txtQuant.Text.Length - 1)
                            : txtQuant.Text;
                    break;
                //Ao apertar ENTER
                case Keys.Enter:
                    if (CodFocus)
                    {
                        PreencherTudo();

                        txtCodigo.Text = "";
                    }
                    else
                        MudarFoco();
                    break;

                case Keys.F10:
                    FormConfirmar frmConf = new FormConfirmar(2);
                    frmConf.ShowDialog();
                    if (cancelarVenda)
                    {
                        CancelarVenda();
                        Reseta();
                    }
                    break;

                case Keys.F9:
                    FormPagamento frmPag = new FormPagamento();
                    frmPag.ShowDialog();
                    if (confirmarVenda)
                    {
                        ConfirmarVenda();
                        confirmarVenda = false;
                        FormPagamento.totalpago = 0;
                        Reseta();
                    }
                    break;
            }
        }

        private void FormPrincipalVenda_Load(object sender, EventArgs e)
        {
            this.Focus();

            MudarFoco();
            MudarFoco();

            cn.Connect();

            lblVenda.Text =
                cn.Query("SELECT * FROM TB_VENDA WHERE CUPOM = (SELECT MAX(CUPOM) FROM TB_VENDA)").Rows[0][0].ToString();
            lblLogado.Text += FormLogin.usuario;
        }

        private void MudarFoco()
        {
            CodFocus = !CodFocus;

            if (CodFocus)
            {
                txtCodigo.BackColor = Color.Moccasin;
                txtQuant.BackColor = Color.FromArgb(224, 224, 224);


            }
            else
            {
                txtCodigo.BackColor = Color.FromArgb(224, 224, 224);
                ;
                txtQuant.BackColor = Color.Moccasin;
            }
        }

        public static int ContarDuplicados(long produtoID, List<Produto> L)
        {
            if (L.Count > 1)
            {
                int count = L.Count(x => x.Idproduto == produtoID && x.Status == 1);
                return count;
            }
            return 1;

        }

        private void PreencherTudo()
        {
            //Validação
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Código não pode estar em branco");
                return;
            }
            if (txtQuant.Text == "")
            {
                MessageBox.Show("Quantidade não pode estar em branco");
                return;
            }

            //Adiciona produtos conforme a quantidade digitada
            for (int i = 0; i < int.Parse(txtQuant.Text); i++)
            {
                Produto novoProduto = new Produto(long.Parse(txtCodigo.Text), ListaProduto.Count + 1, cn);
                if (novoProduto.Nomeproduto == null)
                {
                    MessageBox.Show("Código não reconhecido");
                    return;
                }
                ListaProduto.Add(novoProduto);
            }
            //Seleciona da lista a descrição dos produtos unicos
            //Seleciona itens distintos
            //Conta a quantidade de produtos repetidos e adiciona na string IE: Leite + " x" + "quantos leites foram passados"
            //ficando no formato "Leite xN" caso tenha passado N leites


            //

            CalcularPrecos();
            txtQuant.Text = "1";
        }


        private void CalcularPrecos()
        {
            listBoxCompra.DataSource = ListaProduto
                .Select(x => x.Nomeproduto + " x" + ContarDuplicados(x.Idproduto, ListaProduto))
                .Distinct().ToList();
            
            //Ultimo produto passado

            var listaStatusAtivo = ListaProduto.Where(x => x.Status == 1).ToList();
            if (listaStatusAtivo.Count > 0)
            {
                Produto ultimoProd = listaStatusAtivo.ElementAt(
                    listaStatusAtivo.ToList().Count - 1);


                //Formato valor EX: R$ 42.75
                const string formatoDoValor = "R$ 0.00";

                //Soma o valor dos produtos na lista e armazena na variavel total
                total = listaStatusAtivo.Sum(x => x.Valorvenda);
                //Mostrando o total
                lblTotal.Text = total.ToString(formatoDoValor);

                //Nome, valor unitario e valor unitario total

                lblProdNome.Text = ultimoProd.Nomeproduto;
                txtPrecoUni.Text = ultimoProd.Valorvenda.ToString(formatoDoValor);

                txtPrecoTotal.Text = listaStatusAtivo.Where(x => x.Idproduto == ultimoProd.Idproduto)
                    .Sum(x => x.Valorvenda)
                    .ToString(formatoDoValor);
            }
            else
            {                

                //Formato valor EX: R$ 42.75
                const string formatoDoValor = "R$ 0.00";

                //Soma o valor dos produtos na lista e armazena na variavel total
                total = listaStatusAtivo.Sum(x => x.Valorvenda);
                //Mostrando o total
                lblTotal.Text = total.ToString(formatoDoValor);

                //Nome, valor unitario e valor unitario total

                lblProdNome.Text = "";
                txtPrecoUni.Text = "R$ 0.00";
                txtPrecoTotal.Text = "R$ 0.00";
                
            }
        }

        public void CancelarVenda()
        {
            try
            {
                cn.ExecuteInsertTB_VENDA(0, (decimal) total, 0, 1);
                cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 3, FormLogin.caixa);
                for (int i = 0; i < ListaProduto.Count; i++)
                {
                    Produto P = ListaProduto[i];
                    cn.ExecuteInsertTB_PRODUTO_VENDA(P.Idproduto, P.Status);

                }
                Reseta();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void ConfirmarVenda()
        {

            try
            {

                cn.ExecuteInsertTB_VENDA(1, (decimal) total, (decimal) FormPagamento.totalpago, FormLogin.idusuario);
                cn.ExecuteInsertTB_LOG_CAIXA(FormLogin.idusuario, 3, FormLogin.caixa);
                for (int i = 0; i < ListaProduto.Count; i++)
                {
                    Produto P = ListaProduto[i];
                    cn.ExecuteInsertTB_PRODUTO_VENDA(P.Idproduto, P.Status);

                }

                DataTable pgto = FormPagamento.pgtoVenda;
                for (int i = 0; i < pgto.Rows.Count; i++)
                {
                    string desc = pgto.Rows[i]["Forma"].ToString();
                    double valor = double.Parse(pgto.Rows[i]["Valor"].ToString().Replace(".", ","));
                    cn.ExecuteInsertTB_PGTO_VENDA(valor,
                        Convert.ToInt32(cn.Query("SELECT * FROM TB_FORMAPGTO WHERE DESCRICAO = '" + desc + "'").Rows[0][
                                "IDFORMAPGTO"]));
                    
                }

                Reseta();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Reseta()
        {
            lblProdNome.Text = "";
            
            txtCodigo.Text = "";

            lblVenda.Text =
                cn.Query("SELECT * FROM TB_VENDA WHERE CUPOM = (SELECT MAX(CUPOM) FROM TB_VENDA)").Rows[0][0].ToString();
            lblTotal.Text = txtPrecoTotal.Text = txtPrecoUni.Text = "R$ 0.00";
            ListaProduto.Clear();
            listBoxCompra.DataSource = ListaProduto;
            total = 0;
            FormPagamento.totalpago = 0;
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
