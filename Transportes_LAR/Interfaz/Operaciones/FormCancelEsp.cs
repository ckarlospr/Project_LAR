using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormCancelEsp : Form
	{
		public FormCancelEsp(FormOperadorEsp refEspOp, FormEmpresasOperaciones refEmpO, int mi_Row, int mi_Column)
		{
			InitializeComponent();
			refEmpOper=refEmpO;
			refOpEspecial=refEspOp;
			datoRow=mi_Row;
			datoCol=mi_Column;
		}
		
		#region INSTANCIAS
		private int indexFil=-1;
		
		public int datoRow=0;
		public int datoCol=-1;
		public FormEmpresasOperaciones refEmpOper = null;
		public FormOperadorEsp refOpEspecial = null;
		
		private int tipoCancelado=0;
		#endregion
		
		#region EVENTO BOTONES
		void CmdCancPuntoClick(object sender, EventArgs e)
		{
			this.Size = new System.Drawing.Size(367,260);
			tipoCancelado=1;
		}
		
		void CmdCancAntClick(object sender, EventArgs e)
		{
			this.Size = new System.Drawing.Size(367,260);
			tipoCancelado=2;
		}
		
		void CmdCancAsignClick(object sender, EventArgs e)
		{
			borradoAsignacion();
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text!="")
			{
				borradoAsignacion();
				
				tipoCancelado=0;
				txtNombre.Text="";
				this.Size = new System.Drawing.Size(367,155);
			}
			else
			{
				MessageBox.Show("En necesario ingrese el nombre de la persona que cancela el nombre.");
			}
		}
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region CANCELADO DE ASIGNACION
		public void borradoAsignacion()
		{
			for(int x=0; x<refEmpOper.dtgEmpresas.Rows.Count; x++)
			{
				if(refEmpOper.dtgEmpresas[2,x].Value.ToString()==refOpEspecial.dtDatos[4,datoRow].Value.ToString() && refEmpOper.dtgEmpresas[0,x].Style.BackColor.Name.ToString()=="MediumSpringGreen")
				{
					if(refEmpOper.datosEspeciales==true)
					{
						refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[2,x].Value));
						if(refEmpOper.dtgEmpresas[10,x].Value.ToString()!=" ")
						{
							refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[10,x].Value));
						}
					}
					//new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion(Convert.ToInt64(refEmpOper.dtgEmpresas[17,x].Value));
					indexFil=x;
					modColores(2);
					/*if(tipoCancelado==1)
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaPunto(Convert.ToInt16(refEmpOper.dtgEmpresas[18,indexFil].Value), Convert.ToInt16(refEmpOper.dtgEmpresas[2,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario,refEmpOper.refPrincipal.ConsTurno, refEmpOper.refPrincipal.fecha_despacho);
						new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacionESP("execute cancelacionEspecialPunto "+refOpEspecial.id_Viaje+",'"+txtNombre.Text+"'");
					}
					else if(tipoCancelado==2)
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaEspecial(refEmpOper.dtgEmpresas[2,indexFil].Value.ToString()); //10
						new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacionESP("execute cancelacionEspecial "+refOpEspecial.id_Viaje+",'"+txtNombre.Text+"'");
					}*/
				}
				else if(refEmpOper.dtgEmpresas[10,x].Value.ToString()==refOpEspecial.dtDatos[9,datoRow].Value.ToString() && refEmpOper.dtgEmpresas[9,x].Style.BackColor.Name.ToString()=="MediumSpringGreen")
				{
					if(refEmpOper.datosEspeciales==true)
					{
						refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[10,indexFil].Value));
					}
					//new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion(Convert.ToInt64(refEmpOper.dtgEmpresas[21,x].Value));
					indexFil=x;
					modColores(1);
					/*if(tipoCancelado==2)
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaEspecial(refEmpOper.dtgEmpresas[10,indexFil].Value.ToString()); //10
					}*/
				}
			}
		}
		#endregion
		
		#region CANCELADOS
		public void modColores(int tipo)
		{
			if(indexFil!=-1)
			{
				if(tipo==1)
				{
					
					refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[11,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
					refEmpOper.dtgEmpresas[11,indexFil].Value="Operador";
					refEmpOper.dtgEmpresas[13,indexFil].Value="00:00";
					refEmpOper.dtgEmpresas[15,indexFil].Value="00:00";
					for(int x=9; x<17; x++)
					{
						refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
					}
					refEmpOper.dtgEmpresas[9,indexFil].Style.BackColor=Color.Red;
					//refEmpOper.dtgEmpresas[11,indexFil].Style.BackColor=Color.MediumSpringGreen;
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[21].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[22].Value="";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[23].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[24].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[16].Value=false;
					//refEmpOper.dtgEmpresas[16,indexFil].f;
					
				}
				else if(tipo==2)
				{
					refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[3,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
					refEmpOper.dtgEmpresas[3,indexFil].Value="Operador";
					refEmpOper.dtgEmpresas[5,indexFil].Value="00:00";
					refEmpOper.dtgEmpresas[7,indexFil].Value="00:00";
					for(int x=0; x<9; x++)
					{
						refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
					}
					refEmpOper.dtgEmpresas[0,indexFil].Style.BackColor=Color.Red;
					
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[17].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[18].Value="";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[19].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[20].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[8].Value=false;
				
					refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[11,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
					refEmpOper.dtgEmpresas[11,indexFil].Value="Operador";
					refEmpOper.dtgEmpresas[13,indexFil].Value="00:00";
					refEmpOper.dtgEmpresas[15,indexFil].Value="00:00";
					for(int x=9; x<17; x++)
					{
						refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
					}
					refEmpOper.dtgEmpresas[9,indexFil].Style.BackColor=Color.Red;
					
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[21].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[22].Value="";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[23].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[24].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[16].Value=false;
				}
				indexFil=-1;
			}
		}
		#endregion
	}
}
