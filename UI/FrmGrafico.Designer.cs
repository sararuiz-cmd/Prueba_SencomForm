namespace Proyect_Sencom_Form.UI
{
    partial class FrmGrafico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // =======================
            //   CREAR CHART AREA
            // =======================
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);

            // =======================
            //   CREAR LEYENDA
            // =======================
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);

            // =======================
            //   CONFIGURACIÓN DEL CHART
            // =======================
            this.chart1.Location = new System.Drawing.Point(20, 20);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(760, 540);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";

            // =======================
            //   FORMULARIO
            // =======================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);

            this.Controls.Add(this.chart1);
            this.Name = "FrmGrafico";
            this.Text = "Gráfico de Consumo Mensual";
            this.Load += new System.EventHandler(this.FrmGrafico_Load);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
