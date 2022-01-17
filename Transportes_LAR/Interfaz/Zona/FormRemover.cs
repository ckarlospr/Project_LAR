using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Zona
{
	public partial class FormRemover : Form
	{
		private String[,] zona=null;
		private string id_zona="";
		private Interfaz.FormPrincipal principal=null;
		
		//--CONSTRUCTOR
		public FormRemover(String[,]zona){
			InitializeComponent();
			this.zona=zona;
		}
		
		//--EVENTO LOAD
		void FormRemoverLoad(object sender, EventArgs e){
			getCargarZona(0);
			this.MdiParent=principal;
		}
		
		#region EVENTO_BOTON ( AGREGAR - CANCELAR )
		void BtnEliminarClick(object sender, EventArgs e){
			if(cmbNombreRuta.Text!=""){
				DialogResult result=MessageBox.Show("Al eliminar la zona se eliminará la clasificación de zona del operador y ruta que conincidan con la que se desea eliminar.\n¿Desea eliminar la zona "+cmbNombreRuta.Text+" de la base de datos?","Alerta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
				if(result==DialogResult.OK){
					this.id_zona=zona[Convert.ToInt32(cmbNombreRuta.SelectedIndex.ToString()),0];//CARGNADO_ID_DEL_OPERADOR
					new Conexion_Servidor.Zona.SQL_Zona().getEliminarClasificacion(id_zona);//ELIMINANDO_LA_CLASIFICACION
					new Conexion_Servidor.Zona.SQL_Zona().getModificarZona(this.id_zona,"","","");
					getProcesoEliminar(Convert.ToInt32(cmbNombreRuta.SelectedIndex.ToString()),0);
					getActualizarTabla(0);
					new Interfaz.FormMensaje("Zona eliminada correctamente.").Show();
					this.Close();
				}	
			}else{
				MessageBox.Show("Para eliminar una zona es necesario seleccionar previamente la zona.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		#region CARGAR_LAS_RUTAS_EN_EL_COMBOBOX
		private object getCargarZona(int contador){
			cmbNombreRuta.Items.Add(zona[contador,1]);
			return (contador<(zona.Length/4)-1)?getCargarZona(++contador):null;
		}
		#endregion
		
		#region CICLO_DE_TAMAÑO_DEL_ARRAY 
		private Object getProcesoEliminar(int index, int contador){
			zona[index,contador]="";
			return (contador+1<4)? getProcesoEliminar(index,++contador):getProcesoApilar(0);
		}
		
		private Object getProcesoApilar(int contador){
			int punto =contador;
			if(contador<((zona.Length/4)-1)){
				if(zona[contador,0]==""  && zona[contador+1,0]!=""){
					for(int x=punto;x<zona.Length/4;x++){
						for(int z=0;z<4;z++){
							if(x<(zona.Length/4)-1)
								zona[x,z]=zona[1+x,z];
							else
								zona[x,z]="";
						}
					}
				}
			}
			return (contador<(zona.Length/4)-1)? getProcesoApilar(++contador):getEliminarZona(0);
		}
		#endregion
		
		#region CARGA_CADA_FILA_DEL_ARRAY
		private object getEliminarZona(int contador){
			if(zona[contador,2]!="")
				getIdCadena(zona[contador,2],"",0,contador);
			return (contador<(zona.Length/4)-1)?getEliminarZona(++contador):null;
		}
		#endregion
		
		#region SEPARA_LOS_ID_UNIDOS
		private object getIdCadena(String zonaRelacion,string id_zona,int contador,int localizacion){
			if(contador==0)
				zona[localizacion,2]="";
			if(zonaRelacion.Substring(contador,1)!="-"){
				id_zona+=zonaRelacion.Substring(contador,1);
			}else{
				getCargarId(id_zona,localizacion);
				id_zona="";
			}
			return (contador<zonaRelacion.Length-1)?getIdCadena(zonaRelacion,id_zona,++contador, localizacion):null;
		}
		#endregion
		
		#region CARGA_LOS_ID_NUEVAMENTE_DENTRO_DEL_ARRAY
		private void getCargarId(string id,int localizacion){
			zona[localizacion,2]=( id != this.id_zona)? (id!="")?zona[localizacion,2]+id+"-" : zona[localizacion,2]:  zona[localizacion,2]  ;
		}
		#endregion
		
		#region ACTUALIZAR_LOS_DATOS_DE_LA_TABLA
		private object getActualizarTabla(int contador){
			if(zona[contador,0]!="")
				new Conexion_Servidor.Zona.SQL_Zona().getModificarZona(zona[contador,0],zona[contador,1],zona[contador,2],zona[contador,3]);
			return (contador<(zona.Length/4)-1)? getActualizarTabla(++contador) : null ;
		}
		#endregion
		
	}
}
