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
            ThemeManager.ApplyTheme(this);
            try
            {
                var historial = _controller.ObtenerTodasLasFacturas();

                // ============================
                // VALIDAR DATOS VACÍOS
                // ============================
                if (historial == null || historial.Count == 0)
                {
                    MessageBox.Show("No hay facturas registradas para graficar.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Close();
                    return;
                }

                // ============================
                // LIMPIAR SERIES ANTERIORES
                // ============================
                chart1.Series.Clear();

                // ============================
                // SERIE DEL GRÁFICO
                // ============================
                Series serie = new Series("Producción Mensual (kWh)");
                serie.ChartType = SeriesChartType.Column;
                serie.XValueType = ChartValueType.String;
                serie.YValueType = ChartValueType.Double;

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
                MessageBox.Show("Error al generar el gráfico:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }

            chart1.Series.Add(serie);
        }

        public void VolverAlPrincipal(string usuario = "")
        {
            Program.FormContext.Navigate(new FrmMain(usuario, _controller));
        }
    }
}
