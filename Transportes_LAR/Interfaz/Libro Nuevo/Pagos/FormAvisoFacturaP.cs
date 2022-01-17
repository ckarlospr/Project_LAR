using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormAvisoFacturaP : Form
	{		
		#region CONSTRUCTOR
		public FormAvisoFacturaP(PrivilegiosPagos refp)
		{
			InitializeComponent();
			refprivilegios = refp;
		}
		#endregion
		
		#region INSTANCIAS
		PrivilegiosPagos refprivilegios;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN
		void FormAvisoFacturaPLoad(object sender, EventArgs e)
		{
			adaptador();
		}
		
		void FormAvisoFacturaPFormClosing(object sender, FormClosingEventArgs e)
		{
			refprivilegios.aviso = false;
			if(dgRelacion.Rows.Count == 0)
				refprivilegios.timer1.Stop();
		}
		#endregion
		
		#region ADAPTADOR
		private void adaptador(){
			dgRelacion.Rows.Clear();
			int contador = 0;
			string consulta = @"select re.*, vpn.CONTACTO, vpn.COMPANIA_NOMBRE, vpn.TOTAL_IVA from RUTA_ESPECIAL re join VIAJE_PROSPECTO_NUEVO vpn on re.ID_RE = vpn.ID_RE 
								where (re.FACTURADO = '2' or re.FACTURADO = '1') and re.ID_RE in (select ID_RE from ANTICIPOS_ESPECIALES where tipo = 'EFECTIVO')";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(),
									conn.leer["CONTACTO"].ToString(),
									conn.leer["COMPANIA_NOMBRE"].ToString(),
					                conn.leer["DESTINO"].ToString(),
					                conn.leer["FECHA_SALIDA"].ToString().Substring(0,10),
					                conn.leer["CANT_UNIDADES"].ToString(),
					                conn.leer["TOTAL_IVA"].ToString(),
				                 	((conn.leer["FACTURADO"].ToString() == "0")?"NO":"SI"),
				                 	conn.leer["NUMERO_ANTI"].ToString(),
				                 conn.leer["FACTURA"].ToString(),
				                 "0", // precio a cobrar
				                 "0", //anticipos DEPOSITO
				                 "0", //anticipos EFECTIVO
				                 "0"); //precio que falta a cobrar
				if(conn.leer["FACTURADO"].ToString() == "1" || conn.leer["FACTURADO"].ToString() == "2" || conn.leer["FACTURADO"].ToString() == "3")
						dgRelacion[7,contador].Style.BackColor = Color.LightGreen;
										
				contador++;
			}
			conn.conexion.Close();
			datosCompleta();
			dgRelacion.ClearSelection();
		}
		#endregion
		
		#region METODOS		
		public void datosCompleta(){
			for(int x=0; x<dgRelacion.Rows.Count; x++){
				string consul;		
				if(dgRelacion[7,x].Value.ToString() == "SI"  && (dgRelacion[8,x].Value.ToString() == "" || dgRelacion[8,x].Value.ToString() == " " || dgRelacion[8,x].Value.ToString() == "0" ))
					dgRelacion[8,x].Value = "FACTURABLE";				
								
				consul = @"select SUM(SALDO) AS COSTO from COBRO_ESPECIAL where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[10,x].Value = conn.leer["COSTO"].ToString();
				}				
				conn.conexion.Close();
			
				consul = @"select SUM(CANTIDAD) AS CANTIDAD from ANTICIPOS_ESPECIALES where estatus != '0'  AND tipo = 'DEPOSITO' and ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(conn.leer["CANTIDAD"].ToString() != "")
						dgRelacion[11,x].Value = conn.leer["CANTIDAD"].ToString();
					else
						dgRelacion[11,x].Value = 0;
				}	
				conn.conexion.Close();				
				
				consul = @"select SUM(CANTIDAD) AS CANTIDAD from ANTICIPOS_ESPECIALES where estatus != '0' AND tipo != 'DEPOSITO' and ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(conn.leer["CANTIDAD"].ToString() != "")
						dgRelacion[12,x].Value = conn.leer["CANTIDAD"].ToString();
					else
						dgRelacion[12,x].Value = 0;
				}	
				conn.conexion.Close();
				
				
				if(dgRelacion[10,x].Value.ToString() != "" && dgRelacion[11,x].Value.ToString() != "" && dgRelacion[12,x].Value.ToString() != "")
					dgRelacion[13,x].Value = (Convert.ToDouble(dgRelacion[10,x].Value) - (Convert.ToDouble(dgRelacion[11,x].Value) + Convert.ToDouble(dgRelacion[12,x].Value))).ToString();
			}
		}
		#endregion
		
		#region BOTONES
		void Label1Click(object sender, EventArgs e)
		{
			adaptador();
		}
		#endregion
	}
}
