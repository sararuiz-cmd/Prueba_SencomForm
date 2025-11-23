namespace Proyect_Sencom_Form.UI
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVerGrafico;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnPrediccionIA;
        private System.Windows.Forms.Button btnExportarPdf;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnVerGrafico = new System.Windows.Forms.Button();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnPrediccionIA = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 13);
            this.lblUsuario.Text = "Usuario actual:";
            // 
            // btnVerGrafico
            // 
            this.btnVerGrafico.Location = new System.Drawing.Point(20, 60);
            this.btnVerGrafico.Name = "btnVerGrafico";
            this.btnVerGrafico.Size = new System.Drawing.Size(180, 30);
            this.btnVerGrafico.Text = "Ver Gráfico";
            this.btnVerGrafico.UseVisualStyleBackColor = true;
            this.btnVerGrafico.Click += new System.EventHandler(this.btnVerGrafico_Click);
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.Location = new System.Drawing.Point(220, 60);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Size = new System.Drawing.Size(180, 30);
            this.btnRegistrarFactura.Text = "Registrar Factura";
            this.btnRegistrarFactura.UseVisualStyleBackColor = true;
            this.btnRegistrarFactura.Click += new System.EventHandler(this.btnRegistrarFactura_Click);
            // 
            // btnPrediccionIA
            // 
            this.btnPrediccionIA.Location = new System.Drawing.Point(20, 110);
            this.btnPrediccionIA.Name = "btnPrediccionIA";
            this.btnPrediccionIA.Size = new System.Drawing.Size(180, 30);
            this.btnPrediccionIA.Text = "Predicción IA";
            this.btnPrediccionIA.UseVisualStyleBackColor = true;
            this.btnPrediccionIA.Click += new System.EventHandler(this.btnPrediccionIA_Click);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.Location = new System.Drawing.Point(220, 110);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(180, 30);
            this.btnExportarPdf.Text = "Exportar PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = true;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 180);
            this.Controls.Add(this.btnExportarPdf);
            this.Controls.Add(this.btnPrediccionIA);
            this.Controls.Add(this.btnRegistrarFactura);
            this.Controls.Add(this.btnVerGrafico);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
