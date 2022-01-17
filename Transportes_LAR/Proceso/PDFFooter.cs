using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Transportes_LAR.Interfaz.Nomina;
using System.Collections.Generic;

namespace Transportes_LAR.Proceso
{
	public class PDFFooter: PdfPageEventHelper 
	{
		int Paginas = 0;
		string vehiculo = "";
		
		public PDFFooter(int Paginas, string vehiculo)
		{
			this.Paginas = Paginas;
			this.vehiculo = vehiculo;
		}
		
		public PDFFooter(int Paginas)
		{
			this.Paginas = Paginas;
		}
		
		/*public override void OnStartPage(PdfWriter writer, Document document) 
        {
			PdfContentByte cb = writer.DirectContent;
		 	cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLDOBLIQUE, BaseFont.CP1252, false), 12);
			cb.SetTextMatrix(275, 770);
			cb.ShowText(vehiculo);
			cb.EndText();
			document.Add(new Phrase(Environment.NewLine));
		}*/
		
		public override void OnEndPage(PdfWriter writer, Document document) 
        {
			PdfContentByte cb = writer.DirectContent;
			
			cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLDOBLIQUE, BaseFont.CP1252, false), 12);
			cb.SetTextMatrix(215, 770);
			cb.ShowText(vehiculo);
			cb.EndText();
			
		 	cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false), 10);
			cb.SetTextMatrix(10, 10);
			//cb.ShowText("Fecha de impresión: "+DateTime.Now.ToShortDateString()+ " " + DateTime.Now.ToShortTimeString());
			//cb.ShowText("Fecha de impresión: "+DateTime.Now+"             Operadores Activos: "+new Conexion_Servidor.Operador.SQL_Operador().OperadoresActivos());
			cb.ShowText("Fecha de impresión: "+DateTime.Now+"      Operadores con unidad: "+new Conexion_Servidor.Operador.SQL_Operador().OperadoresAsignados()+"      Operadores sin unidad: "+new Conexion_Servidor.Operador.SQL_Operador().OperadoresSinAsignar());
			cb.EndText();
			
			cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false), 10);
			cb.SetTextMatrix(525, 10);
	        cb.ShowText("Pagina "+writer.PageNumber+" de "+this.Paginas);
	        cb.EndText();
		}
	}
}
