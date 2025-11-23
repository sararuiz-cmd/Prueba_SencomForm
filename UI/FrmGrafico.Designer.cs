namespace Proyect_Sencom_Form.UI
{
    partial class FrmGrafico
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafico));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(760, 500);
            this.chart1.TabIndex = 0;
            // 
            // FrmGrafico
            // 
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGrafico";
            this.Text = "Gráfico de Consumo Mensual";
            this.Load += new System.EventHandler(this.FrmGrafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
