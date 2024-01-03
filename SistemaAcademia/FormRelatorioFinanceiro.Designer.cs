namespace SistemaAcademia
{
    partial class FormRelatorioFinanceiro
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioFinanceiro));
            this.graficoFinanceiro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoFinanceiro
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.graficoFinanceiro.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoFinanceiro.Legends.Add(legend1);
            this.graficoFinanceiro.Location = new System.Drawing.Point(12, 12);
            this.graficoFinanceiro.Name = "graficoFinanceiro";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Faturamento";
            this.graficoFinanceiro.Series.Add(series1);
            this.graficoFinanceiro.Size = new System.Drawing.Size(1160, 537);
            this.graficoFinanceiro.TabIndex = 0;
            this.graficoFinanceiro.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Faturamento Últimos 13 Meses";
            this.graficoFinanceiro.Titles.Add(title1);
            // 
            // FormRelatorioFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.graficoFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Últimos 13 Meses";
            ((System.ComponentModel.ISupportInitialize)(this.graficoFinanceiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoFinanceiro;
    }
}