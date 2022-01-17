using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Transportes_LAR.Interfaz.Aseguradora;

namespace Transportes_LAR.Conexion_Servidor.SegurosAseguradora
{
	public class ConexionSegurosAseguradoras:Conexion_Servidor.SQL_Conexion
	{
		public ConexionSegurosAseguradoras():base() {}
		
		#region getListaAseguradora
		public void getListaAseguradora(Interfaz.Aseguradora.FormSeguros fs){
			base.getAbrirConexion("SELECT ID,Nombre,Telefono,Domicilio FROM Aseguradora");
			base.leer=base.comando.ExecuteReader();
			fs.laseguradora.Clear();
			fs.cmbAseguradoras.Items.Clear();
			int cont = 0;
			while(base.leer.Read()){

				fs.laseguradora.Add(
					new Interfaz.Aseguradora.Dato.Aseguradora(
						base.leer["id"].ToString(),
						base.leer["Nombre"].ToString(),
						base.leer["Domicilio"].ToString(),
						base.leer["Telefono"].ToString()
					));
				fs.cmbAseguradoras.Items.Add(fs.laseguradora[cont].nombre);
				cont++;
			}
			base.conexion.Close();
		}
		#endregion
		
		#region getInsertarAseguradora
		public void getInsertarAseguradora(string nom, string dom, string tel){
			base.getAbrirConexion("exec insertar_aseguradora '"+nom+"','"+dom+"','"+ tel+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region getModificarAseguradora
		public void getModificarAseguradora(string id, string nom, string dom, string tel){
			base.getAbrirConexion("modificar_aseguradora "+ id + ",'"+nom+"','"+dom+"','"+ tel+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
			
		#region eliminarSeguroUnidad
		public void eliminarSeguroUnidad(String idu){
			base.getAbrirConexion("eliminar_segurou " + idu);
			base.comando.ExecuteReader();
			base.conexion.Close();
		}
		#endregion
		
		#region eliminarAseguradora
		public void eliminarAseguradora(string idas ){
			base.getAbrirConexion("execute eliminar_Aseguradora " + idas);
			base.comando.ExecuteReader();
			base.conexion.Close();	
		}
		#endregion
		
		#region getExistenciaAseguradora
		public bool getExistenciaAseguradora(string Nombre ){
		bool existe = false;
			base.getAbrirConexion("SELECT * FROM Aseguradora WHERE Nombre = '" + Nombre + "'");
			base.leer=base.comando.ExecuteReader();
			if(leer.Read())
				existe = true;
			else
				existe =false;
			base.conexion.Close();
			return existe;
		}
		#endregion

		#region getExistenciaSeguros
		public bool getExistenciaSeguros(string idas ){
		bool existe = false;
		base.getAbrirConexion("select * from SEGURO_UNIDAD  su, SEGURO  se, ASEGURADORA  a where su.ID_SEGURO = se.ID and se.ID_ASEGURADORA = a.ID and a.ID = "+ idas +" and("+
		                 	  "select DATEDIFF(d, CONVERT(CHAR(10), getdate(), 103),se.VENCIMIENTO))>=0");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				existe = true;
			else
				existe =false;
			base.conexion.Close();
			return existe;
		}
		#endregion
		
		#region getTabla
		public  DataTable getTabla(int nc){
			/// 1 -> para vehiculos con seguro vigente
			/// 2 -> para vehiculos no asegurados
			/// 3 -> para Aseguradoras existentes
			string consulta = "";
			
			switch(nc){
			case 1:			//	->	PARA VEHICULOS CON SEGURO VIGENTE
				consulta = "select v.Numero as vNumero, s.Vencimiento as sVencimiento from VEHICULO v,SEGURO s, SEGURO_UNIDAD su,ASEGURADORA a where v.ID = su.ID_UNIDAD and su.ID_SEGURO = s.ID and a.ID = s.ID_Aseguradora and (select DATEDIFF(d, CONVERT(CHAR(10), getdate(), 103),s.Vencimiento )) > 0";
				break;
			case 2:			// -->	PARA VEHICULOS NO ASEGURADOS
				consulta = "SELECT Numero, Tipo_Unidad FROM VEHICULO "+
							"WHERE ID NOT IN (" +
							"SELECT v.ID FROM VEHICULO v, SEGURO s,SEGURO_UNIDAD su " +
							"WHERE v.Estado = 1 and v.ID = su.ID_UNIDAD and su.ID_SEGURO = s.ID and (" +
							"select DATEDIFF(d, CONVERT(CHAR(10), getdate(), 103),s.Vencimiento )) > 0)";
				break;
			case 3:			// --> PARA ASEGURADORAS EXISTENTES
				consulta = "select id as dataID, nombre as dataNombre, domicilio as dataDir, telefono as dataTel from ASEGURADORA";
				break;
			case 4:			// -->	PARA VEHICULOS NO ASEGURADOS solo nombre
				consulta = "SELECT Numero FROM VEHICULO "+
							"WHERE Estado = 1 and ID NOT IN (" +
							"SELECT v.ID FROM VEHICULO v, SEGURO s,SEGURO_UNIDAD su " + 
							"WHERE v.ID = su.ID_UNIDAD and su.ID_SEGURO = s.ID and (" +
							"select DATEDIFF(d, CONVERT(CHAR(10), getdate(), 103),s.Vencimiento )) > 0)";
				break;default:
				break;
			}
			return base.getaAdaptadorTabla(consulta);
		}
		#endregion
		
		#region AutoCompleteStringCollection
		public AutoCompleteStringCollection getListaAutocompletar(){
			base.getAbrirConexion("SELECT DISTINCT(COVERTURA) as cover FROM SEGURO");
			base.leer = base.comando.ExecuteReader();
			AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
			
			while(base.leer.Read()){
				ac.Add(base.leer["cover"].ToString());
			}
			base.conexion.Close();
			return ac;
		}
		#endregion
		
		#region getDatosUnidad
		public void getDatosUnidad(Interfaz.Aseguradora.FormSeguros fs){
			base.getAbrirConexion("SELECT ID,Numero,Placa_Estatal,Placa_Federal,Tipo_Unidad FROM vehiculo where Estado = 1 and Numero= '"+ fs.txtUNum.Text + "'");
			base.leer=base.comando.ExecuteReader();	
			fs.idunidad ="0";
			fs.idseguro = "0";
			fs.idaseguradora= "0";
			if(base.leer.Read()){
				fs.idunidad =base.leer["ID"].ToString();
				fs.txtUPE.Text = base.leer["Placa_Estatal"].ToString();
				fs.txtUPF.Text = base.leer["Placa_Federal"].ToString();
				fs.txtUTipo.Text = base.leer["Tipo_Unidad"].ToString();
			}
			base.conexion.Close();
		}
		#endregion
		
		#region getseguroUnidadvigenete
		public void getseguroUnidadVigente(Interfaz.Aseguradora.FormSeguros fs){
			base.getAbrirConexion("select s.ID as s_id, a.ID as aID,a.Nombre as aNombre,s.Covertura as sCovertura,s.Vencimiento as sVencimiento,su.N_POLIZA as sPoliza from VEHICULO v,SEGURO s, SEGURO_UNIDAD su,ASEGURADORA a where v.Estado =1 and v.ID = " + fs.idunidad + " and v.ID = su.ID_UNIDAD and su.ID_SEGURO = s.ID and a.ID = s.ID_Aseguradora and (select DATEDIFF(d, CONVERT(CHAR(10), getdate(), 103),s.Vencimiento )) > 0");
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				fs.idseguro = base.leer["s_id"].ToString();
				fs.idaseguradora = base.leer["aID"].ToString();
				fs.cmbAseguradoras.Text = base.leer["aNombre"].ToString();
				fs.dtpVencimiento.Text = base.leer["sVencimiento"].ToString();
				fs.dtpVencimiento.Text = base.leer["sVencimiento"].ToString();
				fs.txtCobertura.Text = base.leer["sCovertura"].ToString();
				fs.txtNumeroSeguro.Text = base.leer["sPoliza"].ToString();
				fs.editable = false;
			}else			
				fs.editable = true;
		}
		#endregion
		
		#region GuardarSeguro
		public void GuardarSeguro(Interfaz.Aseguradora.FormSeguros fs){
			base.getAbrirConexion("execute insertar_seguro "+ fs.idseguro+"," +
			                 fs.idaseguradora + ","+ 
			                 fs.idunidad + ",'" + 
			                 fs.txtCobertura.Text + "','" +
			                 fs.vencimiento +"'," + 
			                 fs.txtNumeroSeguro.Text);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
		}
		#endregion
		
		#region GuardarSeguroUnidad
		public void GuardarSeguroUnidad(string ids,string idas,string idu,string covertura,string vencimiento, string npoliza){
			string dato = "execute insertar_seguro "+ids+"," + idas + ","+ idu + ",'" + covertura + "','" +vencimiento +"'," + npoliza;
			base.getAbrirConexion(dato);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
	}
}
