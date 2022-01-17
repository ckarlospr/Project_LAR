using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Transportes_LAR.Interfaz.Nomina;
using System.Collections.Generic;

namespace Transportes_LAR.Proceso
{
	public class PDFooterVentas: PdfPageEventHelper 
	{
		int numHojas;
		public PDFooterVentas(int numHojas){
			this.numHojas = numHojas;
		}
				
		public override void OnEndPage(PdfWriter writer, Document document) 
        {
			PdfContentByte cb = writer.DirectContent;
			
			cb.BeginText();
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false), 10);
			cb.SetTextMatrix(550, 10);
			cb.ShowText("Página "+writer.PageNumber+"/"+numHojas);
	        cb.EndText();
		}
	}
}
