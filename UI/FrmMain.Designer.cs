namespace Proyect_Sencom_Form.UI
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnVerGrafico = new System.Windows.Forms.Button();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnPrediccionIA = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.btnVerOrdenadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(30, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(600, 30);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario actual:";
            // 
            // btnVerGrafico
            // 
            this.btnVerGrafico.Location = new System.Drawing.Point(250, 80);
            this.btnVerGrafico.Name = "btnVerGrafico";
            this.btnVerGrafico.Size = new System.Drawing.Size(280, 40);
            this.btnVerGrafico.TabIndex = 1;
            this.btnVerGrafico.Text = "Ver Gráfico de Consumo";
            this.btnVerGrafico.UseVisualStyleBackColor = true;
            this.btnVerGrafico.Click += new System.EventHandler(this.btnVerGrafico_Click);
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.Location = new System.Drawing.Point(250, 140);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Size = new System.Drawing.Size(280, 40);
            this.btnRegistrarFactura.TabIndex = 2;
            this.btnRegistrarFactura.Text = "Registrar Nueva Factura";
            this.btnRegistrarFactura.UseVisualStyleBackColor = true;
            this.btnRegistrarFactura.Click += new System.EventHandler(this.btnRegistrarFactura_Click);
            // 
            // btnPrediccionIA
            // 
            this.btnPrediccionIA.Location = new System.Drawing.Point(250, 200);
            this.btnPrediccionIA.Name = "btnPrediccionIA";
            this.btnPrediccionIA.Size = new System.Drawing.Size(280, 40);
            this.btnPrediccionIA.TabIndex = 3;
            this.btnPrediccionIA.Text = "Predicción con IA";
            this.btnPrediccionIA.UseVisualStyleBackColor = true;
            this.btnPrediccionIA.Click += new System.EventHandler(this.btnPrediccionIA_Click);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.Location = new System.Drawing.Point(250, 260);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(280, 40);
            this.btnExportarPdf.TabIndex = 4;
            this.btnExportarPdf.Text = "Exportar Última Factura a PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = true;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Location = new System.Drawing.Point(250, 320);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(280, 40);
            this.btnBuscarFactura.TabIndex = 5;
            this.btnBuscarFactura.Text = "Buscar Factura por ID";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // btnVerOrdenadas
            // 
            this.btnVerOrdenadas.Location = new System.Drawing.Point(250, 380);
            this.btnVerOrdenadas.Name = "btnVerOrdenadas";
            this.btnVerOrdenadas.Size = new System.Drawing.Size(280, 40);
            this.btnVerOrdenadas.TabIndex = 6;
            this.btnVerOrdenadas.Text = "Ver Facturas Ordenadas por Cliente";
            this.btnVerOrdenadas.UseVisualStyleBackColor = true;
            this.btnVerOrdenadas.Click += new System.EventHandler(this.btnVerOrdenadas_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnVerOrdenadas);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.btnExportarPdf);
            this.Controls.Add(this.btnPrediccionIA);
            this.Controls.Add(this.btnRegistrarFactura);
            this.Controls.Add(this.btnVerGrafico);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmMain";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVerGrafico;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnPrediccionIA;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Button btnVerOrdenadas;
    }
}
