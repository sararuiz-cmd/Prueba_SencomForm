using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyect_Sencom_Form.Domain;

namespace Proyect_Sencom_Form.UI
{
    public partial class FrmListaFacturas : Form
    {
        public FrmListaFacturas(List<Factura> facturas)
        {
            InitializeComponent();
            dgvFacturas.AutoGenerateColumns = true;
            dgvFacturas.DataSource = facturas;
        }
    }
}
