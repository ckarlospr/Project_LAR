using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormApoyos : Form
	{
		public FormApoyos(Interfaz.Operaciones.FormPrin_Empresas refPrin, Interfaz.Operaciones.FormCancelCambio refEmp)
		{
			InitializeComponent();
			refPrincipal = refPrin;
			refEmpresa=refEmp;
			
			txtApoyo.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias As Dato from OPERADOR where Estatus='1' and (tipo_empleado='OPERADOR' OR tipo_empleado like '%coo%' OR tipo_empleado like '%ext%')");
			txtApoyo.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtApoyo.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOpCo.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias As Dato from OPERADOR where Estatus='1' and (tipo_empleado='OPERADOR' OR tipo_empleado like '%coo%' OR tipo_empleado like '%ext%')");
			txtOpCo.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtOpCo.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOpOf.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias As Dato from OPERADOR where Estatus='1' and (tipo_empleado='OPERADOR' OR tipo_empleado like '%coo%' OR tipo_empleado like '%ext%')");
			txtOpOf.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtOpOf.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		#region REFERENCIAS
		private Interfaz.Operaciones.FormCancelCambio refEmpresa = null;
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		private Interfaz.Operaciones.FormPrin_Empresas refPrincipal = null;
		private Int64 IDOP_ENRUTA=0;
		private Int64 ID_RUTA=0;
		#endregion
		
		void FormApoyosLoad(object sender, EventArgs e)
		{
			txtApoyo.Focus();
			if(refEmpresa.indexCol<9)
			{
				if(refEmpresa.refEmpOper.dtgEmpresas[0,refEmpresa.indexFil].Style.BackColor.Name=="MediumSpringGreen")
				{
					txtOperador.Text=refEmpresa.refEmpOper.dtgEmpresas[3,refEmpresa.indexFil].Value.ToString();
					IDOP_ENRUTA=Convert.ToInt64(refEmpresa.refEmpOper.dtgEmpresas[18,refEmpresa.indexFil].Value);
					txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[6,refEmpresa.indexFil].Value.ToString();
					ID_RUTA=Convert.ToInt64(refEmpresa.refEmpOper.dtgEmpresas[2,refEmpresa.indexFil].Value);
				}
				else
				{
					txtOperador.Text="-";
					txtRuta.Text="-";
					rbCoordinacion.Checked=true;
					rbRuta.Checked=false;
					rbRuta.Enabled=false;
				}
			}
			else
			{
				if(refEmpresa.refEmpOper.dtgEmpresas[9,refEmpresa.indexFil].Style.BackColor.Name=="MediumSpringGreen")
				{
					txtOperador.Text=refEmpresa.refEmpOper.dtgEmpresas[11,refEmpresa.indexFil].Value.ToString();
					IDOP_ENRUTA=Convert.ToInt64(refEmpresa.refEmpOper.dtgEmpresas[22,refEmpresa.indexFil].Value);
					txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[14,refEmpresa.indexFil].Value.ToString();
					ID_RUTA=Convert.ToInt64(refEmpresa.refEmpOper.dtgEmpresas[10,refEmpresa.indexFil].Value);
				}
				else
				{
					txtOperador.Text="-";
					txtRuta.Text="-";
					rbCoordinacion.Checked=true;
					rbRuta.Checked=false;
					rbRuta.Enabled=false;
				}
			}
		}
		
		void CbRutaCheckedChanged(object sender, EventArgs e)
		{
			if(refEmpresa.indexCol<9)
			{
				txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[6,refEmpresa.indexFil].Value.ToString();
			}
			else
			{
				txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[14,refEmpresa.indexFil].Value.ToString();
			}
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(txtApoyo.Text!="")
			{
				int idOpApoya = 0;
				if(rbRuta.Checked==true)
				{
					idOpApoya = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtApoyo.Text);
					if(idOpApoya!=0)
					{						
						new Conexion_Servidor.Desapacho.SQL_Operaciones().guardarApoyo(refEmpresa.refEmpOper.refPrincipal.principal.idUsuario,IDOP_ENRUTA, idOpApoya, ID_RUTA, refEmpresa.refEmpOper.refPrincipal.fecha_Base_Datos, refEmpresa.refEmpOper.refPrincipal.ConsTurno, "RUTA "+((rbCorto.Checked==false)?((rbMedio.Checked==false)?"COMPLETA":"MEDIA"):"CORTA"), txtComentarios.Text);
						refPrincipal.datosApoyos();
						this.Close();
					}
					else if(idOpApoya==0)
					{
						MessageBox.Show("Operador no encontrado.");
					}
				}
				else if(rbCoordinacion.Checked==true)
				{
					idOpApoya = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtOpCo.Text);
					if(idOpApoya!=0)
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().guardarApoyoCoordinacion("insert into APOYOS values ("+refEmpresa.refEmpOper.refPrincipal.principal.idUsuario+", null, "+idOpApoya+", null, '"+refEmpresa.refEmpOper.refPrincipal.fecha_Base_Datos+"', '"+refEmpresa.refEmpOper.refPrincipal.ConsTurno+"', 'Coordinación', '"+txtComentarios.Text+"')");
						refPrincipal.datosApoyos();
						this.Close();
					}
					else if(idOpApoya==0)
					{
						MessageBox.Show("Operador no encontrado.");
					}
				}
				else if(rbOficinas.Checked==true)
				{
					idOpApoya = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtOpOf.Text);
					if(idOpApoya!=0)
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().guardarApoyoCoordinacion("insert into APOYOS values ("+refEmpresa.refEmpOper.refPrincipal.principal.idUsuario+", null, "+idOpApoya+", null, '"+refEmpresa.refEmpOper.refPrincipal.fecha_Base_Datos+"', '"+refEmpresa.refEmpOper.refPrincipal.ConsTurno+"', 'Oficinas', '"+txtComentarios.Text+"')");
						refPrincipal.datosApoyos();
						this.Close();
					}
					else if(idOpApoya==0)
					{
						MessageBox.Show("Operador no encontrado.");
					}
				}
			}
		}
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		#region EVENTO RADIO BUTTON
		void RbCoordinacionCheckedChanged(object sender, EventArgs e)
		{
			if(rbCoordinacion.Checked==true)
			{
				gbCoor.Enabled=true;
			}
			else
			{
				gbCoor.Enabled=false;
			}
		}
		
		void RbRutaCheckedChanged(object sender, EventArgs e)
		{
			if(rbRuta.Checked==true)
			{
				gbRuta.Enabled=true;
			}
			else
			{
				gbRuta.Enabled=false;
			}
		}
		
		void RbOficinasCheckedChanged(object sender, EventArgs e)
		{
			if(rbOficinas.Checked==true)
			{
				gbOficinas.Enabled=true;
			}
			else
			{
				gbOficinas.Enabled=false;
			}
		}
		#endregion
	}
}
