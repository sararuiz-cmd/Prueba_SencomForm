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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidadorFactura.EsNombreValido(txtNombreCliente.Text))
                {
                    lblMensaje.Text = "Nombre inválido.";
                    return;
                }

                if (!ValidadorFactura.EsDireccionValida(txtDireccion.Text))
                {
                    lblMensaje.Text = "Dirección inválida.";
                    return;
                }

                if (!double.TryParse(txtCapacidadKw.Text, out double capacidad))
                {
                    lblMensaje.Text = "Capacidad inválida.";
                    return;
                }

                if (!int.TryParse(txtMeses.Text, out int meses))
                {
                    lblMensaje.Text = "Meses inválidos.";
                    return;
                }

                Cliente cli = new Cliente()
                {
                    IdCliente = new Random().Next(1, 99999),
                    Nombre = txtNombreCliente.Text,
                    Direccion = txtDireccion.Text
                };

                var lista = _controller.GenerarFacturasSimuladas(
                    cli,
                    capacidad,
                    meses,
                    DateTime.Now.AddMonths(-meses)
                );

                dgvFacturas.DataSource = lista;
                lblMensaje.Text = "Facturas generadas correctamente.";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
