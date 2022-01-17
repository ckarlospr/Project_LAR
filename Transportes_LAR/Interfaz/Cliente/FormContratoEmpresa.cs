using System.Linq.Expressions;
using System.ComponentModel;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Threading;
using iTextSharp.text;
using System.Drawing;
using System.IO;
using System;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormContratoEmpresa : Form
	{
		#region VARIABLES
		String NomEmpresa = "";
		#endregion
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		#endregion
		
		#region CONSTRUCTOR
		public FormContratoEmpresa(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormValidaFacturaLoad(object sender, EventArgs e)
		{
			int contador = 0;
			String sentencia = "";
			sentencia = "Select Distinct(Empresa) As NombreEmpresa " +
			 			"from Cliente " +
			            "where Empresa!='Especiales'";
			
			dtEmpresa.Rows.Clear();
			dtEmpresa.ClearSelection();
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtEmpresa.Rows.Add();
				dtEmpresa.Rows[contador].Cells[0].Value = conn.leer["NombreEmpresa"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		
		void FormValidaFacturaFormClosing(object sender, FormClosingEventArgs e)
		{
			//principal.validarfact = false;
		}
		#endregion
		
		#region EVENTO CONTRATO
		void DtEmpresaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && dtEmpresa.RowCount>1)
			{
				NomEmpresa =  dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
				PDF();
			}
		}
		
		void PDF()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Contratos de Empresas "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{	
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Empresas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+NomEmpresa +".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoContratoVentas(doc, writer, NomEmpresa, "", "", "RUTA DE TRANSPORTE DE PERSONAL VARIABLE", DateTime.Now.ToString().Substring(0,10), 
				                                 "03:00 hrs", "22:00 hrs", 
				                                 "0", "40", "", "", "0", "0", "0", DateTime.Now.AddDays(30).ToString().Substring(0,10));
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Empresas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+NomEmpresa +".pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		
	}
}
