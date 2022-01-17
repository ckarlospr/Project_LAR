using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormMensaje : Form
	{
		public FormMensaje(int ROW, int COLUMN, FormEmpresasOperaciones refEmp)
		{
			InitializeComponent();
			ROW_Index=ROW;
			COLUMN_Index=COLUMN;
			refEmpOp=refEmp;
		}
		
		private int ROW_Index=0;
		private int COLUMN_Index=0;
		private FormEmpresasOperaciones refEmpOp=null;
		
		void FormMensajeLoad(object sender, EventArgs e)
		{
			lblEmp.Text=refEmpOp.nomEmpresa;
			if(refEmpOp.dtgEmpresas[2, ROW_Index].Value.ToString()!="" && refEmpOp.dtgEmpresas[2, ROW_Index].Value.ToString()!=" ")
			{
				lblRut.Text=refEmpOp.dtgEmpresas[6, ROW_Index].Value.ToString();
				cmdBorrar.Enabled=true;
			}
			else if(refEmpOp.dtgEmpresas[10, ROW_Index].Value.ToString()!="" && refEmpOp.dtgEmpresas[10, ROW_Index].Value.ToString()!=" ")
			{
				lblRut.Text=refEmpOp.dtgEmpresas[14, ROW_Index].Value.ToString();
				cmdBorrar.Enabled=true;
			}
		}
		
		
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtMensaje.Text!="")
			{
				if(refEmpOp.dtgEmpresas[2, ROW_Index].Value.ToString()!="" && refEmpOp.dtgEmpresas[2, ROW_Index].Value.ToString()!=" ")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().msjRuta(refEmpOp.refPrincipal.principal.idUsuario, Convert.ToInt32(refEmpOp.dtgEmpresas[2, ROW_Index].Value), txtMensaje.Text, refEmpOp.refPrincipal.fecha_despacho, refEmpOp.refPrincipal.ConsTurno);
				}
				else if(refEmpOp.dtgEmpresas[10, ROW_Index].Value.ToString()!="" && refEmpOp.dtgEmpresas[10, ROW_Index].Value.ToString()!=" ")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().msjRuta(refEmpOp.refPrincipal.principal.idUsuario, Convert.ToInt32(refEmpOp.dtgEmpresas[10, ROW_Index].Value), txtMensaje.Text, refEmpOp.refPrincipal.fecha_despacho, refEmpOp.refPrincipal.ConsTurno);
				}
				
				refEmpOp.dtgEmpresas[26, ROW_Index].Value=txtMensaje.Text;
				refEmpOp.dtgEmpresas[26, ROW_Index].Style.BackColor=Color.Red;
				this.Close();
			}
			else
			{
				MessageBox.Show("Ingrese mensaje");
			}
		}
		
		
		void CmdBorrarClick(object sender, EventArgs e)
		{
			txtMensaje.Text="";
			refEmpOp.dtgEmpresas[26, ROW_Index].Style.BackColor=Color.White;
			refEmpOp.dtgEmpresas[26, ROW_Index].Value="";
		}
		
		void CmdSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
