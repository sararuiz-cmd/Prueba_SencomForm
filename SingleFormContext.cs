using System.Windows.Forms;
using Proyect_Sencom_Form.UI;

namespace Proyect_Sencom_Form
{
    // Contexto para asegurar que solo haya un formulario visible a la vez
    public class SingleFormContext : ApplicationContext
    {
        private Form _current;
        public string CurrentUser { get; set; } = string.Empty;

        public void ShowForm(Form next)
        {
            if (next == null) return;
            if (_current != null)
            {
                _current.FormClosed -= OnFormClosed;
                if (!_current.IsDisposed)
                    _current.Close();
            }
            _current = next;
            _current.FormClosed += OnFormClosed;
            _current.Show();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (_current == sender)
            {
                _current.FormClosed -= OnFormClosed;
                bool wasMain = sender is FrmMain;
                bool wasLogin = sender is FrmLogin;
                _current = null;
                if (wasLogin)
                {
                    ExitThread(); // cerrar aplicación si se cierra login directamente
                    return;
                }
                if (wasMain)
                {
                    // Volver a Login cuando se cierra FrmMain
                    ShowForm(new FrmLogin(Program.ControllerGlobal));
                    return;
                }
                // cualquier otro formulario regresa a FrmMain
                ShowForm(new FrmMain(CurrentUser, Program.ControllerGlobal));
            }
        }

        public void Navigate(Form next)
        {
            // Si navegamos a FrmMain, actualizar usuario si es posible (lo asigna Login antes)
            ShowForm(next);
        }
    }
}
