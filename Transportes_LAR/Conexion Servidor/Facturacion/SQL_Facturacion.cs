using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Threading;


namespace Transportes_LAR.Conexion_Servidor.Facturacion
{
	public class SQL_Facturacion:SQL_Conexion
	{
		public SQL_Facturacion()
		{
		}
		
		public void ActualizarValores(String NomEmpresa, String FechaInicio, String FechaCorte)
		{
			string sentencia = "";
			sentencia = "UPDATE OPERACION SET FLUJO='2' where id_operacion in (select O.id_operacion "+                                                   
                   		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                   		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                        "and OO.id_operador=OP.ID AND C.Empresa='"+NomEmpresa+"' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void ActualizarRutasHenniges(String ID_fact, String Nombre, String Servicio, String Costo, String tipo, String Turno)
		{
			string sentencia = "";
			sentencia = "UPDATE FACT_HENNIEGES SET Nombre='"+Nombre+"', Servicio='"+Servicio+"', Costo='"+Costo+"', Tipo='"+tipo+"', Turno='"+Turno+"' where ID="+ID_fact;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("El registro fue actualizado correctamente");
			mensaje.Show();
		}
		
		public void AgregarRutasHenniges(String Nombre, String Servicio, String Costo, String tipo, String Turno, String Empresa)
		{
			string sentencia = "";
			sentencia = "insert into FACT_HENNIEGES values ('"+Nombre+"', '"+Servicio+"', '"+Costo+"', '"+tipo+"',  '"+Turno+"', '"+Empresa+"')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("El registro fue agregado correctamente");
			mensaje.Show();
		}
		
		public void EliminarRutasHenniges(String ID)
		{
			string sentencia = "";
			sentencia = "delete from FACT_HENNIEGES where ID="+ID;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("El registro fue eliminado correctamente");
			mensaje.Show();
		}
		
		public void PagoExterno(String ID_R, double costos, double costoc, String id_usuario, String fecha_reg, String hora_reg)
		{
			bool opcion = false;
			
			string sentencia = "select COSTO from COBRO_FACTURA_EMPRESA where ID_R="+ID_R;
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				opcion = true;
			}
			else
			{
				opcion = false;
			}
			base.conexion.Close();
			
			if(opcion==false)
			{
				string sentencia2 = "";
				sentencia2 = "insert into COBRO_FACTURA_EMPRESA values ('"+ID_R+"', '"+costos+"', '"+id_usuario+"', '"+fecha_reg+"',  '"+hora_reg+"', '"+costoc+"')";
				base.getAbrirConexion(sentencia2);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("El registro fue agregado correctamente");
				mensaje.Show();
			}
			else
			{
				string sentencia3 = "";
				sentencia3 = "UPDATE COBRO_FACTURA_EMPRESA SET costo='"+costos+"', costo_completa='"+costoc+"' where ID_R="+ID_R;
				base.getAbrirConexion(sentencia3);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("El registro fue actualizado correctamente");
				mensaje.Show();
			}
		}
		
