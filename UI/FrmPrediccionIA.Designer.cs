using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    partial class FrmPrediccionIA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCliente.Location = new System.Drawing.Point(250, 80);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(220, 25);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtMesPrediccion
            // 
            this.txtMesPrediccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMesPrediccion.Location = new System.Drawing.Point(250, 140);
            this.txtMesPrediccion.Name = "txtMesPrediccion";
            this.txtMesPrediccion.Size = new System.Drawing.Size(220, 25);
            this.txtMesPrediccion.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResultado.Location = new System.Drawing.Point(250, 295);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(220, 25);
            this.txtResultado.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(20, 340);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(760, 30);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEntrenar.Location = new System.Drawing.Point(250, 190);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(220, 30);
            this.btnEntrenar.TabIndex = 4;
            this.btnEntrenar.Text = "Entrenar Modelo";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // btnPredecir
            // 
            this.btnPredecir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPredecir.Location = new System.Drawing.Point(250, 230);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(220, 30);
            this.btnPredecir.TabIndex = 5;
            this.btnPredecir.Text = "Realizar Predicción";
            this.btnPredecir.UseVisualStyleBackColor = true;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(250, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(200, 20);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Nombre del Cliente:";
            // 
            // lblMes
            // 
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMes.Location = new System.Drawing.Point(250, 120);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(200, 20);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes a Predecir:";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(250, 272);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(200, 20);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado:";
            // 
            // FrmPrediccionIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnPredecir);
            this.Controls.Add(this.btnEntrenar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtMesPrediccion);
            this.Controls.Add(this.txtNombreCliente);
            this.Name = "FrmPrediccionIA";
            this.Text = "Módulo de Predicción con IA";


            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtMesPrediccion;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnPredecir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblResultado;
    }
}
