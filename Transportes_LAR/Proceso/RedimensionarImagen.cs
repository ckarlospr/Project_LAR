using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Transportes_LAR.Proceso
{
	public class RedimensionarImagen
	{
		public RedimensionarImagen()
		{
		}
		
		public Image Redimensionar(Image image){
			int anchoDestino = 113;
			int altoDestino = 151;
			int resolucion = Convert.ToInt32(image.HorizontalResolution);
			return Redimensionar(image, anchoDestino, altoDestino, resolucion);
		}
		
		private Image Redimensionar(Image Imagen, int Ancho, int Alto, int resolucion)
		{
			using (Bitmap imagenBitmap = new Bitmap(Ancho, Alto, PixelFormat.Format32bppRgb))
			{
				imagenBitmap.SetResolution(resolucion, resolucion);
				using (Graphics imagenGraphics = Graphics.FromImage(imagenBitmap))
				{
					imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
					imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					imagenGraphics.DrawImage(Imagen, new Rectangle(0, 0, Ancho, Alto), new Rectangle(0, 0, Imagen.Width, Imagen.Height), GraphicsUnit.Pixel);
					MemoryStream imagenMemoryStream = new MemoryStream();
					imagenBitmap.Save(imagenMemoryStream, ImageFormat.Jpeg);
					Imagen = Image.FromStream(imagenMemoryStream);
				}
			}
			return Imagen;
		}
		
		public Image RedimensionarDinamica(Image Imagen, int Ancho, int Alto, int resolucion)
		{
			using (Bitmap imagenBitmap = new Bitmap(360, 420, PixelFormat.Format32bppRgb))
			{
				imagenBitmap.SetResolution(resolucion, resolucion);
				using (Graphics imagenGraphics = Graphics.FromImage(imagenBitmap))
				{
					imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
					imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					//imagenGraphics.DrawImage(Imagen, new Rectangle(0, 0, Ancho, Alto), new Rectangle(0, 0, Imagen.Width, Imagen.Height), GraphicsUnit.Pixel);
					//imagenGraphics.DrawImage(Imagen, 0, 0, new Rectangle(160, 50, 480, 430), GraphicsUnit.Pixel);
					imagenGraphics.DrawImage(Imagen, 0, 0, new Rectangle(130, 20, 490, 440), GraphicsUnit.Pixel);
					MemoryStream imagenMemoryStream = new MemoryStream();
					imagenBitmap.Save(imagenMemoryStream, ImageFormat.Jpeg);
					Imagen = Image.FromStream(imagenMemoryStream);
				}
			}
			return Imagen;
		}
	}
}
