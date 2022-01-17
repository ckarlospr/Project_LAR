using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Transportes_LAR.Interfaz.Operaciones;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormMovimientos : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private FormCompCombustible formComplementos;
        //Thread hiloGuarda = null;
		#endregion
		
		#region VARIABLES		
		public int idUsuario;
		List<Interfaz.Combustible.Datos.DatosMatriz> listMatrizBaseX = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormMovimientos(FormCompCombustible refComp, int id_usu)
		{
			InitializeComponent();
			formComplementos = refComp;
			idUsuario = id_usu;
		}
		#endregion
		
		#region INICIO - FIN		
		void FormMovimientosLoad(object sender, EventArgs e)
		{			
			this.txtCantidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void FormMovimientosFormClosing(object sender, FormClosingEventArgs e)
		{
		}
		#endregion
		
		#region BOTONES
		void BtnGenerarClick(object sender, EventArgs e)
		{
			AgregaPuntos();
		}
		
		void BtnValidarClick(object sender, EventArgs e)
		{
			if(dgDatos.RowCount > 0){
				ValidaPuntos();
				btnAgregar.Enabled = true;
			}
			for(int x=0; x<dgDatos.RowCount; x++){
				if(dgDatos[1,x].Style.BackColor == Color.Red)
					btnAgregar.Enabled = false;	
			}
			if(btnAgregar.Enabled == false){
				MessageBox.Show("Algunos puntos no cumplen con los parámetros establecidos revísalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			EliminaPuntos(); // PRIMERO SE DEBE DE ELIMINAR PUNTOS ANTES DE GUARDAR
			for(int x=0; x<dgDatos.RowCount; x++){
				Guardar(dgDatos[3,x].Value.ToString(), dgDatos[4,x].Value.ToString(), dgDatos[2,x].Value.ToString(), dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1), 
						dgDatos[0,x].Value.ToString());
			}
			GuardaMatrizMovimientos();
			/*
			try{
         		StartHilo();
         	}catch(Exception ex){
         		MessageBox.Show("Error al guardar los puntos "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         		StopHilo();
         	}
			btnAgregar.Enabled = false;	
			lblProceso.Text = "0/0";*/
		}
		#endregion
		
		#region METODOS
		/*
		private void StartHilo(){
		  if (hiloGuarda == null){
				EstatusHilo(false);
		        hiloGuarda = new System.Threading.Thread(GuardaMatrizMovimientos);
		        hiloGuarda.Name = "Guarda_Matriz";
		        hiloGuarda.Start();
		       	hiloGuarda.Join();
	        	if(hiloGuarda.ThreadState.ToString() == "Stopped"){
					MessageBox.Show("Se Guardo Correctamente los Puntos", "Listo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
					hiloGuarda = null;
					EstatusHilo(true);
				}		        
		   }
		}
		
		private void StopHilo(){
	        if (hiloGuarda != null){
	            hiloGuarda.Abort();
	            hiloGuarda = null;
				EstatusHilo(false);
	        }
	    }
		
		private void EstatusHilo(bool respuesta){			
			dgDatos.Enabled = respuesta;
			txtCantidad.Enabled = respuesta;
			btnAgregar.Enabled = respuesta;
			btnGenerar.Enabled = respuesta;
			btnValidar.Enabled = respuesta;
		}*/
		
		private void AgregaPuntos(){
			if(txtCantidad.Text != ""){
				dgDatos.Rows.Clear();
				for(int x=0; x<Convert.ToInt64(txtCantidad.Text); x++)
					dgDatos.Rows.Add("", "", "", "");
				dgDatos.ClearSelection();
			}
		}
		
		private void ValidaPuntos(){
			string consulta = "";
			if(dgDatos.RowCount > 0){
				for(int x=0; x<dgDatos.RowCount; x++){
					dgDatos[2,x].Value = "0";
					dgDatos[4,x].Value = "0";
					if(dgDatos[0, x].Value.ToString().Contains("TALLER")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'TALLER' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("GASOLINERIA")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'GASOLINERA' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("EMPRESA")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'EMPRESA' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("OPERADOR")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'VIVIENDA' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("ZONA")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'ZONA' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("RUTA")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'RUTA' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("OFICINA")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'OFICINA' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[0, x].Value.ToString().Contains("LAR")){
						consulta = "SELECT * FROM RELACION_UBICACION WHERE TIPO = 'LAR' AND NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' order by ESTATUS desc";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "0")
								dgDatos[3,x].Value = "RESTAURAR";
							else
								dgDatos[3,x].Value = "ACTIVO";
							dgDatos[4,x].Value = conn.leer["ID"].ToString();
						}else{
							dgDatos[3,x].Value = "NUEVO";
						}
						conn.conexion.Close();
					}
					
					if(dgDatos[3,x].Value.ToString() == "NUEVO")
						BuscarID(x);
					
				}
			}
		}
		
		private void BuscarID(int x){
			string consulta = "";
			if(dgDatos[0, x].Value.ToString().Contains("GASOLINERA")){
				consulta = "SELECT * FROM GASOLINERA where SUBNOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"' or " +
					" nombre = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())				
					dgDatos[2,x].Value = conn.leer["ID"].ToString();
				else
					dgDatos[2,x].Value = "0";
				conn.conexion.Close();
			}
			
			if(dgDatos[0, x].Value.ToString().Contains("EMPRESA")){
				consulta = "SELECT * FROM GENERAL_CLIENTE WHERE  NOMBRE = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())				
					dgDatos[2,x].Value = conn.leer["ID"].ToString();
				else
					dgDatos[2,x].Value = "0";
				conn.conexion.Close();
			}
			
			if(dgDatos[0, x].Value.ToString().Contains("OPERADOR")){
				consulta = "SELECT * FROM OPERADOR WHERE Alias = '"+dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1)+"'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())				
					dgDatos[2,x].Value = conn.leer["ID"].ToString();
				else
					dgDatos[2,x].Value = "0";
				conn.conexion.Close();
			}
			
			
			if(dgDatos[0, x].Value.ToString().Contains("RUTA")){
				String value = dgDatos[1,x].Value.ToString().Substring(0, dgDatos[1,x].Value.ToString().Length-1);
			    Char delimiter = ' ';
			    String[] substrings = value.Split(delimiter);
			    
			    	string empresa = "";
				    string vehiculo = "";
				    string nombreRuta = "";
				    string turno = "";
				    string sentido = "";
				    
			    try{
			    	empresa = substrings[0];
				    vehiculo = substrings[1];
				    nombreRuta = substrings[2];
				    turno = substrings[3];
				    sentido = substrings[4];
			    }catch(Exception){
			    	dgDatos[1, x].Style.BackColor = Color.Red;
			    	empresa = "";
				    vehiculo = "";
				    nombreRuta = "";
				    turno = "";
				    sentido = "";
			    }
			    
			    
		    	if(substrings[0].Contains("FARMACIAS") || substrings[0].Contains("GRAN") || substrings[0].Contains("SUNNINGDALE")){
		    		if(substrings.Length > 6){
			    		empresa = substrings[0]+" "+substrings[1];
			    		vehiculo = substrings[2];
			    		for(int o=3; o<substrings.Length-2; o++){
			    			if(o == 3)
			    				nombreRuta = substrings[o];
			    			else			    				
			    				nombreRuta += " "+substrings[o];
			    		}			    		
			    		turno = substrings[substrings.Length-2];
			    		sentido = substrings[substrings.Length-1];
			    	}else{
			    		empresa = substrings[0]+" "+substrings[1];
			    		vehiculo = substrings[2];
			    		nombreRuta = substrings[3];
			    		turno = substrings[4];
			    		sentido = substrings[5];
			    	}
		    	}else{
		    		if(substrings.Length > 5){
			    		empresa = substrings[0];
			    		vehiculo = substrings[1];
			    		for(int o=2; o<substrings.Length-2; o++){
			    			if(o == 2)
			    				nombreRuta = substrings[o];
			    			else			    				
			    				nombreRuta += " "+substrings[o];
			    		}			    		
			    		turno = substrings[substrings.Length-2];
			    		sentido = substrings[substrings.Length-1];
			    	}
		    	}
			    if(turno == "1")
			    	turno = "Mañana";
			    else if(turno == "2")
			    	turno = "Medio día";
			    else if(turno == "3")
			    	turno = "Vespertino";
			    else
			    	turno = "Nocturno";
			    
			    vehiculo = ((vehiculo == "T")? "CAMIONETA" : "CAMION");
			    if(substrings[0].Contains("FLEXTRONIX") || substrings[0].Contains("ALDO"))
			    	vehiculo = "ABIERTO";
			    if(substrings[0].Contains("FARMACIAS") && substrings[0].Contains("EXTRA") )
			    	vehiculo = "ABIERTO";
			    
			    consulta = @"select r.ID from RUTA r join Cliente c on c.ID = r.IdSubEmpresa where c.Empresa like '%"+empresa+"%' and c.tipo_cobro like '%"+
			    	vehiculo+"%' and r.Nombre = '"+nombreRuta+"' and r.Turno = '"+turno+"' and  Sentido = '"+((sentido == "E")? "Entrada" : "Salida")+"' order by r.id DESC";
			    
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())				
					dgDatos[2,x].Value = conn.leer["ID"].ToString();
				else
					dgDatos[2,x].Value = "0";
				conn.conexion.Close();				
			}
		}
		
		private void Guardar(string validacion, string id_m, string id_r, string nombre, string tipo){
			string consulta = "";
			if(validacion == "RESTAURAR"){
				consulta = "update RELACION_UBICACION set ESTATUS = '1' where ID = "+id_m;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();				
				conn.conexion.Close();				
				
				consulta = "UPDATE MOVIMIENTO SET ESTATUS='1' WHERE ID_X="+id_m+" or ID_Y="+id_m;
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
			if(validacion == "NUEVO"){
				if(tipo == "OPERADOR")
					tipo = "VIVIENDA";
				consulta = "insert into RELACION_UBICACION values ("+((id_r=="0")?"null":id_r)+", '"+nombre+"', '"+tipo+"', '1')";				
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();				
			}
		}
		
		private void EliminaPuntos(){			
			List<string> ID_PUNTO = new List<string>();
			List<string> ID_PUNTO_ELIMINA = new List<string>();
			
			for(int x=0; x<dgDatos.RowCount; x++){
				if(dgDatos[3,x].Value.ToString() == "ACTIVO" && dgDatos[4,x].Value.ToString() != "")					
					ID_PUNTO.Add(dgDatos[4,x].Value.ToString());
			}
			
			String id_c = "";			
			for(int x=0; x<ID_PUNTO.Count; x++){
				if(x==0)
					id_c = ID_PUNTO[x];
				if(x>0 && x<=ID_PUNTO.Count)
					id_c = id_c + ", "+ ID_PUNTO[x];
			}
						
			string consulta = "select * from RELACION_UBICACION where estatus = '1' and id not in ("+id_c+")";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read())
				ID_PUNTO_ELIMINA.Add(conn.leer["ID"].ToString());
			conn.conexion.Close();
			
			
			for(int y=0; y<ID_PUNTO_ELIMINA.Count; y++){
				consulta = "UPDATE RELACION_UBICACION SET ESTATUS='0' WHERE ID = "+ID_PUNTO_ELIMINA[y];					
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				consulta = "UPDATE MOVIMIENTO SET ESTATUS='0' WHERE ID_X="+ID_PUNTO_ELIMINA[y]+" or ID_Y="+ID_PUNTO_ELIMINA[y];
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
			}
		}
		
		private void GuardaMatrizMovimientos(){			
			listMatrizBaseX = ObtenerDatosMatrizX();
			List<string> ID_PUNTOS = new List<string>();
			List<string> ID_PUNTOS_GUARDADOS = new List<string>();
									
			string consulta = "select * from RELACION_UBICACION where ESTATUS = '1'";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read())
				ID_PUNTOS.Add(conn.leer["ID"].ToString());
			conn.conexion.Close();
			
			int bandera1 = 0; // 0 =  no realiza nada, 1 = restaura, 2 = inserta
			int bandera2 = 0; // 0 =  no realiza nada, 1 = restaura, 2 = inserta
			
			if(listMatrizBaseX != null){
				for(int y=0; y<ID_PUNTOS.Count; y++){
					//lblProceso.Text = y+1 +"/"+ID_PUNTOS.Count+1;
					for(int x=0; x<listMatrizBaseX.Count-1; x++){
						bandera1 = 0;
						string id_m = "0";
						consulta = "SELECT * FROM MOVIMIENTO WHERE ID_X = '"+listMatrizBaseX[x].X+"' AND ID_Y = '"+ID_PUNTOS[y]+"'";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "1")
								bandera1 = 0;
							else
								bandera1 = 1;
							id_m = conn.leer["ID"].ToString();
							ID_PUNTOS_GUARDADOS.Add(conn.leer["ID"].ToString());
						}else{
							bandera1 = 2;
						}
						conn.conexion.Close();
						
						if(bandera1 == 1){
							consulta = "UPDATE MOVIMIENTO SET ESTATUS = '1' WHERE ID = "+id_m;					
							conn.getAbrirConexion(consulta);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
						}else if(bandera1 == 2){
							consulta = "insert into MOVIMIENTO values ("+listMatrizBaseX[x].X+", "+ID_PUNTOS[y]+", '0', '1',"+idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
							conn.getAbrirConexion(consulta);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
														
							consulta = "SELECT MAX(ID) ID FROM MOVIMIENTO";
							conn.getAbrirConexion(consulta);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read())
								ID_PUNTOS_GUARDADOS.Add(conn.leer["ID"].ToString());
							conn.conexion.Close();
						}						
					}
					
					for(int x=0; x<listMatrizBaseX.Count; x++){
						bandera2 = 0;
						string id_m = "0";
						consulta = "SELECT * FROM MOVIMIENTO WHERE ID_X = '"+ID_PUNTOS[y]+"' AND ID_Y = '"+listMatrizBaseX[x].X+"'";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["ESTATUS"].ToString() == "1")
								bandera2 = 0;
							else
								bandera2 = 1;
							id_m = conn.leer["ID"].ToString();
							ID_PUNTOS_GUARDADOS.Add(conn.leer["ID"].ToString());
						}else{
							bandera2 = 2;
						}
						conn.conexion.Close();
						
						if(bandera2 == 1){
							consulta = "UPDATE MOVIMIENTO SET ESTATUS = '1' WHERE ID = "+id_m;					
							conn.getAbrirConexion(consulta);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
						}else if(bandera2 == 2){
							consulta = "insert into MOVIMIENTO values ("+ID_PUNTOS[y]+", "+listMatrizBaseX[x].X+", '0', '1',"+idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
							conn.getAbrirConexion(consulta);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
							
							consulta = "SELECT MAX(ID) ID FROM MOVIMIENTO";
							conn.getAbrirConexion(consulta);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read())
								ID_PUNTOS_GUARDADOS.Add(conn.leer["ID"].ToString());
							conn.conexion.Close();
						}
					}
				}
			}
			
			String id_c = "";			
			for(int x=0; x<ID_PUNTOS_GUARDADOS.Count; x++){
				if(x==0)
					id_c = ID_PUNTOS_GUARDADOS[x];
				if(x>0 && x<=ID_PUNTOS_GUARDADOS.Count)
					id_c = id_c + ", "+ ID_PUNTOS_GUARDADOS[x];
			}
			
			if(id_c == "")
			   id_c = "0";
			
			consulta = "UPDATE MOVIMIENTO SET ESTATUS='0' WHERE ID not in ("+id_c+") ";					
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		
		private List<Interfaz.Combustible.Datos.DatosMatriz> ObtenerDatosMatrizX(){
			List<Interfaz.Combustible.Datos.DatosMatriz> listMatriz=new List<Interfaz.Combustible.Datos.DatosMatriz>();
			
			string consulta = "SELECT * FROM RELACION_UBICACION WHERE ESTATUS='1' ";			
			conn.getAbrirConexion(consulta);			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				Interfaz.Combustible.Datos.DatosMatriz datos = new Interfaz.Combustible.Datos.DatosMatriz();
				datos.X	= conn.leer["ID"].ToString();
				listMatriz.Add(datos);
			}
			conn.conexion.Close();			
			return (listMatriz.Count>0)?listMatriz:null;
		}
		#endregion		
		
		#region EVENTOS COPIAR Y PEGAR
		void DgDatosKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control && e.KeyCode == Keys.V){
				string s = Clipboard.GetText();
				string[] lines = s.Split('\n');
				int row = dgDatos.CurrentCell.RowIndex;
				int col = dgDatos.CurrentCell.ColumnIndex;
				
				foreach (string line in lines){
					if (row < dgDatos.RowCount && line.Length > 0){
						string[] cells = line.Split('\t');
						for (int i = 0; i < cells.GetLength(0); ++i){
							if (col + i <this.dgDatos.ColumnCount){
								dgDatos[col + i, row].Value = Convert.ChangeType(cells[i], dgDatos[col + i, row].ValueType);
							}else{
								break;
							}
						}
						row++;
					}else{
						break;
					}
				}
			}
		}
		#endregion
	}
}
