namespace PDV.Forms.Venda
{
    partial class UserControlRelatorio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoProdutos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoVendas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graficoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoProdutos
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoProdutos.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.graficoProdutos.Legends.Add(legend2);
            this.graficoProdutos.Location = new System.Drawing.Point(645, 58);
            this.graficoProdutos.Name = "graficoProdutos";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "serieValor";
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.graficoProdutos.Series.Add(series3);
            this.graficoProdutos.Size = new System.Drawing.Size(549, 450);
            this.graficoProdutos.TabIndex = 3;
            this.graficoProdutos.Text = "chart1";
            // 
            // graficoVendas
            // 
            chartArea4.Name = "ChartArea1";
            this.graficoVendas.ChartAreas.Add(chartArea4);
            this.graficoVendas.Location = new System.Drawing.Point(27, 68);
            this.graficoVendas.Name = "graficoVendas";
            series4.ChartArea = "ChartArea1";
            series4.Name = "serieValorTotal";
            series4.YValuesPerPoint = 2;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.graficoVendas.Series.Add(series4);
            this.graficoVendas.Size = new System.Drawing.Size(574, 440);
            this.graficoVendas.TabIndex = 2;
            this.graficoVendas.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "VALOR TOTAL POR MÊS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRODUTOS VENDIDOS POR MÊS";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(639, 520);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 33);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "lbltotal";
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.Location = new System.Drawing.Point(21, 520);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(117, 33);
            this.lblLucro.TabIndex = 7;
            this.lblLucro.Text = "lbllucro";
            // 
            // UserControlRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLucro);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graficoProdutos);
            this.Controls.Add(this.graficoVendas);
            this.Name = "UserControlRelatorio";
            this.Size = new System.Drawing.Size(1222, 628);
            this.Load += new System.EventHandler(this.UserControlRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoProdutos;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLucro;
    }
}