		public double getPagoExternoSencillo(String id)
		{
			double costo=0.0;
			
			base.getAbrirConexion("select costo from COBRO_FACTURA_EMPRESA WHERE ID_R="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            	costo = (Convert.ToDouble(base.leer["costo"]));
            else
            	costo = 0.0;
			
			base.conexion.Close();
			
			return costo;
		}
		
		public double getPagoExternoCompleto(String id)
		{
			double costo=0.0;
			
			base.getAbrirConexion("select costo_completa from COBRO_FACTURA_EMPRESA WHERE ID_R="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            	costo = (Convert.ToDouble(base.leer["costo_completa"]));
            else
            	costo = 0.0;
			
			base.conexion.Close();
			
			return costo;
		}
		
		public void Auditoria(String id, String costo, Double nuevoCosto, int idUsuario)
		{			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'ID FACT_HENNIEGES: "+id+",   costo: "+costo+",   Nuevo Costo: "+nuevoCosto+" ', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idUsuario+", 'FACT_HENNIEGES')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
		}
		
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////// PRECIOS FACTURACION  /////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region INSERTAR PRECIO
		public Boolean insertarPrecio(string EMPRESA, string IDENTIFICADOR, string SENTIDO, string VEHICULO, string TIPO, string VELADA, string FORANEA,
		                             string PRECIO, string TURNO, string OBERVACIONES)
		{	
			bool respuesta = true;
			try{ 	
				String sentencia = @"insert into FACTURA_PRECIOS (EMPRESA, IDENTIFICADOR, SENTIDO, VEHICULO, TIPO, VELADA, FORANEA, PRECIO, TURNO, 
									OBERVACIONES, ESTATUS) values ('"+EMPRESA+"', '"+IDENTIFICADOR+"', '"+SENTIDO+"', '"+VEHICULO+"', '"+TIPO
									+"', '"+VELADA+"', '"+FORANEA+"', '"+PRECIO+"', '"+TURNO+"', '"+OBERVACIONES+"', 'Activo')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion
		
		#region MODIFICAR PRECIO
		public Boolean modificarPrecio(string EMPRESA, string IDENTIFICADOR, string SENTIDO, string VEHICULO, string TIPO, string VELADA, string FORANEA,
		                             string PRECIO, string TURNO, string OBERVACIONES, string ID, string ID_USUARIO)
		{	
			string sentencia = "";
			bool respuesta = true;
			string EMPRESA_OLD = "", IDENTIFICADOR_OLD = "", SENTIDO_OLD = "", VEHICULO_OLD = "", TIPO_OLD = "", VELADA_OLD = "", FORANEA_OLD = "", 
				   PRECIO_OLD = "", TURNO_OLD = "", OBERVACIONES_OLD = "";
			
			try{
				sentencia = "SELECT * FROM FACTURA_PRECIOS WHERE ID ="+ID;
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read()){
					EMPRESA_OLD = base.leer["EMPRESA"].ToString();
					IDENTIFICADOR_OLD = base.leer["IDENTIFICADOR"].ToString();
					SENTIDO_OLD = base.leer["SENTIDO"].ToString();
					VEHICULO_OLD = base.leer["VEHICULO"].ToString();
					TIPO_OLD = base.leer["TIPO"].ToString();
					VELADA_OLD = base.leer["VELADA"].ToString();
					FORANEA_OLD = base.leer["FORANEA"].ToString();
					PRECIO_OLD = base.leer["PRECIO"].ToString();
					TURNO_OLD = base.leer["TURNO"].ToString();
					OBERVACIONES_OLD = base.leer["OBERVACIONES"].ToString();
				}
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
							   
			if(respuesta){
				try{
					sentencia = @"insert into HTS_FACTURA_PRECIOS (ID_FACTURA_PRECIOS, EMPRESA, IDENTIFICADOR, SENTIDO, VEHICULO, TIPO, VELADA, FORANEA, PRECIO,
									TURNO, OBERVACIONES, FECHA_REG, HORA_REG, ID_USUARIO) values ('"+ID+"', '"+EMPRESA_OLD+"', '"+IDENTIFICADOR_OLD+"', '"
									+SENTIDO_OLD+"', '"+VEHICULO_OLD+"', '"+TIPO_OLD+"', '"+VELADA_OLD+"', '"+FORANEA_OLD+"', '"+PRECIO_OLD+"', '"+TURNO_OLD+
									"', '"+OBERVACIONES_OLD+"',(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					respuesta = true;
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}
			
			if(respuesta){
				try{
					sentencia = "UPDATE FACTURA_PRECIOS SET EMPRESA = '"+EMPRESA+"', IDENTIFICADOR = '"+IDENTIFICADOR+"', SENTIDO = '"+SENTIDO+"' , VEHICULO = '"
								+VEHICULO+"' , TIPO = '"+TIPO+"', VELADA = '"+VELADA+"' , FORANEA = '"+FORANEA+"' , PRECIO = '"+PRECIO+"' , TURNO = '"+TURNO
								+"' , OBERVACIONES = '"+OBERVACIONES+"'  where ID = "+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					respuesta = true;
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		#endregion
		
		#region ELIMINA PRECIO
		public Boolean eliminaPrecio(string ID, string ID_USUARIO, int bandera)
		{	
			string sentencia = "UPDATE FACTURA_PRECIOS SET ESTATUS = 'Inactivo' where ID = "+ID;
			bool respuesta = true;
			
			try{
				if(bandera == 1)
					sentencia = "UPDATE FACTURA_PRECIOS SET ESTATUS = 'Activo' where ID = "+ID;					
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}		
			return respuesta;
		}
		#endregion
		
		#region OBTENER PRECIO
		public double obtenerPrecioJABIL(string IDENTIFICADOR, string SENTIDO, string VEHICULO, string FORANEA)
		{	
			string sentencia = "";
			double precio = 0.0;
			
			try{
				sentencia = "SELECT PRECIO FROM FACTURA_PRECIOS  WHERE ESTATUS = 'Activo' AND EMPRESA = 'JABIL' AND IDENTIFICADOR = '"+IDENTIFICADOR
							+"' AND SENTIDO = '"+SENTIDO+"' AND VEHICULO = '"+VEHICULO+"' AND FORANEA = '"+FORANEA+"'";
				base.getAbrirConexion(sentencia);			
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read())
					precio = Convert.ToDouble(base.leer["PRECIO"]);
				base.conexion.Close();
			}catch(Exception){
				precio = 0.0;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}		
			return precio;
		}
		
		public double obtenerPrecioRIMSA(string IDENTIFICADOR, string SENTIDO, string VEHICULO)
		{	
			string sentencia = "";
			double precio = 0.0;
			
			try{
				sentencia = "SELECT PRECIO FROM FACTURA_PRECIOS  WHERE ESTATUS = 'Activo' AND EMPRESA = 'RIMSA' AND IDENTIFICADOR = '"+IDENTIFICADOR
							+"' AND SENTIDO = '"+SENTIDO+"' AND VEHICULO = '"+VEHICULO+"'";
				base.getAbrirConexion(sentencia);			
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read())
					precio = Convert.ToDouble(base.leer["PRECIO"]);
				base.conexion.Close();
			}catch(Exception){
				precio = 0.0;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}		
			return precio;
		}
		#endregion		
		
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////// CONTROL FACTURACION  /////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		 
		#region GUARDA FACTURA
		public void GuardaFactura(int idU, string empresa, string inicio, string fin, double importe){
			string sentencia = "";
			
			string idCF = "";
			try{
				sentencia = "SELECT ID FROM CONTROL_FACTURACION WHERE ESTATUS= 'ACTIVO' AND ESTADO = 'GENERADA' AND EMPRESA = '"+empresa+"' AND PERIODO_I = '"+inicio+"'  AND PERIODO_F = '"+fin+"'  AND IMPORTE = '"+importe+"' ORDER BY ID DESC";
				base.getAbrirConexion(sentencia);			
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read())
					idCF = (( base.leer["id"] != null)? base.leer["id"].ToString(): "");					
				else
					idCF = "";
				base.conexion.Close();
			}catch(Exception){
				idCF = "";
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			if(idCF.Length > 0){
				CancelaFacturar(Convert.ToInt64(idCF), idU, "Error de datos, se genero una nueva factura", "");
			}
			
			try{
				sentencia = @"INSERT INTO CONTROL_FACTURACION(FECHA_CREACION, HORA_CREACION, ID_USUARIO_CREACION, EMPRESA, PERIODO_I, PERIODO_F, IMPORTE, IVA, TOTAL, ESTADO, ESTATUS)VALUES( 
							(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+idU+"', '"+empresa+"', '"+inicio+"', '"+fin+"', "+importe+", "+(importe*.16)+",  "
							+(importe*1.16)+", 'GENERADA', 'ACTIVO')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL GUARDAR LA FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
		}	
		#endregion	
				
		#region HISTORIAL FACTURA
		public bool HSTFactura(int idU, Int64 id_f, string tipo){
			string sentencia = "";
			bool respuesta = true;
			
			string FACTURA = "", PERIODO_I = "", PERIODO_F = "", IMPORTE = "", IVA = "", TOTAL = "", DIA_COBRO = "", VENCIMIENTO = "",
					OBERVACIONES = "", ESTADO = "", CONTRIBUYENTE = "";
 
			try{
				sentencia = "SELECT * FROM CONTROL_FACTURACION  WHERE id ="+id_f;
				base.getAbrirConexion(sentencia);			
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read()){
					FACTURA = (( base.leer["FACTURA"] != null)? base.leer["FACTURA"].ToString(): "");
					PERIODO_I = (( base.leer["PERIODO_I"] != null)? base.leer["PERIODO_I"].ToString().Substring(0,10): "");
					PERIODO_F = (( base.leer["PERIODO_F"] != null)? base.leer["PERIODO_F"].ToString().Substring(0,10): "");
					IMPORTE = (( base.leer["IMPORTE"] != null)? base.leer["IMPORTE"].ToString(): "0");
					IVA = (( base.leer["IVA"] != null)? base.leer["IVA"].ToString(): "0");
					TOTAL = (( base.leer["TOTAL"] != null)? base.leer["TOTAL"].ToString(): "0");
					DIA_COBRO = (( base.leer["DIA_COBRO"] != null)? (( base.leer["DIA_COBRO"].ToString().Length > 9)? base.leer["DIA_COBRO"].ToString().Substring(0, 10): base.leer["DIA_COBRO"].ToString() ): "");
					VENCIMIENTO = (( base.leer["VENCIMIENTO"] != null)? (( base.leer["VENCIMIENTO"].ToString().Length > 9)? base.leer["VENCIMIENTO"].ToString().Substring(0, 10): base.leer["VENCIMIENTO"].ToString() ): "");
					OBERVACIONES = (( base.leer["OBSERVACIONES"] != null)? base.leer["OBSERVACIONES"].ToString(): "");
					CONTRIBUYENTE = (( base.leer["CONTRIBUYENTE"] != null)? base.leer["CONTRIBUYENTE"].ToString(): "");
					ESTADO = (( base.leer["ESTADO"] != null)? base.leer["ESTADO"].ToString(): "");
				}
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}	
			
			if(respuesta){
				try{
					sentencia = @"INSERT INTO HST_CONTROL_FACTURACION(ID_CF, TIPO, FACTURA, PERIODO_I, PERIODO_F, IMPORTE, IVA, TOTAL, DIA_COBRO, 
								VENCIMIENTO, OBSERVACIONES, ESTADO, FECHA_REG, HORA_REG, ID_USUARIO, CONTRIBUYENTE)VALUES( "+id_f+", '"+tipo+"', '"+FACTURA+"', '"+PERIODO_I
								+"', '"+PERIODO_F+"', '"+((IMPORTE.Length == 0)? "0": IMPORTE)+"', '"+((IVA.Length == 0)? "0": IVA)+"', '"
								+((TOTAL.Length == 0)? "0": TOTAL)+"', '"+DIA_COBRO+"', '"+VENCIMIENTO+"', '"+OBERVACIONES
								+"', '"+ESTADO+"',  (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+idU+"', '"+CONTRIBUYENTE+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}				
			return respuesta;
		}	
		#endregion	
		
		#region GUARDA FACTURA
		public bool Facturar(Int64 id_f, int idU, string factura, string vencimiento, string observaciones, string CONTRIBUYENTE){
			string sentencia = "";
			bool respuesta = true;
			if(HSTFactura(idU, id_f, "Factura")){
				try{
					sentencia = @"UPDATE CONTROL_FACTURACION SET FACTURA = '"+factura+"', VENCIMIENTO = '"+vencimiento+"', CONTRIBUYENTE = '"+CONTRIBUYENTE+"', OBSERVACIONES = '"+observaciones+"', ESTADO = 'FACTURADA' where ID = "+id_f;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}else{
				respuesta = false;
			}
			return respuesta;
		}	
		#endregion	
		
		#region CANCELAR FACTURA
		public bool CancelaFacturar(Int64 id_f, int idU, string motivo, string observaciones){
			string sentencia = "";
			bool respuesta = true;
			if(HSTFactura(idU, id_f, "Elimina")){
				try{
					sentencia = @"INSERT INTO CANCELA_CONTROL_FACTURACION(ID_CF, MOTIVO, OBSERVACIONES, FECHA_REG, HORA_REG, ID_USUARIO)VALUES('"+id_f+"', '"
								+motivo+"', '"+observaciones+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+idU+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
				
				if(respuesta){
					try{
						sentencia = @"UPDATE CONTROL_FACTURACION SET ESTATUS = 'INACTIVO' where ID = "+id_f;
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}catch(Exception){
						respuesta = false;
					}finally{
						if(base.conexion != null)
							base.conexion.Close();
					}
				}
			}else{
				respuesta = false;
			}
			return respuesta;
		}	
		#endregion	
		
		#region PAGAR FACTURA
		public bool Pagar(Int64 id_f, int idU){
			string sentencia = "";
			bool respuesta = true;
			if(HSTFactura(idU, id_f, "Pagar")){
				try{
					sentencia = @"UPDATE CONTROL_FACTURACION SET ESTADO = 'PAGADA' where ID = "+id_f;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}else{
				respuesta = false;
			}
			return respuesta;
		}	
		#endregion	
	}
}
