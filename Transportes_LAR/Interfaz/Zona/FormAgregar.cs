using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Zona
{
	public partial class FormAgregar : Form
	{
		private Interfaz.FormPrincipal principal=null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormAgregar(){
			InitializeComponent();
		}
		
		void FormAgregarZonaFormClosing(object sender, FormClosingEventArgs e){
			if(txtNombre.Text!="" || txtDescripcion.Text!=""){
				DialogResult result=MessageBox.Show("¿Desea cancelar el registro de zona?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
				if(result==DialogResult.Cancel)
					e.Cancel=true;
			}
		}
		
		void BtnAgregarClick(object sender, EventArgs e){
			if(txtNombre.Text!="" && txtDescripcion.Text!=""){
				if(new Conexion_Servidor.Zona.SQL_Zona().getExistencia(txtNombre.Text))
					MessageBox.Show("La zona "+txtNombre.Text+" ya se encuentra registrada dentro de la base de datos.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				else{
					new Conexion_Servidor.Zona.SQL_Zona().getInsertarZona("",txtNombre.Text,"",txtDescripcion.Text);
					txtNombre.Text="";
					txtDescripcion.Text="";
					new Interfaz.FormMensaje("Zona almacenada exitosamente").Show();
				}
			}else{
				MessageBox.Show("Para poder almacenar una nueva zona es necesario llenar el NOMBRE y la DESCRIPCIÓN.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}	
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		
		void FormAgregarLoad(object sender, EventArgs e)
		{
			this.MdiParent=principal;
		}
	}
}
