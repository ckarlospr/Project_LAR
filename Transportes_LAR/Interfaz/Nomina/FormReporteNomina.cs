using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormReporteNomina : Form
	{
		#region CONSTRUCTOR
		public FormReporteNomina(FormPrincipal refp)
		{
			InitializeComponent();
			refPricipal = refp;
		}		
		#endregion
		
		#region VARIABLES
		int acumulador = 0;
		int progreso = 1;
		#endregion
		
		#region INSTANCIAS
		private FormPrincipal refPricipal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();	
		#endregion		
		
		#region INICIO - FIN
		void FormReporteNominaLoad(object sender, EventArgs e)
		{
			cargaCbEmpresa();
		}
		
		void FormReporteNominaFormClosing(object sender, FormClosingEventArgs e)
		{
			refPricipal.reporten = false;
		}
		#endregion
				
		#region BOTONES		
		void BntBuscarClick(object sender, EventArgs e)
		{
			fitrosPrincipales();
		}
			
		void LblLimpiarClick(object sender, EventArgs e)
		{
			limpiar();
		}
		#endregion
		
		#region FILTROS - ADAPTADOR		
		private void fitrosPrincipales(){
			String Conss = @"select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato, 
			                OO.vehiculo as Vehiculo, O.llegada, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.HORA_LLEGADA, R.kilometros, R.foranea, OP.alias                                                   
                            from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe 
							where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID 
							and C.Empresa!='Especiales' and O.fecha between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dtpFin.Value.ToShortDateString()+"' ";			
			
						if(cbTurno.SelectedIndex > -1)
				Conss = Conss + " and r.turno = '"+cbTurno.Text+"'";
			if(cbEmpresa.SelectedIndex > -1)
				Conss = Conss + " and C.Empresa = '"+cbEmpresa.Text+"'";
			
			Conss = Conss + " order by O.fecha, R.Nombre ";
			limpiaContador();
			AdaptadorNormales(Conss);
		}		
		
		private void AdaptadorNormales(String sentencia)
		{
			/*String sentencia = "select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, " +
		                      	"O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato, " +
			                        "OO.vehiculo as Vehiculo, O.llegada, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.HORA_LLEGADA, R.kilometros, R.foranea, OP.alias "+                                                   
                               		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe "+
                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                    "and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID and C.Empresa!='Especiales' and " +
									"O.fecha between '"+dtpIncio.Value.ToShortDateString()+"' AND '"+dtpFin.Value.ToShortDateString()+"'" +
                                    "order by O.fecha, R.Nombre ";*/
			int contador = 0;
			dataViajesNormales2.Rows.Clear();			
			ColoresAlternadosRows(dataViajesNormales2);
			
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataViajesNormales2.Rows.Add();
				dataViajesNormales2.Rows[contador].Cells[0].Value = "Sencillo";
				dataViajesNormales2.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dataViajesNormales2.Rows[contador].Cells[2].Value = conn.leer["Empresa"].ToString();
				dataViajesNormales2.Rows[contador].Cells[3].Value = conn.leer["SubNombre"].ToString();
				dataViajesNormales2.Rows[contador].Cells[4].Value = conn.leer["Ruta"].ToString();
				dataViajesNormales2.Rows[contador].Cells[5].Value = conn.leer["Sentido"].ToString();
				dataViajesNormales2.Rows[contador].Cells[6].Value = conn.leer["Turno"].ToString();
				dataViajesNormales2.Rows[contador].Cells[8].Value = conn.leer["Vehiculo"].ToString();
				dataViajesNormales2.Rows[contador].Cells[9].Value = conn.leer["tipo"].ToString();
				dataViajesNormales2.Rows[contador].Cells[10].Value = conn.leer["Dato"].ToString();
				if(conn.leer["Nombre"].ToString().Contains("CAMIONETAS") == true)
					dataViajesNormales2.Rows[contador].Cells[7].Value = "CAMIONETA";
				else
					dataViajesNormales2.Rows[contador].Cells[7].Value = "CAMION";
				dataViajesNormales2.Rows[contador].Cells[11].Value = conn.leer["Velada"].ToString();
				dataViajesNormales2.Rows[contador].Cells[12].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales2.Rows[contador].Cells[13].Value = conn.leer["HORA_LLEGADA"].ToString();
				dataViajesNormales2.Rows[contador].Cells[14].Value = conn.leer["llegada"].ToString();				
				dataViajesNormales2.Rows[contador].Cells[15].Value = conn.leer["kilometros"].ToString();
				dataViajesNormales2.Rows[contador].Cells[16].Value = conn.leer["foranea"].ToString();
				dataViajesNormales2.Rows[contador].Cells[17].Value = new Transportes_LAR.Proceso.Semana().SemanaAno(Convert.ToDateTime(conn.leer["Fecha"]));
				dataViajesNormales2.Rows[contador].Cells[18].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			ValidarViajes();
			conteoEmpresa();
			dataViajesNormales2.ClearSelection();
		}
		
		#endregion		
		
		#region METODOS		
		private void progresobarra(int x){
			refPricipal.progressbarPrin.Minimum = 1;
    		refPricipal.progressbarPrin.Maximum = 100;
    		
    		int variable;
			variable = (x/100);		
			++acumulador;
			
			if(acumulador == variable && progreso < 101){
				refPricipal.progressbarPrin.Increment(progreso);
		    	refPricipal.progressbarPrin.Value=progreso;
		    	progreso = progreso + 1;
		    	acumulador = 0;
			}
		}
		
		private void conteoEmpresa(){
			for(int x=0; x<dtConteo.Rows.Count; x++){
				for(int z=0; z<dataViajesNormales2.Rows.Count; z++){
					if(dtConteo[0,x].Value.ToString() == dataViajesNormales2[2,z].Value.ToString()){
						if(dataViajesNormales2[0,z].Value.ToString() == "Completo"){
							dtConteo[2,x].Value = (Convert.ToInt32(dtConteo[2,x].Value) + 1).ToString();
							txtCompleto.Text = (Convert.ToInt32(txtCompleto.Text) + 1).ToString();
						}							
						else if(dataViajesNormales2[0,z].Value.ToString() == "Sencillo"){
							dtConteo[1,x].Value = (Convert.ToInt32(dtConteo[1,x].Value) + 1).ToString();
							txtSencillo.Text = (Convert.ToInt32(txtSencillo.Text) + 1).ToString();
						}else{
							txtOtro.Text = (Convert.ToInt32(txtOtro.Text) + 1).ToString();
						}
						dtConteo[3,x].Value = (Convert.ToInt32(dtConteo[3,x].Value) + 1).ToString();
					}						
				}						
			}
			txtTotal.Text = (Convert.ToInt32(txtSencillo.Text) + Convert.ToInt32(txtCompleto.Text)).ToString();
		}
		
		private void ValidarViajes(){
			String FechaViajeNormal = "";
			String EmpresaViajenormal = "";
			String RutaViajeNormal = "";
			String SentidoViajeNormal = "";
			String FechaViajeNormal2 = "";
			String EmpresaViajenormal2 = "";
			String RutaViajeNormal2 = "";
			String SentidoViajeNormal2 = "";
			String TurnoViajeNormal = "";
			String TurnoViajeNormal2 = "";
			String VehiculoNormal = "";
			String VehiculoNormal2 = "";
			String Extra = "";
			String Extra2 = "";
			String SubEmpresa = "";
			String SubEmpresa2 = "";
			String Alias = "";
			String Alias2 = "";
			acumulador = 0;
			progreso = 1;

			for(int y = 0; y<(dataViajesNormales2.RowCount-1); y++){
				FechaViajeNormal = dataViajesNormales2.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales2.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dataViajesNormales2.Rows[y].Cells[4].Value.ToString();
				SentidoViajeNormal = dataViajesNormales2.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesNormales2.Rows[y].Cells[6].Value.ToString();
				VehiculoNormal = dataViajesNormales2.Rows[y].Cells[7].Value.ToString();
				Extra = dataViajesNormales2.Rows[y].Cells[9].Value.ToString();
				SubEmpresa = dataViajesNormales2.Rows[y].Cells[10].Value.ToString();
				Alias = dataViajesNormales2.Rows[y].Cells[17].Value.ToString();
				
				if(Extra == "DIF" || Extra == "EXT")
					Extra = "NRM";
				
				for(int x = 1; x<(dataViajesNormales2.RowCount); x++){
					progresobarra(dataViajesNormales2.RowCount);
					FechaViajeNormal2 = dataViajesNormales2.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales2.Rows[x].Cells[2].Value.ToString();
					RutaViajeNormal2 = dataViajesNormales2.Rows[x].Cells[4].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales2.Rows[x].Cells[5].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales2.Rows[x].Cells[6].Value.ToString();
					VehiculoNormal2 = dataViajesNormales2.Rows[x].Cells[7].Value.ToString();
					Extra2 = dataViajesNormales2.Rows[x].Cells[9].Value.ToString();
					SubEmpresa2 = dataViajesNormales2.Rows[x].Cells[10].Value.ToString();
					Alias2 = dataViajesNormales2.Rows[x].Cells[17].Value.ToString();
					
					if(Extra2 == "DIF" || Extra2 == "EXT")
						Extra2 = "NRM";
					
						if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)&&(Alias==Alias2))
						{
							if((dataViajesNormales2.Rows[y].Cells[0].Value.ToString() != "Completo") && (dataViajesNormales2.Rows[x].Cells[0].Value.ToString() != "Completo")){
								dataViajesNormales2.Rows[y].Cells[0].Value = "Completo";
								dataViajesNormales2.Rows[x].Cells[0].Value = "Completo";
								dataViajesNormales2.Rows[y].Cells[5].Value = "E/S";
								dataViajesNormales2.Rows[x].Cells[5].Value = "E/S";
								dataViajesNormales2.Rows[y].Cells[4].Value = dataViajesNormales2.Rows[x].Cells[4].Value+" - "+dataViajesNormales2.Rows[y].Cells[4].Value;
								if(x != y){
									dataViajesNormales2.Rows.RemoveAt(x);
									if(y>0)
										--x;
								}
							}
						}
				}
			}
			refPricipal.progressbarPrin.Value = refPricipal.progressbarPrin.Minimum;
		}
		
		private void limpiar(){
			cbEmpresa.SelectedIndex = -1;
			cbTurno.SelectedIndex = -1;
			dtpIncio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
		}
		
		private void cargaCbEmpresa()
		{
			string consulta = "SELECT Empresa FROM Cliente where Empresa not in ('Especiales', 'APOYOS U OTROS') GROUP BY Empresa";
			cbEmpresa.Items.Clear();			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				cbEmpresa.Items.Add(conn.leer["Empresa"].ToString());
				dtConteo.Rows.Add(conn.leer["Empresa"].ToString(), "0", "0", "0");
			}
			conn.conexion.Close();
			cbEmpresa.SelectedIndex = -1;
		}		
		
		private void limpiaContador(){
			txtTotal.Text = "0";
			txtCompleto.Text = "0";
			txtOtro.Text = "0";
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
	}
}
