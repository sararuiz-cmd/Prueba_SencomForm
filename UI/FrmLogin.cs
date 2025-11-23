using System;
using System.Windows.Forms;
using Proyect_Sencom_Form.Business;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmLogin : Form
    {
        private readonly FacturaController _controller;

        public FrmLogin(FacturaController controller)
        {
            InitializeComponent();
            _controller = controller;

            // Asegurar suscripción a eventos en caso de que no esté configurada en el diseñador
            if (btnIniciarSesion != null)
            {
                btnIniciarSesion.Click -= btnIniciarSesion_Click;
                btnIniciarSesion.Click += btnIniciarSesion_Click;
            }

            if (btnRegistrar != null)
            {
                btnRegistrar.Click -= btnRegistrar_Click;
                btnRegistrar.Click += btnRegistrar_Click;
            }

            // Permitir que Enter dispare el login
            if (btnIniciarSesion != null)
            {
                AcceptButton = btnIniciarSesion;
            }

            lblMensaje.Text = string.Empty;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // aquí podrías validar usuario/contraseña; por ahora dejamos “admin”
            string usuario = "admin";

            var main = new FrmMain(usuario, _controller);
            main.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro simulado (puedes implementar Auth real después).");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
