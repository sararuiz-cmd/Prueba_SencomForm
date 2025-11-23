using System;
using System.Windows.Forms;
using Proyect_Sencom_Form.Business;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmMain : Form
    {
        private readonly FacturaController _controller;
        private readonly string _usuario;

        public FrmMain(string usuario, FacturaController controller)
        {
            InitializeComponent();
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
            _usuario = string.IsNullOrWhiteSpace(usuario) ? "(desconocido)" : usuario.Trim();
            lblUsuario.Text = "Usuario actual: " + _usuario;
        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            FrmFactura frm = new FrmFactura(_controller);
            frm.ShowDialog();
        }

        private void btnPrediccionIA_Click(object sender, EventArgs e)
        {
            FrmPrediccionIA frm = new FrmPrediccionIA(_controller);
            frm.ShowDialog();
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerTodasLasFacturas();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay facturas para exportar.");
                return;
            }
            var factura = lista[lista.Count - 1];
            var cliente = factura.Cliente;
            if (factura == null || cliente == null)
            {
                MessageBox.Show("Datos de factura inválidos.");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo PDF|*.pdf";
            sfd.FileName = "Factura_" + factura.IdFactura + ".pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfService pdf = new PdfService();
                    pdf.GenerarReporteFactura(factura, cliente, sfd.FileName);
                    MessageBox.Show("PDF generado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message);
                }
            }
        }

        private void btnVerGrafico_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerTodasLasFacturas();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Debe generar facturas antes de ver el gráfico.");
                return;
            }
            FrmGrafico frm = new FrmGrafico(_controller);
            frm.ShowDialog();
        }
    }
}


