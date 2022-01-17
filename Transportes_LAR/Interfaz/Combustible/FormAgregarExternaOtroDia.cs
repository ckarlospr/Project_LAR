using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormAgregarExternaOtroDia : Form
	{
		#region CONSTRUCTOR
		public FormAgregarExternaOtroDia(formPrincipalComb refc, Int32 id_u)
		{
			InitializeComponent();
			ID_USUARIO = id_u;
			refprincipal = refc;
		}
		#endregion
		
		#region VARIABLES
		Int32 ID_USUARIO;
		bool respuesta = true;
		#endregion
		
		#region INSTANCIAS
		formPrincipalComb refprincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN
		void FormAgregarExternaOtroDiaLoad(object sender, EventArgs e)
		{
			dtpFecha.Value = DateTime.Now.AddDays(-1);
			dtpFecha.MaxDate = DateTime.Now.AddDays(-1);
		}
		
		void FormAgregarExternaOtroDiaFormClosing(object sender, FormClosingEventArgs e)
		{
			if(respuesta)
				refprincipal.getDatosDatagrid();
		}
		#endregion
		
		#region METODOS
		private void agregarAutorizacion(){
			string consulta = "";
			string numeroA = "0";
			consulta = "SELECT MAX(NUMERO)+1 as NUMERO FROM AUTORIZACION WHERE FECHA_REG = '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"'";								
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				numeroA = conn.leer["NUMERO"].ToString();
			}
			conn.conexion.Close();
			
			if(numeroA == "0")
				numeroA = "01";
			else if(numeroA.Length == 1)
				numeroA = "0"+numeroA;
			
			try{
				for(int x = 0; x < nudDias.Value; x++){
					consulta = @"insert into AUTORIZACION values (0, 0, 0, 0, (SELECT CONVERT (DATETIME, '"+dtpFecha.Value.ToString("yyyy-dd-MM")+"')), "+(Convert.ToInt32(numeroA)+x)+", NULL, NULL, '0.00', NULL, '1', "+ID_USUARIO+", '"+dtpFecha.Value.ToString("yyyy-MM-dd")+"',"+
							" (SELECT CONVERT (TIME, SYSDATETIME())), '', '0.00', NULL, 'LOCAL', NULL, NULL, NULL, NULL, 'EXTERNA', NULL, null, null, null, null, null, null)";
					conn.getAbrirConexion(consulta);
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}	
			}catch(Exception ex){
				MessageBox.Show("Error al insertar la autirización: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}
			if(respuesta){
				MessageBox.Show("Se generaron correctamente las autorizaciones", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}				
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarOtroDiaClick(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(nudDias.Value > 0){
				agregarAutorizacion();				
			}else{
				errorProvider1.SetError(nudDias, "Ingresa la cantidad de autorizaciones");
			}
		}
		#endregion	
	}
}
