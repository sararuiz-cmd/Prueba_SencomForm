using System;
using System.Windows.Forms;
using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.Domain;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmFactura : Form
    {
        private readonly FacturaController _controller;

        public FrmFactura(FacturaController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidadorFactura.EsNombreValido(txtNombreCliente.Text))
                {
                    lblMensaje.Text = "Nombre inválido.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (!ValidadorFactura.EsDireccionValida(txtDireccion.Text))
                {
                    lblMensaje.Text = "Dirección inválida.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (!ValidadorFactura.EsDecimalPositivo(txtCapacidadKw.Text, out double capacidad))
                {
                    lblMensaje.Text = "Capacidad inválida (número positivo).";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (!ValidadorFactura.EsEnteroPositivo(txtMeses.Text, out int meses))
                {
                    lblMensaje.Text = "Meses inválidos (entero positivo).";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                Cliente cli = new Cliente()
                {
                    IdCliente = new Random().Next(1, 99999),
                    Nombre = txtNombreCliente.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                var lista = _controller.GenerarFacturasSimuladas(
                    cli,
                    capacidad,
                    meses,
                    DateTime.Now.AddMonths(-meses)
                );

                dgvFacturas.DataSource = lista;
                lblMensaje.Text = "Facturas generadas correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Método público para volver al principal si se requiere desde UI
        public void VolverAlPrincipal(string usuario = "")
        {
            Program.FormContext.Navigate(new FrmMain(usuario, _controller));
        }
    }
}
