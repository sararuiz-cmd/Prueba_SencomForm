using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.UI
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string title)
        {
            Form dialog = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
            };

            // === Sombra estilo Windows 11 ===
            dialog.Padding = new Padding(1);
            dialog.Paint += (s, e) =>
            {
                using (Pen p = new Pen(Color.LightGray))
                    e.Graphics.DrawRectangle(p, new Rectangle(0, 0, dialog.Width - 1, dialog.Height - 1));
            };

            // === Título ===
            Label lblTitle = new Label()
            {
                Text = title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(10, 0, 0, 0),
                BackColor = Color.White
            };

            // === Mensaje ===
            Label lblText = new Label()
            {
                Text = text,
                Left = 20,
                Top = 55,
                Width = 350,
                ForeColor = Color.Black
            };

            // === Caja de texto redondeada ===
            TextBox txtInput = new TextBox()
            {
                Left = 20,
                Top = 85,
                Width = 350,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10)
            };

            // === Botón aceptar estilo Win11 ===
            Button btnOk = new Button()
            {
                Text = "Aceptar",
                Left = 130,
                Top = 125,
                Width = 120,
                Height = 32,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White
            };

            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Cursor = Cursors.Hand;

            btnOk.Click += (sender, e) =>
            {
                dialog.DialogResult = DialogResult.OK;
                dialog.Close();
            };

            // === Botón cancelar ===
            Button btnCancel = new Button()
            {
                Text = "Cancelar",
                Left = 260,
                Top = 125,
                Width = 90,
                Height = 32,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGray
            };

            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Cursor = Cursors.Hand;

            btnCancel.Click += (sender, e) =>
            {
                dialog.DialogResult = DialogResult.Cancel;
                dialog.Close();
            };

            // === Agregar controles ===
            dialog.Controls.Add(lblTitle);
            dialog.Controls.Add(lblText);
            dialog.Controls.Add(txtInput);
            dialog.Controls.Add(btnOk);
            dialog.Controls.Add(btnCancel);

            return dialog.ShowDialog() == DialogResult.OK
                ? txtInput.Text
                : "";
        }
    }
}
