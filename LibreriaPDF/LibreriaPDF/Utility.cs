using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using System;

namespace LibreriaPDF
{
    public class Utility
    {
        public static Document CreatePDF(string ruta)
        {
            PdfWriter writer = new PdfWriter(ruta);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, PageSize.LETTER);
            document.SetMargins(60, 20, 55, 20);

            return document;
        }

        public static Document EncabezadoPDF(Document document, string sistema, string nombreReporte)
        {
            PdfFont fontEncabezado = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Paragraph titulo = new Paragraph(sistema).SetFont(fontEncabezado);
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);
            document.Add(titulo);
            titulo = new Paragraph(nombreReporte).SetFont(fontEncabezado);
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);
            document.Add(titulo);

            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            string hora = DateTime.Now.ToString("hh:mm:ss");
            Paragraph fechaYHora = new Paragraph("Fecha: " + fecha + "\nHORA: " + hora);
            fechaYHora.SetTextAlignment(TextAlignment.RIGHT);
            fechaYHora.SetFontSize(10);
            document.Add(fechaYHora);

            return document;
        }

        public static Table EncabezadoTabla(string[] columnas, float[] tamanio)
        {
            PdfFont fontEncabezado = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            Table table = new Table(UnitValue.CreatePercentArray(tamanio));
            table.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                Paragraph p = new Paragraph(columna).SetFont(fontEncabezado);
                table.AddHeaderCell(new Cell().Add(p));
            }

            return table;
        }
    }
}
