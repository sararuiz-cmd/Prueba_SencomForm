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
            _controller = controller;
        }

        private void btnEntrenar_Click(object sender, EventArgs e)
        {
            var historial = _controller.ObtenerHistorialCompleto();

            if (historial.Count == 0)
            {
                lblMensaje.Text = "No hay datos para entrenar.";
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
                return;
            }

            string nombre = txtNombreCliente.Text.Trim().ToLower();
            var lista = _controller.ObtenerHistorialPorCliente(nombre);

            if (lista.Count == 0)
            {
                lblMensaje.Text = "No hay historial para ese cliente.";
                return;
            }

            var ultima = lista.Last();

            float prediccion = _ia.PredecirMonto(
                ultima.MesNumero + 1,
                ultima.ProduccionKwhMes,
                ultima.CapacidadPlantaKw
            );

            txtResultado.Text = prediccion.ToString("C2");
        }

        private void FrmPrediccionIA_Load(object sender, EventArgs e)
        {
            // Inicialización necesaria al cargar el formulario, si aplica.
        }
    }
}

