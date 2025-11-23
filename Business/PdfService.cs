using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyect_Sencom_Form.Domain;
using System.IO;

namespace Proyect_Sencom_Form.Business
{
    public class PdfService
    {
        public void GenerarReporteFactura(Factura factura, Cliente cliente, string ruta)
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                Paragraph titulo = new Paragraph("REPORTE DE FACTURA\n\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20));
                titulo.Alignment = Element.ALIGN_CENTER;

                doc.Add(titulo);

                doc.Add(new Paragraph($"Cliente: {cliente.Nombre}"));
                doc.Add(new Paragraph($"Dirección: {cliente.Direccion}"));
                doc.Add(new Paragraph($"ID Cliente: {cliente.IdCliente}\n"));

                doc.Add(new Paragraph($"ID Factura: {factura.IdFactura}"));
                doc.Add(new Paragraph($"Fecha: {factura.FechaEmision.ToShortDateString()}"));
                doc.Add(new Paragraph($"Cap. Planta (kW): {factura.CapacidadPlantaKw}"));
                doc.Add(new Paragraph($"Producción mensual (kWh): {factura.ProduccionKwhMes}"));
                doc.Add(new Paragraph($"Monto mensual: {factura.MontoMes:C2}"));
                doc.Add(new Paragraph($"Monto acumulado: {factura.MontoAcumulado:C2}"));

                doc.Close();
            }
        }
    }
}
