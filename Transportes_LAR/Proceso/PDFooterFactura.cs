using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Transportes_LAR.Interfaz.Nomina;
using System.Collections.Generic;
namespace Transportes_LAR.Proceso
{
	public class PDFooterFactura: PdfPageEventHelper 
	{
		string usuario = "";
		
		public PDFooterFactura(string usuario)
		{
			this.usuario = usuario;
		}
				
		public override void OnEndPage(PdfWriter writer, Document document) 
        {
			PdfContentByte cb = writer.DirectContent;
			
			cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLDOBLIQUE, BaseFont.CP1252, false), 12);
			cb.SetTextMatrix(225, 30);
			cb.ShowText("____________________________");
			cb.EndText();
			
			cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false), 12);
			cb.SetTextMatrix(300, 15);
			cb.ShowText("Firma");
			cb.EndText();
			
		 	cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false), 8);
			cb.SetTextMatrix(10, 10);
			cb.ShowText("Fecha de impresión: "+DateTime.Now+"     Por: "+usuario);
			cb.EndText();
			
			cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false), 10);
			cb.SetTextMatrix(550, 10);
			cb.ShowText("Página "+writer.PageNumber);
	        cb.EndText();
		}
	}
}