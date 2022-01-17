using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormContrasena : Form
	{
		#region VARIABLES
		string bandera;
		#endregion
		
		#region CONTRUCTOR
		public FormContrasena(FormCompCombustible repsues, string band)
		{
			InitializeComponent();
			refprincipal = repsues;
			bandera = band;
		}
		#endregion
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(txtContrasena.Text == ((bandera == "PRECIOS")? "Combu1379" : "Combu1249") ){
				refprincipal.respu = true;
				this.Close();
			}else{
				errorProvider1.SetError(txtContrasena, "Lo sentimos la contraseña no es correcta");
				refprincipal.respu = false;
			}
		}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			refprincipal.respu = false;
			this.Close();
		}
		#endregion
		
		#region INTANCIAS
		FormCompCombustible refprincipal;
		#endregion		
		
		#region EVENTOS		
		void TxtContrasenaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				if(txtContrasena.Text == ((bandera == "PRECIOS")? "Combu1379" : "Combu1249") ){
					refprincipal.respu = true;
					this.Close();
				}else{
					errorProvider1.SetError(txtContrasena, "Lo sentimos la contraseña no es correcta");
					refprincipal.respu = false;
				}
			}
		}
		#endregion
	}
}
