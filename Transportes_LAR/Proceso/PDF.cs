using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Transportes_LAR.Proceso
{
	public class PDF
	{
		public PDF()
		{
			
		}
		
		#region ENCABEZADO
		public PdfPCell EncWhite215209(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 3f;
			CSS.BorderWidthTop = 3f;
			CSS.PaddingBottom = 8f;
			CSS.PaddingTop = 6f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell EncWhite215212(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 3f;
			CSS.BorderWidthTop = 3f;
			CSS.PaddingBottom = 8f;
			CSS.PaddingTop = 6f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell Enclgray215209(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 3f;
			CSS.BorderWidthTop = 3f;
			CSS.PaddingBottom = 8f;
			CSS.PaddingTop = 6f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell Enclgray215207(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 3f;
			CSS.BorderWidthTop = 3f;
			CSS.PaddingBottom = 8f;
			CSS.PaddingTop = 6f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell Enclgray215209Normal(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.PaddingBottom = 4f;
			CSS.PaddingTop = 4f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}	

		public PdfPCell Enclgray215209NormalBorde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingBottom = 4f;
			CSS.PaddingTop = 4f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}			
		
		public PdfPCell Arial16BoldsinBorde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 3f;
			CSS.BorderWidthTop = 3f;
			CSS.PaddingBottom = 8f;
			CSS.PaddingTop = 6f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell Enclgray215206(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 1f;
			CSS.BorderWidthTop = 1f;
			CSS.PaddingBottom = 4f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell Enclgray21520201(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 2, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 1f;
			CSS.BorderWidthTop = 1f;
			CSS.PaddingBottom = 3f;
			CSS.PaddingTop = 3f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell EncGray124209(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.BLACK;
			CSS.BorderWidthBottom = 3f;
			CSS.BorderWidthTop = 3f;
			CSS.PaddingBottom = 8f;
			CSS.PaddingTop = 6f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		#endregion
		
		#region ESPACIOS
		public PdfPCell Esp2White115308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.Colspan = 2;
			return CSS;
		}
		
		public PdfPCell Esp3White115308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.Colspan = 3;
			return CSS;
		}
		#endregion
		
		#region TEXTO VERTICAL
		public PdfPCell VerWhite115307(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.Rotation = 90;
			return CSS;
		}
		#endregion
		
		#region TITULOS
		public PdfPCell TitWhite115308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite115308FondoGris(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;			
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite1153082(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite115206(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite115210(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite114308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite114308Sinborde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;			
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.BorderWidthLeft = 0f;
			CSS.BorderWidthRight = 0f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430802(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 1f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430802LightGray(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.LIGHT_GRAY)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430802Padding5(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 5f;
			CSS.PaddingTop = 5f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430802Enc(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 5f;
			CSS.PaddingTop = 5f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430802_2(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
				
		public PdfPCell TitWhite111312(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitLgray114308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitLgray1143081(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 2;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitLgray114312(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitLgray115308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitLgray11530802(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.WHITE;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitLgray115312(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitWhite115304(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingRight = 0f;
			CSS.PaddingLeft = 1f;
			CSS.Rotation = 90;
			return CSS;
		}
		
		public PdfPCell TitGray115308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitGray11530802(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.WHITE;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitGray115310(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TitGray114308(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		#endregion
		
		#region TEXTO
		public PdfPCell TexWhite111107(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite111107_2(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite111111(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite114111(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite112107(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_CENTER;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite115107(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite112106(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexWhite115106(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell TexLgray115205(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			return CSS;
		}
		
		public PdfPCell TexWhite115105(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.PaddingTop = 0f;
			return CSS;
		}
		
		public PdfPCell TexWhite114105(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.PaddingTop = 0f;
			return CSS;
		}
		#endregion
		
		#region FOTO
		public PdfPCell Foto(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.FixedHeight = 100f;
			CSS.MinimumHeight = 100f;
			return CSS;
		}
		
		public PdfPCell Foto(iTextSharp.text.Image imagen)
		{
			PdfPCell CSS = new PdfPCell(imagen);
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.FixedHeight = 90f;
			CSS.MinimumHeight = 90f;
			return CSS;
		}
		
		public PdfPCell FotoNomina(iTextSharp.text.Image imagen)
		{
			PdfPCell CSS = new PdfPCell(imagen);
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.FixedHeight = 110f;
			CSS.MinimumHeight = 110f;
			return CSS;
		}
		
		public PdfPCell FotoEmpleo(iTextSharp.text.Image imagen)
		{
			PdfPCell CSS = new PdfPCell(imagen);
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			//CSS.PaddingBottom = 0f;
			//CSS.PaddingTop = 0f;
			return CSS;
		}
		
		public PdfPCell FotoEmpleoAutorizacion(iTextSharp.text.Image imagen)
		{
			PdfPCell CSS = new PdfPCell(imagen);
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		#endregion
		
		#region SEPARADORES
		public PdfPCell SeparadorTableGris3(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 1, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.GRAY;
			CSS.FixedHeight = 3f;
			CSS.MinimumHeight = 3f;
			return CSS;
		}
		
		public PdfPCell SeparadorTableGris50(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.WHITE;
			CSS.FixedHeight = 50f;
			CSS.MinimumHeight = 50f;
			return CSS;
		}
		
		public PdfPCell SeparadorTableGris30(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.WHITE;
			CSS.FixedHeight = 20f;
			CSS.MinimumHeight = 20f;
			return CSS;
		}
		
		public PdfPCell SeparadorTableGris30SinBorde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.WHITE;
			CSS.FixedHeight = 20f;
			CSS.MinimumHeight = 20f;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}		
		#endregion
		
		#region LOGOS
		public iTextSharp.text.Image Logo(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(10,740);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoLeft(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(180,740);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoFactura(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(380,740);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoSolicitud(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(30,745);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(75f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoSolicitud2(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/Imagen1.jpg");
			jpg.SetAbsolutePosition(25,730);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(45f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoAutorizacion(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/Imagen1.jpg");
			jpg.SetAbsolutePosition(30,745);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(45f);
 			return jpg;
		}
				
		public iTextSharp.text.Image LogoSolicitudManejo(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(30,425);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(45f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoFactura2(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(380,725);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		
		public iTextSharp.text.Image LogoOrden(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(420,740);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoReciboArriba(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(20,740);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		public iTextSharp.text.Image LogoReciboAbajo(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(20, 440);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		#endregion
		
		#region GRAFICA
		public iTextSharp.text.Image Grafica(iTextSharp.text.Image jpg)
		{
			jpg.SetAbsolutePosition(15, 15);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScaleAbsolute(580f, 300f);
 			return jpg;
		}
		#endregion
		
		#region PAGARE
		public iTextSharp.text.Image ImagenPagare(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/Pagare.png");
			jpg.SetAbsolutePosition(10, 5);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		
		public iTextSharp.text.Image ImagenCantidad(PdfWriter writer)
		{
			PdfContentByte cb = writer.DirectContent;
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/letras.png");
			jpg.SetAbsolutePosition(190, 95);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
			jpg.ScalePercent(70f);
 			return jpg;
		}
		#endregion
		
		#region PARAGRAPH'S

		public Paragraph TextoPagare(String Texto)
		{
			Paragraph CSS = new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK));
			return CSS;
		}
		
		public Paragraph TextoPagare14(String Texto)
		{
			Paragraph CSS = new Paragraph(Texto, FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK));
			return CSS;
		}
		
		public Paragraph TextoPagareBold(String Texto)
		{
			Paragraph CSS = new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
			return CSS;
		}
		
		public Paragraph TextoPagareBold12(String Texto)
		{
			Paragraph CSS = new Paragraph(Texto, FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
			return CSS;
		}
		
		
		public Paragraph TextoContrato(String Texto)
		{
			Paragraph CSS = new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK));
			return CSS;
		}
		#endregion
		
		#region CHUCK´S
		public Chunk TextoContratoNegritas(String Texto)
		{
			Chunk CSS = new Chunk(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK));
			return CSS;
		}
		#endregion
		
		#region MARCA DE AGUA TEXTO
		public PdfPCell AliasRecibo(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 32, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.LIGHT_GRAY)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			return CSS;
		}
		
		public PdfPCell LocalizacionOperador(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.LIGHT_GRAY)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_LEFT;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			return CSS;
		}
		#endregion
		
		#region TAMAÑO TABLA
		public PdfPCell Tamaño(iTextSharp.text.pdf.PdfPTable tabla)
		{
			PdfPCell CSS = new PdfPCell(tabla);
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_TOP;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.FixedHeight = 130f;
			CSS.MinimumHeight = 130f;
			return CSS;
		}
		
		public PdfPCell Tamaño2(iTextSharp.text.pdf.PdfPTable tabla)
		{
			PdfPCell CSS = new PdfPCell(tabla);
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_TOP;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.FixedHeight = 130f;
			CSS.MinimumHeight = 130f;
			return CSS;
		}
		#endregion
		
		public PdfPCell ColorMatriz(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.GRAY;
			return CSS;
		}
		
		public PdfPCell TextoIzq15(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.FixedHeight = 15f;
			CSS.MinimumHeight = 15f;
			return CSS;
		}
		
		public PdfPCell DivisionGris20(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.Colspan = 20;
			return CSS;
		}
		
		public PdfPCell DivisionGris8(String Texto)
		{			
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			//CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.Colspan = 3;
			return CSS;
		}		
	
		public PdfPCell Blanco(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		public PdfPCell Blanco2(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.Colspan = 17;			
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		public PdfPCell Blanco3(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 5, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			CSS.Colspan = 16;			
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		public PdfPCell BlancoDirectorio(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		////////////////////////////////////////////////////////////////////////////// SOLICITUD DE EMPLEO //////////////////////////////////////////////////////////////////////////////
		public PdfPCell TitWhite11430802BOLD(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
			
		public PdfPCell Enclgray215206Borde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingBottom = 4f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		public PdfPCell Enclgray215206SinBorde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.PaddingBottom = 4f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}		
		
		public PdfPCell TitWhite11430802JUSTIFIED(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_JUSTIFIED;
			CSS.PaddingBottom = 1f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;			
			//CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;		
			return CSS;
		}
		
		public PdfPCell Enclgray215209SinBorde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
			CSS.VerticalAlignment = Element.ALIGN_JUSTIFIED;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 0f;
			CSS.PaddingLeft = 0f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430802SinBorde(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.BorderWidthLeft = 0f;
			CSS.BorderWidthRight = 0f;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 0f;
			CSS.PaddingLeft = 0f;
			return CSS;
		}			
		
		public PdfPCell TitWhite114318Red(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED)));
			CSS.HorizontalAlignment = 2;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.BorderWidthLeft = 0f;
			CSS.BorderWidthRight = 0f;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 2f;
			CSS.PaddingRight = 0f;
			CSS.PaddingLeft = 0f;
			return CSS;
		}
		
		public PdfPCell TitWhite11430602FondoGris(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;			
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingBottom = 1f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 0f;
			CSS.PaddingLeft = 0f;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.BorderWidthLeft = 0f;
			CSS.BorderWidthRight = 0f;
			
			return CSS;
		}	
		
		
		public PdfPCell TitWhite11430802FondoGris(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		
		public PdfPCell Blanco4(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 5f;
			CSS.PaddingLeft = 5f;	
			CSS.VerticalAlignment = Element.ALIGN_CENTER;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		public PdfPCell Blanco4Justificado(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 0;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 5f;
			CSS.PaddingLeft = 5f;	
			CSS.VerticalAlignment = Element.ALIGN_JUSTIFIED_ALL;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		public PdfPCell Blanco9(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 1;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 1f;
			CSS.PaddingRight = 5f;
			CSS.PaddingLeft = 5f;	
			CSS.VerticalAlignment = Element.ALIGN_CENTER;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}		
		
		public PdfPCell Blanco7(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = 2;
			CSS.PaddingBottom = 0f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 0f;
			CSS.PaddingLeft = 0f;	
			CSS.VerticalAlignment = Element.ALIGN_CENTER;
			CSS.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			return CSS;
		}
		
		public PdfPCell TitGray115308Empleo(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.WHITE)));
			CSS.HorizontalAlignment = 1;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.BackgroundColor =  iTextSharp.text.BaseColor.LIGHT_GRAY;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;
			return CSS;
		}
		
		////////////////////////////////////////////////////////////////////////////// CONTRATO VENTAS //////////////////////////////////////////////////////////////////////////////
		public PdfPCell TitWhiteNormal(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;			
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.BorderWidthLeft = 0f;
			CSS.BorderWidthRight = 0f;
			return CSS;
		}
		
		public PdfPCell TitWhiteBold(String Texto)
		{
			PdfPCell CSS = new PdfPCell(new Paragraph(Texto, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
			CSS.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
			CSS.VerticalAlignment = Element.ALIGN_MIDDLE;
			CSS.PaddingBottom = 2f;
			CSS.PaddingTop = 0f;
			CSS.PaddingRight = 1f;
			CSS.PaddingLeft = 1f;			
			CSS.BorderColor = iTextSharp.text.BaseColor.WHITE;
			CSS.BorderWidthBottom = 0f;
			CSS.BorderWidthTop = 0f;
			CSS.BorderWidthLeft = 0f;
			CSS.BorderWidthRight = 0f;
			return CSS;
		}
	}
}
