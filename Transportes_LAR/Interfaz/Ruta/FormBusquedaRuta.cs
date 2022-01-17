using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta
{
	public partial class FormBusquedaRuta : Form
	{
		string id="";
		public bool buscar=false;
		private Interfaz.Ruta.FormBuscar formBuscar=null;
		private Interfaz.FormPrincipal principal=null;
			
		public FormBusquedaRuta(string id,string empresa,string subNombre, Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.id=id;
			lblTitulo.Text+=" "+empresa+" "+subNombre;
			this.principal =  principal;
		}
		
		#region METODO_LOAD_CLOSING
		void FormBusquedaRutaLoad(object sender, EventArgs e)
		{
			new Conexion_Servidor.Zona.SQL_Zona().getNombreZona(cmbZona);//CARGA_LAS_ZONAS
			dataRuta.DataSource=new Conexion_Servidor.Ruta.SQL_Ruta().getTabla("select ID, Nombre from RUTA where idSubEmpresa="+id+" and TIPO='NRM' order by Nombre");
			getDatoRuta();
			this.MdiParent=principal;
		}
		
		void FormBusquedaRutaFormClosing(object sender, FormClosingEventArgs e){
			
		}
		#endregion
		
		#region EVENTOS_BOTONES (AGREGAR - REMOVER - BUSCAR)
		void BtnAgreagarClick(object sender, EventArgs e){
			new Interfaz.Ruta.FormRuta(null,dataRuta,id,0).ShowDialog();
		}
		
		void BtnRemoverClick(object sender, EventArgs e){
			checkBox1.Checked=false;
			if(dataRuta.Rows.Count>0){
				if(MessageBox.Show("¿Desea eliminar la ruta de la base de datos?","Eliminar ruta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
					new Conexion_Servidor.Ruta.SQL_Ruta().getEliminarRuta(dataRuta[0,dataRuta.CurrentRow.Index].Value.ToString());
					new Interfaz.FormMensaje("Ruta eliminada exitosamente").Show();
					dataRuta.DataSource=new Conexion_Servidor.Ruta.SQL_Ruta().getTabla("select ID, Nombre from RUTA where idSubEmpresa="+id+" and TIPO='NRM' order by Nombre");
					getDatoRuta();
				}
			}
		}
		
		void BtnBuscarClick(object sender, EventArgs e){
			if(dataRuta.Rows.Count>0){
				if(buscar){
					formBuscar.BringToFront();
				}else{
					formBuscar=new Interfaz.Ruta.FormBuscar(this,dataRuta);
					formBuscar.Show();
				}	
			}
		}
		#endregion
		
		#region TABLA_CLICK
		void DataRutaCellClick(object sender, DataGridViewCellEventArgs e){
			checkBox1.Checked=false;
			if(e.RowIndex>=0){
				getDatoRuta();
			}
		}
		#endregion
		
		#region OBTENER_DATOS_DE_RUTA
		private void getDatoRuta()
		{
			if(dataRuta.Rows.Count>0){
				new Conexion_Servidor.Ruta.SQL_Ruta().getDatoRuta(dataRuta[0,dataRuta.CurrentRow.Index].Value.ToString(),
			                                                 	 txtNombre,
			                                                 	 cmbTurno,
			                                                 	 cmbSentido,
			                                                 	 txtKilometros,
			                                                 	 numHora,
			                                                 	 numMinuto,
			                                               		 cmbZona,
			                                                	 txtSencilloCamion,
			                                                  	 txtCompletoCamion,
			                                                 	 txtSencilloCamioneta,
			                                                 	 txtCompletoCamioneta,
			                                                 	 txtSencilloForaneo,
			                                                 	 txtCompletoForaneo,
			                                                 	 txtIntinerario,
			                                                 	 cbxLunes,
			                                                 	 cbxMartes,
			                                                 	 cbxMiercoles,
																 cbxJueves,
																 cbxViernes,
																 cbxSabado,
																 cbxDomingo,
																 cbForanea);
			}else{
				getLimpiarCampo();
			}
		}
		#endregion
		
		#region LIMPIAR_CAMPOS
		private void getLimpiarCampo(){
			txtNombre.Text="";
			cmbTurno.SelectedIndex=0;
			cmbSentido.SelectedIndex=0;
			txtKilometros.Text="";
			numHora.Value=0;
			numMinuto.Value=0;
			txtSencilloCamion.Text="";
			txtCompletoCamion.Text="";
			txtSencilloCamioneta.Text="";
			txtCompletoCamioneta.Text="";
			txtSencilloForaneo.Text="";
			txtCompletoForaneo.Text="";
			txtIntinerario.Text="";
			if(cmbZona.Items.Count>0)
			{
				cmbZona.SelectedIndex=0;	
			}
			cbForanea.Checked=false;
		}
		#endregion
		
		#region EVENTOS_PARA_PODER_MODIFICAR_DATOS (CHECK BOX - KEYPRESS)
		void CheckBox1CheckedChanged(object sender, EventArgs e){
			if(dataRuta.Rows.Count==0){
				checkBox1.Checked=false;
			}else{
				if(checkBox1.Checked==true){
					cmbTurno.Enabled		=true;
					cmbSentido.Enabled		=true;
					cmbZona.Enabled			=true;
					numHora.Enabled			=true;
					numMinuto.Enabled		=true;
					btnModificar.Enabled	=true;
					cbxLunes.Enabled 		=true;
					cbxMartes.Enabled		=true;
					cbxMiercoles.Enabled	=true;
					cbxJueves.Enabled		=true;
					cbxViernes.Enabled		=true;
					cbxSabado.Enabled		=true;
					cbxDomingo.Enabled		=true;
				}else{
					cmbTurno.Enabled		=false;
					cmbSentido.Enabled		=false;
					cmbZona.Enabled			=false;
					numHora.Enabled			=false;
					numMinuto.Enabled		=false;
					btnModificar.Enabled	=false;
					cbxLunes.Enabled 		=false;
					cbxMartes.Enabled		=false;
					cbxMiercoles.Enabled	=false;
					cbxJueves.Enabled		=false;
					cbxViernes.Enabled		=false;
					cbxSabado.Enabled		=false;
					cbxDomingo.Enabled		=false;
					getDatoRuta();
					getValidarCampo();
				}
			}
		}
		
		void TxtNombreKeyPress(object sender, KeyPressEventArgs e){
			if(checkBox1.Checked==true){
				e.Handled=false;
			}else{
				e.Handled=true;
			}
		}
		#endregion
		
		#region CAMBIO_CON_TECLAS_LA_SELECCION_DE_LA_TABLA
		void DataRutaKeyUp(object sender, KeyEventArgs e){
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter){
				if(dataRuta.Rows.Count>0)
				{
					getDatoRuta();
				}
			}
		}
		#endregion
		
		#region EVENTOS_BOTONES (MODIFICAR ACEPTAR)
		void BtnModificarClick(object sender, EventArgs e){
			if(getValidarCampo()){
				MessageBox.Show("Para poder modificar una ruta es necesario completar el llenado de todos los campos.","Modificar ruta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}else{
				if(MessageBox.Show("¿Desea modificar la ruta "+dataRuta[1,dataRuta.CurrentRow.Index].Value.ToString()+"?","Modificar cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
					getModificarRuta();
					new Interfaz.FormMensaje("Ruta modificada exitosamente").Show();
					checkBox1.Checked=false;
                    dataRuta.DataSource = new Conexion_Servidor.Ruta.SQL_Ruta().getTabla("select ID, Nombre from RUTA where idSubEmpresa="+id+" and TIPO='NRM' order by Nombre");
					getDatoRuta();
					
				}	
			}
		}
		void BtnAceptarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		#region SQL_METODOS
		private void getModificarRuta()
		{
			int foranea=0;
			string minuto=(Convert.ToInt16(numMinuto.Text)<10)? "0"+numMinuto.Text:numMinuto.Text;
			string hora=(Convert.ToInt32(numHora.Text)<10)?"0"+numHora.Text+":"+minuto:numHora.Text+":"+minuto;
			string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(cmbZona.Text);
			new Conexion_Servidor.Ruta.SQL_Ruta().getInsertar(dataRuta[0,dataRuta.CurrentRow.Index].Value.ToString(),
			                                                  id,
			                                                  txtNombre.Text,
			                                                  cmbTurno.Text,
			                                                  cmbSentido.Text,
			                                                  txtKilometros.Text,
			                                                  hora,
			                                                  idZona,
			                                                  txtSencilloCamion.Text,
			                                                  txtCompletoCamion.Text,
			                                                  txtSencilloCamioneta.Text,
			                                                  txtCompletoCamioneta.Text,
			                                                  txtSencilloForaneo.Text,
			                                                  txtCompletoForaneo.Text,
			                                                  txtIntinerario.Text,
			                                                  getDias(),
			                                                  foranea=((cbForanea.Checked==true)?1:0)
			                                                 );
		}
		#endregion	
		
		#region VALIDAR_CAMPOS_VACIOS
		private bool getValidarCampo()
		{
			txtNombre.BackColor=(txtNombre.Text=="")?Color.LightPink:Color.White;
			txtKilometros.BackColor=(txtKilometros.Text=="")?Color.LightPink:Color.White;
			txtIntinerario.BackColor=(txtIntinerario.Text=="")?Color.LightPink:Color.White;
			txtSencilloCamioneta.BackColor=(txtSencilloCamioneta.Text=="")?Color.LightPink:Color.White;
			txtCompletoCamioneta.BackColor=(txtCompletoCamioneta.Text=="")?Color.LightPink:Color.White;
			txtSencilloCamion.BackColor=(txtSencilloCamion.Text=="")?Color.LightPink:Color.White;
			txtCompletoCamion.BackColor=(txtCompletoCamion.Text=="")?Color.LightPink:Color.White;
			txtSencilloForaneo.BackColor=(txtSencilloForaneo.Text=="")?Color.LightPink:Color.White;
			txtCompletoForaneo.BackColor=(txtCompletoForaneo.Text=="")?Color.LightPink:Color.White;
			gbDias.BackColor=(  cbxLunes.Checked 		==false&&
								cbxMartes.Checked		==false&&
								cbxMiercoles.Checked	==false&&
								cbxJueves.Checked		==false&&
								cbxViernes.Checked		==false&&
								cbxSabado.Checked		==false&&
								cbxDomingo.Checked		==false)?Color.LightPink:Color.White;
			
			if(cmbZona.Text=="")
				error.SetError(this.cmbZona,"Seleccione una zona"); 
			else
				error.SetError(this.cmbZona,""); 
			
			return (txtNombre.Text				==""||
			        txtKilometros.Text			==""||
			        txtIntinerario.Text			==""||
			        txtSencilloCamion.Text		==""||
			        txtCompletoCamion.Text		==""||
			        txtSencilloCamioneta.Text	==""||
			        txtCompletoCamioneta.Text	==""||
			        txtSencilloForaneo.Text		==""||
			        txtCompletoForaneo.Text		==""||
			        dias()
			       )?true:false;
		}
		
		public bool dias()
		{
			return(	cbxLunes.Checked 		==false&&
					cbxMartes.Checked		==false&&
					cbxMiercoles.Checked	==false&&
					cbxJueves.Checked		==false&&
					cbxViernes.Checked		==false&&
					cbxSabado.Checked		==false&&
					cbxDomingo.Checked		==false)?true:false;
		}
		
		#endregion
		
		#region Obtencion de dias 
		public String getDias()
		{
			String dia="1";
			
			if(cbxLunes.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxMartes.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxMiercoles.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxJueves.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxViernes.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxSabado.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxDomingo.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			
			return dia;
		}
		
		#endregion
		
		void NumHoraKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled=false;
		}
		
		void DataRutaLayout(object sender, LayoutEventArgs e)
		{
			
		}
	}
}
