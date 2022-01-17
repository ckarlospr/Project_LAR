using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Reportes
{
	public class SQL_Reportes:SQL_Conexion
	{
		public SQL_Reportes():base()
		{
		}
		
		public DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		
		#region	CONSULTA DE OTROS REPORTE COMBUSTIBLE
		public List<Interfaz.Reportes.ClassDatos> getLisDatos(String consulta)
		{
			List<Interfaz.Reportes.ClassDatos> listDatos=new List<Interfaz.Reportes.ClassDatos>();
			
			base.getAbrirConexion(consulta);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Reportes.ClassDatos datos = new Interfaz.Reportes.ClassDatos();
				
				datos.Dato0			=base.leer["D1"].ToString();
				datos.Dato1			=base.leer["D2"].ToString();
				datos.Dato2			=base.leer["D3"].ToString();
				
				listDatos.Add(datos);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		
		public List<Interfaz.Reportes.ClassDatos> getLisDatos2(String consulta)
		{
			List<Interfaz.Reportes.ClassDatos> listDatos=new List<Interfaz.Reportes.ClassDatos>();
			
			base.getAbrirConexion(consulta);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Reportes.ClassDatos datos = new Interfaz.Reportes.ClassDatos();
				
				datos.Dato0			=base.leer["D1"].ToString();
				datos.Dato1			=base.leer["D2"].ToString();
				datos.Dato2			=base.leer["D3"].ToString();
				datos.Dato3			=base.leer["D4"].ToString();
				listDatos.Add(datos);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		#endregion
		
		#region DATOS COBRO DE SERVICIOS
		
		#region DATOS PRINCIPALES
		public List<Interfaz.Nomina.Especiales.Finanzas.DatosPrin> getDatosPrin(String consulta)
		{
			List<Interfaz.Nomina.Especiales.Finanzas.DatosPrin> listDatos = new List<Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.DatosPrin>();
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Nomina.Especiales.Finanzas.DatosPrin DATOS = new Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.DatosPrin();
				DATOS.ID_RE			=base.leer["ID_RE"].ToString();
				DATOS.FECHA_SALIDA	=base.leer["FECHA_SALIDA"].ToString();
				DATOS.RESPONSABLE	=base.leer["RESPONSABLE"].ToString();
				DATOS.DESTINO		=base.leer["DESTINO"].ToString();
				DATOS.PRECIO		=base.leer["PRECIO"].ToString();
				DATOS.CANT_UNIDADES	=base.leer["CANT_UNIDADES"].ToString();
				DATOS.COSTO			=base.leer["COSTO"].ToString();
				DATOS.FACT			=base.leer["FACTURADO"].ToString();
				DATOS.INCO			=base.leer["INCOBRABLE"].ToString();
				DATOS.FLUJO			=base.leer["PAGADO"].ToString();
				DATOS.NUMERO_FACT	=base.leer["NUMERO_ANTI"].ToString();
				DATOS.FACTURA		=base.leer["FACTURA"].ToString();
				listDatos.Add(DATOS);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		#endregion
		
		#region DATOS ANTICIPOS
		public List<Interfaz.Nomina.Especiales.Finanzas.Anticipos> getAnticipos(String consulta)
		{
			List<Interfaz.Nomina.Especiales.Finanzas.Anticipos> listDatos = new List<Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.Anticipos>();
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Nomina.Especiales.Finanzas.Anticipos DATOS = new Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.Anticipos();
				DATOS.ID_RE			=base.leer["ID_RE"].ToString();
				DATOS.CANTIDAD		=base.leer["CANTIDAD"].ToString();
				DATOS.TIPO			=base.leer["TIPO"].ToString();
				DATOS.ESTATUS		=base.leer["ESTATUS"].ToString();
				listDatos.Add(DATOS);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		#endregion
		
		#region DATOS COBROS
		public List<Interfaz.Nomina.Especiales.Finanzas.Validado> getCobros(String consulta)
		{
			List<Interfaz.Nomina.Especiales.Finanzas.Validado> listDatos = new List<Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.Validado>();
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Nomina.Especiales.Finanzas.Validado DATOS = new Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.Validado();
				DATOS.ID_RE			=base.leer["ID_RE"].ToString();
				DATOS.SALDO			=base.leer["SALDO"].ToString();
				DATOS.PAGO			=base.leer["PAGO"].ToString();
				DATOS.TIPO_VIAJE	=base.leer["TIPO_VIAJE"].ToString();
				DATOS.DATO_FACT		=base.leer["NUMERO_FACT"].ToString();
				DATOS.INCO			=base.leer["INCOBRABLE"].ToString();
				listDatos.Add(DATOS);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		#endregion
		
		#endregion
		
		#region AUDITORIA CAMBIOS RUTAS
			public void auditoriaRuta(int idUsuario, string tipo){				
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo Varias Rutas "+tipo+" (Km, Hora De Inicio Y Hora De Fin)', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idUsuario+", 'RUTA')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
		}	
		#endregion
		
	}
}
