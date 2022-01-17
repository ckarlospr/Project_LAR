using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormComentarios : Form
	{
		public FormComentarios(Interfaz.Operaciones.FormPrin_Empresas refPrin)
		{
			InitializeComponent();
			refPrincipal=refPrin;
		}
		
		private Interfaz.Operaciones.FormPrin_Empresas refPrincipal = null;
		
		void CmdMinimizarClick(object sender, EventArgs e)
		{
			this.Visible=false;
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			txtNota.Text="";
			cmdNuevo.Visible=false;
			txtNota.Enabled=true;
			lblFecha.Visible=false;
			lbltfecha.Visible=false;
			lblRealizado.Visible=false;
			lblUsuario.Visible=false;
		}
		
		public void GuardarComentario(int idUsu)
		{
			if(txtNota.Enabled==true)
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().setMsjGral("");
			}
		}
		
		void FormComentariosLoad(object sender, EventArgs e)
		{
			try
			{
				List<String> comentario = new Conexion_Servidor.Desapacho.SQL_Operaciones().getComentario(((refPrincipal.ConsTurno=="Mañana")?refPrincipal.diaAnterior(refPrincipal.fecha_despacho):refPrincipal.fecha_despacho), refPrincipal.getTurnoSecundario(refPrincipal.ConsTurno));
				lblRealizado.Text=comentario[0].ToString();
				lblFecha.Text=comentario[1].ToString();
				txtNota.Text=comentario[2].ToString();
			}
			catch(Exception)
			{
				
			}
		}
	}
}
