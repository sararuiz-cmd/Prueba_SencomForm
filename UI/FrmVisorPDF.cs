using System;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmVisorPDF : Form
    {
        private string rutaPdf;

        public FrmVisorPDF(string ruta)
        {
            InitializeComponent();
            rutaPdf = ruta;
        }

        private void FrmVisorPDF_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate(rutaPdf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el PDF: " + ex.Message);
            }
        }
    }
}
