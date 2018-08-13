namespace PDV.Forms.Venda
{
    partial class FormCancelamentoItem
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnRemoverCancelado = new System.Windows.Forms.Button();
            this.listBoxListaItens = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listBoxItensCancelados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE ITENS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(575, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ITENS CANCELADOS";
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Location = new System.Drawing.Point(484, 72);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(75, 53);
            this.btnCancelarItem.TabIndex = 4;
            this.btnCancelarItem.Text = ">>>>";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnRemoverCancelado
            // 
            this.btnRemoverCancelado.Location = new System.Drawing.Point(484, 149);
            this.btnRemoverCancelado.Name = "btnRemoverCancelado";
            this.btnRemoverCancelado.Size = new System.Drawing.Size(75, 53);
            this.btnRemoverCancelado.TabIndex = 5;
            this.btnRemoverCancelado.Text = "X";
            this.btnRemoverCancelado.UseVisualStyleBackColor = true;
            this.btnRemoverCancelado.Click += new System.EventHandler(this.btnRemoverCancelado_Click);
            // 
            // listBoxListaItens
            // 
            this.listBoxListaItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxListaItens.FormattingEnabled = true;
            this.listBoxListaItens.ItemHeight = 25;
            this.listBoxListaItens.Location = new System.Drawing.Point(12, 72);
            this.listBoxListaItens.Name = "listBoxListaItens";
            this.listBoxListaItens.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxListaItens.Size = new System.Drawing.Size(449, 404);
            this.listBoxListaItens.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(836, 505);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(194, 53);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(194, 53);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // listBoxItensCancelados
            // 
            this.listBoxItensCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxItensCancelados.FormattingEnabled = true;
            this.listBoxItensCancelados.ItemHeight = 25;
            this.listBoxItensCancelados.Location = new System.Drawing.Point(580, 72);
            this.listBoxItensCancelados.Name = "listBoxItensCancelados";
            this.listBoxItensCancelados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxItensCancelados.Size = new System.Drawing.Size(449, 404);
            this.listBoxItensCancelados.TabIndex = 8;
            // 
            // FormCancelamentoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1042, 570);
            this.Controls.Add(this.listBoxItensCancelados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRemoverCancelado);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxListaItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormCancelamentoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCancelamentoItem";
            this.Load += new System.EventHandler(this.FormCancelamentoItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnRemoverCancelado;
        private System.Windows.Forms.ListBox listBoxListaItens;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listBoxItensCancelados;
    }
}