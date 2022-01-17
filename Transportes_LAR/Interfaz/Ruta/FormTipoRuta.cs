using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta
{
	public partial class FormTipoRuta : Form
	{
		
		#region CONSTRUCTOR		
		public FormTipoRuta(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();			
			this.principal = principal;
		}
		#endregion
		
		#region INSTANCIAS_DE_OBJETOS		
		public Interfaz.FormPrincipal principal = null;	
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();		
		private Conexion_Servidor.Ruta.SQL_Ruta connr= new Conexion_Servidor.Ruta.SQL_Ruta();
		public 	Interfaz.Ruta.Complemento_Cambio_ruta.FormExtraANormal formNomaExtra = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();	
		#endregion
		
		#region	CONTROL_DE_VENTANAS_ABIERTAS	
		public bool estra_normal = false;
		#endregion
		
		#region VARIABLES
		int idRutaExtra = 0 ;	
		int indexTablaExtra = -1;
		
		int idRutaNormal = 0 ;	
		int indexTablaNormal = -1;
		#endregion		
				
		#region ADAPTADOR
		public void adaptadorNRM(String consulta){			
			ColoresAlternadosRows(dtRutaNRM);
			dtRutaNRM.Rows.Clear();			
			int contador = 0;
			try{
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dtRutaNRM.Rows.Add();
					dtRutaNRM.Rows[contador].Cells[0].Value = conn.leer["id"].ToString();
					dtRutaNRM.Rows[contador].Cells[1].Value = conn.leer["nombre"].ToString();
					dtRutaNRM.Rows[contador].Cells[2].Value = conn.leer["Turno"].ToString();
					dtRutaNRM.Rows[contador].Cells[3].Value = conn.leer["HoraInicio"].ToString();
					dtRutaNRM.Rows[contador].Cells[4].Value = conn.leer["HORA_LLEGADA"].ToString();
					dtRutaNRM.Rows[contador].Cells[5].Value = conn.leer["Dia"].ToString().Substring(1,conn.leer["Dia"].ToString().Length-1);
					dtRutaNRM.Rows[contador].Cells[6].Value = conn.leer["Sentido"].ToString();
					dtRutaNRM.Rows[contador].Cells[7].Value = conn.leer["Kilometros"].ToString();
					dtRutaNRM.Rows[contador].Cells[8].Value = conn.leer["Tipo"].ToString();
					dtRutaNRM.Rows[contador].Cells[9].Value = conn.leer["Empresa"].ToString();
					dtRutaNRM.Rows[contador].Cells[10].Value = conn.leer["tipo_cobro"].ToString();
					dtRutaNRM.Rows[contador].Cells[11].Value = conn.leer["SubNombre"].ToString();

					++contador;
				}
				conn.conexion.Close();
				dtRutaNRM.ClearSelection();
			}catch(Exception){
				
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
		}
		
		public void adaptadorEXT(String consulta){	
			ColoresAlternadosRows(dtRutaEXT);
			dtRutaEXT.Rows.Clear();		
			int contador = 0;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dtRutaEXT.Rows.Add();
				dtRutaEXT.Rows[contador].Cells[0].Value = conn.leer["id"].ToString();
				dtRutaEXT.Rows[contador].Cells[1].Value = conn.leer["nombre"].ToString();
				dtRutaEXT.Rows[contador].Cells[2].Value = conn.leer["Turno"].ToString();
				dtRutaEXT.Rows[contador].Cells[3].Value = conn.leer["Sentido"].ToString();
				dtRutaEXT.Rows[contador].Cells[4].Value = conn.leer["Kilometros"].ToString();
				dtRutaEXT.Rows[contador].Cells[5].Value = conn.leer["extra"].ToString();
				dtRutaEXT.Rows[contador].Cells[6].Value = conn.leer["Empresa"].ToString();
				dtRutaEXT.Rows[contador].Cells[7].Value = conn.leer["tipo_cobro"].ToString();
				dtRutaEXT.Rows[contador].Cells[8].Value = conn.leer["SubNombre"].ToString();
				++contador;
			}
			conn.conexion.Close();			
			dtRutaEXT.ClearSelection();
		}
		#endregion
		
		#region INICIO
		void FormTipoRutaLoad(object sender, EventArgs e)
		{
			filtros();
			limpiarVariables();
			txtNombreRuta.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Nombre from RUTA", "Nombre");
           	txtNombreRuta.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreRuta.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            txtEmpresa.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Empresa from Cliente where Empresa != 'Especiales' ", "Empresa");
           	txtEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            dtInicio.Value=DateTime.Now;
            dtCorte.MinDate = dtInicio.Value;	      
		}
		#endregion
		
		#region BOTONES		
		void BtnDesignarOperadorClick(object sender, EventArgs e)
		{
			if(indexTablaExtra > -1){
				if(this.estra_normal==true)
				{
					if(formNomaExtra.WindowState==FormWindowState.Minimized)
						formNomaExtra.WindowState = FormWindowState.Maximized;
					else
						formNomaExtra.BringToFront();
				}
				else
				{					
					this.formNomaExtra = new Transportes_LAR.Interfaz.Ruta.Complemento_Cambio_ruta.FormExtraANormal(this, idRutaExtra, Convert.ToString(dtRutaEXT.Rows[indexTablaExtra].Cells[1].Value), Convert.ToString(dtRutaEXT.Rows[indexTablaExtra].Cells[6].Value), Convert.ToString(dtRutaEXT.Rows[indexTablaExtra].Cells[2].Value), Convert.ToString(dtRutaEXT.Rows[indexTablaExtra].Cells[7].Value),  principal.idUsuario);
					formNomaExtra.BringToFront();
					this.formNomaExtra.Show();
					this.estra_normal=true;
				}
			}else{
				MessageBox.Show("Selecciona una Ruta extra para convertirla en normal", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
			}
		}
		#endregion
		
		#region EVENTOS TABLAS	
		void DtRutaEXTCellClick(object sender, DataGridViewCellEventArgs e)
		{
			indexTablaExtra = e.RowIndex;			
			if(e.RowIndex >=0)
				idRutaExtra = Convert.ToInt32(dtRutaEXT.Rows[e.RowIndex].Cells[0].Value);	
		}
		
		void DtRutaNRMCellClick(object sender, DataGridViewCellEventArgs e)
		{
			indexTablaNormal = e.RowIndex;			
			if(e.RowIndex >=0)
				idRutaNormal = Convert.ToInt32(dtRutaNRM.Rows[e.RowIndex].Cells[0].Value);	
			
		}
		#endregion	
		
		#region MENU ELIMINAR		
		void EliminarRutaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(indexTablaNormal > -1){
				DialogResult boton1 = MessageBox.Show("Desea Eliminar esta ruta : "+Convert.ToString(dtRutaNRM.Rows[indexTablaNormal].Cells[0].Value)+ " - "+Convert.ToString(dtRutaNRM.Rows[indexTablaNormal].Cells[1].Value)+" - "+Convert.ToString(dtRutaNRM.Rows[indexTablaNormal].Cells[2].Value)+" - "+Convert.ToString(dtRutaNRM.Rows[indexTablaNormal].Cells[6].Value)+" - "+Convert.ToString(dtRutaNRM.Rows[indexTablaNormal].Cells[9].Value), "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{					
					connr.eliminarRuta(idRutaNormal,  principal.idUsuario);
					limpiarVariables();
					dtRutaEXT.ClearSelection();
					dtRutaNRM.ClearSelection();
				}else{
					limpiarVariables();
					dtRutaEXT.ClearSelection();
					dtRutaNRM.ClearSelection();
				}				
			}else{
				MessageBox.Show("Selecciona una Ruta a eliminar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion		
		
		#region METODOS
		public void limpiarVariables(){
			idRutaExtra = 0 ;	
			indexTablaExtra = -1;		
			idRutaNormal = 0 ;	
			indexTablaNormal = -1;
			filtros();
		}
		
		public void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}	
		
		public void filtros(){	
			
			String consultaNRM = @"select c.SubNombre, r.HoraInicio, r.HORA_LLEGADA, r.Dia, r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
									from RUTA r, Cliente c
									where dia!='10000000' AND C.ID = R.IdSubEmpresa AND (Tipo != 'EXT' and Tipo != 'ESP' and Tipo != 'Cancelada' )";
			
			String consultaEXT = @"select c.SubNombre, R.id, R.nombre, R.Turno, R.Sentido, R.Kilometros, R.Tipo, R.extra, C.Empresa, C.tipo_cobro
			                      from RUTA R, CLIENTE C
			                      where C.ID=R.IdSubEmpresa AND (R.Tipo in ('EXT', 'DOM') ) and R.Tipo!='ESP'and R.extra between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"' ";
				
			
			if(txtEmpresa.Text.Length != 0){
				consultaNRM = consultaNRM + " and c.Empresa = '"+txtEmpresa.Text+"'";
				consultaEXT = consultaEXT + " and c.Empresa = '"+txtEmpresa.Text+"'";
			}
			
			if(txtNombreRuta.Text.Length != 0){
				consultaNRM = consultaNRM + " and r.Nombre = '"+txtNombreRuta.Text+"'";
				consultaEXT = consultaEXT + " and r.Nombre = '"+txtNombreRuta.Text+"'";
			}
			
			if(cbTurnoRuta.Text.Length != 0){
				consultaNRM = consultaNRM + " and Turno = '"+cbTurnoRuta.Text+"'";
				consultaEXT = consultaEXT + " and Turno = '"+cbTurnoRuta.Text+"'";
			}		
			
			adaptadorNRM(consultaNRM + "order by NOMBRE");				
			adaptadorEXT(consultaEXT + "order by R.NOMBRE");			
			
			#region Antiguos filtros	
			//Quite forsac 			
			/*
			switch(cbEliminadasNRM.Checked){
				case false:				
										
					if(txtNombreRuta.Text.Length == 0 && cbTurnoRuta.Text.Length == 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia!='10000000' AND C.ID = R.IdSubEmpresa AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
				
						adaptadorEXT(@"select R.id, R.nombre, R.Turno, R.Sentido, R.Kilometros, R.Tipo, R.extra, C.Empresa, C.tipo_cobro
			                      from RUTA R, CLIENTE C
			                      where C.ID=R.IdSubEmpresa AND R.Tipo='EXT' and R.Tipo!='ESP' and R.extra between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"' order by R.NOMBRE");			
					}
					if(txtNombreRuta.Text.Length != 0 && cbTurnoRuta.Text.Length == 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia!='10000000' AND C.ID = R.IdSubEmpresa and r.NOMBRE = '"+txtNombreRuta.Text+"' AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
				
						adaptadorEXT(@"select R.id, R.nombre, R.Turno, R.Sentido, R.Kilometros, R.Tipo, R.extra, C.Empresa, C.tipo_cobro
			                      from RUTA R, CLIENTE C
			                      where C.ID=R.IdSubEmpresa AND R.Tipo='EXT' and R.Tipo!='ESP' and R.NOMBRE = '"+txtNombreRuta.Text+"' and R.extra between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"' order by R.NOMBRE");			
					}	
					if(txtNombreRuta.Text.Length == 0 && cbTurnoRuta.Text.Length != 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia!='10000000' AND C.ID = R.IdSubEmpresa and r.Turno = '"+cbTurnoRuta.Text+"' AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
				
						adaptadorEXT(@"select R.id, R.nombre, R.Turno, R.Sentido, R.Kilometros, R.Tipo, R.extra, C.Empresa, C.tipo_cobro
			                      from RUTA R, CLIENTE C
			                      where C.ID=R.IdSubEmpresa AND R.Tipo='EXT' and R.Tipo!='ESP' and R.Turno = '"+cbTurnoRuta.Text+"' and R.extra between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"' order by R.NOMBRE");			
					}
					
					if(txtNombreRuta.Text.Length != 0 && cbTurnoRuta.Text.Length != 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia!='10000000' AND C.ID = R.IdSubEmpresa and r.NOMBRE = '"+txtNombreRuta.Text+"' and r.Turno = '"+cbTurnoRuta.Text+"' AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
				
						adaptadorEXT(@"select R.id, R.nombre, R.Turno, R.Sentido, R.Kilometros, R.Tipo, R.extra, C.Empresa, C.tipo_cobro
			                      from RUTA R, CLIENTE C
			                      where C.ID=R.IdSubEmpresa AND R.Tipo='EXT' and R.Tipo!='ESP' and R.NOMBRE = '"+txtNombreRuta.Text+"' and r.Turno = '"+cbTurnoRuta.Text+"' and R.extra between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"' order by R.NOMBRE");			
					}
				break;
				
			case true:				
					if(txtNombreRuta.Text.Length == 0 && cbTurnoRuta.Text.Length == 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia = '10000000' AND C.ID = R.IdSubEmpresa AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");				
					}
					if(txtNombreRuta.Text.Length != 0 && cbTurnoRuta.Text.Length == 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia = '10000000' AND C.ID = R.IdSubEmpresa and r.NOMBRE = '"+txtNombreRuta.Text+"' AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
					}	
					if(txtNombreRuta.Text.Length == 0 && cbTurnoRuta.Text.Length != 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia = '10000000' AND C.ID = R.IdSubEmpresa and r.Turno = '"+cbTurnoRuta.Text+"' AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
					}
					
					if(txtNombreRuta.Text.Length != 0 && cbTurnoRuta.Text.Length != 0 ){
						adaptadorNRM(@"select r.id, r.nombre, r.Turno, r.Sentido, r.Kilometros, r.Tipo, C.Empresa, C.tipo_cobro
			                      from RUTA r, Cliente c
			                      where dia = '10000000' AND C.ID = R.IdSubEmpresa and r.NOMBRE = '"+txtNombreRuta.Text+"' and r.Turno = '"+cbTurnoRuta.Text+"' AND (Tipo != 'EXT' and Tipo != 'ESP') order by NOMBRE");
					}
					break;
			}
			*/
			#endregion
		}
		#endregion
		
		#region EVENTOS DE TEXTBOX, COMBOBOX, CHECKBOX y DATAPICKER		
		void TxtNombreRutaKeyUp(object sender, KeyEventArgs e)
		{
			filtros();
		}
		
		void TxtEmpresaKeyUp(object sender, KeyEventArgs e)
		{
			filtros();
		}
		
		void CbTurnoRutaTextChanged(object sender, EventArgs e)
		{			
			filtros();			
		}
		
		void CbEliminadasNRMCheckedChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void CbTurnoRutaSelectedIndexChanged(object sender, EventArgs e)
		{
			filtros();			
		}		
		
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			dtCorte.MinDate = dtInicio.Value;	    
			filtros();	
		}
		
		void DtCorteValueChanged(object sender, EventArgs e)
		{			   
			filtros();	
		}
		#endregion			
	}
}
