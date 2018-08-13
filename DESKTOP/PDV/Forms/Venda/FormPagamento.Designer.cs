using System.Windows.Forms;

namespace PDV.Forms.Venda
{
    partial class FormPagamento
    {
       /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFormasPagamento = new System.Windows.Forms.ListBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecebimentos = new System.Windows.Forms.ListBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdicionar = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFormasPagamento
            // 
            this.lstFormasPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFormasPagamento.FormattingEnabled = true;
            this.lstFormasPagamento.ItemHeight = 25;
            this.lstFormasPagamento.Location = new System.Drawing.Point(29, 28);
            this.lstFormasPagamento.Name = "lstFormasPagamento";
            this.lstFormasPagamento.Size = new System.Drawing.Size(356, 279);
            this.lstFormasPagamento.TabIndex = 16;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(665, 243);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(200, 29);
            this.txtTotalPagar.TabIndex = 22;
            this.txtTotalPagar.Text = "R$ 0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total à pagar : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total pago : ";
            // 
            // lstRecebimentos
            // 
            this.lstRecebimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecebimentos.FormattingEnabled = true;
            this.lstRecebimentos.ItemHeight = 25;
            this.lstRecebimentos.Location = new System.Drawing.Point(456, 28);
            this.lstRecebimentos.Name = "lstRecebimentos";
            this.lstRecebimentos.Size = new System.Drawing.Size(409, 179);
            this.lstRecebimentos.TabIndex = 26;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPago.Location = new System.Drawing.Point(665, 287);
            this.txtTotalPago.Multiline = true;
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.ReadOnly = true;
            this.txtTotalPago.Size = new System.Drawing.Size(200, 29);
            this.txtTotalPago.TabIndex = 24;
            this.txtTotalPago.Text = "R$ 0.00";
            this.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstFormasPagamento);
            this.groupBox1.Controls.Add(this.lstRecebimentos);
            this.groupBox1.Controls.Add(this.txtTotalPagar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 469);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(29, 408);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(178, 55);
            this.btnVoltar.TabIndex = 42;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(687, 408);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(178, 55);
            this.btnFinalizar.TabIndex = 36;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(391, 28);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(52, 35);
            this.btnRemover.TabIndex = 41;
            this.btnRemover.Text = "<<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdicionar);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Location = new System.Drawing.Point(29, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 86);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor";
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Enabled = false;
            this.txtAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionar.Location = new System.Drawing.Point(16, 37);
            this.txtAdicionar.Multiline = true;
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.ReadOnly = true;
            this.txtAdicionar.Size = new System.Drawing.Size(200, 29);
            this.txtAdicionar.TabIndex = 43;
            this.txtAdicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(222, 34);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(118, 38);
            this.btnAdicionar.TabIndex = 35;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 493);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPagamento_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPagamento_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstFormasPagamento;
        public System.Windows.Forms.TextBox txtTotalPagar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lstRecebimentos;
        public System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVoltar;
        public TextBox txtAdicionar;
        private Button btnAdicionar;
    }

    public class NumericUpDownEx : NumericUpDown
    {
        public NumericUpDownEx()
        {
        }

        protected override void UpdateEditText()
        {
            // Append the units to the end of the numeric value
            this.Text = "R$" + this.Value;
        }
    }
    
}