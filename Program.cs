using System;
using System.Windows.Forms;
using Proyect_Sencom_Form.Business;
using Proyect_Sencom_Form.UI;

namespace Proyect_Sencom_Form
{
    static class Program
    {
        // Controlador compartido
        public static FacturaController ControllerGlobal = new FacturaController();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Se lo pasamos al Login
            Application.Run(new FrmLogin(ControllerGlobal));
        }
    }
}
