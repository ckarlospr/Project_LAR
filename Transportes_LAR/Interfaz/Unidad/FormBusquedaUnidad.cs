using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Unidad
{
	public partial class FormBusquedaUnidad : Form
	{
		#region INSTANCIAS
		public  bool unidad=false;
		private Interfaz.Unidad.FormUnidad formUnidad=null;
		private Interfaz.FormPrincipal principal=null;
		private Conexion_Servidor.Unidad.SQL_Unidad connU = new Conexion_Servidor.Unidad.SQL_Unidad();
		#endregion
				
		int id_usuario = 0;
		
		#region CONSTRUCTOR
		public FormBusquedaUnidad(Interfaz.FormPrincipal principal, int id_usu){
			InitializeComponent();
			//dataGridViewUnidad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
			this.principal=principal;
			id_usuario = id_usu;
		}
		#endregion
		
		#region CONSULTAS_LIKE_DE_LA_UNIDAD
		void TxtBusquedaNumeroTextChanged(object sender, EventArgs e){
			consultaLista();
		}
		
		public void consultaLista()
		{
			dataGridViewUnidad.DataSource=new Conexion_Servidor.Unidad.SQL_Unidad().getTabla(
											"SELECT ID,Numero as UnidadNumero, " +
											"estatus as Unidad_estatus, " +
											"Tipo_Unidad as Unidad_Tipo, " +
											"Tipo_Servicio as UnidadServicio, " +
											"Marca as Unidad_Marca, " +
											"Modelo as Unidad_Modelo, " +
											"ano as Unidad_Ano, " +
											"Placa_Federal as Unidad_Federal, " +
											"Placa_Estatal as Unidad_Estatal, " +
											"Numero_Serie as Unidad_num_serie, " +
											"Motor_Nombre as Unidad_nom_motor, " +
											"Motor_Modelo as Unidad_mod_motor, " +
											"Motor_Num_Serie as Unidad_num_motor, " +
											"Diferencial as Unidad_diferencial, " +
											"Paso_Diferencial as Paso_dif, " +
											"Tipo_llanta as Tipo_llanta, " +
											"Perimetro_llanta as Peri_llanta, " +
											"Potencia_vehiculo as Unidad_potencia, " +
											"Caja_Nombre as Unidad_nom_caja, " +
											"Caja_modelo as Modelo_caja, " +
											"U_Relacion as U_rel, " +
											"Torque_Vehiculo as Unidad_torque, " +
											"Capacidad_Tantque as Cap_tanque, " +
											"Capacidad as Unidad_cap " +
											"FROM VEHICULO WHERE Numero like '" + txtBusquedaNumero.Text + "%' " +
											"and Placa_Federal like '" + txtBusquedaFederal.Text + "%' " +
											"and Placa_Estatal like '" + txtBusquedaEstatal.Text + "%' " +
											"and Tipo_Servicio like '" + cmbBusquedaTipoServ.Text + "%' " +
											"and Tipo_Unidad like '" + cmbBusquedaTipoUnidad.Text + "%' " +
											"and Marca like '" + txtBusquedaMarca.Text + "%' ");// +
											//"and Estado =1");
		}
		
		public void consultaLista2()
		{
			dataGridViewUnidad.DataSource=new Conexion_Servidor.Unidad.SQL_Unidad().getTabla("SELECT ID,Numero as UnidadNumero, estatus as Unidad_estatus,Tipo_Unidad as Unidad_Tipo,Tipo_Servicio as UnidadServicio,Marca as Unidad_Marca,Modelo as Unidad_Modelo,ano as Unidad_Ano,Placa_Federal as Unidad_Federal,Placa_Estatal as Unidad_Estatal, " +
			                                                                                 "Numero_Serie as Unidad_num_serie, Motor_Nombre as Unidad_nom_motor, Motor_Modelo as Unidad_mod_motor, Motor_Num_Serie as Unidad_num_motor, Diferencial as Unidad_diferencial, Paso_Diferencial as Paso_dif, " +
			                                                                                 "Tipo_llanta as Tipo_llanta, Perimetro_llanta as Peri_llanta, Potencia_vehiculo as Unidad_potencia, Caja_Nombre as Unidad_nom_caja, Caja_modelo as Modelo_caja, U_Relacion as U_rel, Torque_Vehiculo as Unidad_torque, " +
			                                                                                 "Capacidad_Tantque as Cap_tanque, Capacidad as Unidad_cap FROM VEHICULO");
		}
		#endregion
		
		#region EVENTO_BOTONES
		void BtnNuevoClick(object sender, EventArgs e){
			if(unidad){
				if(formUnidad.WindowState==FormWindowState.Minimized)
					formUnidad.WindowState = FormWindowState.Normal;
				else
					formUnidad.BringToFront();
			}else{
				this.formUnidad = new Transportes_LAR.Interfaz.Unidad.FormUnidad(this, id_usuario);
				formUnidad.Show();
				unidad=true;
			}
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(dataGridViewUnidad.Rows.Count>0)
			{
				if(unidad)
				{
					MessageBox.Show("El proceso de modificar no se puede llevar a cabo debido a que actualmente se encuentra abierta la ventana de vehículo","Modificar vehículo",MessageBoxButtons.OK,MessageBoxIcon.Error);
					if(formUnidad.WindowState==FormWindowState.Minimized)
						formUnidad.WindowState = FormWindowState.Normal;
					else
						formUnidad.BringToFront();
				}else{
					this.formUnidad=new Transportes_LAR.Interfaz.Unidad.FormUnidad(this,dataGridViewUnidad[0,dataGridViewUnidad.CurrentRow.Index].Value.ToString(), id_usuario);
					formUnidad.Show();
					unidad=true;
				}	
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e){
			if(dataGridViewUnidad.Rows.Count>0){
				if(MessageBox.Show("¿Desea eliminar al vehículo seleccionado?","Eliminar vehículo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
					connU.eliminaUnidad(Convert.ToInt32(dataGridViewUnidad[0,dataGridViewUnidad.CurrentRow.Index].Value), principal.idUsuario);
					MessageBox.Show("Se elimino correctamente la unidad","Listo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					dataGridViewUnidad.Rows.RemoveAt(dataGridViewUnidad.CurrentRow.Index);
				}
			}
		}
		#endregion
		
		
		void FormBusquedaUnidadFormClosing(object sender, FormClosingEventArgs e){
			this.principal.busquedaUnidad=false;
		}
		
		void FormBusquedaUnidadLoad(object sender, EventArgs e)
		{
			
		}
	}
}
