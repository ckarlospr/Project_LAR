using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Transportes_LAR.Interfaz.Nomina;
using System.Collections.Generic; 
using NumeroLetras;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Transportes_LAR.Proceso
{
	public class FormatosPDF
	{
		#region INSTANCIAS
		private Conexion_Servidor.Facturacion.SQL_Facturacion connF = new Conexion_Servidor.Facturacion.SQL_Facturacion();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.PDF PDFs= new Transportes_LAR.Proceso.PDF();
		private Interfaz.Facturacion.FormFacturacion formFacturacion = null;
		List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
		#endregion
			
		#region CONSTRUCTOR
		public FormatosPDF()
		{
		}
		#endregion
		
		#region DIRECTORIO ILUSTRADO
		public void DirectorioIlustrado(Interfaz.FormPrincipal principal, Document document, 
		                                PdfWriter writer, DataGridView dtOperador, String Ingreso, 
		                                String VigEstatal, String VigFederal, PictureBox ptbImagen, 
		                                String Celular, String Unidad, String Alias, String Nomb, 
		                                String Ape, String ShortFecha, System.IO.MemoryStream ms, 
		                                Interfaz.Nomina.FormNomina FormNom, string vehiculo, String opcion)
		{
			int vacios = 0;
			int c = 1;
			PdfPTable Formato;
			PdfPTable Contenedor;
			List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
			
			int totalPaginas = 0;
			if(opcion=="1")
			{
				if(dtOperador.Rows.Count%20==0)
					totalPaginas = dtOperador.Rows.Count/20;
				else
				{
					totalPaginas = dtOperador.Rows.Count/20;
					++totalPaginas;
				}
			}
			else
			{
				if(dtOperador.Rows.Count%15==0)
					totalPaginas = dtOperador.Rows.Count/15;
				else
				{
					totalPaginas = dtOperador.Rows.Count/15;
					++totalPaginas;
				}
			}		
			
			writer.PageEvent = new PDFFooter(totalPaginas, vehiculo);
				
    		float[] wFormato = new float[] {20f, 20f, 20f, 20f, 20f};
			Formato = new PdfPTable(5);
			Formato.WidthPercentage = 100;
			Formato.SetWidths(wFormato);
				
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
				if(x>0)
				{
					dtOperador.Rows[x-1].Selected = false;
				}
				dtOperador.Rows[x].Selected = true;
				
				Celular = "";
				listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(dtOperador[0,x].Value.ToString());
				Ingreso = listNomina[0].Ingreso;
				Nomb = listNomina[0].Nomb;
				Ape = listNomina[0].Ape;
				Unidad = listNomina[0].Unidad;
				Celular = listNomina[0].Celular;
				if(Celular=="")
				{
					Celular ="-";
				}
				VigEstatal = listNomina[0].VigEstatal;
				VigFederal = listNomina[0].VigFederal;
				FormNom.DatosOperadorPDF(x);
				
			iTextSharp.text.Image foto2;
				
			if(ms==null)
				foto2 = iTextSharp.text.Image.GetInstance(@"../debug/Nomina.jpg");
			else
				foto2 = iTextSharp.text.Image.GetInstance(ptbImagen.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
			
			float[] widthsDatosEs = new float[] {100f};
			PdfPTable DatosEs = new PdfPTable(1);
			DatosEs.SetWidths(widthsDatosEs);
			DatosEs.AddCell(PDFs.TexLgray115205("Ingreso"));
			DatosEs.AddCell(PDFs.TexWhite115105(Ingreso));
			DatosEs.AddCell(PDFs.TexLgray115205("Asignación"));
			DatosEs.AddCell(PDFs.TexWhite115105("-"));
			if(VigEstatal=="" || VigEstatal == null)
			{
				DatosEs.AddCell(PDFs.TexLgray115205("Estatal"));
				DatosEs.AddCell(PDFs.TexWhite115105("-----"));
			}
			else
			{
				DatosEs.AddCell(PDFs.TexLgray115205("Estatal"));
				DatosEs.AddCell(PDFs.TexWhite115105(VigEstatal));
			}
			
			
			if(VigFederal=="" || VigFederal == null)
			{
				DatosEs.AddCell(PDFs.TexLgray115205("Federal"));
				DatosEs.AddCell(PDFs.TexWhite115105("-----"));
			}
			else
			{
				DatosEs.AddCell(PDFs.TexLgray115205("Federal"));
				DatosEs.AddCell(PDFs.TexWhite115105(VigFederal));
			}
			
			DatosEs.AddCell(PDFs.TexLgray115205("Teléfono(s)"));
			conn.getAbrirConexion("select T.tipo, T.Descripcion, T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Alias!='Admvo' and Alias!='ADMINOO' and T.tipo!='LAR' and O.ID="+dtOperador[0,x].Value.ToString());
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				DatosEs.AddCell(PDFs.TexWhite115105(conn.leer["Telefono"].ToString()));
			}
			conn.conexion.Close();
			conn.getAbrirConexion("select T.Numero " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Alias!='Admvo' and Alias!='ADMINOO' and T.tipo!='LAR' and O.ID="+dtOperador[0,x].Value.ToString());
			conn.leer=conn.comando.ExecuteReader();
			if(!conn.leer.Read())
				DatosEs.AddCell(PDFs.TexWhite115105("-"));
			conn.conexion.Close();
			
			float[] widthsFoto = new float[] {65f, 35f};
			PdfPTable Foto = new PdfPTable(2);
			Foto.SetWidths(widthsFoto);
			foto2.Border = iTextSharp.text.Rectangle.ALIGN_MIDDLE;
			foto2.ScaleAbsoluteHeight(90f);
			foto2.ScaleAbsoluteWidth(71f);
			Foto.AddCell(PDFs.Foto(foto2));
			Foto.AddCell(DatosEs);
			
			float[] widthsVehiculoVentas = new float[] {48f, 18f, 50f, 18f, 80f, 26f};
			PdfPTable VehiculoVentas = new PdfPTable(6);
			VehiculoVentas.SetWidths(widthsVehiculoVentas);
			conn.getAbrirConexion("select E.ID_categoria " +
			                      "from vehiculo v, EQUIPAMENTO E " +
			                      "where E.ID_Unidad=v.ID and E.ID_categoria='2' and v.Numero='"+Unidad+"'");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				VehiculoVentas.AddCell(PDFs.TitLgray114308("Aire"));
				VehiculoVentas.AddCell(PDFs.TexWhite115107("X"));
			}
			else
			{
				VehiculoVentas.AddCell(PDFs.TitLgray114308("Aire"));
				VehiculoVentas.AddCell(PDFs.TexWhite115107(" "));
			}
			conn.conexion.Close();
			conn.getAbrirConexion("select v.capacidad, E.ID_categoria " +
			                      "from vehiculo v, EQUIPAMENTO E " +
			                      "where E.ID_Unidad=v.ID and ID_categoria='3' and v.Numero='"+Unidad+"'");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				VehiculoVentas.AddCell(PDFs.TitLgray114308("Baño"));
				VehiculoVentas.AddCell(PDFs.TexWhite115107("X"));
			}
			else
			{
				VehiculoVentas.AddCell(PDFs.TitLgray114308("Baño"));
				VehiculoVentas.AddCell(PDFs.TexWhite115107(" "));
			}
			conn.conexion.Close();
			conn.getAbrirConexion("select capacidad " +
			                      "from vehiculo " +
			                      "where Numero='"+Unidad+"'");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				VehiculoVentas.AddCell(PDFs.TitLgray114308("Usuarios"));
				VehiculoVentas.AddCell(PDFs.TexWhite115107(conn.leer["capacidad"].ToString()));
			}
			conn.conexion.Close();
			
			float[] widthsTelefono = new float[] {20f, 80f};
			PdfPTable TELEFONO = new PdfPTable(2);
			TELEFONO.SetWidths(widthsTelefono);
			conn.getAbrirConexion("select Calle, Num_Exterior, Colonia, Municipio " +
			                      "from Operador O " +
			                      "where O.Alias!='Admvo' and Alias!='ADMINOO' and O.ID="+dtOperador[0,x].Value.ToString());
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				TELEFONO.AddCell(PDFs.TitLgray114308("Calle"));
				TELEFONO.AddCell(PDFs.TexWhite115106(conn.leer["Calle"].ToString().ToUpper()+" #"+conn.leer["Num_Exterior"].ToString()));
				TELEFONO.AddCell(PDFs.TitLgray114308("Col."));
				TELEFONO.AddCell(PDFs.TexWhite115106(conn.leer["Colonia"].ToString().ToUpper()+", "+conn.leer["Municipio"].ToString().ToUpper()));
			}
			conn.conexion.Close();
			
			PdfPCell headerVentas = new PdfPCell(VehiculoVentas);
			headerVentas.Colspan = 2;
			PdfPCell header2TELEFONO = new PdfPCell(TELEFONO);
			header2TELEFONO.Colspan = 2;
			float[] widthsvehiculo = new float[] {20f, 80f};
			PdfPTable tvehiculo = new PdfPTable(2);
			tvehiculo.SetWidths(widthsvehiculo);
			tvehiculo.AddCell(PDFs.TitLgray114308("RED"));
			tvehiculo.AddCell(PDFs.TitWhite115210(Celular));
			conn.getAbrirConexion("select Marca, Modelo, Tipo_Unidad " +
			                      "from vehiculo v " +
			                      "where v.Numero='"+Unidad+"'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				tvehiculo.AddCell(PDFs.TitLgray114308("Veh."));
				tvehiculo.AddCell(PDFs.TitWhite115210(conn.leer["Tipo_Unidad"].ToString()));
				if(opcion!="1")
				{
					tvehiculo.AddCell(PDFs.TitLgray114308("Des."));
					tvehiculo.AddCell(PDFs.TexWhite115107(conn.leer["Marca"].ToString().ToUpper()+", "+conn.leer["Modelo"].ToString()));
					tvehiculo.AddCell(headerVentas);
				}
				tvehiculo.AddCell(header2TELEFONO);
			}
			conn.conexion.Close();
			
			float[] widthsContenedor = new float[] {94f};
			Contenedor = new PdfPTable(1);
			Contenedor.TotalWidth = 470f;
			Contenedor.WidthPercentage = 20;
			Contenedor.SetWidths(widthsContenedor);
			Contenedor.AddCell(PDFs.TitGray115310(Unidad+" "+listNomina[0].Alias));
			Contenedor.AddCell(Foto);
			Contenedor.AddCell(PDFs.TitWhite115308(Nomb.ToUpper()));
			Contenedor.AddCell(PDFs.TitWhite115308(Ape.ToUpper()));
			Contenedor.AddCell(tvehiculo);
			//Contenedor.AddCell(TELEFONO);
			Formato.AddCell(Contenedor);
			
			principal.progressbarPrin.Minimum = 1;
    		principal.progressbarPrin.Maximum = dtOperador.Rows.Count; 
			principal.progressbarPrin.Increment(1);
			
				int residuo = dtOperador.Rows.Count%5;
				if(vacios==0&&dtOperador.Rows.Count-residuo<=x)
				{
					if(c==residuo)
					{
						residuo = 5 - residuo;
						for(int z=0;z<residuo;z++)
						{
							Formato.AddCell(PDFs.BlancoDirectorio("'"));
							vacios = 1;
						}
					}
					++c;
				}
			}
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			document.Add(Formato);
		}
		#endregion
		
		#region DIRECTORIO TELEFONICO
		public void DirectorioTelefonico(Interfaz.FormPrincipal principal, Document document, 
		                                PdfWriter writer, DataGridView dtOperador, String Ingreso, 
		                                String VigEstatal, String VigFederal, PictureBox ptbImagen, 
		                                String Celular, String Unidad, String Alias, String Nomb, 
		                                String Ape, String ShortFecha, System.IO.MemoryStream ms, 
		                                Interfaz.Nomina.FormNomina FormNom)
		{
			int y = 1;
			int divisor = 0;
			Paragraph espacio = new Paragraph("                                                                                     ", FontFactory.GetFont("ARIAL", 3));
			document.Add(PDFs.Logo(writer));
			
			List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
			
			float[] widths = new float[] {100f};
			PdfPTable tableContenedor = new PdfPTable(1);
			tableContenedor.SetWidths(widths);
			tableContenedor.TotalWidth = 100f;
			tableContenedor.WidthPercentage = 40;
			tableContenedor.HorizontalAlignment = 2;
			PdfPCell header2 = new PdfPCell(PDFs.TitGray115308("DIRECTORIO TELEFÓNICO"));
			header2.Colspan = 2;
			tableContenedor.AddCell(header2);
 			document.Add(tableContenedor);
 			
 			//Tabla de Datos del Operador
 			float[] widthsD = new float[]{40f, 60f};
			PdfPTable Datos = new PdfPTable(2);
			Datos.SetWidths(widthsD);
			Datos.WidthPercentage = 40;
			Datos.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			Datos.AddCell(PDFs.TitLgray114308("OFICINA LOCAL:"));
			Datos.AddCell(PDFs.TexWhite112107("38-24-39-85"));
			Datos.AddCell(PDFs.TitLgray114308("OFICINA RED:"));
			Datos.AddCell(PDFs.TexWhite112107("33-34-41-49-26"));
			Datos.AddCell(PDFs.TitLgray114308("TALLER LAR:"));
			Datos.AddCell(PDFs.TexWhite112107("31-26-10-04 y 31-26-10-08"));
			Datos.AddCell(PDFs.TitLgray114308("LUIS ARRIAGA RUIZ:"));
			Datos.AddCell(PDFs.TexWhite112107("3331158856"));
			document.Add(Datos);
			document.Add(espacio);
			
			//Numero de registros
			conn.getAbrirConexion("select Alias, tipo_empleado, T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='LAR' AND tipo_empleado!='OPERADOR' and O.Alias!='Admvo' and Alias!='ADMINOO' ORDER BY Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				divisor = divisor + 1;
			}
			conn.conexion.Close();
			
			divisor = (divisor/2);
			
			// Tabla Columna empleados oficinas y taller
				float[] widthsCoordinador = new float[]  {5f, 19f, 30f, 21f};
				PdfPTable TbCoordinador = new PdfPTable(4);
				TbCoordinador.SetWidths(widthsCoordinador);
				TbCoordinador.AddCell(PDFs.TitLgray115308("#"));
				TbCoordinador.AddCell(PDFs.TitLgray115308("NICK"));
				TbCoordinador.AddCell(PDFs.TitLgray115308("PUESTO"));
				TbCoordinador.AddCell(PDFs.TitLgray115308("RED LAR"));
	
				conn.getAbrirConexion("select Alias, tipo_empleado, T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='LAR' AND tipo_empleado!='OPERADOR' and O.Alias!='Admvo' and Alias!='ADMINOO' ORDER BY Alias");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(y<=divisor)
					{
						TbCoordinador.AddCell(PDFs.TexWhite112107(y.ToString()));
						TbCoordinador.AddCell(PDFs.TexWhite112107(conn.leer["Alias"].ToString()));
						TbCoordinador.AddCell(PDFs.TexWhite112107(conn.leer["tipo_empleado"].ToString()));
						if(conn.leer["Telefono"].ToString()!="")
							TbCoordinador.AddCell(PDFs.TexWhite112107(conn.leer["Telefono"].ToString()));
						else
							TbCoordinador.AddCell(PDFs.TexWhite112107("-"));
						++y;
					}
				}
				conn.conexion.Close();
				
				divisor = divisor + divisor;
				
				float[] widthsCoordinador2 = new float[]  {5f, 19f, 30f, 21f};
				PdfPTable TbCoordinador2 = new PdfPTable(4);
				TbCoordinador2.SetWidths(widthsCoordinador2);
				TbCoordinador2.AddCell(PDFs.TitLgray115308("#"));
				TbCoordinador2.AddCell(PDFs.TitLgray115308("NICK"));
				TbCoordinador2.AddCell(PDFs.TitLgray115308("PUESTO"));
				TbCoordinador2.AddCell(PDFs.TitLgray115308("RED LAR"));
				int m = 1;
				conn.getAbrirConexion("select Alias, tipo_empleado, T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='LAR' AND tipo_empleado!='OPERADOR' and O.Alias!='Admvo' and Alias!='ADMINOO' ORDER BY Alias");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(y<=divisor && m>(divisor/2))
					{
						TbCoordinador2.AddCell(PDFs.TexWhite112107(y.ToString()));
						TbCoordinador2.AddCell(PDFs.TexWhite112107(conn.leer["Alias"].ToString()));
						TbCoordinador2.AddCell(PDFs.TexWhite112107(conn.leer["tipo_empleado"].ToString()));
						if(conn.leer["Telefono"].ToString()!="")
							TbCoordinador2.AddCell(PDFs.TexWhite112107(conn.leer["Telefono"].ToString()));
						else
							TbCoordinador2.AddCell(PDFs.TexWhite112107("-"));
						++y;
					}
					++m;
				}
				conn.conexion.Close();
			
			// Tabla Columna central izq - OPERADOR
			float[] widthsAnticipos = new float[]  {6f, 14f, 20f, 20f, 20f, 20f};
			PdfPTable TbAnticipos = new PdfPTable(6);
			TbAnticipos.SetWidths(widthsAnticipos);
			TbAnticipos.AddCell(PDFs.TitLgray115308("#"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("UNIDAD"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("NICK"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("RED LAR"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("PARTICULAR"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("CASA"));
			for(int x=0; x<dtOperador.Rows.Count/2; x++)
			{
				if(x>0)
				{
					dtOperador.Rows[x-1].Selected = false;
				}
				dtOperador.Rows[x].Selected = true;
				
				Celular = "";
				listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(dtOperador[0,x].Value.ToString());
				Unidad = listNomina[0].Unidad;
				Celular = listNomina[0].Celular;
				if(Celular=="")
				{
					Celular ="-";
				}
				FormNom.DatosOperadorPDF(x);
				
				
				TbAnticipos.AddCell(PDFs.TexWhite112107((x+1).ToString()));
				TbAnticipos.AddCell(PDFs.TexWhite112107(Unidad));
				TbAnticipos.AddCell(PDFs.TexWhite112107(dtOperador[1,x].Value.ToString()));
				TbAnticipos.AddCell(PDFs.TexWhite112107(Celular));
				
				conn.getAbrirConexion("select T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='Celular' and O.Alias!='Admvo' and Alias!='ADMINOO' and O.ID ="+dtOperador[0,x].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["Telefono"].ToString()!="")
						TbAnticipos.AddCell(PDFs.TexWhite112107(conn.leer["Telefono"].ToString()));
				}
				else
					TbAnticipos.AddCell(PDFs.TexWhite112107("-"));
				
				conn.conexion.Close();
				
				conn.getAbrirConexion("select T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='Fijo' and O.Alias!='Admvo' and Alias!='ADMINOO' and O.ID ="+dtOperador[0,x].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["Telefono"].ToString()!="")
						TbAnticipos.AddCell(PDFs.TexWhite112107(conn.leer["Telefono"].ToString()));
				}
				else
					TbAnticipos.AddCell(PDFs.TexWhite112107("-"));
				
				conn.conexion.Close();
			}
			//TbContenerdorC.AddCell(tableEncDescuentos);
			
			// Tabla Columna central derecha
			PdfPTable tablePrestamos = new PdfPTable(1);
			tablePrestamos.TotalWidth = 100f;
			tablePrestamos.WidthPercentage = 50;
			tablePrestamos.HorizontalAlignment = 0;
			float[] widthsAnticiposPrestamos = new float[]  {6f, 14f, 20f, 20f, 20f, 20f};
			PdfPTable TbAnticiposPrestamos = new PdfPTable(6);
			TbAnticiposPrestamos.SetWidths(widthsAnticiposPrestamos);
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("#"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("UNIDAD"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("NICK"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("RED LAR"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("PARTICULAR"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("CASA"));
			//
			for(int x=((dtOperador.Rows.Count/2)); x<dtOperador.Rows.Count; x++)
			{
				if(x>0)
				{
					dtOperador.Rows[x-1].Selected = false;
				}
				dtOperador.Rows[x].Selected = true;
				
				Celular = "";
				listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(dtOperador[0,x].Value.ToString());
				Unidad = listNomina[0].Unidad;
				Celular = listNomina[0].Celular;
				if(Celular=="")
				{
					Celular ="-";
				}
				FormNom.DatosOperadorPDF(x);
				
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107((x+1).ToString()));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(Unidad));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(dtOperador[1,x].Value.ToString()));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(Celular));
				
				conn.getAbrirConexion("select T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='Celular' and O.Alias!='Admvo' and Alias!='ADMINOO' and O.ID ="+dtOperador[0,x].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["Telefono"].ToString()!="")
						TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(conn.leer["Telefono"].ToString()));
				}
				else
					TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107("-"));
				
				conn.conexion.Close();
				
				conn.getAbrirConexion("select T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='Fijo' and O.Alias!='Admvo' and Alias!='ADMINOO' and O.ID ="+dtOperador[0,x].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["Telefono"].ToString()!="")
						TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(conn.leer["Telefono"].ToString()));
				}
				else
					TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107("-"));
				
				conn.conexion.Close();
			}
			tablePrestamos.AddCell(PDFs.Tamaño(TbAnticiposPrestamos));
			//TbContenerdorC.AddCell(tablePrestamos);
			
			//Contenedor Descuentos
			PdfPCell headertelefonos0 = new PdfPCell(PDFs.TitGray115308("OFICINA LAR"));
			headertelefonos0.Colspan = 4;
			float[] widthsContenedorC0 = new float[] {50f, 50f};
			PdfPTable TbContenerdorC0 = new PdfPTable(2);
			TbContenerdorC0.SetWidths(widthsContenedorC0);
			TbContenerdorC0.TotalWidth = 470f;
			TbContenerdorC0.WidthPercentage = 100;
			TbContenerdorC0.AddCell(headertelefonos0);
			TbContenerdorC0.AddCell(TbCoordinador);
			TbContenerdorC0.AddCell(TbCoordinador2);
			document.Add(TbContenerdorC0);
			
			PdfPCell headertelefonos = new PdfPCell(PDFs.TitGray115308("OPERADORES LAR"));
			headertelefonos.Colspan = 2;
			float[] widthsContenedorC = new float[] {235f, 235f};
			PdfPTable TbContenerdorC = new PdfPTable(2);
			TbContenerdorC.SetWidths(widthsContenedorC);
			TbContenerdorC.TotalWidth = 470f;
			TbContenerdorC.WidthPercentage = 100;
			TbContenerdorC.AddCell(headertelefonos);
			TbContenerdorC.AddCell(TbAnticipos);
			TbContenerdorC.AddCell(tablePrestamos);
			document.Add(TbContenerdorC);
			writer.PageEvent = new PDFFooter(1);
		}
		#endregion
		
		#region Orden Compra
		public void OrdenCompra(Interfaz.FormPrincipal principal, Document document, PdfWriter writer, 
		                       	String folio, String fecha, String factura, String Semana, String Vencimiento, String CodProv, String Clase, String Otros,
		                      	String Proovedor, String domicilio, String telefono, DataGridView dgOrdenCompra, String subtotaltxt,
		                     	String Cantdescuento1, String Descuento1txt, String CantIva, String IVA, String subtotal2txt, String cantdescuento2, 
		                    	String descuento2txt, String Totaltxt, String TotalLetra, String Observaciones){
			PdfContentByte cb = writer.DirectContent;
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 3));
			document.Add(PDFs.LogoLeft(writer));
 			
 			float[] widthsA = new float[]{20f, 30f};
			PdfPTable Datos = new PdfPTable(2);
			Datos.SetWidths(widthsA);
			//Datos.TotalWidth = 50f;
			Datos.WidthPercentage = 25;
			Datos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			Datos.AddCell(PDFs.TitLgray114308("FOLIO:"));
			Datos.AddCell(PDFs.TexWhite112107(folio));
			Datos.AddCell(PDFs.TitLgray114308("FECHA:"));
			Datos.AddCell(PDFs.TexWhite112107(fecha));
			Datos.AddCell(PDFs.TitLgray114308("FACTURA:"));
			Datos.AddCell(PDFs.TexWhite112107(factura));
			Datos.AddCell(PDFs.TitLgray114308("Semana:"));
			Datos.AddCell(PDFs.TexWhite112107(Semana));
			Datos.AddCell(PDFs.TitLgray114308("Vencimiento:"));
			Datos.AddCell(PDFs.TexWhite112107(Vencimiento));
			document.Add(Datos);
			
			float[] widthsB = new float[]{20f, 30f, 20f, 130};
			PdfPTable Datos1 = new PdfPTable(4);
			Datos1.SetWidths(widthsB);
			Datos1.WidthPercentage = 100;
			//Datos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			Datos1.AddCell(PDFs.TitLgray114308("Cod. Prov.:"));
			Datos1.AddCell(PDFs.TexWhite111107(CodProv));
			Datos1.AddCell(PDFs.TitLgray114308("Proovedor"));
			Datos1.AddCell(PDFs.TexWhite111107(Proovedor));
			Datos1.AddCell(PDFs.TitLgray114308("Clase"));
			Datos1.AddCell(PDFs.TexWhite111107(Clase));
			Datos1.AddCell(PDFs.TitLgray114308("Domicilio"));
			Datos1.AddCell(PDFs.TexWhite111107(domicilio));
			Datos1.AddCell(PDFs.TitLgray114308("Otros"));
			Datos1.AddCell(PDFs.TexWhite111107(Otros));
			Datos1.AddCell(PDFs.TitLgray114308("Teléfono"));
			Datos1.AddCell(PDFs.TexWhite111107(telefono));
			document.Add(Datos1);
			
 			document.Add(new Paragraph(espacio));
 			
 			//Tabla Principal
			float[] widths4 = new float[] {300f};
			PdfPTable tableC = new PdfPTable(1);
			tableC.SetWidths(widths4);
			tableC.TotalWidth = 470f;
			tableC.WidthPercentage = 100;
			//PdfPCell header = new PdfPCell(PDFs.TitGray11530802("RESULTADOS"));
			
//			header.Colspan = 2;
//			tableC.AddCell(header);
 			
 			float[] widthsC = new float[] {10f, 15f, 250f, 20f, 20f, 20f};
			PdfPTable nested = new PdfPTable(6);
			nested.SetWidths(widthsC);
			nested.WidthPercentage = 100;
			nested.AddCell(PDFs.TitLgray115308("#"));
			nested.AddCell(PDFs.TitLgray115308("Cant"));
			nested.AddCell(PDFs.TitLgray115308("Concepto"));
			nested.AddCell(PDFs.TitLgray115308("Carro"));
			nested.AddCell(PDFs.TitLgray115308("P. Unit"));
			nested.AddCell(PDFs.TitLgray115308("Subtotal"));
			for(int y = 0; y<dgOrdenCompra.RowCount; y++)
			{
				nested.AddCell(PDFs.TexWhite112107((y+1).ToString()));
				nested.AddCell(PDFs.TexWhite112107(dgOrdenCompra.Rows[y].Cells[2].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dgOrdenCompra.Rows[y].Cells[3].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dgOrdenCompra.Rows[y].Cells[4].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dgOrdenCompra.Rows[y].Cells[5].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dgOrdenCompra.Rows[y].Cells[6].Value.ToString()));
			}
			
			PdfPCell nesthousing = new PdfPCell(PDFs.Tamaño2(nested));
			nesthousing.Padding = 0f;
			tableC.AddCell(nesthousing);
			
			document.Add(tableC);
			
			float[] widthsD = new float[]{20f, 20f};
			PdfPTable subtotal = new PdfPTable(2);
			subtotal.SetWidths(widthsD);
			//Datos.TotalWidth = 50f;
			subtotal.WidthPercentage = 12;
			subtotal.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			subtotal.AddCell(PDFs.TitLgray1143081("Subtotal:"));
			subtotal.AddCell(PDFs.TexWhite112107(subtotaltxt));
			document.Add(subtotal);
			
			float[] widthsE = new float[]{80f, 13f, 13f, 13f};
			PdfPTable Descuento1 = new PdfPTable(4);
			Descuento1.SetWidths(widthsE);
			//Datos.TotalWidth = 50f;
			Descuento1.WidthPercentage = 55;
			Descuento1.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			Descuento1.AddCell(PDFs.TitLgray1143081("Descuento:"));
			Descuento1.AddCell(PDFs.TexWhite112107(Cantdescuento1));
			Descuento1.AddCell(PDFs.TitLgray1143081("Desc:"));
			Descuento1.AddCell(PDFs.TexWhite112107(Descuento1txt));
			Descuento1.AddCell(PDFs.TitLgray1143081("IVA:"));
			Descuento1.AddCell(PDFs.TexWhite112107(CantIva));
			Descuento1.AddCell(PDFs.TitLgray1143081("IVA"));
			Descuento1.AddCell(PDFs.TexWhite112107(IVA));
			document.Add(Descuento1);
			
			float[] widthsF = new float[]{20f, 20f};
			PdfPTable subtotal2 = new PdfPTable(2);
			subtotal2.SetWidths(widthsF);
			//Datos.TotalWidth = 50f;
			subtotal2.WidthPercentage = 12;
			subtotal2.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			subtotal2.AddCell(PDFs.TitLgray1143081("Subtotal2:"));
			subtotal2.AddCell(PDFs.TexWhite112107(subtotal2txt));
			document.Add(subtotal2);
			
			float[] widthsG = new float[]{80f, 13f, 13f, 13f};
			PdfPTable Descuento2 = new PdfPTable(4);
			Descuento2.SetWidths(widthsG);
			//Datos.TotalWidth = 50f;
			Descuento2.WidthPercentage = 55;
			Descuento2.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			Descuento2.AddCell(PDFs.TitLgray1143081("Descuento2:"));
			Descuento2.AddCell(PDFs.TexWhite112107(cantdescuento2));
			Descuento2.AddCell(PDFs.TitLgray1143081("Desc:"));
			Descuento2.AddCell(PDFs.TexWhite112107(descuento2txt));
			document.Add(Descuento2);
			
			float[] widthsH = new float[]{20f, 20f};
			PdfPTable Total = new PdfPTable(2);
			Total.SetWidths(widthsH);
			//Datos.TotalWidth = 50f;
			Total.WidthPercentage = 12;
			Total.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			Total.AddCell(PDFs.TitLgray1143081("Total:"));
			Total.AddCell(PDFs.TexWhite112107(Totaltxt));
			document.Add(Total);
			
			float[] widthsI = new float[]{35f, 360f};
			PdfPTable LastLine = new PdfPTable(2);
			LastLine.SetWidths(widthsI);
			//Datos.TotalWidth = 50f;
			LastLine.WidthPercentage = 100;
			//Total.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			LastLine.AddCell(PDFs.TitLgray1143081("Cant. con Letra:"));
			LastLine.AddCell(PDFs.TexWhite112107(TotalLetra));
			LastLine.AddCell(PDFs.TitLgray1143081("Observaciones:"));
			LastLine.AddCell(PDFs.TexWhite112107(Observaciones));
			document.Add(LastLine);
		}
		#endregion
		
		#region NOMINA
		public void FormatoNomina(Interfaz.FormPrincipal principal, Document document, PdfWriter writer, System.IO.MemoryStream ms, 
		                          PictureBox ptbImagen, String DiaNomina1, String DiaNomina2, String FechaInicio, String FechaCorte, 
		                          String Nombre, String Alias, String Unidad, DataGridView dtConteo, double sueldoViajes, 
		                          double sueldoViajesE, double sueldoViajesG, double sueldoRecono, double sumapoyos, 
		                          double sueldoCanc, double sueldoPRendimiento, double subtotalviajesneto, double imss, 
		                          double infonavit, double isr, double telcel, double extra1, double bonos, double valorBonoEx, 
		                          double valorBonoEs, TextBox txtApoyoCoord, double totalpercepciones, double anticipos, 
		                          double impuestos, double total, String Celular, String Ingreso, String Estatal, 
		                          String Federal, double AcumuladorViajes, DataGridView dataDatos, DataGridView dataPrestamos, 
		                          DataGridView dataMatriz, TextBox txtEnvio, DataGridView dataChoque, 
		                          DataGridView dataTaxis, DataGridView dataBono, double DescuentoPeriodo, double DescuentoPrestamo, 
		                          double AcumuladorBonos, int AcumuladorTaller, int AcumuladorDormida, int AcumuladorPermiso, 
		                          DataGridView dataIngresosExtras, double totalIngresos, double Tickets, double prestamoRestante, 
		                          String foraneo, double pagare, double AcumuladorSencillos, double AcumuladorCompletos, String tipoUnidad,
		                          TextBox txtPrestamoAdicional, TextBox txtEfectivo, TextBox txtCheque)
		{
			//Variables
			PdfContentByte cb = writer.DirectContent;
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 3));
			iTextSharp.text.Image foto2 = iTextSharp.text.Image.GetInstance(@"../debug/Nomina.jpg");
			document.Add(PDFs.Logo(writer));
			
			//Imagen
			if(ms!=null)
				foto2 = iTextSharp.text.Image.GetInstance(ptbImagen.Image, System.Drawing.Imaging.ImageFormat.Jpeg); 		
 			
 			/*Barcode39 bar = new Barcode39();
 			bar.Code = 
 			Image barCode = bar.CreateImageWithBarcode(cb, null, null);		
 			barCode.SetAbsolutePosition(240,740);
 			document.Add(barCode);*/
 			
 			//Tabla Contenedora de Datos Operador
			float[] widths = new float[] {100f};
			PdfPTable tableContenedorDatosOP = new PdfPTable(1);
			tableContenedorDatosOP.SetWidths(widths);
			tableContenedorDatosOP.TotalWidth = 100f;
			tableContenedorDatosOP.WidthPercentage = 37;
			tableContenedorDatosOP.HorizontalAlignment = 2;
			//PdfPCell header2 = new PdfPCell(PDFs.TitGray115308("DATOS"));		
			PdfPCell header2 = new PdfPCell(PDFs.TitGray11530802("DATOS"));				
			header2.Colspan = 2;
			tableContenedorDatosOP.AddCell(header2);
 			document.Add(tableContenedorDatosOP);
 			
 			//Tabla de Datos del Operador
 			float[] widthsD = new float[]{20f, 80f};
			PdfPTable Datos = new PdfPTable(2);
			Datos.SetWidths(widthsD);
			Datos.WidthPercentage = 37;
			Datos.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			Datos.AddCell(PDFs.TitLgray114308("Fecha:"));
			Datos.AddCell(PDFs.TexWhite111107((DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte).ToUpper()));
			Datos.AddCell(PDFs.TitLgray114308("Nombre:"));
			Datos.AddCell(PDFs.TexWhite111107(Nombre.ToUpper()));
			document.Add(Datos);
			
			float[] widthsD2 = new float[]{20f, 30f, 20f, 30f};
			PdfPTable Datos2 = new PdfPTable(4);
			Datos2.SetWidths(widthsD2);
			Datos2.WidthPercentage = 37;
			Datos2.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			Datos2.AddCell(PDFs.TitLgray114308("Nick:"));
			Datos2.AddCell(PDFs.TexWhite111107(Alias));
			Datos2.AddCell(PDFs.TitLgray114308("Carro:"));
			Datos2.AddCell(PDFs.TexWhite111107(Unidad));
			document.Add(Datos2);
			document.Add(new Paragraph(espacio));
			document.Add(new Paragraph(espacio));
			
			//Tabla Principal
			float[] widths4 = new float[] {300f, 170f};
			PdfPTable tableC = new PdfPTable(2);
			tableC.SetWidths(widths4);
			tableC.TotalWidth = 470f;
			tableC.WidthPercentage = 100;
			//PdfPCell header = new PdfPCell(PDFs.TitGray115308("RESULTADOS"));
			PdfPCell header = new PdfPCell(PDFs.TitGray11530802("RESULTADOS"));
			
			header.Colspan = 2;
			tableC.AddCell(header);
			
			//Tabla Pricipal de viajes
			float[] widths5 = new float[] {235f, 11f, 11f, 11f, 32f};
			PdfPTable nested = new PdfPTable(5);
			nested.SetWidths(widths5);
			nested.AddCell(PDFs.TitLgray115308("Viajes por Empresas"));
			nested.AddCell(PDFs.TitLgray115308("S"));
			nested.AddCell(PDFs.TitLgray115308("C"));
			nested.AddCell(PDFs.TitLgray115308("#"));
			nested.AddCell(PDFs.TitLgray115308("$"));
			for(int y = 0; y<(dtConteo.RowCount); y++)
			{
				nested.AddCell(PDFs.TexWhite111107(dtConteo.Rows[y].Cells[0].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dtConteo.Rows[y].Cells[1].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dtConteo.Rows[y].Cells[2].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dtConteo.Rows[y].Cells[3].Value.ToString()));
				nested.AddCell(PDFs.TexWhite111107(Convert.ToDouble(dtConteo.Rows[y].Cells[4].Value).ToString("C")));
			}
			PdfPCell nesthousing = new PdfPCell(PDFs.Tamaño(nested));
			nesthousing.Padding = 0f;
			tableC.AddCell(nesthousing);
			
			//Tabla parte baja total viajes
			float[] widthsViajes = new float[] {235f, 11f, 11f, 11f, 32f};
			PdfPTable TotalViajes = new PdfPTable(5);
			TotalViajes.SetWidths( widthsViajes);
			TotalViajes.TotalWidth = 300f;
			TotalViajes.WidthPercentage = 63.82f;
			TotalViajes.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			TotalViajes.AddCell(PDFs.TitLgray114308("Total de viajes:"));
			TotalViajes.AddCell(PDFs.TitLgray115308(AcumuladorSencillos.ToString()));
			TotalViajes.AddCell(PDFs.TitLgray115308(AcumuladorCompletos.ToString()));
			TotalViajes.AddCell(PDFs.TitLgray115308(AcumuladorViajes.ToString()));
			TotalViajes.AddCell(PDFs.TitLgray114308(subtotalviajesneto.ToString("C")));
			
			//Tabla Bonos
			float[] widthsBonos = new float[] {75f, 25f};
			PdfPTable Bonos = new PdfPTable(2);
			Bonos.SetWidths(widthsBonos);
			Bonos.AddCell(PDFs.TitLgray114308("Ingresos"));
			Bonos.AddCell(PDFs.TitLgray115308("Importe"));
			Bonos.AddCell(PDFs.TexWhite111107("Bono Normal"));
			Bonos.AddCell(PDFs.TexWhite112107(bonos.ToString("C")));
			if(valorBonoEx>0)
			{
				Bonos.AddCell(PDFs.TexWhite111107("Bono Extra"));
				Bonos.AddCell(PDFs.TexWhite112107(valorBonoEx.ToString("C")));
			}
			if(valorBonoEs>0)
			{
				Bonos.AddCell(PDFs.TexWhite111107("Bono Especial"));
				Bonos.AddCell(PDFs.TexWhite112107(valorBonoEs.ToString("C")));
			}
			if(Convert.ToDouble(txtApoyoCoord.Text)>0)
			{
				Bonos.AddCell(PDFs.TexWhite111107("Apoyo Coordinación"));
				Bonos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(txtApoyoCoord.Text)).ToString("C")));
			}
			for(int y = 0; y<(dataIngresosExtras.RowCount); y++)
			{
				Bonos.AddCell(PDFs.TexWhite111107(dataIngresosExtras.Rows[y].Cells[1].Value.ToString()));
				Bonos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(dataIngresosExtras.Rows[y].Cells[2].Value)).ToString("C")));
			}

			float[] widthsTotalIngreso = new float[] {75.5f, 24.5f};
			PdfPTable TotalIngreso = new PdfPTable(2);
			TotalIngreso.SetWidths(widthsTotalIngreso);
			TotalIngreso.AddCell(PDFs.TitWhite114308("Total Otros Ingresos"));
			TotalIngreso.AddCell(PDFs.TitWhite114308((Convert.ToDouble(totalIngresos+bonos+valorBonoEs+valorBonoEx+Convert.ToDouble(txtApoyoCoord.Text))).ToString("C")));
			TotalIngreso.AddCell(PDFs.TitWhite114308("Total viajes"));
			TotalIngreso.AddCell(PDFs.TitWhite114308((Convert.ToDouble(subtotalviajesneto)).ToString("C")));
			TotalIngreso.AddCell(PDFs.TitLgray114308("Total percepcciones sin ajuste"));
			TotalIngreso.AddCell(PDFs.TitLgray114308((Convert.ToDouble(totalIngresos+totalpercepciones)).ToString("C")));
			TotalIngreso.AddCell(PDFs.TitWhite114308("Ajuste Nominal"));
			TotalIngreso.AddCell(PDFs.TitWhite114308(extra1.ToString("C")));
			TotalIngreso.AddCell(PDFs.TitLgray114308("Total viajes, ingresos y ajustes"));
			TotalIngreso.AddCell(PDFs.TitLgray114308((Convert.ToDouble(totalIngresos+extra1+totalpercepciones)).ToString("C")));
			
			//Contenedor Panel Pricipal Derecho
			PdfPTable ContenedorPrincipal = new PdfPTable(1);
			ContenedorPrincipal.AddCell(PDFs.Tamaño(Bonos));
			ContenedorPrincipal.AddCell(TotalIngreso);
			tableC.AddCell(ContenedorPrincipal);
			document.Add(tableC);
			document.Add(TotalViajes);
			
			//Tablas y contenedor Datos, Foto
			PdfPCell headerImprimir = new PdfPCell(PDFs.TitGray11530802("IMPRESIÓN"));
			//PdfPCell headerImprimir = new PdfPCell(PDFs.TitGray115308("IMPRESIÓN"));
			headerImprimir.Colspan = 2;
			float[] widthsReviso = new float[] {41f, 59f};
			PdfPTable Reviso = new PdfPTable(2);
			Reviso.SetWidths(widthsReviso);
			Reviso.AddCell(headerImprimir);
			Reviso.AddCell(PDFs.TitLgray114308("Reviso:"));
			Reviso.AddCell(PDFs.TexWhite112107(principal.lblDatoUsuario.Text));
			Reviso.AddCell(PDFs.TitLgray114308("Fecha:"));
			Reviso.AddCell(PDFs.TexWhite112107(DateTime.Now.ToString("dd-MM-yyyy")));
			Reviso.AddCell(PDFs.TitLgray114308("Hora:"));
			Reviso.AddCell(PDFs.TexWhite112107(principal.HoraUniversal()));
			
			// Tabla descuentos del periodo
			PdfPTable tableEncDescuentos = new PdfPTable(1);
			tableEncDescuentos.TotalWidth = 100f;
			tableEncDescuentos.WidthPercentage = 45;
			tableEncDescuentos.HorizontalAlignment = 0;
			PdfPCell headerDescuentos = new PdfPCell(PDFs.TitGray11530802("DESCUENTOS DEL PERIODO"));
			//PdfPCell headerDescuentos = new PdfPCell(PDFs.TitGray115308("DESCUENTOS DEL PERIODO"));
			
			headerDescuentos.Colspan = 1;
			tableEncDescuentos.AddCell(headerDescuentos);
			float[] widthsAnticipos = new float[] {35f, 30f, 30f, 95f, 45f};
			PdfPTable TbAnticipos = new PdfPTable(5);
			TbAnticipos.SetWidths(widthsAnticipos);
			TbAnticipos.AddCell(PDFs.TitLgray115308("Fecha"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Tipo"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Pago"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Detalle"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Descuento"));
			for(int y = 0; y<(dataDatos.RowCount); y++)
			{
				TbAnticipos.AddCell(PDFs.TexWhite112107(dataDatos.Rows[y].Cells[1].Value.ToString()));
					if(dataDatos.Rows[y].Cells[2].Value!=null && dataDatos.Rows[y].Cells[2].Value.ToString()!="")
						TbAnticipos.AddCell(PDFs.TexWhite112107(dataDatos.Rows[y].Cells[2].Value.ToString()));
					else
						TbAnticipos.AddCell(PDFs.TexWhite112107("---"));
				TbAnticipos.AddCell(PDFs.TexWhite112107(dataDatos.Rows[y].Cells[3].Value.ToString()));
				TbAnticipos.AddCell(PDFs.TexWhite111107(dataDatos.Rows[y].Cells[4].Value.ToString()));
				TbAnticipos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(dataDatos.Rows[y].Cells[5].Value)).ToString("C")));
			}
			if(dataDatos.RowCount==0)
			{
				TbAnticipos.AddCell(PDFs.TexWhite112107(""));
				TbAnticipos.AddCell(PDFs.TexWhite111107(""));
				TbAnticipos.AddCell(PDFs.TexWhite112107(""));
				TbAnticipos.AddCell(PDFs.TexWhite112107(""));
				TbAnticipos.AddCell(PDFs.TexWhite112107(""));
			}
			tableEncDescuentos.AddCell(PDFs.Tamaño(TbAnticipos));
			
			//Tabla de Prestamos
			PdfPTable tablePrestamos = new PdfPTable(1);
			tablePrestamos.TotalWidth = 100f;
			tablePrestamos.WidthPercentage = 45;
			tablePrestamos.HorizontalAlignment = 0;
			//PdfPCell headerPrestamos = new PdfPCell(PDFs.TitGray115308("PRESTAMOS"));
			PdfPCell headerPrestamos = new PdfPCell(PDFs.TitGray11530802("PRESTAMOS"));
			
			headerPrestamos.Colspan = 1;
			tablePrestamos.AddCell(headerPrestamos);
			float[] widthsAnticiposPrestamos = new float[]  {35f, 30f, 100f, 30f, 40f};
			PdfPTable TbAnticiposPrestamos = new PdfPTable(5);
			TbAnticiposPrestamos.SetWidths(widthsAnticiposPrestamos);
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("Fecha"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("Tipo"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("Detalle"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("Resta"));
			TbAnticiposPrestamos.AddCell(PDFs.TitLgray115308("Descuento"));
			for(int y = 0; y<(dataPrestamos.RowCount); y++)
			{
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(dataPrestamos.Rows[y].Cells[1].Value.ToString()));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(dataPrestamos.Rows[y].Cells[2].Value.ToString()));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(dataPrestamos.Rows[y].Cells[3].Value.ToString()));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(dataPrestamos.Rows[y].Cells[4].Value)).ToString("C")));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(dataPrestamos.Rows[y].Cells[5].Value)).ToString("C")));
			}
			if(dataPrestamos.RowCount==0)
			{
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(""));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite111107(""));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(""));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(""));
				TbAnticiposPrestamos.AddCell(PDFs.TexWhite112107(""));
			}
			tablePrestamos.AddCell(PDFs.Tamaño(TbAnticiposPrestamos));
			
			//Contenedor Descuentos
			float[] widthsDescuentos = new float[] {235f, 235f};
			PdfPTable TbDescuentos = new PdfPTable(2);
			TbDescuentos.SetWidths(widthsDescuentos);
			TbDescuentos.TotalWidth = 470f;
			TbDescuentos.WidthPercentage = 100;
			TbDescuentos.AddCell(tableEncDescuentos);
			TbDescuentos.AddCell(tablePrestamos);
			
			//Parte Baja Descuentos
			float[] widthsTotalDescuentos = new float[] {189f, 46f, 194f, 41f};
			PdfPTable TotalDescuentos = new PdfPTable(4);
			TotalDescuentos.SetWidths(widthsTotalDescuentos);
			TotalDescuentos.TotalWidth = 470f;
			TotalDescuentos.WidthPercentage = 100f;
			TotalDescuentos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			TotalDescuentos.AddCell(PDFs.TitWhite114308("Tickets de casetas recabados:"));
			TotalDescuentos.AddCell(PDFs.TitWhite114308(Tickets.ToString("C")));
			TotalDescuentos.AddCell(PDFs.TitWhite114308("Importe Restante:"));
			TotalDescuentos.AddCell(PDFs.TitWhite114308(prestamoRestante.ToString("C")));
			TotalDescuentos.AddCell(PDFs.TitLgray114308("Total descuento periodo:"));
			TotalDescuentos.AddCell(PDFs.TitLgray114308(DescuentoPeriodo.ToString("C")));
			TotalDescuentos.AddCell(PDFs.TitLgray114308("Total de Prestamos:"));
			TotalDescuentos.AddCell(PDFs.TitLgray114308(DescuentoPrestamo.ToString("C")));
			
			//Eliminado Temporalmente
			float[] widthsTotalizado = new float[] {194f, 41f};
			PdfPTable Totalizado = new PdfPTable(2);
			Totalizado.SetWidths(widthsTotalizado);
			Totalizado.TotalWidth = 235f;
			Totalizado.WidthPercentage = 50f;
			Totalizado.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
			
			//Agrega al documento Tablas Descuentos
			document.Add(new Paragraph(espacio));
			document.Add(new Paragraph(espacio));
			document.Add(TbDescuentos);
			document.Add(TotalDescuentos);
			document.Add(Totalizado);
			document.Add(new Paragraph(espacio));
			document.Add(new Paragraph(espacio));
			
			//TABLA Taxis
			
			PdfPCell headerTaxi = new PdfPCell(PDFs.TitGray11530802("CONTROL DE TAXIS A 6 MESES"));
			//PdfPCell headerTaxi = new PdfPCell(PDFs.TitGray115308("CONTROL DE TAXIS A 6 MESES"));
			headerTaxi.Colspan = 5;
			float[] widthsTaxi = new float[] {16f, 4f, 43f, 19f, 18f};
			PdfPTable TbTaxi = new PdfPTable(5);
			TbTaxi.SetWidths(widthsTaxi);
			TbTaxi.AddCell(headerTaxi);
			TbTaxi.AddCell(PDFs.TitLgray115308("Fecha"));
			TbTaxi.AddCell(PDFs.TitLgray115308("T"));
			TbTaxi.AddCell(PDFs.TitLgray115308("Empresa"));
			TbTaxi.AddCell(PDFs.TitLgray115308("Total $"));
			TbTaxi.AddCell(PDFs.TitLgray115308("Desc. $"));
			for(int y = 0; y<(dataTaxis.RowCount); y++)
				{
					TbTaxi.AddCell(PDFs.TexWhite115105(dataTaxis.Rows[y].Cells[0].Value.ToString()));
					TbTaxi.AddCell(PDFs.TexWhite115105(dataTaxis.Rows[y].Cells[1].Value.ToString()));
					TbTaxi.AddCell(PDFs.TexWhite115105(dataTaxis.Rows[y].Cells[2].Value.ToString()));
					TbTaxi.AddCell(PDFs.TexWhite115105((Convert.ToDouble(dataTaxis.Rows[y].Cells[3].Value)).ToString("C")));
					TbTaxi.AddCell(PDFs.TexWhite115105((Convert.ToDouble(dataTaxis.Rows[y].Cells[4].Value)).ToString("C")));
				}
				if(dataTaxis.RowCount==0)
				{
					TbTaxi.AddCell("");
					TbTaxi.AddCell("");
					TbTaxi.AddCell("");
					TbTaxi.AddCell("");
					TbTaxi.AddCell("");
				}
			
			//TABLA Choques
			
			//PdfPCell headerchoque = new PdfPCell(PDFs.TitGray115308("CONTROL DE CHOQUES A 6 MESES"));
			PdfPCell headerchoque = new PdfPCell(PDFs.TitGray11530802("CONTROL DE CHOQUES A 6 MESES"));
			headerchoque.Colspan = 3;
			float[] widthsChoque = new float[] {16f, 65f, 19f};
			PdfPTable TbChoque = new PdfPTable(3);
			TbChoque.SetWidths(widthsChoque);
			TbChoque.AddCell(headerchoque);
			TbChoque.AddCell(PDFs.TitLgray115308("Fecha"));
			TbChoque.AddCell(PDFs.TitLgray115308("Detalle"));
			TbChoque.AddCell(PDFs.TitLgray115308("Desc. $"));
			for(int y = 0; y<(dataChoque.RowCount); y++)
			{
				TbChoque.AddCell(PDFs.TexWhite115105(dataChoque.Rows[y].Cells[0].Value.ToString()));
				TbChoque.AddCell(PDFs.TexWhite115105(dataChoque.Rows[y].Cells[1].Value.ToString()));
				TbChoque.AddCell(PDFs.TexWhite115105((Convert.ToDouble(dataChoque.Rows[y].Cells[2].Value)).ToString("C")));
			}
			
			if(dataChoque.RowCount==0)
			{
				TbChoque.AddCell("");
				TbChoque.AddCell("");
				TbChoque.AddCell("");
			}
			
			//Tabla Acotaciones
			//PdfPCell headerAcotaciones = new PdfPCell(PDFs.TitGray115308("ACOTACIONES"));
			PdfPCell headerAcotaciones = new PdfPCell(PDFs.TitGray11530802("ACOTACIONES"));
			headerAcotaciones.Colspan = 2;
			float[] widthsAcotaciones = new float[] {40f, 10f};
			PdfPTable Acotaciones = new PdfPTable(2);
			Acotaciones.SetWidths(widthsAcotaciones);
			Acotaciones.AddCell(headerAcotaciones);
			Acotaciones.AddCell(PDFs.TexWhite114105("Apoyo:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("A"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Bonificación del Bono:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("B"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Cancelación en el punto:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("CP"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Completo:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("C"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Guardía:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("G"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Perdida de Bono:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("P"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Prueba de Rendimiento:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("PR"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Reconocimiento de Ruta:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("R"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Sencillo:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("S"));
			Acotaciones.AddCell(PDFs.TexWhite114105("Turno:"));
			Acotaciones.AddCell(PDFs.TexWhite115105("T"));
			
			//Contenedor FOTO
			PdfPCell headerFoto = new PdfPCell(PDFs.TitGray115308(Unidad+" "+Alias));
			headerFoto.Colspan = 1;
			PdfPTable Foto = new PdfPTable(1);
			foto2.Border = iTextSharp.text.Rectangle.ALIGN_MIDDLE;
			foto2.ScaleAbsoluteHeight(90f);
			foto2.ScaleAbsoluteWidth(68f);
			Foto.AddCell(headerFoto);
			Foto.AddCell(PDFs.TitWhite115308(tipoUnidad));
			Foto.AddCell(PDFs.FotoNomina(foto2));
			float[] widthsDatosEs = new float[] {41f, 59f};
			PdfPTable DatosEs = new PdfPTable(2);
			DatosEs.SetWidths(widthsDatosEs);
			DatosEs.AddCell(PDFs.TitLgray114308("Cel:"));
			DatosEs.AddCell(PDFs.TexWhite112107(Celular));
			DatosEs.AddCell(PDFs.TitLgray114308("Ingreso:"));
			DatosEs.AddCell(PDFs.TexWhite112107(Ingreso));
			DatosEs.AddCell(PDFs.TitLgray114308("Estatal:"));
			DatosEs.AddCell(PDFs.TexWhite112107(Estatal));
			DatosEs.AddCell(PDFs.TitLgray114308("Federal:"));
			DatosEs.AddCell(PDFs.TexWhite112107(Federal));
			
			PdfPTable ContenedorDatosFoto = new PdfPTable(1);
			ContenedorDatosFoto.AddCell(Reviso);
			ContenedorDatosFoto.AddCell("");
			
			PdfPTable ContenedorDatosFoto2 = new PdfPTable(1);
			ContenedorDatosFoto2.AddCell(Foto);
			ContenedorDatosFoto2.AddCell(DatosEs);
			if(foraneo=="1")
				ContenedorDatosFoto2.AddCell(PDFs.LocalizacionOperador("Foráneo"));
			else
				ContenedorDatosFoto2.AddCell(PDFs.LocalizacionOperador("Local"));
			//ContenedorDatosFoto2.AddCell(barCode);
			
			//Tabla Impuestos
			
			//PdfPCell headerImpuestos = new PdfPCell(PDFs.TitGray115308("IMPUESTOS"));
			PdfPCell headerImpuestos = new PdfPCell(PDFs.TitGray11530802("IMPUESTOS"));
			headerImpuestos.Colspan = 2;
			float[] widthsDeducciones = new float[] {70f, 30f};
			PdfPTable TbDeducciones = new PdfPTable(2);
			TbDeducciones.SetWidths(widthsDeducciones);
			TbDeducciones.AddCell(headerImpuestos);
			TbDeducciones.AddCell(PDFs.TitLgray114308("Detalle"));
			TbDeducciones.AddCell(PDFs.TitLgray115308("Importe"));
			TbDeducciones.AddCell(PDFs.TexWhite111107("IMSS"));
			TbDeducciones.AddCell(PDFs.TexWhite111107(imss.ToString("C")));
			TbDeducciones.AddCell(PDFs.TexWhite111107("INFONAVIT"));
			TbDeducciones.AddCell(PDFs.TexWhite111107(infonavit.ToString("C")));
			TbDeducciones.AddCell(PDFs.TexWhite111107("ISR"));
			TbDeducciones.AddCell(PDFs.TexWhite111107(isr.ToString("C")));
			TbDeducciones.AddCell(PDFs.TitLgray114308("Total Impuestos"));
			TbDeducciones.AddCell(PDFs.TitLgray114308(impuestos.ToString("C")));
			
			//Tabla de Totales
			
			//PdfPCell headerTotales = new PdfPCell(PDFs.TitGray115308("RESUMEN DE TOTALES"));
			PdfPCell headerTotales = new PdfPCell(PDFs.TitGray11530802("RESUMEN DE TOTALES"));
			headerTotales.Colspan = 2;
			float[] widthsTotales = new float[] {70f, 30f};
			PdfPTable TbTotales = new PdfPTable(2);
			TbTotales.SetWidths(widthsTotales);
			TbTotales.AddCell(headerTotales);
			TbTotales.AddCell(PDFs.TitLgray114308("Detalle"));
			TbTotales.AddCell(PDFs.TitLgray115308("Importe"));
			
			TbTotales.AddCell(PDFs.TitWhite11430802("Percepciones y Ajustes"));
			//TbTotales.AddCell(PDFs.TitWhite114308("Percepciones y Ajustes"));
			TbTotales.AddCell(PDFs.TitWhite114308((Convert.ToDouble(totalpercepciones+totalIngresos+extra1)).ToString("C")));
			TbTotales.AddCell(PDFs.TitWhite11430802("Descuentos y Prestamos"));
			//TbTotales.AddCell(PDFs.TitWhite114308("Descuentos y Prestamos"));
			TbTotales.AddCell(PDFs.TitWhite114308(((DescuentoPrestamo+DescuentoPeriodo)*-1).ToString("C")));
			TbTotales.AddCell(PDFs.TitWhite11430802("Impuestos"));
			//TbTotales.AddCell(PDFs.TitWhite114308("Impuestos"));
			TbTotales.AddCell(PDFs.TitWhite114308((Convert.ToDouble(impuestos)*-1).ToString("C")));
			TbTotales.AddCell(PDFs.TitWhite11430802("Préstamo Adicional"));
			//TbTotales.AddCell(PDFs.TitWhite114308("Préstamo Adicional"));
			TbTotales.AddCell(PDFs.TitWhite114308((Convert.ToDouble(txtPrestamoAdicional.Text)).ToString("C")));
			TbTotales.AddCell(PDFs.TitLgray114308("Sueldo Total"));
			TbTotales.AddCell(PDFs.TitLgray114308(Math.Round(total).ToString("C")));
			
			//TbTotales.AddCell(PDFs.TitWhite114308("Importe por liquidar"));
			TbTotales.AddCell(PDFs.TitWhite11430802("Importe por liquidar"));
			TbTotales.AddCell(PDFs.TitWhite114308("$0.00"));
			//Tabla de forma de Pagos
			
			PdfPCell headerPago = new PdfPCell(PDFs.TitGray11530802("FORMA DE PAGO"));
			//PdfPCell headerPago = new PdfPCell(PDFs.TitGray115308("FORMA DE PAGO"));
			headerPago.Colspan = 2;
			float[] widthsPago = new float[] {70f, 30f};
			PdfPTable TbPago = new PdfPTable(2);
			TbPago.SetWidths(widthsPago);
			TbPago.AddCell(headerPago);
			
			//TbPago.AddCell(PDFs.TitLgray115308("Cheque"));
			TbPago.AddCell(PDFs.TitLgray11530802("Cheque"));
			TbPago.AddCell(PDFs.TexWhite111107(Math.Round(Convert.ToDouble(txtCheque.Text)).ToString("C")));
			//TbPago.AddCell(PDFs.TitLgray115308("Efectivo"));
			TbPago.AddCell(PDFs.TitLgray11530802("Efectivo"));
			TbPago.AddCell(PDFs.TexWhite111107(Math.Round(Convert.ToDouble(txtEfectivo.Text)).ToString("C")));
			//TbPago.AddCell(PDFs.TitLgray115308("Pagaré"));
			TbPago.AddCell(PDFs.TitLgray11530802("Pagaré"));
			TbPago.AddCell(PDFs.TexWhite111107(pagare.ToString("C")));
			//TbPago.AddCell(PDFs.TitLgray115308("Envió"));
			TbPago.AddCell(PDFs.TitLgray11530802("Envió"));
			TbPago.AddCell(PDFs.TexWhite112107(txtEnvio.Text));
			
			//TABLA CAUSAS PERDIDA DE BONO
			
			//PdfPCell headerPerdida = new PdfPCell(PDFs.TitGray115308("CAUSAS DE PERDIDA DE BONO"));
			PdfPCell headerPerdida = new PdfPCell(PDFs.TitGray11530802("CAUSAS DE PERDIDA DE BONO"));
			headerPerdida.Colspan = 6;
			float[] widthsPerdida = new float[] {30f, 60f, 125f, 10f, 10f};
			PdfPTable TbPerdida = new PdfPTable(5);
			TbPerdida.SetWidths(widthsPerdida);
			TbPerdida.AddCell(headerPerdida);
			TbPerdida.AddCell(PDFs.TitLgray115308("Fecha"));
			TbPerdida.AddCell(PDFs.TitLgray115308("Detalle"));
			TbPerdida.AddCell(PDFs.TitLgray115308("Observación"));
			TbPerdida.AddCell(PDFs.TitLgray115308("P"));
			TbPerdida.AddCell(PDFs.TitLgray115308("B"));
			
			for(int y = 0; y<(dataBono.RowCount); y++)
			{
				TbPerdida.AddCell(PDFs.TexWhite115105(dataBono.Rows[y].Cells[0].Value.ToString()));
				TbPerdida.AddCell(PDFs.TexWhite115105(dataBono.Rows[y].Cells[1].Value.ToString().ToUpper()));
				TbPerdida.AddCell(PDFs.TexWhite115105(dataBono.Rows[y].Cells[2].Value.ToString().ToUpper()));
				TbPerdida.AddCell(PDFs.TexWhite115105(dataBono.Rows[y].Cells[3].Value.ToString()));
				TbPerdida.AddCell(PDFs.TexWhite115105(dataBono.Rows[y].Cells[4].Value.ToString()));
			}
			
			if(dataBono.RowCount<=0)
			{
				TbPerdida.AddCell((PDFs.TexWhite115105("-")));
				TbPerdida.AddCell((PDFs.TexWhite115105("-")));
                TbPerdida.AddCell((PDFs.TexWhite115105("-")));
                TbPerdida.AddCell((PDFs.TexWhite115105("-")));
                TbPerdida.AddCell((PDFs.TexWhite115105("-")));
			}
				
			//TABLA Matriz
			PdfPCell headerMatriz = new PdfPCell(PDFs.TitGray115308("MATRIZ DE TURNOS LABORADOS"));
			headerMatriz.Colspan = dataMatriz.RowCount;
			float[] widthsMatriz=null;
			if((dataMatriz.RowCount+1)==19)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==18)
				widthsMatriz = new float[]{3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==17)
				widthsMatriz = new float[]{3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==16)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==15)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==14)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==13)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==12)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==11)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==10)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==9)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==8)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==7)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==6)
				widthsMatriz = new float[] {3f,10f,10f,10f,10f, 25f};
			if((dataMatriz.RowCount+1)==5)
				widthsMatriz = new float[] {3f,10f,10f,10f, 25f};
			if((dataMatriz.RowCount+1)==4)
				widthsMatriz = new float[] {3f,10f,10f,25f};
			if((dataMatriz.RowCount+1)==3)
				widthsMatriz = new float[] {3f,10f,25f};
			
			PdfPTable Matriz = new PdfPTable(dataMatriz.RowCount+1);
			Matriz.SetWidths(widthsMatriz);
			Matriz.AddCell(headerMatriz);
			Matriz.AddCell(PDFs.TitLgray115308("Num."));
			Matriz.AddCell(PDFs.TitLgray115308(""));
			for(int y = 0; y<(dataMatriz.RowCount-1); y++)
			{
				if(dataMatriz.Rows[y].Cells[0].Value!=null)
					Matriz.AddCell(PDFs.TitLgray115308(dataMatriz.Rows[y].Cells[0].Value.ToString().Substring(0, 2)));
				else
					Matriz.AddCell("");	
			}
			Matriz.AddCell(PDFs.TexWhite115107(""));
			Matriz.AddCell(PDFs.TitWhite115304("VIAJE"));
			for(int y = 0; y<(dataMatriz.RowCount-1); y++)
			{
				PdfPTable Interna = new PdfPTable(2);
				Interna.AddCell(PDFs.TexWhite115105("1"));
				if(dataMatriz.Rows[y].Cells[1].Value!=null || dataMatriz.Rows[y].Cells[2].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("2"));
				if(dataMatriz.Rows[y].Cells[5].Value!=null || dataMatriz.Rows[y].Cells[6].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("3"));
				if(dataMatriz.Rows[y].Cells[9].Value!=null || dataMatriz.Rows[y].Cells[10].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("4"));
				if(dataMatriz.Rows[y].Cells[13].Value!=null || dataMatriz.Rows[y].Cells[14].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
					Matriz.AddCell(Interna);			
			}
			Matriz.AddCell(PDFs.TexWhite115107(AcumuladorBonos.ToString()));
			int f = 0;
			while(f<dataMatriz.RowCount+1)
			{
			Matriz.AddCell(PDFs.SeparadorTableGris3("-"));
			++f;
			}
			Matriz.AddCell(PDFs.TitLgray115308(""));
			for(int y = 0; y<(dataMatriz.RowCount-1); y++)
			{
				Matriz.AddCell(PDFs.TexWhite115107(dataMatriz.Rows[y].Cells[17].Value.ToString()));
			}
			PdfPCell TbPROMR = new PdfPCell(PDFs.TexWhite115107("Prom: "+(Math.Round(AcumuladorBonos/(dataMatriz.RowCount-1),2)).ToString()));
			TbPROMR.Colspan = 1;
			Matriz.AddCell(TbPROMR);
			f=0;
			while(f<dataMatriz.RowCount+1)
			{
			Matriz.AddCell(PDFs.SeparadorTableGris3("-"));
			++f;
			}
			Matriz.AddCell(PDFs.TitWhite115304("TALLER"));
			for(int y = 0; y<(dataMatriz.RowCount-1); y++)
			{
				PdfPTable Interna = new PdfPTable(2);
				
				Interna.AddCell(PDFs.TexWhite115105("1"));
				if(dataMatriz.Rows[y].Cells[3].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("2"));
				if(dataMatriz.Rows[y].Cells[7].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("3"));
				if(dataMatriz.Rows[y].Cells[11].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("4"));
				if(dataMatriz.Rows[y].Cells[15].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
					Matriz.AddCell(Interna);
			}
			Matriz.AddCell(PDFs.TexWhite115107(AcumuladorTaller.ToString()));
			Matriz.AddCell(PDFs.TitWhite115304("DORMIDA"));
			for(int y = 0; y<(dataMatriz.RowCount-1); y++)
			{
				PdfPTable Interna = new PdfPTable(2);
				
				Interna.AddCell(PDFs.TexWhite115105("1"));
				if(dataMatriz.Rows[y].Cells[4].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("2"));
				if(dataMatriz.Rows[y].Cells[8].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("3"));
				if(dataMatriz.Rows[y].Cells[12].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("4"));
				if(dataMatriz.Rows[y].Cells[16].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
					Matriz.AddCell(Interna);
			}
			Matriz.AddCell(PDFs.TexWhite115107(AcumuladorDormida.ToString()));
			Matriz.AddCell(PDFs.TitWhite115304("PERMISO"));
			for(int y = 0; y<(dataMatriz.RowCount-1); y++)
			{
				PdfPTable Interna = new PdfPTable(2);
				
				Interna.AddCell(PDFs.TexWhite115105("1"));
				if(dataMatriz.Rows[y].Cells[2].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("2"));
				if(dataMatriz.Rows[y].Cells[6].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("3"));
				if(dataMatriz.Rows[y].Cells[10].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
				
				Interna.AddCell(PDFs.TexWhite115105("4"));
				if(dataMatriz.Rows[y].Cells[14].Value!=null)
					Interna.AddCell(PDFs.ColorMatriz(""));
				else
					Interna.AddCell("");
					Matriz.AddCell(Interna);
			}
			Matriz.AddCell(PDFs.TexWhite115107(AcumuladorPermiso.ToString()));
			
			//Contenedor Parte IZQUIERDA
			PdfPTable ContenedorHistorial = new PdfPTable(2);
			ContenedorHistorial.AddCell(TbTaxi);
			ContenedorHistorial.AddCell(TbChoque);
			//
			PdfPTable ContenedorHistorial2 = new PdfPTable(1);
			ContenedorHistorial2.AddCell(TbPerdida);
			ContenedorHistorial2.AddCell(Matriz);
			
			//Contenedor Parte Derecha
			PdfPTable ContenedorResultados = new PdfPTable(1);
			ContenedorResultados.AddCell(Acotaciones);
			ContenedorResultados.AddCell("");
			//
			PdfPTable ContenedorResultados2 = new PdfPTable(1);
			ContenedorResultados2.AddCell(TbDeducciones);
			ContenedorResultados2.AddCell(TbTotales);
			ContenedorResultados2.AddCell(TbPago);
			ContenedorResultados2.AddCell("");
			
			//Contenerdor Parte Baja
			float[] widthshistorial = new float[] {318f, 76f, 76f};
			PdfPTable TbHistorial = new PdfPTable(3);
			TbHistorial.SetWidths(widthshistorial);
			TbHistorial.TotalWidth = 470f;
			TbHistorial.WidthPercentage = 100;
			TbHistorial.AddCell(ContenedorHistorial);
			TbHistorial.AddCell(ContenedorResultados);
			TbHistorial.AddCell(ContenedorDatosFoto);
			document.Add(TbHistorial);
			document.Add(new Paragraph(espacio));
			document.Add(new Paragraph(espacio));
			
			float[] widthsPie = new float[] {235f, 159f, 76f};
			PdfPTable TbPie = new PdfPTable(3);
			TbPie.SetWidths(widthsPie);
			TbPie.TotalWidth = 470f;
			TbPie.WidthPercentage = 100;
			TbPie.AddCell(ContenedorHistorial2);
			TbPie.AddCell(ContenedorResultados2);
			TbPie.AddCell(ContenedorDatosFoto2);
			document.Add(TbPie);
		}
		#endregion
		
		#region FACTURACION
		
			#region GENERAL
			public void FormatoGeneralFacturacion(String FechaInicio, String FechaCorte, DataGridView dtTotales, TextBox txtCamionetasS, 
			                                      TextBox txtCamionetasC, TextBox txtCamionesS, TextBox txtCamionesC,
			                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                      String DiaFacturacion, DataGridView dataViajesNormales, 
			                                      DataGridView dtViajesEstandarExtras, PdfWriter writer, Interfaz.FormPrincipal principal,
			                                      DataGridView dataCONVER)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				int ContadorForsac = 0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				float[] widths = new float[] {50f, 370f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
				
				/////////////////////////////////////////////////////////////// TEVA ALMACEN ////////////////////////////////////////////////////////////////////
				float[] widthsAlmacen = new float[] {90f, 380f};
				PdfPTable tableAlmacen = new PdfPTable(2);
				tableAlmacen.SetWidths(widthsAlmacen);
				tableAlmacen.TotalWidth = 470f;
				PdfPCell headerAlmacen = new PdfPCell(PDFs.Enclgray215209("TEVA ALMACÉN"));
				headerAlmacen.Colspan = 2;
				tableAlmacen.AddCell(headerAlmacen);
				//*********************************************************************************
						
				//Datos = formFacturacion.RetornoArregloFecha();
			
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0;
				double tR=0, tV=0, sumaAlmacen=0.0, sumaTotalAlmacen = 0.0;
				int a = 0;
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {100f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
					nested.AddCell(PDFs.TitWhite115308("Fecha"));
					nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {40f, 87f, 81f, 81f, 81f, 50f};
					PdfPTable bottom = new PdfPTable(6);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115308("Horario"));
					bottom.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
					bottom.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
					bottom.AddCell(PDFs.TitWhite115308("Camiones Completos"));
					bottom.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
					bottom.AddCell(PDFs.TitWhite115308("Precio"));
					
					///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////
					float[] widths1Almacen = new float[] {80f};
					PdfPTable nestedAlmacen = new PdfPTable(1);
					nestedAlmacen.SetWidths(widths1Almacen);
		   		    nestedAlmacen.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousingAlmacen = new PdfPCell(nestedAlmacen);
					nesthousingAlmacen.Padding = 0f;
					tableAlmacen.AddCell(nesthousingAlmacen);
					
					float[] widths2Almacen = new float[] {100f, 100f};
					PdfPTable bottomAlmacen = new PdfPTable(2);
					bottomAlmacen.SetWidths(widths2Almacen);
					bottomAlmacen.AddCell(PDFs.TitWhite115308("Horario"));
					bottomAlmacen.AddCell(PDFs.TitWhite115308("Almacén"));
					// ****************************************************************************************************
						
						for(int y = 0; y<(dtTotales.RowCount); y++)
						{
							if(Datos[contadorArray]==dtTotales.Rows[y].Cells[1].Value.ToString())
							{
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[2].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[3].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[4].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[5].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[6].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[11].Value));
								
								Cc += Convert.ToDouble(dtTotales.Rows[y].Cells[7].Value);
								Cs += Convert.ToDouble(dtTotales.Rows[y].Cells[8].Value);
								Tc += Convert.ToDouble(dtTotales.Rows[y].Cells[9].Value);
								Ts += Convert.ToDouble(dtTotales.Rows[y].Cells[10].Value);
								a += Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value);
								
								///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////
							
								if(Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) > 0){
									bottomAlmacen.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[2].Value));
									bottomAlmacen.AddCell(PDFs.TexWhite115107(""+ Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value)));
									sumaTotalAlmacen += Convert.ToDouble(dtTotales.Rows[y].Cells[12].Value);
									sumaAlmacen += Convert.ToDouble(dtTotales.Rows[y].Cells[13].Value);
								}
								tR = tR - ( Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) * Convert.ToInt32(dtTotales.Rows[y].Cells[13].Value) );
							}
						}	
						++contadorArray;
						///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////	
						tableAlmacen.AddCell(bottomAlmacen);/************************/
		
						tableC.AddCell(bottom);
				}
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {70f, 330f,70f,};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
	   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
	
				float[] widths5 = new float[] {105f, 105f, 105f, 105f};
				PdfPTable bottom2 = new PdfPTable(4);
				bottom2.SetWidths(widths5);
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Completos"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasC.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasS.Text));
				bottom2.AddCell(PDFs.TexWhite115107((Convert.ToDouble(txtCamionesC.Text)-ContadorForsac).ToString()));
				bottom2.AddCell(PDFs.TexWhite115107((Convert.ToDouble(txtCamionesS.Text)-sumaTotalAlmacen).ToString()));
								
				double Tc2 = 0.0, Ts2 = 0.0, Cc2 = 0.0, Cs2 = 0.0;
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA"))
						Tc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA"))
						Ts2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]);
				}
				conn.conexion.Close();
				
				if(lblEmpresa.Text != "CONVER"){	
					//OSCAR
					if(lblEmpresa.Text == "TRACSA"){
						bottom2.AddCell(PDFs.TexWhite115107("0"));
						bottom2.AddCell(PDFs.TexWhite115107("0"));
						bottom2.AddCell(PDFs.TexWhite115107("0"));
						bottom2.AddCell(PDFs.TexWhite115107("0"));
					}
					else {
						bottom2.AddCell(PDFs.TexWhite115107(Tc2.ToString()));
						bottom2.AddCell(PDFs.TexWhite115107(Ts2.ToString()));
						bottom2.AddCell(PDFs.TexWhite115107(Cc2.ToString()));
						bottom2.AddCell(PDFs.TexWhite115107(Cs2.ToString()));
					}
				}
					
				/*
				bottom2.AddCell(PDFs.TexWhite115107(Tc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Ts.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs.ToString()));*/
				
				totales.AddCell(bottom2);
				
				// TOTALES PRECIO
				float[] widths44 = new float[] {50f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);	
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215206("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				//si quieren el total debe ser PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts + sumaAlmacen).ToString()));
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts).ToString()));
				//PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts + sumaAlmacen).ToString())); //Oscar 3 abril 2018
				nested22.AddCell(TotalTRimsa);				
				totales.AddCell(nested22);	
							
				PdfPTable Extras = new PdfPTable(1);
				Extras.TotalWidth = 470f;
				PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS"));
				headerExtras.Colspan = 2;
				Extras.AddCell(headerExtras);
				
				float[] widthsExtras = new float[] {50f, 40f, 200f, 65f, 65f};
				PdfPTable ContenidoExtras = new PdfPTable(5);
				ContenidoExtras.SetWidths(widthsExtras);
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
				for(int y = 0; y<(dtViajesEstandarExtras.RowCount); y++)
					{
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[0].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[1].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[2].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[3].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[4].Value));
					}
				Extras.AddCell(ContenidoExtras);
				
				
				if(dtViajesEstandarExtras.RowCount>0)
				{
					if(lblEmpresa.Text=="TEVA" || lblEmpresa.Text=="TEVA VANILLA")
						document.NewPage();
					document.Add(Extras);
				}
				
				document.Add(new Paragraph(espacio));
				document.Add(totales);
				//document.Add(new Paragraph(espacio));
				
				/*if(lblEmpresa.Text=="CARESTREAM")
				{
					PdfPTable DesgloseConver = new PdfPTable(1);
					DesgloseConver.TotalWidth = 470f;
					PdfPCell headerExtrasConver = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
					headerExtrasConver.Colspan = 2;
					DesgloseConver.AddCell(headerExtrasConver);
					
					float[] widthsExtrasConver = new float[] {20f, 20f, 20f, 20f, 20f, 20f};
					PdfPTable ContenidoExtrasConver = new PdfPTable(6);
					ContenidoExtrasConver.SetWidths(widthsExtrasConver);
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Total Final"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camiones Completos"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camiones Sencillos F"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Precio Total"));
					
					DesgloseConver.AddCell(ContenidoExtrasConver);
					document.Add(DesgloseConver);
				}	*/	
				
					/*if(lblEmpresa.Text=="LIVERPOOL")
				{
					PdfPTable DesgloseLiverpool = new PdfPTable(1);
					DesgloseLiverpool.TotalWidth = 470f;
					PdfPCell headerExtrasLiverpool = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
					headerExtrasLiverpool.Colspan = 2;
					DesgloseLiverpool.AddCell(headerExtrasLiverpool);
					
					float[] widthsExtrasLiverpool = new float[] {20f, 20f, 20f, 20f, 20f, 20f};
					PdfPTable ContenidoExtrasLiverpool = new PdfPTable(6);
					ContenidoExtrasLiverpool.SetWidths(widthsExtrasLiverpool);
					ContenidoExtrasLiverpool.AddCell(PDFs.TitWhite115308("Total Final"));
					ContenidoExtrasLiverpool.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
					ContenidoExtrasLiverpool.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
					ContenidoExtrasLiverpool.AddCell(PDFs.TitWhite115308("Camiones Completos"));
					ContenidoExtrasLiverpool.AddCell(PDFs.TitWhite115308("Camiones Sencillos F"));
					ContenidoExtrasLiverpool.AddCell(PDFs.TitWhite115308("Precio Total"));
					
					DesgloseLiverpool.AddCell(ContenidoExtrasLiverpool);
					document.Add(DesgloseLiverpool);
				}	*/
				
				if(lblEmpresa.Text=="CONVER")
				{
					PdfPTable DesgloseConver = new PdfPTable(1);
					DesgloseConver.TotalWidth = 470f;
					PdfPCell headerExtrasConver = new PdfPCell(PDFs.Enclgray215209("DESGLOSE TOTALES"));
					headerExtrasConver.Colspan = 2;
					DesgloseConver.AddCell(headerExtrasConver);
					
					float[] widthsExtrasConver = new float[] {20f, 20f, 20f, 20f, 20f};
					PdfPTable ContenidoExtrasConver = new PdfPTable(5);
					ContenidoExtrasConver.SetWidths(widthsExtrasConver);
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Ruta"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camiones Completos"));
					ContenidoExtrasConver.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
					for(int y = 0; y<(dataCONVER.RowCount); y++)
						{
							ContenidoExtrasConver.AddCell(PDFs.TexWhite115107(""+dataCONVER.Rows[y].Cells[0].Value));
							ContenidoExtrasConver.AddCell(PDFs.TexWhite115107(""+dataCONVER.Rows[y].Cells[1].Value));
							ContenidoExtrasConver.AddCell(PDFs.TexWhite115107(""+dataCONVER.Rows[y].Cells[2].Value));
							ContenidoExtrasConver.AddCell(PDFs.TexWhite115107(""+dataCONVER.Rows[y].Cells[3].Value));
							ContenidoExtrasConver.AddCell(PDFs.TexWhite115107(""+dataCONVER.Rows[y].Cells[4].Value));
						}
					DesgloseConver.AddCell(ContenidoExtrasConver);
					document.Add(DesgloseConver);
				}		
				
				if(lblEmpresa.Text=="BEBOX"){
					int viajes = Convert.ToInt32( txtCamionetasC.Text) +  Convert.ToInt32( txtCamionetasS.Text) + Convert.ToInt32( txtCamionesS.Text) + (Convert.ToInt32(txtCamionesC.Text)-ContadorForsac);
								
					string importe = (Cc + Cs + Tc + Ts).ToString();
					float[] widthtotalP = new float[] {16f,7f,7f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,5f,8f,15f};
					PdfPTable totalP = new PdfPTable(20);
					totalP.SetWidths(widthtotalP);
					
					totalP.AddCell(PDFs.Blanco2(viajes.ToString()));				
					totalP.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(viajes)*.70).ToString()));
					totalP.AddCell(PDFs.TitWhite1153082("70%"));
					totalP.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(importe)*.70).ToString("C")));
					
					totalP.AddCell(PDFs.Blanco2(viajes.ToString()));				
					totalP.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(viajes)*.30).ToString()));
					totalP.AddCell(PDFs.TitWhite1153082("30%"));
					totalP.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(importe)*.30).ToString("C")));
					
					totalP.AddCell(PDFs.Blanco2(viajes.ToString()));	
					totalP.AddCell(PDFs.DivisionGris8("TOTAL"));
					
					totalP.AddCell(PDFs.Blanco2(viajes.ToString()));
					totalP.AddCell(PDFs.TitWhite1153082(viajes.ToString()));
					totalP.AddCell(PDFs.TitWhite1153082("100%"));
					totalP.AddCell(PDFs.TitWhite1153082(Convert.ToDouble(importe).ToString("C")));
					document.Add(totalP);
				}	
				
				if(dtViajesEstandarExtras.RowCount>0)
				{
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
					document.Add(new Paragraph("                  están contabilizadas en la tabla de totales"));
				}
							
				///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////	
					
				if(lblEmpresa.Text == "TEVA"){
					document.NewPage();
					document.Add(tableAlmacen);
					document.Add(new Paragraph(espacio));
					
					float[] widths3a = new float[] {320f, 200f};
					PdfPTable totalesAlmacen = new PdfPTable(2);
					totalesAlmacen.SetWidths(widths3a);
					totalesAlmacen.TotalWidth = 470f;
					totalesAlmacen.AddCell(header2);						
		
					float[] widths5a = new float[] {105f};
					PdfPTable bottom2a = new PdfPTable(1);
					bottom2a.SetWidths(widths5a);	
					bottom2a.AddCell(PDFs.TitWhite115308("Almacén"));
					bottom2a.AddCell(PDFs.TexWhite115107(a.ToString()));	
					totalesAlmacen.AddCell(bottom2a);	
	
					float[] widths4a = new float[] {50f};
					PdfPTable nested2a = new PdfPTable(1);
					nested2a.SetWidths(widths4a);
					
					PdfPCell TotalNombreTevaA = new PdfPCell(PDFs.Enclgray215209("Total Almacén"));
					nested2a.AddCell(TotalNombreTevaA);	
					PdfPCell TotalTtevaA = new PdfPCell(PDFs.TitWhite115308(  (sumaAlmacen).ToString() ));
					nested2a.AddCell(TotalTtevaA);				
					totalesAlmacen.AddCell(nested2a);
					document.Add(totalesAlmacen);
				}
					
					/******************************************/
				if((Cc + Cs + Tc + Ts) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}
				}
			}
			#endregion
			
			#region RIMSA
			public void FormatoRIMSA1Facturacion(String FechaInicio, String FechaCorte, DataGridView dtLuisNormales, DataGridView dtChuyNormales, 
			                                     DataGridView dtLuisAlmacen, DataGridView dtChuyAlmacen, TextBox txtSencilloLuis,
			   		   							 TextBox txtAlmacen, TextBox txtEntrada, TextBox txtSalida, TextBox txtSencilloChuy, 
			   		   							 TextBox txtAlamcenChuy, TextBox txtEntradaChuy, TextBox txtSalidaChuy, 
			   		   							 Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                     String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {235f, 235f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
								
				float[] widths1 = new float[] {50f, 50f, 50f};
				PdfPTable nested = new PdfPTable(3);
				nested.SetWidths(widths1);
				
				nested.AddCell(PDFs.TitWhite115308("Luis"));
				    nested.AddCell(PDFs.TitWhite115308("."));
				    nested.AddCell(PDFs.TitWhite115308("."));
				    
				    nested.AddCell(PDFs.TitWhite115308("Fechas"));
				    nested.AddCell(PDFs.TitWhite115308("Sencillos"));
				    nested.AddCell(PDFs.TitWhite115308("Completos"));
				    
		   		    for(int y = 0; y<(dtLuisNormales.RowCount); y++)
					{
						nested.AddCell(PDFs.TexWhite115107(""+dtLuisNormales.Rows[y].Cells[0].Value));
						nested.AddCell(PDFs.TexWhite115107(""+dtLuisNormales.Rows[y].Cells[1].Value));
						nested.AddCell(PDFs.TexWhite115107(""+dtLuisNormales.Rows[y].Cells[2].Value));
					}	
		   		    
				PdfPCell nesthousing = new PdfPCell(nested);
				nesthousing.Padding = 0f;
				tableC.AddCell(nesthousing);
				
				float[] widths12 = new float[] {50f, 50f, 50f};
				PdfPTable nested2 = new PdfPTable(3);
				nested2.SetWidths(widths12);
				
				nested2.AddCell(PDFs.TitWhite115308("Chuy"));
				    nested2.AddCell(PDFs.TitWhite115308("."));
				    nested2.AddCell(PDFs.TitWhite115308("."));
				    nested2.AddCell(PDFs.TitWhite115308("Fechas"));
				    nested2.AddCell(PDFs.TitWhite115308("Sencillos"));
				    nested2.AddCell(PDFs.TitWhite115308("Completos"));
				    
				    
		   		    for(int y = 0; y<(dtChuyNormales.RowCount); y++)
					{
						nested2.AddCell(PDFs.TexWhite115107(""+dtChuyNormales.Rows[y].Cells[0].Value));
						nested2.AddCell(PDFs.TexWhite115107(""+dtChuyNormales.Rows[y].Cells[1].Value));
						nested2.AddCell(PDFs.TexWhite115107(""+dtChuyNormales.Rows[y].Cells[2].Value));
					}	
		   		    
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				tableC.AddCell(nesthousing2);
				
				//Almacen
				
				float[] widths122 = new float[] {50f, 50f, 50f};
				PdfPTable nested22 = new PdfPTable(3);
				nested22.SetWidths(widths122);
				nested22.AddCell(PDFs.TitWhite115308("Luis"));
				    nested22.AddCell(PDFs.TitWhite115308("Almacen"));
				    nested22.AddCell(PDFs.TitWhite115308("."));
				    nested22.AddCell(PDFs.TitWhite115308("Fechas"));
				    nested22.AddCell(PDFs.TitWhite115308("Sencillos"));
				    nested22.AddCell(PDFs.TitWhite115308("Completos"));
				    
		   		    for(int y = 0; y<(dtLuisAlmacen.RowCount); y++)
					{
						nested22.AddCell(PDFs.TexWhite115107(""+dtLuisAlmacen.Rows[y].Cells[0].Value));
						nested22.AddCell(PDFs.TexWhite115107(""+dtLuisAlmacen.Rows[y].Cells[1].Value));
						nested22.AddCell(PDFs.TexWhite115107(""+dtLuisAlmacen.Rows[y].Cells[2].Value));
					}	
		   		    
				PdfPCell nesthousing22 = new PdfPCell(nested22);
				nesthousing22.Padding = 0f;
				tableC.AddCell(nesthousing22);
				
				float[] widths1222 = new float[] {50f, 50f, 50f};
				PdfPTable nested222 = new PdfPTable(3);
				nested222.SetWidths(widths1222);
				nested222.AddCell(PDFs.TitWhite115308("Chuy"));
				    nested222.AddCell(PDFs.TitWhite115308("Almacen"));
				    nested222.AddCell(PDFs.TitWhite115308("."));
				    nested222.AddCell(PDFs.TitWhite115308("Fechas"));
				    nested222.AddCell(PDFs.TitWhite115308("Sencillos"));
				    nested222.AddCell(PDFs.TitWhite115308("Completos"));
				    
		   		    for(int y = 0; y<(dtChuyAlmacen.RowCount); y++)
					{
						nested222.AddCell(PDFs.TexWhite115107(""+dtChuyAlmacen.Rows[y].Cells[0].Value));
						nested222.AddCell(PDFs.TexWhite115107(""+dtChuyAlmacen.Rows[y].Cells[1].Value));
						nested222.AddCell(PDFs.TexWhite115107(""+dtChuyAlmacen.Rows[y].Cells[2].Value));
					}	
		   		    
				PdfPCell nesthousing222 = new PdfPCell(nested222);
				nesthousing222.Padding = 0f;
				tableC.AddCell(nesthousing222);
				
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {470f};
				PdfPTable totales = new PdfPTable(1);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 2;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f, 50f, 50f, 50f, 50f};
				PdfPTable nested23 = new PdfPTable(5);
				nested23.SetWidths(widths4);
				
	   		    nested23.AddCell(PDFs.TitWhite115308("."));
	   		    nested23.AddCell(PDFs.TitWhite115308("Sencillos"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Almacen"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Entrada"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Salida"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Luis"));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSencilloLuis.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtAlmacen.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtEntrada.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSalida.Text));
	   		    nested23.AddCell(PDFs.TitWhite115308("Chuy"));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSencilloChuy.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtAlamcenChuy.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtEntradaChuy.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSalidaChuy.Text));
	   		    
				PdfPCell nesthousing23 = new PdfPCell(nested23);
				nesthousing23.Padding = 0f;
				totales.AddCell(nesthousing23);			
				document.Add(totales);
			}
			
			public void FormatoRIMSA2Facturacion(String FechaInicio, String FechaCorte, DataGridView dtRimsa2, DataGridView dtViajesExtrasRimsa, 
			                                     TextBox txtNormales, TextBox txtCompletasEntradas, TextBox txtCompletasSalidas, TextBox txtAlmacenRimsa2, 
			   		   							 Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                     String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {90f, 380f, 90f, 380f};
			PdfPTable tableC = new PdfPTable(4);
			tableC.SetWidths(widths);
			tableC.TotalWidth = 470f;
			PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
			header.Colspan = 4;
			tableC.AddCell(header);
			
			for(int z = 0; z<Datos.Length; z++)
			{
				FechaPDF = Datos[contadorArray];
				DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
				float[] widths1 = new float[] {80f};
				PdfPTable nested = new PdfPTable(1);
				nested.SetWidths(widths1);
	   		    nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
				PdfPCell nesthousing = new PdfPCell(nested);
				nesthousing.Padding = 0f;
				tableC.AddCell(nesthousing);
				
				float[] widths2 = new float[] {80f, 100f, 100f, 100f};
				PdfPTable bottom = new PdfPTable(4);
				bottom.SetWidths(widths2);
				bottom.AddCell(PDFs.TitWhite115308("Horario"));
				bottom.AddCell(PDFs.TitWhite115308("Normales"));
				bottom.AddCell(PDFs.TitWhite115308("Entrada"));
				bottom.AddCell(PDFs.TitWhite115308("Salida"));
				
				for(int y = 0; y<(dtRimsa2.RowCount); y++)
				{
					if(Datos[contadorArray]==dtRimsa2.Rows[y].Cells[0].Value.ToString())
					{
						bottom.AddCell(PDFs.TexWhite115107(""+dtRimsa2.Rows[y].Cells[1].Value));
						bottom.AddCell(PDFs.TexWhite115107(""+dtRimsa2.Rows[y].Cells[2].Value));
						bottom.AddCell(PDFs.TexWhite115107(""+dtRimsa2.Rows[y].Cells[3].Value));
						bottom.AddCell(PDFs.TexWhite115107(""+dtRimsa2.Rows[y].Cells[4].Value));
					}
				}	
				++contadorArray;
				tableC.AddCell(bottom);
			}
			
			document.Add(tableC);
			document.Add(new Paragraph(espacio));
			
			float[] widths3 = new float[] {50f, 420f};
			PdfPTable totales = new PdfPTable(2);
			totales.SetWidths(widths3);
			totales.TotalWidth = 470f;
			PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
			header2.Colspan = 2;
			totales.AddCell(header2);
					
			float[] widths4 = new float[] {50f};
			PdfPTable nested2 = new PdfPTable(1);
			nested2.SetWidths(widths4);
   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
			PdfPCell nesthousing2 = new PdfPCell(nested2);
			nesthousing2.Padding = 0f;
			totales.AddCell(nesthousing2);

			float[] widths5 = new float[] {105f, 105f, 105f, 105f};
			PdfPTable bottom2 = new PdfPTable(4);
			bottom2.SetWidths(widths5);
			bottom2.AddCell(PDFs.TitWhite115308("Normales"));
			bottom2.AddCell(PDFs.TitWhite115308("Entradas"));
			bottom2.AddCell(PDFs.TitWhite115308("Salidas"));
			bottom2.AddCell(PDFs.TitWhite115308("Almacen"));
			bottom2.AddCell(PDFs.TexWhite115107(txtNormales.Text));
			bottom2.AddCell(PDFs.TexWhite115107(txtCompletasEntradas.Text));
			bottom2.AddCell(PDFs.TexWhite115107(txtCompletasSalidas.Text));
			bottom2.AddCell(PDFs.TexWhite115107(txtAlmacenRimsa2.Text));
			totales.AddCell(bottom2);		
			document.Add(totales);
			
			if(dtViajesExtrasRimsa.RowCount>0)
			{
				document.NewPage();
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				document.Add(espacio);
				
				PdfPTable Extras = new PdfPTable(1);
				Extras.TotalWidth = 470f;
				PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS"));
				headerExtras.Colspan = 2;
				Extras.AddCell(headerExtras);
				
				float[] widthsExtras = new float[] {15f, 15f, 40f, 15f, 15f};
				PdfPTable ContenidoExtras = new PdfPTable(5);
				ContenidoExtras.SetWidths(widthsExtras);
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
				for(int y = 0; y<(dtViajesExtrasRimsa.RowCount); y++)
					{
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[0].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[1].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[2].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[3].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[4].Value));
					}
				Extras.AddCell(ContenidoExtras);			
				document.Add(Extras);
				document.Add(new Paragraph(espacio));
				document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
				document.Add(new Paragraph("                  no están contabilizadas en la tabla de totales"));
			}
			
			}
			
			public void FormatoRIMSA3Facturacion(String FechaInicio, String FechaCorte, DataGridView dtTotales, DataGridView dtRimsa2, DataGridView dtViajesExtrasRimsa, 
			                                     DataGridView dtAlmacen, TextBox txtNormales, TextBox txtCompletasEntradas, TextBox txtCompletasSalidas, TextBox txtAlmacenRimsa2, 
			   		   							 Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                     String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal, string Tipo, double Calmacen)
			{				
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				///////////////////////////////////////////////////////////// NORMALES ////////////////////////////////////////////////////////////////////
				float[] widths = new float[] {90f, 380f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
				
				/////////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////
				float[] widthsAlmacen = new float[] {90f, 380f};
				PdfPTable tableAlmacen = new PdfPTable(2);
				tableAlmacen.SetWidths(widthsAlmacen);
				tableAlmacen.TotalWidth = 470f;
				PdfPCell headerAlmacen = new PdfPCell(PDFs.Enclgray215209("RIMSA ALMACÉN"));
				headerAlmacen.Colspan = 2;
				tableAlmacen.AddCell(headerAlmacen);
				
				///////////////////////////////////////////////////////////// VANILLA /////////////////////////////////////////////////////////////////////
				float[] widthsVANILLA = new float[] {90f, 380f};
				PdfPTable tableCVANILLA = new PdfPTable(2);
				tableCVANILLA.SetWidths(widthsVANILLA);
				tableCVANILLA.TotalWidth = 470f;
				PdfPCell headerVANILLA = new PdfPCell(PDFs.Enclgray215209("PROYECTO VANILLA"));
				headerVANILLA.Colspan = 2;
				tableCVANILLA.AddCell(headerVANILLA);
				
				int c=0, s=0, cT=0, sT=0, cV=0, sV=0, a=0, compV=0;
				double tR=0, tV=0;
				
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					
					///////////////////////////////////////////////////////////// NORMALES ////////////////////////////////////////////////////////////////////
					float[] widths1 = new float[] {80f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
		   		    nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {100f, 100f, 100f, 100f};
					PdfPTable bottom = new PdfPTable(4);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115308("Horario"));
					bottom.AddCell(PDFs.TitWhite115308("Completos"));
					bottom.AddCell(PDFs.TitWhite115308("Sencillos"));
					bottom.AddCell(PDFs.TitWhite115308("Total"));
										
					///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////
					float[] widths1Almacen = new float[] {80f};
					PdfPTable nestedAlmacen = new PdfPTable(1);
					nestedAlmacen.SetWidths(widths1Almacen);
		   		    nestedAlmacen.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousingAlmacen = new PdfPCell(nestedAlmacen);
					nesthousingAlmacen.Padding = 0f;
					tableAlmacen.AddCell(nesthousingAlmacen);
					
					float[] widths2Almacen = new float[] {100f, 100f};
					PdfPTable bottomAlmacen = new PdfPTable(2);
					bottomAlmacen.SetWidths(widths2Almacen);
					bottomAlmacen.AddCell(PDFs.TitWhite115308("Horario"));
					bottomAlmacen.AddCell(PDFs.TitWhite115308("Almacén"));
					
					///////////////////////////////////////////////////////////// VANILLA ////////////////////////////////////////////////////////////////////
					float[] widths1VANILLA = new float[] {80f};
					PdfPTable nestedVANILLA = new PdfPTable(1);
					nestedVANILLA.SetWidths(widths1VANILLA);
		   		    nestedVANILLA.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousingVANILLA = new PdfPCell(nestedVANILLA);
					nesthousingVANILLA.Padding = 0f;
					tableCVANILLA.AddCell(nesthousingVANILLA);
					
					float[] widths2VANILLA = new float[] {100f, 100f, 100f, 100f, 100f};
					PdfPTable bottomVANILLA = new PdfPTable(5);
					bottomVANILLA.SetWidths(widths2VANILLA);
					bottomVANILLA.AddCell(PDFs.TitWhite115308("Horario"));
					bottomVANILLA.AddCell(PDFs.TitWhite115308("Completos"));
					bottomVANILLA.AddCell(PDFs.TitWhite115308("Sencillos"));
					bottomVANILLA.AddCell(PDFs.TitWhite115308("Complementos"));
					bottomVANILLA.AddCell(PDFs.TitWhite115308("Total"));
				
					
					for(int y = 0; y<(dtTotales.RowCount); y++)
					{
						if(Datos[contadorArray] == dtTotales.Rows[y].Cells[0].Value.ToString())
						{
							if( ( Convert.ToInt32(dtTotales.Rows[y].Cells[8].Value) - ( ( Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) ) * Calmacen) ) > 0){
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[1].Value));							
								bottom.AddCell(PDFs.TexWhite115107(""+( Convert.ToInt32(dtTotales.Rows[y].Cells[2].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[10].Value) ) ));
								bottom.AddCell(PDFs.TexWhite115107(""+( Convert.ToInt32(dtTotales.Rows[y].Cells[3].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[11].Value) ) ));
								//bottom.AddCell(PDFs.TexWhite115107(""+( Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) ) ));							
								bottom.AddCell(PDFs.TexWhite115107(""+( Convert.ToDouble(dtTotales.Rows[y].Cells[8].Value)  - ( ( Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) ) * Calmacen) ) ) );
							}
							
							tR += Convert.ToDouble(dtTotales.Rows[y].Cells[8].Value);
							
							c += Convert.ToInt32(dtTotales.Rows[y].Cells[2].Value);
							s += Convert.ToInt32(dtTotales.Rows[y].Cells[3].Value);	
							a += Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value);								
						
							cT += Convert.ToInt32(dtTotales.Rows[y].Cells[10].Value);
							sT += Convert.ToInt32(dtTotales.Rows[y].Cells[11].Value);
							a += Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value);
													
							
							///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////
							
							if(( Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) ) > 0){
								bottomAlmacen.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[1].Value));
								bottomAlmacen.AddCell(PDFs.TexWhite115107(""+( Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) ) ));
							}
							tR = tR - ( ( Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value) + Convert.ToInt32(dtTotales.Rows[y].Cells[12].Value) ) * Calmacen);
								
							///////////////////////////////////////////////////////////// VANILLA ////////////////////////////////////////////////////////////////////
							
							bottomVANILLA.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[1].Value));
							bottomVANILLA.AddCell(PDFs.TexWhite115107(""+ dtTotales.Rows[y].Cells[4].Value  ));
							bottomVANILLA.AddCell(PDFs.TexWhite115107(""+ dtTotales.Rows[y].Cells[5].Value  ));						
							bottomVANILLA.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[6].Value));					
							bottomVANILLA.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[9].Value));
							
							tV += Convert.ToDouble(dtTotales.Rows[y].Cells[9].Value);							
							cV += Convert.ToInt32(dtTotales.Rows[y].Cells[4].Value);
							sV += Convert.ToInt32(dtTotales.Rows[y].Cells[5].Value);
							compV += Convert.ToInt32(dtTotales.Rows[y].Cells[6].Value);
						}
					}
					++contadorArray;					
					tableC.AddCell(bottom);	
					///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////	
					tableAlmacen.AddCell(bottomAlmacen);
					///////////////////////////////////////////////////////////// VANILLA ////////////////////////////////////////////////////////////////////	
					tableCVANILLA.AddCell(bottomVANILLA);
				}
				
				if(Tipo == ""){
					document.Add(tableC);
					document.Add(new Paragraph(espacio));
					
					float[] widths3 = new float[] {420f, 100f};
					PdfPTable totales = new PdfPTable(2);
					totales.SetWidths(widths3);
					totales.TotalWidth = 470f;
					PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
					header2.Colspan = 2;
					totales.AddCell(header2);						
		
					float[] widths5 = new float[] {105f, 105f, 105f, 105f};
					PdfPTable bottom2 = new PdfPTable(4);
					bottom2.SetWidths(widths5);
					
					
					PdfPCell headerCamion = new PdfPCell(PDFs.TitWhite115308("Camión"));
					headerCamion.Colspan = 2;
					bottom2.AddCell(headerCamion);	
					
					PdfPCell headerCamioneta = new PdfPCell(PDFs.TitWhite115308("Camioneta"));
					headerCamioneta.Colspan = 2;
					bottom2.AddCell(headerCamioneta);	
					
					bottom2.AddCell(PDFs.TitWhite115308("Completos"));
					bottom2.AddCell(PDFs.TitWhite115308("Sencillos"));
					//bottom2.AddCell(PDFs.TitWhite115308("Almacén"));
					bottom2.AddCell(PDFs.TitWhite115308("Completos"));
					bottom2.AddCell(PDFs.TitWhite115308("Sencillos"));
					
					
					bottom2.AddCell(PDFs.TexWhite115107(c.ToString()));
					bottom2.AddCell(PDFs.TexWhite115107(s.ToString()));
					//bottom2.AddCell(PDFs.TexWhite115107(a.ToString()));
					bottom2.AddCell(PDFs.TexWhite115107(cT.ToString()));
					bottom2.AddCell(PDFs.TexWhite115107(sT.ToString()));							
					
					totales.AddCell(bottom2);	
	
					float[] widths4 = new float[] {50f};
					PdfPTable nested2 = new PdfPTable(1);
					nested2.SetWidths(widths4);
					
					PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215209("Total Rimsa"));
					nested2.AddCell(TotalNombreRimsa);	
					PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308(tR.ToString()));
					nested2.AddCell(TotalTRimsa);				
					totales.AddCell(nested2);		
					
					document.Add(totales);
					
					if((tR) > 0.0){
						if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
							DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura RIMSA? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if(respuesta == DialogResult.Yes)
								connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (tR));
						}else{
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (tR));
						}
					}

					///////////////////////////////////////////////////////////// ALMACEN ////////////////////////////////////////////////////////////////////	
					document.NewPage();	
					document.Add(tableAlmacen);
					document.Add(new Paragraph(espacio));
					
					float[] widths3a = new float[] {320f, 200f};
					PdfPTable totalesAlmacen = new PdfPTable(2);
					totalesAlmacen.SetWidths(widths3a);
					totalesAlmacen.TotalWidth = 470f;
					totalesAlmacen.AddCell(header2);						
		
					float[] widths5a = new float[] {105f};
					PdfPTable bottom2a = new PdfPTable(1);
					bottom2a.SetWidths(widths5a);	
					bottom2a.AddCell(PDFs.TitWhite115308("Almacén"));
					bottom2a.AddCell(PDFs.TexWhite115107(a.ToString()));	
					totalesAlmacen.AddCell(bottom2a);	
	
					float[] widths4a = new float[] {50f};
					PdfPTable nested2a = new PdfPTable(1);
					nested2a.SetWidths(widths4a);
					
					PdfPCell TotalNombreRimsaA = new PdfPCell(PDFs.Enclgray215209("Total Almacén"));
					nested2a.AddCell(TotalNombreRimsaA);	
					PdfPCell TotalTRimsaA = new PdfPCell(PDFs.TitWhite115308( ( a * Calmacen).ToString() ));
					nested2a.AddCell(TotalTRimsaA);				
					totalesAlmacen.AddCell(nested2a);
					document.Add(totalesAlmacen);
					
					if( a > 0){
						if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
							DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura RIMSA ALMACÉN? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if(respuesta == DialogResult.Yes)
								connF.GuardaFactura(principal.idUsuario, "RIMSA ALMACÉN", FechaInicio, FechaCorte, (a * Calmacen));
						}else{
							connF.GuardaFactura(principal.idUsuario, "RIMSA ALMACÉN", FechaInicio, FechaCorte, (a * Calmacen));
						}
					}					
				}
					
				///////////////////////////////////////////////////////////// VANILLA ////////////////////////////////////////////////////////////////////
				
				if(Tipo == "VANILLA"){			
					//document.NewPage();
						
					writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
					
					document.Add(tableCVANILLA);
					document.Add(new Paragraph(espacio));
					
					float[] widths3VANILLA = new float[] {420f};
					PdfPTable totalesVANILLA = new PdfPTable(1);
					totalesVANILLA.SetWidths(widths3VANILLA);
					totalesVANILLA.TotalWidth = 470f;
					PdfPCell header2VANILLA = new PdfPCell(PDFs.Enclgray215209("TOTALES VANILLA"));
					totalesVANILLA.AddCell(header2VANILLA);						
		
					float[] widths5VANILLA = new float[] {105f, 105f, 105f, 105f};
					PdfPTable bottom2VANILLA = new PdfPTable(4);
					bottom2VANILLA.SetWidths(widths5VANILLA);
					
					bottom2VANILLA.AddCell(PDFs.TitWhite115308("Completos"));
					bottom2VANILLA.AddCell(PDFs.TitWhite115308("Sencillos"));
					bottom2VANILLA.AddCell(PDFs.TitWhite115308("Comlementos"));
					bottom2VANILLA.AddCell(PDFs.TitWhite115308("Total VANILLA"));
					
					bottom2VANILLA.AddCell(PDFs.TexWhite115107(cV.ToString()));
					bottom2VANILLA.AddCell(PDFs.TexWhite115107(sV.ToString()));
					bottom2VANILLA.AddCell(PDFs.TexWhite115107(compV.ToString()));	
					bottom2VANILLA.AddCell(PDFs.TexWhite115107(tV.ToString()));							
					
					totalesVANILLA.AddCell(bottom2VANILLA);	
	
					float[] widths4VANILLA = new float[] {50f};
					PdfPTable nested2VANILLA = new PdfPTable(1);
					nested2VANILLA.SetWidths(widths4VANILLA);	
					totalesVANILLA.AddCell(nested2VANILLA);
					
					document.Add(totalesVANILLA);

					if((tV) > 0.0){
						if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
							DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura RIMSA VANILLA? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if(respuesta == DialogResult.Yes)
								connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (tV));
						}else{
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (tV));
						}
					}					
				}
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				///////////////////////////////////////////////////////////// EXTRAS /////////////////////////////////////////////////////////////////////
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////				
				
				if(Tipo == ""){					
					if(dtViajesExtrasRimsa.RowCount > 0){
						
					int eE = 0, eS = 0, ecE = 0, ecS = 0, eC = 0, ecC = 0;
					double cCamion = 0, cCamioneta = 0;
					
						document.NewPage();					
						writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
					
						DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
						DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
						document.Add(PDFs.LogoFactura(writer)); 
						document.Add(espacio);
						document.Add(TablaDatos);
						document.Add(espacio);
						document.Add(espacio);
						document.Add(espacio);
						
						PdfPTable Extras = new PdfPTable(1);
						Extras.TotalWidth = 470f;
						PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS CAMION"));
						headerExtras.Colspan = 2;
						Extras.AddCell(headerExtras);
						
						float[] widthsExtras = new float[] {15f, 15f, 40f, 15f, 15f, 15f, 15f};
						PdfPTable ContenidoExtras = new PdfPTable(7);
						ContenidoExtras.SetWidths(widthsExtras);
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Tipo"));
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
						ContenidoExtras.AddCell(PDFs.TitWhite115308("Precio"));
						
						PdfPTable ExtrasC = new PdfPTable(1);
						ExtrasC.TotalWidth = 470f;
						PdfPCell headerExtrasC = new PdfPCell(PDFs.Enclgray215209("EXTRAS CAMIONETA"));
						headerExtrasC.Colspan = 2;
						ExtrasC.AddCell(headerExtrasC);
						
						float[] widthsExtrasC = new float[] {15f, 15f, 40f, 15f, 15f, 15f, 15f};
						PdfPTable ContenidoExtrasC = new PdfPTable(7);
						ContenidoExtrasC.SetWidths(widthsExtrasC);
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Tipo"));
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Fecha"));
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Horario"));
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Ruta"));
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Sentido"));
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Vehiculo"));
						ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Precio"));
						
						for(int y = 0; y<(dtViajesExtrasRimsa.RowCount); y++){
							
							if(dtViajesExtrasRimsa.Rows[y].Cells[5].Value.ToString() == "CAMION"){
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[0].Value));
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[1].Value));
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[2].Value));
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[3].Value));
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[4].Value));
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[5].Value));
								ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[7].Value));
								
								if(dtViajesExtrasRimsa.Rows[y].Cells[0].Value.ToString() == "Sencillo"){
									if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Entrada")
										eE++;
									if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Salida")
										eS++;
								}else{
									eC++;
								}
								
								cCamion += Convert.ToDouble(dtViajesExtrasRimsa.Rows[y].Cells[7].Value);
								
						    }
						    
							if(dtViajesExtrasRimsa.Rows[y].Cells[5].Value.ToString() == "CAMIONETA"){
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[0].Value));
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[1].Value));
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[2].Value));
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[3].Value));
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[4].Value));
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[5].Value));
								ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[7].Value));
							
								if(dtViajesExtrasRimsa.Rows[y].Cells[0].Value.ToString() == "Sencillo"){
									if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Entrada")
										ecE++;
									if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Salida")
										ecS++;
								}else{
									ecC++;
								}
								cCamioneta += Convert.ToDouble(dtViajesExtrasRimsa.Rows[y].Cells[7].Value);
						    }
							
						}
						
						////////////////////////////////////////////////////////////////////////////// EXTRA CAMION  ////////////////////////////////////////////////////////////////////////////// 
						Extras.AddCell(ContenidoExtras);
						document.Add(Extras);
						
						
						float[] widthsECT = new float[] {150f, 320f};
						PdfPTable totalesE = new PdfPTable(2);
						totalesE.SetWidths(widthsECT);
						totalesE.TotalWidth = 470f;
						PdfPCell header2E = new PdfPCell(PDFs.Enclgray215209("TOTALES EXTRA CAMION"));
						header2E.Colspan = 2;
						totalesE.AddCell(header2E);
								
						float[] widths4E = new float[] {50f};
						PdfPTable nested2E = new PdfPTable(1);
						nested2E.SetWidths(widths4E);
			   		    nested2E.AddCell(PDFs.TitWhite115308("Total Final"));
						PdfPCell nesthousing2E = new PdfPCell(nested2E);
						totalesE.AddCell(nesthousing2E);
			
						float[] widths5E = new float[] {105f,105f,105f};
						PdfPTable bottom2E = new PdfPTable(3);
						bottom2E.SetWidths(widths5E);
						bottom2E.AddCell(PDFs.TitWhite115308("Completos"));
						bottom2E.AddCell(PDFs.TitWhite115308("Sencillos"));
						bottom2E.AddCell(PDFs.TitWhite115308("Total"));
						bottom2E.AddCell(PDFs.TexWhite115107(eC.ToString()));
						bottom2E.AddCell(PDFs.TexWhite115107((eE+eS).ToString()));
						bottom2E.AddCell(PDFs.TexWhite115107((cCamion).ToString()));
						totalesE.AddCell(bottom2E);		
						document.Add(totalesE);
						
						////////////////////////////////////////////////////////////////////////////// EXTRA CAMIONETA ////////////////////////////////////////////////////////////////////////////// 
						
						document.NewPage();					
						writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);				
						document.Add(new Paragraph(espacio));
						ExtrasC.AddCell(ContenidoExtrasC);
						document.Add(ExtrasC);
						
						PdfPTable totalesC = new PdfPTable(2);
						totalesC.SetWidths(widthsECT);
						totalesC.TotalWidth = 470f;
						PdfPCell header2C = new PdfPCell(PDFs.Enclgray215209("TOTALES EXTRA CAMIONETA"));
						header2C.Colspan = 2;
						totalesC.AddCell(header2C);
								
						float[] widths4C = new float[] {50f};
						PdfPTable nested2C = new PdfPTable(1);
						nested2C.SetWidths(widths4C);
			   		    nested2C.AddCell(PDFs.TitWhite115308("Total Final"));
						PdfPCell nesthousing2C = new PdfPCell(nested2C);
						nesthousing2C.Padding = 0f;
						totalesC.AddCell(nesthousing2C);
			
						float[] widths5C = new float[] {105f,105f,105f};
						PdfPTable bottom2C = new PdfPTable(3);
						bottom2C.SetWidths(widths5C);
						bottom2C.AddCell(PDFs.TitWhite115308("Completos"));
						bottom2C.AddCell(PDFs.TitWhite115308("Sencillos"));
						bottom2C.AddCell(PDFs.TitWhite115308("Total"));
						bottom2C.AddCell(PDFs.TexWhite115107(ecC.ToString()));
						bottom2C.AddCell(PDFs.TexWhite115107((ecE+ecS).ToString()));
						bottom2C.AddCell(PDFs.TexWhite115107((cCamioneta).ToString()));
						totalesC.AddCell(bottom2C);		
						document.Add(totalesC);
						document.Add(new Paragraph(espacio));
						
						
						document.Add(new Paragraph(espacio));
						document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
						document.Add(new Paragraph("                  no están contabilizadas en la tabla de totales"));
	
						if((cCamioneta) > 0.0){
							if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
								DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura RIMSA EXTRA CAMIONETA? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if(respuesta == DialogResult.Yes)
									connF.GuardaFactura(principal.idUsuario, "RIMSA EXTRA CAMIONETA", FechaInicio, FechaCorte, cCamioneta);	
							}else{
								connF.GuardaFactura(principal.idUsuario, "RIMSA EXTRA CAMIONETA", FechaInicio, FechaCorte, cCamioneta);	
							}
						}		
						if((cCamioneta) > 0.0){
							if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
								DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura RIMSA EXTRA CAMION? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if(respuesta == DialogResult.Yes)
									connF.GuardaFactura(principal.idUsuario, "RIMSA EXTRA CAMION", FechaInicio, FechaCorte, cCamion);
							}else{
								connF.GuardaFactura(principal.idUsuario, "RIMSA EXTRA CAMION", FechaInicio, FechaCorte, cCamion);
							}
						}
					}	

				}// IF VANILLA O NORMAL					
			}
			
			
			#region otra factura
			/*
			  public void FormatoRIMSA3Facturacion(String FechaInicio, String FechaCorte, DataGridView dtTotales, DataGridView dtRimsa2, DataGridView dtViajesExtrasRimsa, 
			                                     DataGridView dtAlmacen, TextBox txtNormales, TextBox txtCompletasEntradas, TextBox txtCompletasSalidas, TextBox txtAlmacenRimsa2, 
			   		   							 Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                     String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {90f, 380f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
				
				int c=0, s=0, cV=0, sV=0, a=0, eV=0;
				double tR=0, tV=0;
				
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {80f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
		   		    nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {90f, 100, 100f, 100, 100, 120, 100, 75, 75};
					PdfPTable bottom = new PdfPTable(9);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115308("Horario"));
					bottom.AddCell(PDFs.TitWhite115308("Completos"));
					bottom.AddCell(PDFs.TitWhite115308("Sencillos"));
					bottom.AddCell(PDFs.TitWhite115308("Completos Vanilla"));
					bottom.AddCell(PDFs.TitWhite115308("Sencillos Vanilla"));
					bottom.AddCell(PDFs.TitWhite115308("Complemento Vanilla"));
					bottom.AddCell(PDFs.TitWhite115308("Almacén"));
					bottom.AddCell(PDFs.TitWhite115308("Total Rimsa"));
					bottom.AddCell(PDFs.TitWhite115308("Total Vanilla"));
					
					for(int y = 0; y<(dtTotales.RowCount); y++)
					{
						if(Datos[contadorArray]==dtTotales.Rows[y].Cells[0].Value.ToString())
						{
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[1].Value));
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[2].Value));
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[3].Value));
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[4].Value));
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[5].Value));	
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[6].Value));
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[7].Value));
							
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[8].Value));
							bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[9].Value));
							
							c += Convert.ToInt32(dtTotales.Rows[y].Cells[2].Value);
							s += Convert.ToInt32(dtTotales.Rows[y].Cells[3].Value);
							cV += Convert.ToInt32(dtTotales.Rows[y].Cells[4].Value);
							sV += Convert.ToInt32(dtTotales.Rows[y].Cells[5].Value);
							eV += Convert.ToInt32(dtTotales.Rows[y].Cells[6].Value);								
							a += Convert.ToInt32(dtTotales.Rows[y].Cells[7].Value);	

							tR += Convert.ToDouble(dtTotales.Rows[y].Cells[8].Value);	
							tV += Convert.ToDouble(dtTotales.Rows[y].Cells[9].Value);								
						}
					}	
					++contadorArray;					
					tableC.AddCell(bottom);
				}
				
				document.Add(tableC);
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {50f, 420f};
				PdfPTable totales = new PdfPTable(2);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 2;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
	   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
	
				float[] widths5 = new float[] {105f, 105f, 105f, 105f};
				PdfPTable bottom2 = new PdfPTable(4);
				bottom2.SetWidths(widths5);
				
				bottom2.AddCell(PDFs.TitWhite115308("Completos"));
				bottom2.AddCell(PDFs.TitWhite115308("Sencillos"));
				bottom2.AddCell(PDFs.TitWhite115308("Almacén"));
				bottom2.AddCell(PDFs.TitWhite115308("Total Rimsa"));
				
				bottom2.AddCell(PDFs.TexWhite115107(c.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(s.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(a.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(tR.ToString()));
				
				bottom2.AddCell(PDFs.Enclgray21520201("-"));
				bottom2.AddCell(PDFs.Enclgray21520201("-"));
				bottom2.AddCell(PDFs.Enclgray21520201("-"));	
				bottom2.AddCell(PDFs.Enclgray21520201("-"));				
								
				bottom2.AddCell(PDFs.TitWhite115308("Completos Vanilla"));
				bottom2.AddCell(PDFs.TitWhite115308("Sencillos Vanilla"));
				bottom2.AddCell(PDFs.TitWhite115308("Complemento Vanilla"));
				bottom2.AddCell(PDFs.TitWhite115308("Total Vanilla"));							
				
				bottom2.AddCell(PDFs.TexWhite115107(cV.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(sV.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(eV.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(tV.ToString()));
				
				totales.AddCell(bottom2);		
				document.Add(totales);
				
				if(dtViajesExtrasRimsa.RowCount>0)			{
					
				int eE = 0, eS = 0, ecE = 0, ecS = 0, eC = 0, ecC = 0;
				double cCamion = 0, cCamioneta = 0;
				
					document.NewPage();
					DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
					DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
					document.Add(PDFs.LogoFactura(writer)); 
					document.Add(espacio);
					document.Add(TablaDatos);
					document.Add(espacio);
					document.Add(espacio);
					document.Add(espacio);
					
					PdfPTable Extras = new PdfPTable(1);
					Extras.TotalWidth = 470f;
					PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS CAMION"));
					headerExtras.Colspan = 2;
					Extras.AddCell(headerExtras);
					
					float[] widthsExtras = new float[] {15f, 15f, 40f, 15f, 15f, 15f, 15f};
					PdfPTable ContenidoExtras = new PdfPTable(7);
					ContenidoExtras.SetWidths(widthsExtras);
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Tipo"));
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
					ContenidoExtras.AddCell(PDFs.TitWhite115308("Precio"));
					
					PdfPTable ExtrasC = new PdfPTable(1);
					ExtrasC.TotalWidth = 470f;
					PdfPCell headerExtrasC = new PdfPCell(PDFs.Enclgray215209("EXTRAS CAMIONETA"));
					headerExtrasC.Colspan = 2;
					ExtrasC.AddCell(headerExtrasC);
					
					float[] widthsExtrasC = new float[] {15f, 15f, 40f, 15f, 15f, 15f, 15f};
					PdfPTable ContenidoExtrasC = new PdfPTable(7);
					ContenidoExtrasC.SetWidths(widthsExtrasC);
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Tipo"));
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Fecha"));
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Horario"));
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Ruta"));
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Sentido"));
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Vehiculo"));
					ContenidoExtrasC.AddCell(PDFs.TitWhite115308("Precio"));
					
					for(int y = 0; y<(dtViajesExtrasRimsa.RowCount); y++){
						
						if(dtViajesExtrasRimsa.Rows[y].Cells[5].Value.ToString() == "CAMION"){
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[0].Value));
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[1].Value));
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[2].Value));
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[3].Value));
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[4].Value));
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[5].Value));
							ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[7].Value));
							
							if(dtViajesExtrasRimsa.Rows[y].Cells[0].Value.ToString() == "Sencillo"){
								if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Entrada")
									eE++;
								if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Salida")
									eS++;
							}else{
								eC++;
							}
							
							cCamion += Convert.ToDouble(dtViajesExtrasRimsa.Rows[y].Cells[7].Value);
							
					    }
					    
						if(dtViajesExtrasRimsa.Rows[y].Cells[5].Value.ToString() == "CAMIONETA"){
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[0].Value));
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[1].Value));
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[2].Value));
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[3].Value));
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[4].Value));
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[5].Value));
							ContenidoExtrasC.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasRimsa.Rows[y].Cells[7].Value));
						
							if(dtViajesExtrasRimsa.Rows[y].Cells[0].Value.ToString() == "Sencillo"){
								if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Entrada")
									ecE++;
								if(dtViajesExtrasRimsa.Rows[y].Cells[4].Value.ToString() == "Salida")
									ecS++;
							}else{
								ecC++;
							}
							cCamioneta += Convert.ToDouble(dtViajesExtrasRimsa.Rows[y].Cells[7].Value);
					    }
						
					}
					
					////////////////////////////////////////////////////////////////////////////// EXTRA CAMION  ////////////////////////////////////////////////////////////////////////////// 
					Extras.AddCell(ContenidoExtras);
					document.Add(Extras);
					
					PdfPTable totalesE = new PdfPTable(2);
					totalesE.SetWidths(widths3);
					totalesE.TotalWidth = 470f;
					PdfPCell header2E = new PdfPCell(PDFs.Enclgray215209("TOTALES EXTRA CAMION"));
					header2E.Colspan = 2;
					totalesE.AddCell(header2E);
							
					float[] widths4E = new float[] {50f};
					PdfPTable nested2E = new PdfPTable(1);
					nested2E.SetWidths(widths4E);
		   		    nested2E.AddCell(PDFs.TitWhite115308("Total Final"));
					PdfPCell nesthousing2E = new PdfPCell(nested2E);
					nesthousing2E.Padding = 0f;
					totalesE.AddCell(nesthousing2E);
		
					float[] widths5E = new float[] {105f,105f,105f};
					PdfPTable bottom2E = new PdfPTable(3);
					bottom2E.SetWidths(widths5E);
					bottom2E.AddCell(PDFs.TitWhite115308("Completos"));
					bottom2E.AddCell(PDFs.TitWhite115308("Sencillos"));
					bottom2E.AddCell(PDFs.TitWhite115308("Total"));
					bottom2E.AddCell(PDFs.TexWhite115107(eC.ToString()));
					bottom2E.AddCell(PDFs.TexWhite115107((eE+eS).ToString()));
					bottom2E.AddCell(PDFs.TexWhite115107((cCamion).ToString()));
					totalesE.AddCell(bottom2E);		
					document.Add(totalesE);
					
					////////////////////////////////////////////////////////////////////////////// EXTRA CAMIONETA ////////////////////////////////////////////////////////////////////////////// 
					
					document.NewPage();
					
					document.Add(new Paragraph(espacio));
					ExtrasC.AddCell(ContenidoExtrasC);
					document.Add(ExtrasC);
					
					PdfPTable totalesC = new PdfPTable(2);
					totalesC.SetWidths(widths3);
					totalesC.TotalWidth = 470f;
					PdfPCell header2C = new PdfPCell(PDFs.Enclgray215209("TOTALES EXTRA CAMIONETA"));
					header2C.Colspan = 2;
					totalesC.AddCell(header2C);
							
					float[] widths4C = new float[] {50f};
					PdfPTable nested2C = new PdfPTable(1);
					nested2C.SetWidths(widths4C);
		   		    nested2C.AddCell(PDFs.TitWhite115308("Total Final"));
					PdfPCell nesthousing2C = new PdfPCell(nested2C);
					nesthousing2C.Padding = 0f;
					totalesC.AddCell(nesthousing2C);
		
					float[] widths5C = new float[] {105f,105f,105f};
					PdfPTable bottom2C = new PdfPTable(3);
					bottom2C.SetWidths(widths5C);
					bottom2C.AddCell(PDFs.TitWhite115308("Completos"));
					bottom2C.AddCell(PDFs.TitWhite115308("Sencillos"));
					bottom2C.AddCell(PDFs.TitWhite115308("Total"));
					bottom2C.AddCell(PDFs.TexWhite115107(ecC.ToString()));
					bottom2C.AddCell(PDFs.TexWhite115107((ecE+ecS).ToString()));
					bottom2C.AddCell(PDFs.TexWhite115107((cCamioneta).ToString()));
					totalesC.AddCell(bottom2C);		
					document.Add(totalesC);
					document.Add(new Paragraph(espacio));
					
					
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
					document.Add(new Paragraph("                  no están contabilizadas en la tabla de totales"));
				}
			
			} 
			  
			  * */
			#endregion
			
			#endregion
			
			#region COREY
			public void FormatoCOREYFacturacion(String FechaInicio, String FechaCorte, DataGridView dtCorey, TextBox txtCamionetasSCorey, 
				                                      TextBox txtCamionetasCCorey, TextBox txtCamionesSCorey, TextBox txtCamionesCCorey, TextBox txtCamionetasOfCorey,
				                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
				                                      String DiaFacturacion, DataGridView dataFarmaciasNormales, DataGridView dtViajesExtrasCorey,
				                                      PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				float[] widths = new float[] {80f, 340f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
						
				
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0, To = 0.0;
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {100f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
					nested.AddCell(PDFs.TitWhite115308("Fecha"));
					nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
						
						float[] widths2 = new float[] {50f, 60f, 60f, 60f, 60f, 60f, 60f};
						PdfPTable bottom = new PdfPTable(7);
						bottom.SetWidths(widths2);
	
						bottom.AddCell(PDFs.TitWhite115308("Horario"));
						bottom.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
						bottom.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
						bottom.AddCell(PDFs.TitWhite115308("Camiones Completos"));
						bottom.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
						//if(lblEmpresa.Text=="COREY")
							bottom.AddCell(PDFs.TitWhite115308("Camionetas Oficinas"));
						//else
							//bottom.AddCell(PDFs.TitWhite115308("Angel Leaño"));
						bottom.AddCell(PDFs.TitWhite115308("Precios"));
						
						for(int y = 0; y<(dtCorey.RowCount); y++)
						{
							if((Convert.ToDateTime(Datos[contadorArray]).DayOfWeek.ToString())==(Convert.ToDateTime(dtCorey.Rows[y].Cells[0].Value.ToString()).DayOfWeek.ToString()))
							{
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[1].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[2].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[3].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[4].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[5].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[6].Value));
								
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[12].Value));
																
								Cc += Convert.ToDouble(dtCorey.Rows[y].Cells[9].Value);
								Cs += Convert.ToDouble(dtCorey.Rows[y].Cells[10].Value);
								Tc += Convert.ToDouble(dtCorey.Rows[y].Cells[7].Value);
								Ts += Convert.ToDouble(dtCorey.Rows[y].Cells[8].Value);
								To += Convert.ToDouble(dtCorey.Rows[y].Cells[11].Value);	
							}
						}	
						++contadorArray;
		
						tableC.AddCell(bottom);
				}
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {60f, 340f, 60f};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;				
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);
				
						
				float[] widths4 = new float[] {50f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
				
	   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
			
				float[] widths5 = new float[] {84f, 84f, 84f, 84f, 84f};
				PdfPTable bottom2 = new PdfPTable(5);
				bottom2.SetWidths(widths5);
				
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Completos"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
				//if(lblEmpresa.Text=="COREY")
					bottom2.AddCell(PDFs.TitWhite115308("Camionetas Oficinas"));
				//else
					//bottom2.AddCell(PDFs.TitWhite115308("Angel Leaño"));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasCCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasSCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionesCCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionesSCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasOfCorey.Text));
				
				
				double Tc2 = 0.0, Ts2 = 0.0, Cc2 = 0.0, Cs2 = 0.0;
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA"))
						Tc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA"))
						Ts2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]);
				}
				conn.conexion.Close();
				
				bottom2.AddCell(PDFs.TexWhite115107(Tc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Ts2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(To.ToString()));
				/*
				bottom2.AddCell(PDFs.TexWhite115107(Tc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Ts.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(To.ToString()));*/
				
				totales.AddCell(bottom2);
				
				// TOTALES PRECIO
				float[] widths44 = new float[] {50f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);		
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215209("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts + To).ToString()));
				nested22.AddCell(TotalTRimsa);				
				totales.AddCell(nested22);		
								
				if((Cc + Cs + Tc + Ts + To) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts + To));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts + To));
					}
				}				
				
				PdfPTable Extras = new PdfPTable(1);
				Extras.TotalWidth = 470f;
				PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS"));
				headerExtras.Colspan = 2;
				Extras.AddCell(headerExtras);
				
				float[] widthsExtras = new float[] {50f, 40f, 200f, 65f, 65f};
				PdfPTable ContenidoExtras = new PdfPTable(5);
				ContenidoExtras.SetWidths(widthsExtras);
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
				for(int y = 0; y<(dtViajesExtrasCorey.RowCount); y++)
				{
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[0].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[1].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[2].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[3].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[4].Value));
				}
				Extras.AddCell(ContenidoExtras);
				
				document.Add(new Paragraph(espacio));
				document.Add(totales);
				
				document.NewPage();
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				
				if(dtViajesExtrasCorey.RowCount>0)
				{
					document.Add(PDFs.LogoFactura(writer)); 
					document.Add(espacio);
					document.Add(TablaDatos);
					document.Add(espacio);
					document.Add(Extras);
				}
			
				/*if(dtViajesExtrasCorey.RowCount>0)
				{
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
					document.Add(new Paragraph("                  están contabilizadas en la tabla de totales"));
				}*/
			}
			#endregion
						
			#region FORSAC
			public void FormatoFORSACFacturacion(String FechaInicio, String FechaCorte, DataGridView dtCorey, TextBox txtCamionetasSCorey, 
				                                      TextBox txtCamionetasCCorey, TextBox txtCamionesSCorey, TextBox txtCamionesCCorey, TextBox txtCamionetasOfCorey,
				                                      TextBox txtCamionetasSEXTRA, TextBox txtCamionetasCEXTRA, TextBox txtCamionesSEXTRA, TextBox txtCamionesCEXTRA, 
				                                      TextBox txtOtroVehiculoEXTRA, Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
				                                      String DiaFacturacion, DataGridView dataFarmaciasNormales, DataGridView dtViajesExtrasCorey,
				                                      PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				float[] widths = new float[] {80f, 340f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
					
				
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0, To = 0.0;				
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {100f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
					nested.AddCell(PDFs.TitWhite115308("Fecha"));
					nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
						/*
						float[] widths2 = new float[] {50f, 60f, 60f, 60f, 60f, 60f, 60f};
						PdfPTable bottom = new PdfPTable(7);*/
						//nuevas
						float[] widths2 = new float[] {80f, 90f, 90f, 90f};
						PdfPTable bottom = new PdfPTable(4);
						bottom.SetWidths(widths2);
						/*
						bottom.AddCell(PDFs.TitWhite115308("Horario"));
						bottom.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
						bottom.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
						bottom.AddCell(PDFs.TitWhite115308("Camiones Completos"));
						bottom.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
						bottom.AddCell(PDFs.TitWhite115308("Angel Leaño"));
						bottom.AddCell(PDFs.TitWhite115308("Precio"));*/
						
						//nuevas
						bottom.AddCell(PDFs.TitWhite115308("Horario"));
						bottom.AddCell(PDFs.TitWhite115308("Galerias Camionetas Sencillas"));
						bottom.AddCell(PDFs.TitWhite115308("Tabachines Camionetas Sencillas"));
						bottom.AddCell(PDFs.TitWhite115308("Precio"));
						
						for(int y = 0; y<(dtCorey.RowCount); y++)
						{
							if((Convert.ToDateTime(Datos[contadorArray]).DayOfWeek.ToString())==(Convert.ToDateTime(dtCorey.Rows[y].Cells[0].Value.ToString()).DayOfWeek.ToString()))
							{
								/*
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[1].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[2].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[3].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[4].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[5].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[6].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[12].Value));*/
								
								//nuevas
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[1].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[2].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[3].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtCorey.Rows[y].Cells[12].Value));
																
								Cc += Convert.ToDouble(dtCorey.Rows[y].Cells[9].Value);
								Cs += Convert.ToDouble(dtCorey.Rows[y].Cells[10].Value);
								Tc += Convert.ToDouble(dtCorey.Rows[y].Cells[7].Value);
								Ts += Convert.ToDouble(dtCorey.Rows[y].Cells[8].Value);
								To += Convert.ToDouble(dtCorey.Rows[y].Cells[11].Value);								
							}
						}	
						++contadorArray;
		
						tableC.AddCell(bottom);
				}
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {60f, 340f, 80f};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
				
	   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
				/*
				float[] widths5 = new float[] {84f, 84f, 84f, 84f, 84f};
				PdfPTable bottom2 = new PdfPTable(5);
				bottom2.SetWidths(widths5);*/
				
				//nuevas
				float[] widths5 = new float[] {200f, 200f};
				PdfPTable bottom2 = new PdfPTable(2);
				bottom2.SetWidths(widths5);
				/*
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Completos"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));				
				bottom2.AddCell(PDFs.TitWhite115308("Angel Leaño"));*/
				
				//nuevas
				bottom2.AddCell(PDFs.TitWhite115308("Galerias Camionetas Sencillas"));
				bottom2.AddCell(PDFs.TitWhite115308("Tabachines Camionetas Sencillas"));
				/*
				if(Convert.ToInt32(txtCamionetasCEXTRA.Text) >= Convert.ToInt32(txtCamionetasCCorey.Text))
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionetasCEXTRA.Text) - Convert.ToInt32(txtCamionetasCCorey.Text)).ToString() ));
				else
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionetasCCorey.Text) - Convert.ToInt32(txtCamionetasCEXTRA.Text)).ToString() ));
					
				if(Convert.ToInt32(txtCamionetasSEXTRA.Text) >= Convert.ToInt32(txtCamionetasSCorey.Text))
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionetasSEXTRA.Text) - Convert.ToInt32(txtCamionetasSCorey.Text)).ToString() ));
				else
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionetasSCorey.Text) - Convert.ToInt32(txtCamionetasSEXTRA.Text)).ToString() ));
				
				if(Convert.ToInt32(txtCamionesCEXTRA.Text) >= Convert.ToInt32(txtCamionesCCorey.Text))
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionesCEXTRA.Text) - Convert.ToInt32(txtCamionesCCorey.Text)).ToString() ));
				else
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionesCCorey.Text) - Convert.ToInt32(txtCamionesCEXTRA.Text)).ToString() ));
								
				if(Convert.ToInt32(txtCamionesSEXTRA.Text) >= Convert.ToInt32(txtCamionesSCorey.Text))
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionesSEXTRA.Text) - Convert.ToInt32(txtCamionesSCorey.Text)).ToString() ));
				else
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionesSCorey.Text) - Convert.ToInt32(txtCamionesSEXTRA.Text)).ToString() ));
				
				if(Convert.ToInt32(txtOtroVehiculoEXTRA.Text) >= Convert.ToInt32(txtCamionetasOfCorey.Text))
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtOtroVehiculoEXTRA.Text) - Convert.ToInt32(txtCamionetasOfCorey.Text)).ToString() ));
				else
					bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToInt32(txtCamionetasOfCorey.Text) - Convert.ToInt32(txtOtroVehiculoEXTRA.Text)).ToString() ));
				
				*/
				/*
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasCCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasSCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionesCCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionesSCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasOfCorey.Text));*/
				
				//nuevas
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasCCorey.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasSCorey.Text));
								
				double Tc2 = 0.0, Ts2 = 0.0, Cc2 = 0.0, Cs2 = 0.0;
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA"))
						Tc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA"))
						Ts2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]);
					
					//nuevas
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["IDENTIFICADOR"].ToString().Equals("GALERIAS"))
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["IDENTIFICADOR"].ToString().Equals("TABACHINES"))
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]);
				}
				conn.conexion.Close();
				
				/*
				bottom2.AddCell(PDFs.TexWhite115107(Tc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Ts2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(To.ToString()));*/
				
				//nuevas
				bottom2.AddCell(PDFs.TexWhite115107(Cc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs2.ToString()));
				
				/*
				bottom2.AddCell(PDFs.TexWhite115107(Tc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Ts.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(To.ToString()));*/
								
				totales.AddCell(bottom2);
				
				// TOTALES PRECIO
				float[] widths44 = new float[] {70f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);		
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215209("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts + To).ToString()));
				nested22.AddCell(TotalTRimsa);				
				totales.AddCell(nested22);		
				
				if( (Cc + Cs + Tc + Ts + To) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts + To));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts + To));
					}
				}	
				
								
				PdfPTable Extras = new PdfPTable(1);
				Extras.TotalWidth = 470f;
				
				PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS"));
				headerExtras.Colspan = 2;
				Extras.AddCell(headerExtras);
				
				float[] widthsExtras = new float[] {50f, 40f, 200f, 65f, 65f};
				PdfPTable ContenidoExtras = new PdfPTable(5);
				ContenidoExtras.SetWidths(widthsExtras);
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
				for(int y = 0; y<(dtViajesExtrasCorey.RowCount); y++)
				{
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[0].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[1].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[2].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[3].Value));
					ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesExtrasCorey.Rows[y].Cells[4].Value));
				}
				Extras.AddCell(ContenidoExtras);				
				
				float[] widths55 = new float[] {80f, 340f};
				PdfPTable totalesEXTRA = new PdfPTable(2);
				totalesEXTRA.SetWidths(widths55);
				totalesEXTRA.TotalWidth = 470f;
				
				PdfPCell header4 = new PdfPCell(PDFs.Enclgray215209("TOTALES EXTRA"));
				header4.Colspan = 2;
				totalesEXTRA.AddCell(header4);
						
				float[] widths6 = new float[] {50f};
				PdfPTable nested4 = new PdfPTable(1);
				nested4.SetWidths(widths6);
				
	   		    nested4.AddCell(PDFs.TitWhite115308("Total Final Extra"));
				PdfPCell nesthousing4 = new PdfPCell(nested4);
				nesthousing4.Padding = 0f;
				totalesEXTRA.AddCell(nesthousing4);
			
				float[] widths7 = new float[] {84f, 84f, 84f, 84f, 84f};
				PdfPTable bottom22 = new PdfPTable(5);
				bottom22.SetWidths(widths7);
				
				bottom22.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
				bottom22.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
				bottom22.AddCell(PDFs.TitWhite115308("Camiones Completos"));
				bottom22.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));				
				//bottom22.AddCell(PDFs.TitWhite115308("Angel Leaño"));
				
				bottom22.AddCell(PDFs.TexWhite115107(txtCamionetasCEXTRA.Text));
				bottom22.AddCell(PDFs.TexWhite115107(txtCamionetasSEXTRA.Text));
				bottom22.AddCell(PDFs.TexWhite115107(txtCamionesCEXTRA.Text));
				bottom22.AddCell(PDFs.TexWhite115107(txtCamionesSEXTRA.Text));
				bottom22.AddCell(PDFs.TexWhite115107(txtOtroVehiculoEXTRA.Text));
				totalesEXTRA.AddCell(bottom22);
				
				document.Add(new Paragraph(espacio));
				document.Add(totales);
				
				document.NewPage();
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				if(dtViajesExtrasCorey.RowCount > 0){
					document.Add(PDFs.LogoFactura(writer)); 
					document.Add(espacio);
					document.Add(TablaDatos);
					document.Add(espacio);
					document.Add(Extras);					
					document.Add(totalesEXTRA);
				}
			
				/*if(dtViajesExtrasCorey.RowCount>0)
				{
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
					document.Add(new Paragraph("                  están contabilizadas en la tabla de totales"));
				}*/
			}
			#endregion
			
			#region FARMACIAS
			public void FormatoFarmacias1Facturacion(String FechaInicio, String FechaCorte, DataGridView dataFarmaciasNormales, TextBox txtCamionetasS, 
				                                      TextBox txtCamionetasC, TextBox txtCamionesS, TextBox txtCamionesC,
				                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
				                                      String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {48f, 427f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.WidthPercentage = 90;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
								
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0;
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {80f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
		   		    nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {53f, 100f, 108.5f, 108.5f, 101.5f, 101.5f, 50f};
					PdfPTable bottom = new PdfPTable(7);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115206("HORARIO"));
					bottom.AddCell(PDFs.TitWhite115206("DEPARTAMENTO"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONETAS COMPLETAS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONETAS SENCILLAS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONES COMPLETOS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONES SENCILLOS"));
					bottom.AddCell(PDFs.TitWhite115206("PRECIO"));
					
					for(int y = 0; y<(dataFarmaciasNormales.RowCount); y++)
					{
						if(Datos[contadorArray]==dataFarmaciasNormales.Rows[y].Cells[1].Value.ToString())
						{
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[2].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[3].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[4].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[5].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[6].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[7].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasNormales.Rows[y].Cells[12].Value));
							
							Cc += Convert.ToDouble(dataFarmaciasNormales.Rows[y].Cells[10].Value);
							Cs += Convert.ToDouble(dataFarmaciasNormales.Rows[y].Cells[11].Value);
							Tc += Convert.ToDouble(dataFarmaciasNormales.Rows[y].Cells[8].Value);
							Ts += Convert.ToDouble(dataFarmaciasNormales.Rows[y].Cells[9].Value);
						}
					}	
					++contadorArray;
					tableC.AddCell(bottom);
				}
			
				document.Add(tableC);
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {35f, 407f, 55f};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.WidthPercentage = 90;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {40f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
	   		    nested2.AddCell(PDFs.TitWhite115308("TOTAL FINAL"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
	
				double Tc2 = 0.0, Ts2 = 0.0, Cc2 = 0.0, Cs2 = 0.0;
				string codigoTC = "", codigoTS = "", codigoCC = "", codigoCS = "";
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA")){
						Tc2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoTC = conn.leer["OBERVACIONES"].ToString();						
					}
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA")){
						Ts2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoTS = conn.leer["OBERVACIONES"].ToString();
					}						
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMION")){
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoCC = conn.leer["OBERVACIONES"].ToString();
					}						
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION")){
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoCS = conn.leer["OBERVACIONES"].ToString();
					}
				}
				conn.conexion.Close();
				
				float[] widths5 = new float[] {105f, 105f, 105f, 105f};
				PdfPTable bottom2 = new PdfPTable(4);
				bottom2.SetWidths(widths5);
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONETAS COMPLETAS #"+codigoTC));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONETAS SENCILLAS #"+codigoTS));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONES COMPLETOS #"+codigoCC));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONES SENCILLOS #"+codigoCS));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionetasC.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionetasS.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionesC.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionesS.Text));
				bottom2.AddCell(PDFs.TexWhite112106(Tc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite112106(Ts2.ToString()));
				bottom2.AddCell(PDFs.TexWhite112106(Cc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite112106(Cs2.ToString()));				
				totales.AddCell(bottom2);
				
				// TOTALES PRECIO
				float[] widths44 = new float[] {50f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);		
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215206("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts).ToString()));
				nested22.AddCell(TotalTRimsa);					
				totales.AddCell(nested22);
				
				document.Add(totales);
				
				if( (Cc + Cs + Tc + Ts) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}
				}
			}
				
			public void FormatoFarmacias2Facturacion(String FechaInicio, String FechaCorte, DataGridView dataFarmaciasExtras, TextBox txtCamionetasS, 
					                                      TextBox txtCamionetasC, TextBox txtCamionesS, TextBox txtCamionesC,
					                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
					                                      String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal, TextBox txtOtroVehiculo)
				{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {20f, 450f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.WidthPercentage = 90;
				//tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
				
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0, Tv = 0.0;
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {80f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
		   		    nested.AddCell(PDFs.VerWhite115307(DiaFacturacion + " \n" + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {33f, 50f, 76f, 76f, 68f, 65f, 64f, 30f};
					PdfPTable bottom = new PdfPTable(8);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115206("HORARIO"));
					bottom.AddCell(PDFs.TitWhite115206("DEPARTAMENTO"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONETAS COMPLETAS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONETAS SENCILLAS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONES COMPLETOS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONES SENCILLOS"));
					bottom.AddCell(PDFs.TitWhite115206("CAMIONETAS VELADA"));
					bottom.AddCell(PDFs.TitWhite115206("PRECIO"));
					
					for(int y = 0; y<(dataFarmaciasExtras.RowCount); y++)
					{
						if(Datos[contadorArray]==dataFarmaciasExtras.Rows[y].Cells[1].Value.ToString())
						{
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[2].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[3].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[4].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[5].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[6].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[7].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[8].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataFarmaciasExtras.Rows[y].Cells[14].Value));
														
							Cc += Convert.ToDouble(dataFarmaciasExtras.Rows[y].Cells[11].Value);
							Cs += Convert.ToDouble(dataFarmaciasExtras.Rows[y].Cells[12].Value);
							Tc += Convert.ToDouble(dataFarmaciasExtras.Rows[y].Cells[9].Value);
							Ts += Convert.ToDouble(dataFarmaciasExtras.Rows[y].Cells[10].Value);
							Tv += Convert.ToDouble(dataFarmaciasExtras.Rows[y].Cells[13].Value);
						}
					}	
					++contadorArray;
					tableC.AddCell(bottom);
				}
				
				document.Add(tableC);
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {35f, 407f, 55f};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.WidthPercentage = 90;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);				
						
				float[] widths4 = new float[] {40f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
	   		    nested2.AddCell(PDFs.TitWhite115308("TOTAL FINAL"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
	
				double Tc2 = 0.0, Ts2 = 0.0, Cc2 = 0.0, Cs2 = 0.0,  Tv2 = 0.0;
				string codigoTC = "", codigoTS = "", codigoCC = "", codigoCS = "", codigoTv = "";
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA")){
						Tc2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoTC = conn.leer["OBERVACIONES"].ToString();
					}
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA")){
						Ts2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoTS = conn.leer["OBERVACIONES"].ToString();
					}						
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMION")){
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoCC = conn.leer["OBERVACIONES"].ToString();
					}						
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION")){
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoCS = conn.leer["OBERVACIONES"].ToString();
					}						
					if(conn.leer["SENTIDO"].ToString().Equals("NA") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["IDENTIFICADOR"].ToString().Equals("VELADA")){
						Tv2 = Convert.ToDouble(conn.leer["PRECIO"]); 
						codigoTv = conn.leer["OBERVACIONES"].ToString();
					}	
				}
				conn.conexion.Close();
				
				float[] widths5 = new float[] {94f, 94f, 94f, 94f, 94f};
				PdfPTable bottom2 = new PdfPTable(5);
				bottom2.SetWidths(widths5);
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONETAS COMPLETAS "+codigoTC));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONETAS SENCILLAS "+codigoTS));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONES COMPLETOS "+codigoCC));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONES SENCILLOS "+codigoCS));
				bottom2.AddCell(PDFs.TitWhite115206("CAMIONETAS VELADA "+codigoTv));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionetasC.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionetasS.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionesC.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtCamionesS.Text));
				bottom2.AddCell(PDFs.TexWhite112106(txtOtroVehiculo.Text));				
				bottom2.AddCell(PDFs.TexWhite112106(Tc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite112106(Ts2.ToString()));
				bottom2.AddCell(PDFs.TexWhite112106(Cc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite112106(Cs2.ToString()));	
				bottom2.AddCell(PDFs.TexWhite112106(Tv2.ToString()));				
				totales.AddCell(bottom2);

				// TOTALES PRECIO
				float[] widths44 = new float[] {50f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);		
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215206("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts + Tv).ToString()));
				nested22.AddCell(TotalTRimsa);					
				totales.AddCell(nested22);
				
				document.Add(totales);
				
				if((Cc + Cs + Tc + Ts + Tv) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts + Tv));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts + Tv));
					}
				}
			}
			
			public void FormatoFarmacias3Facturacion(String FechaInicio, String FechaCorte, DataGridView dataDesglose,
				                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
				                                      String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {50f, 420f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.WidthPercentage = 90;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
						
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {80f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
		   		    nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {80f, 60f, 150f, 150f};
					PdfPTable bottom = new PdfPTable(4);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115206("UNIDAD"));
					bottom.AddCell(PDFs.TitWhite115206("HORARIO"));
					bottom.AddCell(PDFs.TitWhite115206("ENTRADAS"));
					bottom.AddCell(PDFs.TitWhite115206("SALIDAS"));
					
					for(int y = 0; y<(dataDesglose.RowCount); y++)
					{
						if(Datos[contadorArray]==dataDesglose.Rows[y].Cells[1].Value.ToString())
						{
							bottom.AddCell(PDFs.TexWhite112106(""+dataDesglose.Rows[y].Cells[2].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataDesglose.Rows[y].Cells[3].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataDesglose.Rows[y].Cells[4].Value));
							bottom.AddCell(PDFs.TexWhite112106(""+dataDesglose.Rows[y].Cells[5].Value));
						}
					}	
					++contadorArray;
					tableC.AddCell(bottom);
				}
				document.Add(tableC);	
			}
			#endregion
			
			#region HENNIEGES - VITRO
			public void FormatoHENNIEGESFacturacion(String FechaInicio, String FechaCorte, DataGridView dataHenniges,  
			                                        Document document, String lblEmpresa, PdfWriter writer, 
			                                        Interfaz.FormPrincipal principal, String viajes, String importe)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				bool Tarde = false;
				bool Vespertino = false;
				bool Noche =false;
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				PdfPTable tableC = new PdfPTable(1);
				tableC.WidthPercentage = 80;
				tableC.AddCell(PDFs.Enclgray215209(lblEmpresa));
				document.Add(tableC);
				
				float[] widths1 = new float[] {17f,7f,7f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,5f,8f,14f};
				PdfPTable nested = new PdfPTable(20);
				nested.SetWidths(widths1);
				
				nested.AddCell(PDFs.Esp3White115308(""));
				nested.AddCell(PDFs.Esp2White115308("Lun"));
				nested.AddCell(PDFs.Esp2White115308("Mar"));
				nested.AddCell(PDFs.Esp2White115308("Mie"));
				nested.AddCell(PDFs.Esp2White115308("Jue"));
				nested.AddCell(PDFs.Esp2White115308("Vie"));
				nested.AddCell(PDFs.Esp2White115308("Sab"));
				nested.AddCell(PDFs.Esp2White115308("Dom"));
				nested.AddCell(PDFs.Esp3White115308(""));
				
				nested.AddCell(PDFs.TitWhite115308("Ruta"));
				nested.AddCell(PDFs.TitWhite115308("Servicio"));
				nested.AddCell(PDFs.TitWhite115308("Turno"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("#"));
				nested.AddCell(PDFs.TitWhite115308("P.Uni"));
				nested.AddCell(PDFs.TitWhite115308("Total"));
					for(int z = 0; z<dataHenniges.RowCount; z++)
					{
						if(dataHenniges.Rows[z].Cells[2].Value.ToString()=="Medio día"&&Tarde==false)
						{
							nested.AddCell(PDFs.DivisionGris20("-"));
							Tarde=true;							
						}
						if(dataHenniges.Rows[z].Cells[2].Value.ToString()=="Vespertino"&&Vespertino==false)
						{
							nested.AddCell(PDFs.DivisionGris20("-"));
							Vespertino=true;							
						}
						if(dataHenniges.Rows[z].Cells[2].Value.ToString()=="Nocturno"&&Noche==false)
						{
							nested.AddCell(PDFs.DivisionGris20("-"));
							Noche=true;							
						}
						nested.AddCell(PDFs.TexWhite111107(dataHenniges.Rows[z].Cells[0].Value.ToString()));
						nested.AddCell(PDFs.TexWhite115107(dataHenniges.Rows[z].Cells[1].Value.ToString()));
						nested.AddCell(PDFs.TexWhite115107(dataHenniges.Rows[z].Cells[2].Value.ToString()));
						for(int t = 3; t<dataHenniges.ColumnCount; t++)
						{
							if(dataHenniges.Rows[z].Cells[t].Value!=null)
							{
								if(t!=18&&t!=19)
									nested.AddCell(PDFs.TexWhite115107(dataHenniges.Rows[z].Cells[t].Value.ToString()));
								else
									nested.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dataHenniges.Rows[z].Cells[t].Value).ToString("C")));
							}
							else
								nested.AddCell(PDFs.TexWhite115107("-"));
						}
					}
				document.Add(nested);
				document.Add(espacio);
				
				float[] widthtotal = new float[] {17f,7f,7f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,5f,8f,14f};
				PdfPTable total = new PdfPTable(20);
				total.SetWidths(widthtotal);
				//total.WidthPercentage = 80f;		
				
				//for(int f=0; f<17; f++)
				total.AddCell(PDFs.Blanco2(viajes));				
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(viajes)*.80).ToString()));
				total.AddCell(PDFs.TitWhite1153082("80%"));
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(importe)*.80).ToString("C")));
				
				total.AddCell(PDFs.Blanco2(viajes));				
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(viajes)*.20).ToString()));
				total.AddCell(PDFs.TitWhite1153082("20%"));
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(importe)*.20).ToString("C")));
				
				total.AddCell(PDFs.Blanco2(viajes));	
				total.AddCell(PDFs.DivisionGris8("TOTAL"));
				
				total.AddCell(PDFs.Blanco2(viajes));				
				total.AddCell(PDFs.TitWhite1153082(viajes));
				total.AddCell(PDFs.TitWhite1153082("100%"));
				total.AddCell(PDFs.TitWhite1153082(Convert.ToDouble(importe).ToString("C")));
				document.Add(total);

				if(Convert.ToDouble(importe) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa, FechaInicio, FechaCorte, Convert.ToDouble(importe));	
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa, FechaInicio, FechaCorte, Convert.ToDouble(importe));	
					}
				}				
			}
			
			public void FormatoHENNIEGESFacturacionExtra(String FechaInicio, String FechaCorte, DataGridView dataHennigesExtra,  
			                                        Document document, Label lblEmpresa, PdfWriter writer, 
			                                        Interfaz.FormPrincipal principal, String viajes, String importe, 
			                                        DataGridView dataHennigesEspecial, String viajes2, String importe2, 
			                                        DataGridView dataHennigesExtra2, String viajes3, String importe3, DataGridView dataviajesnormales)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				PdfPTable tableC = new PdfPTable(1);
				tableC.WidthPercentage = 80;
				tableC.AddCell(PDFs.Enclgray215209("HENNIGES TIEMPO EXTRA"));
				document.Add(tableC);
				
				float[] widths1 = new float[] {20f,10f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,5f,9f,14f};
				PdfPTable nested = new PdfPTable(19);
				nested.SetWidths(widths1);
				
				nested.AddCell(PDFs.Esp2White115308(""));
				nested.AddCell(PDFs.Esp2White115308("Lun"));
				nested.AddCell(PDFs.Esp2White115308("Mar"));
				nested.AddCell(PDFs.Esp2White115308("Mie"));
				nested.AddCell(PDFs.Esp2White115308("Jue"));
				nested.AddCell(PDFs.Esp2White115308("Vie"));
				nested.AddCell(PDFs.Esp2White115308("Sab"));
				nested.AddCell(PDFs.Esp2White115308("Dom"));
				nested.AddCell(PDFs.Esp3White115308(""));
				
				nested.AddCell(PDFs.TitWhite115308("Ruta"));
				nested.AddCell(PDFs.TitWhite115308("Servicio"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("E"));
				nested.AddCell(PDFs.TitWhite115308("S"));
				nested.AddCell(PDFs.TitWhite115308("#"));
				nested.AddCell(PDFs.TitWhite115308("P.Uni"));
				nested.AddCell(PDFs.TitWhite115308("Total"));
				for(int z = 0; z<dataHennigesExtra.RowCount; z++)
				{
					nested.AddCell(PDFs.TexWhite111107(dataHennigesExtra.Rows[z].Cells[0].Value.ToString()));
					nested.AddCell(PDFs.TexWhite115107(dataHennigesExtra.Rows[z].Cells[1].Value.ToString()));
					for(int t = 2; t<dataHennigesExtra.ColumnCount; t++)
					{
						if(dataHennigesExtra.Rows[z].Cells[t].Value!=null)
						{
							if(t!=17&&t!=18)
								nested.AddCell(PDFs.TexWhite115107(dataHennigesExtra.Rows[z].Cells[t].Value.ToString()));
							else
								nested.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dataHennigesExtra.Rows[z].Cells[t].Value).ToString("C")));
						}
						else
							nested.AddCell(PDFs.TexWhite115107("-"));
					}
				}
				document.Add(nested);
				document.Add(espacio);
				
				float[] widthtotal = new float[] {20f,10f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,3f,5f,9f,14f};
				PdfPTable total = new PdfPTable(19);
				total.SetWidths(widthtotal);
				total.WidthPercentage = 80f;
				/*
				for(int f=0; f<16; f++)
				total.AddCell(PDFs.Blanco(viajes));
				total.AddCell(PDFs.TitWhite115308(viajes));
				total.AddCell(PDFs.TexWhite111107(""));
				total.AddCell(PDFs.TitWhite115308(Convert.ToDouble(importe).ToString("C")));
				*/
				total.AddCell(PDFs.Blanco3(viajes));				
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(viajes)*.80).ToString()));
				total.AddCell(PDFs.TitWhite1153082("80%"));
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(importe)*.80).ToString("C")));
				
				total.AddCell(PDFs.Blanco3(viajes));				
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(viajes)*.20).ToString()));
				total.AddCell(PDFs.TitWhite1153082("20%"));
				total.AddCell(PDFs.TitWhite1153082((Convert.ToDouble(importe)*.20).ToString("C")));
				
				total.AddCell(PDFs.Blanco3(viajes));	
				total.AddCell(PDFs.DivisionGris8("TOTAL"));
				
				total.AddCell(PDFs.Blanco3(viajes));				
				total.AddCell(PDFs.TitWhite1153082(viajes));
				total.AddCell(PDFs.TitWhite1153082("100%"));
				total.AddCell(PDFs.TitWhite1153082(Convert.ToDouble(importe).ToString("C")));				
				document.Add(total);
				document.Add(espacio);
				
				PdfPTable tableC2 = new PdfPTable(1);
				tableC2.WidthPercentage = 80;
				tableC2.AddCell(PDFs.Enclgray215209("HENNIGES ESPECIALES"));
				document.Add(tableC2);
				
				float[] widths121 = new float[] {62f,5f,13f,20f};
				PdfPTable nested21 = new PdfPTable(4);
				nested21.SetWidths(widths121);
				nested21.AddCell(PDFs.TitWhite115308("Ruta"));
				nested21.AddCell(PDFs.TitWhite115308("#"));
				nested21.AddCell(PDFs.TitWhite115308("P.Uni"));
				nested21.AddCell(PDFs.TitWhite115308("Total"));
				for(int z = 0; z<dataHennigesEspecial.RowCount; z++)
				{
					nested21.AddCell(PDFs.TexWhite111107(dataHennigesEspecial.Rows[z].Cells[0].Value.ToString()));
					nested21.AddCell(PDFs.TexWhite115107(dataHennigesEspecial.Rows[z].Cells[1].Value.ToString()));
					nested21.AddCell(PDFs.TexWhite115107(dataHennigesEspecial.Rows[z].Cells[2].Value.ToString()));
					nested21.AddCell(PDFs.TexWhite115107(dataHennigesEspecial.Rows[z].Cells[3].Value.ToString()));
				}
				nested21.AddCell(PDFs.TitWhite115308(""));
				nested21.AddCell(PDFs.TitWhite115308(viajes3));
				nested21.AddCell(PDFs.TexWhite111107(""));
				nested21.AddCell(PDFs.TitWhite115308(Convert.ToDouble(importe3).ToString("C")));
				document.Add(nested21);
				
				if(Convert.ToDouble(importe) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, "HENNIGES TIEMPO EXTRA", FechaInicio, FechaCorte, Convert.ToDouble(importe));
					}else{
						connF.GuardaFactura(principal.idUsuario, "HENNIGES TIEMPO EXTRA", FechaInicio, FechaCorte, Convert.ToDouble(importe));
					}
				}	
				if(Convert.ToDouble(importe3) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, "HENNIGES ESPECIALES", FechaInicio, FechaCorte, Convert.ToDouble(importe3));
					}else{
						connF.GuardaFactura(principal.idUsuario, "HENNIGES ESPECIALES", FechaInicio, FechaCorte, Convert.ToDouble(importe3));
					}
				}	
			}
			
			public void FormatoVITROFacturacion(String FechaInicio, String FechaCorte, DataGridView dtLuisNormales, DataGridView dtChuyNormales, 
			                                     TextBox txtSencilloLuis,
			   		   							 TextBox txtEntrada, TextBox txtSalida, TextBox txtSencilloChuy, 
			   		   							 TextBox txtEntradaChuy, TextBox txtSalidaChuy, 
			   		   							 Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                     String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
	 			
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD ));
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				document.Add(espacio);
				
				float[] widths = new float[] {235f, 235f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
								
				float[] widths1 = new float[] {50f, 50f, 50f};
				PdfPTable nested = new PdfPTable(3);
				nested.SetWidths(widths1);
				
				nested.AddCell(PDFs.TitWhite115308("LAR"));
				    nested.AddCell(PDFs.TitWhite115308("."));
				    nested.AddCell(PDFs.TitWhite115308("."));
				    
				    nested.AddCell(PDFs.TitWhite115308("Fechas"));
				    nested.AddCell(PDFs.TitWhite115308("Sencillos"));
				    nested.AddCell(PDFs.TitWhite115308("Completos"));
				    
		   		    for(int y = 0; y<(dtLuisNormales.RowCount); y++)
					{
						nested.AddCell(PDFs.TexWhite115107(""+dtLuisNormales.Rows[y].Cells[0].Value));
						nested.AddCell(PDFs.TexWhite115107(""+dtLuisNormales.Rows[y].Cells[1].Value));
						nested.AddCell(PDFs.TexWhite115107(""+dtLuisNormales.Rows[y].Cells[2].Value));
					}	
		   		    
				PdfPCell nesthousing = new PdfPCell(nested);
				nesthousing.Padding = 0f;
				tableC.AddCell(nesthousing);
				
				float[] widths12 = new float[] {50f, 50f, 50f};
				PdfPTable nested2 = new PdfPTable(3);
				nested2.SetWidths(widths12);
				
				nested2.AddCell(PDFs.TitWhite115308("VITRO"));
				    nested2.AddCell(PDFs.TitWhite115308("."));
				    nested2.AddCell(PDFs.TitWhite115308("."));
				    nested2.AddCell(PDFs.TitWhite115308("Fechas"));
				    nested2.AddCell(PDFs.TitWhite115308("Sencillos"));
				    nested2.AddCell(PDFs.TitWhite115308("Completos"));
				    
				    
		   		    for(int y = 0; y<(dtChuyNormales.RowCount); y++)
					{
						nested2.AddCell(PDFs.TexWhite115107(""+dtChuyNormales.Rows[y].Cells[0].Value));
						nested2.AddCell(PDFs.TexWhite115107(""+dtChuyNormales.Rows[y].Cells[1].Value));
						nested2.AddCell(PDFs.TexWhite115107(""+dtChuyNormales.Rows[y].Cells[2].Value));
					}	
		   		    
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				tableC.AddCell(nesthousing2);
				
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {470f};
				PdfPTable totales = new PdfPTable(1);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 2;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f, 50f, 50f, 50f};
				PdfPTable nested23 = new PdfPTable(4);
				nested23.SetWidths(widths4);
				
	   		    nested23.AddCell(PDFs.TitWhite115308("-"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Sencillos"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Entrada"));
	   		    nested23.AddCell(PDFs.TitWhite115308("Salida"));
	   		    nested23.AddCell(PDFs.TitWhite115308("LAR"));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSencilloLuis.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtEntrada.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSalida.Text));
	   		    nested23.AddCell(PDFs.TitWhite115308("VITRO"));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSencilloChuy.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtEntradaChuy.Text));
	   		    nested23.AddCell(PDFs.TexWhite115107(txtSalidaChuy.Text));
	   		    
				PdfPCell nesthousing23 = new PdfPCell(nested23);
				nesthousing23.Padding = 0f;
				totales.AddCell(nesthousing23);			
				document.Add(totales);
			}
			#endregion
			
			#region JABIL
			public void FormatoJABILFacturacion(String FechaInicio, String FechaCorte, DataGridView dataJabilP, DataGridView dataJabilA,
				                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
				                                      String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal, String Depto,
				                                      DataGridView dataTotalesJabil, DataGridView dataTotalesJabil2)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				PdfPCell headerBlanco = new PdfPCell(PDFs.TitWhite115308(""));
				headerBlanco.Colspan = 3;
				PdfPCell headerM = new PdfPCell(PDFs.TexWhite112106("Mañana"));
				headerM.Colspan = 2;
				PdfPCell headerMD = new PdfPCell(PDFs.TexWhite112106("Medio día"));
				headerMD.Colspan = 2;
				PdfPCell headerV = new PdfPCell(PDFs.TexWhite112106("Vesp."));
				headerV.Colspan = 2;
				PdfPCell headerN = new PdfPCell(PDFs.TexWhite112106("Nocturno"));
				headerN.Colspan = 2;
				
				float[] widths = new float[] {80f, 340f, 80f, 340f};
				PdfPTable tableC = new PdfPTable(4);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 4;
				tableC.AddCell(header);
				PdfPCell headerP = new PdfPCell(PDFs.EncWhite215209(Depto+" Camiones"));
				headerP.Colspan = 2;
				PdfPCell headerA = new PdfPCell(PDFs.EncWhite215209(Depto+" Camionetas"));
				headerA.Colspan = 2;
				tableC.AddCell(headerP);
				tableC.AddCell(headerA);
						
				for(contadorArray = 0; contadorArray<Datos.Length; contadorArray++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {100f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
					nested.AddCell(PDFs.TitWhite115308("Fecha"));
					nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
						
						float[] widths2 = new float[] {80f, 17f, 35f, 20f, 20f, 20f, 20f, 20f, 20f, 20f, 20f};
						PdfPTable bottom = new PdfPTable(11);
						bottom.SetWidths(widths2);
						bottom.AddCell(headerBlanco);
						bottom.AddCell(headerM);
						bottom.AddCell(headerMD);
						bottom.AddCell(headerV);
						bottom.AddCell(headerN);
						bottom.AddCell(PDFs.TitWhite115308("Ruta"));
						bottom.AddCell(PDFs.TitWhite115308("T"));
						bottom.AddCell(PDFs.TitWhite115308("KM"));
						bottom.AddCell(PDFs.TitWhite115308("E"));
						bottom.AddCell(PDFs.TitWhite115308("S"));
						bottom.AddCell(PDFs.TitWhite115308("E"));
						bottom.AddCell(PDFs.TitWhite115308("S"));
						bottom.AddCell(PDFs.TitWhite115308("E"));
						bottom.AddCell(PDFs.TitWhite115308("S"));
						bottom.AddCell(PDFs.TitWhite115308("E"));
						bottom.AddCell(PDFs.TitWhite115308("S"));
						
							for(int y = 0; y<(dataJabilP.RowCount); y++)
							{
								if((Convert.ToDateTime(Datos[contadorArray]).DayOfWeek.ToString())==(Convert.ToDateTime(dataJabilP.Rows[y].Cells[0].Value.ToString()).DayOfWeek.ToString()))
								{
									bottom.AddCell(PDFs.TexWhite112106(dataJabilP.Rows[y].Cells[1].Value.ToString()));
									if(dataJabilP.Rows[y].Cells[7].Value.ToString() == "1"){
										bottom.AddCell(PDFs.TexWhite112106("F"));
									}else{
										if(Convert.ToInt32(dataJabilP.Rows[y].Cells[6].Value) < 46)
											bottom.AddCell(PDFs.TexWhite112106("C"));
										else
											bottom.AddCell(PDFs.TexWhite112106("L"));
									}
									bottom.AddCell(PDFs.TexWhite112106(dataJabilP.Rows[y].Cells[6].Value.ToString()));
									
										if("Mañana"==dataJabilP.Rows[y].Cells[3].Value.ToString())
										{
											
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[4].Value));
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[5].Value));
											if(y<dataJabilP.RowCount-1)
											{
												if(dataJabilP.Rows[y].Cells[1].Value.ToString()==dataJabilP.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
											
										}
										else
										{
											bottom.AddCell(PDFs.TexWhite112106(""));
											bottom.AddCell(PDFs.TexWhite112106(""));
										}
										if("Medio día"==dataJabilP.Rows[y].Cells[3].Value.ToString())
										{
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[4].Value));
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[5].Value));
											if(y<dataJabilP.RowCount-1)
											{
												if(dataJabilP.Rows[y].Cells[1].Value.ToString()==dataJabilP.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
										}
										else
										{
											bottom.AddCell(PDFs.TexWhite112106(""));
											bottom.AddCell(PDFs.TexWhite112106(""));
										}
										if("Vespertino"==dataJabilP.Rows[y].Cells[3].Value.ToString())
										{
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[4].Value));
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[5].Value));
											if(y<dataJabilP.RowCount-1)
											{
												if(dataJabilP.Rows[y].Cells[1].Value.ToString()==dataJabilP.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
										}
										else
										{
											bottom.AddCell(PDFs.TexWhite112106(""));
											bottom.AddCell(PDFs.TexWhite112106(""));
										}
										if("Nocturno"==dataJabilP.Rows[y].Cells[3].Value.ToString())
										{
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[4].Value));
											bottom.AddCell(PDFs.TexWhite112106(""+dataJabilP.Rows[y].Cells[5].Value));
											if(y<dataJabilP.RowCount-1)
											{
												if(dataJabilP.Rows[y].Cells[1].Value.ToString()==dataJabilP.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
										}
										else
										{
											bottom.AddCell(PDFs.TexWhite112106(""));
											bottom.AddCell(PDFs.TexWhite112106(""));
										}
									}
								}
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						bottom.AddCell(PDFs.TexWhite112106(""));
						tableC.AddCell(bottom);
						
					float[] widths12 = new float[] {100f};
					PdfPTable nested2 = new PdfPTable(1);
					nested2.SetWidths(widths12);
					nested2.AddCell(PDFs.TitWhite115308("Fecha"));
					nested2.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing2 = new PdfPCell(nested2);
					nesthousing2.Padding = 0f;
					tableC.AddCell(nesthousing2);
						
						float[] widths22= new float[] {80f, 20f, 35f, 20f, 20f, 20f, 20f, 20f, 20f, 20f, 20f};
						PdfPTable bottom2 = new PdfPTable(11);
						bottom2.SetWidths(widths22);
						bottom2.AddCell(headerBlanco);
						bottom2.AddCell(headerM);
						bottom2.AddCell(headerMD);
						bottom2.AddCell(headerV);
						bottom2.AddCell(headerN);
						bottom2.AddCell(PDFs.TitWhite115308("Ruta"));
						bottom2.AddCell(PDFs.TitWhite115308("F"));
						bottom2.AddCell(PDFs.TitWhite115308("KM"));
						bottom2.AddCell(PDFs.TitWhite115308("E"));
						bottom2.AddCell(PDFs.TitWhite115308("S"));
						bottom2.AddCell(PDFs.TitWhite115308("E"));
						bottom2.AddCell(PDFs.TitWhite115308("S"));
						bottom2.AddCell(PDFs.TitWhite115308("E"));
						bottom2.AddCell(PDFs.TitWhite115308("S"));
						bottom2.AddCell(PDFs.TitWhite115308("E"));
						bottom2.AddCell(PDFs.TitWhite115308("S"));
						
							for(int y = 0; y<(dataJabilA.RowCount); y++)
							{
								if((Convert.ToDateTime(Datos[contadorArray]).DayOfWeek.ToString())==(Convert.ToDateTime(dataJabilA.Rows[y].Cells[0].Value.ToString()).DayOfWeek.ToString()))
								{
									bottom2.AddCell(PDFs.TexWhite112106(dataJabilA.Rows[y].Cells[1].Value.ToString()));
									if(dataJabilP.Rows[y].Cells[7].Value.ToString() == "1"){
										bottom2.AddCell(PDFs.TexWhite112106("F"));
									}else{
										if(Convert.ToInt32(dataJabilP.Rows[y].Cells[6].Value) < 46)
											bottom2.AddCell(PDFs.TexWhite112106("C"));
										else
											bottom2.AddCell(PDFs.TexWhite112106("L"));
									}
									bottom2.AddCell(PDFs.TexWhite112106(dataJabilA.Rows[y].Cells[6].Value.ToString()));
									
										if("Mañana"==dataJabilA.Rows[y].Cells[3].Value.ToString())
										{
											
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[4].Value));
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[5].Value));
											if(y<dataJabilA.RowCount-1)
											{
												if(dataJabilA.Rows[y].Cells[1].Value.ToString()==dataJabilA.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
											
										}
										else
										{
											bottom2.AddCell(PDFs.TexWhite112106(""));
											bottom2.AddCell(PDFs.TexWhite112106(""));
										}
										if("Medio día"==dataJabilA.Rows[y].Cells[3].Value.ToString())
										{
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[4].Value));
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[5].Value));
											if(y<dataJabilA.RowCount-1)
											{
												if(dataJabilA.Rows[y].Cells[1].Value.ToString()==dataJabilA.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
										}
										else
										{
											bottom2.AddCell(PDFs.TexWhite112106(""));
											bottom2.AddCell(PDFs.TexWhite112106(""));
										}
										if("Vespertino"==dataJabilA.Rows[y].Cells[3].Value.ToString())
										{
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[4].Value));
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[5].Value));
											if(y<dataJabilA.RowCount-1)
											{
												if(dataJabilA.Rows[y].Cells[1].Value.ToString()==dataJabilA.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
										}
										else
										{
											bottom2.AddCell(PDFs.TexWhite112106(""));
											bottom2.AddCell(PDFs.TexWhite112106(""));
										}
										if("Nocturno"==dataJabilA.Rows[y].Cells[3].Value.ToString())
										{
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[4].Value));
											bottom2.AddCell(PDFs.TexWhite112106(""+dataJabilA.Rows[y].Cells[5].Value));
											if(y<dataJabilA.RowCount-1)
											{
												if(dataJabilA.Rows[y].Cells[1].Value.ToString()==dataJabilA.Rows[y+1].Cells[1].Value.ToString())
													y = y + 1;
											}
										}
										else
										{
											bottom2.AddCell(PDFs.TexWhite112106(""));
											bottom2.AddCell(PDFs.TexWhite112106(""));
										}
									}
								}
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						bottom2.AddCell(PDFs.TexWhite112106(""));
						tableC.AddCell(bottom2);
				}
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {20f, 215f, 20f, 215f};
				PdfPTable totales = new PdfPTable(4);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 4;
				totales.AddCell(header2);
	   		    totales.AddCell(PDFs.VerWhite115307("Camiones"));

	   		    
	   		    double totalF = ( Convert.ToDouble(dataTotalesJabil.Rows[0].Cells[3].Value) + Convert.ToDouble(dataTotalesJabil.Rows[1].Cells[3].Value) +
				                                         Convert.ToDouble(dataTotalesJabil.Rows[2].Cells[3].Value) + Convert.ToDouble(dataTotalesJabil.Rows[3].Cells[3].Value) + 
				                                         Convert.ToDouble(dataTotalesJabil.Rows[4].Cells[3].Value) + Convert.ToDouble(dataTotalesJabil.Rows[5].Cells[3].Value) );
				float[] widths5 = new float[] {80f, 40f, 40f, 40f};
				PdfPTable bottom20 = new PdfPTable(4);
				bottom20.SetWidths(widths5);
				bottom20.AddCell(PDFs.TitWhite115308("Tipo Ruta"));
				bottom20.AddCell(PDFs.TitWhite115308("# Viajes"));
				bottom20.AddCell(PDFs.TitWhite115308("P. Uni"));
				bottom20.AddCell(PDFs.TitWhite115308("Importe"));
				bottom20.AddCell(PDFs.TitWhite114308("Larga Sencilla"));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[0].Cells[1].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[0].Cells[2].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[0].Cells[3].Value.ToString()));
				bottom20.AddCell(PDFs.TitWhite114308("Larga Completa"));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[1].Cells[1].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[1].Cells[2].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[1].Cells[3].Value.ToString()));
				bottom20.AddCell(PDFs.TitWhite114308("Corta Sencilla"));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[2].Cells[1].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[2].Cells[2].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[2].Cells[3].Value.ToString()));
				bottom20.AddCell(PDFs.TitWhite114308("Corta Completa"));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[3].Cells[1].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[3].Cells[2].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[3].Cells[3].Value.ToString()));
				bottom20.AddCell(PDFs.TitWhite114308("Foranea Sencilla"));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[4].Cells[1].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[4].Cells[2].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[4].Cells[3].Value.ToString()));
				bottom20.AddCell(PDFs.TitWhite114308("Foranea Completa"));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[5].Cells[1].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[5].Cells[2].Value.ToString()));
				bottom20.AddCell(PDFs.TexWhite115107(dataTotalesJabil.Rows[5].Cells[3].Value.ToString()));
				
				PdfPCell headerBlancoo = new PdfPCell(PDFs.Enclgray215209SinBorde(""));
				headerBlancoo.Colspan = 2;
				
				bottom20.AddCell(headerBlancoo);
				bottom20.AddCell(PDFs.TitWhite114308("Subtotal"));
				bottom20.AddCell(PDFs.TexWhite115107( (Math.Round(totalF,2)).ToString() ));
				bottom20.AddCell(headerBlancoo);
				bottom20.AddCell(PDFs.TitWhite114308("IVA 16%"));
				bottom20.AddCell(PDFs.TexWhite115107( (Math.Round( (totalF * .16) ,2)).ToString() ));
				bottom20.AddCell(headerBlancoo);
				bottom20.AddCell(PDFs.TitWhite114308("Total"));
				bottom20.AddCell(PDFs.TexWhite115107( (Math.Round( (totalF * 1.16) ,2)).ToString() ));
				totales.AddCell(bottom20);
				
				totales.AddCell(PDFs.VerWhite115307("Camionetas"));
				double totalFCamioneta = ( Convert.ToDouble(dataTotalesJabil2.Rows[0].Cells[3].Value) + Convert.ToDouble(dataTotalesJabil2.Rows[1].Cells[3].Value) +
                                  Convert.ToDouble(dataTotalesJabil2.Rows[2].Cells[3].Value) + Convert.ToDouble(dataTotalesJabil2.Rows[3].Cells[3].Value) + 
                                  Convert.ToDouble(dataTotalesJabil2.Rows[4].Cells[3].Value) + Convert.ToDouble(dataTotalesJabil2.Rows[5].Cells[3].Value) );
				float[] widths6 = new float[] {80f, 40f, 40f, 40f};
				PdfPTable bottom21 = new PdfPTable(4);
				bottom21.SetWidths(widths6);
				bottom21.AddCell(PDFs.TitWhite115308("Tipo Ruta"));
				bottom21.AddCell(PDFs.TitWhite115308("# Viajes"));
				bottom21.AddCell(PDFs.TitWhite115308("P. Uni"));
				bottom21.AddCell(PDFs.TitWhite115308("Importe"));
				bottom21.AddCell(PDFs.TitWhite114308("Larga Sencilla"));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[0].Cells[1].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[0].Cells[2].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[0].Cells[3].Value.ToString()));
				bottom21.AddCell(PDFs.TitWhite114308("Larga Completa"));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[1].Cells[1].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[1].Cells[2].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[1].Cells[3].Value.ToString()));
				bottom21.AddCell(PDFs.TitWhite114308("Corta Sencilla"));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[2].Cells[1].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[2].Cells[2].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[2].Cells[3].Value.ToString()));
				bottom21.AddCell(PDFs.TitWhite114308("Corta Completa"));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[3].Cells[1].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[3].Cells[2].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[3].Cells[3].Value.ToString()));
				bottom21.AddCell(PDFs.TitWhite114308("Foranea Sencilla"));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[4].Cells[1].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[4].Cells[2].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[4].Cells[3].Value.ToString()));
				bottom21.AddCell(PDFs.TitWhite114308("Foranea Completa"));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[5].Cells[1].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[5].Cells[2].Value.ToString()));
				bottom21.AddCell(PDFs.TexWhite115107(dataTotalesJabil2.Rows[5].Cells[3].Value.ToString()));
				
				bottom21.AddCell(headerBlancoo);
				bottom21.AddCell(PDFs.TitWhite114308("Subtotal"));
				bottom21.AddCell(PDFs.TexWhite115107( (Math.Round(totalFCamioneta,2)).ToString() ));				
				bottom21.AddCell(headerBlancoo);
				bottom21.AddCell(PDFs.TitWhite114308("IVA 16%"));
				bottom21.AddCell(PDFs.TexWhite115107( (Math.Round( (totalFCamioneta * .16) ,2)).ToString() ));				
				bottom21.AddCell(headerBlancoo);
				bottom21.AddCell(PDFs.TitWhite114308("Total"));
				bottom21.AddCell(PDFs.TexWhite115107( (Math.Round( (totalFCamioneta * 1.16) ,2)).ToString() ));
				totales.AddCell(bottom21);
				
				document.Add(totales);
			}
			
			public void FormatoJABILFacturacionTotales(String FechaInicio, String FechaCorte, DataGridView dataJabilP, DataGridView dataJabilA,
				                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
				                                      String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal, String Depto,
				                                      DataGridView dataTotalesJabil, DataGridView dataTotalesJabil2)
			{				
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				
				document.NewPage();
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				PdfPCell headerBlanco = new PdfPCell(PDFs.Enclgray215209SinBorde(""));
				headerBlanco.Colspan = 2;
				PdfPCell headerM = new PdfPCell(PDFs.Enclgray215209("Facturación"));
				headerM.Colspan = 6;
			
				float[] widthsT1 = new float[] {45f, 85f, 85f, 85f, 85f, 85f};
				PdfPTable table1 = new PdfPTable(6);
				table1.SetWidths(widthsT1);
				table1.TotalWidth = 470f;
				
				table1.AddCell(headerM);
				
				table1.AddCell(PDFs.TitWhite115308FondoGris("Turno"));
				table1.AddCell(PDFs.TitWhite115308FondoGris("Advance"));
				table1.AddCell(PDFs.TitWhite115308FondoGris("Shenk"));
				table1.AddCell(PDFs.TitWhite115308FondoGris("Mega"));
				table1.AddCell(PDFs.TitWhite115308FondoGris("Poblacion Circuit"));
				table1.AddCell(PDFs.TitWhite115308FondoGris("Total Poblaciones"));
				
			
				table1.AddCell(PDFs.TitWhite115308("1"));				
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));
				
				table1.AddCell(PDFs.TitWhite115308("2"));				
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));
				
				table1.AddCell(PDFs.TitWhite115308("3"));				
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));
				
				table1.AddCell(PDFs.TitWhite115308("4"));				
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));			
				table1.AddCell(PDFs.TexWhite115107(" "));
				
				document.Add(espacio);
				document.Add(table1);
				
				float[] widthsT2 = new float[] {45f, 85f, 85f, 85f, 85f, 85f};
				PdfPTable table2 = new PdfPTable(6);
				table2.SetWidths(widthsT2);
				table2.TotalWidth = 470f;
								
				table2.AddCell(PDFs.TitWhite115308FondoGris("Turno"));
				table2.AddCell(PDFs.TitWhite115308FondoGris("% Advanced"));
				table2.AddCell(PDFs.TitWhite115308FondoGris("% Circuit"));
				table2.AddCell(PDFs.TitWhite115308FondoGris("$ Advanced"));
				table2.AddCell(PDFs.TitWhite115308FondoGris("$ Circuit"));
				table2.AddCell(PDFs.TitWhite115308FondoGris("$ Factura General"));
				
			
				table2.AddCell(PDFs.TitWhite115308("1"));				
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));		
				table2.AddCell(PDFs.TexWhite115107(" "));		
			
				table2.AddCell(PDFs.TitWhite115308("2"));				
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));
			
				table2.AddCell(PDFs.TitWhite115308("3"));				
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));
			
				table2.AddCell(PDFs.TitWhite115308("4"));				
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));	
				
				table2.AddCell(headerBlanco);				
				table2.AddCell(PDFs.TitWhite115308FondoGris("Sub-Total"));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));
				
				table2.AddCell(headerBlanco);				
				table2.AddCell(PDFs.TitWhite115308FondoGris("IVA"));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));
				
				table2.AddCell(headerBlanco);				
				table2.AddCell(PDFs.TitWhite115308FondoGris("Total"));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));			
				table2.AddCell(PDFs.TexWhite115107(" "));
				
				document.Add(table2);
				document.Add(espacio);

			}
			#endregion
			
			#region PLEXUS
			public void FormatoPLEXUSFacturacion(String FechaInicio, String FechaCorte, TextBox txtCamionLocal, TextBox txtCamionForaneo, 
			                                     TextBox txtCamionetaLocal, TextBox txtCamionetaForaneo,
			                                      Document document, Label lblEmpresa,
			                                      String DiaFacturacion, PdfWriter writer, Interfaz.FormPrincipal principal,
			                                     DataGridView dtCamionLocal, DataGridView dtCamionForaneo, 
			                                     DataGridView dtCamionetaLocal, DataGridView dtCamionetaForaneo, DataGridView dtDetalle)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				float[] widths = new float[] {20f, 400f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.VerWhite115307("CAMIÓN\nLOCAL"));
				tableC.AddCell(header);
				
				float[] widths2 = new float[] {100f, 40f, 40f, 81f, 81f, 81f};
				PdfPTable bottom = new PdfPTable(6);
				bottom.SetWidths(widths2);
				bottom.AddCell(PDFs.TitWhite115308("Tipo"));
				bottom.AddCell(PDFs.TitWhite115308("Minimo"));
				bottom.AddCell(PDFs.TitWhite115308("Maximo"));
				bottom.AddCell(PDFs.TitWhite115308("Cantidad"));
				bottom.AddCell(PDFs.TitWhite115308("Importe"));
				bottom.AddCell(PDFs.TitWhite115308("Total"));
					
					for(int y = 0; y<(dtCamionLocal.RowCount); y++)
					{
						bottom.AddCell(PDFs.TexWhite115107(""+dtCamionLocal.Rows[y].Cells[0].Value));
						bottom.AddCell(PDFs.TexWhite115107(""+dtCamionLocal.Rows[y].Cells[1].Value));
						bottom.AddCell(PDFs.TexWhite115107(""+dtCamionLocal.Rows[y].Cells[2].Value));
						bottom.AddCell(PDFs.TexWhite115107(dtCamionLocal.Rows[y].Cells[3].Value.ToString()));
						bottom.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionLocal.Rows[y].Cells[4].Value).ToString("C")));
						bottom.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionLocal.Rows[y].Cells[5].Value).ToString("C")));
					}	
				bottom.AddCell(PDFs.TexWhite115107(""));
				bottom.AddCell(PDFs.TexWhite115107(""));
				bottom.AddCell(PDFs.TexWhite115107(""));
				bottom.AddCell(PDFs.TexWhite115107(""));
				bottom.AddCell(PDFs.TexWhite115107(""));
				bottom.AddCell(PDFs.TexWhite115107(Convert.ToDouble(txtCamionLocal.Text).ToString("C")));
				tableC.AddCell(bottom);
				document.Add(tableC);
				
				//document.Add(new Paragraph(espacio));
				
				float[] widths12 = new float[] {20f, 400f};
				PdfPTable tableC2 = new PdfPTable(2);
				tableC2.SetWidths(widths12);
				tableC2.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.VerWhite115307("CAMIÓN\nFORANEO"));
				tableC2.AddCell(header2);
				
				float[] widths22 = new float[] {100f, 40f, 40f, 81f, 81f, 81f};
				PdfPTable bottom2 = new PdfPTable(6);
				bottom2.SetWidths(widths2);
				bottom2.AddCell(PDFs.TitWhite115308("Tipo"));
				bottom2.AddCell(PDFs.TitWhite115308("Minimo"));
				bottom2.AddCell(PDFs.TitWhite115308("Maximo"));
				bottom2.AddCell(PDFs.TitWhite115308("Cantidad"));
				bottom2.AddCell(PDFs.TitWhite115308("Importe"));
				bottom2.AddCell(PDFs.TitWhite115308("Total"));
					
					for(int y = 0; y<(dtCamionForaneo.RowCount); y++)
					{
						bottom2.AddCell(PDFs.TexWhite115107(""+dtCamionForaneo.Rows[y].Cells[0].Value));
						bottom2.AddCell(PDFs.TexWhite115107(""+dtCamionForaneo.Rows[y].Cells[1].Value));
						bottom2.AddCell(PDFs.TexWhite115107(""+dtCamionForaneo.Rows[y].Cells[2].Value));
						bottom2.AddCell(PDFs.TexWhite115107(dtCamionForaneo.Rows[y].Cells[3].Value.ToString()));
						bottom2.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionForaneo.Rows[y].Cells[4].Value).ToString("C")));
						bottom2.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionForaneo.Rows[y].Cells[5].Value).ToString("C")));
					}	
				bottom2.AddCell(PDFs.TexWhite115107(""));
				bottom2.AddCell(PDFs.TexWhite115107(""));
				bottom2.AddCell(PDFs.TexWhite115107(""));
				bottom2.AddCell(PDFs.TexWhite115107(""));
				bottom2.AddCell(PDFs.TexWhite115107(""));
				bottom2.AddCell(PDFs.TexWhite115107(Convert.ToDouble(txtCamionForaneo.Text).ToString("C")));
				tableC2.AddCell(bottom2);
				document.Add(tableC2);
				
				//document.Add(new Paragraph(espacio));
				
				float[] widths13 = new float[] {20f, 400f};
				PdfPTable tableC3 = new PdfPTable(2);
				tableC3.SetWidths(widths13);
				tableC3.TotalWidth = 470f;
				PdfPCell header3 = new PdfPCell(PDFs.VerWhite115307("CAMIONETA\nLOCAL"));
				tableC3.AddCell(header3);
				
				float[] widths33 = new float[] {100f, 40f, 40f, 81f, 81f, 81f};
				PdfPTable bottom3 = new PdfPTable(6);
				bottom3.SetWidths(widths33);
				bottom3.AddCell(PDFs.TitWhite115308("Tipo"));
				bottom3.AddCell(PDFs.TitWhite115308("Minimo"));
				bottom3.AddCell(PDFs.TitWhite115308("Maximo"));
				bottom3.AddCell(PDFs.TitWhite115308("Cantidad"));
				bottom3.AddCell(PDFs.TitWhite115308("Importe"));
				bottom3.AddCell(PDFs.TitWhite115308("Total"));
					
					for(int y = 0; y<(dtCamionetaLocal.RowCount); y++)
					{
						bottom3.AddCell(PDFs.TexWhite115107(""+dtCamionetaLocal.Rows[y].Cells[0].Value));
						bottom3.AddCell(PDFs.TexWhite115107(""+dtCamionetaLocal.Rows[y].Cells[1].Value));
						bottom3.AddCell(PDFs.TexWhite115107(""+dtCamionetaLocal.Rows[y].Cells[2].Value));
						bottom3.AddCell(PDFs.TexWhite115107(dtCamionetaLocal.Rows[y].Cells[3].Value.ToString()));
						bottom3.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionetaLocal.Rows[y].Cells[4].Value).ToString("C")));
						bottom3.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionetaLocal.Rows[y].Cells[5].Value).ToString("C")));
					}	
				bottom3.AddCell(PDFs.TexWhite115107(""));
				bottom3.AddCell(PDFs.TexWhite115107(""));
				bottom3.AddCell(PDFs.TexWhite115107(""));
				bottom3.AddCell(PDFs.TexWhite115107(""));
				bottom3.AddCell(PDFs.TexWhite115107(""));
				bottom3.AddCell(PDFs.TexWhite115107(Convert.ToDouble(txtCamionetaLocal.Text).ToString("C")));
				tableC3.AddCell(bottom3);
				document.Add(tableC3);
				
				//document.Add(new Paragraph(espacio));
				
				float[] widths14 = new float[]{20f, 400f};
				PdfPTable tableC4 = new PdfPTable(2);
				tableC4.SetWidths(widths14);
				tableC4.TotalWidth = 470f;
				PdfPCell header4 = new PdfPCell(PDFs.VerWhite115307("CAMIONETA\nFORANEA"));
				tableC4.AddCell(header4);
				
				float[] widths44 = new float[] {100f, 40f, 40f, 81f, 81f, 81f};
				PdfPTable bottom4 = new PdfPTable(6);
				bottom4.SetWidths(widths44);
				bottom4.AddCell(PDFs.TitWhite115308("Tipo"));
				bottom4.AddCell(PDFs.TitWhite115308("Minimo"));
				bottom4.AddCell(PDFs.TitWhite115308("Maximo"));
				bottom4.AddCell(PDFs.TitWhite115308("Cantidad"));
				bottom4.AddCell(PDFs.TitWhite115308("Importe"));
				bottom4.AddCell(PDFs.TitWhite115308("Total"));
					
					for(int y = 0; y<(dtCamionetaForaneo.RowCount); y++)
					{
						bottom4.AddCell(PDFs.TexWhite115107(""+dtCamionetaForaneo.Rows[y].Cells[0].Value));
						bottom4.AddCell(PDFs.TexWhite115107(""+dtCamionetaForaneo.Rows[y].Cells[1].Value));
						bottom4.AddCell(PDFs.TexWhite115107(""+dtCamionetaForaneo.Rows[y].Cells[2].Value));
						bottom4.AddCell(PDFs.TexWhite115107(dtCamionetaForaneo.Rows[y].Cells[3].Value.ToString()));
						bottom4.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionetaForaneo.Rows[y].Cells[4].Value).ToString("C")));
						bottom4.AddCell(PDFs.TexWhite115107(Convert.ToDouble(dtCamionetaForaneo.Rows[y].Cells[5].Value).ToString("C")));
					}	
					
					bottom4.AddCell(PDFs.TexWhite115107(""));
					bottom4.AddCell(PDFs.TexWhite115107(""));
					bottom4.AddCell(PDFs.TexWhite115107(""));
					bottom4.AddCell(PDFs.TexWhite115107(""));
					bottom4.AddCell(PDFs.TexWhite115107(""));
					bottom4.AddCell(PDFs.TexWhite115107(Convert.ToDouble(txtCamionetaForaneo.Text).ToString("C")));
				
				tableC4.AddCell(bottom4);
				document.Add(tableC4);
				
				document.Add(new Paragraph(espacio));
				
				float[] widthsDetalle = new float[] {20f, 400f};
				PdfPTable tableDetalle = new PdfPTable(2);
				tableDetalle.SetWidths(widthsDetalle);
				tableDetalle.TotalWidth = 470f;
				PdfPCell headerDetalle = new PdfPCell(PDFs.VerWhite115307("DETALLE DE\nLOS VIAJES"));
				tableDetalle.AddCell(headerDetalle);
				
				float[] widthsDetalle2 = new float[] {197f, 60f, 70f, 46f, 25f, 25f};
				PdfPTable tableDetalle2 = new PdfPTable(6);
				tableDetalle2.SetWidths(widthsDetalle2);
				tableDetalle2.AddCell(PDFs.TitWhite115308("Ruta"));
				tableDetalle2.AddCell(PDFs.TitWhite115308("Tipo"));
				tableDetalle2.AddCell(PDFs.TitWhite115308("Vehiculo"));
				tableDetalle2.AddCell(PDFs.TitWhite115308("Distancia"));
				tableDetalle2.AddCell(PDFs.TitWhite115308("Km"));
				tableDetalle2.AddCell(PDFs.TitWhite115308("Cant"));
					
					for(int y = 0; y<(dtDetalle.RowCount); y++)
					{
						tableDetalle2.AddCell(PDFs.TexWhite115107(dtDetalle.Rows[y].Cells[0].Value.ToString()));
						tableDetalle2.AddCell(PDFs.TexWhite115107(dtDetalle.Rows[y].Cells[1].Value.ToString()));
						tableDetalle2.AddCell(PDFs.TexWhite115107(dtDetalle.Rows[y].Cells[2].Value.ToString()));
						tableDetalle2.AddCell(PDFs.TexWhite115107(dtDetalle.Rows[y].Cells[3].Value.ToString()));
						tableDetalle2.AddCell(PDFs.TexWhite115107(dtDetalle.Rows[y].Cells[4].Value.ToString()));
						tableDetalle2.AddCell(PDFs.TexWhite115107(dtDetalle.Rows[y].Cells[5].Value.ToString()));
					}	
				
				tableDetalle.AddCell(tableDetalle2);
				document.Add(tableDetalle);
			}
			#endregion
			
			#region CARESTREAM
			public void FormatoGeneralFacturacionCarestream(String FechaInicio, String FechaCorte, DataGridView dtTotales, TextBox txtCamionetasS, 
			                                      TextBox txtCamionetasC, TextBox txtCamionesS, TextBox txtCamionesC,
			                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                      String DiaFacturacion, DataGridView dataViajesNormales, 
			                                      DataGridView dtViajesEstandarExtras, PdfWriter writer, Interfaz.FormPrincipal principal,
			                                      DataGridView dataCONVER)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				int ContadorForsac = 0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				
				float[] widths = new float[] {50f, 370f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
						
				//Datos = formFacturacion.RetornoArregloFecha();
			
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0;
				double TCc = 0.0, TCM = 0.0, TCN = 0.0, CSc = 0.0;
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {100f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
					nested.AddCell(PDFs.TitWhite115308("Fecha"));
					nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {40f, 87f, 81f, 81f, 81f, 50f};
					PdfPTable bottom = new PdfPTable(6);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115308("Horario"));
					bottom.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
					bottom.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
					bottom.AddCell(PDFs.TitWhite115308("Camiones Completos"));
					bottom.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
					bottom.AddCell(PDFs.TitWhite115308("Precio"));
						
						for(int y = 0; y<(dtTotales.RowCount); y++)
						{
							if(Datos[contadorArray]==dtTotales.Rows[y].Cells[1].Value.ToString())
							{
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[2].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[3].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[4].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[5].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[6].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[11].Value));
								
								Cc += Convert.ToDouble(dtTotales.Rows[y].Cells[7].Value);
								Cs += Convert.ToDouble(dtTotales.Rows[y].Cells[8].Value);
								Tc += Convert.ToDouble(dtTotales.Rows[y].Cells[9].Value);
								Ts += Convert.ToDouble(dtTotales.Rows[y].Cells[10].Value);
								
								if(dtTotales.Rows[y].Cells[2].Value.ToString() != "Medio día")
									TCc += Convert.ToDouble(dtTotales.Rows[y].Cells[3].Value);
								if(dtTotales.Rows[y].Cells[2].Value.ToString() == "Medio día")
									TCM += Convert.ToDouble(dtTotales.Rows[y].Cells[3].Value);
								if(dtTotales.Rows[y].Cells[2].Value.ToString() == "Nocturno")
									TCN += Convert.ToDouble(dtTotales.Rows[y].Cells[4].Value);
								if(dtTotales.Rows[y].Cells[2].Value.ToString() != "Nocturno")
									CSc += Convert.ToDouble(dtTotales.Rows[y].Cells[4].Value);
							}
						}	
						++contadorArray;
		
						tableC.AddCell(bottom);
				}
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {70f, 330f,70f,};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
	   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
	
				float[] widths5 = new float[] {105f, 105f, 105f, 105f};
				PdfPTable bottom2 = new PdfPTable(4);
				bottom2.SetWidths(widths5);
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Completas M"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Sencillos N"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Sencillos"));
				bottom2.AddCell(PDFs.TexWhite115107(TCc.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(TCM.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(TCN.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(CSc.ToString()));
//				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasC.Text));
//				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasS.Text));
//				bottom2.AddCell(PDFs.TexWhite115107((Convert.ToDouble(txtCamionesC.Text)-ContadorForsac).ToString()));
//				bottom2.AddCell(PDFs.TexWhite115107(txtCamionesS.Text));
								
				double TcM = 0.0, TcNORMAL = 0.0, TcN2 = 0.0, Cs2 = 0.0;
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["TURNO"].ToString().Equals("Medio día"))
						TcM = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["TURNO"].ToString().Equals("Nocturno"))
						TcN2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["TURNO"].ToString().Equals("Mañana"))
						TcNORMAL = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION"))
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]);
				}
				conn.conexion.Close();
				
				bottom2.AddCell(PDFs.TexWhite115107(TcNORMAL.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(TcM.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(TcN2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs2.ToString()));
				totales.AddCell(bottom2);
				
				// TOTALES PRECIO
				float[] widths44 = new float[] {50f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);	
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215206("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts).ToString()));
				nested22.AddCell(TotalTRimsa);				
				totales.AddCell(nested22);	
							
				PdfPTable Extras = new PdfPTable(1);
				Extras.TotalWidth = 470f;
				PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS"));
				headerExtras.Colspan = 2;
				Extras.AddCell(headerExtras);
				
				float[] widthsExtras = new float[] {50f, 40f, 200f, 65f, 65f};
				PdfPTable ContenidoExtras = new PdfPTable(5);
				ContenidoExtras.SetWidths(widthsExtras);
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
				for(int y = 0; y<(dtViajesEstandarExtras.RowCount); y++)
					{
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[0].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[1].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[2].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[3].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[4].Value));
					}
				Extras.AddCell(ContenidoExtras);
				
				if(dtViajesEstandarExtras.RowCount>0)
				{
					document.Add(Extras);
				}
				
				document.Add(new Paragraph(espacio));
				document.Add(totales);
								
				if(dtViajesEstandarExtras.RowCount>0)
				{
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
					document.Add(new Paragraph("                  están contabilizadas en la tabla de totales"));
				}
							
				
				if((Cc + Cs + Tc + Ts) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}
				}
			}
			#endregion
			
			#region GENERAL
			public void FormatoGeneralFacturacionLiverpool(String FechaInicio, String FechaCorte, DataGridView dtTotales, TextBox txtCamionetasS, 
			                                      TextBox txtCamionetasC, TextBox txtCamionesS, TextBox txtCamionesC,
			                                      Document document, Label lblEmpresa, String[] Datos, String FechaPDF,
			                                      String DiaFacturacion, DataGridView dataViajesNormales, 
			                                      DataGridView dtViajesEstandarExtras, PdfWriter writer, Interfaz.FormPrincipal principal,
			                                      DataGridView dataCONVER, TextBox txtCamionesSF)
			{
				writer.PageEvent = new PDFooterFactura(principal.lblDatoUsuario.Text);
				
				int contadorArray=0;
				//int ContadorForsac = 0;
				String DiaNomina1 = "";
				String DiaNomina2 = "";
				this.formFacturacion = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(principal);
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
				DiaNomina1 = formFacturacion.DiaFactura(FechaInicio);
				DiaNomina2 = formFacturacion.DiaFactura(FechaCorte);
				document.Add(PDFs.LogoFactura(writer)); 
				
				float[] widthsD = new float[]{48f, 144f};
				PdfPTable TablaDatos = new PdfPTable(2);
				TablaDatos.SetWidths(widthsD);
				TablaDatos.WidthPercentage = 40;
				TablaDatos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
				TablaDatos.AddCell(PDFs.Blanco(""));
				TablaDatos.AddCell(PDFs.TitWhite115308(DiaNomina1 +" "+ FechaInicio +" al "+DiaNomina2 +" "+ FechaCorte));
				document.Add(espacio);
				document.Add(TablaDatos);
				document.Add(espacio);
				
				
				float[] widths = new float[] {50f, 370f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 470f;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209(lblEmpresa.Text));
				header.Colspan = 2;
				tableC.AddCell(header);
						
				//Datos = formFacturacion.RetornoArregloFecha();
			
				double Cc = 0.0, Cs = 0.0, Tc = 0.0, Ts = 0.0;
				for(int z = 0; z<Datos.Length; z++)
				{
					FechaPDF = Datos[contadorArray];
					DiaFacturacion = formFacturacion.DiaFactura(FechaPDF);
					float[] widths1 = new float[] {100f};
					PdfPTable nested = new PdfPTable(1);
					nested.SetWidths(widths1);
					nested.AddCell(PDFs.TitWhite115308("Fecha"));
					nested.AddCell(PDFs.TitWhite115308(DiaFacturacion + " " + Datos[contadorArray]));
					PdfPCell nesthousing = new PdfPCell(nested);
					nesthousing.Padding = 0f;
					tableC.AddCell(nesthousing);
					
					float[] widths2 = new float[] {40f, 87f, 81f, 81f, 81f, 50f};
					PdfPTable bottom = new PdfPTable(6);
					bottom.SetWidths(widths2);
					bottom.AddCell(PDFs.TitWhite115308("Horario"));
					bottom.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
					bottom.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
					bottom.AddCell(PDFs.TitWhite115308("Camiones Completos"));
					bottom.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
					bottom.AddCell(PDFs.TitWhite115308("Precio"));
						
						for(int y = 0; y<(dtTotales.RowCount); y++)
						{
							if(Datos[contadorArray]==dtTotales.Rows[y].Cells[1].Value.ToString())
							{
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[2].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[3].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[4].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[5].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[6].Value));
								bottom.AddCell(PDFs.TexWhite115107(""+dtTotales.Rows[y].Cells[11].Value));
								
								Cc += Convert.ToDouble(dtTotales.Rows[y].Cells[7].Value);
								Cs += Convert.ToDouble(dtTotales.Rows[y].Cells[8].Value);
								Tc += Convert.ToDouble(dtTotales.Rows[y].Cells[9].Value);
								Ts += Convert.ToDouble(dtTotales.Rows[y].Cells[10].Value);
							}
						}	
						++contadorArray;
		
						tableC.AddCell(bottom);
				}
				document.Add(tableC);
				
				document.Add(new Paragraph(espacio));
				
				float[] widths3 = new float[] {70f, 330f,70f,};
				PdfPTable totales = new PdfPTable(3);
				totales.SetWidths(widths3);
				totales.TotalWidth = 470f;
				PdfPCell header2 = new PdfPCell(PDFs.Enclgray215209("TOTALES"));
				header2.Colspan = 3;
				totales.AddCell(header2);
						
				float[] widths4 = new float[] {50f};
				PdfPTable nested2 = new PdfPTable(1);
				nested2.SetWidths(widths4);
	   		    nested2.AddCell(PDFs.TitWhite115308("Total Final"));
				PdfPCell nesthousing2 = new PdfPCell(nested2);
				nesthousing2.Padding = 0f;
				totales.AddCell(nesthousing2);
	
				float[] widths5 = new float[] {105f, 105f, 105f, 105f};
				PdfPTable bottom2 = new PdfPTable(4);
				bottom2.SetWidths(widths5);
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Completas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camionetas Sencillas"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Sencillos F"));
				bottom2.AddCell(PDFs.TitWhite115308("Camiones Sencillos"));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasC.Text));
				bottom2.AddCell(PDFs.TexWhite115107(txtCamionetasS.Text));
				bottom2.AddCell(PDFs.TexWhite115107( txtCamionesSF.Text));
				bottom2.AddCell(PDFs.TexWhite115107( (Convert.ToDouble(txtCamionesS.Text) - (Convert.ToDouble(txtCamionesSF.Text)) ).ToString()));
								
				double Tc2 = 0.0, Ts2 = 0.0, Cc2 = 0.0, Cs2 = 0.0;
				string consulta = "select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+lblEmpresa.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["SENTIDO"].ToString().Equals("Completo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA")  && conn.leer["FORANEA"].ToString().Equals("NO"))
						Tc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMIONETA") && conn.leer["FORANEA"].ToString().Equals("NO"))
						Ts2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION") && conn.leer["FORANEA"].ToString().Equals("SI"))
						Cc2 = Convert.ToDouble(conn.leer["PRECIO"]);
					if(conn.leer["SENTIDO"].ToString().Equals("Sencillo") && conn.leer["VEHICULO"].ToString().Equals("CAMION") && conn.leer["FORANEA"].ToString().Equals("NO"))
						Cs2 = Convert.ToDouble(conn.leer["PRECIO"]);
				}
				conn.conexion.Close();
				
				bottom2.AddCell(PDFs.TexWhite115107(Tc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Ts2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cc2.ToString()));
				bottom2.AddCell(PDFs.TexWhite115107(Cs2.ToString()));
				
				totales.AddCell(bottom2);
				
				// TOTALES PRECIO
				float[] widths44 = new float[] {50f};
				PdfPTable nested22 = new PdfPTable(1);
				nested22.SetWidths(widths44);	
				
				PdfPCell TotalNombreRimsa = new PdfPCell(PDFs.Enclgray215206("Precio Total"));
				nested22.AddCell(TotalNombreRimsa);	
				PdfPCell TotalTRimsa = new PdfPCell(PDFs.TitWhite115308((Cc + Cs + Tc + Ts).ToString()));
				nested22.AddCell(TotalTRimsa);				
				totales.AddCell(nested22);	
							
				PdfPTable Extras = new PdfPTable(1);
				Extras.TotalWidth = 470f;
				PdfPCell headerExtras = new PdfPCell(PDFs.Enclgray215209("EXTRAS"));
				headerExtras.Colspan = 2;
				Extras.AddCell(headerExtras);
				
				float[] widthsExtras = new float[] {50f, 40f, 200f, 65f, 65f};
				PdfPTable ContenidoExtras = new PdfPTable(5);
				ContenidoExtras.SetWidths(widthsExtras);
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Fecha"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Horario"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Ruta"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Sentido"));
				ContenidoExtras.AddCell(PDFs.TitWhite115308("Vehiculo"));
				for(int y = 0; y<(dtViajesEstandarExtras.RowCount); y++)
					{
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[0].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[1].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[2].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[3].Value));
						ContenidoExtras.AddCell(PDFs.TexWhite115107(""+dtViajesEstandarExtras.Rows[y].Cells[4].Value));
					}
				Extras.AddCell(ContenidoExtras);
				
				if(dtViajesEstandarExtras.RowCount>0)
				{
					document.Add(Extras);
				}				
				document.Add(new Paragraph(espacio));
				document.Add(totales);
								
				if(dtViajesEstandarExtras.RowCount>0)
				{
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph("                  NOTA: Los viajes extras que aparecen en la tabla de la parte de inferior de la hoja"));
					document.Add(new Paragraph("                  están contabilizadas en la tabla de totales"));
				}
							
				
				if((Cc + Cs + Tc + Ts) > 0.0){
					if(principal.idUsuario == 12 || principal.idUsuario == 10 || principal.idUsuario == 54 || principal.idUsuario == 63 ){
						DialogResult respuesta = MessageBox.Show("¿Deseas generar el registro para el control de la factura? (Si solo quieres imprimir la factura oprime NO)", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(respuesta == DialogResult.Yes)
							connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}else{
						connF.GuardaFactura(principal.idUsuario, lblEmpresa.Text, FechaInicio, FechaCorte, (Cc + Cs + Tc + Ts));
					}
				}
			}
			#endregion
			
		#endregion
		
		#region ORDEN DE TRABAJO
		public void OrdenTrabajo(Document document, PdfWriter writer, Int64 ID_OrdenTrabajo)
		{
			//Variables
			PdfContentByte cb = writer.DirectContent;
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 3));
			iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			//document.Add(PDFs.Logo(writer));
		
			
			
			
			
			/*
			//Tabla Principal Superior
			float[] widthsP = new float[] {150f, 170f, 150f};
			PdfPTable tablePS = new PdfPTable(3);
			tablePS.SetWidths(widthsP);
			tablePS.TotalWidth = 470f;
			tablePS.WidthPercentage = 100;
			PdfPCell header = new PdfPCell(PDFs.TitGray115308("RESULTADOS"));
			header.Colspan = 3;
			tablePS.AddCell(header);
			
			*/
			//Tabla Contenedora de Entrada
			float[] widthsE = new float[] {100f};
			PdfPTable tableContenedorEntrada= new PdfPTable(1);
			tableContenedorEntrada.SetWidths(widthsE);
			tableContenedorEntrada.TotalWidth = 155;
			tableContenedorEntrada.WidthPercentage = 30;
			tableContenedorEntrada.HorizontalAlignment = 0;
			PdfPCell header1 = new PdfPCell(new Paragraph("ENTRADA", FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE)));
			header1.HorizontalAlignment = 1;
			header1.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
			header1.Colspan = 2;
			tableContenedorEntrada.AddCell(header1);
 			document.Add(tableContenedorEntrada);
 			
 			//Tabla de Datos de Entrada
 			float[] widthsE1 = new float[]{50f, 50f};
			PdfPTable Fecha1 = new PdfPTable(2);
			Fecha1.SetWidths(widthsE1);
			Fecha1.WidthPercentage = 30;
			Fecha1.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			Fecha1.AddCell(PDFs.TexLgray115205("FECHA:"));
			Fecha1.AddCell(PDFs.TexWhite115107("12/07/2015"));
			document.Add(Fecha1);
			
			float[] widthsE2 = new float[]{50f, 50f};
			PdfPTable Hora1 = new PdfPTable(2);
			Hora1.SetWidths(widthsE2);
			Hora1.WidthPercentage = 30;
			Hora1.HorizontalAlignment = 0;
			Hora1.AddCell(PDFs.TexLgray115205("HORA:"));
			Hora1.AddCell(PDFs.TexWhite115107("15:34"));
			document.Add(Hora1);
			
			float[] widthsE3 = new float[]{50f, 50f};
			PdfPTable Combustible = new PdfPTable(2);
			Combustible.SetWidths(widthsE3);
			Combustible.WidthPercentage = 30;
			Combustible.HorizontalAlignment = 0;
			Combustible.AddCell(PDFs.TexLgray115205("COMBUSTIBLE:"));
			Combustible.AddCell(PDFs.TexWhite115107("LLENO"));
			document.Add(Combustible);
			
			float[] widthsE4 = new float[]{50f, 50f};
			PdfPTable Kilometraje1 = new PdfPTable(2);
			Kilometraje1.SetWidths(widthsE4);
			Kilometraje1.WidthPercentage = 30;
			Kilometraje1.HorizontalAlignment = 0;
			Kilometraje1.AddCell(PDFs.TexLgray115205("KILOMETRAJE:"));
			Kilometraje1.AddCell(PDFs.TexWhite115107("120180"));
			document.Add(Kilometraje1);
			
			float[] widthsE5 = new float[]{50f, 50f};
			PdfPTable Folio = new PdfPTable(2);
			Folio.SetWidths(widthsE1);
			Folio.WidthPercentage = 30;
			Folio.HorizontalAlignment = 0;
			Folio.AddCell(PDFs.TexLgray115205("FOLIO:"));
			Folio.AddCell(PDFs.TexWhite115107("12345"));
			document.Add(Folio);
			
			//Tabla Contenedora de Imagen
			float[] widthsI = new float[] {100f};
			PdfPTable tableContenedorImagen= new PdfPTable(1);
			tableContenedorImagen.SetWidths(widthsI);
			tableContenedorImagen.TotalWidth = 155;
			tableContenedorImagen.WidthPercentage = 30;
			tableContenedorImagen.HorizontalAlignment = 1;
			PdfPCell header2 = new PdfPCell(PDFs.TitWhite115210("ENTRADA"));
			header2.Colspan = 2;
			header2.Rowspan = 5;
			tableContenedorImagen.AddCell(header2);
 			document.Add(tableContenedorImagen);
			
			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			
 			/*
			
			//Tabla Principal
			float[] widths4 = new float[] {300f, 170f};
			PdfPTable tableC = new PdfPTable(2);
			tableC.SetWidths(widths4);
			tableC.TotalWidth = 470f;
			tableC.WidthPercentage = 100;
			PdfPCell header21 = new PdfPCell(PDFs.TitGray115308("RESULTADOS"));
			header21.Colspan = 2;
			tableC.AddCell(header21);
			
			//Tabla Pricipal de viajes
			float[] widths5 = new float[] {235f, 11f, 11f, 11f, 32f};
			PdfPTable nested = new PdfPTable(5);
			nested.SetWidths(widths5);
			nested.AddCell(PDFs.TitLgray115308("Viajes por Empresas"));
			nested.AddCell(PDFs.TitLgray115308("S"));
			nested.AddCell(PDFs.TitLgray115308("C"));
			nested.AddCell(PDFs.TitLgray115308("#"));
			nested.AddCell(PDFs.TitLgray115308("$"));
			
			PdfPCell nesthousing = new PdfPCell(PDFs.Tamaño(nested));
			nesthousing.Padding = 0f;
			tableC.AddCell(nesthousing);
			
			//Tabla parte baja total viajes
			float[] widthsViajes = new float[] {235f, 11f, 11f, 11f, 32f};
			PdfPTable TotalViajes = new PdfPTable(5);
			TotalViajes.SetWidths( widthsViajes);
			TotalViajes.TotalWidth = 300f;
			TotalViajes.WidthPercentage = 63.82f;
			TotalViajes.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			TotalViajes.AddCell(PDFs.TitLgray114308("Total de viajes:"));
			
			
			//Tabla Bonos
			float[] widthsBonos = new float[] {75f, 25f};
			PdfPTable Bonos = new PdfPTable(2);
			Bonos.SetWidths(widthsBonos);
			Bonos.AddCell(PDFs.TitLgray114308("Ingresos"));
			Bonos.AddCell(PDFs.TitLgray115308("Importe"));
			Bonos.AddCell(PDFs.TexWhite111107("Bono Normal"));
			
			float[] widthsTotalIngreso = new float[] {75.5f, 24.5f};
			PdfPTable TotalIngreso = new PdfPTable(2);
			TotalIngreso.SetWidths(widthsTotalIngreso);
			TotalIngreso.AddCell(PDFs.TitWhite114308("Total Otros Ingresos"));
			TotalIngreso.AddCell(PDFs.TitWhite114308("Total viajes"));
			TotalIngreso.AddCell(PDFs.TitLgray114308("Total percepcciones sin ajuste"));
			TotalIngreso.AddCell(PDFs.TitWhite114308("Ajuste Nominal"));
			TotalIngreso.AddCell(PDFs.TitLgray114308("Total viajes, ingresos y ajustes"));
			
			//Contenedor Panel Pricipal Derecho
			PdfPTable ContenedorPrincipal = new PdfPTable(1);
			ContenedorPrincipal.AddCell(PDFs.Tamaño(Bonos));
			ContenedorPrincipal.AddCell(TotalIngreso);
			tableC.AddCell(ContenedorPrincipal);
			document.Add(tableC);
			document.Add(TotalViajes);
			
			//Tablas y contenedor Datos, Foto
			PdfPCell headerImprimir = new PdfPCell(PDFs.TitGray115308("IMPRESIÓN"));
			headerImprimir.Colspan = 2;
			float[] widthsReviso = new float[] {41f, 59f};
			PdfPTable Reviso = new PdfPTable(2);
			Reviso.SetWidths(widthsReviso);
			Reviso.AddCell(headerImprimir);
			Reviso.AddCell(PDFs.TitLgray114308("Reviso:"));
			Reviso.AddCell(PDFs.TitLgray114308("Fecha:"));
			Reviso.AddCell(PDFs.TexWhite112107(DateTime.Now.ToString("dd-MM-yyyy")));
			Reviso.AddCell(PDFs.TitLgray114308("Hora:"));
			
			// Tabla descuentos del periodo
			PdfPTable tableEncDescuentos = new PdfPTable(1);
			tableEncDescuentos.TotalWidth = 100f;
			tableEncDescuentos.WidthPercentage = 45;
			tableEncDescuentos.HorizontalAlignment = 0;
			PdfPCell headerDescuentos = new PdfPCell(PDFs.TitGray115308("DESCUENTOS DEL PERIODO"));
			headerDescuentos.Colspan = 1;
			tableEncDescuentos.AddCell(headerDescuentos);
			float[] widthsAnticipos = new float[] {35f, 30f, 30f, 95f, 45f};
			PdfPTable TbAnticipos = new PdfPTable(5);
			TbAnticipos.SetWidths(widthsAnticipos);
			TbAnticipos.AddCell(PDFs.TitLgray115308("Fecha"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Tipo"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Pago"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Detalle"));
			TbAnticipos.AddCell(PDFs.TitLgray115308("Descuento"));
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			for(int y = 0; y<(dtConteo.RowCount); y++)
			{
				nested.AddCell(PDFs.TexWhite111107(dtConteo.Rows[y].Cells[0].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dtConteo.Rows[y].Cells[1].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dtConteo.Rows[y].Cells[2].Value.ToString()));
				nested.AddCell(PDFs.TexWhite112107(dtConteo.Rows[y].Cells[3].Value.ToString()));
				nested.AddCell(PDFs.TexWhite111107(Convert.ToDouble(dtConteo.Rows[y].Cells[4].Value).ToString("C")));
			}
			PdfPCell nesthousing = new PdfPCell(PDFs.Tamaño(nested));
			nesthousing.Padding = 0f;
			tableC.AddCell(nesthousing);
			
			//Tabla parte baja total viajes
			float[] widthsViajes = new float[] {235f, 11f, 11f, 11f, 32f};
			PdfPTable TotalViajes = new PdfPTable(5);
			TotalViajes.SetWidths( widthsViajes);
			TotalViajes.TotalWidth = 300f;
			TotalViajes.WidthPercentage = 63.82f;
			TotalViajes.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
			TotalViajes.AddCell(PDFs.TitLgray114308("Total de viajes:"));
			TotalViajes.AddCell(PDFs.TitLgray115308(AcumuladorSencillos.ToString()));
			TotalViajes.AddCell(PDFs.TitLgray115308(AcumuladorCompletos.ToString()));
			TotalViajes.AddCell(PDFs.TitLgray115308(AcumuladorViajes.ToString()));
			TotalViajes.AddCell(PDFs.TitLgray114308(subtotalviajesneto.ToString("C")));
			
			//Tabla Bonos
			float[] widthsBonos = new float[] {75f, 25f};
			PdfPTable Bonos = new PdfPTable(2);
			Bonos.SetWidths(widthsBonos);
			Bonos.AddCell(PDFs.TitLgray114308("Ingresos"));
			Bonos.AddCell(PDFs.TitLgray115308("Importe"));
			Bonos.AddCell(PDFs.TexWhite111107("Bono Normal"));
			Bonos.AddCell(PDFs.TexWhite112107(bonos.ToString("C")));
			if(valorBonoEx>0)
			{
				Bonos.AddCell(PDFs.TexWhite111107("Bono Extra"));
				Bonos.AddCell(PDFs.TexWhite112107(valorBonoEx.ToString("C")));
			}
			if(valorBonoEs>0)
			{
				Bonos.AddCell(PDFs.TexWhite111107("Bono Especial"));
				Bonos.AddCell(PDFs.TexWhite112107(valorBonoEs.ToString("C")));
			}
			if(Convert.ToDouble(txtApoyoCoord.Text)>0)
			{
				Bonos.AddCell(PDFs.TexWhite111107("Apoyo Coordinación"));
				Bonos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(txtApoyoCoord.Text)).ToString("C")));
			}
			for(int y = 0; y<(dataIngresosExtras.RowCount); y++)
			{
				Bonos.AddCell(PDFs.TexWhite111107(dataIngresosExtras.Rows[y].Cells[1].Value.ToString()));
				Bonos.AddCell(PDFs.TexWhite112107((Convert.ToDouble(dataIngresosExtras.Rows[y].Cells[2].Value)).ToString("C")));
			}

			float[] widthsTotalIngreso = new float[] {75.5f, 24.5f};
			PdfPTable TotalIngreso = new PdfPTable(2);
			TotalIngreso.SetWidths(widthsTotalIngreso);
			TotalIngreso.AddCell(PDFs.TitWhite114308("Total Otros Ingresos"));
			TotalIngreso.AddCell(PDFs.TitWhite114308((Convert.ToDouble(totalIngresos+bonos+valorBonoEs+valorBonoEx+Convert.ToDouble(txtApoyoCoord.Text))).ToString("C")));
			TotalIngreso.AddCell(PDFs.TitWhite114308("Total viajes"));
			TotalIngreso.AddCell(PDFs.TitWhite114308((Convert.ToDouble(subtotalviajesneto)).ToString("C")));
			TotalIngreso.AddCell(PDFs.TitLgray114308("Total percepcciones sin ajuste"));
			TotalIngreso.AddCell(PDFs.TitLgray114308((Convert.ToDouble(totalIngresos+totalpercepciones)).ToString("C")));
			TotalIngreso.AddCell(PDFs.TitWhite114308("Ajuste Nominal"));
			TotalIngreso.AddCell(PDFs.TitWhite114308(extra1.ToString("C")));
			TotalIngreso.AddCell(PDFs.TitLgray114308("Total viajes, ingresos y ajustes"));
			TotalIngreso.AddCell(PDFs.TitLgray114308((Convert.ToDouble(totalIngresos+extra1+totalpercepciones)).ToString("C")));
			*/
			
		}
			
		#endregion			
		
		#region ORDEN DE COMPRA	
		public void OrdenCompra(
			Document document, 
			PdfWriter writer, 
			String NomProvee,
			String RFC,			
			String Domicilio,
			String Telefono,
			String Unidad,
			String Observaciones
		)
		{
				document.Add(PDFs.LogoOrden(writer)); 
	 			
				Paragraph espacio = new Paragraph("                                                                                     ", FontFactory.GetFont("ARIAL", 5));
				
				float[] widths = new float[] {100f};
				PdfPTable tableC = new PdfPTable(1);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 100f;
				tableC.WidthPercentage = 15;
				tableC.HorizontalAlignment = 0;
				
				float[] widths1 = new float[] {20f};
				PdfPTable nested = new PdfPTable(1);
				nested.SetWidths(widths1);
				nested.AddCell(PDFs.TitLgray115308("FOLIO"));
	   		    nested.AddCell(PDFs.TexWhite112107("00000"));
	   		    nested.AddCell(PDFs.TitLgray115308("FACTURA:"));
	   		    nested.AddCell(PDFs.TexWhite112107("00000"));
				tableC.AddCell(nested);
				document.Add(tableC);
				document.Add(new Paragraph(espacio));
				
				//inicia segunda tabla
				float[] widths4 = new float[] {100f};
				PdfPTable tableContenedorDatosOP = new PdfPTable(1);
				tableContenedorDatosOP.SetWidths(widths4);
				tableContenedorDatosOP.WidthPercentage = 100;
				tableContenedorDatosOP.HorizontalAlignment = 2;
				PdfPCell header2 = new PdfPCell(PDFs.TitLgray115308("ORDEN DE COMPRA"));
				tableContenedorDatosOP.AddCell(header2);
	 			document.Add(tableContenedorDatosOP);
				document.Add(new Paragraph(espacio));
				float[] widths12 = new float[] {10f, 90f};
				PdfPTable nested11 = new PdfPTable(2);
				nested11.SetWidths(widths12);
				nested11.WidthPercentage = 100;
	   		    nested11.AddCell(new Paragraph("Proveedor: ", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    nested11.AddCell(new Paragraph(NomProvee, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
				document.Add(nested11);
				
				//inicia segunda tabla complemento
				
				float[] widthsDatosEmpleado = new float[] {10f, 60f, 10f, 20f};
				PdfPTable datosEmpleado = new PdfPTable(4);
				datosEmpleado.SetWidths(widthsDatosEmpleado);
				datosEmpleado.WidthPercentage = 100;
	   		    datosEmpleado.AddCell(new Paragraph("Domicilio:", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosEmpleado.AddCell(new Paragraph(Domicilio, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL)));
	   		    datosEmpleado.AddCell(new Paragraph("Telefono:", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosEmpleado.AddCell(new Paragraph(Telefono, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL)));
	   		    datosEmpleado.AddCell(new Paragraph("Unidad: ", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosEmpleado.AddCell(new Paragraph(Unidad, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL)));
	   		    datosEmpleado.AddCell(new Paragraph("Impresión: ", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosEmpleado.AddCell(PDFs.TexWhite115107(DateTime.Now.ToString()));
				document.Add(datosEmpleado);
				document.Add(new Paragraph(espacio));
				
				/*
				//inicia Contenido per y deduc
				float[] widthscontenido = new float[] {10f, 70f, 10f, 10f};
				PdfPTable datoscontenido = new PdfPTable(4);
				datoscontenido.SetWidths(widthscontenido);
				datoscontenido.WidthPercentage = 100;
				datoscontenido.HorizontalAlignment = 1;
	   		    datoscontenido.AddCell(PDFs.TitLgray115308("Cantidad"));
	   		    datoscontenido.AddCell(PDFs.TitLgray115308("Concepto"));
	   		    datoscontenido.AddCell(PDFs.TitLgray115308("P. Unitario"));
	   		    datoscontenido.AddCell(PDFs.TitLgray115308("Importe"));
	   		    datoscontenido.AddCell(new Paragraph(cantidad[0], FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(concepto[0], FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(precioU[0], FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(importe[0], FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
	   		    datoscontenido.AddCell(new Paragraph(".", FontFactory.GetFont("Arial", 8)));
				document.Add(datoscontenido);
				
				//inicia total neto
				float[] widthsNeto = new float[] {50f, 50f};
				PdfPTable datosNeto = new PdfPTable(2);
				datosNeto.SetWidths(widthsNeto);
				datosNeto.WidthPercentage = 20;
				datosNeto.HorizontalAlignment = 2;
	   		    datosNeto.AddCell(new Paragraph("Subtotal", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosNeto.AddCell(new Paragraph("$", FontFactory.GetFont("Arial", 8)));
	   		    datosNeto.AddCell(new Paragraph("IVA", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosNeto.AddCell(new Paragraph("$", FontFactory.GetFont("Arial", 8)));
	   		    datosNeto.AddCell(new Paragraph("Total", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
	   		    datosNeto.AddCell(new Paragraph("$", FontFactory.GetFont("Arial", 8)));
				document.Add(datosNeto);
				
				//inicia final del recibo
				document.Add(new Paragraph(espacio));
				
				float[] widthsfirma = new float[] {50f, 50f};
				PdfPTable datosfirma = new PdfPTable(2);
				datosfirma.SetWidths(widthsfirma);
				datosfirma.WidthPercentage = 100;
				datosfirma.AddCell(new Paragraph("Observaciones:\n"+Observaciones));
	   		    datosfirma.AddCell(new Paragraph(".                                                                                                                                                                           " +
				                                 ".                                                                                                                                                                           " +
				                                 ".                                                                                                                                                                           " +
				                                 ".                                                                                                                                                                           " +
				                                 ".                                                                                                                                                                           " +
				                                 "-------------------------------------------------------------------------------------------------------------.                                                  Firma Empleado", FontFactory.GetFont("Arial", 8)));
				datosfirma.HorizontalAlignment = 1;
				document.Add(datosfirma);
				*/
				//document.Add(PDFs.Grafica(grafica));
			}
		#endregion
		
		#region RECIBO
		public void Recibo(Interfaz.FormPrincipal principal, Document document, PdfWriter writer, 
		                   String Opcion, String Alias, TextBox txtPatron, TextBox txtNs, TextBox txtPuesto, TextBox txtRfc, 
		                   TextBox txtNumImss, TextBox txtDiasTrabajados, DateTimePicker dtInicio, DateTimePicker dtFin, 
		                   DataGridView dataPercepciones, DataGridView dataDeducciones, double TotalDeducciones, TextBox txtPrima, 
			               TextBox txtPrimaVacacional, TextBox txtAguinaldo, double Compesacion, double Retener, 
			               TextBox txtNombreCompleto, Interfaz.Nomina.FormNomina formnomina, String Nombre, DataGridView dtOperador, String ID_OP, String Opcion2)
		{
			Convertir con = new Convertir();
			double ceropagare = 0.0;
			document.Add(PDFs.LogoReciboArriba(writer));
			document.Add(PDFs.LogoReciboAbajo(writer));
			Paragraph espacio = new Paragraph("                                                                                     ", FontFactory.GetFont("ARIAL", 5));
			PdfContentByte cb = writer.DirectContent;
			BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
			cb.SetColorFill(iTextSharp.text.BaseColor.LIGHT_GRAY);
			
			if(Opcion=="1" && Opcion2!="2")
			{
				  listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(ID_OP);
				  document.Add(PDFs.ImagenPagare(writer));
				  document.Add(PDFs.ImagenCantidad(writer));
				  cb.BeginText();
				  cb.SetFontAndSize(bf, 10);
				  cb.SetTextMatrix(500, 175);
				  cb.ShowText(Alias+" "+listNomina[0].Unidad);
				  cb.EndText();
			}
			for(int z=0; z<2; z++)
			{
				float[] widths = new float[] {15f, 85f};
				PdfPTable tableC = new PdfPTable(2);
				tableC.SetWidths(widths);
				tableC.TotalWidth = 100f;
				tableC.WidthPercentage = 70;
				tableC.HorizontalAlignment = 2 ;
				PdfPCell header = new PdfPCell(PDFs.Enclgray215209("DATOS DEL PATRÓN"));
				header.Colspan = 2;
				tableC.AddCell(header);
				
				float[] widths1 = new float[] {10f};
				PdfPTable nested = new PdfPTable(1);
				nested.SetWidths(widths1);
		
	   		    nested.AddCell(PDFs.TitWhite114308("Nombre:"));
	   		    nested.AddCell(PDFs.TitWhite114308("N.S."));
				tableC.AddCell(nested);
				
				float[] widths2 = new float[] {90f};
				PdfPTable bottom = new PdfPTable(1);
				bottom.SetWidths(widths2);
				bottom.AddCell(PDFs.TexWhite111107(txtPatron.Text.ToUpper()));
				bottom.AddCell(PDFs.TexWhite111107(txtNs.Text));
				tableC.AddCell(bottom);
				document.Add(tableC);
				document.Add(new Paragraph(espacio));
				
				//inicia segunda tabla
				
				PdfPTable tableC11 = new PdfPTable(1);
				tableC11.WidthPercentage = 100;
				tableC11.HorizontalAlignment = 1;
				PdfPCell header11 = new PdfPCell(PDFs.Enclgray215209("DATOS DEL EMPLEADO"));
				header11.Colspan = 1;
				tableC11.AddCell(header11);
				document.Add(tableC11);
				
				float[] widths12 = new float[] {5f, 75f};
				PdfPTable nested11 = new PdfPTable(2);
				nested11.SetWidths(widths12);
				nested11.WidthPercentage = 100;
	   		    nested11.AddCell(PDFs.TitWhite114308("Nombre"));
	   		    nested11.AddCell(PDFs.TexWhite111107(Nombre.ToUpper()));
				document.Add(nested11);
				
				//inicia segunda tabla complemento
				
				float[] widthsDatosEmpleado = new float[] {5f, 10f, 3f, 9f, 3f, 7f, 3f, 2f, 5f, 33f};
				PdfPTable datosEmpleado = new PdfPTable(10);
				datosEmpleado.SetWidths(widthsDatosEmpleado);
				datosEmpleado.WidthPercentage = 100;
	   		    datosEmpleado.AddCell(PDFs.TitWhite114308("Puesto"));
	   		    datosEmpleado.AddCell(PDFs.TexWhite115107(txtPuesto.Text));
	   		    datosEmpleado.AddCell(PDFs.TitWhite114308("RFC"));
	   		    datosEmpleado.AddCell(PDFs.TexWhite115107(txtRfc.Text));
	   		    datosEmpleado.AddCell(PDFs.TitWhite114308("Afil IMSS"));
	   		    datosEmpleado.AddCell(PDFs.TexWhite115107(txtNumImss.Text));
	   		    datosEmpleado.AddCell(PDFs.TitWhite114308("Días Trab."));
	   		    datosEmpleado.AddCell(PDFs.TexWhite115107(txtDiasTrabajados.Text));
	   		    datosEmpleado.AddCell(PDFs.TitWhite114308("Periodo"));
	   		    datosEmpleado.AddCell(PDFs.TexWhite115107(dtInicio.Value.ToLongDateString()+" al "+dtFin.Value.ToLongDateString()));
				
				document.Add(datosEmpleado);
				document.Add(new Paragraph(espacio));
				
				float[] widthsPD = new float[] {50f, 50f};
				PdfPTable tablePD = new PdfPTable(2);
				tablePD.SetWidths(widthsPD);
				tablePD.TotalWidth = 100f;
				tablePD.WidthPercentage = 100;
				tablePD.HorizontalAlignment = 0;
				
				PdfPCell headerPD = new PdfPCell(PDFs.Enclgray215209("PERCEPCIONES"));
				PdfPCell headerPD2 = new PdfPCell(PDFs.Enclgray215209("DEDUCCIONES"));
				tablePD.AddCell(headerPD);
				tablePD.AddCell(headerPD2);
				document.Add(tablePD);
				
				if(Opcion=="1")
				{
					//inicia Contenido per y deduc
					float[] widthscontenido = new float[] {37.5f, 12.5f, 37.5f, 12.5f};
					PdfPTable datoscontenido = new PdfPTable(4);
					datoscontenido.SetWidths(widthscontenido);
					datoscontenido.WidthPercentage = 100;
					datoscontenido.HorizontalAlignment = 1;
					
					/*if(Opcion2=="1")
					{
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("Sueldo"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("I.S.R."));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[0].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("Subsidio para el empleo"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[4].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("I.M.S.S."));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[1].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308(""));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("INFONAVIT"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[3].Value)).ToString("C")));
			   		    for(int num=0; num<9; num++)
			   		    {
			   		    	datoscontenido.AddCell(PDFs.TitWhite114308(""));
			   		   	    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
			   		    }
						document.Add(datoscontenido);
					}
					else if(Opcion2=="2")
					{*/
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("Sueldo"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("I.S.R."));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[0].Value)).ToString("C")));
//			   		    datoscontenido.AddCell(PDFs.TitWhite114308("Despensa"));
//			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[7].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("Premio de Asistencia"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[5].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("I.M.S.S."));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[1].Value)).ToString("C")));
			   		     datoscontenido.AddCell(PDFs.TitWhite114308("Premio a la Puntualidad"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[6].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("INFONAVIT"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[3].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308("Subsidio para el empleo"));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[4].Value)).ToString("C")));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308(""));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308(""));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
			   		    datoscontenido.AddCell(PDFs.TitWhite114308(""));
			   		    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
			   		    
			   		    for(int num=0; num<5; num++)
			   		    {
			   		    	datoscontenido.AddCell(PDFs.TitWhite114308(""));
			   		   	    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
			   		    }
						document.Add(datoscontenido);
					//}
					
					//inicia total per y deduc
					float[] widthsTotales = new float[] {37.5f, 12.5f, 37.5f, 12.5f};
					PdfPTable datosTotales = new PdfPTable(4);
					datosTotales.SetWidths(widthsTotales);
					datosTotales.WidthPercentage = 100;
					datosTotales.HorizontalAlignment = 1;
		   		    datosTotales.AddCell(PDFs.TitWhite114308("Total Percepciones"));
		   		    datosTotales.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataPercepciones.Rows[0].Cells[8].Value)).ToString("C")));
		   		    datosTotales.AddCell(PDFs.TitWhite114308("Total Deducciones"));
		   		    datosTotales.AddCell(PDFs.TexWhite111107(TotalDeducciones.ToString("C")));
					document.Add(datosTotales);
					
					//inicia total neto
					float[] widthsNeto = new float[] {50f, 50f};
					PdfPTable datosNeto = new PdfPTable(2);
					datosNeto.SetWidths(widthsNeto);
					datosNeto.WidthPercentage = 25;
					datosNeto.HorizontalAlignment = 2;
		   		    datosNeto.AddCell(PDFs.TitWhite114308("Total Neto"));
		   		    datosNeto.AddCell(PDFs.TexWhite111107((Convert.ToDouble(dataDeducciones.Rows[0].Cells[5].Value)).ToString("C")));
					document.Add(datosNeto);
				}
				else if(Opcion=="2")
				{
					//inicia Contenido per y deduc
					float[] widthscontenido = new float[] {37.5f, 12.5f, 37.5f, 12.5f};
					PdfPTable datoscontenido = new PdfPTable(4);
					datoscontenido.SetWidths(widthscontenido);
					datoscontenido.WidthPercentage = 100;
					datoscontenido.HorizontalAlignment = 1;
					datoscontenido.AddCell(PDFs.TitWhite114308("Vacaciones"));
					datoscontenido.AddCell(PDFs.TexWhite111107(((Convert.ToDouble(txtPrima.Text)) - (Convert.ToDouble(txtPrima.Text))*(Convert.ToDouble(txtPrimaVacacional.Text))).ToString("C")));
		   		    datoscontenido.AddCell(PDFs.TitWhite114308(""));
		   		    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
		   		    datoscontenido.AddCell(PDFs.TitWhite114308("Prima Vacacional"));
		   		    datoscontenido.AddCell(PDFs.TexWhite111107(((Convert.ToDouble(txtPrima.Text))*(Convert.ToDouble(txtPrimaVacacional.Text))).ToString("C")));
		   		    for(int num=0; num<13; num++)
		   		    {
		   		    	datoscontenido.AddCell(PDFs.TitWhite114308(""));
		   		   	    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
		   		    }
					document.Add(datoscontenido);
					
					//inicia total per y deduc
					float[] widthsTotales = new float[] {37.5f, 12.5f, 37.5f, 12.5f};
					PdfPTable datosTotales = new PdfPTable(4);
					datosTotales.SetWidths(widthsTotales);
					datosTotales.WidthPercentage = 100;
					datosTotales.HorizontalAlignment = 1;
		   		    datosTotales.AddCell(PDFs.TitWhite114308("Total Percepciones"));
		   		    datosTotales.AddCell(PDFs.TexWhite111107((Convert.ToDouble(txtPrima.Text)).ToString("C")));
		   		    datosTotales.AddCell(PDFs.TitWhite114308("Total Deducciones"));
		   		    datosTotales.AddCell(PDFs.TexWhite111107("$0.00"));
					document.Add(datosTotales);
					
					//inicia total neto
					float[] widthsNeto = new float[] {50f, 50f};
					PdfPTable datosNeto = new PdfPTable(2);
					datosNeto.SetWidths(widthsNeto);
					datosNeto.WidthPercentage = 25;
					datosNeto.HorizontalAlignment = 2;
					datosNeto.AddCell(PDFs.TitWhite114308("Total Neto"));
					datosNeto.AddCell(PDFs.TexWhite111107("$720.00"));
					document.Add(datosNeto);
				}
				else if(Opcion=="3")
				{
					//inicia Contenido per y deduc
					float[] widthscontenido = new float[] {37.5f, 12.5f, 37.5f, 12.5f};
					PdfPTable datoscontenido = new PdfPTable(4);
					datoscontenido.SetWidths(widthscontenido);
					datoscontenido.WidthPercentage = 100;
					datoscontenido.HorizontalAlignment = 1;
					datoscontenido.AddCell(PDFs.TitWhite114308("Aguinaldo"));
					datoscontenido.AddCell(PDFs.TexWhite111107((Convert.ToDouble(txtAguinaldo.Text)-Compesacion).ToString("C")));
		   		    datoscontenido.AddCell(PDFs.TitWhite114308("A retener"));
		   		    datoscontenido.AddCell(PDFs.TexWhite111107(Retener.ToString("C")));
		   		    datoscontenido.AddCell(PDFs.TitWhite114308("Compensación Anual"));
		   		    datoscontenido.AddCell(PDFs.TexWhite111107(Compesacion.ToString("C")));
		   		    for(int num=0; num<13; num++)
		   		    {
		   		    	datoscontenido.AddCell(PDFs.TitWhite114308(""));
		   		   	    datoscontenido.AddCell(PDFs.TexWhite111107("$0.00"));
		   		    }
					document.Add(datoscontenido);
					
					//inicia total per y deduc
					float[] widthsTotales = new float[] {37.5f, 12.5f, 37.5f, 12.5f};
					PdfPTable datosTotales = new PdfPTable(4);
					datosTotales.SetWidths(widthsTotales);
					datosTotales.WidthPercentage = 100;
					datosTotales.HorizontalAlignment = 1;
		   		    datosTotales.AddCell(PDFs.TitWhite114308("Total Percepciones"));
		   		    datosTotales.AddCell(PDFs.TexWhite111107((Convert.ToDouble(txtAguinaldo.Text)).ToString("C")));
		   		    datosTotales.AddCell(PDFs.TitWhite114308("Total Deducciones"));
		   		    datosTotales.AddCell(PDFs.TexWhite111107(Retener.ToString("C")));
					document.Add(datosTotales);
					
					//inicia total neto
					float[] widthsNeto = new float[] {50f, 50f};
					PdfPTable datosNeto = new PdfPTable(2);
					datosNeto.SetWidths(widthsNeto);
					datosNeto.WidthPercentage = 25;
					datosNeto.HorizontalAlignment = 2;
					datosNeto.AddCell(PDFs.TitWhite114308("Total Neto"));
					datosNeto.AddCell(PDFs.TexWhite111107(((Convert.ToDouble(txtAguinaldo.Text))-(Retener)).ToString("C")));
					document.Add(datosNeto);
				}
				//inicia final del recibo
				document.Add(new Paragraph(espacio));
				
				PdfPTable cellfirma = new PdfPTable(1);
				cellfirma.WidthPercentage = 100;
				cellfirma.HorizontalAlignment = 1;
				cellfirma.AddCell(PDFs.AliasRecibo(Alias));
				cellfirma.AddCell(PDFs.TitWhite115308("Firma Empleado"));
				
				float[] widthsfirma = new float[] {50f, 50f};
				PdfPTable datosfirma = new PdfPTable(2);
				datosfirma.SetWidths(widthsfirma);
				datosfirma.WidthPercentage = 100;
				datosfirma.HorizontalAlignment = 1;
				datosfirma.AddCell(PDFs.SeparadorTableGris50("Recibi de empresa arriba mencionada la cantidad neta a que este documento se refiere, estando conforme con las percepciones y deducciones que en el aparecen especificado"));
	   		    datosfirma.AddCell(cellfirma);
	   		    document.Add(datosfirma);
				document.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));
				document.Add(new Paragraph(espacio));
			}
				if(Opcion=="1" && Opcion2!="2")
				{
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph(espacio));
					document.Add(new Paragraph(espacio));
					
					float[] widthsEncP = new float[] {30f, 70f};
					PdfPTable nestedEncP = new PdfPTable(2);
					nestedEncP.SetWidths(widthsEncP);
					nestedEncP.WidthPercentage = 30;
					nestedEncP.HorizontalAlignment = 1;
		   		    nestedEncP.AddCell(PDFs.TitWhite114308("Numero:"));
		   		    nestedEncP.AddCell(PDFs.TexWhite111107("01 de 01"));
		   		    nestedEncP.AddCell(PDFs.TitWhite114308("Vencimiento:"));
		   		    nestedEncP.AddCell(PDFs.TexWhite111107(DateTime.Now.AddDays(15).ToLongDateString()));
		   		    nestedEncP.AddCell(PDFs.TitWhite114308("Importe:"));
		   		    ceropagare = formnomina.RetornoPagareAlias(Alias);
		   		    if(ceropagare>1&&formnomina.RetornoSueldoAlias(Alias)>999)
		   		    	nestedEncP.AddCell(PDFs.TexWhite111107(formnomina.RetornoPagareAlias(Alias).ToString("C")));
		   		    else 
		   		    	nestedEncP.AddCell(PDFs.TexWhite111107("$"));
		   		    document.Add(nestedEncP);
		   		    
		   		    document.Add(PDFs.TextoPagare("   Por el presente pagaré reconozco deber y me obligo a pagar en esta ciudad o en cualquier otra en que se requiera "));
		   		    document.Add(PDFs.TextoPagare("   pago a "+txtPatron.Text.ToUpper()));
					
		   		    if(ceropagare>1&&formnomina.RetornoSueldoAlias(Alias)>999)
						document.Add(PDFs.TextoPagare("   o a su orden el día de su vencimiento la cantidad de:    "+(con.Convertir_Numero((Math.Truncate(formnomina.RetornoPagareAlias(Alias))).ToString())).ToUpper()+" PESOS 00/100 M.N."));
					else
						document.Add(PDFs.TextoPagare("   o a su orden el día de su vencimiento la cantidad de: "));
				    document.Add(PDFs.TextoPagare("   Valor recibido en moneda nacional a mi entera satisfacción."));
				    document.Add(PDFs.TextoPagare("   Este pagaré es mercantil y esta rígido por la ley general de títulos y operaciones de crédito en su artículo 173 parte final y artículos correlativos, por no ser pagare"));
				    document.Add(PDFs.TextoPagare("   domiciliado. De no verificarse el pago de la cantidad que este expresa en el pagare el día de su vencimiento, abonare rédito de 5% mensual por todo este tiempo"));
				    document.Add(PDFs.TextoPagare("   que este insoluto, sin perjuicio alcobro más los gastos por los que ellos se originen."));
				    document.Add(new Paragraph(espacio));
				    
				    PdfPTable cellfirma2 = new PdfPTable(1);
					cellfirma2.WidthPercentage = 100;
					cellfirma2.HorizontalAlignment = 1;
					cellfirma2.AddCell(".");
					cellfirma2.AddCell(PDFs.TitWhite115308("Nombre y Firma del Empleado"));
				    
				    float[] widthspagare = new float[] {50f, 50f};
					PdfPTable datosPagare = new PdfPTable(2);
					datosPagare.SetWidths(widthspagare);
					datosPagare.WidthPercentage = 85;
					datosPagare.HorizontalAlignment = 1;
					datosPagare.AddCell(PDFs.SeparadorTableGris30("Otorgante: "+txtNombreCompleto.Text.ToUpper()+"                                                                                     "+
					                                     		  ".                                                                                                                         "+           
					                                     		  "Guadalajara, Jalisco a "+DateTime.Now.AddDays(1).ToLongDateString()+"                                                                "));
		   		    datosPagare.AddCell(cellfirma2);
					datosPagare.HorizontalAlignment = 1;
					document.Add(datosPagare);
				}
		}
		#endregion
		
		#region DATOS INSCRIPCION
		public void FormatoDatosInscripcion(Document document, PdfWriter writer, String Nombre, String ApellidoPat, String ApellidoMat,
		                                    String Lugar_Nac, String Fecha_Nac, String Sexo, String Curp, String Rfc, String nss, 
		                                    String Calle, String Colonia, String Municipio, String Estado, String Numero, 
		                                    String CP, String referencia1, String referencia2, String idOperador, String Numero_infonavit)
		{
			//Variables
			PdfContentByte cb = writer.DirectContent;
			document.Add(PDFs.LogoFactura(writer));
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
			
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			PdfPTable tableC = new PdfPTable(1);
			tableC.WidthPercentage = 100;
			tableC.HorizontalAlignment = 1;
			PdfPCell header = new PdfPCell(PDFs.EncWhite215212("DATOS DE INSCRIPCIÓN"));
			tableC.AddCell(header);
			document.Add(tableC);
			
			PdfPTable tableCPesonales = new PdfPTable(1);
			tableCPesonales.WidthPercentage = 100;
			tableCPesonales.HorizontalAlignment = 1;
			PdfPCell headerPesonales = new PdfPCell(PDFs.TitLgray115312("PERSONALES"));
			headerPesonales.Colspan = 1;
			tableCPesonales.AddCell(headerPesonales);
			document.Add(tableCPesonales);
			
			float[] widths12 = new float[] {25f, 45f, 20f, 50f, 20f, 50f};
			PdfPTable nestedpersonales = new PdfPTable(6);
			nestedpersonales.SetWidths(widths12);
			nestedpersonales.WidthPercentage = 100;
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("Nombre(s)"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(Nombre.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("Apellido Paterno"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(ApellidoPat.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("Apellido Materno"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(ApellidoMat.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("Lugar de Nac."));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(Lugar_Nac.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("Fecha de Nac."));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(Fecha_Nac.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("Sexo"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(Sexo.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("NSS"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(nss.ToUpper())); 
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("RFC"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(Rfc.ToUpper()));
   		    nestedpersonales.AddCell(PDFs.TitWhite111312("CURP"));
   		    nestedpersonales.AddCell(PDFs.TexWhite114111(Curp.ToUpper()));
			document.Add(nestedpersonales);
			document.Add(espacio);
			
			PdfPTable tableDomicilio = new PdfPTable(1);
			tableDomicilio.WidthPercentage = 100;
			tableDomicilio.HorizontalAlignment = 1;
			PdfPCell headerDomicilio = new PdfPCell(PDFs.TitLgray115312("DOMICILIO"));
			headerDomicilio.Colspan = 1;
			tableDomicilio.AddCell(headerDomicilio);
			document.Add(tableDomicilio);
			
			float[] widthsdomicilio = new float[] {30f, 54f, 24f, 24f, 24f, 54f};
			PdfPTable nestedDomicilio = new PdfPTable(6);
			nestedDomicilio.SetWidths(widthsdomicilio);
			nestedDomicilio.WidthPercentage = 100;
   		    nestedDomicilio.AddCell(PDFs.TitWhite111312("Calle"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111111(Calle.ToUpper()));
   		    nestedDomicilio.AddCell(PDFs.TitWhite111312("Num."));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111111(Numero));
   		    nestedDomicilio.AddCell(PDFs.TitWhite111312("Colonia"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111111(Colonia.ToUpper()));
   		    nestedDomicilio.AddCell(PDFs.TitWhite111312("Municipio"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111111(Municipio.ToUpper()));
   		    nestedDomicilio.AddCell(PDFs.TitWhite111312("C.P."));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111111(CP));
   		    nestedDomicilio.AddCell(PDFs.TitWhite111312("Estado"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111111(Estado.ToUpper()));
			document.Add(nestedDomicilio);
			
			float[] widthsdomicilio2 = new float[] {30f, 180f};
			PdfPTable nestedDomicilio2 = new PdfPTable(2);
			nestedDomicilio2.SetWidths(widthsdomicilio2);
			nestedDomicilio2.WidthPercentage = 100;
   		    nestedDomicilio2.AddCell(PDFs.TitWhite111312("Entre Calle"));
   		    nestedDomicilio2.AddCell(PDFs.TexWhite111111(referencia1.ToUpper()));
   		    nestedDomicilio2.AddCell(PDFs.TitWhite111312("Entre Calle"));
   		    nestedDomicilio2.AddCell(PDFs.TexWhite111111(referencia2.ToUpper()));
			document.Add(nestedDomicilio2);
			document.Add(espacio);
			
			PdfPTable tableINFONAVIT = new PdfPTable(1);
			tableINFONAVIT.WidthPercentage = 100;
			tableINFONAVIT.HorizontalAlignment = 0;
			PdfPCell headerINFONAVIT = new PdfPCell(PDFs.TitLgray115312("INFONAVIT"));
			headerINFONAVIT.Colspan = 1;
			tableINFONAVIT.AddCell(headerINFONAVIT);
			document.Add(tableINFONAVIT);
			
			float[] widthsINFONAVIT = new float[] {30f, 40f, 30f, 40f};
			PdfPTable nestedINFONAVIT = new PdfPTable(4);
			nestedINFONAVIT.SetWidths(widthsINFONAVIT);
			nestedINFONAVIT.WidthPercentage = 100;
			nestedINFONAVIT.HorizontalAlignment = 0;
			nestedINFONAVIT.AddCell(PDFs.TitWhite111312("Num. INFONAVIT"));
   		    nestedINFONAVIT.AddCell(PDFs.TexWhite111111(Numero_infonavit));
   		    nestedINFONAVIT.AddCell(PDFs.TitWhite111312("Tarifa INFONAVIT"));
   		    nestedINFONAVIT.AddCell(PDFs.TexWhite111111(((Convert.ToDouble(new Conexion_Servidor.Anticipos.SQL_Anticipos().Infonavit(idOperador)))).ToString("C")));
   		    document.Add(nestedINFONAVIT);
   		    document.Add(espacio);
			
   		    PdfPTable tableSalario = new PdfPTable(1);
			tableSalario.WidthPercentage = 100;
			tableSalario.HorizontalAlignment = 0;
			PdfPCell headerSalario = new PdfPCell(PDFs.TitLgray115312("SALARIO"));
			headerSalario.Colspan = 1;
			tableSalario.AddCell(headerSalario);
			document.Add(tableSalario);
			
			float[] widthsSalario = new float[] {30f, 40f, 30f, 40f};
			PdfPTable nestedSalario = new PdfPTable(4);
			nestedSalario.SetWidths(widthsSalario);
			nestedSalario.WidthPercentage = 100;
			nestedSalario.HorizontalAlignment = 0;
   		    nestedSalario.AddCell(PDFs.TitWhite111312("Tipo de salario"));
   		    if(new Conexion_Servidor.Operador.SQL_Operador().Puesto(idOperador)=="OPERADOR")
   		    	nestedSalario.AddCell(PDFs.TexWhite111111("VARIABLE"));
   		    else
   		    	nestedSalario.AddCell(PDFs.TexWhite111111("FIJO"));	

   		    nestedSalario.AddCell(PDFs.TitWhite111312("Salario Base $"));
   		    nestedSalario.AddCell(PDFs.TexWhite111111(((Convert.ToDouble(new Conexion_Servidor.Operador.SQL_Operador().SalarioBase(idOperador)))).ToString("C")));
   		    document.Add(nestedSalario);
   		    document.Add(espacio);
   		    
			PdfPTable tableContratacion = new PdfPTable(1);
			tableContratacion.WidthPercentage = 100;
			tableContratacion.HorizontalAlignment = 0;
			PdfPCell headerContratacion = new PdfPCell(PDFs.TitLgray115312("CONTRATACIÓN"));
			headerContratacion.Colspan = 1;
			tableContratacion.AddCell(headerContratacion);
			document.Add(tableContratacion);
			
			float[] widthsContratacion = new float[] {21.5f, 78.5f};
			PdfPTable nestedContratacion = new PdfPTable(2);
			nestedContratacion.SetWidths(widthsContratacion);
			nestedContratacion.WidthPercentage = 100;
			nestedContratacion.HorizontalAlignment = 0;
   		    nestedContratacion.AddCell(PDFs.TitWhite111312("Tipo Contratación"));
   		    nestedContratacion.AddCell(PDFs.TexWhite111111("PERMANENTE"));
   		    nestedContratacion.AddCell(PDFs.TitWhite111312("Fecha de Ingreso"));
   		    nestedContratacion.AddCell(PDFs.TexWhite111111(""));
   		    nestedContratacion.AddCell(PDFs.TitWhite111312("Puesto"));
   		    nestedContratacion.AddCell(PDFs.TexWhite111111(new Conexion_Servidor.Operador.SQL_Operador().Puesto(idOperador)));
   		    document.Add(nestedContratacion);
   		    document.Add(espacio);
			
   		    PdfPTable tableContratacion3 = new PdfPTable(1);
			tableContratacion3.WidthPercentage = 100;
			tableContratacion3.HorizontalAlignment = 1;
			PdfPCell headerContratacion3 = new PdfPCell(PDFs.TitLgray115312("PATRON"));
			headerContratacion3.Colspan = 1;
			tableContratacion3.AddCell(headerContratacion3);
			document.Add(tableContratacion3);
   		    
			int booleano = 0;
   		    float[] widthsContratacion2 = new float[] {21.5f, 78.5f};
			PdfPTable nestedContratacion2 = new PdfPTable(2);
			nestedContratacion2.SetWidths(widthsContratacion2);
			nestedContratacion2.WidthPercentage = 100;
			conn.getAbrirConexion("select NombrePatron, ns_patron " +
				                      "from OperadorContrato " +
				                      "WHERE IdOperador="+idOperador+"" +
				                      "order by ID DESC");
			conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					nestedContratacion2.AddCell(PDFs.TitWhite111312("Patrón"));
					nestedContratacion2.AddCell(PDFs.TexWhite111111(conn.leer["NombrePatron"].ToString()));
					nestedContratacion2.AddCell(PDFs.TitWhite111312("Numero Patrón"));
					nestedContratacion2.AddCell(PDFs.TexWhite111111(conn.leer["ns_patron"].ToString()));
					booleano = 1;
				}
			conn.conexion.Close();
			if(booleano!=1)
			{
				conn.getAbrirConexion("select NombrePatron, ns_patron " +
				                      "from OperadorContrato " +
				                      "WHERE TipoContrato='Planta' and IdOperador ="+idOperador);
				conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						nestedContratacion2.AddCell(PDFs.TitWhite111312("Patrón"));
						nestedContratacion2.AddCell(PDFs.TexWhite111111(conn.leer["NombrePatron"].ToString()));
						nestedContratacion2.AddCell(PDFs.TitWhite111312("Numero Patrón"));
						nestedContratacion2.AddCell(PDFs.TexWhite111111(conn.leer["ns_patron"].ToString()));
					}
				conn.conexion.Close();
			}
			
			document.Add(nestedContratacion2);
			document.Add(espacio);
   		    
			PdfPTable tableTelefonos = new PdfPTable(1);
			tableTelefonos.WidthPercentage = 60;
			tableTelefonos.HorizontalAlignment = 1;
			PdfPCell headerTelefonos = new PdfPCell(PDFs.TitLgray115312("TELEFONOS"));
			headerTelefonos.Colspan = 1;
			tableTelefonos.AddCell(headerTelefonos);
			document.Add(tableTelefonos);
			
			PdfPTable nestedTelefonos = new PdfPTable(3);
			nestedTelefonos.WidthPercentage = 60;
			nestedTelefonos.HorizontalAlignment = 1;
			nestedTelefonos.AddCell(PDFs.TitWhite111312("Tipo"));
			nestedTelefonos.AddCell(PDFs.TitWhite111312("Descripción"));
   		    nestedTelefonos.AddCell(PDFs.TitWhite111312("Teléfono"));

   		    conn.getAbrirConexion("select T.tipo, T.Descripcion, T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Alias!='Admvo' and Alias!='ADMINOO' and O.ID="+idOperador);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				 nestedTelefonos.AddCell(PDFs.TexWhite111111(conn.leer["tipo"].ToString()));
				 nestedTelefonos.AddCell(PDFs.TexWhite111111(conn.leer["Descripcion"].ToString()));
				 nestedTelefonos.AddCell(PDFs.TexWhite111111(conn.leer["Telefono"].ToString()));
			}
			conn.conexion.Close();
			
   		    document.Add(nestedTelefonos);
   		    document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			PdfPTable nestedFirma = new PdfPTable(1);
			nestedFirma.WidthPercentage = 30;
			nestedFirma.HorizontalAlignment = 1;
   		    nestedFirma.AddCell(PDFs.SeparadorTableGris50("."));
   		    nestedFirma.AddCell(PDFs.TitWhite115210("Firma del Empleado"));
			document.Add(nestedFirma);
		}
		#endregion
		
		#region CONTRATO VIAJE ESPECIAL
		public void FormatoContratoVentas(Document document, PdfWriter writer, String Cliente, String Telefono, String Domicilio, 
		                                  String Destino, String Fecha_Salida, String Hora_Salida, String Hora_Regreso, 
		                                  String NumUnidad, String Pasajeros, String Colonia, String Cruces, 
		                                  String Saldo, String Anticipos, String Precio, String Fecha_Regreso)
		{
			//Variables
			Convertir con = new Convertir();
			PdfContentByte cb = writer.DirectContent;
			document.Add(PDFs.LogoFactura(writer));
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
			
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			PdfPTable tableC = new PdfPTable(1);
			tableC.WidthPercentage = 80;
			tableC.HorizontalAlignment = 1;
			PdfPCell header = new PdfPCell(PDFs.EncWhite215209("Contrato de Servicios LAR"));
			tableC.AddCell(header);
			document.Add(tableC);
			
			document.Add(PDFs.TextoPagare("                           GUADALAJARA, JAL. A "+DateTime.Now.ToLongDateString().ToUpper()));
			document.Add(espacio);
			
			PdfPTable tableCPesonales = new PdfPTable(1);
			tableCPesonales.WidthPercentage = 80;
			tableCPesonales.HorizontalAlignment = 1;
			PdfPCell headerPesonales = new PdfPCell(PDFs.Enclgray215209("DATOS DEL VIAJE"));
			headerPesonales.Colspan = 1;
			tableCPesonales.AddCell(headerPesonales);
			document.Add(tableCPesonales);
			
			float[] widths1 = new float[] {50f, 160f};
			PdfPTable nestedpersonales0 = new PdfPTable(2);
			nestedpersonales0.SetWidths(widths1);
			nestedpersonales0.WidthPercentage = 80;
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Nombre(s)"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Cliente+"("+Telefono+")"));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Dirección"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Domicilio));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Destino"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Destino));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Nombre del Operador"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(""));
			document.Add(nestedpersonales0);
			
			float[] widths0 = new float[] {50f, 55f, 50f, 55f};
			PdfPTable nestedpersonales = new PdfPTable(4);
			nestedpersonales.SetWidths(widths0);
			nestedpersonales.WidthPercentage = 80;
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Salida"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(Fecha_Salida+" a las "+Hora_Salida));
   		    if(Fecha_Salida!=Fecha_Regreso)
   		    {
	   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Regreso"));
	   		    nestedpersonales.AddCell(PDFs.TexWhite111107(Fecha_Regreso+" a las "+Hora_Regreso));
   		    }
   		    else
   		    {
   		    	nestedpersonales.AddCell(PDFs.TitWhite114308("Regreso"));
	   		    nestedpersonales.AddCell(PDFs.TexWhite111107(Hora_Regreso));
   		    }
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Unidades Contratadas"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(NumUnidad));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Numero de Unidad"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(""));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Plazas "));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(Pasajeros));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Seguro de Viajero "));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107("SI"));
			document.Add(nestedpersonales);
			
			float[] widths2 = new float[] {50f, 160f};
			PdfPTable nestedpersonales2 = new PdfPTable(2);
			nestedpersonales2.SetWidths(widths2);
			nestedpersonales2.WidthPercentage = 80;
			nestedpersonales2.AddCell(PDFs.TitWhite114308("Salidad de "));
   		    nestedpersonales2.AddCell(PDFs.TexWhite111107("GUADALAJARA A "+Destino));
   		    nestedpersonales2.AddCell(PDFs.TitWhite114308("Regreso de "));
   		    nestedpersonales2.AddCell(PDFs.TexWhite111107(Destino+" A GUADALAJARA"));
   		   	nestedpersonales2.AddCell(PDFs.TitWhite114308("Itinerario del viaje"));
   		    nestedpersonales2.AddCell(PDFs.TexWhite111107("GUADALAJARA - "+Destino+" - GUADALAJARA"));
			document.Add(nestedpersonales2);
			document.Add(espacio);
			
			PdfPTable tableResponsable = new PdfPTable(1);
			tableResponsable.WidthPercentage = 80;
			tableResponsable.HorizontalAlignment = 1;
			PdfPCell headerResponsable = new PdfPCell(PDFs.Enclgray215209("RESPONSABLE"));
			headerResponsable.Colspan = 1;
			tableResponsable.AddCell(headerResponsable);
			document.Add(tableResponsable);
			
			float[] widthsResponsable = new float[] {50f, 55f, 50f, 55f};
			PdfPTable nestedResponsable = new PdfPTable(4);
			nestedResponsable.SetWidths(widthsResponsable);
			nestedResponsable.WidthPercentage = 80;
   		    nestedResponsable.AddCell(PDFs.TitWhite114308("Nombre"));
   		    nestedResponsable.AddCell(PDFs.TexWhite111107(""));
   		    nestedResponsable.AddCell(PDFs.TitWhite114308("Telefono"));
   		    nestedResponsable.AddCell(PDFs.TexWhite111107(""));
			document.Add(nestedResponsable);
			document.Add(espacio);
			
			PdfPTable tableDomicilio = new PdfPTable(1);
			tableDomicilio.WidthPercentage = 80;
			tableDomicilio.HorizontalAlignment = 1;
			PdfPCell headerDomicilio = new PdfPCell(PDFs.Enclgray215209("DOMICILIO"));
			headerDomicilio.Colspan = 1;
			tableDomicilio.AddCell(headerDomicilio);
			document.Add(tableDomicilio);
			
			float[] widthsdomicilio = new float[] {50f, 55f, 50f, 55f};
			PdfPTable nestedDomicilio = new PdfPTable(4);
			nestedDomicilio.SetWidths(widthsdomicilio);
			nestedDomicilio.WidthPercentage = 80;
   		    nestedDomicilio.AddCell(PDFs.TitWhite114308("Domicilio"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111107(Domicilio));
   		    nestedDomicilio.AddCell(PDFs.TitWhite114308("Colonia"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111107(Colonia));
			document.Add(nestedDomicilio);
			
			float[] widthsdomicilio2 = new float[] {50f, 160f};
			PdfPTable nestedDomicilio2 = new PdfPTable(2);
			nestedDomicilio2.SetWidths(widthsdomicilio2);
			nestedDomicilio2.WidthPercentage = 80;
   		    nestedDomicilio2.AddCell(PDFs.TitWhite114308("Cruces"));
   		    nestedDomicilio2.AddCell(PDFs.TexWhite111107(Cruces));
			document.Add(nestedDomicilio2);
			document.Add(espacio);
			
			PdfPTable tableCOSTO= new PdfPTable(1);
			tableCOSTO.WidthPercentage = 80;
			tableCOSTO.HorizontalAlignment = 1;
			PdfPCell headerCOSTO = new PdfPCell(PDFs.Enclgray215209("IMPORTES"));
			headerCOSTO.Colspan = 1;
			tableCOSTO.AddCell(headerCOSTO);
			document.Add(tableCOSTO);
			
			float[] widthsIMPORTES = new float[] {50f, 160f};
			PdfPTable nestedIMPORTES = new PdfPTable(2);
			nestedIMPORTES.SetWidths(widthsIMPORTES);
			nestedIMPORTES.WidthPercentage = 80;
   		    nestedIMPORTES.AddCell(PDFs.TitWhite114308("Costo"));
   		    nestedIMPORTES.AddCell(PDFs.TexWhite111107(Convert.ToDouble(Precio).ToString("C")+" ("+(con.Convertir_Numero((Math.Truncate(Convert.ToDouble(Precio))).ToString())).ToUpper()+" PESOS 00/100 M.N.)"));
   		    nestedIMPORTES.AddCell(PDFs.TitWhite114308("Anticipo"));
   		    nestedIMPORTES.AddCell(PDFs.TexWhite111107(Convert.ToDouble(Anticipos).ToString("C")+" ("+(con.Convertir_Numero((Math.Truncate(Convert.ToDouble(Anticipos))).ToString())).ToUpper()+" PESOS 00/100 M.N.)"));
   		    nestedIMPORTES.AddCell(PDFs.TitWhite114308("Saldo"));
   		    Saldo = ((Convert.ToDouble(Precio) * Convert.ToDouble(NumUnidad)) - (Convert.ToDouble(Anticipos))).ToString();
   		    if(Convert.ToDouble(Saldo)>0)
   		    	nestedIMPORTES.AddCell(PDFs.TexWhite111107(Convert.ToDouble(Saldo).ToString("C")+" ("+(con.Convertir_Numero((Math.Truncate(Convert.ToDouble(Saldo))).ToString())).ToUpper()+" PESOS 00/100 M.N.)"));
   		    else
   		    	nestedIMPORTES.AddCell(PDFs.TexWhite111107("$0.00"));
			document.Add(nestedIMPORTES);
			document.Add(espacio);
			
			document.Add(PDFs.TextoPagare("                         NOTA IMPORTANTE: Al firmar del contrato debará cubrirse el 60% y el saldo al termino del servicio "));
			document.Add(PDFs.TextoPagare("                         Acepto el clausulado que se muestra en el anexo "));
			document.Add(espacio);
			
			float[] widthsfirma = new float[] {50f, 50f};
			PdfPTable datosfirma = new PdfPTable(2);
			datosfirma.SetWidths(widthsfirma);
			datosfirma.WidthPercentage = 80;
			datosfirma.HorizontalAlignment = 1;
   		    datosfirma.AddCell(PDFs.SeparadorTableGris50(""));
   		    datosfirma.AddCell(PDFs.SeparadorTableGris50(""));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Firma del Cliente"));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Sello y Firma del Prestador de Servicio"));
   		    document.Add(datosfirma);
			document.Add(new Paragraph(espacio));
			
   		    document.Add(PDFs.TextoPagare("                         Por este pagare debo(emos) presente pagaré(mos) incondicionalmente a la orden de LUIS ARRIAGA RUIZ, en esta ciudad "));
   		    document.Add(PDFs.TextoPagare("                         de Guadalajara, Jal. o en cualquier otra en que se (nos) requiera de pago."));
			document.Add(PDFs.TextoPagare("                         el día ___ de _______________ de 20___ la cantidad de:                                                                                          PESOS 00/100 M.N."));
		    document.Add(PDFs.TextoPagare("                         Valor recibido en moneda nacional a mi entera satisfacción."));
		    document.Add(PDFs.TextoPagare("                         Este pagaré es mercantil y esta rígido por la ley general de títulos y operaciones de crédito en su artículo 173 parte final "));
		    document.Add(PDFs.TextoPagare("                         y artículos correlativos, por no ser pagare domiciliado. De no verificarse el pago de la cantidad que este expresa en el "));
		    document.Add(PDFs.TextoPagare("                         pagare el día de su vencimiento causará un interés de ___% mensual hasta su total liquidación."));
		    document.Add(new Paragraph(espacio));
		    
		    PdfPTable cellfirma2 = new PdfPTable(1);
			cellfirma2.WidthPercentage = 100;
			cellfirma2.HorizontalAlignment = 1;
			cellfirma2.AddCell(PDFs.SeparadorTableGris50(""));
			cellfirma2.AddCell(PDFs.TitWhite115308("Nombre y Firma de conformidad"));
		    
		    float[] widthspagare = new float[] {50f, 50f};
			PdfPTable datosPagare = new PdfPTable(2);
			datosPagare.SetWidths(widthspagare);
			datosPagare.WidthPercentage = 80;
			datosPagare.HorizontalAlignment = 1;
			datosPagare.AddCell(PDFs.SeparadorTableGris30("Guadalajara, Jalisco a "+DateTime.Now.ToLongDateString()+"                                                                "));
   		    datosPagare.AddCell(cellfirma2);
			datosPagare.HorizontalAlignment = 1;
			document.Add(datosPagare);
		}
		#endregion
		
		#region CONTRATO VIAJE ESPECIAL NUEVO
		public void FormatoContratoVentas2(Document document, PdfWriter writer, Int32 id_re)
		{
			writer.PageEvent = new PDFooterVentas(4);
			double anticipos = 0;
			string fechaAnticipo = "";
			String consulta = @" SELECT * FROM ANTICIPOS_ESPECIALES WHERE ID_RE = "+id_re;		
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				anticipos = anticipos + Convert.ToDouble(conn.leer["CANTIDAD"].ToString());
				
				if(fechaAnticipo.Length == 0)
					fechaAnticipo = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyyy");
				else
					fechaAnticipo = fechaAnticipo + " - " + Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyyy");
			}
			conn.conexion.Close();
			
			consulta = @" select vpn.FACTURA, vpn.FECHA_FACTURA, RE.SALDO, RE.PRECIO, C.Rumbo, RE.DOMICILIO, RE.cantidad_usuarios, CS.Nombre, CS.Telefono, DT.CALLE_S +' COL.: '+DT.COLONIA_S+ ' CIUDAD: '+ DT.CIUDAD_S AS DIRECCION, C.Estado, RE.DESTINO, 
								re.FECHA_SALIDA, VPN.HORA_SALIDA, VPN.UBICACION_PARTIDA, RE.FECHA_REGRESO, VPN.HORA_REGRESO, RE.CANT_UNIDADES, RE.RESPONSABLE, DT.TELEFONO_R, VPN.ITINERARIO, RE.OBSERVACIONES from VIAJE_PROSPECTO_NUEVO VPN, 
									RUTA_ESPECIAL RE, Cliente C, ContactoServicio CS, DETALLE_SERVICIO DT where VPN.ID_RE = re.ID_RE and re.ID_C = c.ID and c.ID = 
										cs.IdCliente AND VPN.ID = DT.ID_COTIZACION AND RE.ID_RE = "+id_re;	
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			conn.leer.Read();
			
			Convertir con = new Convertir();
			PdfContentByte cb = writer.DirectContent;
			document.Add(PDFs.LogoFactura2(writer));
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 5, iTextSharp.text.Font.BOLD ));
			
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			PdfPTable tableC = new PdfPTable(1);
			tableC.WidthPercentage = 80;
			tableC.HorizontalAlignment = 1;
			PdfPCell header = new PdfPCell(PDFs.EncWhite215209("Contrato de Servicios LAR"));
			tableC.AddCell(header);
			document.Add(tableC);
			
			document.Add(PDFs.TextoPagare("                           GUADALAJARA, JAL. A "+DateTime.Now.ToLongDateString().ToUpper()));
			document.Add(espacio);
			
			PdfPTable tableCPesonales = new PdfPTable(1);
			tableCPesonales.WidthPercentage = 80;
			tableCPesonales.HorizontalAlignment = 1;
			PdfPCell headerPesonales = new PdfPCell(PDFs.Enclgray215209("DATOS DEL SERVICIO"));
			headerPesonales.Colspan = 1;
			tableCPesonales.AddCell(headerPesonales);
			document.Add(tableCPesonales);
			
			float[] widths1Nombre = new float[] {50f, 80f, 25f, 55f};
			PdfPTable nestedpersonales0Nombre = new PdfPTable(4);
			nestedpersonales0Nombre.SetWidths(widths1Nombre);
			nestedpersonales0Nombre.WidthPercentage = 80;
   		    nestedpersonales0Nombre.AddCell(PDFs.TitWhite114308("Nombre del Contratante"));
   		    nestedpersonales0Nombre.AddCell(PDFs.TexWhite111107(conn.leer["Nombre"].ToString()));
   		    nestedpersonales0Nombre.AddCell(PDFs.TitWhite114308("Teléfono(s) "));
   		    nestedpersonales0Nombre.AddCell(PDFs.TexWhite111107(conn.leer["Telefono"].ToString()));
			document.Add(nestedpersonales0Nombre);
			
			float[] widths1 = new float[] {50f, 160f};
			PdfPTable nestedpersonales0 = new PdfPTable(2);
			nestedpersonales0.SetWidths(widths1);
			nestedpersonales0.WidthPercentage = 80;
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Dirección del Contratante"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(conn.leer["DIRECCION"].ToString()));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Destino"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(conn.leer["DESTINO"].ToString()));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Nombre del Operador"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(""));
			document.Add(nestedpersonales0);
			
			float[] widthsSalidas = new float[] {50f, 25f, 10f, 20f, 50f, 25f, 10f, 20f};
			PdfPTable nestedSalidas = new PdfPTable(8);
			nestedSalidas.SetWidths(widthsSalidas);
			nestedSalidas.WidthPercentage = 80;
   		    nestedSalidas.AddCell(PDFs.TitWhite114308("Salida"));
   		    nestedSalidas.AddCell(PDFs.TexWhite111107(conn.leer["FECHA_SALIDA"].ToString().Substring(0,10)));
   		    nestedSalidas.AddCell(PDFs.TexWhite111107(" a las  "));
   		    nestedSalidas.AddCell(PDFs.TexWhite111107(conn.leer["HORA_SALIDA"].ToString()));
	   		nestedSalidas.AddCell(PDFs.TitWhite114308("Regreso"));
   		    nestedSalidas.AddCell(PDFs.TexWhite111107(conn.leer["FECHA_REGRESO"].ToString().Substring(0,10)));
   		    nestedSalidas.AddCell(PDFs.TexWhite111107(" a las  "));
   		    nestedSalidas.AddCell(PDFs.TexWhite111107(conn.leer["HORA_REGRESO"].ToString()));   		    
			document.Add(nestedSalidas);
   		    
			float[] widths0 = new float[] {50f, 55f, 50f, 55f};
			PdfPTable nestedpersonales = new PdfPTable(4);
			nestedpersonales.SetWidths(widths0);
			nestedpersonales.WidthPercentage = 80;
			/*
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Salida"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(conn.leer["FECHA_SALIDA"].ToString().Substring(0,10) +" | a las | "+conn.leer["HORA_SALIDA"].ToString()));
   		    if(conn.leer["FECHA_SALIDA"].ToString() != conn.leer["FECHA_REGRESO"].ToString()){
	   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Regreso"));
	   		    nestedpersonales.AddCell(PDFs.TexWhite111107(conn.leer["FECHA_REGRESO"].ToString().Substring(0,10)+" | a las | "+conn.leer["HORA_REGRESO"].ToString()));
   		    }else{
   		    	nestedpersonales.AddCell(PDFs.TitWhite114308("Regreso"));
	   		    nestedpersonales.AddCell(PDFs.TexWhite111107(conn.leer["HORA_REGRESO"].ToString().Substring(0,8)));
   		    }*/
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Unidades Contratadas"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(conn.leer["CANT_UNIDADES"].ToString()));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Número de Unidad"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(""));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Plazas "));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(conn.leer["cantidad_usuarios"].ToString()));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Seguro de Viajero "));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107("SI"));
			document.Add(nestedpersonales);
			
			float[] widths2 = new float[] {50f, 160f};
			PdfPTable nestedpersonales2 = new PdfPTable(2);
			nestedpersonales2.SetWidths(widths2);
			nestedpersonales2.WidthPercentage = 80;
			nestedpersonales2.AddCell(PDFs.TitWhite114308("Salidad de "));
   		    nestedpersonales2.AddCell(PDFs.TexWhite111107("GUADALAJARA A "+conn.leer["DESTINO"].ToString()));
   		    nestedpersonales2.AddCell(PDFs.TitWhite114308("Regreso de "));
   		    nestedpersonales2.AddCell(PDFs.TexWhite111107(conn.leer["DESTINO"].ToString()+" A GUADALAJARA"));
   		   	nestedpersonales2.AddCell(PDFs.TitWhite114308("Itinerario del viaje"));
   		    nestedpersonales2.AddCell(PDFs.TexWhite111107("GUADALAJARA - "+conn.leer["ITINERARIO"].ToString()+" Destino: "+conn.leer["DESTINO"].ToString()+" - GUADALAJARA"));
   		    /*
   		   	nestedpersonales2.AddCell(PDFs.TitWhite114308("Observaciones del viaje"));
   		   	nestedpersonales2.AddCell(PDFs.TexWhite111107(conn.leer["OBSERVACIONES"].ToString()));
   		   	nestedpersonales2.AddCell(PDFs.TitWhite114308("Facturar Servicio"));
   		   	nestedpersonales2.AddCell(PDFs.TexWhite111107( ((conn.leer["FACTURA"].ToString().Equals("0"))? "NO" : "SI, el cliente desea la factura para el día "+Convert.ToDateTime(conn.leer["FECHA_FACTURA"]).ToString("dd/MM/yyyy") )  ));
   		   	*/
   		   	
   		   	/*
   		   	if( !(conn.leer["FACTURA"].ToString().Equals("0")) ){
				Conexion_Servidor.SQL_Conexion conn2 = new Conexion_Servidor.SQL_Conexion();
				String consulta = "select * from DATOS_FACTURA where RAZON_SOCIAL='"+razon_social+"'";
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						txtRazon.Text=conn.leer["RAZON_SOCIAL"].ToString();
						txtDomicilio.Text=conn.leer["DOMICILIO"].ToString();
						txtRFC.Text=conn.leer["RFC"].ToString();
						txtCp.Text=conn.leer["CP"].ToString();
						txtColonia.Text=conn.leer["COLONIA"].ToString();
						txtCiudad.Text=conn.leer["CIUDAD"].ToString();
					}			
					conn.conexion.Close();
			
   		   		nestedpersonales2.AddCell(PDFs.TitWhite114308("Datos de Facturación"));
	   		   	nestedpersonales2.AddCell(PDFs.TexWhite111107( "Razon Social" ));
   		   	}*/
	   		   
			document.Add(nestedpersonales2);
			document.Add(espacio);
			
			PdfPTable tableResponsable = new PdfPTable(1);
			tableResponsable.WidthPercentage = 80;
			tableResponsable.HorizontalAlignment = 1;
			PdfPCell headerResponsable = new PdfPCell(PDFs.Enclgray215209("RESPONSABLE DURANTE EL SERVICIO"));
			headerResponsable.Colspan = 1;
			tableResponsable.AddCell(headerResponsable);
			document.Add(tableResponsable);
			
			float[] widthsResponsable = new float[] {50f, 55f, 50f, 55f};
			PdfPTable nestedResponsable = new PdfPTable(4);
			nestedResponsable.SetWidths(widthsResponsable);
			nestedResponsable.WidthPercentage = 80;
   		    nestedResponsable.AddCell(PDFs.TitWhite114308("Nombre"));
   		    nestedResponsable.AddCell(PDFs.TexWhite111107(conn.leer["RESPONSABLE"].ToString()));
   		    nestedResponsable.AddCell(PDFs.TitWhite114308("Teléfono(s)"));
   		    nestedResponsable.AddCell(PDFs.TexWhite111107(conn.leer["TELEFONO_R"].ToString()));
			document.Add(nestedResponsable);
			document.Add(espacio);
			
			PdfPTable tableDomicilio = new PdfPTable(1);
			tableDomicilio.WidthPercentage = 80;
			tableDomicilio.HorizontalAlignment = 1;
			PdfPCell headerDomicilio = new PdfPCell(PDFs.Enclgray215209("DOMICILIO DEL SERVICIO"));
			headerDomicilio.Colspan = 1;
			tableDomicilio.AddCell(headerDomicilio);
			document.Add(tableDomicilio);
			
			float[] widthsdomicilio = new float[] {50f, 160F};
			PdfPTable nestedDomicilio = new PdfPTable(2);
			nestedDomicilio.SetWidths(widthsdomicilio);
			nestedDomicilio.WidthPercentage = 80;
   		    nestedDomicilio.AddCell(PDFs.TitWhite114308("Domicilio"));
   		    nestedDomicilio.AddCell(PDFs.TexWhite111107(conn.leer["DOMICILIO"].ToString()));
			document.Add(nestedDomicilio);
			
			float[] widthsdomicilio2 = new float[] {50f, 160f};
			PdfPTable nestedDomicilio2 = new PdfPTable(2);
			nestedDomicilio2.SetWidths(widthsdomicilio2);
			nestedDomicilio2.WidthPercentage = 80;
   		    nestedDomicilio2.AddCell(PDFs.TitWhite114308("Referencias"));
   		    nestedDomicilio2.AddCell(PDFs.TexWhite111107(conn.leer["Rumbo"].ToString()));
			document.Add(nestedDomicilio2);
			document.Add(espacio);
			
			PdfPTable tableCOSTO= new PdfPTable(1);
			tableCOSTO.WidthPercentage = 80;
			tableCOSTO.HorizontalAlignment = 1;
			PdfPCell headerCOSTO = new PdfPCell(PDFs.Enclgray215209("IMPORTES"));
			headerCOSTO.Colspan = 1;
			tableCOSTO.AddCell(headerCOSTO);
			document.Add(tableCOSTO);
			
			float[] widthsIMPORTES = new float[] {50f, 160f};
			PdfPTable nestedIMPORTES = new PdfPTable(2);
			nestedIMPORTES.SetWidths(widthsIMPORTES);
			nestedIMPORTES.WidthPercentage = 80;
   		    nestedIMPORTES.AddCell(PDFs.TitWhite114308("Costo"));
   		    nestedIMPORTES.AddCell(PDFs.TexWhite111107(Convert.ToDouble(conn.leer["SALDO"].ToString()).ToString("C")+" ("+(con.Convertir_Numero((Math.Truncate(Convert.ToDouble(Convert.ToDouble(conn.leer["SALDO"].ToString()))).ToString())).ToUpper()+" PESOS 00/100 M.N.)"  )));
   		    nestedIMPORTES.AddCell(PDFs.TitWhite114308("Anticipo"));
   		    nestedIMPORTES.AddCell(PDFs.TexWhite111107(Convert.ToDouble(anticipos).ToString("C")+" ("+(con.Convertir_Numero((Math.Truncate(Convert.ToDouble(anticipos))).ToString())).ToUpper()+" PESOS 00/100 M.N.) "));
   		    nestedIMPORTES.AddCell(PDFs.TitWhite114308("Saldo"));
   		    String Saldo = ((Convert.ToDouble(conn.leer["SALDO"].ToString())) - (Convert.ToDouble(anticipos))).ToString();
   		   
   		    if(Convert.ToDouble(Saldo) > 0)
   		    	nestedIMPORTES.AddCell(PDFs.TexWhite111107(Convert.ToDouble(Saldo).ToString("C")+" ("+(con.Convertir_Numero((Math.Truncate(Convert.ToDouble(Saldo))).ToString())).ToUpper()+" PESOS 00/100 M.N.)"));
   		    else
   		    	nestedIMPORTES.AddCell(PDFs.TexWhite111107("$0.00"));
   		    
			document.Add(nestedIMPORTES);
			document.Add(espacio);
			
			document.Add(PDFs.TextoPagare("                         NOTA IMPORTANTE: A una vez realizado su pago (Anticipo / Liquidación) les solicitamos nos envié al siguiente correo electrónico "));
			document.Add(PDFs.TextoPagare("                         el comprobante del mismo; en el cual requerimos que especifique como ASUNTO DEL CORREO: (Nombre completo del contratante) "));
			document.Add(PDFs.TextoPagareBold("                         Correo: ventas@lar.com.mx"));
			document.Add(espacio);			
			document.Add(PDFs.TextoPagareBold("                          LOS DATOS ARRIBA ESPECIFICADOS SON LOS CORRECTOS DE ACUERDO A LA CONTRATACIÓN DE MI SERVICIO"));
			document.Add(espacio);	
			
			float[] widthsfirma = new float[] {50f, 50f};
			PdfPTable datosfirma = new PdfPTable(2);
			datosfirma.SetWidths(widthsfirma);
			datosfirma.WidthPercentage = 80;
			datosfirma.HorizontalAlignment = 1;
   		    datosfirma.AddCell(PDFs.SeparadorTableGris50(""));
   		    datosfirma.AddCell(PDFs.SeparadorTableGris50(""));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Firma del Responsable"));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Sello y Firma del Prestador de Servicio"));
   		    document.Add(datosfirma);
			document.Add(new Paragraph(espacio));
			//document.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));
			
   		    document.Add(PDFs.TextoPagare("                         Por este pagaré debo(emos) presente pagaré(mos) incondicionalmente a la orden de LUIS ARRIAGA RUIZ, en esta ciudad de"));
   		    document.Add(PDFs.TextoPagare("                         Guadalajara, Jal. o en cualquier otra en que se (nos) requiera de pago los montos calculados por Transportes LAR  que por"));
			document.Add(PDFs.TextoPagare("                         causas de la cláusula TERCERA en cuanto a kilometraje excedente se refiere, y a la cláusula QUINTA en caso de daños que a"));
		    document.Add(PDFs.TextoPagare("                         la unidad se refieran, esto una vez terminado el servicio en un plazo máximo de 72 Hrs."));
		    document.Add(PDFs.TextoPagare("                         Este pagaré es mercantil y esta rígido por la ley general de títulos y operaciones de crédito en su ART. 173 parte final y artículos"));
		    document.Add(PDFs.TextoPagare("                         correlativos, por no ser pagare domiciliado. De no verificarse el pago de la cantidad que este expresa en el pagaré el día de su "));
		    document.Add(PDFs.TextoPagare("                         vencimiento causará un interés de 5% mensual hasta su total liquidación."));
		    document.Add(new Paragraph(espacio));
		    document.Add(PDFs.TextoPagare("                         Guadalajara, Jalisco a "+DateTime.Now.ToLongDateString()+"                                                                "));
		   // document.Add(new Paragraph(espacio));
		    document.Add(new Paragraph(espacio));
		    
		    PdfPTable cellfirma2 = new PdfPTable(1);
			cellfirma2.WidthPercentage = 100;
			cellfirma2.HorizontalAlignment = 1;
			cellfirma2.AddCell(PDFs.SeparadorTableGris50(""));
			cellfirma2.AddCell(PDFs.TitWhite115308("Nombre y Firma de conformidad del Responsable"));
		    
		    float[] widthsAnexa = new float[] {100f};
			PdfPTable datosAnexa = new PdfPTable(1);
			datosAnexa.SetWidths(widthsAnexa);
			datosAnexa.WidthPercentage = 80;
			datosAnexa.HorizontalAlignment = 1;
			datosAnexa.AddCell(PDFs.TextoPagareBold12(" Se anexa hoja de movimientos adicionales al servicio contratado ")); 
			datosAnexa.HorizontalAlignment = 1;
			document.Add(datosAnexa);
			document.Add(espacio);
			
			float[] widthspagare = new float[] {50f, 50f};
			PdfPTable datosPagare = new PdfPTable(2);
			datosPagare.SetWidths(widthspagare);
			datosPagare.WidthPercentage = 80;
			datosPagare.HorizontalAlignment = 1;
   		    datosPagare.AddCell(PDFs.SeparadorTableGris30SinBorde(""));
   		    datosPagare.AddCell(cellfirma2);
			document.Add(datosPagare);
			conn.conexion.Close();			
			
			
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////// SEGUNDA PÁGINA MOVIMIENTOS ADICIONALES /////////////////////////////////////////////////////////////////////
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
						
			document.NewPage();
			writer.PageEvent = new PDFooterVentas(4);
			document.Add(new Paragraph(espacio));		
			
			float[] widthsAvisoMov = new float[]{470f};
			PdfPTable TablaAvisoMov = new PdfPTable(1);
			TablaAvisoMov.SetWidths(widthsAvisoMov);
			TablaAvisoMov.WidthPercentage = 100;
			TablaAvisoMov.HorizontalAlignment = 0; 
			TablaAvisoMov.TotalWidth = 470f;
			
   		    document.Add(PDFs.TextoPagare14("                                                  MOVIMIENTOS ADICIONALES "));
			document.Add(espacio);
		    			
				PdfPCell headerAvisoMov = new PdfPCell(PDFs.Enclgray215209("LLENE SEGÚN CORRESPONDA A LA OPCIÓN A U OPCIÓN B"));
				headerAvisoMov.HorizontalAlignment = 1;
			TablaAvisoMov.AddCell(headerAvisoMov);
			document.Add(TablaAvisoMov);
			document.Add(new Paragraph(espacio));
			document.Add(new Paragraph(espacio));
			
			//////////////////////////////////////////////////////////////////////////////////// OPCION A  ////////////////////////////////////////////////////////////////////////////////////				
							
   		    document.Add(PDFs.TextoPagare14(" Opción A"));
			document.Add(espacio);
			float[] widthsMovimientos = new float[]{50f, 185f, 165f, 70f};
			PdfPTable TablaMovimientos = new PdfPTable(4);
			TablaMovimientos.SetWidths(widthsMovimientos);
			TablaMovimientos.WidthPercentage = 100;
			TablaMovimientos.HorizontalAlignment = 0; 
			TablaMovimientos.TotalWidth = 470f;
		
				PdfPCell headerOpcionA = new PdfPCell(PDFs.Enclgray215209(" Movimientos Adicionales"));
				headerOpcionA.HorizontalAlignment = 0;
				headerOpcionA.Colspan = 4;				
			TablaMovimientos.AddCell(headerOpcionA);
										
				PdfPCell headerOpcionAMov = new PdfPCell(PDFs.TitWhite11430802("Movimiento"));
				headerOpcionAMov.HorizontalAlignment = 1;
				headerOpcionAMov.PaddingTop = 3f;	
				headerOpcionAMov.PaddingBottom = 3f;	
				headerOpcionAMov.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov);
			
				PdfPCell headerOpcionASal = new PdfPCell(PDFs.TitWhite11430802("Lugar de Salida"));
				headerOpcionASal.HorizontalAlignment = 1;
				headerOpcionASal.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionASal);
			
				PdfPCell headerOpcionALleg = new PdfPCell(PDFs.TitWhite11430802("Lugar de Llegada"));
				headerOpcionALleg.HorizontalAlignment = 1;
				headerOpcionALleg.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionALleg);
			
				PdfPCell headerOpcionAKM = new PdfPCell(PDFs.TitWhite11430802("KM Recorridos"));
				headerOpcionAKM.HorizontalAlignment = 1;
				headerOpcionAKM.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAKM);
												
				PdfPCell headerOpcionAMov1 = new PdfPCell(PDFs.TitWhite11430802("1"));
				headerOpcionAMov1.HorizontalAlignment = 1;
				headerOpcionAMov1.PaddingTop = 5f;	
				headerOpcionAMov1.PaddingBottom = 5f;	
				headerOpcionAMov1.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov1);				
			
				PdfPCell headerOpcionASal1 = new PdfPCell(PDFs.TitWhite11430802("    "));
				headerOpcionASal1.HorizontalAlignment = 1;
				headerOpcionASal1.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionASal1);
			
				PdfPCell headerOpcionALleg1 = new PdfPCell(PDFs.TitWhite11430802("    "));
				headerOpcionALleg1.HorizontalAlignment = 1;
				headerOpcionALleg1.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionALleg1);
			
				PdfPCell headerOpcionAKM1 = new PdfPCell(PDFs.TitWhite11430802("   "));
				headerOpcionAKM1.HorizontalAlignment = 1;
				headerOpcionAKM1.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAKM1);	
			
				PdfPCell headerOpcionAMov2 = new PdfPCell(PDFs.TitWhite11430802("2"));
				headerOpcionAMov2.HorizontalAlignment = 1;
				headerOpcionAMov2.PaddingTop = 5f;	
				headerOpcionAMov2.PaddingBottom = 5f;	
				headerOpcionAMov2.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov2);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
				PdfPCell headerOpcionAMov3 = new PdfPCell(PDFs.TitWhite11430802("3"));
				headerOpcionAMov3.HorizontalAlignment = 1;
				headerOpcionAMov3.PaddingTop = 5f;	
				headerOpcionAMov3.PaddingBottom = 5f;	
				headerOpcionAMov3.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov3);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
				PdfPCell headerOpcionAMov4 = new PdfPCell(PDFs.TitWhite11430802("4"));
				headerOpcionAMov4.HorizontalAlignment = 1;
				headerOpcionAMov4.PaddingTop = 5f;	
				headerOpcionAMov4.PaddingBottom = 5f;	
				headerOpcionAMov4.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov4);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);
				PdfPCell headerOpcionAMov5 = new PdfPCell(PDFs.TitWhite11430802("5"));
				headerOpcionAMov5.HorizontalAlignment = 1;
				headerOpcionAMov5.PaddingTop = 5f;	
				headerOpcionAMov5.PaddingBottom = 5f;	
				headerOpcionAMov5.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov5);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);
				PdfPCell headerOpcionAMov6 = new PdfPCell(PDFs.TitWhite11430802("6"));
				headerOpcionAMov6.HorizontalAlignment = 1;
				headerOpcionAMov6.PaddingTop = 5f;	
				headerOpcionAMov6.PaddingBottom = 5f;	
				headerOpcionAMov6.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov6);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
				PdfPCell headerOpcionAMov7 = new PdfPCell(PDFs.TitWhite11430802("7"));
				headerOpcionAMov7.HorizontalAlignment = 1;
				headerOpcionAMov7.PaddingTop = 5f;	
				headerOpcionAMov7.PaddingBottom = 5f;	
				headerOpcionAMov7.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov7);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
				PdfPCell headerOpcionAMov8 = new PdfPCell(PDFs.TitWhite11430802("8"));
				headerOpcionAMov8.HorizontalAlignment = 1;
				headerOpcionAMov8.PaddingTop = 5f;	
				headerOpcionAMov8.PaddingBottom = 5f;	
				headerOpcionAMov8.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov8);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
				PdfPCell headerOpcionAMov9 = new PdfPCell(PDFs.TitWhite11430802("9"));
				headerOpcionAMov9.HorizontalAlignment = 1;
				headerOpcionAMov9.PaddingTop = 5f;	
				headerOpcionAMov9.PaddingBottom = 5f;	
				headerOpcionAMov9.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov9);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
				PdfPCell headerOpcionAMov10 = new PdfPCell(PDFs.TitWhite11430802("10"));
				headerOpcionAMov10.HorizontalAlignment = 1;
				headerOpcionAMov10.PaddingTop = 5f;	
				headerOpcionAMov10.PaddingBottom = 5f;	
				headerOpcionAMov10.Colspan = 1;				
			TablaMovimientos.AddCell(headerOpcionAMov10);	
			TablaMovimientos.AddCell(headerOpcionASal1);
			TablaMovimientos.AddCell(headerOpcionALleg1);
			TablaMovimientos.AddCell(headerOpcionAKM1);	
			
			
				PdfPCell headerOpcionAFirmaC = new PdfPCell(PDFs.SeparadorTableGris50(" "));
				headerOpcionAFirmaC.HorizontalAlignment = 1;
				headerOpcionAFirmaC.Colspan = 2;				
			TablaMovimientos.AddCell(headerOpcionAFirmaC);	
			TablaMovimientos.AddCell(headerOpcionAFirmaC);
			
				PdfPCell headerOpcionAFirmaCli = new PdfPCell(PDFs.TitWhite115308("Firma del Responsable"));
				headerOpcionAFirmaCli.HorizontalAlignment = 1;	
				headerOpcionAFirmaCli.Colspan = 2;			
			TablaMovimientos.AddCell(headerOpcionAFirmaCli);
				PdfPCell headerOpcionAFirmaOpe = new PdfPCell(PDFs.TitWhite115308("Sello y Firma del Operador"));
				headerOpcionAFirmaOpe.HorizontalAlignment = 1;
				headerOpcionAFirmaOpe.Colspan = 2;				
			TablaMovimientos.AddCell(headerOpcionAFirmaOpe);	
			
			document.Add(TablaMovimientos);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			//////////////////////////////////////////////////////////////////////////////////// OPCION B  ////////////////////////////////////////////////////////////////////////////////////				
				
   		    document.Add(PDFs.TextoPagare14(" Opción B"));
			document.Add(espacio);
			float[] widthsMovimientosNO = new float[]{50f, 185f, 165f, 70f};
			PdfPTable TablaMovimientosNO = new PdfPTable(4);
			TablaMovimientosNO.SetWidths(widthsMovimientosNO);
			TablaMovimientosNO.WidthPercentage = 100;
			TablaMovimientosNO.HorizontalAlignment = 0; 
			TablaMovimientosNO.TotalWidth = 470f;
		
				PdfPCell headerOpcionB = new PdfPCell(PDFs.Enclgray215209(" NO Realice Movimientos Adicionales"));
				headerOpcionB.HorizontalAlignment = 0;
				headerOpcionB.Colspan = 4;				
			TablaMovimientosNO.AddCell(headerOpcionB);								
			
				PdfPCell headerOpcionBFirmaC = new PdfPCell(PDFs.SeparadorTableGris50(" "));
				headerOpcionBFirmaC.HorizontalAlignment = 1;
				headerOpcionBFirmaC.Colspan = 2;				
			TablaMovimientosNO.AddCell(headerOpcionBFirmaC);	
			TablaMovimientosNO.AddCell(headerOpcionBFirmaC);
			
				PdfPCell headerOpcionBFirmaCli = new PdfPCell(PDFs.TitWhite115308("Firma del Responsable"));
				headerOpcionBFirmaCli.HorizontalAlignment = 1;	
				headerOpcionBFirmaCli.Colspan = 2;			
			TablaMovimientosNO.AddCell(headerOpcionBFirmaCli);
				PdfPCell headerOpcionBFirmaOpe = new PdfPCell(PDFs.TitWhite115308("Sello y Firma del Operador"));
				headerOpcionBFirmaOpe.HorizontalAlignment = 1;
				headerOpcionBFirmaOpe.Colspan = 2;				
			TablaMovimientosNO.AddCell(headerOpcionBFirmaOpe);	
			document.Add(TablaMovimientosNO);
			document.Add(espacio);
			
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////// TERCERA PÁGINA CLAUSULAS ///////////////////////////////////////////////////////////////////////////
			/// &nbsp;&nbsp;&nbsp; - Servicio Especial Foráneo: $50 pesos por kilómetro excedido <p>
//														&nbsp;&nbsp;&nbsp; - Servicio Especial Local: $25 pesos por kilómetro excedido <p>
//														&nbsp;&nbsp;&nbsp; - Sprinter o Van Servicio Foráneo: $40 pesos por kilómetro excedido <p>
//														&nbsp;&nbsp;&nbsp; - Sprinter o Van Servicio Local: $18 pesos por kilómetro excedido <br>
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			
			document.NewPage();				
			writer.PageEvent = new PDFooterVentas(4);
			document.Add(CreateSimpleHtmlParagraph(@"CONTRATO DE MEDIACIÓN PARA LA PRESTACIÓN DE SERVICIOS DE TRANSPORTE TURISTICO ESCOLAR Y SERVCIO ESPECIALIZADO, QUE CELEBRAN POR UNA PARTE LA EMPRESA PRESTADORA DEL SERVICIO DE TRANSPORTACIÓN,
													 A QUIEN EN LO SUCESIVO SE LE DENOMINARÁ “TRANSPORTES LAR” Y POR LA OTRA EL CONTRATANTE RESPONSABLE DEL SERVICIO, EN LO SUCESIVO SE LE DENOMINARÁ “EL CLIENTE”, Y QUE SE SUJETAN AL TENOR DE LOS 
													SIGUIENTES ANTECEDENTES Y CLÁUSULAS: <br><br>
													EL CONTRATO SE EXTENDERÁ POR DUPLICADO Y DEBERÁ DISTRIBUIRSE UNA COPIA PARA EL CLIENTE Y LA COPIA PARA TRANSPORTES LAR <br>
								<html>
									<body>
										<p align='justify' style='line-height: 110%;'>
											<ul>
												 <li><b>PRIMERA.</b> Objeto. <b>“EL CLIENTE”</b> contrata los servicios de <b>“TRANSPORTES LAR”</b>, a fin de que este último proporcione el servicio de transportación de pasajeros que se detalla en la Carátula.<br></li>
												 <li><b>SEGUNDA</b>. <b>“TRANSPORTES LAR”</b> se obliga a mantener vigente la póliza de seguro de viajero por cada una de las unidades de transporte que utilice para dar el servicio en materia del 
													presente contrato, teniendo una cobertura de hasta 5,000 UMAS que es lo que establece el diario oficial de la federacion y la secretaria de comunicaciones y transporte por pasajero; misma que cubre daños causados al pasajero durante el uso
													 de las unidades mientras estan arriba de ellas. Todas y cada una de las unidades cuentan con pólizas de seguro de viajero, mismas que se puede mostrar a  <b>“EL CLIENTE”</b> si así lo solicita.<br></li>
												 <li><b>TERCERA</b>. Pago:  <b>“EL CLIENTE”</b> se compromete a apartar el servicio descrito en la Carátula con un 50% del total y <u> el resto liquidarlo a más tardar un día antes </u> de iniciar el servicio contratado 
													descrito en carátula; esto, por uno de los diferentes canales de opciones de pago brindada por la empresa prestadora de servicios <b>“TRANSPORTES LAR”</b>. <br> Por disposición de la Secretaría de Hacienda y Crédito Público las Empresas de
													Auto transportes estarán sujetas al Régimen Simplificado, según el Artículo 67 del Título 11 A de la ley del impuesto sobre la Renta, por lo tanto, causa IVA.<br> 
													En caso de que <b>“EL CLIENTE”</b> solicite exceder el kilometraje una vez iniciado el servicio, respecto al servicio descrito en la Carátula, éste se obligará a liquidar PREVIO a la realización de la 
													extensión requerida, las siguientes tarifas; esto en efectivo a través  del operador haciendo uso de la hoja de movimientos adicionales; o comunicándose con <b>“TRANSPORTES LAR”</b> para realizar depósito o transferencia, 
													en horarios y días hábiles,  para posteriormente ser facturados en caso de requerirlo.<p>
														&nbsp;&nbsp;&nbsp; - De 0 a 5 Kilometros $800 <p>
														&nbsp;&nbsp;&nbsp; - De 6 a 20 Kilometros $1000 <p>
														&nbsp;&nbsp;&nbsp; - De 21 a 30 Kilometros $2000 <p>
														&nbsp;&nbsp;&nbsp; - Más de 30 llamar para presupuesto <br>
												 </li>
												 <li><b>CUARTA</b>. Cancelación de servicio. En caso de que <b>“EL CLIENTE”</b> cancele este contrato, tendrá derecho al importe total del mismo, siempre y cuando lo hagan un mínimo de anticipación de 24 hrs. al horario de salida 
														del primer trayecto descrito en la Carátula, después de este horario y a hasta  2 horas antes del horario estipulado del servicio, tendrá un costo de $500, quedando como costo ultimo del servicio por cancelación de 2 hrs. 
														antes, hasta antes de inicio del servicio de $1,200. Estos costos son por Unidad contratada. <br></li>
												 <li><b>QUINTA</b>. Conducta de los Usuarios. <b>“EL CLIENTE”</b> se compromete a mantener en buen estado los interiores de las unidades y observar el buen comportamiento a bordo; así mismo, los pasajeros se abstendrán de fumar, 
														ingerir bebidas alcohólicas o consumir enervantes o estupefacientes dentro de las unidades de <b>“TRANSPORTES LAR”</b>.<p>
 														<b>“EL CLIENTE”</b> se obliga a indemnizar de forma total a <b>“TRANSPORTES LAR”</b> de cualquier daño que ocurriera a las unidades por culpa, dolo o negligencia por parte de los pasajeros. El monto del daño será facturado 
														por <b>“TRANSPORTES LAR”</b> anexando la cotización del proveedor que lleve a cabo la reparación. </li>
												 <li><b>SEXTA</b>. <b>“TRANSPORTES LAR”</b> se reserva el derecho de la subcontratación en el caso que así se requiera para cubrir un servicio, emergencias y/o imprevistos. En caso de la subcontratación para cubrir algún servicio, 
														<b>“TRANSPORTES LAR”</b> es responsable y está obligado a cumplir con el servicio estipulado en el presente contrato en igualdad de condiciones.<br></li>
												 <li><b>SEPTIMA</b>: Derechos y obligaciones. <b>“TRANSPORTES LAR”</b> se obliga a:<p>
														&nbsp;&nbsp; - Asignar la unidad contratada en el lugar, fecha y hora estipulados en la Carátula.<p>
														&nbsp;&nbsp; - Asignar unidades en buenas condiciones mecánicas de higiene y seguridad.<p>
														&nbsp;&nbsp; - Reemplazar por unidades similares a las contratadas en caso de descompostura, en un plazo máximo, &nbsp;&nbsp;&nbsp;&nbsp; de dos veces el tiempo del recorrido del punto donde haya sucedido la descompostura, 
																				respecto a la <p> &nbsp;&nbsp;&nbsp;&nbsp; base de <b>“TRANSPORTES LAR”</b> en Guadalajara. <p>
																																								
														&nbsp;&nbsp; - En caso de que la unidad contratada tuviera descompostura, y <b>“TRANSPORTES LAR”</b> no alcanzará a &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;cubrirla con otra unidad, <b>“EL CLIENTE”</b> y/o los pasajeros están autorizados a tomar otro 
																				tipo de &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;transporte terrestre, y el pago será a cargo de <b>“TRANSPORTES LAR”</b>. Dicho cargo no podrá exceder &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;del costo total del servicio inicial, y solo se cubrirá el pago del punto donde se presentó 
																				el incidente, <p> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;hasta el punto de destino.<p>
														&nbsp;&nbsp; - En caso de que la unidad contratada, no se presente en el lugar y fecha establecidos,<p> &nbsp;&nbsp;&nbsp;&nbsp;<b>“TRANSPORTES LAR”</b> queda obligada a devolver la totalidad del importe cobrado dentro de un lapso <p> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;de 72 hrs.<p>
														&nbsp;&nbsp; - La unidad del servicio deberá presentarse en el domicilio acordado con <b>“EL CLIENTE”</b>, con un mínimo <p> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;de 15 minutos antes del horario de salida del primer trayecto descrito en Carátula.<p> <br>

														&nbsp;&nbsp;&nbsp;&nbsp;<b>“TRANSPORTES LAR”</b> tiene el derecho de: <p>
														&nbsp;&nbsp; - Suspender el servicio en caso de que esté en riesgo la integridad de los pasajeros, y/o de la unidad que &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;brinda el servicio de transporte, mencionando de forma enunciativa más no limitativa por: Camino en
														 	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mal estado, brechas angostas, tramos en reparación con alto riesgo, zonas con riesgo de delincuencia, &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;inundaciones&nbsp; o deslaves, &nbsp;bloqueos o accidentes y &nbsp;demás situaciones que estén fuera del control de &nbsp;&nbsp;&nbsp;&nbsp; <b>“TRANSPORTES LAR”</b>.<p>
														 
														&nbsp; - Suspender el servicio&nbsp; en caso de mal comportamiento&nbsp; dentro de la unidad de&nbsp; transporte por parte de &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>“EL CLIENTE”</b> y/o de los pasajeros, tales como disturbios, riñas, consumo de drogas, alcohol, &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;comportamientos inmorales, entre otros.<p>
		
														&nbsp;&nbsp; - En caso de que <b>“EL CLIENTE”</b> y/o un pasajero o grupo de personas irrumpiera el servicio en un lugar &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;intermedio por causas no imputables a <b>“TRANSPORTES LAR”</b>, <b>“EL CLIENTE”</b> no tendrá derecho a &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;reembolso alguno.<p>
		
														&nbsp;&nbsp; - <b>“TRANSPORTES LAR”</b> no se hace responsable por objetos olvidados, perdidos o robados dentro de la &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;unidad del servicio de transporte durante ni después del recorrido, tampoco se hace responsable por &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;retrasos de eventos y/o por pérdidas de 
															conexiones de vuelos o por tierra de los pasajeros en caso de &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;haberlos. La responsabilidad de <b>“TRANSPORTES LAR”</b> ante cualquier imprevisto no podrá ser &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;superior al valor total del servicio descrito en la Carátula.<p>
		
		 												<b>“EL CLIENTE”</b> se obliga a:<p>
														&nbsp;&nbsp; - No exceder la capacidad de las unidades asignadas para el servicio descrito en la Carátula, en caso de &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;hacerlo, <b>“TRANSPORTES LAR”</b> no se hace responsable de ningún daño ocurrido a los pasajeros &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;durante el servicio, quedando excluida la vigencia 
															del seguro de pasajero, por así establecerse dentro &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;del contrato de la póliza.<p>
		
														&nbsp;&nbsp; - <u>En servicios especiales locales exclusivamente</u>, es necesario que los pasajeros se encuentren en el &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;lugar acordado, <u>con un máximo de una tolerancia de 30 mins. de retraso</u>, respecto a la hora de salida y &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;la hora de regreso de los lugares de origen, 
															destino o trayectos intermedios que se visiten, previamente &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;especificados en la Carátula; en caso de incumplimiento por parte de <b>“EL CLIENTE”</b>, en el horario de &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;inicio del primer trayecto, posterior a la tolerancia permitida, <b>“TRANSPORTES LAR”</b> se reserva el &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;derecho de 
															continuar con el servicio, tomándose como cobro por cancelación de último momento.<p>
												<br></li>
												 <li><b>OCTAVA</b>. Convienen ambas partes en que en el presente contrato no existe lesión, dolo, error, violencia o coacción alguna. Para todo lo relativo a la interpretación, cumplimiento y ejecución del presente contrato, las 
														partes acuerdan someterse a la jurisdicción de los tribunales de la Ciudad de Guadalajara Jalisco, renunciando por lo tanto a cualquier fuero que pudieran tener en razón de sus domicilios actuales o futuros, señalando para 
														recibir cualquier aviso o notificación al respecto, sus domicilios asentados en las Declaraciones de este contrato.</li>
											</ul>					
										</p>
									</body>
								</html>"));
			
			document.Add(espacio);
			document.Add(datosPagare);
		}
		
		private Paragraph CreateSimpleHtmlParagraph(String text) {
		    Paragraph p = new Paragraph();
			Font font = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
			p.Font = font;
			p.Alignment = Element.ALIGN_JUSTIFIED;
			p.SetLeading(1.0f, 1.2f);
			
		    using (StringReader sr = new StringReader(text)) {
		        List<IElement> elements = iTextSharp.text.html.simpleparser.HTMLWorker.ParseToList(sr, null);
		        foreach (IElement e in elements) 
		            p.Add(e);
		    }
		    return p;
		}
		#endregion
		
		#region FORMATO PRECIOS ESPECIALES
		public void FormatoFormatoPrecios(Document document, PdfWriter writer, String Responsable, String Telefono, String Domicilio, 
		                                  String Destino, String Fecha_Salida, String Hora_Salida, String Hora_Regreso, 
		                                  String NumUnidad, String Pasajeros, String Colonia, String Cruces, 
		                                  String Saldo, String Anticipos, String Precio, String Fecha_Regreso, String Cliente, String Observaciones)
		{
			//Variables
			Convertir con = new Convertir();
			PdfContentByte cb = writer.DirectContent;
			document.Add(PDFs.LogoFactura(writer));
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
			
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			PdfPTable tableC = new PdfPTable(1);
			tableC.WidthPercentage = 90;
			tableC.HorizontalAlignment = 1;
			PdfPCell header = new PdfPCell(PDFs.EncWhite215209("Servicios Incobrable LAR"));
			//PdfPCell header = new PdfPCell(PDFs.EncWhite215209("Autorización de Servicios LAR"));
			tableC.AddCell(header);
			document.Add(tableC);
			
			document.Add(PDFs.TextoPagare("             GUADALAJARA, JAL. A "+DateTime.Now.ToLongDateString().ToUpper()));
			document.Add(espacio);
			
			PdfPTable tableCPesonales = new PdfPTable(1);
			tableCPesonales.WidthPercentage = 90;
			tableCPesonales.HorizontalAlignment = 1;
			PdfPCell headerPesonales = new PdfPCell(PDFs.Enclgray215209("DATOS DEL VIAJE"));
			headerPesonales.Colspan = 1;
			tableCPesonales.AddCell(headerPesonales);
			document.Add(tableCPesonales);
			
			float[] widths1 = new float[] {25, 185f};
			PdfPTable nestedpersonales0 = new PdfPTable(2);
			nestedpersonales0.SetWidths(widths1);
			nestedpersonales0.WidthPercentage = 90;
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Responsable"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Responsable+"("+Telefono+")"));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Cliente"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Cliente+"("+Telefono+")"));
   		  	nestedpersonales0.AddCell(PDFs.TitWhite114308("Destino"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Destino));
			document.Add(nestedpersonales0);
			
			float[] widths0 = new float[] {25f, 80f, 15f, 37.5f, 15f, 37.5f};
			PdfPTable nestedpersonales = new PdfPTable(6);
			nestedpersonales.SetWidths(widths0);
			nestedpersonales.WidthPercentage = 90;
			nestedpersonales.AddCell(PDFs.TitWhite114308("Dirección"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(Domicilio));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Salida"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107_2(Fecha_Salida+" a las "+Hora_Salida));
	   		nestedpersonales.AddCell(PDFs.TitWhite114308("Regreso"));
	   		nestedpersonales.AddCell(PDFs.TexWhite111107_2(Fecha_Regreso+" a las "+Hora_Regreso));
			document.Add(nestedpersonales);
			
			float[] widths2 = new float[] {25f, 185f};
			PdfPTable nestedpersonales2 = new PdfPTable(2);
			nestedpersonales2.SetWidths(widths2);
			nestedpersonales2.WidthPercentage = 90;
			nestedpersonales2.AddCell(PDFs.TitWhite114308("Itinerario"));
   		    nestedpersonales2.AddCell(PDFs.SeparadorTableGris50(Observaciones));
			document.Add(nestedpersonales2);
			document.Add(espacio);
		    
			float[] widths21 = new float[] {25f, 25f};
			PdfPTable nestedpersonales21 = new PdfPTable(2);
			nestedpersonales21.SetWidths(widths21);
			nestedpersonales21.AddCell(PDFs.TitWhite114308("Precio Viaje"));
   		    nestedpersonales21.AddCell(PDFs.TexWhite111107("$"));
   		    nestedpersonales21.AddCell(PDFs.TitWhite114308("Precio Autorizado"));
   		    nestedpersonales21.AddCell(PDFs.TexWhite111107("$"));
   		    nestedpersonales21.AddCell(PDFs.TitWhite114308("Pago Operador"));
   		    nestedpersonales21.AddCell(PDFs.TexWhite111107("$"));
			
		    PdfPTable cellfirma2 = new PdfPTable(1);
			cellfirma2.WidthPercentage = 90;
			cellfirma2.HorizontalAlignment = 1;
			cellfirma2.AddCell(PDFs.SeparadorTableGris30(""));
			cellfirma2.AddCell(PDFs.TitWhite115308("Luis Arriaga Ruiz (Firma de conformidad)"));
		    
		    float[] widthspagare = new float[] {50f, 50f};
			PdfPTable datosPagare = new PdfPTable(2);
			datosPagare.SetWidths(widthspagare);
			datosPagare.WidthPercentage = 90;
			datosPagare.HorizontalAlignment = 1;
			datosPagare.AddCell(nestedpersonales21);
   		    datosPagare.AddCell(cellfirma2);
			datosPagare.HorizontalAlignment = 1;
			document.Add(datosPagare);
		}
		
		public void FormatoFormatoPrecios2(Document document, PdfWriter writer, String Responsable, String Telefono, String Domicilio, 
		                                  String Destino, String Fecha_Salida, String Hora_Salida, String Hora_Regreso, 
		                                  String NumUnidad, String Pasajeros, String Colonia, String Cruces, 
		                                  String Saldo, String Anticipos, String Precio, String Fecha_Regreso, String Cliente, String Observaciones, string ID)
		{
			//Variables
			Convertir con = new Convertir();
			PdfContentByte cb = writer.DirectContent;
			document.Add(PDFs.LogoFactura(writer));
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD ));
			
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			PdfPTable tableC = new PdfPTable(1);
			tableC.WidthPercentage = 90;
			tableC.HorizontalAlignment = 1;
			PdfPCell header = new PdfPCell(PDFs.EncWhite215209("Formato de Pago LAR"));
			//PdfPCell header = new PdfPCell(PDFs.EncWhite215209("Autorización de Servicios LAR"));
			tableC.AddCell(header);
			document.Add(tableC);
			
			
			float[] widthsLugar = new float[] {150, 50f};
			PdfPTable tablaLugar = new PdfPTable(2);
			tablaLugar.SetWidths(widthsLugar);
			tablaLugar.WidthPercentage = 90;
   		    tablaLugar.AddCell(PDFs.TitWhite114308Sinborde("             GUADALAJARA, JAL. A "+DateTime.Now.ToLongDateString().ToUpper()));
   		    tablaLugar.AddCell(PDFs.TitWhite114318Red(" ID "+ID));
			document.Add(tablaLugar);
			
			
			
			//document.Add(PDFs.TextoPagare("             GUADALAJARA, JAL. A "+DateTime.Now.ToLongDateString().ToUpper()));
			//document.Add(espacio);
			
			PdfPTable tableCPesonales = new PdfPTable(1);
			tableCPesonales.WidthPercentage = 90;
			tableCPesonales.HorizontalAlignment = 1;
			PdfPCell headerPesonales = new PdfPCell(PDFs.Enclgray215209("DATOS DEL VIAJE"));
			headerPesonales.Colspan = 1;
			tableCPesonales.AddCell(headerPesonales);
			document.Add(tableCPesonales);
			
			float[] widths1 = new float[] {25, 185f};
			PdfPTable nestedpersonales0 = new PdfPTable(2);
			nestedpersonales0.SetWidths(widths1);
			nestedpersonales0.WidthPercentage = 90;
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Responsable"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Responsable+"("+Telefono+")"));
   		    nestedpersonales0.AddCell(PDFs.TitWhite114308("Cliente"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Cliente+"("+Telefono+")"));
   		  	nestedpersonales0.AddCell(PDFs.TitWhite114308("Destino"));
   		    nestedpersonales0.AddCell(PDFs.TexWhite111107(Destino));
			document.Add(nestedpersonales0);
			
			float[] widths0 = new float[] {25f, 80f, 15f, 37.5f, 15f, 37.5f};
			PdfPTable nestedpersonales = new PdfPTable(6);
			nestedpersonales.SetWidths(widths0);
			nestedpersonales.WidthPercentage = 90;
			nestedpersonales.AddCell(PDFs.TitWhite114308("Dirección"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107(Domicilio));
   		    nestedpersonales.AddCell(PDFs.TitWhite114308("Salida"));
   		    nestedpersonales.AddCell(PDFs.TexWhite111107_2(Fecha_Salida+" a las "+Hora_Salida));
	   		nestedpersonales.AddCell(PDFs.TitWhite114308("Regreso"));
	   		nestedpersonales.AddCell(PDFs.TexWhite111107_2(Fecha_Regreso+" a las "+Hora_Regreso));
			document.Add(nestedpersonales);
			
			float[] widths2 = new float[] {25f, 185f};
			PdfPTable nestedpersonales2 = new PdfPTable(2);
			nestedpersonales2.SetWidths(widths2);
			nestedpersonales2.WidthPercentage = 90;
			nestedpersonales2.AddCell(PDFs.TitWhite114308("Itinerario"));
   		    nestedpersonales2.AddCell(PDFs.SeparadorTableGris50(Observaciones));
			document.Add(nestedpersonales2);
			document.Add(espacio);
		    
			float[] widths21 = new float[] {25f, 25f};
			PdfPTable nestedpersonales21 = new PdfPTable(2);
			nestedpersonales21.SetWidths(widths21);
			nestedpersonales21.AddCell(PDFs.TitWhite114308("Precio Viaje"));
   		    nestedpersonales21.AddCell(PDFs.TexWhite111107("$"));
   		    nestedpersonales21.AddCell(PDFs.TitWhite114308("Precio Autorizado"));
   		    nestedpersonales21.AddCell(PDFs.TexWhite111107("$"));
   		    nestedpersonales21.AddCell(PDFs.TitWhite114308("Pago Operador"));
   		    nestedpersonales21.AddCell(PDFs.TexWhite111107("$"));
			
		    PdfPTable cellfirma2 = new PdfPTable(1);
			cellfirma2.WidthPercentage = 90;
			cellfirma2.HorizontalAlignment = 1;
			cellfirma2.AddCell(PDFs.SeparadorTableGris30(""));
			cellfirma2.AddCell(PDFs.TitWhite115308("Luis Arriaga Ruiz (Firma de conformidad)"));
		    
		    float[] widthspagare = new float[] {50f, 50f};
			PdfPTable datosPagare = new PdfPTable(2);
			datosPagare.SetWidths(widthspagare);
			datosPagare.WidthPercentage = 90;
			datosPagare.HorizontalAlignment = 1;
			datosPagare.AddCell(nestedpersonales21);
   		    datosPagare.AddCell(cellfirma2);
			datosPagare.HorizontalAlignment = 1;
			document.Add(datosPagare);
		}
		#endregion
		
		#region CONTRATO
		public void FormatoContrato(Document document, PdfWriter writer, Interfaz.Contrato.FormDatoContrato Contrato)
		{
			Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 4, iTextSharp.text.Font.BOLD ));
			document.Add(PDFs.LogoFactura(writer));
			
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			document.Add(PDFs.TextoContrato("CONTRATO INDIVIDUAL DE  TRABAJO que celebran "+PDFs.TextoContratoNegritas(Contrato.cmbPatron.Text)+" como patrón y el Sr. "+PDFs.TextoContratoNegritas(Contrato.txtNombreEmpleado.Text.ToUpper())+" como trabajador o empleado bajo las siguientes cláusulas:"));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("1. - Por sus generales, los contratantes declaran las siguientes:\n"+
			"PATRON:\nNacionalidad "+PDFs.TextoContratoNegritas(Contrato.txtNacionalidadPatron.Text)+", Edad "+PDFs.TextoContratoNegritas(Contrato.txtEdadPatron.Text)+" años, Sexo "+PDFs.TextoContratoNegritas(Contrato.cmbSexoPatron.Text)+", Estado Civil "+PDFs.TextoContratoNegritas(Contrato.cmbEstadoCivilPatron.Text)+" "+                 
			"con domicilio en "+PDFs.TextoContratoNegritas(Contrato.txtDomicilioPatron.Text)+", \n"+
			//"TRABAJADOR O EMPLEADO:\nNacionalidad "+PDFs.TextoContratoNegritas(Contrato.txtNacionalidad.Text)+ Contrato.txtEdad.Text == "N/A"? "" : ", Edad "; +PDFs.TextoContratoNegritas(Contrato.txtEdad.Text)+" años, Sexo "+PDFs.TextoContratoNegritas(Contrato.cmbSexo.Text)+", "+
			"TRABAJADOR O EMPLEADO:\nNacionalidad "+PDFs.TextoContratoNegritas(Contrato.txtNacionalidad.Text)+", Edad " +PDFs.TextoContratoNegritas(Contrato.txtEdad.Text)+" años, Sexo "+PDFs.TextoContratoNegritas(Contrato.cmbSexo.Text)+", "+
			"Estado Civil "+PDFs.TextoContratoNegritas(Contrato.cmbEstadoCivil.Text)+", con Domicilio en "+PDFs.TextoContratoNegritas(Contrato.txtDomicilio.Text)+""));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("2. - Este contrato se celebra "+PDFs.TextoContratoNegritas(Contrato.txtCelebra.Text)+" y solo podrá ser modificado, suspendido, rescindido o terminado en los casos y con los requisitos establecidos por la Ley Federal del Trabajo."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("3. - El trabajador o empleado se obliga a prestar al patrón, bajo su dirección y dependencia, sus servicios personales como "+PDFs.TextoContratoNegritas(Contrato.txtServicioPersonal.Text)+" debiendo desempeñarlos en "+PDFs.TextoContratoNegritas(Contrato.txtLugarDesempeno.Text)+"."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("4. - La duración de la jornada de trabajo será "+PDFs.TextoContratoNegritas(Contrato.txtDuracionJornada.Text)+"."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("5. - El salario o sueldo convenido como retribución por los servicios a que este contrato se refiere es el siguiente:"+
			"Salario o sueldo a destajo, conforme a la siguiente tarifa "+PDFs.TextoContratoNegritas(Contrato.txtTarifa.Text)+". "+
			"Sometiéndose a los descuentos que deban hacerse por orden expresa de la Ley del Seguro Social y de la Ley del Impuesto Sobre la Renta _____________ El pago de este salario o sueldo se hará en moneda mexicana del cuño cada catorce días, en los días miercoles de cada "+PDFs.TextoContratoNegritas(Contrato.txtDiaPago.Text)+" y en "+PDFs.TextoContratoNegritas(Contrato.txtLugarPaga.Text)+". "));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("6. - El día de descanso semanal  para el trabajador será de "+PDFs.TextoContratoNegritas(Contrato.txtVacaciones.Text)+" cada semana y causara salario de acuerdo con el Art. 69 de la Ley Federal del Trabajo."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("7. - En los días de descanso legal obligatorio: 1 de Enero, 5 de Febrero, 21 de Marzo, 1 de Mayo,  16 de Septiembre, 20 de Noviembre y 25 de Diciembre y en los que comprendan las vacaciones a que se refiere la cláusula octava, el trabajador percibirá su salario o sueldo integro, promediándose las percepciones obtenidas en los últimos treinta días  efectivamente trabajados si se calcula a destajo."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("8. - El trabajador o empleado disfrutara de seis días de vacaciones cuando tenga un año de servicios, que aumentara dos días laborables hasta llegar a doce, por cada año subsecuente de servicios Después del cuarto año, el periodo de vacaciones aumentara en dos días por cada cinco de servicios. "+
			"Estas vacaciones comenzaran cada año el ______________________________________________"));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("9. - El trabajador o empleado conviene en someterse a los reconocimientos médicos que periódicamente ordene el patrón, en los términos de la Frac. X del articulo 134 de la Ley Federal del Trabajo, en el concepto de que el medico que los practique será designado y retribuido por el mismo patrón."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("10. - Ambas partes convienen expresamente en someterse en caso de cualquier diferencia o controversia, al texto de este contrato y a las disposiciones del Reglamento Interior de Trabajo aprobado por la Junta Central de Conciliación y Arbitraje, y del cual se entrega un ejemplar al empleado o trabajador en el momento de la celebración de dicho contrato."));
			document.Add(espacio);
			document.Add(PDFs.TextoContrato("11. - El trabajador tiene y asume la obligación de guardar el secreto y la confidencialidad de toda la información de la empresa a la que tenga acceso durante y después de la relación laboral convenida con esta empresa, El trabajador será responsable de todos los daños y perjuicios que para la empresa se deriven como consecuencia del incumplimiento doloso o culposo de dicha obligación de conformidad con los dispuesto en el artículo 47 de la Ley Federal del Trabajo."));
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			//document.Add(PDFs.TextoContrato("12. -  El Trabajador que por voluntad propia, deseara dejar de laborar para la Empresa, deberá informar de su retiro con una anticipación mínima de 15 días. En dicho caso el patrón solo quedará obligado al pago de remuneraciones y beneficios que pudieran devengarse hasta el vencimiento del plazo señalado en el aviso de cese o la carta de renuncia."));
			//document.Add(espacio);
			
			String mes = "";
			if(Contrato.dateFecha.Value.Month.ToString()=="1")
				mes = "Enero";
			if(Contrato.dateFecha.Value.Month.ToString()=="2")
				mes = "Febrero";
			if(Contrato.dateFecha.Value.Month.ToString()=="3")
				mes = "Marzo";
			if(Contrato.dateFecha.Value.Month.ToString()=="4")
				mes = "Abril";
			if(Contrato.dateFecha.Value.Month.ToString()=="5")
				mes = "Mayo";
			if(Contrato.dateFecha.Value.Month.ToString()=="6")
				mes = "Junio";
			if(Contrato.dateFecha.Value.Month.ToString()=="7")
				mes = "Julio";
			if(Contrato.dateFecha.Value.Month.ToString()=="8")
				mes = "Agosto";
			if(Contrato.dateFecha.Value.Month.ToString()=="9")
				mes = "Septiembre";
			if(Contrato.dateFecha.Value.Month.ToString()=="10")
				mes = "Octubre";
			if(Contrato.dateFecha.Value.Month.ToString()=="11")
				mes = "Noviembre";
			if(Contrato.dateFecha.Value.Month.ToString()=="12")
				mes = "Diciembre";
				
			document.Add(PDFs.TextoContrato("Leído que fue por ambas partes este documento ante los testigos que firman, e impuestos de su contenido y sabedores de las obligaciones que por virtud de el contraen así como de las que la Ley "+
			                                "Les impone, lo firman por "+PDFs.TextoContratoNegritas(Contrato.txtFirmaPor.Text)+" en "+PDFs.TextoContratoNegritas(Contrato.txtLugarFirma.Text)+" a los "+PDFs.TextoContratoNegritas(Contrato.dateFecha.Value.Day.ToString())+" Días del mes "+PDFs.TextoContratoNegritas(mes)+" del "+PDFs.TextoContratoNegritas(Contrato.dateFecha.Value.Year.ToString())+"."));
			document.Add(espacio);
			document.Add(espacio);
			document.Add(espacio);
			
			float[] widthsfirma = new float[] {50f, 50f, 50f};
			PdfPTable datosfirma = new PdfPTable(3);
			datosfirma.SetWidths(widthsfirma);
			datosfirma.WidthPercentage = 80;
			datosfirma.HorizontalAlignment = 1;
   		    datosfirma.AddCell(PDFs.SeparadorTableGris30(""));
   		    datosfirma.AddCell(PDFs.SeparadorTableGris30(""));
   		    datosfirma.AddCell(PDFs.SeparadorTableGris30(""));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Firma del Patrón"));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Firma del Testigo"));
   		    datosfirma.AddCell(PDFs.TitWhite115308("Firma del Empleado"));
   		    document.Add(datosfirma);
		}
		#endregion
		
		#region GESTORIA
		public void FormatoGestoriaScanner(Document document, PdfWriter writer)
		{
			PdfPTable Formato;
			PdfPTable Contenedor;
				
    		float[] wFormato = new float[] {65f};
			Formato = new PdfPTable(1);
			Formato.WidthPercentage = 100;
			Formato.SetWidths(wFormato);				
						
	        DirectoryInfo picrut = new DirectoryInfo(@"C:\Users\Estandar\Desktop\Iconos");	        
	        FileInfo[] rgFiles = picrut.GetFiles("*.jpg");
	        
	        int a = 20;
	        for (int i = 0; i < rgFiles.Length; i++){	
				iTextSharp.text.Image imagendemo = iTextSharp.text.Image.GetInstance(@"C:\Users\Estandar\Desktop\Iconos\"+ rgFiles[i].Name);
            	imagendemo.SetAbsolutePosition(30, 30 + a);
            	a += 165 ;            	
				
				float[] widthsFoto = new float[] {65f, 35f};
				PdfPTable Foto = new PdfPTable(2);
				Foto.SetWidths(widthsFoto);
				imagendemo.Border = iTextSharp.text.Rectangle.ALIGN_CENTER;
				imagendemo.ScaleAbsoluteHeight(500);
				imagendemo.ScaleAbsoluteWidth(900);
				Foto.AddCell(PDFs.Foto(imagendemo));
				Foto.AddCell(".");			
				
				float[] widthsContenedor = new float[] {200f};
				Contenedor = new PdfPTable(1);
				Contenedor.TotalWidth = 1000f;
				Contenedor.WidthPercentage = 20;
				Contenedor.SetWidths(widthsContenedor);
				Contenedor.AddCell(PDFs.TitGray115310("REFRENDO"));
				Contenedor.AddCell(Foto);
				Contenedor.AddCell(PDFs.TitWhite115308(""));
				Contenedor.AddCell(PDFs.TitWhite115308(""));
				Formato.AddCell(Contenedor);
			}
			document.Add(Formato);			
		}
		#endregion
		
		#region PRE_OPERADOR
		
			#region SOLICITUD DE EMPLEO
			public void FormatoSolicitudEmpleo(Document document, PdfWriter writer, System.IO.MemoryStream ms, PictureBox ptbImagen, string folio, String nombre, String apPat, String apMat, String calle, String numE, String numI, String municipio, 
		         String colonia, String cp, String estado, String cruce1, String cruce2, String lugarNaci, String municipioNaci, String estadoNaci, String fechaNaci, String edad, String sexo, String estatura, String peso,
		         String tipoLicE, String numLicE, String venceLicE, String tipoLicF, String numLicF, String venceLicF, String numApto, String venceApto, String credito, String montoCredito, String correo, String zona, String dual, String dirTrasera, String personal,
		        String tipoContratacion, String fuente, String detalleFuente, String imagenP, String tatuajes, List <Interfaz.Operador.Dato.Telefonos> ListarTelefonos, string infonavit, string monto, String estadoLicE, String estadoLicF){
			
				
				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 3, iTextSharp.text.Font.BOLD ));
				document.Add(PDFs.LogoSolicitud2(writer));
								
				iTextSharp.text.Image foto2 = null;				
				try{
					foto2 = iTextSharp.text.Image.GetInstance(ptbImagen.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
				}catch(Exception){
					foto2 = iTextSharp.text.Image.GetInstance(@"../debug/Nomina.jpg");
				}

		 		float[] widthsFolio = new float[]{36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.20f};	 		
				PdfPTable TablaFolios = new PdfPTable(13);
				TablaFolios.SetWidths(widthsFolio);
				TablaFolios.WidthPercentage = 65;
				TablaFolios.TotalWidth = 470f;
				TablaFolios.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
					PdfPCell headerTituloAuto = new PdfPCell(PDFs.Enclgray215206SinBorde("SOLICITUD DE EMPLEO	                OPERADOR   "));
					headerTituloAuto.Colspan = 13;
					headerTituloAuto.PaddingTop = 4f;	
					headerTituloAuto.PaddingBottom = 4f;	
					headerTituloAuto.HorizontalAlignment = 2;
				TablaFolios.AddCell(headerTituloAuto);
					PdfPCell headerTituloAuto5 = new PdfPCell(PDFs.TitWhite11430802("Fecha:"));
					headerTituloAuto5.Colspan = 2;
					headerTituloAuto5.PaddingTop = 3f;	
					headerTituloAuto5.PaddingBottom = 3f;	
					headerTituloAuto5.HorizontalAlignment = 2;	
				TablaFolios.AddCell(headerTituloAuto5);
					PdfPCell headerTituloAuto6 = new PdfPCell(PDFs.TitWhite11430802(" "+DateTime.Now.ToLongDateString().ToUpper()+" "+DateTime.Now.ToString("HH:mm")+" hrs"));
					headerTituloAuto6.Colspan = 8;
					headerTituloAuto6.PaddingTop = 3f;	
					headerTituloAuto6.PaddingBottom = 3f;	
					headerTituloAuto6.HorizontalAlignment = 1;	
				TablaFolios.AddCell(headerTituloAuto6);			
				
					PdfPCell headerTituloAuto3 = new PdfPCell(PDFs.TitWhite11430802("Folio: "));
					headerTituloAuto3.Colspan = 1;
					headerTituloAuto3.PaddingTop = 2f;	
					headerTituloAuto3.PaddingBottom = 2f;	
					headerTituloAuto3.HorizontalAlignment = 2;	
				TablaFolios.AddCell(headerTituloAuto3);
					PdfPCell headerTituloAuto4 = new PdfPCell(PDFs.TitWhite11430802(" "+folio));
					headerTituloAuto4.Colspan = 2;
					headerTituloAuto4.PaddingTop = 2f;	
					headerTituloAuto4.PaddingBottom = 2f;	
					headerTituloAuto4.HorizontalAlignment = 1;	
				TablaFolios.AddCell(headerTituloAuto4);				
				
					PdfPCell headerTituloAuto2 = new PdfPCell(PDFs.TitWhite11430802JUSTIFIED("Estimado solicitante de empleo, te solicitamos leer detenidamente todas las preguntas y contestar con toda la sinceridad todos los datos contenidos. " +
				                                        "La información se tratará de manera confidencial, por lo que te pedimos la mayor honradez en la informacion. Toma el tiempo necesario."));
					headerTituloAuto2.Colspan = 13;
					headerTituloAuto2.PaddingTop = 2f;	
					headerTituloAuto2.PaddingBottom = 2f;	
					headerTituloAuto2.HorizontalAlignment = 1;	
				TablaFolios.AddCell(headerTituloAuto2);
						
				document.Add(TablaFolios);
				document.Add(espacio);					
					
				//////////////////////////////////////////////////////////////////////////////// DATOS PERSONALES ////////////////////////////////////////////////////////////////////////////////				
				float[] widthsDatos = new float[]{369.28f, 100.72f};	 		
				PdfPTable TablaD = new PdfPTable(2);
				TablaD.SetWidths(widthsDatos);
				TablaD.WidthPercentage = 100;
				TablaD.HorizontalAlignment = 1;
				TablaD.TotalWidth = 470f;				
								
				float[] widthsInfo = new float[]{26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.11f, 26.13f};
				PdfPTable TablaI = new PdfPTable(18);
				TablaI.SetWidths(widthsInfo);
				TablaI.WidthPercentage = 100;
				TablaI.HorizontalAlignment = 0; 
				TablaI.TotalWidth = 470f;

					PdfPCell headerTituloDP = new PdfPCell(PDFs.Enclgray215209(" l.- DATOS PERSONALES"));					
					headerTituloDP.HorizontalAlignment = 0;
					headerTituloDP.Colspan = 10;			
					headerTituloDP.BorderWidthLeft = 0f;	
				TablaI.AddCell(headerTituloDP);	

					PdfPCell headerTituloDP2 = new PdfPCell(PDFs.Enclgray215207("Sueldo MENSUAL Deseado:"));		//Sueldo  			
					headerTituloDP2.HorizontalAlignment = 2;
					headerTituloDP2.Colspan = 4;	
				TablaI.AddCell(headerTituloDP2);	

					PdfPCell headerTituloDP3 = new PdfPCell(PDFs.TitWhite11430802("  "));					
					headerTituloDP3.HorizontalAlignment = 2;
					headerTituloDP3.PaddingTop = 3f;	
					headerTituloDP3.PaddingBottom= 3f;	
					headerTituloDP3.Colspan = 4;
				TablaI.AddCell(headerTituloDP3);					
										
					PdfPCell headerNombreDP = new PdfPCell(PDFs.TitWhite11430802("Nombre:"));
					headerNombreDP.Colspan = 2;
					headerNombreDP.PaddingTop = 3f;	
					headerNombreDP.PaddingBottom= 3f;	
					headerNombreDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerNombreDP);
				
					PdfPCell headerNombreDPC = new PdfPCell(PDFs.TitWhite11430802(" "+nombre+" "+apPat+" "+apMat));
					headerNombreDPC.Colspan = 8;
					headerNombreDPC.HorizontalAlignment = 1;	
				TablaI.AddCell(headerNombreDPC);
				
					PdfPCell headerEdadDP = new PdfPCell(PDFs.TitWhite11430802("  Fecha de Nacimiento:"));
					headerEdadDP.Colspan = 4;
					headerEdadDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerEdadDP);
								
					PdfPCell headerEdadCDP = new PdfPCell(PDFs.TitWhite11430802(" "+fechaNaci));
					headerEdadCDP.Colspan = 4;
					headerEdadCDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerEdadCDP);
												
					PdfPCell headerCorreoDPC = new PdfPCell(PDFs.TitWhite11430802(" Correo:"));
					headerCorreoDPC.Colspan = 2;
					headerCorreoDPC.PaddingTop = 3f;	
					headerCorreoDPC.PaddingBottom= 3f;
					headerCorreoDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerCorreoDPC);
				
					PdfPCell headerCorreoDP = new PdfPCell(PDFs.TitWhite11430802(" "+correo));
					headerCorreoDP.Colspan = 8;
					headerCorreoDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerCorreoDP);	
				
					PdfPCell headerLugarNDP = new PdfPCell(PDFs.TitWhite11430802("  Lugar de Nacimiento:"));
					headerLugarNDP.Colspan = 4;
					headerLugarNDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerLugarNDP);
								
					PdfPCell headerLugarNDPC = new PdfPCell(PDFs.TitWhite11430802(" "+lugarNaci));
					headerLugarNDPC.Colspan = 4;
					headerLugarNDPC.HorizontalAlignment = 1;	
				TablaI.AddCell(headerLugarNDPC);
				
					PdfPCell headerEstaturaS = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEstaturaS.Colspan = 10;	
					headerEstaturaS.BorderWidthBottom = 0f;
					headerEstaturaS.BorderWidthLeft = 0f;
					headerEstaturaS.BorderWidthRight = 0f;
					headerEstaturaS.BorderWidthTop = 0f;
				TablaI.AddCell(headerEstaturaS);
											
					PdfPCell headerEstaturaDPC = new PdfPCell(PDFs.TitWhite11430802("Estatura:"));
					headerEstaturaDPC.Colspan = 2;
					headerEstaturaDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerEstaturaDPC);
				
					PdfPCell headerEstaturaDP = new PdfPCell(PDFs.TitWhite11430802(" "+estatura));
					headerEstaturaDP.Colspan = 2;
					headerEstaturaDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerEstaturaDP);
				
					PdfPCell headerPesoDPC = new PdfPCell(PDFs.TitWhite11430802("Peso:"));
					headerPesoDPC.Colspan = 2;
					headerPesoDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerPesoDPC);
				
					PdfPCell headerPesoDP = new PdfPCell(PDFs.TitWhite11430802(" "+peso));
					headerPesoDP.Colspan = 2;
					headerPesoDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerPesoDP);
				
					PdfPCell headerSaltoLinea0 = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerSaltoLinea0.Colspan = 18;					
					headerSaltoLinea0.BorderWidthBottom = 0f;
					headerSaltoLinea0.BorderWidthRight = 0f;
					headerSaltoLinea0.BorderWidthLeft = 0f;
					headerSaltoLinea0.BorderWidthTop = 0f;
					headerSaltoLinea0.PaddingTop = 1f;	
					headerSaltoLinea0.PaddingBottom = 1f;	
					headerSaltoLinea0.HorizontalAlignment = 2;	
				TablaI.AddCell(headerSaltoLinea0);
				
					PdfPCell headerDomicilioDPC = new PdfPCell(PDFs.TitWhite11430802(" Domicilio:"));
					headerDomicilioDPC.Colspan = 2;
					headerDomicilioDPC.PaddingTop = 3f;	
					headerDomicilioDPC.PaddingBottom= 3f;
					headerDomicilioDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerDomicilioDPC);
				
					PdfPCell headerDomicilioDP = new PdfPCell(PDFs.TitWhite11430802(" "+calle+" #"+numE+" "+numI));
					headerDomicilioDP.Colspan = 8;
					headerDomicilioDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerDomicilioDP);	
								
					PdfPCell headerColoniaDPC = new PdfPCell(PDFs.TitWhite11430802(" Colonia:"));
					headerColoniaDPC.Colspan = 2;
					headerColoniaDPC.PaddingTop = 3f;	
					headerColoniaDPC.PaddingBottom= 3f;
					headerColoniaDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerColoniaDPC);
				
					PdfPCell headerColoniaDP = new PdfPCell(PDFs.TitWhite11430802(" "+colonia));
					headerColoniaDP.Colspan = 6;
					headerColoniaDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerColoniaDP);
				
					PdfPCell headerEntreDP = new PdfPCell(PDFs.TitWhite11430802("Entre calles de:"));
					headerEntreDP.Colspan = 3;
					headerEntreDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerEntreDP);
				
					PdfPCell headerEntreDPc = new PdfPCell(PDFs.TitWhite11430802(" "+cruce1+" y "+cruce2));
					headerEntreDPc.Colspan = 9;
					headerEntreDPc.HorizontalAlignment = 1;	
				TablaI.AddCell(headerEntreDPc);
				
				PdfPCell headerInfonavitDPC = new PdfPCell(PDFs.TitWhite11430802Enc("Infonavit:"));
					headerInfonavitDPC.Colspan = 2;
					headerInfonavitDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerInfonavitDPC);
				
					PdfPCell headerInfonavitDP = new PdfPCell(PDFs.TitWhite11430802Enc(" "+infonavit));
					headerInfonavitDP.HorizontalAlignment = 1;	
					headerInfonavitDPC.Colspan = 1;
				TablaI.AddCell(headerInfonavitDP);
								
				if(monto.Length > 0){
					PdfPCell headerInfonavitMontoDPC = new PdfPCell(PDFs.TitWhite11430802Enc("Monto: $"+monto));
					headerInfonavitMontoDPC.Colspan = 4;
					headerInfonavitMontoDPC.HorizontalAlignment = 0;
					TablaI.AddCell(headerInfonavitMontoDPC);
				}else{
					PdfPCell headerInfonavitMontoDPC = new PdfPCell(PDFs.TitWhite11430802Enc("Monto: N/A"));
					headerInfonavitMontoDPC.Colspan = 4;
					headerInfonavitMontoDPC.HorizontalAlignment = 0;	
					TablaI.AddCell(headerInfonavitMontoDPC);
				}				
				TablaI.AddCell(headerSaltoLinea0);			

					PdfPCell headerNumerosDPC = new PdfPCell(PDFs.Enclgray215209NormalBorde("Numeros de Contacto"));
					headerNumerosDPC.Colspan = 12;
					headerNumerosDPC.HorizontalAlignment = 0;
				TablaI.AddCell(headerNumerosDPC);
				
					PdfPCell headerCelularDPC = new PdfPCell(PDFs.TitWhite11430802("Celular:"));
					headerCelularDPC.Colspan = 2;
					headerCelularDPC.HorizontalAlignment = 2;
				TablaI.AddCell(headerCelularDPC);
				
				string numeroTelefonico = "", Relacion1 = "", numeroRelacion1 = "", nombreRelacion1 = "", Relacion2 = "", numeroRelacion2 = "", nombreRelacion2 = "";
				for (int i = 0; i < ListarTelefonos.Count; i++){
					if(ListarTelefonos[i].relacion == "PROPIO" && ListarTelefonos[i].tipo == "CELULAR")
						numeroTelefonico = ListarTelefonos[i].numero;
					else if(ListarTelefonos[i].relacion == "PROPIO" && ListarTelefonos[i].tipo == "FIJO" && numeroTelefonico == "")
						numeroTelefonico = ListarTelefonos[i].numero;
						
					if(ListarTelefonos[i].relacion != "PROPIO" ){
						if(numeroRelacion1.Length == 0){
							numeroRelacion1 = ListarTelefonos[i].numero;
							Relacion1 = ListarTelefonos[i].relacion;
							nombreRelacion1 = ListarTelefonos[i].nombre;
						}else{
							numeroRelacion2 = ListarTelefonos[i].numero;
							Relacion2 = ListarTelefonos[i].relacion;	
							nombreRelacion2 = ListarTelefonos[i].nombre;								
						}
					}
				}				
				
					PdfPCell headerCelularDP = new PdfPCell(PDFs.TitWhite11430802(" "+numeroTelefonico));
					headerCelularDP.Colspan = 4;
					headerCelularDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerCelularDP);	
				
					PdfPCell headerRelacion1DPC = new PdfPCell(PDFs.TitWhite11430802(Relacion1+": "+nombreRelacion1));
					headerRelacion1DPC.Colspan = 5;
					headerRelacion1DPC.HorizontalAlignment = 1;	
				TablaI.AddCell(headerRelacion1DPC);	
				
					PdfPCell headerRelacion1DP = new PdfPCell(PDFs.TitWhite11430802(" "+numeroRelacion1));
					headerRelacion1DP.Colspan = 4;
					headerRelacion1DP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerRelacion1DP);
				
				if(Relacion2.Length > 0){
						PdfPCell headerRelacion2DPC = new PdfPCell(PDFs.TitWhite11430802(Relacion2+ ": "+nombreRelacion2));
						headerRelacion2DPC.Colspan = 5;
						headerRelacion2DPC.HorizontalAlignment = 1;	
					TablaI.AddCell(headerRelacion2DPC);	
				}else{
						PdfPCell headerRelacion2DPC = new PdfPCell(PDFs.TitWhite11430802(" "));
						headerRelacion2DPC.Colspan = 5;
						headerRelacion2DPC.HorizontalAlignment = 1;	
					TablaI.AddCell(headerRelacion2DPC);	
				}
					
					PdfPCell headerRelacion2DP = new PdfPCell(PDFs.TitWhite11430802(" "+numeroRelacion2));
					headerRelacion2DP.Colspan = 4;
					headerRelacion2DP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerRelacion2DP);			

				TablaD.AddCell(TablaI);	
				TablaD.AddCell(PDFs.FotoEmpleo(foto2));					
								
				document.Add(TablaD);
				document.Add(espacio);				
				
				//////////////////////////////////////////////////////////////////////////////////  DOCUMENTACION /////////////////////////////////////////////////////////////////////////////////
				float[] widthsDocumentacion = new float[]{73.75f, 35.75f, 30.75f, 80.75f, 40.75f, 35.75f, 81.75f, 90.75f};
				PdfPTable TablaDocumentacion = new PdfPTable(8);
				TablaDocumentacion.SetWidths(widthsDocumentacion);
				TablaDocumentacion.WidthPercentage = 100;
				TablaDocumentacion.HorizontalAlignment = 0; 
				TablaDocumentacion.TotalWidth = 470f;
				
					PdfPCell headerTituloDocumentos = new PdfPCell(PDFs.Enclgray215209(" ll.- DOCUMENTACIÓN"));
					headerTituloDocumentos.HorizontalAlignment = 0;
					headerTituloDocumentos.Colspan = 8;				
				TablaDocumentacion.AddCell(headerTituloDocumentos);
				
							
					PdfPCell headerNombreLicE = new PdfPCell(PDFs.TitWhite11430802Enc("LICENCIA DE MANEJO ESTATAL"));
					headerNombreLicE.Colspan = 3;					
					//headerNombreLicE.BorderWidthBottom = 0f;
					//headerNombreLicE.BorderWidthRight = 0f;
					headerNombreLicE.HorizontalAlignment = 1;	
				TablaDocumentacion.AddCell(headerNombreLicE);
					PdfPCell headerNombreLicF = new PdfPCell(PDFs.TitWhite11430802Enc("LICENCIA DE MANEJO FEDERAL"));
					headerNombreLicF.Colspan = 3;
					//headerNombreLicF.BorderWidthBottom = 0f;
					headerNombreLicF.HorizontalAlignment = 1;	
				TablaDocumentacion.AddCell(headerNombreLicF);
				
				PdfPCell headerCurp = new PdfPCell(PDFs.TitWhite11430802(" IFE:"));
					headerCurp.Colspan = 2;
					//headerCurp.BorderWidthLeft = 0f;
					headerCurp.HorizontalAlignment = 0;				
				TablaDocumentacion.AddCell(headerCurp);
				
				PdfPCell headerNumeroLicTipo = new PdfPCell(PDFs.TitWhite11430802("  Tipo: "+tipoLicE));
					headerNumeroLicTipo.Colspan = 3;
					//headerNumeroLicTipo.BorderWidthBottom = 0f;
					//headerNumeroLicTipo.BorderWidthTop = 0f;
					//headerNumeroLicTipo.BorderWidthRight = 0f;
					headerNumeroLicTipo.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerNumeroLicTipo);											
				
				PdfPCell headerLicTipoF = new PdfPCell(PDFs.TitWhite11430802("  Tipo: "+tipoLicF));
					headerLicTipoF.Colspan = 1;
					//headerLicTipoF.BorderWidthBottom = 0f;
					//headerLicTipoF.BorderWidthTop = 0f;
					//headerLicTipoF.BorderWidthRight = 0f;
					headerLicTipoF.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerLicTipoF);				
				
				PdfPCell headerVenceLicF = new PdfPCell(PDFs.TitWhite11430802("  Vigencia: "+venceLicF));
					headerVenceLicF.Colspan = 2;
					//headerVenceLicF.BorderWidthBottom = 0f;
					//headerVenceLicF.BorderWidthTop = 0f;
					//headerVenceLicF.BorderWidthRight = 0f;
					headerVenceLicF.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerVenceLicF);
				
				PdfPCell headerRFC = new PdfPCell(PDFs.TitWhite11430802(" CURP:"));
					headerRFC.Colspan = 2;
					headerRFC.HorizontalAlignment = 0;
					//headerRFC.BorderWidthTop = 0f;
					//headerRFC.BorderWidthLeft = 0f;					
					headerRFC.PaddingBottom = 5f;
					headerRFC.PaddingTop = 5f;
				TablaDocumentacion.AddCell(headerRFC);				
								
				PdfPCell headerVenceLicE = new PdfPCell(PDFs.TitWhite11430802("  Vigencia: "+venceLicE));
					headerVenceLicE.Colspan = 1;
					//headerVenceLicE.BorderWidthTop = 0f;
					//headerVenceLicE.BorderWidthRight = 0f;
					//headerVenceLicE.BorderWidthBottom = 0f;
					headerVenceLicE.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerVenceLicE);
				
					PdfPCell headerEstadoLicE = new PdfPCell(PDFs.TitWhite11430802("  Estado: "+estadoLicE));
					headerEstadoLicE.Colspan = 2;
					//headerEstadoLicE.BorderWidthTop = 0f;
					//headerEstadoLicE.BorderWidthLeft = 0f;
					//headerEstadoLicE.BorderWidthBottom = 0f;
					//headerEstadoLicE.BorderWidthRight = 0f;
					headerEstadoLicE.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerEstadoLicE);				
				
					PdfPCell headerNumeroLicF = new PdfPCell(PDFs.TitWhite11430802("  Número: "+numLicF));
					headerNumeroLicF.Colspan = 1;
					//headerNumeroLicF.BorderWidthBottom = 0f;
					//headerNumeroLicF.BorderWidthTop = 0f;
					//headerNumeroLicF.BorderWidthLeft = 0f;
					headerNumeroLicF.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerNumeroLicF);
				
				
					PdfPCell headerEstadoLicF = new PdfPCell(PDFs.TitWhite11430802("  Estado: "+estadoLicF));
					headerEstadoLicF.Colspan = 2;
					//headerEstadoLicF.BorderWidthBottom = 0f;
					//headerEstadoLicF.BorderWidthTop = 0f;
					//headerEstadoLicF.BorderWidthLeft = 0f;
					headerEstadoLicF.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerEstadoLicF);
				
				PdfPCell headerIFE = new PdfPCell(PDFs.TitWhite11430802(" RFC:"));
					headerIFE.Colspan = 2;
					headerIFE.HorizontalAlignment = 0;	
					//headerIFE.BorderWidthTop = 0f;
					//headerIFE.BorderWidthLeft = 0f;
					headerIFE.PaddingBottom = 5f;
					headerIFE.PaddingTop = 5f;
				TablaDocumentacion.AddCell(headerIFE);
				
					PdfPCell headerNumeroLicE = new PdfPCell(PDFs.TitWhite11430802("  Número: "+numLicE));
					headerNumeroLicE.Colspan = 3;
					//headerNumeroLicE.BorderWidthBottom = 0f;
					//headerNumeroLicE.BorderWidthTop = 0f;
					//headerNumeroLicE.BorderWidthLeft = 0f;
					//headerNumeroLicE.BorderWidthRight = 0f;
					headerNumeroLicE.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerNumeroLicE);
				
				
				PdfPCell headerVenceLicApto = new PdfPCell(PDFs.TitWhite11430802("  Apto méd: "+numApto));
					headerVenceLicApto.Colspan = 1;
					//headerVenceLicApto.BorderWidthTop = 0f;
					//headerVenceLicApto.BorderWidthRight = 0f;
					headerVenceLicApto.HorizontalAlignment = 0;	
					headerVenceLicApto.PaddingTop = 5f;
				TablaDocumentacion.AddCell(headerVenceLicApto);
				
					PdfPCell headerEstadoLicApto = new PdfPCell(PDFs.TitWhite11430802("  Vigencia: "+venceApto));
					headerEstadoLicApto.Colspan = 2;
					//headerEstadoLicApto.BorderWidthTop = 0f;
					//headerEstadoLicApto.BorderWidthLeft = 0f;
					headerEstadoLicApto.HorizontalAlignment = 0;	
				TablaDocumentacion.AddCell(headerEstadoLicApto);
									
					PdfPCell headerImss = new PdfPCell(PDFs.TitWhite11430802(" IMSS:"));
					headerImss.Colspan = 2;
					headerImss.HorizontalAlignment = 0;	
					//headerImss.BorderWidthLeft = 0f;
					//headerImss.BorderWidthTop = 0f;
					headerImss.PaddingBottom = 5f;
					headerImss.PaddingTop = 5f;
				TablaDocumentacion.AddCell(headerImss);
				
				document.Add(TablaDocumentacion);
				document.Add(espacio);	
				
				//////////////////////////////////////////////////////////////////////////////////  EMPLEOS /////////////////////////////////////////////////////////////////////////////////
				float[] widthsEmpleos = new float[]{90f, 95f, 95f, 95f, 95f};
				PdfPTable TablaEmpleos = new PdfPTable(5);
				TablaEmpleos.SetWidths(widthsEmpleos);
				TablaEmpleos.WidthPercentage = 100;
				TablaEmpleos.HorizontalAlignment = 0; 
				TablaEmpleos.TotalWidth = 470f;
				
					PdfPCell headerAvisos = new PdfPCell(PDFs.TitWhite114308("Antes de continuar revisa la información de la parte superior".ToUpper()));
					headerAvisos.HorizontalAlignment = 0;
					headerAvisos.Colspan = 5;		
					headerAvisos.BorderWidthLeft = 0f;
					headerAvisos.BorderWidthTop = 0f;	
					headerAvisos.BorderWidthRight = 0f;	
					headerAvisos.BorderWidthBottom = 0f;		
				TablaEmpleos.AddCell(headerAvisos);	
				
				
					PdfPCell headerTituloEmpleos = new PdfPCell(PDFs.Enclgray215209(" lll.- EMPLEOS. (10 AÑOS A LA FECHA)" ));
					headerTituloEmpleos.HorizontalAlignment = 0;
					headerTituloEmpleos.Colspan = 5;				
				TablaEmpleos.AddCell(headerTituloEmpleos);					
				
					PdfPCell headerConcepto = new PdfPCell(PDFs.TitWhite11430802("CONCEPTO"));
					headerConcepto.HorizontalAlignment = 1;				
				TablaEmpleos.AddCell(headerConcepto);
				
					PdfPCell headerUltipo= new PdfPCell(PDFs.TitWhite11430802("ULTIMO O ACTUAL"));
					headerUltipo.HorizontalAlignment = 1;				
				TablaEmpleos.AddCell(headerUltipo);
				
					PdfPCell headerAnterior1 = new PdfPCell(PDFs.TitWhite11430802("ANTERIOR"));
					headerAnterior1.HorizontalAlignment = 1;				
				TablaEmpleos.AddCell(headerAnterior1);
				
					PdfPCell headerAnterior2 = new PdfPCell(PDFs.TitWhite11430802("ANTERIOR"));
					headerAnterior2.HorizontalAlignment = 1;				
				TablaEmpleos.AddCell(headerAnterior2);
				
					PdfPCell headerAnterior3 = new PdfPCell(PDFs.TitWhite11430802("ANTERIOR"));
					headerAnterior3.HorizontalAlignment = 1;				
				TablaEmpleos.AddCell(headerAnterior3);
				
					PdfPCell headerPeriodo = new PdfPCell(PDFs.TitWhite11430802("Periodo"));
					headerPeriodo.HorizontalAlignment = 1;
					headerPeriodo.PaddingBottom = 7f;
					headerPeriodo.PaddingTop = 7f;						
					TablaEmpleos.AddCell(headerPeriodo);				
					float[] widthsAños = new float[]{470f};
					PdfPTable TablaAños = new PdfPTable(1);
					TablaAños.SetWidths(widthsAños);
					TablaAños.WidthPercentage = 100;
					TablaAños.HorizontalAlignment = 1; 
					TablaAños.TotalWidth = 470f;	
					TablaAños.AddCell(PDFs.TitWhite11430802SinBorde(" De"));
					TablaAños.AddCell(PDFs.TitWhite11430802SinBorde(" A"));		
				TablaEmpleos.AddCell(TablaAños);
				TablaEmpleos.AddCell(TablaAños);
				TablaEmpleos.AddCell(TablaAños);
				TablaEmpleos.AddCell(TablaAños);
				
					PdfPCell headerCompania = new PdfPCell(PDFs.TitWhite11430802("Compañia"));
					headerCompania.HorizontalAlignment = 1;	
					headerCompania.PaddingBottom = 10f;
					headerCompania.PaddingTop = 10f;				
				TablaEmpleos.AddCell(headerCompania);		
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));
				
					PdfPCell headerDomicilio = new PdfPCell(PDFs.TitWhite11430802("Domicilio"));
					headerDomicilio.HorizontalAlignment = 1;
					headerDomicilio.PaddingBottom = 12f;
					headerDomicilio.PaddingTop = 12f;					
				TablaEmpleos.AddCell(headerDomicilio);			
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));
				
					PdfPCell headerTelefonos = new PdfPCell(PDFs.TitWhite11430802("Teléfonos"));
					headerTelefonos.HorizontalAlignment = 1;
					headerTelefonos.PaddingBottom = 12f;
					headerTelefonos.PaddingTop = 12f;							
				TablaEmpleos.AddCell(headerTelefonos);				
					float[] widthsCelular1 = new float[]{470f};
					PdfPTable TablaCelular1 = new PdfPTable(1);
					TablaCelular1.SetWidths(widthsCelular1);
					TablaCelular1.WidthPercentage = 100;
					TablaCelular1.HorizontalAlignment = 1; 
					TablaCelular1.TotalWidth = 470f;
					//TablaCelular1.AddCell(PDFs.TitWhite11430602FondoGris("NO CELULARES"));
					TablaCelular1.AddCell(PDFs.TitWhite11430802SinBorde(" "));		
					TablaCelular1.AddCell(PDFs.TitWhite11430802SinBorde(" "));		
				TablaEmpleos.AddCell(TablaCelular1);
				TablaEmpleos.AddCell(TablaCelular1);
				TablaEmpleos.AddCell(TablaCelular1);
				TablaEmpleos.AddCell(TablaCelular1);
	
					PdfPCell headerPuesto = new PdfPCell(PDFs.TitWhite11430802("Puesto"));
					headerPuesto.HorizontalAlignment = 1;
					headerPuesto.PaddingBottom = 7f;
					headerPuesto.PaddingTop = 7f;	
				TablaEmpleos.AddCell(headerPuesto);			
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
	
					PdfPCell headerSueldo = new PdfPCell(PDFs.TitWhite11430802("Sueldo Mensual"));
					headerSueldo.HorizontalAlignment = 1;	
					headerSueldo.PaddingBottom = 5f;
					headerSueldo.PaddingTop = 5f;			
				TablaEmpleos.AddCell(headerSueldo);			
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
	
					PdfPCell headerMotivo = new PdfPCell(PDFs.TitWhite11430802("Motivo de Sep"));
					headerMotivo.HorizontalAlignment = 1;	
					headerMotivo.PaddingBottom = 15f;
					headerMotivo.PaddingTop = 15f;		
				TablaEmpleos.AddCell(headerMotivo);			
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
				TablaEmpleos.AddCell(PDFs.TitWhite11430802(" "));	
					
					PdfPCell headerJefe = new PdfPCell(PDFs.TitWhite11430802("Jefe Inmediato y Puesto"));
					headerJefe.HorizontalAlignment = 1;
					headerJefe.PaddingBottom = 17f;
					headerJefe.PaddingTop = 17f;						
					TablaEmpleos.AddCell(headerJefe);				
					float[] widthsJefe = new float[]{470f};
					PdfPTable TablaJefe = new PdfPTable(1);
					TablaJefe.SetWidths(widthsAños);
					TablaJefe.WidthPercentage = 100;
					TablaJefe.HorizontalAlignment = 1; 
					TablaJefe.TotalWidth = 470f;	
					
						PdfPCell headerLineaJefe = new PdfPCell(PDFs.TitWhite11430802(" "));
						headerLineaJefe.Colspan = 2;
						headerLineaJefe.HorizontalAlignment = 0;	
						headerLineaJefe.BorderWidthLeft = 0f;
						headerLineaJefe.BorderWidthRight = 0f;
						headerLineaJefe.BorderWidthTop = 0f;
						headerLineaJefe.PaddingTop = 8f;			
					TablaJefe.AddCell(headerLineaJefe);
					TablaJefe.AddCell(PDFs.TitWhite11430802SinBorde(" "));		
				TablaEmpleos.AddCell(TablaJefe);
				TablaEmpleos.AddCell(TablaJefe);
				TablaEmpleos.AddCell(TablaJefe);
				TablaEmpleos.AddCell(TablaJefe);				
				
					PdfPCell headerRefLaborales = new PdfPCell(PDFs.TitWhite11430802("Ref. Laborales"));
					headerRefLaborales.HorizontalAlignment = 1;	
					headerRefLaborales.PaddingBottom = 6f;
					headerRefLaborales.PaddingTop = 6f;						
				TablaEmpleos.AddCell(headerRefLaborales);				
					float[] widthsRefLaborales = new float[]{235f, 235f};
					PdfPTable TablaRefLaborales = new PdfPTable(2);
					TablaRefLaborales.SetWidths(widthsRefLaborales);
					TablaRefLaborales.WidthPercentage = 100;
					TablaRefLaborales.HorizontalAlignment = 1; 
					TablaRefLaborales.TotalWidth = 470f;
					TablaRefLaborales.AddCell(PDFs.TitWhite11430802SinBorde("             SI"));
					TablaRefLaborales.AddCell(PDFs.TitWhite11430802SinBorde("        NO"));		
				TablaEmpleos.AddCell(TablaRefLaborales);
				TablaEmpleos.AddCell(TablaRefLaborales);
				TablaEmpleos.AddCell(TablaRefLaborales);
				TablaEmpleos.AddCell(TablaRefLaborales);
				
					PdfPCell headerNoHacer = new PdfPCell(PDFs.TitWhite11430802(" La siguiente parte se llena por el personal de Transporte LAR"));
					headerNoHacer.HorizontalAlignment = 0;
					headerNoHacer.Colspan = 5;	
					headerNoHacer.BorderWidthBottom = 0f;
					headerNoHacer.BorderWidthRight = 0f;
					headerNoHacer.BorderWidthLeft = 0f;
					headerNoHacer.BorderWidthTop = 0f;					
				TablaEmpleos.AddCell(headerNoHacer);
				
					PdfPCell headerT = new PdfPCell(PDFs.TitWhite11430802FondoGris("T"));
					headerT.HorizontalAlignment = 1;					
					headerT.PaddingBottom = 7f;
					headerT.PaddingTop = 7f;		
				TablaEmpleos.AddCell(headerT);				
					float[] widthsT= new float[]{370f, 100f};
					PdfPTable TablaT = new PdfPTable(2);
					TablaT.SetWidths(widthsT);
					TablaT.WidthPercentage = 100;
					TablaT.HorizontalAlignment = 1; 
					TablaT.TotalWidth = 470f;
					TablaT.AddCell(PDFs.TitWhite11430802_2(" "));		
					TablaT.AddCell(PDFs.TitWhite11430802_2(" "));
				TablaEmpleos.AddCell(TablaT);
				TablaEmpleos.AddCell(TablaT);
				TablaEmpleos.AddCell(TablaT);
				TablaEmpleos.AddCell(TablaT);
				
					PdfPCell headerM = new PdfPCell(PDFs.TitWhite11430802FondoGris("M"));
					headerM.HorizontalAlignment = 1;				
					headerM.PaddingBottom = 7f;
					headerM.PaddingTop = 7f;				
				TablaEmpleos.AddCell(headerM);				
					float[] widthsM= new float[]{370f, 100f};
					PdfPTable TablaM = new PdfPTable(2);
					TablaM.SetWidths(widthsM);
					TablaM.WidthPercentage = 100;
					TablaM.HorizontalAlignment = 1; 
					TablaM.TotalWidth = 470f;
					TablaM.AddCell(PDFs.TitWhite11430802_2(" "));		
					TablaM.AddCell(PDFs.TitWhite11430802_2(" "));
				TablaEmpleos.AddCell(TablaM);
				TablaEmpleos.AddCell(TablaM);
				TablaEmpleos.AddCell(TablaM);
				TablaEmpleos.AddCell(TablaM);
				
				document.Add(TablaEmpleos);
				document.Add(espacio);
				document.Add(espacio);
				document.Add(espacio);
				document.Add(espacio);
				
				
				//////////////////////////////////////////////////////////////////////////////// AVISO DE PRIVASIDAD  ////////////////////////////////////////////////////////////////////////////////
				float[] widthsDerecho = new float[]{235f, 235f};
				PdfPTable TablaDerecho = new PdfPTable(2);
				TablaDerecho.SetWidths(widthsDerecho);
				TablaDerecho.WidthPercentage = 100;
				TablaDerecho.HorizontalAlignment = 0; 
				TablaDerecho.TotalWidth = 470f;			
				TablaDerecho.AddCell(PDFs.Blanco4Justificado("Yo "+nombre+" "+apPat+" "+apMat+" por este medio otorgo mi consentimiento a la empresa Transportes LAR a fin de que " +
				                                             "pueda verificar las referencias laborales que yo mismo asiento en esta solicitud, con cualquier entidad y/o persona que provea esta " +
				                                             "clase de información; de la misma manera por este medio libero a la empresa Transportes LAR de cualquier responsabilidad, ya que entiendo" +
															 " y así  acepto que la información ó resultados de las referencias laborales que reciba la empresa Transportes LAR será utilizada única" +
															 " y exclusivamente para fines de trabajo que se solicita desempeñar en la empresa Transportes LAR."));
				
				float[] widthsFirma = new float[]{470f};
				PdfPTable TablaFirma = new PdfPTable(1);
				TablaFirma.SetWidths(widthsFirma);
				TablaFirma.HorizontalAlignment = 1;
				TablaFirma.TotalWidth = 470f;
				TablaFirma.AddCell(PDFs.Blanco9(nombre+" "+apPat+" "+apMat));
				TablaFirma.AddCell(PDFs.Blanco4("_______________________________________________________________"));
				TablaFirma.AddCell(PDFs.Blanco4(" Hago constar que todas mi respuestas son verdaderas"));
				TablaFirma.AddCell(PDFs.Blanco4(" NOMBRE Y FIRMA DEL SOLICITANTE "));
				//document.Add(TablaFirma);
				TablaDerecho.AddCell(TablaFirma);
				
				float[] widthsFuente = new float[]{470f};
				PdfPTable TablaFuente= new PdfPTable(1);
				TablaFuente.SetWidths(widthsFuente);
				TablaFuente.HorizontalAlignment = 1;
				TablaFuente.TotalWidth = 470f;
				TablaFuente.AddCell(PDFs.Blanco9("Fuente"));
				TablaFuente.AddCell(PDFs.Blanco4(" "+fuente+" : "+detalleFuente));				
				
				TablaDerecho.AddCell(PDFs.Blanco4Justificado("  "));
				TablaDerecho.AddCell(TablaFuente);
				
				document.Add(TablaDerecho);
				document.Add(espacio);	
				document.Add(espacio);
	
				
				///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				////////////////////////////////////////////////////////////////////////////////// SEGUNDA PÁGINA  ////////////////////////////////////////////////////////////////////////////////
				///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				document.NewPage();
				
				document.Add(PDFs.LogoSolicitud(writer));	
				
		 		float[] widthsFolio2 = new float[]{190f, 190f, 90f};	 		
				PdfPTable TablaFolios2 = new PdfPTable(3);
				TablaFolios2.SetWidths(widthsFolio2);
				TablaFolios2.WidthPercentage = 65;
				TablaFolios2.TotalWidth = 470f;
				TablaFolios2.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
				TablaFolios2.AddCell(PDFs.TitWhite11430802Padding5(" Fecha: "+DateTime.Now.ToString("dd/MM/yyyy")));
				TablaFolios2.AddCell(PDFs.TitWhite11430802Padding5(" Puesto Solicitado: OPERADOR"));
				TablaFolios2.AddCell(PDFs.TitWhite11430802Padding5(" Folio: "+ folio));
				
					PdfPCell headerNombre2= new PdfPCell(PDFs.TitWhite11430802Padding5(" Nombre: "+nombre+" "+apPat+" "+apMat));
					headerNombre2.HorizontalAlignment = 0;
					headerNombre2.Colspan = 10;				
				TablaFolios2.AddCell(headerNombre2);			
				document.Add(TablaFolios2);
				document.Add(espacio);				
				
				///////////////////////////////////////////////////////////////////////// ECONOMÍA Y COMPOSICIÓN FAMILIAR  ////////////////////////////////////////////////////////////////////////
				
				float[] widthsEconomia = new float[]{30.80f, 16.80f, 16.80f, 16.80f, 13.80f, 13.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 
													 12.80f, 12.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.60f, 16.60f };
				PdfPTable TablaEconomia = new PdfPTable(28);
				TablaEconomia.SetWidths(widthsEconomia);
				TablaEconomia.WidthPercentage = 100;
				TablaEconomia.HorizontalAlignment = 0; 
				TablaEconomia.TotalWidth = 470f;
				
					PdfPCell headerTituloEconimia= new PdfPCell(PDFs.Enclgray215209(" lV.- ECONOMÍA Y COMPOSICIÓN FAMILIAR"));
					headerTituloEconimia.HorizontalAlignment = 0;
					headerTituloEconimia.Colspan = 28;				
				TablaEconomia.AddCell(headerTituloEconimia);
										
					PdfPCell headerIngresoMensual = new PdfPCell(PDFs.TitWhite11430802("Ingreso Mensual Total: "));
					headerIngresoMensual.Colspan = 6;					
					//headerIngresoMensual.BorderWidthBottom = 0f;
					//headerIngresoMensual.BorderWidthRight = 0f;
					//headerIngresoMensual.BorderWidthLeft = 0f;
					//headerIngresoMensual.BorderWidthTop = 0f;
					headerIngresoMensual.PaddingTop = 5f;	
					headerIngresoMensual.PaddingBottom= 5f;	
					headerIngresoMensual.HorizontalAlignment = 2;	
				TablaEconomia.AddCell(headerIngresoMensual);
				
					PdfPCell headerIngresoM1 = new PdfPCell(PDFs.TitWhite11430802("Menor a $6,000"));
					headerIngresoM1.Colspan = 3;
					headerIngresoM1.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerIngresoM1);
								
					PdfPCell headerEspacioBorde = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEspacioBorde.Colspan = 1;
					headerEspacioBorde.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerIngresoM2 = new PdfPCell(PDFs.TitWhite11430802("$6,001 a $8,000"));
					headerIngresoM2.Colspan = 3;
					headerIngresoM2.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerIngresoM2);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerIngresoM3 = new PdfPCell(PDFs.TitWhite11430802("$8,001 a $10,000"));
					headerIngresoM3.Colspan = 4;
					headerIngresoM3.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerIngresoM3);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerIngresoM4 = new PdfPCell(PDFs.TitWhite11430802("$10,001 a $12,000"));
					headerIngresoM4.Colspan = 4;
					headerIngresoM4.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerIngresoM4);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerIngresoM5 = new PdfPCell(PDFs.TitWhite11430802("$12,001 a Más"));
					headerIngresoM5.Colspan = 3;
					headerIngresoM5.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerIngresoM5);
				TablaEconomia.AddCell(headerEspacioBorde);
										
					PdfPCell headerFuenteIngreso = new PdfPCell(PDFs.TitWhite11430802("Tiene otra fuente de Ingresos: "));
					headerFuenteIngreso.Colspan = 6;
					headerFuenteIngreso.PaddingTop = 5f;	
					headerFuenteIngreso.PaddingBottom= 5f;	
					headerFuenteIngreso.HorizontalAlignment = 2;	
				TablaEconomia.AddCell(headerFuenteIngreso);
				
					PdfPCell headerFuenteIngreso1 = new PdfPCell(PDFs.TitWhite11430802("SI"));
					headerFuenteIngreso1.Colspan = 1;
					headerFuenteIngreso1.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerFuenteIngreso1);
				
					PdfPCell headerFuenteIngreso2 = new PdfPCell(PDFs.TitWhite11430802("NO"));
					headerFuenteIngreso2.Colspan = 1;
					headerFuenteIngreso2.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerFuenteIngreso2);
								
					PdfPCell headerFuenteIngresoCuanto = new PdfPCell(PDFs.TitWhite11430802LightGray(" Cuanto: $"));
					headerFuenteIngresoCuanto.Colspan = 6;
					headerFuenteIngresoCuanto.HorizontalAlignment = 0;	
				TablaEconomia.AddCell(headerFuenteIngresoCuanto);
				
					PdfPCell headerFuenteIngresoCual = new PdfPCell(PDFs.TitWhite11430802LightGray(" Cual: "));
					headerFuenteIngresoCual.Colspan = 14;
					headerFuenteIngresoCual.HorizontalAlignment = 0;	
				TablaEconomia.AddCell(headerFuenteIngresoCual);
								
					PdfPCell headerSaltoLinea = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerSaltoLinea.Colspan = 28;					
					headerSaltoLinea.BorderWidthBottom = 0f;
					headerSaltoLinea.BorderWidthRight = 0f;
					headerSaltoLinea.BorderWidthLeft = 0f;
					headerSaltoLinea.BorderWidthTop = 0f;
					headerSaltoLinea.PaddingTop = 1f;	
					headerSaltoLinea.PaddingBottom = 1f;	
					headerSaltoLinea.HorizontalAlignment = 2;	
				TablaEconomia.AddCell(headerSaltoLinea);
				
					PdfPCell headerPagaRenta = new PdfPCell(PDFs.TitWhite11430802("Paga Renta:"));
					headerPagaRenta.Colspan = 2;					
					//headerPagaRenta.BorderWidthBottom = 0f;
					//headerPagaRenta.BorderWidthRight = 0f;
					//headerPagaRenta.BorderWidthLeft = 0f;
					//headerPagaRenta.BorderWidthTop = 0f;
					headerPagaRenta.PaddingTop = 5f;	
					headerPagaRenta.PaddingBottom = 5f;	
					headerPagaRenta.HorizontalAlignment = 2;	
				TablaEconomia.AddCell(headerPagaRenta);
				TablaEconomia.AddCell(headerFuenteIngreso1);
				TablaEconomia.AddCell(headerFuenteIngreso2);
				
					PdfPCell headerCuentorenta = new PdfPCell(PDFs.TitWhite11430802("Cuanto:"));
					headerCuentorenta.Colspan = 2;	
					//headerCuentorenta.BorderWidthBottom = 0f;
					//headerCuentorenta.BorderWidthRight = 0f;
					//headerCuentorenta.BorderWidthLeft = 0f;
					//headerCuentorenta.BorderWidthTop = 0f;
					headerCuentorenta.HorizontalAlignment = 2;
				TablaEconomia.AddCell(headerCuentorenta);
				
					PdfPCell headerRentaC1 = new PdfPCell(PDFs.TitWhite11430802("$1 a $1,000"));
					headerRentaC1.Colspan = 3;
					headerRentaC1.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerRentaC1);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerRentaC2 = new PdfPCell(PDFs.TitWhite11430802("$1,001 a $2,000"));
					headerRentaC2.Colspan = 3;
					headerRentaC2.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerRentaC2);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerRentaC3 = new PdfPCell(PDFs.TitWhite11430802("$2,001 a $3,000"));
					headerRentaC3.Colspan = 4;
					headerRentaC3.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerRentaC3);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerRentaC4 = new PdfPCell(PDFs.TitWhite11430802("$3,001 a $4,000"));
					headerRentaC4.Colspan = 4;
					headerRentaC4.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerRentaC4);
				TablaEconomia.AddCell(headerEspacioBorde);
				
					PdfPCell headerRentaC5 = new PdfPCell(PDFs.TitWhite11430802("$4,001 a Más"));
					headerRentaC5.Colspan = 3;
					headerRentaC5.HorizontalAlignment = 1;
				TablaEconomia.AddCell(headerRentaC5);
				TablaEconomia.AddCell(headerEspacioBorde);	
				
					PdfPCell headerTieneVehiculo = new PdfPCell(PDFs.TitWhite11430802("Tiene Vehículo:"));
					headerTieneVehiculo.Colspan = 2;
					//headerTieneVehiculo.BorderWidthBottom = 0f;
					//headerTieneVehiculo.BorderWidthRight = 0f;
					//headerTieneVehiculo.BorderWidthLeft = 0f;
					//headerTieneVehiculo.BorderWidthTop = 0f;
					headerTieneVehiculo.PaddingTop = 5f;	
					headerTieneVehiculo.PaddingBottom = 5f;	
					headerTieneVehiculo.HorizontalAlignment = 2;	
				TablaEconomia.AddCell(headerTieneVehiculo);
				TablaEconomia.AddCell(headerFuenteIngreso1);
				TablaEconomia.AddCell(headerFuenteIngreso2);
				
					PdfPCell headervehiculoM = new PdfPCell(PDFs.TitWhite11430802LightGray(" Marca:"));
					headervehiculoM.Colspan = 10;
					headervehiculoM.HorizontalAlignment = 0;
				TablaEconomia.AddCell(headervehiculoM);
				
					PdfPCell headervehiculoA = new PdfPCell(PDFs.TitWhite11430802LightGray(" Año:"));
					headervehiculoA.Colspan = 5;
					headervehiculoA.HorizontalAlignment = 0;
				TablaEconomia.AddCell(headervehiculoA);
				
					PdfPCell headervehiculoValor = new PdfPCell(PDFs.TitWhite11430802LightGray(" Valor del Vehículo:"));
					headervehiculoValor.Colspan = 9;
					headervehiculoValor.HorizontalAlignment = 0;
				TablaEconomia.AddCell(headervehiculoValor);
				
				document.Add(TablaEconomia);
				document.Add(espacio);
				
				float[] widthsFamilia = new float[]{16.80f, 16.80f, 16.80f, 17.80f, 17.80f, 17.80f, 17.80f, 17.80f, 17.80f, 17.80f, 17.80f, 16.80f, 8.80f, 16.80f, 
													16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.60f, 16.60f };
				PdfPTable TablaFamilia = new PdfPTable(28);
				TablaFamilia.SetWidths(widthsFamilia);
				TablaFamilia.WidthPercentage = 100;
				TablaFamilia.HorizontalAlignment = 0; 
				TablaFamilia.TotalWidth = 470f;
							
					PdfPCell headerCasado= new PdfPCell(PDFs.TitWhite11430802("Casado: "));
					headerCasado.Colspan = 2;					
					//headerCasado.BorderWidthBottom = 0f;
					//headerCasado.BorderWidthRight = 0f;
					//headerCasado.BorderWidthLeft = 0f;
					//headerCasado.BorderWidthTop = 0f;
					headerCasado.PaddingTop = 5f;	
					headerCasado.PaddingBottom = 5f;	
					headerCasado.HorizontalAlignment = 2;	
				TablaFamilia.AddCell(headerCasado);
				TablaFamilia.AddCell(headerFuenteIngreso1);  //si
				TablaFamilia.AddCell(headerFuenteIngreso2); //no
				
					PdfPCell headerReligion = new PdfPCell(PDFs.TitWhite11430802("Religión: "));
					headerReligion.Colspan = 2;					
					//headerReligion.BorderWidthBottom = 0f;
					//headerReligion.BorderWidthRight = 0f;
					//headerReligion.BorderWidthLeft = 0f;
					//headerReligion.BorderWidthTop = 0f;
					headerReligion.HorizontalAlignment = 2;	
				TablaFamilia.AddCell(headerReligion);			
				
					PdfPCell headerReligion1 = new PdfPCell(PDFs.TitWhite11430802("Cristiana"));
					headerReligion1.Colspan = 2;
					headerReligion1.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerReligion1);
					PdfPCell headerReligion2 = new PdfPCell(PDFs.TitWhite11430802("Católica"));
					headerReligion2.Colspan = 2;
					headerReligion2.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerReligion2);
					PdfPCell headerReligion3 = new PdfPCell(PDFs.TitWhite11430802("Otra"));
					headerReligion3.Colspan = 2;
					headerReligion3.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerReligion3);
					
					PdfPCell headerEspacio = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEspacio.Colspan = 1;					
					headerEspacio.BorderWidthBottom = 0f;
					headerEspacio.BorderWidthRight = 0f;
					headerEspacio.BorderWidthLeft = 0f;
					headerEspacio.BorderWidthTop = 0f;
					headerEspacio.HorizontalAlignment = 2;	
				TablaFamilia.AddCell(headerEspacio);				
						
					PdfPCell headerNombreFamilia = new PdfPCell(PDFs.TitWhite11430802("NOMBRES DE FAMILIA"));
					headerNombreFamilia.Colspan = 7;
					headerNombreFamilia.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerNombreFamilia);
					PdfPCell headerNombreFamiliaSexo = new PdfPCell(PDFs.TitWhite11430802("SEXO"));
					headerNombreFamiliaSexo.Colspan = 2;
					headerNombreFamiliaSexo.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerNombreFamiliaSexo);
					PdfPCell headerEdadFamilia = new PdfPCell(PDFs.TitWhite11430802("NACIMIENTO"));
					headerEdadFamilia.Colspan = 3;
					headerEdadFamilia.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerEdadFamilia);
					PdfPCell headerOcupacionFamilia = new PdfPCell(PDFs.TitWhite11430802("OCUPACIÓN"));
					headerOcupacionFamilia.Colspan = 3;
					headerOcupacionFamilia.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerOcupacionFamilia);				
				
				PdfPCell headerMatrimonioCivil = new PdfPCell(PDFs.TitWhite11430802("Matrimonio Civil: "));
					headerMatrimonioCivil.Colspan = 5;					
					//headerMatrimonioCivil.BorderWidthBottom = 0f;
					//headerMatrimonioCivil.BorderWidthRight = 0f;
					//headerMatrimonioCivil.BorderWidthLeft = 0f;
					//headerMatrimonioCivil.BorderWidthTop = 0f;
					headerMatrimonioCivil.PaddingTop = 5f;	
					headerMatrimonioCivil.PaddingBottom = 5f;	
					headerMatrimonioCivil.HorizontalAlignment = 2;	
				TablaFamilia.AddCell(headerMatrimonioCivil);
					PdfPCell headerMatrimonioCivilC = new PdfPCell(PDFs.TitWhite11430802LightGray("Lugar            /   dd/mm/aaaa"));
					headerMatrimonioCivilC.Colspan = 7;
					headerMatrimonioCivilC.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerMatrimonioCivilC);
				
				TablaFamilia.AddCell(headerEspacio);
					
					PdfPCell headerNombrePareja= new PdfPCell(PDFs.TitWhite11430802LightGray("Pareja"));
					headerNombrePareja.Colspan = 7;
					headerNombrePareja.HorizontalAlignment = 0;	
				TablaFamilia.AddCell(headerNombrePareja);
					PdfPCell headerSexoH = new PdfPCell(PDFs.TitWhite11430802("H"));
					headerSexoH.Colspan = 1;
					headerSexoH.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerSexoH);
					PdfPCell headerSexoM = new PdfPCell(PDFs.TitWhite11430802("M"));
					headerSexoM.Colspan = 1;
					headerSexoM.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerSexoM);				
					PdfPCell headerNacimientoM  = new PdfPCell(PDFs.TitWhite11430802LightGray("dd/mm/aaaa"));
					headerNacimientoM.Colspan = 3;
					headerNacimientoM.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerNacimientoM);
				
					PdfPCell headerOcupacionFamiliaC = new PdfPCell(PDFs.TitWhite11430802(""));
					headerOcupacionFamiliaC.Colspan = 3;
					headerOcupacionFamiliaC.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerOcupacionFamiliaC);
				
				PdfPCell headerMatrimonioIgresia = new PdfPCell(PDFs.TitWhite11430802("Matrimonio Iglesia: "));
					headerMatrimonioIgresia.Colspan = 5;					
					//headerMatrimonioIgresia.BorderWidthBottom = 0f;
					//headerMatrimonioIgresia.BorderWidthRight = 0f;
					//headerMatrimonioIgresia.BorderWidthLeft = 0f;
					//headerMatrimonioIgresia.BorderWidthTop = 0f;
					headerMatrimonioIgresia.PaddingTop = 5f;	
					headerMatrimonioIgresia.PaddingBottom = 5f;	
					headerMatrimonioIgresia.HorizontalAlignment = 2;	
				TablaFamilia.AddCell(headerMatrimonioIgresia);				
				TablaFamilia.AddCell(headerMatrimonioCivilC);				
				TablaFamilia.AddCell(headerEspacio);				
						
					PdfPCell headerNombreHijos = new PdfPCell(PDFs.TitWhite11430802LightGray("Hijos"));
					headerNombreHijos.Colspan = 7;
					headerNombreHijos.PaddingTop = 5f;	
					headerNombreHijos.PaddingBottom = 5f;
					headerNombreHijos.HorizontalAlignment = 0;	
				TablaFamilia.AddCell(headerNombreHijos);		
				TablaFamilia.AddCell(headerSexoH);
				TablaFamilia.AddCell(headerSexoM);				
				TablaFamilia.AddCell(headerNacimientoM);				
				TablaFamilia.AddCell(headerOcupacionFamiliaC);
				
				PdfPCell headerNombresPadres = new PdfPCell(PDFs.TitWhite11430802("NOMBRES DE PADRES "));
					headerNombresPadres.Colspan = 8;
					headerNombresPadres.PaddingTop = 5f;	
					headerNombresPadres.PaddingBottom = 5f;	
					headerNombresPadres.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerNombresPadres);
					PdfPCell headerEdadPadres = new PdfPCell(PDFs.TitWhite11430802("EDAD"));
					headerEdadPadres.Colspan = 2;
					headerEdadPadres.HorizontalAlignment = 1;
				TablaFamilia.AddCell(headerEdadPadres);
					PdfPCell headerVivenPadres = new PdfPCell(PDFs.TitWhite11430802("VIVEN"));
					headerVivenPadres.Colspan = 2;
					headerVivenPadres.HorizontalAlignment = 1;
				TablaFamilia.AddCell(headerVivenPadres);
				TablaFamilia.AddCell(headerEspacio);
				TablaFamilia.AddCell(headerNombreHijos);	
				TablaFamilia.AddCell(headerSexoH);
				TablaFamilia.AddCell(headerSexoM);				
				TablaFamilia.AddCell(headerNacimientoM);				
				TablaFamilia.AddCell(headerOcupacionFamiliaC);
				
				PdfPCell headerNombresPadresC = new PdfPCell(PDFs.TitWhite11430802(""));
					headerNombresPadresC.Colspan = 8;
					headerNombresPadresC.PaddingTop = 5f;	
					headerNombresPadresC.PaddingBottom = 5f;	
					headerNombresPadresC.HorizontalAlignment = 1;	
				TablaFamilia.AddCell(headerNombresPadresC);
					PdfPCell headerEdadPadresC = new PdfPCell(PDFs.TitWhite11430802(""));
					headerEdadPadresC.Colspan = 2;
					headerEdadPadresC.HorizontalAlignment = 1;
				TablaFamilia.AddCell(headerEdadPadresC);
					PdfPCell headerVivenPadresC = new PdfPCell(PDFs.TitWhite11430802(""));
					headerVivenPadresC.Colspan = 2;
					headerVivenPadresC.HorizontalAlignment = 1;
				TablaFamilia.AddCell(headerFuenteIngreso1);  //si
				TablaFamilia.AddCell(headerFuenteIngreso2); //no
				TablaFamilia.AddCell(headerEspacio);
				TablaFamilia.AddCell(headerNombreHijos);	
				TablaFamilia.AddCell(headerSexoH);
				TablaFamilia.AddCell(headerSexoM);				
				TablaFamilia.AddCell(headerNacimientoM);				
				TablaFamilia.AddCell(headerOcupacionFamiliaC);
				
				TablaFamilia.AddCell(headerNombresPadresC);
				TablaFamilia.AddCell(headerEdadPadresC);
				TablaFamilia.AddCell(headerFuenteIngreso1);  //si
				TablaFamilia.AddCell(headerFuenteIngreso2); //no
				TablaFamilia.AddCell(headerEspacio);
				TablaFamilia.AddCell(headerNombreHijos);	
				TablaFamilia.AddCell(headerSexoH);
				TablaFamilia.AddCell(headerSexoM);				
				TablaFamilia.AddCell(headerNacimientoM);				
				TablaFamilia.AddCell(headerOcupacionFamiliaC);			
				
				document.Add(TablaFamilia);
				document.Add(espacio);
				//17
				float[] widthsDependientes = new float[]{215f, 40f, 19f, 60f, 19f, 40f, 19f, 39f, 19f};
				PdfPTable TablaDependientes = new PdfPTable(9);
				TablaDependientes.SetWidths(widthsDependientes);
				TablaDependientes.WidthPercentage = 100;
				TablaDependientes.HorizontalAlignment = 0; 
				TablaDependientes.TotalWidth = 470f;
							
					PdfPCell headerNumeroDepen = new PdfPCell(PDFs.TitWhite11430802("Número de personas que viven con usted: "));
					headerNumeroDepen.Colspan = 1;					
					headerNumeroDepen.BorderWidthBottom = 0f;
					headerNumeroDepen.BorderWidthRight = 0f;
					headerNumeroDepen.BorderWidthLeft = 0f;
					headerNumeroDepen.BorderWidthTop = 0f;
					headerNumeroDepen.PaddingTop = 5f;	
					headerNumeroDepen.PaddingBottom = 5f;	
					headerNumeroDepen.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerNumeroDepen);
				
					PdfPCell headerFamiliaDepen = new PdfPCell(PDFs.TitWhite11430802("Total "));
					headerFamiliaDepen.Colspan = 1;					
					headerFamiliaDepen.BorderWidthBottom = 0f;
					headerFamiliaDepen.BorderWidthRight = 0f;
					headerFamiliaDepen.BorderWidthLeft = 0f;
					headerFamiliaDepen.BorderWidthTop = 0f;
					headerFamiliaDepen.PaddingTop = 5f;	
					headerFamiliaDepen.PaddingBottom = 5f;	
					headerFamiliaDepen.HorizontalAlignment = 1;	
				TablaDependientes.AddCell(headerFamiliaDepen);
								
					PdfPCell headerDepenContenedor = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerDepenContenedor.Colspan = 1;
					headerDepenContenedor.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerDepenContenedor);
				
					PdfPCell headerPadresDepen = new PdfPCell(PDFs.TitWhite11430802("|       Pareja "));
					headerPadresDepen.Colspan = 1;					
					headerPadresDepen.BorderWidthBottom = 0f;
					headerPadresDepen.BorderWidthRight = 0f;
					headerPadresDepen.BorderWidthLeft = 0f;
					headerPadresDepen.BorderWidthTop = 0f;
					headerPadresDepen.PaddingTop = 5f;	
					headerPadresDepen.PaddingBottom = 5f;	
					headerPadresDepen.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerPadresDepen);
				TablaDependientes.AddCell(headerDepenContenedor);
				
					PdfPCell headerParientesDepen = new PdfPCell(PDFs.TitWhite11430802("Hijos "));
					headerParientesDepen.Colspan = 1;					
					headerParientesDepen.BorderWidthBottom = 0f;
					headerParientesDepen.BorderWidthRight = 0f;
					headerParientesDepen.BorderWidthLeft = 0f;
					headerParientesDepen.BorderWidthTop = 0f;
					headerParientesDepen.PaddingTop = 5f;	
					headerParientesDepen.PaddingBottom = 5f;	
					headerParientesDepen.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerParientesDepen);
				TablaDependientes.AddCell(headerDepenContenedor);
				
					PdfPCell headerOtrosDepen = new PdfPCell(PDFs.TitWhite11430802("Otros "));
					headerOtrosDepen.Colspan = 1;					
					headerOtrosDepen.BorderWidthBottom = 0f;
					headerOtrosDepen.BorderWidthRight = 0f;
					headerOtrosDepen.BorderWidthLeft = 0f;
					headerOtrosDepen.BorderWidthTop = 0f;
					headerOtrosDepen.PaddingTop = 5f;	
					headerOtrosDepen.PaddingBottom = 5f;	
					headerOtrosDepen.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerOtrosDepen);
				TablaDependientes.AddCell(headerDepenContenedor);
						
					PdfPCell headerNumeroDepen2 = new PdfPCell(PDFs.TitWhite11430802("Dependientes económicos: "));
					headerNumeroDepen2.Colspan = 1;					
					headerNumeroDepen2.BorderWidthBottom = 0f;
					headerNumeroDepen2.BorderWidthRight = 0f;
					headerNumeroDepen2.BorderWidthLeft = 0f;
					headerNumeroDepen2.BorderWidthTop = 0f;
					headerNumeroDepen2.PaddingTop = 5f;	
					headerNumeroDepen2.PaddingBottom = 5f;	
					headerNumeroDepen2.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerNumeroDepen2);
				
					PdfPCell headerFamiliaDepenPar = new PdfPCell(PDFs.TitWhite11430802("Pareja "));
					headerFamiliaDepenPar.Colspan = 1;					
					headerFamiliaDepenPar.BorderWidthBottom = 0f;
					headerFamiliaDepenPar.BorderWidthRight = 0f;
					headerFamiliaDepenPar.BorderWidthLeft = 0f;
					headerFamiliaDepenPar.BorderWidthTop = 0f;
					headerFamiliaDepenPar.PaddingTop = 5f;	
					headerFamiliaDepenPar.PaddingBottom = 5f;	
					headerFamiliaDepenPar.HorizontalAlignment = 1;	
				TablaDependientes.AddCell(headerFamiliaDepenPar);
				
				TablaDependientes.AddCell(headerDepenContenedor);
				
					PdfPCell headerParientesDepen2 = new PdfPCell(PDFs.TitWhite11430802("|         Hijos "));
					headerParientesDepen2.Colspan = 1;					
					headerParientesDepen2.BorderWidthBottom = 0f;
					headerParientesDepen2.BorderWidthRight = 0f;
					headerParientesDepen2.BorderWidthLeft = 0f;
					headerParientesDepen2.BorderWidthTop = 0f;
					headerParientesDepen2.PaddingTop = 5f;	
					headerParientesDepen2.PaddingBottom = 5f;	
					headerParientesDepen2.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerParientesDepen2);
				
				TablaDependientes.AddCell(headerDepenContenedor);
								
					PdfPCell headerPadresD = new PdfPCell(PDFs.TitWhite11430802("Padres "));
					headerPadresD.Colspan = 1;					
					headerPadresD.BorderWidthBottom = 0f;
					headerPadresD.BorderWidthRight = 0f;
					headerPadresD.BorderWidthLeft = 0f;
					headerPadresD.BorderWidthTop = 0f;
					headerPadresD.PaddingTop = 5f;	
					headerPadresD.PaddingBottom = 5f;	
					headerPadresD.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerPadresD);				
				TablaDependientes.AddCell(headerDepenContenedor);
				
				PdfPCell headerNadieDepen = new PdfPCell(PDFs.TitWhite11430802("Otros "));
					headerNadieDepen.Colspan = 1;					
					headerNadieDepen.BorderWidthBottom = 0f;
					headerNadieDepen.BorderWidthRight = 0f;
					headerNadieDepen.BorderWidthLeft = 0f;
					headerNadieDepen.BorderWidthTop = 0f;
					headerNadieDepen.PaddingTop = 5f;	
					headerNadieDepen.PaddingBottom = 5f;	
					headerNadieDepen.HorizontalAlignment = 2;	
				TablaDependientes.AddCell(headerNadieDepen);
				TablaDependientes.AddCell(headerDepenContenedor);	
				
				document.Add(TablaDependientes);
				document.Add(espacio);
				
				///////////////////////////////////////////////////////////////////////// ESCOLARIDAD Y CONOCIMIENTOS GENERALES  ////////////////////////////////////////////////////////////////////////				
				float[] widthsEscolaridad = new float[]{16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f,
														16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.80f, 16.60f, 16.60f };
				PdfPTable TablaEscolaridad = new PdfPTable(28);
				TablaEscolaridad.SetWidths(widthsEscolaridad);
				TablaEscolaridad.WidthPercentage = 100;
				TablaEscolaridad.HorizontalAlignment = 0; 
				TablaEscolaridad.TotalWidth = 470f;				
				
					PdfPCell headerTituloEscolaridad = new PdfPCell(PDFs.Enclgray215209(" V.- ESCOLARIDAD Y CONOCIMIENTOS GENERALES"));
					headerTituloEscolaridad.HorizontalAlignment = 0;
					headerTituloEscolaridad.Colspan = 28;				
				TablaEscolaridad.AddCell(headerTituloEscolaridad);
				
					PdfPCell headerUltimo = new PdfPCell(PDFs.TitWhite11430802(" Último grado de estudios:"));
					headerUltimo.HorizontalAlignment = 2;
					headerUltimo.PaddingTop = 5f;	
					headerUltimo.PaddingBottom= 5f;			
					//headerUltimo.BorderWidthBottom = 0f;
					//headerUltimo.BorderWidthRight = 0f;
					//headerUltimo.BorderWidthLeft = 0f;
					//headerUltimo.BorderWidthTop = 0f;
					headerUltimo.Colspan = 8;				
				TablaEscolaridad.AddCell(headerUltimo);
				
					PdfPCell headerUltimoP = new PdfPCell(PDFs.TitWhite11430802("Primaria"));
					headerUltimoP.Colspan = 3;
					headerUltimoP.HorizontalAlignment = 1;
				TablaEscolaridad.AddCell(headerUltimoP);
				TablaEscolaridad.AddCell(headerEspacioBorde);
				
					PdfPCell headerUltimoS = new PdfPCell(PDFs.TitWhite11430802("Secundaria"));
					headerUltimoS.Colspan = 3;
					headerUltimoS.HorizontalAlignment = 1;
				TablaEscolaridad.AddCell(headerUltimoS);
				TablaEscolaridad.AddCell(headerEspacioBorde);
				
					PdfPCell headerUltimoPr = new PdfPCell(PDFs.TitWhite11430802("Preparatoria"));
					headerUltimoPr.Colspan = 3;
					headerUltimoPr.HorizontalAlignment = 1;
				TablaEscolaridad.AddCell(headerUltimoPr);
				TablaEscolaridad.AddCell(headerEspacioBorde);
				
					PdfPCell headerUltimoT = new PdfPCell(PDFs.TitWhite11430802("Técnica"));
					headerUltimoT.Colspan = 3;
					headerUltimoT.HorizontalAlignment = 1;
				TablaEscolaridad.AddCell(headerUltimoT);
				TablaEscolaridad.AddCell(headerEspacioBorde);
				
					PdfPCell headerUltimoL = new PdfPCell(PDFs.TitWhite11430802("Licenciatura"));
					headerUltimoL.Colspan = 3;
					headerUltimoL.HorizontalAlignment = 1;
				TablaEscolaridad.AddCell(headerUltimoL);
				TablaEscolaridad.AddCell(headerEspacioBorde);
				
					PdfPCell headerCursos = new PdfPCell(PDFs.TitWhite11430802("CURSOS RECIBIDOS EN EMPRESAS"));
					headerCursos.HorizontalAlignment = 1;
					headerCursos.PaddingTop = 5f;	
					headerCursos.PaddingBottom = 5f;	
					headerCursos.Colspan = 28;				
				TablaEscolaridad.AddCell(headerCursos);
			
					PdfPCell headerCurso = new PdfPCell(PDFs.TitWhite11430802("CURSO"));
					headerCurso.HorizontalAlignment = 1;
					headerCurso.PaddingTop = 5f;	
					headerCurso.PaddingBottom= 5f;	
					headerCurso.Colspan = 9;				
				TablaEscolaridad.AddCell(headerCurso);
				
					PdfPCell headerDuracion = new PdfPCell(PDFs.TitWhite11430802("DURACIÓN"));
					headerDuracion.HorizontalAlignment = 1;
					headerDuracion.Colspan = 6;				
				TablaEscolaridad.AddCell(headerDuracion);
				
					PdfPCell headerEmpresa = new PdfPCell(PDFs.TitWhite11430802("EMPRESA"));
					headerEmpresa.HorizontalAlignment = 1;
					headerEmpresa.Colspan = 10;				
				TablaEscolaridad.AddCell(headerEmpresa);
				
					PdfPCell headerAñoCurso = new PdfPCell(PDFs.TitWhite11430802("AÑO"));
					headerAñoCurso.HorizontalAlignment = 1;
					headerAñoCurso.Colspan = 3;				
				TablaEscolaridad.AddCell(headerAñoCurso);
				
					PdfPCell headerCursoC = new PdfPCell(PDFs.TitWhite11430802("     "));
					headerCursoC.HorizontalAlignment = 1;
					headerCursoC.PaddingTop = 9f;	
					headerCursoC.PaddingBottom = 9f;	
					headerCursoC.Colspan = 9;				
				TablaEscolaridad.AddCell(headerCursoC);
				
					PdfPCell headerDuracionC = new PdfPCell(PDFs.TitWhite11430802("    "));
					headerDuracionC.HorizontalAlignment = 1;
					headerDuracionC.Colspan = 6;				
				TablaEscolaridad.AddCell(headerDuracionC);
				
					PdfPCell headerEmpresaC = new PdfPCell(PDFs.TitWhite11430802("    "));
					headerEmpresa.HorizontalAlignment = 1;
					headerEmpresaC.Colspan = 10;				
				TablaEscolaridad.AddCell(headerEmpresaC);
				
					PdfPCell headerAñoCursoC = new PdfPCell(PDFs.TitWhite11430802("   "));
					headerAñoCursoC.HorizontalAlignment = 1;
					headerAñoCursoC.Colspan = 3;				
				TablaEscolaridad.AddCell(headerAñoCursoC);
					
				TablaEscolaridad.AddCell(headerCursoC);	
				TablaEscolaridad.AddCell(headerDuracionC);
				TablaEscolaridad.AddCell(headerEmpresaC);
				TablaEscolaridad.AddCell(headerAñoCursoC);				
				
				TablaEscolaridad.AddCell(headerCursoC);	
				TablaEscolaridad.AddCell(headerDuracionC);
				TablaEscolaridad.AddCell(headerEmpresaC);
				TablaEscolaridad.AddCell(headerAñoCursoC);
				
				TablaEscolaridad.AddCell(headerCursoC);	
				TablaEscolaridad.AddCell(headerDuracionC);
				TablaEscolaridad.AddCell(headerEmpresaC);
				TablaEscolaridad.AddCell(headerAñoCursoC);
					
				document.Add(TablaEscolaridad);
				document.Add(espacio);
				
				//////////////////////////////////////////////////////////////////////// ACTIVIDAD PROFESIONAL  ////////////////////////////////////////////////////////////////////////				
				
				float[] widthsActividadprofe = new float[]{170f, 50f, 140f, 110f};
				PdfPTable TablaActividadprofe = new PdfPTable(4);
				TablaActividadprofe.SetWidths(widthsActividadprofe);
				TablaActividadprofe.WidthPercentage = 100;
				TablaActividadprofe.HorizontalAlignment = 0; 
				TablaActividadprofe.TotalWidth = 470f;
				
					PdfPCell headerTituloActividad = new PdfPCell(PDFs.Enclgray215209(" Vl.- ACTIVIDAD PROFESIONAL"));
					headerTituloActividad.HorizontalAlignment = 0;
					headerTituloActividad.Colspan = 4;				
				TablaActividadprofe.AddCell(headerTituloActividad);
								
					PdfPCell headerTiposMotores = new PdfPCell(PDFs.TitWhite11430802("TIPOS DE MOTORES QUE HA MANEJADO"));
					headerTiposMotores.HorizontalAlignment = 1;
					headerTiposMotores.PaddingTop = 5f;	
					headerTiposMotores.PaddingBottom = 5f;	
					headerTiposMotores.Colspan = 4;				
				TablaActividadprofe.AddCell(headerTiposMotores);
			
					PdfPCell headerMarcaA = new PdfPCell(PDFs.TitWhite11430802("MARCA DE CAMIÓN"));
					headerMarcaA.HorizontalAlignment = 1;
					headerMarcaA.PaddingTop = 5f;	
					headerMarcaA.PaddingBottom= 5f;	
					headerMarcaA.Colspan = 1;				
				TablaActividadprofe.AddCell(headerMarcaA);
				
					PdfPCell headerModelo = new PdfPCell(PDFs.TitWhite11430802("MODELO"));
					headerModelo.HorizontalAlignment = 1;
					headerModelo.Colspan = 1;				
				TablaActividadprofe.AddCell(headerModelo);
				
					PdfPCell headerMotor = new PdfPCell(PDFs.TitWhite11430802("MOTOR"));
					headerMotor.HorizontalAlignment = 1;
					headerMotor.Colspan = 1;				
				TablaActividadprofe.AddCell(headerMotor);
				
					PdfPCell headerCaja = new PdfPCell(PDFs.TitWhite11430802("CAJA DE VELOCIDADES"));
					headerCaja.HorizontalAlignment = 1;
					headerCaja.Colspan = 1;				
				TablaActividadprofe.AddCell(headerCaja);
				
					PdfPCell headerMarcaAC = new PdfPCell(PDFs.TitWhite11430802("     "));
					headerMarcaAC.HorizontalAlignment = 1;
					headerMarcaAC.PaddingTop = 5f;	
					headerMarcaAC.PaddingBottom = 5f;	
					headerMarcaAC.Colspan = 1;				
				TablaActividadprofe.AddCell(headerMarcaAC);				
				
					PdfPCell headerModeloC = new PdfPCell(PDFs.TitWhite11430802("    "));
					headerModeloC.HorizontalAlignment = 1;
					headerModeloC.Colspan = 1;				
				TablaActividadprofe.AddCell(headerModeloC);
				
					PdfPCell headerMotorC = new PdfPCell(PDFs.TitWhite11430802("    "));
					headerMotorC.HorizontalAlignment = 1;
					headerMotorC.Colspan = 1;				
				TablaActividadprofe.AddCell(headerMotorC);
				
					PdfPCell headerCajaC = new PdfPCell(PDFs.TitWhite11430802("   "));
					headerCajaC.HorizontalAlignment = 1;
					headerCajaC.Colspan = 1;				
				TablaActividadprofe.AddCell(headerCajaC);
					
				TablaActividadprofe.AddCell(headerMarcaAC);	
				TablaActividadprofe.AddCell(headerModeloC);
				TablaActividadprofe.AddCell(headerMotorC);
				TablaActividadprofe.AddCell(headerCajaC);

				TablaActividadprofe.AddCell(headerMarcaAC);	
				TablaActividadprofe.AddCell(headerModeloC);
				TablaActividadprofe.AddCell(headerMotorC);
				TablaActividadprofe.AddCell(headerCajaC);

				TablaActividadprofe.AddCell(headerMarcaAC);	
				TablaActividadprofe.AddCell(headerModeloC);
				TablaActividadprofe.AddCell(headerMotorC);
				TablaActividadprofe.AddCell(headerCajaC);
					
				PdfPCell headerSabe = new PdfPCell(PDFs.TitWhite11430802(" Sabe manejar algún otro tipo de máquinas  o aparatos:______________________________________________________________________________"));
					headerSabe.HorizontalAlignment = 2;
					headerSabe.PaddingTop = 13f;	
					headerSabe.PaddingBottom = 1f;			
					headerSabe.BorderWidthBottom = 0f;
					headerSabe.BorderWidthRight = 0f;
					headerSabe.BorderWidthLeft = 0f;
					headerSabe.BorderWidthTop = 0f;
					headerSabe.Colspan = 4;				
				TablaActividadprofe.AddCell(headerSabe);
				
				document.Add(TablaActividadprofe);
				document.Add(espacio);
				
				
				//////////////////////////////////////////////////////////////////////// REFERENCIAS PERSONALES  ////////////////////////////////////////////////////////////////////////				
				
				float[] widthsReferencias = new float[]{170f, 80f, 70f, 75f, 75f};
				PdfPTable TablaReferencias = new PdfPTable(5);
				TablaReferencias.SetWidths(widthsReferencias);
				TablaReferencias.WidthPercentage = 100;
				TablaReferencias.HorizontalAlignment = 0; 
				TablaReferencias.TotalWidth = 470f;
				
					PdfPCell headerTituloReferencias = new PdfPCell(PDFs.Enclgray215209(" Vll.- REFERENCIAS PERSONALES  (NO FAMILIAR)"));
					headerTituloReferencias.HorizontalAlignment = 0;
					headerTituloReferencias.Colspan = 5;				
				TablaReferencias.AddCell(headerTituloReferencias);
								
					PdfPCell headerNombreRef = new PdfPCell(PDFs.TitWhite11430802("NOMBRE"));
					headerNombreRef.HorizontalAlignment = 1;
					headerNombreRef.PaddingTop = 5f;	
					headerNombreRef.PaddingBottom = 5f;	
					headerNombreRef.Colspan = 1;				
				TablaReferencias.AddCell(headerNombreRef);
			
					PdfPCell headerTelefonoRef = new PdfPCell(PDFs.TitWhite11430802("TELÉFONO"));
					headerTelefonoRef.HorizontalAlignment = 1;	
					headerTelefonoRef.Colspan = 1;				
				TablaReferencias.AddCell(headerTelefonoRef);
				
					PdfPCell headerTiempoRef = new PdfPCell(PDFs.TitWhite11430802("TIEMPO"));
					headerTiempoRef.HorizontalAlignment = 1;
					headerTiempoRef.Colspan = 1;				
				TablaReferencias.AddCell(headerTiempoRef);
				
					PdfPCell headerRelacionRef = new PdfPCell(PDFs.TitWhite11430802("RELACIÓN"));
					headerRelacionRef.HorizontalAlignment = 1;
					headerRelacionRef.Colspan = 1;				
				TablaReferencias.AddCell(headerRelacionRef);
				
					PdfPCell headerOcupacionRef = new PdfPCell(PDFs.TitWhite11430802("OCUPACIÓN"));
					headerOcupacionRef.HorizontalAlignment = 1;
					headerOcupacionRef.Colspan = 1;				
				TablaReferencias.AddCell(headerOcupacionRef);
				
					PdfPCell headerNombreRefC = new PdfPCell(PDFs.TitWhite11430802("     "));
					headerNombreRefC.HorizontalAlignment = 1;
					headerNombreRefC.PaddingTop = 5f;	
					headerNombreRefC.PaddingBottom = 5f;	
					headerNombreRefC.Colspan = 1;				
				TablaReferencias.AddCell(headerNombreRefC);				
				
					PdfPCell headerTelefonoRefC = new PdfPCell(PDFs.TitWhite11430802("    "));
					headerTelefonoRefC.HorizontalAlignment = 1;
					headerTelefonoRefC.Colspan = 1;				
				TablaReferencias.AddCell(headerTelefonoRefC);
				
					PdfPCell headerTiempoRefC = new PdfPCell(PDFs.TitWhite11430802("    "));
					headerTiempoRefC.HorizontalAlignment = 1;
					headerTiempoRefC.Colspan = 1;				
				TablaReferencias.AddCell(headerTiempoRefC);
				
					PdfPCell headerRelacionRefC = new PdfPCell(PDFs.TitWhite11430802("   "));
					headerRelacionRefC.HorizontalAlignment = 1;
					headerRelacionRefC.Colspan = 1;				
				TablaReferencias.AddCell(headerRelacionRefC);
				
					PdfPCell headerOcupacionRefC = new PdfPCell(PDFs.TitWhite11430802("   "));
					headerOcupacionRefC.HorizontalAlignment = 1;
					headerOcupacionRefC.Colspan = 1;				
				TablaReferencias.AddCell(headerOcupacionRefC);
					
				TablaReferencias.AddCell(headerNombreRefC);	
				TablaReferencias.AddCell(headerTelefonoRefC);
				TablaReferencias.AddCell(headerTiempoRefC);
				TablaReferencias.AddCell(headerRelacionRefC);
				TablaReferencias.AddCell(headerOcupacionRefC);
				
				TablaReferencias.AddCell(headerNombreRefC);	
				TablaReferencias.AddCell(headerTelefonoRefC);
				TablaReferencias.AddCell(headerTiempoRefC);
				TablaReferencias.AddCell(headerRelacionRefC);
				TablaReferencias.AddCell(headerOcupacionRefC);
				
				TablaReferencias.AddCell(headerNombreRefC);	
				TablaReferencias.AddCell(headerTelefonoRefC);
				TablaReferencias.AddCell(headerTiempoRefC);
				TablaReferencias.AddCell(headerRelacionRefC);
				TablaReferencias.AddCell(headerOcupacionRefC);
				
				document.Add(TablaReferencias);
				document.Add(espacio);
				
			}
			#endregion
			
			#region DOCUMENTACIÓN DE INDUCCIÓN
			public void FormatoDocInduccion(Document document, PdfWriter writer, System.IO.MemoryStream ms, string id, String nombre, String apPat){				
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 3, iTextSharp.text.Font.BOLD ));
				document.Add(PDFs.LogoSolicitud(writer));
				
		 		float[] widthsHoraLL = new float[]{270f, 200f};	 		
				PdfPTable TablaHoraLL = new PdfPTable(2);
				TablaHoraLL.SetWidths(widthsHoraLL);
				TablaHoraLL.WidthPercentage = 30;
				TablaHoraLL.TotalWidth = 470f;
				TablaHoraLL.HorizontalAlignment = 2;
				
					PdfPCell headerHoraLlegada = new PdfPCell(PDFs.TitWhite11430802Padding5(" HORA LLEGADA "));
					headerHoraLlegada.HorizontalAlignment = 2;		
					headerHoraLlegada.BorderWidthBottom = 0f;
					headerHoraLlegada.BorderWidthRight = 0f;
					headerHoraLlegada.BorderWidthLeft = 0f;
					headerHoraLlegada.BorderWidthTop = 0f;
				TablaHoraLL.AddCell(headerHoraLlegada);	
				TablaHoraLL.AddCell(PDFs.TitWhite11430802Padding5(" "));
							
				document.Add(espacio);
				document.Add(espacio);
				document.Add(espacio);
				document.Add(TablaHoraLL);
				document.Add(espacio);
				
				///////////////////////////////////////////////////////////////////////// ECONOMÍA Y COMPOSICIÓN FAMILIAR  ////////////////////////////////////////////////////////////////////////
				
				//float[] widthsControl = new float[]{ 125f, 125f, 45f, 45f, 130f };
				float[] widthsControl = new float[]{ 40, 320f, 50f, 60f};
				PdfPTable TablaControl = new PdfPTable(4);
				TablaControl.SetWidths(widthsControl);
				TablaControl.WidthPercentage = 100;
				TablaControl.HorizontalAlignment = 0; 
				TablaControl.TotalWidth = 470f;
				
					PdfPCell headerTituloControl = new PdfPCell(PDFs.Enclgray215209(" CONTROL DE INDUCCIÓN Y CONTRATACIÓN DE PERSONAL                                                                     OPERADOR DE CAMION"));
					headerTituloControl.HorizontalAlignment = 0;
					headerTituloControl.Colspan = 4;				
				TablaControl.AddCell(headerTituloControl);
										
					PdfPCell headerOperador = new PdfPCell(PDFs.TitWhite11430802("OPERADOR"));
					headerOperador.BorderWidthBottom = 0f;
					headerOperador.BorderWidthRight = 0f;
					headerOperador.BorderWidthLeft = 0f;
					headerOperador.BorderWidthTop = 0f;
					headerOperador.PaddingTop = 5f;	
					headerOperador.PaddingBottom= 5f;	
					headerOperador.HorizontalAlignment = 0;	
				TablaControl.AddCell(headerOperador);
				
					PdfPCell headerOperadorC = new PdfPCell(PDFs.TitWhite11430802BOLD("   "+nombre+" "+apPat));
					headerOperadorC.BorderWidthRight = 0f;
					headerOperadorC.BorderWidthLeft = 0f;
					headerOperadorC.BorderWidthTop = 0f;
					headerOperadorC.HorizontalAlignment = 0;
				TablaControl.AddCell(headerOperadorC);
								
					PdfPCell headerFecha = new PdfPCell(PDFs.TitWhite11430802("FECHA"));
					headerFecha.HorizontalAlignment = 1;
				TablaControl.AddCell(headerFecha);
				
				PdfPCell headerFechaC = new PdfPCell(PDFs.TitWhite11430802(DateTime.Now.ToString("dd/MM/yyyy")));
					headerFechaC.HorizontalAlignment = 1;
				TablaControl.AddCell(headerFechaC);
				
				PdfPCell headerAviso = new PdfPCell(PDFs.TitWhite11430802("EL CONDUCTOR DEBERÁ CUMPLIR CON LOS DATOS QUE A CONTINUACIÓN SE DESCRIBEN, RECABANDO LA FIRMA DE LAS ÁREAS QUE INVOLUCRAN EN ESTE PROCESO"));
					headerAviso.Colspan = 4;			
					headerAviso.BorderWidthBottom = 0f;
					headerAviso.BorderWidthRight = 0f;
					headerAviso.BorderWidthLeft = 0f;
					headerAviso.BorderWidthTop = 0f;
					headerAviso.HorizontalAlignment = 0;	
				TablaControl.AddCell(headerAviso);
				
				document.Add(TablaControl);
				document.Add(espacio);		
				
				float[] widthsControlPre = new float[]{ 130f, 120f, 40f, 40f, 140f};
				PdfPTable TablaControlPre = new PdfPTable(5);
				TablaControlPre.SetWidths(widthsControlPre);
				TablaControlPre.WidthPercentage = 100;
				TablaControlPre.HorizontalAlignment = 0; 
				TablaControlPre.TotalWidth = 470f;
				
					/*PdfPCell headerTituloBlanco = new PdfPCell(PDFs.Enclgray215209(" "));
					headerTituloBlanco.HorizontalAlignment = 0;
					headerTituloBlanco.Colspan = 5;				
				TablaControlPre.AddCell(headerTituloBlanco);*/
										
					PdfPCell headerDepartamento = new PdfPCell(PDFs.TitWhite11430802FondoGris("DEPARTAMENTO"));
					headerDepartamento.PaddingTop = 5f;	
					headerDepartamento.PaddingBottom = 5f;	
					headerDepartamento.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerDepartamento);
				
					PdfPCell headerActividad = new PdfPCell(PDFs.TitWhite11430802FondoGris("ACTIVIDAD"));
					headerActividad.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividad);
				
					PdfPCell headerInicio = new PdfPCell(PDFs.TitWhite11430802FondoGris("INICIO"));
					headerInicio.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerInicio);
				
					PdfPCell headerFin = new PdfPCell(PDFs.TitWhite11430802FondoGris("TERMINO"));
					headerFin.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerFin);
				
					PdfPCell headerFirma = new PdfPCell(PDFs.TitWhite11430802FondoGris("FIRMA"));
					headerFirma.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerFirma);
								
					PdfPCell headerDepartamento1 = new PdfPCell(PDFs.TitWhite11430802("GCIA OPERACIONES"));
					headerDepartamento1.PaddingTop = 5f;	
					headerDepartamento1.PaddingBottom = 5f;	
					headerDepartamento1.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerDepartamento1);				
					PdfPCell headerActividad1 = new PdfPCell(PDFs.TitWhite11430802("VALIDACION ZONA"));
					headerActividad1.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividad1);				
					PdfPCell headerInicio1 = new PdfPCell(PDFs.TitWhite11430802FondoGris(" "));
				TablaControlPre.AddCell(headerInicio1);				
					PdfPCell headerFin1 = new PdfPCell(PDFs.TitWhite11430802FondoGris(" "));
				TablaControlPre.AddCell(headerFin1);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Angel Ornelas "));
				
				PdfPCell headerDepartamento2 = new PdfPCell(PDFs.TitWhite11430802("RECURSOS HUMANOS"));
					headerDepartamento2.PaddingTop = 5f;	
					headerDepartamento2.PaddingBottom = 5f;	
					headerDepartamento2.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividad2 = new PdfPCell(PDFs.TitWhite11430802("SELECCIÓN DE PERSONAL"));
					headerActividad2.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividad2);				
					PdfPCell headerInicio2 = new PdfPCell(PDFs.TitWhite11430802(" "));
				TablaControlPre.AddCell(headerInicio2);				
					PdfPCell headerFin2 = new PdfPCell(PDFs.TitWhite11430802(" "));
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Paty"));
								
				TablaControlPre.AddCell(headerDepartamento2);
					PdfPCell headerActividad3 = new PdfPCell(PDFs.TitWhite11430802("REVICION MEDICA"));
					headerActividad3.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerActividad3);	
				TablaControlPre.AddCell(headerInicio1);		
				TablaControlPre.AddCell(headerFin1);
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" "));

					PdfPCell headerDepartamento4 = new PdfPCell(PDFs.TitWhite11430802("COMEDOR"));
					headerDepartamento4.PaddingTop = 5f;	
					headerDepartamento4.PaddingBottom = 5f;	
					headerDepartamento4.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerDepartamento4);				
					PdfPCell headerActividad4 = new PdfPCell(PDFs.TitWhite11430802("VALIDACION ZONA"));
					headerActividad4.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerActividad4);
				TablaControlPre.AddCell(headerInicio1);
				TablaControlPre.AddCell(headerFin1);
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Irma"));
				
					PdfPCell headerTituloCapacitacion = new PdfPCell(PDFs.Enclgray215209("CAPACITACION Y ENTREGA DE MATERIALES"));
					headerTituloCapacitacion.HorizontalAlignment = 1;
					headerTituloCapacitacion.Colspan = 5;				
				TablaControlPre.AddCell(headerTituloCapacitacion);
				
				TablaControlPre.AddCell(headerDepartamento);;
				TablaControlPre.AddCell(headerActividad);
				TablaControlPre.AddCell(headerInicio);
				TablaControlPre.AddCell(headerFin);					
				TablaControlPre.AddCell(headerFirma);
					
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC1 = new PdfPCell(PDFs.TitWhite11430802("INDUCCIÓN GENERAL"));
					headerActividadC1.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC1);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Darío"));
					
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC2 = new PdfPCell(PDFs.TitWhite11430802("TARJETA DE BANCO"));
					headerActividadC2.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC2);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Paty"));
					
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC3 = new PdfPCell(PDFs.TitWhite11430802("UNIFORME"));
					headerActividadC3.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC3);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Paty"));
					
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC4 = new PdfPCell(PDFs.TitWhite11430802("SCANEO DE DOCUMENTOS"));
					headerActividadC4.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC4);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Melissa"));
					
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC5 = new PdfPCell(PDFs.TitWhite11430802("PLAN CELULAR"));
					headerActividadC5.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC5);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Nestor"));
								
					PdfPCell headerDepartamentoC6 = new PdfPCell(PDFs.TitWhite11430802("ÁREA ADMINISTRATIVA"));
					headerDepartamentoC6.PaddingTop = 5f;	
					headerDepartamentoC6.PaddingBottom = 5f;	
					headerDepartamentoC6.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerDepartamentoC6);				
					PdfPCell headerActividadC6 = new PdfPCell(PDFs.TitWhite11430802("GAFFETE"));
					headerActividadC6.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC6);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Melissa"));
								
					PdfPCell headerDepartamentoC7 = new PdfPCell(PDFs.TitWhite11430802("ÁREA DE OPERACIONES"));
					headerDepartamentoC7.PaddingTop = 5f;	
					headerDepartamentoC7.PaddingBottom = 5f;	
					headerDepartamentoC7.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerDepartamentoC7);				
					PdfPCell headerActividadC7 = new PdfPCell(PDFs.TitWhite11430802("INDUCCIÓN OPERATIVA"));
					headerActividadC7.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC7);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" COORD  EN TURNO"));
								
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC8 = new PdfPCell(PDFs.TitWhite11430802BOLD("INDUCCIÓN OPERATIVA"));
					headerActividadC8.HorizontalAlignment = 1;
					headerActividadC8.Colspan = 3;
				TablaControlPre.AddCell(headerActividadC8);		
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" "));
				
					PdfPCell headerDepartamentoC9 = new PdfPCell(PDFs.TitWhite11430802("ÁREA ADMINISTRATIVA"));
					headerDepartamentoC9.PaddingTop = 5f;	
					headerDepartamentoC9.PaddingBottom = 5f;	
					headerDepartamentoC9.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerDepartamentoC9);				
					PdfPCell headerActividadC9 = new PdfPCell(PDFs.TitWhite11430802("DIRECTORIO TELEFONICO Y CUENTA DE GOOGLE"));
					headerActividadC9.HorizontalAlignment = 1;	
				TablaControlPre.AddCell(headerActividadC9);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Elizondo"));
				
					PdfPCell headerDepartamentoC10 = new PdfPCell(PDFs.TitWhite11430802("VENTAS"));
					headerDepartamentoC10.PaddingTop = 5f;	
					headerDepartamentoC10.PaddingBottom = 5f;	
					headerDepartamentoC10.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerDepartamentoC10);				
					PdfPCell headerActividadC10 = new PdfPCell(PDFs.TitWhite11430802("Carlos Alberto Rojas Becerra "));
					headerActividadC10.HorizontalAlignment = 0;	
				TablaControlPre.AddCell(headerActividadC10);
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);				
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Miguel y/o Camilo "));
				
				TablaControlPre.AddCell(headerDepartamento2);				
					PdfPCell headerActividadC11 = new PdfPCell(PDFs.TitWhite11430802("CONTRATACION DE PERSONAL"));
					headerActividadC11.HorizontalAlignment = 1;
				TablaControlPre.AddCell(headerActividadC11);	
				TablaControlPre.AddCell(headerInicio2);	
				TablaControlPre.AddCell(headerFin2);		
				TablaControlPre.AddCell(PDFs.TitWhite11430802BOLD(" Gloria"));
				
				
				document.Add(TablaControlPre);
				document.Add(espacio);	
				
			}
			#endregion
			
			#region AUTORIZACIÓN DATOS CANDIDATO
			public Interfaz.Operador.Dato.Parametros parametros;
			
			private void getParametros(){
				if(parametros != null)
					parametros = null;
				parametros = new Interfaz.Operador.Dato.Parametros();
				
				if(parametros != null){
					try{
						conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 5");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							parametros.edadMin = conn.leer["PARAMETRO1"].ToString();
							parametros.edadMax = conn.leer["PARAMETRO2"].ToString();
							parametros.imagen = conn.leer["PARAMETRO3"].ToString();
							parametros.tatuajes = conn.leer["PARAMETRO4"].ToString();
							parametros.percing = conn.leer["PARAMETRO5"].ToString();
							parametros.infonavit = conn.leer["PARAMETRO6"].ToString();						
						}
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
					try{
						conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 6");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							parametros.expDual = conn.leer["PARAMETRO1"].ToString();
							parametros.expDirTrasera = conn.leer["PARAMETRO2"].ToString();
							parametros.expTransPersonal = conn.leer["PARAMETRO3"].ToString();
							parametros.descEstatal = conn.leer["PARAMETRO4"].ToString();
							parametros.descFederal = conn.leer["PARAMETRO5"].ToString();
							parametros.descAptoMedico = conn.leer["PARAMETRO6"].ToString();						
						}
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
					try{
						conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 7");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							parametros.licEstatal = conn.leer["PARAMETRO1"].ToString();
							parametros.vigEstatal = conn.leer["PARAMETRO2"].ToString();
							parametros.licFederal = conn.leer["PARAMETRO3"].ToString();
							parametros.vigFederal = conn.leer["PARAMETRO4"].ToString();
							parametros.vigAptoMedico = conn.leer["PARAMETRO5"].ToString();					
						}
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
					try{
						conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 8");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							parametros.contactoTaller = conn.leer["PARAMETRO1"].ToString();
							parametros.numeroTaller = conn.leer["PARAMETRO2"].ToString();
							parametros.contactoOficina = conn.leer["PARAMETRO3"].ToString();
							parametros.numeroOficina = conn.leer["PARAMETRO4"].ToString();
						}
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
				}
			}
					
			public void FormatoAutorizacionCandidato(Document document, PdfWriter writer, System.IO.MemoryStream ms, PictureBox ptbImagen, string folio, String nombre, String apPat, String apMat, String edad, String sexo, String imagenPersonal, 
                                 String tipoOperador, String zona, List <Interfaz.Operador.Dato.Telefonos> ListarTelefonos, string tatuajes, String colonia, string infonavit, string monto, string piercing,
								 String tipoLicE, String estatoLicE, String numLicE, String venceLicE, String tipoLicF, String estadoLicF, String numLicF, String venceLicF, String numApto, String venceApto,
								 String dualA, String dualM, String dirTraseraA, String dirTraseraM, String personalA, String personalM, String tramite, string fuente, string detalleFuente, string diaFuente,
								 bool AJUSTE_LIC, Interfaz.Operador.Dato.LicenciasAjuste licAjuste){			
				
				getParametros();
				Paragraph espacio = new Paragraph("\n", FontFactory.GetFont("ARIAL", 3, iTextSharp.text.Font.BOLD ));
				document.Add(PDFs.LogoAutorizacion(writer));
								
				iTextSharp.text.Image foto2 = null;				
				try{
					foto2 = iTextSharp.text.Image.GetInstance(ptbImagen.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
				}catch(Exception){
					foto2 = iTextSharp.text.Image.GetInstance(@"../debug/Nomina.jpg");
				}

		 		float[] widthsFolio = new float[]{36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.15f, 36.20f};	 		
				PdfPTable TablaFolios = new PdfPTable(13);
				TablaFolios.SetWidths(widthsFolio);
				TablaFolios.WidthPercentage = 55;
				TablaFolios.TotalWidth = 470f;
				TablaFolios.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
					PdfPCell headerTituloAuto = new PdfPCell(PDFs.Enclgray215206SinBorde("AUTORIZACION SELECCIÓN DE PERSONAL   "));
					headerTituloAuto.Colspan = 13;
					headerTituloAuto.PaddingTop = 4f;	
					headerTituloAuto.PaddingBottom = 4f;	
					headerTituloAuto.HorizontalAlignment = 2;	
				TablaFolios.AddCell(headerTituloAuto);
					PdfPCell headerTituloAuto2 = new PdfPCell(PDFs.TitWhite11430802("Aspectos Iniciales: Operador"));
					headerTituloAuto2.Colspan = 8;
					headerTituloAuto2.PaddingTop = 2f;	
					headerTituloAuto2.PaddingBottom = 2f;	
					headerTituloAuto2.HorizontalAlignment = 1;	
				TablaFolios.AddCell(headerTituloAuto2);
					PdfPCell headerTituloAuto3 = new PdfPCell(PDFs.TitWhite11430802("Folio: "));
					headerTituloAuto3.Colspan = 2;
					headerTituloAuto3.PaddingTop = 2f;	
					headerTituloAuto3.PaddingBottom = 2f;	
					headerTituloAuto3.HorizontalAlignment = 2;	
				TablaFolios.AddCell(headerTituloAuto3);
					PdfPCell headerTituloAuto4 = new PdfPCell(PDFs.TitWhite11430802(" "+folio));
					headerTituloAuto4.Colspan = 3;
					headerTituloAuto4.PaddingTop = 2f;	
					headerTituloAuto4.PaddingBottom = 2f;	
					headerTituloAuto4.HorizontalAlignment = 1;	
				TablaFolios.AddCell(headerTituloAuto4);
					PdfPCell headerTituloAuto5 = new PdfPCell(PDFs.TitWhite11430802("Fecha:"));
					headerTituloAuto5.Colspan = 2;
					headerTituloAuto5.PaddingTop = 3f;	
					headerTituloAuto5.PaddingBottom = 3f;	
					headerTituloAuto5.HorizontalAlignment = 2;	
				TablaFolios.AddCell(headerTituloAuto5);
					PdfPCell headerTituloAuto6 = new PdfPCell(PDFs.TitWhite11430802(" "+DateTime.Now.ToLongDateString().ToUpper()+" "+DateTime.Now.ToString("HH:mm")+" hrs"));
					headerTituloAuto6.Colspan = 11;
					headerTituloAuto6.PaddingTop = 3f;	
					headerTituloAuto6.PaddingBottom = 3f;	
					headerTituloAuto6.HorizontalAlignment = 1;	
				TablaFolios.AddCell(headerTituloAuto6);				
				document.Add(TablaFolios);
				document.Add(espacio);
					
				//////////////////////////////////////////////////////////////////////////////// DATOS PERSONALES ////////////////////////////////////////////////////////////////////////////////
				
				float[] widthsDatos = new float[]{369.28f, 100.72f};	 		
				PdfPTable TablaD = new PdfPTable(2);
				TablaD.SetWidths(widthsDatos);
				TablaD.WidthPercentage = 100;
				TablaD.HorizontalAlignment = 1;
				TablaD.TotalWidth = 470f;				
				
					PdfPCell headerTituloDP = new PdfPCell(PDFs.Enclgray215209Normal(" Datos Personales"));
					headerTituloDP.HorizontalAlignment = 0;
					headerTituloDP.Colspan = 2;			
					headerTituloDP.BorderWidthLeft = 0f;	
				TablaD.AddCell(headerTituloDP);			
								
				float[] widthsInfo = new float[]{27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.76f};
				PdfPTable TablaI = new PdfPTable(17);
				TablaI.SetWidths(widthsInfo);
				TablaI.WidthPercentage = 100;
				TablaI.HorizontalAlignment = 0; 
				TablaI.TotalWidth = 470f;				
										
					PdfPCell headerNombreDP= new PdfPCell(PDFs.TitWhite11430802("Nombre:"));
					headerNombreDP.Colspan = 2;
					headerNombreDP.PaddingTop = 3f;	
					headerNombreDP.PaddingBottom= 3f;	
					headerNombreDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerNombreDP);
				
					PdfPCell headerNombreDPC = new PdfPCell(PDFs.TitWhite11430802(" "+nombre+" "+apPat+" "+apMat));
					headerNombreDPC.Colspan = 7;
					headerNombreDPC.HorizontalAlignment = 1;	
				TablaI.AddCell(headerNombreDPC);
				
					PdfPCell headerEdadDP = new PdfPCell(PDFs.TitWhite11430802(" Edad: "));
					headerEdadDP.Colspan = 1;	
					headerEdadDP.HorizontalAlignment = 2;	
					headerEdadDP.BorderWidthRight = 0f;
					headerEdadDP.BorderWidthBottom = 0f;
				TablaI.AddCell(headerEdadDP);
				
				if(Convert.ToInt16(edad) < Convert.ToInt16(parametros.edadMin) || Convert.ToInt16(edad) > Convert.ToInt16(parametros.edadMax)){
						PdfPCell headerEdadDPC = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+edad+" años  " ));
						headerEdadDPC.Colspan = 2;
						headerEdadDPC.HorizontalAlignment = 1;	
						headerEdadDPC.BorderWidthRight = 0f;
						headerEdadDPC.BorderWidthLeft = 0f;
						headerEdadDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerEdadDPC);
				}else{
						PdfPCell headerEdadDPC = new PdfPCell(PDFs.TitWhite11430802(""+edad+" años  " ));
						headerEdadDPC.Colspan = 2;
						headerEdadDPC.HorizontalAlignment = 1;	
						headerEdadDPC.BorderWidthRight = 0f;
						headerEdadDPC.BorderWidthLeft = 0f;
						headerEdadDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerEdadDPC);
				}
					
					PdfPCell headerEdadDPC2 = new PdfPCell(PDFs.TitWhite11430802(""+sexo ));
					headerEdadDPC2.Colspan = 2;
					headerEdadDPC2.HorizontalAlignment = 1;	
					headerEdadDPC2.BorderWidthLeft = 0f;
					headerEdadDPC2.BorderWidthRight = 0f;
					headerEdadDPC2.BorderWidthBottom = 0f;
				TablaI.AddCell(headerEdadDPC2);
								
					PdfPCell headerImagenCDP = new PdfPCell(PDFs.TitWhite11430802("Imagen:"));
					headerImagenCDP.Colspan = 2;
					headerImagenCDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerImagenCDP);
				
				if(Convert.ToInt32(imagenPersonal) < Convert.ToInt32(parametros.imagen)){
					PdfPCell headerImagenDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+imagenPersonal));
					headerImagenDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerImagenDP);
				}else{
					PdfPCell headerImagenDP = new PdfPCell(PDFs.TitWhite11430802(" "+imagenPersonal));
					headerImagenDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerImagenDP);
				}	
				
					PdfPCell headerZonacDPC = new PdfPCell(PDFs.TitWhite11430802(" Zona:"));
					headerZonacDPC.Colspan = 2;
					headerZonacDPC.PaddingTop = 3f;	
					headerZonacDPC.PaddingBottom= 3f;
					headerZonacDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerZonacDPC);
				
					PdfPCell headerZonacDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+zona));
					headerZonacDP.Colspan = 5;
					headerZonacDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerZonacDP);				
				
					PdfPCell headerCeluarDPC = new PdfPCell(PDFs.TitWhite11430802("Celular:"));
					headerCeluarDPC.Colspan = 2;
					headerCeluarDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerCeluarDPC);
				
				string numeroTelefonico = "";
				for (int i = 0; i < ListarTelefonos.Count; i++){
					if(ListarTelefonos[i].relacion == "PROPIO" && ListarTelefonos[i].tipo == "CELULAR"){
						numeroTelefonico = ListarTelefonos[i].numero;
						i = ListarTelefonos.Count-1;
					}else if(ListarTelefonos[i].relacion == "PROPIO" && ListarTelefonos[i].tipo == "FIJO"){						
						numeroTelefonico = ListarTelefonos[i].numero;
					}else{						
						numeroTelefonico = ListarTelefonos[i].numero;
					}
				}
				
				if(numeroTelefonico.Length == 0 && ListarTelefonos.Count > 0)
					numeroTelefonico = ListarTelefonos[0].numero;
				
					PdfPCell headerCeluarDP = new PdfPCell(PDFs.TitWhite11430802(" "+numeroTelefonico));
					headerCeluarDP.Colspan = 5;
					headerCeluarDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerCeluarDP);
				
					PdfPCell hearderTatuajesDPC = new PdfPCell(PDFs.TitWhite11430802("Tatuajes:"));
					hearderTatuajesDPC.Colspan = 2;
					hearderTatuajesDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(hearderTatuajesDPC);
				
				if(parametros.tatuajes != tatuajes){					
					PdfPCell hearderTatuajesDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+tatuajes));
					hearderTatuajesDP.HorizontalAlignment = 1;	
					TablaI.AddCell(hearderTatuajesDP);
				}else{
					PdfPCell hearderTatuajesDP = new PdfPCell(PDFs.TitWhite11430802(" "+tatuajes));
					hearderTatuajesDP.HorizontalAlignment = 1;	
					TablaI.AddCell(hearderTatuajesDP);
				}
				
					PdfPCell headerColoniaDPC = new PdfPCell(PDFs.TitWhite11430802(" Colonia:"));
					headerColoniaDPC.Colspan = 2;
					headerColoniaDPC.PaddingTop = 3f;	
					headerColoniaDPC.PaddingBottom = 3f;
					headerColoniaDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerColoniaDPC);
				
					PdfPCell headerColoniaDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+colonia));
					headerColoniaDP.Colspan = 5;
					headerColoniaDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerColoniaDP);	
				
					PdfPCell headerInfonavitDPC = new PdfPCell(PDFs.TitWhite11430802("Infonavit:"));
					headerInfonavitDPC.Colspan = 2;
					headerInfonavitDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerInfonavitDPC);
				
					PdfPCell headerInfonavitDP = new PdfPCell(PDFs.TitWhite11430802(" "+infonavit));
					headerInfonavitDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerInfonavitDP);
								
				if(monto.Length > 0){
					if(Convert.ToDouble(monto) > Convert.ToDouble(parametros.infonavit)){
						PdfPCell headerInfonavitMontoDPC = new PdfPCell(PDFs.TitWhite11430802BOLD("Monto: $"+monto));
						headerInfonavitMontoDPC.Colspan = 4;
						headerInfonavitMontoDPC.HorizontalAlignment = 0;	
						TablaI.AddCell(headerInfonavitMontoDPC);
					}else{
						PdfPCell headerInfonavitMontoDPC = new PdfPCell(PDFs.TitWhite11430802("Monto: $"+monto));
						headerInfonavitMontoDPC.Colspan = 4;
						headerInfonavitMontoDPC.HorizontalAlignment = 0;	
						TablaI.AddCell(headerInfonavitMontoDPC);
					}
				}else{
					PdfPCell headerInfonavitMontoDPC = new PdfPCell(PDFs.TitWhite11430802("Monto: N/A"));
					headerInfonavitMontoDPC.Colspan = 4;
					headerInfonavitMontoDPC.HorizontalAlignment = 0;	
					TablaI.AddCell(headerInfonavitMontoDPC);
				}
								
					PdfPCell hearderPiercingDPC = new PdfPCell(PDFs.TitWhite11430802("Piercing:"));
					hearderPiercingDPC.Colspan = 2;
					hearderPiercingDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(hearderPiercingDPC);
				
				if(parametros.percing != piercing){					
					PdfPCell hearderPiercingDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+piercing));
					hearderPiercingDP.HorizontalAlignment = 1;	
					TablaI.AddCell(hearderPiercingDP);
				}else{
					PdfPCell hearderPiercingDP = new PdfPCell(PDFs.TitWhite11430802(" "+piercing));
					hearderPiercingDP.HorizontalAlignment = 1;	
					TablaI.AddCell(hearderPiercingDP);
				}				
								
					PdfPCell headerSaltoLinea = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerSaltoLinea.Colspan = 17;					
					headerSaltoLinea.BorderWidthBottom = 0f;
					headerSaltoLinea.BorderWidthLeft = 0f;
					headerSaltoLinea.BorderWidthRight = 0f;
					headerSaltoLinea.BorderWidthTop = 0f;
					headerSaltoLinea.PaddingTop = 0f;	
					headerSaltoLinea.PaddingBottom = 0f;	
				TablaI.AddCell(headerSaltoLinea);
								
					PdfPCell hearderDocumentacionDP = new PdfPCell(PDFs.Enclgray215209NormalBorde("Documentacion                                                       Licencias de Manejo"));
					hearderDocumentacionDP.HorizontalAlignment = 0;	
					hearderDocumentacionDP.Colspan = 11;
				TablaI.AddCell(hearderDocumentacionDP);				
				
					PdfPCell hearderExpDP = new PdfPCell(PDFs.Enclgray215209NormalBorde("                                      Experiencia"));
					hearderExpDP.HorizontalAlignment = 0;	
					hearderExpDP.Colspan = 6;
				TablaI.AddCell(hearderExpDP);
				
					PdfPCell headerLicEstatalDPC = new PdfPCell(PDFs.TitWhite11430802("Estatal:"));
					headerLicEstatalDPC.Colspan = 2;
					headerLicEstatalDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerLicEstatalDPC);
								
				if(tipoLicE.Length > 0 && tipoLicE != "-" && tipoLicE != "TODAS"){
					if(parametros.licEstatal != "TODAS"){
						if(tipoLicE != parametros.licEstatal){
								PdfPCell headerLicEstatalDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+tipoLicE));
								headerLicEstatalDP.Colspan = 2;
								headerLicEstatalDP.HorizontalAlignment = 1;	
							TablaI.AddCell(headerLicEstatalDP);	
						}else{
								PdfPCell headerLicEstatalDP = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicE));
								headerLicEstatalDP.Colspan = 2;
								headerLicEstatalDP.HorizontalAlignment = 1;	
							TablaI.AddCell(headerLicEstatalDP);	
						}
					}else{
							PdfPCell headerLicEstatalDP = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicE));
							headerLicEstatalDP.Colspan = 2;
							headerLicEstatalDP.HorizontalAlignment = 1;	
						TablaI.AddCell(headerLicEstatalDP);	
					}
				}else{
						PdfPCell headerLicEstatalDP = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicE));
						headerLicEstatalDP.Colspan = 2;
						headerLicEstatalDP.HorizontalAlignment = 1;	
					TablaI.AddCell(headerLicEstatalDP);	
				}					
				
					PdfPCell headerLicEstatalEstadoDP = new PdfPCell(PDFs.TitWhite11430802(" "+estatoLicE));
					headerLicEstatalEstadoDP.HorizontalAlignment = 1;	
				TablaI.AddCell(headerLicEstatalEstadoDP);	
								
					PdfPCell headerLicEstatalVigDP = new PdfPCell(PDFs.TitWhite11430802("Vigencia:"));
					headerLicEstatalVigDP.Colspan = 2;
					headerLicEstatalVigDP.HorizontalAlignment = 2;	
				TablaI.AddCell(headerLicEstatalVigDP);	
					
				if(venceLicE != "" && venceLicE != "N/A"){
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigEstatal)) >= Convert.ToDateTime(venceLicE) ){
							PdfPCell headerLicEstatalVigDPC = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+venceLicE));
							headerLicEstatalVigDPC.Colspan = 2;
							headerLicEstatalVigDPC.HorizontalAlignment = 1;	
						TablaI.AddCell(headerLicEstatalVigDPC);	
					}else{
							PdfPCell headerLicEstatalVigDPC = new PdfPCell(PDFs.TitWhite11430802(" "+venceLicE));
							headerLicEstatalVigDPC.Colspan = 2;
							headerLicEstatalVigDPC.HorizontalAlignment = 1;	
						TablaI.AddCell(headerLicEstatalVigDPC);			
					}				
				}else{
						PdfPCell headerLicEstatalVigDPC = new PdfPCell(PDFs.TitWhite11430802(" "+venceLicE));
						headerLicEstatalVigDPC.Colspan = 2;
						headerLicEstatalVigDPC.HorizontalAlignment = 1;	
					TablaI.AddCell(headerLicEstatalVigDPC);	
				}	
				
					PdfPCell headerLicEstatalsignoDPC = new PdfPCell(PDFs.TitWhite11430802("$"));
					headerLicEstatalsignoDPC.HorizontalAlignment = 1;
					headerLicEstatalsignoDPC.PaddingTop = 3f;	
					headerLicEstatalsignoDPC.PaddingBottom = 3f;	
					headerLicEstatalsignoDPC.BorderWidthRight = 0f;
					headerLicEstatalsignoDPC.BorderWidthBottom = 0f;
				TablaI.AddCell(headerLicEstatalsignoDPC);	
				
				if(AJUSTE_LIC){
					PdfPCell headerLicEstatalDecDPC = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+licAjuste.estatal+" "+ ((licAjuste.estatal_vence != "Vencida" && licAjuste.estatal_vence != "Tipo Lic" && licAjuste.estatal_vence != "" )? licAjuste.estatal_vence+" Cat" : ((licAjuste.estatal_vence == "Vencida" )? "Venc" : ((licAjuste.estatal_vence == "Tipo Lic" )? "Lic " : "N/A") ) ) ));
					headerLicEstatalDecDPC.Colspan = 2;
					headerLicEstatalDecDPC.HorizontalAlignment = 1;	
					headerLicEstatalDecDPC.BorderWidthLeft = 0f;
					headerLicEstatalDecDPC.BorderWidthTop = 0f;
					headerLicEstatalDecDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerLicEstatalDecDPC);	
				}else{
					PdfPCell headerLicEstatalDecDPC = new PdfPCell(PDFs.TitWhite11430802("N/A"));
					headerLicEstatalDecDPC.Colspan = 2;
					headerLicEstatalDecDPC.HorizontalAlignment = 1;	
					headerLicEstatalDecDPC.BorderWidthLeft = 0f;
					headerLicEstatalDecDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerLicEstatalDecDPC);	
				}					
				
					PdfPCell headerExpDualDPC = new PdfPCell(PDFs.TitWhite11430802("Dual: "));
					headerExpDualDPC.Colspan = 2;
					headerExpDualDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerExpDualDPC);
				
				if(dualA.Length > 0){
					if(Convert.ToInt16(dualA) < Convert.ToInt16(parametros.expDual)){
							PdfPCell headerExpDualDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+dualA+" Años "+dualM+" Meses"));
							headerExpDualDP.Colspan = 3;
							headerExpDualDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerExpDualDP);	
					}else{
							PdfPCell headerExpDualDP = new PdfPCell(PDFs.TitWhite11430802(" "+dualA+" Años "+dualM+" Meses"));
							headerExpDualDP.Colspan = 3;
							headerExpDualDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerExpDualDP);	
					}
				}else{
						PdfPCell headerExpDualDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+dualA+" Años "+dualM+" Meses"));
						headerExpDualDP.Colspan = 3;
						headerExpDualDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerExpDualDP);	
				}								
				
					PdfPCell headerLicFederalDPC = new PdfPCell(PDFs.TitWhite11430802("Federal:"));
					headerLicFederalDPC.Colspan = 2;
					headerLicFederalDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerLicFederalDPC);
				
				if(tipoLicF.Length > 0 && tipoLicF != "-" && tipoLicE != "TODAS"){
					if(parametros.licFederal != "TODAS"){
						if(tipoLicF != parametros.licFederal){
								PdfPCell headerLicFederalDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+tipoLicF));
								headerLicFederalDP.Colspan = 2;
								headerLicFederalDP.HorizontalAlignment = 1;	
							TablaI.AddCell(headerLicFederalDP);	
						}else{
								PdfPCell headerLicFederalDP = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicF));
								headerLicFederalDP.Colspan = 2;
								headerLicFederalDP.HorizontalAlignment = 1;	
							TablaI.AddCell(headerLicFederalDP);	
						}
					}else{
							PdfPCell headerLicFederalDP = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicF));
							headerLicFederalDP.Colspan = 2;
							headerLicFederalDP.HorizontalAlignment = 1;	
						TablaI.AddCell(headerLicFederalDP);	
					}
				}else{
						PdfPCell headerLicFederalDP = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicF));
						headerLicFederalDP.Colspan = 2;
						headerLicFederalDP.HorizontalAlignment = 1;	
					TablaI.AddCell(headerLicFederalDP);		
				}						
				
					PdfPCell headerLicFederalEstadoDP = new PdfPCell(PDFs.TitWhite11430802(" "+estadoLicF));
					headerLicFederalEstadoDP.HorizontalAlignment = 1;
				TablaI.AddCell(headerLicFederalEstadoDP);
				
				TablaI.AddCell(headerLicEstatalVigDP);
								
				if(venceLicF != "" && venceLicF != "N/A"){
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigFederal)) >= Convert.ToDateTime(venceLicF)  ){
							PdfPCell headerLicFederalVigDPC = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+venceLicF));
							headerLicFederalVigDPC.Colspan = 2;
							headerLicFederalVigDPC.HorizontalAlignment = 1;
						TablaI.AddCell(headerLicFederalVigDPC);
					}else{
							PdfPCell headerLicFederalVigDPC = new PdfPCell(PDFs.TitWhite11430802(" "+venceLicF));
							headerLicFederalVigDPC.Colspan = 2;
							headerLicFederalVigDPC.HorizontalAlignment = 1;
						TablaI.AddCell(headerLicFederalVigDPC);
					}
				}else{
						PdfPCell headerLicFederalVigDPC = new PdfPCell(PDFs.TitWhite11430802(" "+venceLicF));
						headerLicFederalVigDPC.Colspan = 2;
						headerLicFederalVigDPC.HorizontalAlignment = 1;
					TablaI.AddCell(headerLicFederalVigDPC);
				}
				
				TablaI.AddCell(headerLicEstatalsignoDPC);
				
				if(AJUSTE_LIC){
					PdfPCell headerLicFederalDecDPC = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+licAjuste.federal+" "+ ((licAjuste.federal_vence != "Vencida" && licAjuste.federal_vence != "Tipo Lic" && licAjuste.federal_vence != "" )? licAjuste.federal_vence+" Cat" : ((licAjuste.federal_vence == "Vencida" )? "Venc" : ((licAjuste.federal_vence == "Tipo Lic" )? "Lic " : "N/A") ) )));
					headerLicFederalDecDPC.Colspan = 2;
					headerLicFederalDecDPC.HorizontalAlignment = 1;
					headerLicFederalDecDPC.BorderWidthLeft = 0f;
					headerLicFederalDecDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerLicFederalDecDPC);
				}else{
					PdfPCell headerLicFederalDecDPC = new PdfPCell(PDFs.TitWhite11430802("N/A"));
					headerLicFederalDecDPC.Colspan = 2;
					headerLicFederalDecDPC.HorizontalAlignment = 1;
					headerLicFederalDecDPC.BorderWidthLeft = 0f;
					headerLicFederalDecDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerLicFederalDecDPC);
				}
				
					PdfPCell headerExpDirDPC = new PdfPCell(PDFs.TitWhite11430802("Dir Tras:"));
					headerExpDirDPC.Colspan = 2;
					headerExpDirDPC.HorizontalAlignment = 2;
				TablaI.AddCell(headerExpDirDPC);
				
				if(dirTraseraA.Length > 0){
					if(Convert.ToInt16(dirTraseraA) < Convert.ToInt16(parametros.expDirTrasera)){
							PdfPCell headerExpDirDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+dirTraseraA+" Años "+dirTraseraM+" Meses"));
							headerExpDirDP.Colspan = 3;
							headerExpDirDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerExpDirDP);
					}else{
							PdfPCell headerExpDirDP = new PdfPCell(PDFs.TitWhite11430802(" "+dirTraseraA+" Años "+dirTraseraM+" Meses"));
							headerExpDirDP.Colspan = 3;
							headerExpDirDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerExpDirDP);
					}
				}else{
						PdfPCell headerExpDirDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+dirTraseraA+" Años "+dirTraseraM+" Meses"));
						headerExpDirDP.Colspan = 3;
						headerExpDirDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerExpDirDP);
				}
					
					PdfPCell headerObservacionesDPC = new PdfPCell(PDFs.Enclgray215209NormalBorde("Observaciones:"));
					headerObservacionesDPC.Colspan = 5;
					headerObservacionesDPC.HorizontalAlignment = 0;
				TablaI.AddCell(headerObservacionesDPC);
				
					PdfPCell headerMedicoDPC = new PdfPCell(PDFs.TitWhite11430802("Medico:"));
					headerMedicoDPC.Colspan = 2;
					headerMedicoDPC.HorizontalAlignment = 2;
				TablaI.AddCell(headerMedicoDPC);
				
				
				if(venceApto != "" && venceApto != "N/A"){
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigAptoMedico)) >= Convert.ToDateTime(venceApto)  ){
							PdfPCell headerMedicoDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+venceApto));
							headerMedicoDP.Colspan = 2;
							headerMedicoDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerMedicoDP);
					}else{
							PdfPCell headerMedicoDP = new PdfPCell(PDFs.TitWhite11430802(" "+venceApto));
							headerMedicoDP.Colspan = 2;
							headerMedicoDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerMedicoDP);
					}				
				}else{
						PdfPCell headerMedicoDP = new PdfPCell(PDFs.TitWhite11430802(" "+venceApto));
						headerMedicoDP.Colspan = 2;
						headerMedicoDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerMedicoDP);
				}
				
				TablaI.AddCell(headerLicEstatalsignoDPC);
						
				if(AJUSTE_LIC){
					PdfPCell headerMedicoDecDPC = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+licAjuste.medico+" "+ ((licAjuste.medico_vence != "Vencida")?  ((licAjuste.medico_vence == "" )? "N/A" : licAjuste.medico_vence+" Cat")  : "Venc") ));
					headerMedicoDecDPC.Colspan = 2;
					headerMedicoDecDPC.HorizontalAlignment = 1;
					headerMedicoDecDPC.BorderWidthLeft = 0f;
					headerMedicoDecDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerMedicoDecDPC);
				}else{
					PdfPCell headerMedicoDecDPC = new PdfPCell(PDFs.TitWhite11430802("N/A"));
					headerMedicoDecDPC.Colspan = 2;
					headerMedicoDecDPC.HorizontalAlignment = 1;
					headerMedicoDecDPC.BorderWidthLeft = 0f;
					headerMedicoDecDPC.BorderWidthBottom = 0f;
					TablaI.AddCell(headerMedicoDecDPC);
				}	
				
					PdfPCell headerExpPersonalDPC = new PdfPCell(PDFs.TitWhite11430802("Personal:"));
					headerExpPersonalDPC.Colspan = 2;
					headerExpPersonalDPC.HorizontalAlignment = 2;
				TablaI.AddCell(headerExpPersonalDPC);
				
				if(personalA.Length > 0){
					if(Convert.ToInt16(personalA) < Convert.ToInt16(parametros.expTransPersonal)){
							PdfPCell headerExpPersonalDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+personalA+" Años "+personalM+" Meses"));
							headerExpPersonalDP.Colspan = 3;
							headerExpPersonalDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerExpPersonalDP);
					}else{
							PdfPCell headerExpPersonalDP = new PdfPCell(PDFs.TitWhite11430802(" "+personalA+" Años "+personalM+" Meses"));
							headerExpPersonalDP.Colspan = 3;
							headerExpPersonalDP.HorizontalAlignment = 1;
						TablaI.AddCell(headerExpPersonalDP);
					}
				}else{
						PdfPCell headerExpPersonalDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+personalA+" Años "+personalM+" Meses"));
						headerExpPersonalDP.Colspan = 3;
						headerExpPersonalDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerExpPersonalDP);
				}					

					PdfPCell headerObservacionesDP = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerObservacionesDP.Colspan = 17;
					headerObservacionesDP.HorizontalAlignment = 1;
					headerObservacionesDP.PaddingTop = 3f;
					headerObservacionesDP.PaddingBottom= 3f;
				TablaI.AddCell(headerObservacionesDP);
				
				TablaI.AddCell(headerSaltoLinea);
								
					PdfPCell headerTramiteDPC = new PdfPCell(PDFs.Enclgray215209NormalBorde("Tipo de Tramite:"));
					headerTramiteDPC.Colspan = 9;
					headerTramiteDPC.PaddingTop = 3f;
					headerTramiteDPC.PaddingBottom = 3f;
					headerTramiteDPC.HorizontalAlignment = 1;
				TablaI.AddCell(headerTramiteDPC);
								
					PdfPCell headerBlancoTramite = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerBlancoTramite.BorderWidthBottom = 0f;
					headerBlancoTramite.BorderWidthTop = 0f;
					headerBlancoTramite.BorderWidthRight = 0f;
				TablaI.AddCell(headerBlancoTramite);
				
					PdfPCell headerFuenteDPC = new PdfPCell(PDFs.TitWhite11430802("Fuente:"));
					headerFuenteDPC.Colspan = 2;
					headerFuenteDPC.HorizontalAlignment = 2;
				TablaI.AddCell(headerFuenteDPC);
				
				if(fuente == "RECOMENDACION"){
						PdfPCell headerFuenteDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+fuente));
						headerFuenteDP.Colspan = 5;
						headerFuenteDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerFuenteDP);
				}else{
						PdfPCell headerFuenteDP = new PdfPCell(PDFs.TitWhite11430802(" "+fuente));
						headerFuenteDP.Colspan = 5;
						headerFuenteDP.HorizontalAlignment = 1;
					TablaI.AddCell(headerFuenteDP);
				}					
								
					PdfPCell headerTramiteDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+tramite));
					headerTramiteDP.Colspan = 9;
					headerTramiteDP.HorizontalAlignment = 1;
					headerTramiteDP.PaddingTop = 3f;
					headerTramiteDP.PaddingBottom = 3f;
				TablaI.AddCell(headerTramiteDP);
				TablaI.AddCell(headerBlancoTramite);				
				
					PdfPCell headerDetalleFuenteDPC = new PdfPCell(PDFs.TitWhite11430802("Detalle:"));
					headerDetalleFuenteDPC.Colspan = 2;
					headerDetalleFuenteDPC.HorizontalAlignment = 2;	
				TablaI.AddCell(headerDetalleFuenteDPC);
								
				if(fuente == "RECOMENDACION"){
						PdfPCell headerDetalleFuenteDP = new PdfPCell(PDFs.TitWhite11430802BOLD(" "+detalleFuente+"      "+((fuente == "PERIODICO")? diaFuente : "")  ));
						headerDetalleFuenteDP.Colspan = 5;
						headerDetalleFuenteDP.HorizontalAlignment = 1;	
					TablaI.AddCell(headerDetalleFuenteDP);
				}else{
						PdfPCell headerDetalleFuenteDP = new PdfPCell(PDFs.TitWhite11430802(" "+detalleFuente+"      "+((fuente == "PERIODICO")? diaFuente : "")  ));
						headerDetalleFuenteDP.Colspan = 5;
						headerDetalleFuenteDP.HorizontalAlignment = 1;	
					TablaI.AddCell(headerDetalleFuenteDP);
				}	
				
				PdfPCell headerFoto = new PdfPCell(PDFs.Enclgray215209Normal(" "+tipoOperador));
				
				PdfPTable Foto = new PdfPTable(1);
				Foto.AddCell(headerFoto);
				Foto.AddCell(PDFs.FotoEmpleoAutorizacion(foto2));

				TablaD.AddCell(TablaI);	
				TablaD.AddCell(Foto);					
				//TablaD.AddCell(PDFs.FotoEmpleo(foto2));					
								
				document.Add(TablaD);
				document.Add(espacio);
				
				float[] widthsFirma = new float[]{235f, 235f};	
				PdfPTable TablaF = new PdfPTable(2);
				TablaF.SetWidths(widthsFirma);
				TablaF.WidthPercentage = 100;
				TablaF.HorizontalAlignment = 1;
				TablaF.TotalWidth = 470f;				
				
					PdfPCell headerOperacionesF = new PdfPCell(PDFs.Enclgray215209NormalBorde("Firma Departamento de Operaciones"));
					headerOperacionesF.HorizontalAlignment = 0;
				TablaF.AddCell(headerOperacionesF);		
					PdfPCell headerGerencialF = new PdfPCell(PDFs.Enclgray215209NormalBorde("Firma Director General"));
					headerGerencialF.HorizontalAlignment = 0;
				TablaF.AddCell(headerGerencialF);	

					PdfPCell headerEstapicoF = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEstapicoF.HorizontalAlignment = 0;
					headerEstapicoF.BorderWidthTop = 0f;
					headerEstapicoF.BorderWidthBottom = 0f;
				TablaF.AddCell(headerEstapicoF);
				
					PdfPCell headerEstapico2F = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEstapico2F.HorizontalAlignment = 0;
					headerEstapico2F.BorderWidthTop = 0f;
					headerEstapico2F.BorderWidthBottom = 0f;
					headerEstapico2F.BorderWidthLeft = 0f;
				TablaF.AddCell(headerEstapico2F);
				
				TablaF.AddCell(headerEstapicoF);
				TablaF.AddCell(headerEstapico2F);
				TablaF.AddCell(headerEstapicoF);
				TablaF.AddCell(headerEstapico2F);
				TablaF.AddCell(headerEstapicoF);
				TablaF.AddCell(headerEstapico2F);
				
					PdfPCell headerEstapico3F = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEstapico3F.HorizontalAlignment = 0;
					headerEstapico3F.BorderWidthTop = 0f;;
				TablaF.AddCell(headerEstapico3F);
				
					PdfPCell headerEstapico4F = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerEstapico4F.HorizontalAlignment = 0;
					headerEstapico4F.BorderWidthTop = 0f;
					headerEstapico4F.BorderWidthLeft = 0f;
				TablaF.AddCell(headerEstapico4F);
				
				document.Add(TablaF);
				document.Add(espacio);
				document.Add(new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));
				document.Add(espacio);
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////
				/*  									SOLICITUD DE EXAMEN DE MANEJO								*/
				//////////////////////////////////////////////////////////////////////////////////////////////////////
				
				document.Add(PDFs.LogoSolicitudManejo(writer));				
				
				float[] widthsDatosExamen = new float[]{369.28f, 100.72f};	 		
				PdfPTable TablaE = new PdfPTable(2);
				TablaE.SetWidths(widthsDatosExamen);
				TablaE.WidthPercentage = 100;
				TablaE.HorizontalAlignment = 1;
				TablaE.TotalWidth = 470f;
								
				float[] widthsInfoExamen = new float[]{27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.64f, 27.76f};
				PdfPTable TablaIExamen = new PdfPTable(17);
				TablaIExamen.SetWidths(widthsInfoExamen);
				TablaIExamen.WidthPercentage = 100;
				TablaIExamen.HorizontalAlignment = 0; 
				TablaIExamen.TotalWidth = 470f;				
										
					PdfPCell headerLogoSolicitud = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerLogoSolicitud.Colspan = 7;					
					headerLogoSolicitud.BorderWidthBottom = 0f;
					headerLogoSolicitud.BorderWidthLeft = 0f;
					headerLogoSolicitud.BorderWidthRight = 0f;
					headerLogoSolicitud.BorderWidthTop = 0f;
					headerLogoSolicitud.PaddingTop = 0f;	
					headerLogoSolicitud.PaddingBottom = 0f;	
				TablaIExamen.AddCell(headerLogoSolicitud);				
					PdfPCell headerTituloExamen = new PdfPCell(PDFs.Enclgray215206SinBorde("SOLICITUD DE EXAMEN DE MANEJO"));
					headerTituloExamen.Colspan = 10;
					headerTituloExamen.PaddingTop = 4f;	
					headerTituloExamen.PaddingBottom = 4f;	
					headerTituloExamen.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerTituloExamen);
				
				TablaIExamen.AddCell(headerLogoSolicitud);	
					PdfPCell headerTituloExamen2 = new PdfPCell(PDFs.TitWhite11430802("Autorización:"));
					headerTituloExamen2.Colspan = 3;
					headerTituloExamen2.PaddingTop = 2f;	
					headerTituloExamen2.PaddingBottom = 2f;	
					headerTituloExamen2.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerTituloExamen2);				
					PdfPCell headerTituloExamen3 = new PdfPCell(PDFs.TitWhite11430802(" "+DateTime.Now.ToShortDateString().ToUpper()+" "+DateTime.Now.ToString("HH:mm")+" hrs"));
					headerTituloExamen3.Colspan = 7;
					headerTituloExamen3.PaddingTop = 2f;	
					headerTituloExamen3.PaddingBottom = 2f;	
					headerTituloExamen3.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerTituloExamen3);
								
				TablaIExamen.AddCell(headerLogoSolicitud);
					PdfPCell headerTituloExamen4 = new PdfPCell(PDFs.TitWhite11430802(" "+tramite));
					headerTituloExamen4.Colspan = 5;
					headerTituloExamen4.PaddingTop = 2f;	
					headerTituloExamen4.PaddingBottom = 2f;	
					headerTituloExamen4.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerTituloExamen4);
					PdfPCell headerTituloExamen5 = new PdfPCell(PDFs.TitWhite11430802("Folio:"));
					headerTituloExamen5.Colspan = 2;
					headerTituloExamen5.PaddingTop = 2f;	
					headerTituloExamen5.PaddingBottom = 2f;	
					headerTituloExamen5.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerTituloExamen5);
					PdfPCell headerTituloExamen6 = new PdfPCell(PDFs.TitWhite11430802(" "+folio));
					headerTituloExamen6.Colspan = 3;
					headerTituloExamen6.PaddingTop = 3f;	
					headerTituloExamen6.PaddingBottom = 3f;	
					headerTituloExamen6.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerTituloExamen6);
					
					PdfPCell headerSaltoLineaExamen = new PdfPCell(PDFs.TitWhite11430802(" "));
					headerSaltoLineaExamen.Colspan = 17;					
					headerSaltoLineaExamen.BorderWidthBottom = 0f;
					headerSaltoLineaExamen.BorderWidthLeft = 0f;
					headerSaltoLineaExamen.BorderWidthRight = 0f;
					headerSaltoLineaExamen.BorderWidthTop = 0f;
					headerSaltoLineaExamen.PaddingTop = 0f;	
					headerSaltoLineaExamen.PaddingBottom = 0f;	
				TablaIExamen.AddCell(headerSaltoLineaExamen);
				
					PdfPCell headerNombreE = new PdfPCell(PDFs.TitWhite11430802("Nombre:"));
					headerNombreE.Colspan = 2;
					headerNombreE.PaddingTop = 3f;	
					headerNombreE.PaddingBottom= 3f;	
					headerNombreE.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerNombreE);				
				
					PdfPCell headerNombreEC = new PdfPCell(PDFs.TitWhite11430802(" "+nombre+" "+apPat+" "+apMat));
					headerNombreEC.Colspan = 8;
					headerNombreEC.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerNombreEC);
				
					PdfPCell headerCeluarEC = new PdfPCell(PDFs.TitWhite11430802("Celular:"));
					headerCeluarEC.Colspan = 2;
					headerCeluarEC.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerCeluarEC);
				
					PdfPCell headerCeluarEP = new PdfPCell(PDFs.TitWhite11430802(" "+numeroTelefonico));
					headerCeluarEP.Colspan = 5;
					headerCeluarEP.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerCeluarEP);
				
					PdfPCell headerColoniaEC = new PdfPCell(PDFs.TitWhite11430802("Colonia:"));
					headerColoniaEC.Colspan = 2;
					headerColoniaEC.PaddingTop = 3f;	
					headerColoniaEC.PaddingBottom = 3f;
					headerColoniaEC.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerColoniaEC);
				
					PdfPCell headerColoniaEP = new PdfPCell(PDFs.TitWhite11430802(" "+colonia));
					headerColoniaEP.Colspan = 6;
					headerColoniaEP.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerColoniaEP);	
							
					PdfPCell headerZonacEC = new PdfPCell(PDFs.TitWhite11430802("Zona:"));
					headerZonacEC.Colspan = 2;
					headerZonacEC.PaddingTop = 3f;	
					headerZonacEC.PaddingBottom= 3f;
					headerZonacEC.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerZonacEC);
				
					PdfPCell headerZonacE = new PdfPCell(PDFs.TitWhite11430802(" "+zona));
					headerZonacE.Colspan = 7;
					headerZonacE.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerZonacE);				

				TablaIExamen.AddCell(headerSaltoLineaExamen);

					PdfPCell hearderDocumentacionE = new PdfPCell(PDFs.Enclgray215209NormalBorde("Licencias de Manejo:"));
					hearderDocumentacionE.HorizontalAlignment = 0;	
					hearderDocumentacionE.Colspan = 4;
				TablaIExamen.AddCell(hearderDocumentacionE);				
				
					PdfPCell headerLicEstatalEC = new PdfPCell(PDFs.TitWhite11430802("Estatal:"));
					headerLicEstatalEC.Colspan = 2;
					headerLicEstatalEC.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerLicEstatalEC);
				
					PdfPCell headerLicEstatalE = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicE));
					headerLicEstatalE.Colspan = 4;
					headerLicEstatalE.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerLicEstatalE);					
				
					PdfPCell headerLicEstatalVigE = new PdfPCell(PDFs.TitWhite11430802("Vigencia:"));
					headerLicEstatalVigE.Colspan = 3;
					headerLicEstatalVigE.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerLicEstatalVigE);	
				
					PdfPCell headerLicEstatalVigEC = new PdfPCell(PDFs.TitWhite11430802(" "+venceLicE));
					headerLicEstatalVigEC.Colspan = 4;
					headerLicEstatalVigEC.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerLicEstatalVigEC);	
				
					PdfPCell headerLicFederalEC = new PdfPCell(PDFs.TitWhite11430802("Federal:"));
					headerLicFederalEC.Colspan = 2;
					headerLicFederalEC.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerLicFederalEC);
				
					PdfPCell headerLicFederalE = new PdfPCell(PDFs.TitWhite11430802(" "+tipoLicF));
					headerLicFederalE.Colspan = 2;
					headerLicFederalE.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerLicFederalE);
				
					PdfPCell headerLicFederalVigE = new PdfPCell(PDFs.TitWhite11430802("Vigencia:"));
					headerLicFederalVigE.Colspan = 2;
					headerLicFederalVigE.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerLicFederalVigE);					
				
					PdfPCell headerLicFederalVigEC = new PdfPCell(PDFs.TitWhite11430802(" "+venceLicF));
					headerLicFederalVigEC.Colspan = 4;
					headerLicFederalVigEC.HorizontalAlignment = 1;	
				TablaIExamen.AddCell(headerLicFederalVigEC);	
				
					PdfPCell headerMedicoEC = new PdfPCell(PDFs.TitWhite11430802("Apto Medico:"));
					headerMedicoEC.Colspan = 3;
					headerMedicoEC.HorizontalAlignment = 2;	
				TablaIExamen.AddCell(headerMedicoEC);	
				
					PdfPCell headerMedicoE = new PdfPCell(PDFs.TitWhite11430802(" "+venceApto));
					headerMedicoE.Colspan = 4;
					headerMedicoE.HorizontalAlignment = 1;
				TablaIExamen.AddCell(headerMedicoE);
				
				TablaIExamen.AddCell(headerSaltoLineaExamen);				
								
					PdfPCell hearderExpE = new PdfPCell(PDFs.Enclgray215209NormalBorde("Experiencia"));
					hearderExpE.HorizontalAlignment = 0;	
					hearderExpE.Colspan = 2;
				TablaIExamen.AddCell(hearderExpE);				
				
					PdfPCell headerExpDualE = new PdfPCell(PDFs.TitWhite11430802("Dual: "+dualA+" Años "+dualM+" Meses"));
					headerExpDualE.Colspan = 5;
					headerExpDualE.HorizontalAlignment = 1;
				TablaIExamen.AddCell(headerExpDualE);	
				
					PdfPCell headerExpDirE = new PdfPCell(PDFs.TitWhite11430802("Dir Tras: "+dirTraseraA+" Años "+dirTraseraM+" Meses"));
					headerExpDirE.Colspan = 5;
					headerExpDirE.HorizontalAlignment = 1;
				TablaIExamen.AddCell(headerExpDirE);

					PdfPCell headerExpPersonalE = new PdfPCell(PDFs.TitWhite11430802("Personal: "+personalA+" Años "+personalM+" Meses"));
					headerExpPersonalE.Colspan = 5;
					headerExpPersonalE.HorizontalAlignment = 1;
				TablaIExamen.AddCell(headerExpPersonalE);
						
				TablaE.AddCell(TablaIExamen);	
				TablaE.AddCell(PDFs.FotoEmpleo(foto2));
				document.Add(TablaE);
				document.Add(espacio);
				
				iTextSharp.text.Image fotoTaller = iTextSharp.text.Image.GetInstance(@"../debug/MapaTaller.jpg");;				
							fotoTaller.ScaleAbsolute(120f, 155.25f);
				float[] widthsImagenTaller = new float[]{470f};
				PdfPTable TablaImagenTaller = new PdfPTable(1);
				TablaImagenTaller.SetWidths(widthsImagenTaller);
				TablaImagenTaller.WidthPercentage = 100;
				TablaImagenTaller.HorizontalAlignment = 0; 
				TablaImagenTaller.TotalWidth = 470f;	
										
				TablaImagenTaller.AddCell(fotoTaller);		
				document.Add(TablaImagenTaller);
				document.Add(espacio);
				
				float[] widthsContacto = new float[]{94f, 94f, 94f, 188f};	 		
				PdfPTable TablaContacto = new PdfPTable(4);
				TablaContacto.SetWidths(widthsContacto);
				TablaContacto.WidthPercentage = 100;
				TablaContacto.TotalWidth = 470f;
					PdfPCell headerTaller = new PdfPCell(PDFs.Enclgray215209NormalBorde("Contacto Taller:"));
					headerTaller.PaddingTop = 4f;	
					headerTaller.PaddingBottom = 4f;	
					headerTaller.HorizontalAlignment = 2;	
				TablaContacto.AddCell(headerTaller);
					PdfPCell headerTallerNom = new PdfPCell(PDFs.TitWhite11430802(" "+parametros.contactoTaller));
					headerTallerNom.HorizontalAlignment = 0;	
				TablaContacto.AddCell(headerTallerNom);
					PdfPCell headerTallerTel = new PdfPCell(PDFs.TitWhite11430802(" "+parametros.numeroTaller));
					headerTallerTel.HorizontalAlignment = 1;	
				TablaContacto.AddCell(headerTallerTel);	
					PdfPCell headerCita1 = new PdfPCell(PDFs.TitWhite11430802("Cita Taller:"));
					headerCita1.HorizontalAlignment = 0;
					headerCita1.BorderWidthBottom = 0f;
				TablaContacto.AddCell(headerCita1);	
				
					PdfPCell headerOficina = new PdfPCell(PDFs.Enclgray215209NormalBorde("Contacto Taller:"));
					headerOficina.PaddingTop = 4f;	
					headerOficina.PaddingBottom = 4f;	
					headerOficina.HorizontalAlignment = 2;	
				TablaContacto.AddCell(headerOficina);
					PdfPCell headerOficinaNom = new PdfPCell(PDFs.TitWhite11430802(" "+parametros.contactoOficina));
					headerOficinaNom.HorizontalAlignment = 0;	
				TablaContacto.AddCell(headerOficinaNom);
					PdfPCell headerOficinaTel = new PdfPCell(PDFs.TitWhite11430802(" "+parametros.numeroOficina));
					headerOficinaTel.HorizontalAlignment = 1;	
				TablaContacto.AddCell(headerOficinaTel);	
					PdfPCell headerCita2 = new PdfPCell(PDFs.TitWhite11430802(""));
					headerCita2.HorizontalAlignment = 0;
					headerCita2.BorderWidthTop = 0f;
				TablaContacto.AddCell(headerCita2);					
				
				document.Add(TablaContacto);
			}
			#endregion
			
		#endregion
	}
}
