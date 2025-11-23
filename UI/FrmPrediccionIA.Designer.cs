using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    partial class FrmPrediccionIA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtMesPrediccion;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnPredecir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMesPrediccion = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.btnPredecir = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(40, 40);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(93, 13);
            this.lblCliente.Text = "Nombre Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 37);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(40, 80);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(79, 13);
            this.lblMes.Text = "Mes a Predecir:";
            // 
            // txtMesPrediccion
            // 
            this.txtMesPrediccion.Location = new System.Drawing.Point(160, 77);
            this.txtMesPrediccion.Name = "txtMesPrediccion";
            this.txtMesPrediccion.Size = new System.Drawing.Size(200, 20);
            this.txtMesPrediccion.TabIndex = 1;
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Location = new System.Drawing.Point(160, 115);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(200, 30);
            this.btnEntrenar.TabIndex = 2;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // btnPredecir
            // 
            this.btnPredecir.Location = new System.Drawing.Point(160, 155);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(200, 30);
            this.btnPredecir.TabIndex = 3;
            this.btnPredecir.Text = "Predecir";
            this.btnPredecir.UseVisualStyleBackColor = true;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(40, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(160, 197);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(200, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(40, 230);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(320, 30);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrediccionIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPredecir);
            this.Controls.Add(this.btnEntrenar);
            this.Controls.Add(this.txtMesPrediccion);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrediccionIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Predicción IA";
            this.Load += new System.EventHandler(this.FrmPrediccionIA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
