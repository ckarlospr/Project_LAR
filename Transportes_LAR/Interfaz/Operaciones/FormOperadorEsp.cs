using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormOperadorEsp : Form
	{
		public FormOperadorEsp(FormPrincEspeciales refPrincEsp, int ID)
		{
			InitializeComponent();
			
			id_Viaje=ID;
			refPrincEspeciales=refPrincEsp;
		}
		
		#region INSTANCIAS
		public FormPrincEspeciales refPrincEspeciales=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		public int id_Viaje = 0;
		private int filaSelect=-1;
		
		public int cantEntradas = 0;
		public int cantSalidas = 0;
		#endregion
		
		void FormOperadorEspLoad(object sender, EventArgs e)
		{
			getDatosRutas();
			dtDatos.AutoSize=true;
			getAsignaciones();
			//getCancelados();
		}
		
		#region EVENTO BOTONES
		void CmdMuestraClick(object sender, EventArgs e)
		{
			if(cmdMuestra.Text=="+")
			{
				this.AutoSize = true;
				cmdMuestra.Text="-";
				
			}
			else if(cmdMuestra.Text=="-")
			{
				this.AutoSize = false;
				cmdMuestra.Text="+";
				this.Size = new System.Drawing.Size(357,27);
			}
			refPrincEspeciales.mueveFormVR(this);
		}
		
		public void CIERRE()
		{
			this.AutoSize = false;
			cmdMuestra.Text="+";
			this.Size = new System.Drawing.Size(357,27);
		}
		
		public void ABRE()
		{
			this.AutoSize = true;
			cmdMuestra.Text="-";
		}
		
		void CmdSeleccionarClick(object sender, EventArgs e)
		{
			if(cmdSeleccionar.Text==">")
			{
				refPrincEspeciales.seleccionDatos(this);
				cmdSeleccionar.Text="<";
				this.BackColor=Color.LightBlue;
			}
			else if(cmdSeleccionar.Text=="<")
			{
				refPrincEspeciales.desSeleccion();
				cmdSeleccionar.Text=">";
				this.BackColor=Color.Tan;
			}
		}
		#endregion
		
		#region PREPARACION DE DATOS PARA DESPACHAR ESPECIALES
		public void getDatosRutas()
		{
			conn.getAbrirConexion("SELECT R.ID FROM RUTA_ESPECIAL RE, RUTA R WHERE R.IdSubEmpresa=RE.ID_C and RE.ID_RE="+id_Viaje+" and R.Sentido='Entrada'");
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dtDatos.Rows.Add("*", "000", "Operador", " ", conn.leer["ID"].ToString(), " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
			}
			
			conn.conexion.Close();
			
			conn.getAbrirConexion("SELECT R.ID FROM RUTA_ESPECIAL RE, RUTA R WHERE R.IdSubEmpresa=RE.ID_C and RE.ID_RE="+id_Viaje+" and R.Sentido='Salida'");
			conn.leer=conn.comando.ExecuteReader();
			
			
			/*if(conn.leer.Read())
			{*/
				int x=0;
				while(conn.leer.Read())
				{
					dtDatos[9,x].Value=conn.leer["ID"].ToString();
					dtDatos[15,x].Value="000";
					dtDatos[16,x].Value="Operador";
					dtDatos[14,x].Value="*";
					x++;
				}
			/*}
			else
			{
				for(int x=0; x<dtDatos.Rows.Count; x++)
				{
					dtDatos[9,x].Value=conn.leer["ID"].ToString();
					dtDatos[15,x].Value="000";
					dtDatos[16,x].Value="Operador";
					dtDatos[16,x].=;
					dtDatos[14,x].Value="*";
				}
			}*/
				
			conn.conexion.Close();
			
			conn.getAbrirConexion("SELECT DESTINO, CANT_UNIDADES FROM RUTA_ESPECIAL WHERE ID_RE="+id_Viaje);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				lblNombre.Text=conn.leer["DESTINO"].ToString().ToUpper();
				lblCantidad.Text=conn.leer["CANT_UNIDADES"].ToString();
			}
			conn.conexion.Close();
			
			dtDatos.ClearSelection();
		}
		#endregion
		
		#region AUTOCOMPLETE
		void DtDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			filaSelect=e.RowIndex;
		}
		
		void DtDatosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if(dtDatos.CurrentCell.ColumnIndex==2 || dtDatos.CurrentCell.ColumnIndex==16)
			{
				if(dtDatos.CurrentCell.ColumnIndex==2 && dtDatos[2,dtDatos.CurrentRow.Index].Style.BackColor.Name.ToString()!="MediumSpringGreen")
				{
					((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
	                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
	                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;
	                
	                ((TextBox)e.Control).KeyUp += DtDatosKeyUp;
				}
				else if(dtDatos.CurrentCell.ColumnIndex==16 && dtDatos[16,dtDatos.CurrentRow.Index].Style.BackColor.Name.ToString()!="MediumSpringGreen")
				{
					((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
	                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
	                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;
	                
	                ((TextBox)e.Control).KeyUp += DtDatosKeyUp;
				}
				else
				{
					if(dtDatos.CurrentCell.ColumnIndex==2)
						dtDatos[2,dtDatos.CurrentRow.Index].ReadOnly=true;
					
					if(dtDatos.CurrentCell.ColumnIndex==16)
						dtDatos[16,dtDatos.CurrentRow.Index].ReadOnly=true;
					
					
					if (e.Control is DataGridViewTextBoxEditingControl )
						((TextBox)e.Control).AutoCompleteCustomSource = null;
				}
			}
			else
			{
				if (e.Control is DataGridViewTextBoxEditingControl )
						((TextBox)e.Control).AutoCompleteCustomSource = null;
			}
		}
		
		void DtDatosKeyUp(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next)
			{
				if(dtDatos.CurrentCell.ColumnIndex==2 || dtDatos.CurrentCell.ColumnIndex==16)
				{
					filaSelect=dtDatos.CurrentRow.Index;
				}
			}
			
			if(e.KeyCode == Keys.Return)
			{
				if(filaSelect!=-1)
				{
					if(dtDatos.CurrentCell.ColumnIndex==2)
					{
						refPrincEspeciales.refEmpresaOper.refPrincipal.principal.contandoViajes(0,dtDatos[2,filaSelect].Value.ToString(),refPrincEspeciales.refEmpresaOper.lblNombreEmp.Text, "C");
						if(refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi!=null)
						{
							dtDatos[1,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.numeroVehiculo.ToString();
							
							dtDatos[6,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
							dtDatos[7,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
							dtDatos[8,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
							/*dtDatos[10,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
							dtDatos[11,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
							dtDatos[12,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();*/
							
							refPrincEspeciales.refEmpresaOper.AsignacionOperadorAlt(Convert.ToInt64(dtDatos[4,filaSelect].Value));
							
							if(dtDatos[9,filaSelect].Value.ToString()!=" ")
							{
								dtDatos[15,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.numeroVehiculo.ToString();
								dtDatos[16,filaSelect].Value=dtDatos[2,filaSelect].Value.ToString();
								
								dtDatos[11,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtDatos[12,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtDatos[13,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
								refPrincEspeciales.refEmpresaOper.AsignacionOperadorAlt(Convert.ToInt64(dtDatos[9,filaSelect].Value));
							}
						}
						else
						{
							dtDatos[2,filaSelect].Value="Operador";
							dtDatos[1,filaSelect].Value="000";
						}
					}
					else if(dtDatos.CurrentCell.ColumnIndex==16)
					{
						refPrincEspeciales.refEmpresaOper.refPrincipal.principal.contandoViajes(0,dtDatos[16,filaSelect].Value.ToString(),refPrincEspeciales.refEmpresaOper.lblNombreEmp.Text, "C");
						if(refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi!=null)
						{
							dtDatos[15,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.numeroVehiculo.ToString();
								
							dtDatos[11,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
							dtDatos[12,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
							dtDatos[13,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
							/*dtDatos[10,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
							dtDatos[11,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
							dtDatos[12,filaSelect].Value=refPrincEspeciales.refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();*/
							
							refPrincEspeciales.refEmpresaOper.AsignacionOperadorAlt(Convert.ToInt64(dtDatos[9,filaSelect].Value));
						}
						else
						{
							dtDatos[2,filaSelect].Value="Operador";
							dtDatos[1,filaSelect].Value="000";
						}
					}
						
				}
			}
			
			dtDatos.ClearSelection();
		}
		#endregion
		
		#region GET RUTAS ASIGNADAS
		public void getAsignaciones()
		{
			List<String> RutasAsignadas = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdEspAsigEsp(refPrincEspeciales.refEmpresaOper.DIA_DESPACHO);
			
			if(RutasAsignadas.Count>0)
			{
				for(int y=0; y<dtDatos.Rows.Count; y++)
				{
					for(int x=0; x<RutasAsignadas.Count; x++)
					{
						if(Convert.ToString(dtDatos[4,y].Value)==RutasAsignadas[x].ToString())
						{
							Interfaz.Operaciones.Dato.Busqueda DATOS = new Conexion_Servidor.Desapacho.SQL_Operaciones().getOperador(RutasAsignadas[x].ToString(), refPrincEspeciales.refEmpresaOper.miTurno, refPrincEspeciales.refEmpresaOper.DIA_DESPACHO, refPrincEspeciales.refEmpresaOper.lblNombreEmp.Text);
							dtDatos[1,y].Value= new Conexion_Servidor.Desapacho.SQL_Operaciones().getNumUnidad(DATOS.id_vehiculo);
							
							dtDatos[2,y].Value=DATOS.nomOperador;
							dtDatos[3,y].Value=DATOS.confirmada;
							dtDatos[5,y].Value=DATOS.id_operacion;
							dtDatos[6,y].Value=DATOS.id_operacion;
							dtDatos[7,y].Value=DATOS.id_vehiculo;
							dtDatos[8,y].Value=DATOS.vehiculo;
							
							for(int z=0; z<3; z++)
							{
								dtDatos[z,y].Style.BackColor=Color.MediumSpringGreen;
							}
							
							cantEntradas ++; 
						}
						else if(Convert.ToString(dtDatos[9,y].Value)==RutasAsignadas[x].ToString()) // Salidas
						{
							Interfaz.Operaciones.Dato.Busqueda DATOS = new Conexion_Servidor.Desapacho.SQL_Operaciones().getOperador(RutasAsignadas[x].ToString(), refPrincEspeciales.refEmpresaOper.miTurno, refPrincEspeciales.refEmpresaOper.DIA_DESPACHO, refPrincEspeciales.refEmpresaOper.lblNombreEmp.Text);
							dtDatos[15,y].Value= new Conexion_Servidor.Desapacho.SQL_Operaciones().getNumUnidad(DATOS.id_vehiculo);
							
							dtDatos[16,y].Value=DATOS.nomOperador;
							dtDatos[17,y].Value=DATOS.confirmada;
							dtDatos[10,y].Value=DATOS.id_operacion;
							dtDatos[11,y].Value=DATOS.id_operacion;
							dtDatos[12,y].Value=DATOS.id_vehiculo;
							dtDatos[13,y].Value=DATOS.vehiculo;
							
							
							for(int z=14; z<17; z++)
							{
								dtDatos[z,y].Style.BackColor=Color.MediumSpringGreen;
							}
							
							cantSalidas ++;
						}
					}
				}
			}
			
			//MessageBox.Show("Entradas: "+cantEntradas+" - Salidas: "+cantSalidas);
			lblRestEnt.Text=(Convert.ToInt16(lblCantidad.Text)-cantEntradas).ToString();
			lblRestRegresos.Text=(Convert.ToInt16(lblCantidad.Text)-cantSalidas).ToString();
			
			getCanceladosPunto();
			getCancelados();
			getCancAntPunto();
			bloqueoOtros();
		}
		
		public void getCanceladosPunto()
		{
			for(int x=0; x<dtDatos.Rows.Count; x++)
			{
				String consulta = "select Alias, V.Numero from CANCELACION_PUNTO C, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=C.ID_OPERADOR and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and C.ID_RUTA='"+dtDatos[4,x].Value.ToString()+"' and C.FECHA='"+refPrincEspeciales.dtpInicio.Value.ToString().Substring(0,10)+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dtDatos[2,x].Value=conn.leer["Alias"].ToString();
					dtDatos[1,x].Value=conn.leer["Numero"].ToString();
					
					dtDatos[16,x].Value=conn.leer["Alias"].ToString();
					dtDatos[15,x].Value=conn.leer["Numero"].ToString();
					
					for(int y=0; y<dtDatos.Columns.Count; y++)
					{
						dtDatos[y,x].Style.BackColor=Color.Red;
						dtDatos[y,x].ReadOnly=true;
					}
				}
				conn.conexion.Close();
			}
		}
		
		public void getCancelados()
		{
			conn.getAbrirConexion("select estado from RUTA_ESPECIAL where ID_RE="+id_Viaje);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				if(conn.leer["estado"].ToString()=="Cancelado")
				{
					this.lblNombre.BackColor=Color.Red;
					lblNombre.Text="(Cancelado) "+lblNombre.Text;
					dtDatos.Enabled=false;
				}
			}
			conn.conexion.Close();
		}
		
		public void bloqueoOtros()
		{
			conn.getAbrirConexion("select FECHA_SALIDA from RUTA_ESPECIAL where ID_RE="+id_Viaje);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				String Alc = refPrincEspeciales.refEmpresaOper.DIA_DESPACHO;
				if(conn.leer["FECHA_SALIDA"].ToString().Substring(0,10)!=refPrincEspeciales.refEmpresaOper.refPrincipal.fecha_despacho)
				{
					this.lblNombre.BackColor=Color.Red;
					lblNombre.Text="(OTRO DÍA) "+lblNombre.Text;
					dtDatos.Enabled=false;
				}
			}
			conn.conexion.Close();
		}
		
		public void getCancAntPunto()
		{
			for(int x=0; x<dtDatos.Rows.Count; x++)
			{
				String consulta = "select TIPO from RUTA where ID="+dtDatos[4,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="Cancelada")
					{
						dtDatos[2,x].Value="Cancelada";
						dtDatos[16,x].Value="Cancelada";
						for(int y=0; y<dtDatos.Columns.Count; y++)
						{
							dtDatos[y,x].Style.BackColor=Color.Yellow;
							dtDatos[y,x].ReadOnly=true;
						}
					}
				}
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region CONFIRMACION-CANCELADO
		void DtDatosDoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show(dtDatos.CurrentCell.ColumnIndex.ToString());
			if(dtDatos.CurrentCell.ColumnIndex==0)
			{
				if(dtDatos.CurrentRow.Cells[2].Style.BackColor.Name=="MediumSpringGreen")
				{
					DialogResult rs = MessageBox.Show("Este servicio ya esta asignado. ¿Desea eliminar asignación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs)
					{
						new FormCancelEsp(this, refPrincEspeciales.refEmpresaOper, filaSelect, dtDatos.CurrentCell.ColumnIndex).ShowDialog();
					}
				}
				else if(dtDatos.CurrentCell.ColumnIndex==0 && (dtDatos.CurrentRow.Cells[2].Style.BackColor.Name!="MediumSpringGreen" && dtDatos.CurrentRow.Cells[6].Value.ToString()!=" ") && (dtDatos.CurrentRow.Cells[16].Style.BackColor.Name!="MediumSpringGreen" && dtDatos.CurrentRow.Cells[11].Value.ToString()!=" "))
				{
					refPrincEspeciales.refEmpresaOper.confirmaAlt(Convert.ToInt64(dtDatos[4,filaSelect].Value));
					refPrincEspeciales.refEmpresaOper.confirmaAlt(Convert.ToInt64(dtDatos[9,filaSelect].Value));
				}
				else if(dtDatos.CurrentRow.Cells[2].Style.BackColor.Name!="MediumSpringGreen" && dtDatos.CurrentRow.Cells[6].Value.ToString()!=" ")
				{
					refPrincEspeciales.refEmpresaOper.confirmaAlt(Convert.ToInt64(dtDatos[4,filaSelect].Value));
				}
			}
			else if(dtDatos.CurrentCell.ColumnIndex==14)
			{				
				if(dtDatos.CurrentRow.Cells[16].Style.BackColor.Name=="MediumSpringGreen")
				{
					DialogResult rs = MessageBox.Show("Este servicio ya esta asignado. ¿Desea eliminar asignación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs)
					{
						new FormCancelEsp(this, refPrincEspeciales.refEmpresaOper, filaSelect, dtDatos.CurrentCell.ColumnIndex).ShowDialog();
					}
				}				
				else if(dtDatos.CurrentRow.Cells[16].Style.BackColor.Name!="MediumSpringGreen" && dtDatos.CurrentRow.Cells[11].Value.ToString()!=" ")
				{
					refPrincEspeciales.refEmpresaOper.confirmaAlt(Convert.ToInt64(dtDatos[9,filaSelect].Value));
				}
			}
		}
		#endregion
		
		#region CONTEO 
		public void conteoFaltante()
		{
			//int total=0;
			int faltEnt=0;
			int faltSal=0;
			for(int x=0; x<dtDatos.Rows.Count; x++)
			{
				/*if(((dtDatos[5,x].Value.ToString()==" ")?0:Convert.ToInt64(dtDatos[5,x].Value))>0  ((dtDatos[10,x].Value.ToString()==" ")?0:Convert.ToInt64(dtDatos[10,x].Value))>0)
				{
					total++;
				}*/
				
				if(((dtDatos[5,x].Value.ToString()==" ")?0:Convert.ToInt64(dtDatos[5,x].Value))==0)
				{
					faltEnt++;	
				}
				
				if(((dtDatos[10,x].Value.ToString()==" ")?0:Convert.ToInt64(dtDatos[10,x].Value))==0)
				{
					faltSal++;	
				}
				
				lblRestEnt.Text=faltEnt.ToString();
				lblRestRegresos.Text=faltSal.ToString();
				
				if(lblRestEnt.Text.ToString()!="0")
					lblRestEnt.BackColor=Color.Red;
				else
					lblRestEnt.BackColor=Color.Silver;
				
				if(lblRestRegresos.Text.ToString()!="0")
					lblRestRegresos.BackColor=Color.Red;
				else
					lblRestRegresos.BackColor=Color.Silver;
			}
		}
		#endregion
		
	}
}
