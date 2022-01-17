using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormOrdenEmpresas : Form
	{
		public FormOrdenEmpresas(Interfaz.Operaciones.FormPrin_Empresas refPrin, String Turn)
		{
			InitializeComponent();
			refPrincipal=refPrin;
			Turno=Turn;
		}
		
		#region	VARIABLES
		private String Turno="";
		private int empSelect = -1;
		private List<Interfaz.Operaciones.Dato.OrdenEmpresas> listaEmpOrden = null;
		private Interfaz.Operaciones.FormPrin_Empresas refPrincipal;
		#endregion
		
		#region GET EMPRESAS
		public void getEmpresas()
		{
			String consEmpresas="select ID, NOMBRE, NUMERO, NOMENCLATURA from ORDEN_EMPRESAS WHERE ";
			
			String diaExtra = refPrincipal.fecha_despacho.Substring(0,2);
			String mesExtra = refPrincipal.fecha_despacho.Substring(3,2);
			String anioExtra = refPrincipal.fecha_despacho.Substring(6,4);
			
			DateTime dateValue = new DateTime(Convert.ToInt16(anioExtra), Convert.ToInt16(mesExtra), Convert.ToInt16(diaExtra));
			
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="lunes")
				consEmpresas=consEmpresas+" LU='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="martes")
				consEmpresas=consEmpresas+" MA='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="miércoles")
				consEmpresas=consEmpresas+" MI='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="jueves")
				consEmpresas=consEmpresas+" JU='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="viernes")
				consEmpresas=consEmpresas+" VI='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="sábado")
				consEmpresas=consEmpresas+" SA='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="domingo")
				consEmpresas=consEmpresas+" DO='1' ";
			
			if(refPrincipal.ConsTurno=="Mañana")
				consEmpresas=consEmpresas+" and T1='1' ";
			else if(refPrincipal.ConsTurno=="Medio Día")
				consEmpresas=consEmpresas+" and T2='1' ";
			else if(refPrincipal.ConsTurno=="Vespertino")
				consEmpresas=consEmpresas+" and T3='1' ";
			else if(refPrincipal.ConsTurno=="Nocturno")
				consEmpresas=consEmpresas+" and T4='1' ";
			
			consEmpresas=consEmpresas+" ORDER BY NUMERO ";
			
			listaEmpOrden = new Conexion_Servidor.Desapacho.SQL_Operaciones().getEmpOrden(consEmpresas);
			
			if(listaEmpOrden!=null)
			{
				for(int x=0; x<listaEmpOrden.Count; x++)
				{
					dgEmpOrd.Rows.Add(listaEmpOrden[x].id_e, listaEmpOrden[x].nombre, listaEmpOrden[x].orden,  listaEmpOrden[x].nomenc);
				}
			}
		}
		#endregion
		
		void FormOrdenEmpresasLoad(object sender, EventArgs e)
		{
			getEmpresas();
			dgEmpOrd.ClearSelection();
		}
		
		#region EVENTOS BOTONES
		void CmdAntClick(object sender, EventArgs e)
		{
			if(empSelect>0)
			{
				for(int x=0; x<listaEmpOrden.Count; x++)
				{
					if(listaEmpOrden[x].id_e==dgEmpOrd[0,empSelect].Value.ToString())
					{
						dgEmpOrd[0,empSelect].Value=dgEmpOrd[0,empSelect-1].Value.ToString();
						dgEmpOrd[1,empSelect].Value=dgEmpOrd[1,empSelect-1].Value.ToString();
						dgEmpOrd[2,empSelect].Value=dgEmpOrd[2,empSelect-1].Value.ToString();
						dgEmpOrd[3,empSelect].Value=dgEmpOrd[3,empSelect-1].Value.ToString();
						
						dgEmpOrd[0,empSelect-1].Value=listaEmpOrden[x].id_e;
						dgEmpOrd[1,empSelect-1].Value=listaEmpOrden[x].nombre;
						dgEmpOrd[2,empSelect-1].Value=listaEmpOrden[x].orden;
						dgEmpOrd[3,empSelect-1].Value=listaEmpOrden[x].nomenc;
						break;
					}
				}
				empSelect=empSelect-1;
				dgEmpOrd.ClearSelection();
				dgEmpOrd[1,empSelect].Selected=true;
			}
		}
		
		void CmdDespClick(object sender, EventArgs e)
		{
			if(empSelect!=-1 && empSelect<dgEmpOrd.Rows.Count)
			{
				for(int x=listaEmpOrden.Count-1; x>-1; x--)
				{
					if(listaEmpOrden[x].id_e==dgEmpOrd[0,empSelect].Value.ToString())
					{
						dgEmpOrd[0,empSelect].Value=dgEmpOrd[0,empSelect+1].Value.ToString();
						dgEmpOrd[1,empSelect].Value=dgEmpOrd[1,empSelect+1].Value.ToString();
						dgEmpOrd[2,empSelect].Value=dgEmpOrd[2,empSelect+1].Value.ToString();
						dgEmpOrd[3,empSelect].Value=dgEmpOrd[3,empSelect+1].Value.ToString();
						
						dgEmpOrd[0,empSelect+1].Value=listaEmpOrden[x].id_e;
						dgEmpOrd[1,empSelect+1].Value=listaEmpOrden[x].nombre;
						dgEmpOrd[2,empSelect+1].Value=listaEmpOrden[x].orden;
						dgEmpOrd[3,empSelect+1].Value=listaEmpOrden[x].nomenc;
					}
				}
				empSelect=empSelect+1;
				dgEmpOrd.ClearSelection();
				dgEmpOrd[1,empSelect].Selected=true;
			}
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			for(int x=0; x<dgEmpOrd.Rows.Count; x++)
			{
				dgEmpOrd[2,x].Value=x+1;
			}
			
			for(int x=0; x<dgEmpOrd.Rows.Count; x++)
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().modificarOrden(Convert.ToInt16(dgEmpOrd[0,x].Value), Convert.ToInt16(dgEmpOrd[2,x].Value), Convert.ToString(dgEmpOrd[3,x].Value));
			}
			
			refPrincipal.carga=true;
			refPrincipal.getSubNombresEmpresas();
			refPrincipal.getEmpresas();
			this.Close();
		}
		#endregion
		
		#region SELECCION DE EMPRESA
		void DgEmpOrdCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				empSelect=e.RowIndex;
			}
		}
		#endregion
		
		void DgEmpOrdKeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		
		void DgEmpOrdKeyDown(object sender, KeyEventArgs e)
		{
			//e.KeyChar = char.ToUpper(e.KeyChar);
			
		}
	}
}
