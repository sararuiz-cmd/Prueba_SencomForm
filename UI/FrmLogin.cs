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
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

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
    }
}

