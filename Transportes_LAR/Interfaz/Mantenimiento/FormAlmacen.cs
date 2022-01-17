using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
 
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Mantenimiento
{
	public partial class FormAlmacen : Form
	{
		#region VARIABLES
		Int32 id_usuario = 0;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region CONSTRUCTORES
		public FormAlmacen(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO - TERMINO
		void FormAlmacenLoad(object sender, EventArgs e)
		{			
			id_usuario = principal.idUsuario;
		}
		
		void FormAlmacenFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.almacen = false;
		}
		#endregion		
		
		#region MENU
		private void getCambiarOpcion(int opcion)
		{
			if(opcion==0)
			{
				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormEntrada Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormEntrada(id_usuario.ToString());
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
			}
			else if(opcion==1)
			{
				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormSalida Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormSalida(id_usuario.ToString());
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
			}
			if(opcion==2)
			{
				
            	Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormExistencia Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormExistencia();
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
				
			}
			else if(opcion==3)
			{
				/*
				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormMovimientos Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormMovimientos();
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
				*/
			}
			else if(opcion==4)
			{
				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormOrdenCompra Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormOrdenCompra(id_usuario.ToString(), principal);
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
				//PDF();
			}
			else if(opcion==5)
			{
            	Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormProducto Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormProducto();
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
			}
			else if(opcion==6)
			{
				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormProveedores Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormProveedores();
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
			}
			else if(opcion==7)
			{
				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormAgrupación Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormAgrupación();
				Entrada.TopLevel = false;
				this.pPrincipal.Tag = Entrada;
				this.pPrincipal.Controls.Add(Entrada);
				Entrada.Show();
			}
			else if(opcion==8)
			{
//				Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormIntervencion Entrada = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.FormIntervencion();
//				Entrada.TopLevel = false;
//				this.pPrincipal.Tag = Entrada;
//				this.pPrincipal.Controls.Add(Entrada);
//				Entrada.Show();
			}
		}
		
		//--EVENTO_CAMBIO_DE_OPCION
		void LtMenuItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			getCambiarOpcion(Convert.ToInt16(e.ItemIndex.ToString()));
		}
		#endregion	
	}
}
