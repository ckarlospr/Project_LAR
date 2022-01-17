using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReporteViajesDespacho : Form
	{
		
		#region CONSTRUCTOR
		public FormReporteViajesDespacho(FormPrincipal refPrincipal)
		{
			InitializeComponent();
			principal = refPrincipal;
		}
		#endregion
		
		#region INSTANCIAS
		private FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		int acumulador = 0;
		int progreso = 1;
		int contadoVV = 0;
		#endregion
		
		#region INICIO - FIN
		void FormReporteViajesDespachoLoad(object sender, EventArgs e)
		{			
			cargaCbEmpresa();
		}
		
		void FormReporteViajesDespachoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.reporteCuadreDespacho = false;
		}
		#endregion
				
		#region BOTONES
		void BntBuscarClick(object sender, EventArgs e)
		{			
			fitrosPrincipales();
			fitrosReconocimientos();
			fitrosGuardias();
			fitrosRendimiento();
			fitrosCancelaP();
			fitrosApoyos();
			conteoEmpresa();
		}
		void LblLimpiarClick(object sender, EventArgs e)
		{			
			limpiar();
		}
		#endregion									
		
		#region METODOS	
		private void progresobarra(int x){
			principal.progressbarPrin.Minimum = 1;
    		principal.progressbarPrin.Maximum = 100;
    		
    		int variable;
			variable = (x/100);		
			++acumulador;
			
			if(acumulador == variable && progreso < 101){
				principal.progressbarPrin.Increment(progreso);
		    	principal.progressbarPrin.Value = progreso;
		    	progreso = progreso + 1;
		    	acumulador = 0;
			}
		}
		
		private void conteoEmpresa(){
			for(int x=0; x<dtConteo.Rows.Count; x++){
				for(int z=0; z<dataViajesNormales.Rows.Count; z++){
					if(dtConteo[0,x].Value.ToString() == dataViajesNormales[2,z].Value.ToString()){
						if(dataViajesNormales[0,z].Value.ToString() == "Completo"){
							dtConteo[2,x].Value = (Convert.ToInt32(dtConteo[2,x].Value) + 1).ToString();
							txtCompleto.Text = (Convert.ToInt32(txtCompleto.Text) + 1).ToString();
						}							
						else if(dataViajesNormales[0,z].Value.ToString() == "Sencillo"){
							dtConteo[1,x].Value = (Convert.ToInt32(dtConteo[1,x].Value) + 1).ToString();
							txtSencillo.Text = (Convert.ToInt32(txtSencillo.Text) + 1).ToString();
						}
						dtConteo[3,x].Value = (Convert.ToInt32(dtConteo[3,x].Value) + 1).ToString();
					}						
				}						
			}
			txtTotal.Text = (Convert.ToInt32(txtSencillo.Text) + Convert.ToInt32(txtCompleto.Text)).ToString();
		}		
		
		private void ValidarViajes0(){
			String FechaViajeNormal="";
			String EmpresaViajenormal="";
			String RutaViajeNormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String EmpresaViajenormal2="";
			String RutaViajeNormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";
			String VehiculoNormal="";
			String VehiculoNormal2="";
			String Extra="";
			String Extra2="";
			String SubEmpresa="";
			String SubEmpresa2="";
			String Alias="";
			String Alias2="";
			acumulador = 0;
			progreso = 1;

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[6].Value.ToString();
				VehiculoNormal = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
				Extra = dataViajesNormales.Rows[y].Cells[9].Value.ToString();
				SubEmpresa = dataViajesNormales.Rows[y].Cells[10].Value.ToString();
				Alias = dataViajesNormales.Rows[y].Cells[18].Value.ToString();
				
				if(Extra=="DIF")
					Extra="NRM";
				if(SubEmpresa == "RIMSA VANILLA" && TurnoViajeNormal == "Mañana"){
					SubEmpresa = "RIMSA LAR";		
					VehiculoNormal = "CAMION";
					dataViajesNormales.Rows[y].Cells[4].Style.BackColor=Color.LightPink;
				}
				
				for(int x = 1; x<(dataViajesNormales.RowCount); x++)
				{
					progresobarra(dataViajesNormales.RowCount);
					FechaViajeNormal2 = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
					RutaViajeNormal2 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales.Rows[x].Cells[6].Value.ToString();
					VehiculoNormal2 = dataViajesNormales.Rows[x].Cells[7].Value.ToString();
					Extra2 = dataViajesNormales.Rows[x].Cells[9].Value.ToString();
					SubEmpresa2 = dataViajesNormales.Rows[x].Cells[10].Value.ToString();
					Alias2 = dataViajesNormales.Rows[x].Cells[18].Value.ToString();
					
					if(Extra2=="DIF")
						Extra2="NRM";
					if(SubEmpresa2 == "RIMSA VANILLA" && TurnoViajeNormal2 == "Mañana"){
						SubEmpresa2 = "RIMSA LAR";
						VehiculoNormal2 = "CAMION";
						dataViajesNormales.Rows[x].Cells[4].Style.BackColor=Color.LightPink;
					}
					if((dataViajesNormales.Rows[x].Cells[0].Value.ToString() != "Completo") && (dataViajesNormales.Rows[y].Cells[0].Value.ToString() != "Completo")){					
						if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)
						    &&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(SubEmpresa==SubEmpresa2)&&(RutaViajeNormal==RutaViajeNormal2))
							{
								dataViajesNormales.Rows[y].Cells[0].Value = "Completo";
								dataViajesNormales.Rows[x].Cells[0].Value = "Completo";
								dataViajesNormales.Rows[y].Cells[5].Value = "E/S";
								dataViajesNormales.Rows[x].Cells[5].Value = "E/S";
								dataViajesNormales.Rows[y].Cells[4].Value = RutaViajeNormal2+" - "+RutaViajeNormal;
								dataViajesNormales.Rows[x].Cells[4].Value = RutaViajeNormal2+" - "+RutaViajeNormal;
								dataViajesNormales.Rows[y].Cells[0].Style.BackColor=Color.LimeGreen;
								dataViajesNormales.Rows[x].Cells[0].Style.BackColor=Color.LimeGreen;
								
								if(dataViajesNormales.Rows[y].Cells[18].Value.ToString() != dataViajesNormales.Rows[x].Cells[18].Value.ToString()){
									dataViajesNormales.Rows[x].Cells[18].Value = Alias+" - "+Alias2;
									dataViajesNormales.Rows[y].Cells[18].Value = Alias+" - "+Alias2;;
								}
								
								if(x != y){									
									if((Convert.ToDouble(dataViajesNormales.Rows[y].Cells[14].Value))>=(Convert.ToDouble(dataViajesNormales.Rows[x].Cells[14].Value))){
										dataViajesNormales.Rows.RemoveAt(x);
										if(x>0)
										    --x;
									}else{											
										dataViajesNormales.Rows.RemoveAt(y);
										if(x>0){
											--y;
											break;
										}
									}										
								}
							}											
					}
				}
			}
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
		}
		
		private void ValidarViajes(){
			String FechaViajeNormal="";
			String EmpresaViajenormal="";
			String RutaViajeNormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String EmpresaViajenormal2="";
			String RutaViajeNormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";
			String VehiculoNormal="";
			String VehiculoNormal2="";
			String Extra="";
			String Extra2="";
			String SubEmpresa="";
			String SubEmpresa2="";
			String Alias="";
			String Alias2="";
			acumulador = 0;
			progreso = 1;

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[6].Value.ToString();
				VehiculoNormal = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
				Extra = dataViajesNormales.Rows[y].Cells[9].Value.ToString();
				SubEmpresa = dataViajesNormales.Rows[y].Cells[10].Value.ToString();
				Alias = dataViajesNormales.Rows[y].Cells[18].Value.ToString();
				
				if(Extra=="DIF")
					Extra="NRM";
				if(SubEmpresa == "RIMSA VANILLA" && TurnoViajeNormal == "Mañana"){
					SubEmpresa = "RIMSA LAR";		
					VehiculoNormal = "CAMION";
					dataViajesNormales.Rows[y].Cells[4].Style.BackColor=Color.LightPink;
				}
				
				for(int x = 1; x<(dataViajesNormales.RowCount); x++)
				{
					progresobarra(dataViajesNormales.RowCount);
					FechaViajeNormal2 = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
					RutaViajeNormal2 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales.Rows[x].Cells[6].Value.ToString();
					VehiculoNormal2 = dataViajesNormales.Rows[x].Cells[7].Value.ToString();
					Extra2 = dataViajesNormales.Rows[x].Cells[9].Value.ToString();
					SubEmpresa2 = dataViajesNormales.Rows[x].Cells[10].Value.ToString();
					Alias2 = dataViajesNormales.Rows[x].Cells[18].Value.ToString();
					
					if(Extra2=="DIF")
						Extra2="NRM";
					if(SubEmpresa2 == "RIMSA VANILLA" && TurnoViajeNormal2 == "Mañana"){
						SubEmpresa2 = "RIMSA LAR";
						VehiculoNormal2 = "CAMION";
						dataViajesNormales.Rows[x].Cells[4].Style.BackColor=Color.LightPink;
					}
					
					if((dataViajesNormales.Rows[x].Cells[0].Value.ToString() != "Completo") && (dataViajesNormales.Rows[y].Cells[0].Value.ToString() != "Completo")){					
						if( (EmpresaViajenormal == "VITRO" && EmpresaViajenormal2 == "VITRO") || (EmpresaViajenormal == "CONVER" && EmpresaViajenormal2 == "CONVER") || (EmpresaViajenormal == "GRAN VITA" && EmpresaViajenormal2 == "GRAN VITA") ){
							if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)
						    &&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(SubEmpresa==SubEmpresa2)&&(RutaViajeNormal==RutaViajeNormal2))
							{
								dataViajesNormales.Rows[y].Cells[0].Value = "Completo";
								dataViajesNormales.Rows[x].Cells[0].Value = "Completo";
								dataViajesNormales.Rows[y].Cells[5].Value = "E/S";
								dataViajesNormales.Rows[x].Cells[5].Value = "E/S";
								dataViajesNormales.Rows[y].Cells[4].Value = RutaViajeNormal2+" - "+RutaViajeNormal;
								dataViajesNormales.Rows[x].Cells[4].Value = RutaViajeNormal2+" - "+RutaViajeNormal;
								dataViajesNormales.Rows[y].Cells[0].Style.BackColor=Color.LimeGreen;
								dataViajesNormales.Rows[x].Cells[0].Style.BackColor=Color.LimeGreen;
								
								if(dataViajesNormales.Rows[y].Cells[18].Value.ToString() != dataViajesNormales.Rows[x].Cells[18].Value.ToString()){
									dataViajesNormales.Rows[x].Cells[18].Value = Alias+" - "+Alias2;
									dataViajesNormales.Rows[y].Cells[18].Value = Alias+" - "+Alias2;;
								}
								
								if(x != y){									
									if((Convert.ToDouble(dataViajesNormales.Rows[y].Cells[14].Value))>=(Convert.ToDouble(dataViajesNormales.Rows[x].Cells[14].Value))){
										dataViajesNormales.Rows.RemoveAt(x);
										if(x>0)
										    --x;
									}else{											
										dataViajesNormales.Rows.RemoveAt(y);
										if(x>0){
											--y;
											break;
										}
									}										
								}
							}
						}else{
							if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)
						    &&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(SubEmpresa==SubEmpresa2))
							{
								dataViajesNormales.Rows[y].Cells[0].Value = "Completo";
								dataViajesNormales.Rows[x].Cells[0].Value = "Completo";
								dataViajesNormales.Rows[y].Cells[5].Value = "E/S";
								dataViajesNormales.Rows[x].Cells[5].Value = "E/S";
								dataViajesNormales.Rows[y].Cells[4].Value = RutaViajeNormal2+" - "+RutaViajeNormal;
								dataViajesNormales.Rows[x].Cells[4].Value = RutaViajeNormal2+" - "+RutaViajeNormal;
								dataViajesNormales.Rows[y].Cells[0].Style.BackColor=Color.LimeGreen;
								dataViajesNormales.Rows[x].Cells[0].Style.BackColor=Color.LimeGreen;
								
								if(dataViajesNormales.Rows[y].Cells[18].Value.ToString() != dataViajesNormales.Rows[x].Cells[18].Value.ToString()){
									dataViajesNormales.Rows[x].Cells[18].Value = Alias+" - "+Alias2;
									dataViajesNormales.Rows[y].Cells[18].Value = Alias+" - "+Alias2;;
								}
								
								if(x != y){									
									if((Convert.ToDouble(dataViajesNormales.Rows[y].Cells[14].Value))>=(Convert.ToDouble(dataViajesNormales.Rows[x].Cells[14].Value))){
										dataViajesNormales.Rows.RemoveAt(x);
										if(x>0)
										    --x;
									}else{											
										dataViajesNormales.Rows.RemoveAt(y);
										if(x>0){
											--y;
											break;
										}
									}										
								}
							}
						}						
					}
				}
			}
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
		}
		
		private void limpiar(){
			cbEmpresa.SelectedIndex = -1;
			cbTurno.SelectedIndex = -1;
			dtpIncio.Value = DateTime.Now;
			dateTimePicker1.Value = DateTime.Now;
		}
		
		private void cargaCbEmpresa()
		{
			string consulta = "SELECT Empresa FROM Cliente GROUP BY Empresa order by empresa";
			cbEmpresa.Items.Clear();			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				cbEmpresa.Items.Add(conn.leer["Empresa"].ToString());
				dtConteo.Rows.Add(conn.leer["Empresa"].ToString(), "0", "0", "0");
			}
			conn.conexion.Close();
			cbEmpresa.Items.Add("GUARDIAS");
			cbEmpresa.Items.Add("APOYOS");
			cbEmpresa.Items.Add("CANCELACION PUNTO");
			cbEmpresa.Items.Add("PRUEBA RENDIMIENTO");
			cbEmpresa.Items.Add("RECONOCIMIENTOS");
			dtConteo.Rows.Add("APOYOS", "0", "0", "0");
			dtConteo.Rows.Add("CANCELACION PUNTO", "0", "0", "0");
			dtConteo.Rows.Add("PRUEBA RENDIMIENTO", "0", "0", "0");
			dtConteo.Rows.Add("RECONOCIMIENTOS", "0", "0", "0");
			cbEmpresa.SelectedIndex = -1;
		}		
		
		private void limpiaContador(){
			txtTotal.Text = "0";
			txtCompleto.Text = "0";
			txtSencillo.Text = "0";
			for(int y = 0; y<(dtConteo.RowCount); y++){
				dtConteo.Rows[y].Cells[1].Value = "0";
				dtConteo.Rows[y].Cells[2].Value = "0";
				dtConteo.Rows[y].Cells[3].Value = "0";
			}			
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}		
		#endregion	
		
		#region FILTROS - ADAPTADOR NORMALES
		private void fitrosPrincipales(){
			String Conss = @"select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato,
			                OO.vehiculo as Vehiculo, O.llegada, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.HORA_LLEGADA, R.kilometros, R.foranea, OP.alias                                                  
                            from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe
                            where O.Estatus = '1' and C.ID = R.IdSubEmpresa and R.ID = O.id_ruta and O.id_operacion=OO.id_operacion
                            and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID and O.fecha between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dateTimePicker1.Value.ToShortDateString()+"'";
			if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and r.turno = '"+cbTurno.Text+"'";			
			if(cbEmpresa.SelectedIndex > -1)
				Conss = Conss + " and C.Empresa = '"+cbEmpresa.Text+"'";
			if(rbCombustible.Checked == true)
				Conss = Conss + " and op.ID in (select id from OPERADOR where tipo_empleado = 'OPERADOR' and id not in(167))";
			Conss = Conss + " order by O.fecha, R.Nombre ";
			
			limpiaContador();			
			dataViajesNormales.Rows.Clear();			
			ColoresAlternadosRows(dataViajesNormales);
			contadoVV = 0;
			AdaptadorNormales(Conss);
			ValidarViajes0();
			ValidarViajes();
			dataViajesNormales.ClearSelection();			
		}		
		
		private void AdaptadorNormales(String sentencia){			
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataViajesNormales.Rows.Add();
				dataViajesNormales.Rows[contadoVV].Cells[0].Value = "Sencillo";
				dataViajesNormales.Rows[contadoVV].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dataViajesNormales.Rows[contadoVV].Cells[2].Value = conn.leer["Empresa"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[3].Value = conn.leer["SubNombre"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[4].Value = conn.leer["Ruta"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[5].Value = conn.leer["Sentido"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[6].Value = conn.leer["Turno"].ToString();
				if(conn.leer["Viaje"].ToString().Contains("CAMIONETAS")==true)
					dataViajesNormales.Rows[contadoVV].Cells[7].Value = "CAMIONETA";
				else
					dataViajesNormales.Rows[contadoVV].Cells[7].Value = "CAMION";
				dataViajesNormales.Rows[contadoVV].Cells[8].Value = conn.leer["Vehiculo"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[9].Value = conn.leer["tipo"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[10].Value = conn.leer["Dato"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[11].Value = conn.leer["Velada"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[12].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[13].Value = conn.leer["HORA_LLEGADA"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[14].Value = conn.leer["kilometros"].ToString();				
				dataViajesNormales.Rows[contadoVV].Cells[15].Value = conn.leer["foranea"].ToString();
				dataViajesNormales.Rows[contadoVV].Cells[16].Value = "";
				dataViajesNormales.Rows[contadoVV].Cells[17].Value = new Transportes_LAR.Proceso.Semana().SemanaAno(Convert.ToDateTime(conn.leer["Fecha"]));
				dataViajesNormales.Rows[contadoVV].Cells[18].Value = conn.leer["alias"].ToString();
				++contadoVV;
			}
			conn.conexion.Close();
			dataViajesNormales.AutoSize = true;		
		}		
		#endregion		
		
		#region FILTROS - ADAPTADOR RECONOCIMIENTOS
		private void fitrosReconocimientos(){
			String Conss = @"select op.alias, RR.ID, RR.ID_RUTA, RR.ID_OPERADOR, RR.ID_OP_MUESTRA, C.Empresa as Empresa, R.Nombre as Ruta, RR.turno As Turno, RR.DIA
			                from CLIENTE C, RUTA R, OPERADOR OP, RECONOCIMIENTO_RUTA RR
			                where C.ID = R.IdSubEmpresa and R.ID=RR.ID_RUTA and OP.ID=RR.ID_OPERADOR and C.Empresa!='Especiales' 
							and RR.DIA between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dateTimePicker1.Value.ToShortDateString()+"' ";	
			if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and r.turno = '"+cbTurno.Text+"'";
			if(rbCombustible.Checked == true)
				Conss = Conss + " and op.ID in (select id from OPERADOR where tipo_empleado = 'OPERADOR' and id not in(167))";			
			Conss = Conss + "  order by RR.DIA";
			
			if(cbEmpresa.SelectedIndex == -1 || cbEmpresa.Text == "RECONOCIMIENTOS"){
				AdaptadorReconocimientos(Conss);	
			}else{				
				dataReconocimientos.Rows.Clear();			
			}		
		}
		
		private void AdaptadorReconocimientos(string consulta)
		{
			int contador = 0;
			dataReconocimientos.Rows.Clear();			
			ColoresAlternadosRows(dataReconocimientos);
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataReconocimientos.Rows.Add();
				dataReconocimientos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataReconocimientos.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				dataReconocimientos.Rows[contador].Cells[2].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataReconocimientos.Rows[contador].Cells[3].Value = conn.leer["ID_OPERADOR"].ToString();
				dataReconocimientos.Rows[contador].Cells[4].Value = conn.leer["ID_OP_MUESTRA"].ToString();
				dataReconocimientos.Rows[contador].Cells[5].Value = conn.leer["Empresa"].ToString();
				dataReconocimientos.Rows[contador].Cells[6].Value = conn.leer["Ruta"].ToString();
				dataReconocimientos.Rows[contador].Cells[7].Value = conn.leer["Turno"].ToString();
				dataReconocimientos.Rows[contador].Cells[8].Value = "";
				dataReconocimientos.Rows[contador].Cells[9].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataReconocimientos.AutoSize = true;
			if(dataReconocimientos.RowCount <=0 ){
				dataReconocimientos.Visible = false;
				lblReconocimiento.Visible = false;
			}else{
				dataReconocimientos.Visible = true;
				lblReconocimiento.Visible = true;
			}			
			dataReconocimientos.ClearSelection();			
		}
		
		#endregion
		
		#region FILTROS - ADAPTADOR GUARDIAS
		private void fitrosGuardias(){
			String Conss = @"select OP.alias, G.ID, C.Empresa as Empresa, G.turno As Turno, G.DIA, G.TIPO from CLIENTE C, OPERADOR OP, GUARDIA G
			                where C.ID=G.ID_SUBEMPRESA and OP.ID=G.ID_OPERADOR and C.Empresa!='Especiales' and G.DIA 
							between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dateTimePicker1.Value.ToShortDateString()+"' ";
			if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and g.turno = '"+cbTurno.Text+"'";
			if(rbCombustible.Checked == true)
				Conss = Conss + " and op.ID in (select id from OPERADOR where tipo_empleado = 'OPERADOR' and id not in(167))";
			if(cbEmpresa.SelectedIndex == -1 || cbEmpresa.Text == "GUARDIAS"){
				AdaptadorGuardia(Conss);	
			}else{				
				dataGuardia.Rows.Clear();			
			}		
		}
		
		void AdaptadorGuardia(string consulta)
		{
			int contador = 0;
			dataGuardia.Rows.Clear();
			ColoresAlternadosRows(dataGuardia);		
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataGuardia.Rows.Add();
				dataGuardia.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataGuardia.Rows[contador].Cells[1].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataGuardia.Rows[contador].Cells[2].Value = conn.leer["Empresa"].ToString();
				dataGuardia.Rows[contador].Cells[4].Value = conn.leer["Turno"].ToString();
				dataGuardia.Rows[contador].Cells[3].Value = conn.leer["TIPO"].ToString();
				dataGuardia.Rows[contador].Cells[5].Value = 0;
				dataGuardia.Rows[contador].Cells[6].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataGuardia.AutoSize=true;
			if(dataGuardia.RowCount<=0){
				dataGuardia.Visible = false;
				lblGuardia.Visible = false;
			}else{
				dataGuardia.Visible = true;
				lblGuardia.Visible = true;
			}
			dataGuardia.ClearSelection();
		}
		#endregion
				
		#region FILTROS - ADAPTADOR PRUEBA RENDIMIENTO
		private void fitrosRendimiento(){
			String Conss = @"select op.alias, P.ID_PR, P.ID_RUTA, P.ID_OPERADOR, P.ID_OP_SUPERVISOR, R.Nombre, R.CompletoCamion, P.turno, P.DIA 
			                from RUTA R, OPERADOR OP, PRUEBA_RENDIMIENTO P, cliente c where c.id = r.IdSubEmpresa and R.ID = P.ID_RUTA and OP.ID = P.ID_OPERADOR 
							and P.DIA between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dateTimePicker1.Value.ToShortDateString()+"' ";
			if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and p.turno = '"+cbTurno.Text+"'";
			if(rbCombustible.Checked == true)
				Conss = Conss + " and op.ID in (select id from OPERADOR where tipo_empleado = 'OPERADOR' and id not in(167))";		
			Conss = Conss + "  order by p.DIA";
			
			if(cbEmpresa.SelectedIndex == -1 || cbEmpresa.Text == "PRUEBA RENDIMIENTO"){
				AdaptadorPRendimiento(Conss);	
			}else{				
				dataRendimiento.Rows.Clear();			
			}		
		}
		
		void AdaptadorPRendimiento(string consulta)
		{
			int contador = 0;
			dataRendimiento.Rows.Clear();
			ColoresAlternadosRows(dataRendimiento);		
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataRendimiento.Rows.Add();
				dataRendimiento.Rows[contador].Cells[0].Value = conn.leer["ID_PR"].ToString();
				dataRendimiento.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				dataRendimiento.Rows[contador].Cells[2].Value = conn.leer["ID_OPERADOR"].ToString();
				dataRendimiento.Rows[contador].Cells[3].Value = conn.leer["ID_OP_SUPERVISOR"].ToString();
				dataRendimiento.Rows[contador].Cells[4].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataRendimiento.Rows[contador].Cells[5].Value = conn.leer["Nombre"].ToString();
				dataRendimiento.Rows[contador].Cells[6].Value = conn.leer["turno"].ToString();
				dataRendimiento.Rows[contador].Cells[7].Value = "";
				dataRendimiento.Rows[contador].Cells[8].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataRendimiento.AutoSize=true;
			if(dataRendimiento.RowCount <= 0){
				dataRendimiento.Visible = false;
				lblPruebas.Visible = false;
			}else{
				dataRendimiento.Visible = true;
				lblPruebas.Visible = true;
			}
			dataRendimiento.ClearSelection();
		} 
		
		
		#endregion		
		
		#region FILTROS - ADAPTADOR CANCELACION PUNTO
		private void fitrosCancelaP(){
			String Conss = @"select op.alias, CP.ID, CP.ID_RUTA, R.Nombre, CP.turno, CP.Fecha from RUTA R, OPERADOR OP, CANCELACION_PUNTO CP, cliente c
			                 where c.id = r.IdSubEmpresa and R.ID=CP.ID_RUTA and OP.ID=CP.ID_OPERADOR and CP.Fecha
							 between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dateTimePicker1.Value.ToShortDateString()+"' ";
			if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and r.turno = '"+cbTurno.Text+"'";
			if(rbCombustible.Checked == true)
				Conss = Conss + " and op.ID in (select id from OPERADOR where tipo_empleado = 'OPERADOR' and id not in(167))";	
			Conss = Conss + "  order by CP.Fecha";
			
			if(cbEmpresa.SelectedIndex == -1 || cbEmpresa.Text == "CANCELACION PUNTO"){
				AdaptadorCancelacion(Conss);	
			}else{				
				dataCancelacion.Rows.Clear();			
			}		
		}
		
		void AdaptadorCancelacion(string consulta)
		{
			int contador = 0;
			dataCancelacion.Rows.Clear();
			ColoresAlternadosRows(dataCancelacion);		
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataCancelacion.Rows.Add();
				dataCancelacion.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataCancelacion.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				dataCancelacion.Rows[contador].Cells[2].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dataCancelacion.Rows[contador].Cells[3].Value = conn.leer["Nombre"].ToString();
				dataCancelacion.Rows[contador].Cells[4].Value = conn.leer["turno"].ToString();
				dataCancelacion.Rows[contador].Cells[5].Value = "";
				dataCancelacion.Rows[contador].Cells[6].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			dataCancelacion.AutoSize = true;
			if(dataCancelacion.RowCount <= 0){
				dataCancelacion.Visible = false;
				lblCancelacion.Visible = false;
			}else{
				dataCancelacion.Visible = true;
				lblCancelacion.Visible = true;
			}
			dataCancelacion.ClearSelection();
		}	
		#endregion		
	
		#region FILTROS - ADAPTADOR APOYOS
		private void fitrosApoyos(){
			String Conss = @"select o.alias, A.ID, A.ID_OP_APOYO, A.turno, A.DIA, A.TIPO, A.COMENTARIOS, A.ID_RUTA from APOYOS A, ruta r, cliente c, operador o, usuario u, VALOR_IMPORTE_APOYOS via
		 					where via.TAMANO = a.TIPO and a.ID_U = u.id_usuario and a.ID_RUTA = r.ID and r.IdSubEmpresa = c.ID and a.ID_OP_APOYO = o.ID and  a.DIA 
							between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dateTimePicker1.Value.ToShortDateString()+"' ";
			if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and a.turno = '"+cbTurno.Text+"'";
			if(rbCombustible.Checked == true)
				Conss = Conss + " and o.ID in (select id from OPERADOR where tipo_empleado = 'OPERADOR' and id not in(167))";			
			Conss = Conss + "  order by a.dia";
			
			if(cbEmpresa.SelectedIndex == -1 || cbEmpresa.Text == "APOYOS"){
				AdaptadorApoyos(Conss);	
			}else{				
				dataApoyos.Rows.Clear();			
			}		
		}

		void AdaptadorApoyos(string consulta)
		{
			int contador = 0;			
			dataApoyos.Rows.Clear();			
			ColoresAlternadosRows(dataApoyos);
			try{
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dataApoyos.Rows.Add();
					dataApoyos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataApoyos.Rows[contador].Cells[2].Value = conn.leer["ID_OP_APOYO"].ToString();
					dataApoyos.Rows[contador].Cells[3].Value = conn.leer["DIA"].ToString().Substring(0,10);
					dataApoyos.Rows[contador].Cells[5].Value = conn.leer["turno"].ToString();
					dataApoyos.Rows[contador].Cells[6].Value = conn.leer["TIPO"].ToString();
					dataApoyos.Rows[contador].Cells[7].Value = conn.leer["COMENTARIOS"].ToString();
					dataApoyos.Rows[contador].Cells[8].Value = "";
					dataApoyos.Rows[contador].Cells[9].Value = conn.leer["alias"].ToString();				
					++contador;
				}
			}
			catch{}
			conn.conexion.Close();
			
			dataApoyos.AutoSize = true;
			if(dataApoyos.RowCount <= 0){
				dataApoyos.Visible = false;
				lblApoyo.Visible = false;
			}else{
				dataApoyos.Visible = true;
				lblApoyo.Visible = true;
			}			
			dataApoyos.ClearSelection();
		}		
		#endregion		
		
		#region EVENTOS
		void LbEmpresaClick(object sender, EventArgs e)
		{
			cbEmpresa.SelectedIndex = -1;
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			cbTurno.SelectedIndex = -1;
		}
		#endregion
	}
}
