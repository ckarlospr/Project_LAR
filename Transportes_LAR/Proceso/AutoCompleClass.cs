using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Transportes_LAR.Proceso
{
	public partial class AutoCompleClass
	{
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		public AutoCompleteStringCollection AutocompleteGeneral(String Consulta, String Campo)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion(Consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				coleccion.Add(conn.leer[Campo].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
		
		public AutoCompleteStringCollection Bonos()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
			coleccion.Add("Aguinaldo");
            coleccion.Add("Finiquito");
			coleccion.Add("Prima Vacacional");
			coleccion.Add("Incapacidad");
            return coleccion;
        }
		
		//Ckarlos
		public AutoCompleteStringCollection AutocompleteGeneral(String Consulta)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion(Consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				coleccion.Add(conn.leer["FACTURA"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
		
		public AutoCompleteStringCollection AutocompleteActivoAdmin()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select alias from OPERADOR where Estatus='1' and tipo_empleado!='OPERADOR' ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["alias"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
		
		public AutoCompleteStringCollection AutocompletePatron()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select NombrePatron from OperadorContrato");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["NombrePatron"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	 
	 	public AutoCompleteStringCollection AutocompleteNombre()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select Nombre from OPERADOR");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["Nombre"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	 
		public AutoCompleteStringCollection AutocompleteApePat()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select Apellido_Pat from OPERADOR");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["Apellido_Pat"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	 
	 	public AutoCompleteStringCollection AutocompleteApeMaT()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select Apellido_Mat from OPERADOR");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["Apellido_Mat"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	 
	 	public AutoCompleteStringCollection AutocompleteOperadores()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            
            conn.getAbrirConexion("select O.alias from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR");
			
            conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				coleccion.Add(conn.leer["Alias"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	 
	  	public AutoCompleteStringCollection AutocompleteFecha()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select FECHA from RUTA_ESPECIAL");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["FECHA"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	  
	   	public AutoCompleteStringCollection AutocompleteCliente()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select O.alias from LICENCIA L, OPERADOR O, ASIGNACIONUNIDAD AU, VEHICULO V, OperadorContrato OC WHERE O.ID=OC.IdOperador and L.ID_Chofer=O.ID and O.ID = AU.ID_OPERADOR AND AU.ID_UNIDAD=V.ID and OC.Fecha>(SELECT CONVERT (date, SYSDATETIME())) AND L.Vigencia>(SELECT CONVERT (date, SYSDATETIME())) AND AU.ID_OPERADOR IN (SELECT ID_OPERADOR FROM ASIGNACIONUNIDAD) group by Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["Alias"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	   
	    public AutoCompleteStringCollection AutoOp()
        {
	    	DataTable dt = conn.getaAdaptadorTabla("select Alias from operador where Estatus=1");
 
	         AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
	         
	         foreach (DataRow row in dt.Rows)
	         {
	             coleccion.Add(Convert.ToString(row["Alias"]));
	         }
	 
	         return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutocompleterResponsable()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select responsable from RUTA_ESPECIAL");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["responsable"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutocompleteContactoCliente()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select Nombre from ContactoServicio");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["Nombre"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
		
		public AutoCompleteStringCollection AutoOp2()
        {
	    	DataTable dt = conn.getaAdaptadorTabla("select * from operador where estatus='1' and TIPO_EMPLEADO='OPERADOR'");
 
	         AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
	         
	         foreach (DataRow row in dt.Rows)
	         {
	             coleccion.Add(Convert.ToString(row["Alias"])); 	
	         }
	 
	         return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutoReconocimiento(String Consulta)
        {
	    	DataTable dt = conn.getaAdaptadorTabla(Consulta);
 
	         AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
	         
	         foreach (DataRow row in dt.Rows)
	         {
	             coleccion.Add(Convert.ToString(row["Dato"]));
	         }
	 
	         return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutocompleteUnidad()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select V.NUMERO from VEHICULO V ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["NUMERO"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutocompleteEmpresa()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("Select Distinct(Empresa) As NombreEmpresa from Cliente where Empresa!='Especiales'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["NombreEmpresa"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutocompleteRuta(String Empresa)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("Select Distinct(R.Nombre) As NombreRuta from CLIENTE C, RUTA R where C.ID=R.IdSubEmpresa and C.Empresa like '%"+Empresa+"%'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["NombreRuta"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	    
	    public AutoCompleteStringCollection AutocompletePrestamos()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            conn.getAbrirConexion("select distinct(descripcion) as pres from descuento where tipo!='U' and tipo!='LIQ' and tipo!='L' and tipo!='A' ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
			coleccion.Add(conn.leer["pres"].ToString());
			}
			conn.conexion.Close();
            return coleccion;
        }
	     
	    public AutoCompleteStringCollection AutocompleteOrdenCompra(String celda)
	    {
	    	String collectAdd = "";
    		AutoCompleteStringCollection colect = new AutoCompleteStringCollection();
	    	
	    	if(celda == "Concepto")
	    	{
	    		conn.getAbrirConexion("SELECT pa.CODIGO, pa.PIEZA, pa.MARCA, pa.MODELO FROM PRODUCTO_ALMACEN pa");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					collectAdd = conn.leer["CODIGO"].ToString()+" - "+
								 conn.leer["Pieza"].ToString()+" - "+
						   		 conn.leer["Marca"].ToString()+", "+
						   		 conn.leer["Modelo"].ToString();
					colect.Add(collectAdd);
				}
				conn.conexion.Close();
				return colect;
	    	}
	    	if(celda == "Carro")
	    	{
	    		conn.getAbrirConexion("SELECT v.Numero, v.Tipo_Unidad, v.Tipo_Servicio, v.Marca, v.Modelo FROM VEHICULO v");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					collectAdd = conn.leer["Numero"].ToString()+" - "+
							     conn.leer["Tipo_Unidad"].ToString()+" "+
							     conn.leer["Tipo_Servicio"].ToString()+", "+
							     conn.leer["Marca"].ToString()+" "+
							     conn.leer["Modelo"].ToString();
					colect.Add(collectAdd);
				}
				conn.conexion.Close();
				return colect;
	    	}
	    	return colect;
	    }
	
	} 
}
