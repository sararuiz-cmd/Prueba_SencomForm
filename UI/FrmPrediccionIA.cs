using System;
using System.Linq;
using System.Windows.Forms;
using Proyect_Sencom_Form.Business;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmPrediccionIA : Form
    {
        private readonly FacturaController _controller;
        private readonly PrediccionIAService _ia = new PrediccionIAService();
        private bool _modeloEntrenado = false;

        public FrmPrediccionIA(FacturaController controller)
        {
            InitializeComponent();
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        private void btnEntrenar_Click(object sender, EventArgs e)
        {
            var historial = _controller.ObtenerHistorialCompleto();
            if (historial == null || historial.Count == 0)
            {
                lblMensaje.Text = "No hay datos para entrenar.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }
            _ia.EntrenarModelo(historial);
            _modeloEntrenado = true;
            lblMensaje.Text = "Modelo entrenado.";
            lblMensaje.ForeColor = System.Drawing.Color.Green;
        }

        private void btnPredecir_Click(object sender, EventArgs e)
        {
            if (!_modeloEntrenado)
            {
                lblMensaje.Text = "Primero entrene el modelo.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }
            string nombre = txtNombreCliente.Text.Trim();
            if (!ValidadorFactura.EsNombreValido(nombre))
            {
                lblMensaje.Text = "Nombre inválido.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }
            var lista = _controller.ObtenerHistorialPorCliente(nombre.ToLower());
            if (lista == null || lista.Count == 0)
            {
                lblMensaje.Text = "No hay historial para ese cliente.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }
            int mesPrediccion;
            if (!int.TryParse(txtMesPrediccion.Text.Trim(), out mesPrediccion) || mesPrediccion < 1 || mesPrediccion > 12)
            {
                // Si no se proporciona mes válido, usar siguiente al último.
                mesPrediccion = lista.Last().MesNumero + 1;
                if (mesPrediccion > 12) mesPrediccion = 12;
            }
            var ultima = lista.Last();
            float prediccion = _ia.PredecirMonto(
                mesPrediccion,
                ultima.ProduccionKwhMes,
                ultima.CapacidadPlantaKw
            );
            txtResultado.Text = prediccion.ToString("C2");
            lblMensaje.Text = "Predicción generada.";
            lblMensaje.ForeColor = System.Drawing.Color.Green;
        }

        private void FrmPrediccionIA_Load(object sender, EventArgs e)
        {
            // Inicialización necesaria al cargar el formulario, si aplica.
            lblMensaje.Text = string.Empty;
        }
    }
}

