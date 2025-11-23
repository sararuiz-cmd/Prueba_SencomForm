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
            string usuario = txtUsuario?.Text?.Trim() ?? string.Empty;
            string contrasena = txtContrasena?.Text ?? string.Empty;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                lblMensaje.Text = "Ingrese usuario y contraseña.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                AuthService auth = new AuthService();

                if (auth.ValidarLogin(usuario, contrasena))
                {
                    var frm = new FrmMain(usuario, _controller);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña incorrectos.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                lblMensaje.Text = "Error al procesar el inicio de sesión.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario?.Text?.Trim() ?? string.Empty;
            string contrasena = txtContrasena?.Text ?? string.Empty;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                lblMensaje.Text = "Ingrese usuario y contraseña para registrar.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                AuthService auth = new AuthService();

                if (auth.RegistrarUsuario(usuario, contrasena, out string mensaje))
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }

                lblMensaje.Text = mensaje;
            }
            catch (Exception)
            {
                lblMensaje.Text = "Error al registrar usuario.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

