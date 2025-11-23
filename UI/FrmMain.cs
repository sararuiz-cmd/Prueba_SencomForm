using System;
using System.Linq;
using System.Windows.Forms;
using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.Domain;


namespace Proyect_Sencom_Form.UI
{
    public partial class FrmMain : Form
    {
        private readonly FacturaController _controller;
        private readonly string _usuario;

        public FrmMain(string usuario, FacturaController controller)
        {
            InitializeComponent();
            _controller = controller;
            _usuario = usuario;

            lblUsuario.Text = "Usuario actual: " + usuario;
        }

        private void btnVerGrafico_Click(object sender, EventArgs e)
        {
            var historial = _controller.ObtenerHistorialCompleto();

            if (historial == null || historial.Count == 0)
            {
                MessageBox.Show("No hay facturas registradas para graficar.", "Sin datos");
                return;
            }

            using (var frm = new FrmGrafico(_controller))
            {
                frm.ShowDialog();
            }
        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmFactura(_controller))
            {
                frm.ShowDialog();
            }
        }

        private void btnPrediccionIA_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmPrediccionIA(_controller))
            {
                frm.ShowDialog();
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerTodasLasFacturas();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay facturas para exportar.");
                return;
            }

            var factura = lista.Last();
            var sfd = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                FileName = $"Factura_{factura.IdFactura}.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var pdf = new PdfService();
                pdf.GenerarReporteFactura(factura, factura.Cliente, sfd.FileName);
                MessageBox.Show("Archivo exportado (simulación de PDF).");
            }
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            string input = Prompt.ShowDialog(
                "Ingrese el ID de la factura a buscar:",
                "Buscar factura por ID");

            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            var factura = _controller.BuscarFacturaPorId(id);

            if (factura == null)
            {
                MessageBox.Show("No se encontró esa factura.");
                return;
            }

            MessageBox.Show(
                $"Factura {factura.IdFactura}\n" +
                $"Cliente: {factura.Cliente?.Nombre}\n" +
                $"Mes: {factura.MesNombre}\n" +
                $"Producción: {factura.ProduccionKwhMes:F2} kWh\n" +
                $"Monto: {factura.MontoMes:C2}",
                "Detalle de factura");
        }


        private void btnVerOrdenadas_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerTodasLasFacturas();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay facturas registradas.");
                return;
            }

            var ordenadas = lista
                .OrderBy(f => f.Cliente?.Nombre)
                .ThenBy(f => f.MesNumero)
                .ToList();

            using (var frm = new FrmListaFacturas(ordenadas))
            {
                frm.ShowDialog();
            }
        }
    }
}

