namespace PDV.Forms.Venda
{
    partial class FormPrincipalVenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalVenda));
            this.label3 = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxCompra = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtPrecoUni = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblProdNome = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cupom Fiscal: ";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.Color.Red;
            this.lblVenda.Location = new System.Drawing.Point(351, 0);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(80, 55);
            this.lblVenda.TabIndex = 3;
            this.lblVenda.Text = "01";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(911, 767);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 29);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "21/02/2017";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(967, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 55);
            this.label7.TabIndex = 6;
            this.label7.Text = "Compra";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1058, 767);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(111, 29);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "14:21:47";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(715, 696);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 55);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total : ";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(886, 696);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(228, 55);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "R$ 00,00";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Código";
            // 
            // listBoxCompra
            // 
            this.listBoxCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompra.ForeColor = System.Drawing.Color.Black;
            this.listBoxCompra.FormattingEnabled = true;
            this.listBoxCompra.ItemHeight = 25;
            this.listBoxCompra.Location = new System.Drawing.Point(805, 146);
            this.listBoxCompra.Name = "listBoxCompra";
            this.listBoxCompra.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxCompra.Size = new System.Drawing.Size(364, 404);
            this.listBoxCompra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Preço Unidade";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Silver;
            this.txtCodigo.Location = new System.Drawing.Point(488, 159);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(300, 48);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuant
            // 
            this.txtQuant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQuant.Enabled = false;
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.ForeColor = System.Drawing.Color.Black;
            this.txtQuant.Location = new System.Drawing.Point(488, 249);
            this.txtQuant.Multiline = true;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.ReadOnly = true;
            this.txtQuant.Size = new System.Drawing.Size(300, 48);
            this.txtQuant.TabIndex = 2;
            this.txtQuant.Text = "1";
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecoUni
            // 
            this.txtPrecoUni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecoUni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecoUni.Enabled = false;
            this.txtPrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUni.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoUni.Location = new System.Drawing.Point(488, 359);
            this.txtPrecoUni.Multiline = true;
            this.txtPrecoUni.Name = "txtPrecoUni";
            this.txtPrecoUni.ReadOnly = true;
            this.txtPrecoUni.Size = new System.Drawing.Size(300, 48);
            this.txtPrecoUni.TabIndex = 21;
            this.txtPrecoUni.Text = "R$ 0.00";
            this.txtPrecoUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecoTotal.Enabled = false;
            this.txtPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoTotal.Location = new System.Drawing.Point(489, 468);
            this.txtPrecoTotal.Multiline = true;
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(299, 48);
            this.txtPrecoTotal.TabIndex = 23;
            this.txtPrecoTotal.Text = "R$ 0.00";
            this.txtPrecoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Preço Total";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(68, 567);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(720, 55);
            this.textBox5.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(18, 679);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 2);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(18, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 2);
            this.panel2.TabIndex = 26;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Orange;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(68, 159);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(392, 357);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblProdNome
            // 
            this.lblProdNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProdNome.AutoSize = true;
            this.lblProdNome.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdNome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblProdNome.Location = new System.Drawing.Point(210, 576);
            this.lblProdNome.Name = "lblProdNome";
            this.lblProdNome.Size = new System.Drawing.Size(353, 37);
            this.lblProdNome.TabIndex = 29;
            this.lblProdNome.Text = "NOME DO PRODUTO";
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogado.Location = new System.Drawing.Point(14, 63);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(98, 24);
            this.lblLogado.TabIndex = 30;
            this.lblLogado.Text = "Logado : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "F1 - PROXIMO CAMPO";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 727);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "F4 - CANCELAR ITEM";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(422, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "F9 - CONFIRMAR VENDA";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 727);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "F10 - CANCELAR VENDA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(661, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "01";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(549, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 29);
            this.label13.TabIndex = 36;
            this.label13.Text = "Estação";
            // 
            // lblDataHora
            // 
            this.lblDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(90, 636);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(65, 24);
            this.lblDataHora.TabIndex = 37;
            this.lblDataHora.Text = "DATA";
            // 
            // FormPrincipalVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 772);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.lblProdNome);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecoUni);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormPrincipalVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipalVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipalVenda_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPrincipalVenda_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtQuant;
        public System.Windows.Forms.TextBox txtPrecoUni;
        public System.Windows.Forms.TextBox txtPrecoTotal;
        public System.Windows.Forms.ListBox listBoxCompra;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblVenda;
        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public System.Windows.Forms.Label lblProdNome;
        private System.Windows.Forms.Timer timerHora;
        public System.Windows.Forms.Label lblLogado;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblDataHora;
    }
}