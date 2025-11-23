using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Proyect_Sencom_Form.Business;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmGrafico : Form
    {
        private readonly FacturaController _controller;

        public FrmGrafico(FacturaController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            var historial = _controller.ObtenerHistorialCompleto();

            if (historial == null || historial.Count == 0)
            {
                MessageBox.Show("No hay facturas registradas para graficar.");
                return;
            }

            chart1.Series.Clear();

            var serie = new Series("Consumo (kWh)");
            serie.ChartType = SeriesChartType.Column;
            serie.XValueType = ChartValueType.String;
            serie.YValueType = ChartValueType.Double;

            foreach (var f in historial.OrderBy(h => h.MesNumero))
            {
                serie.Points.AddXY(f.MesNombre, f.ProduccionKwhMes);
            }

            chart1.Series.Add(serie);
        }
    }
}
