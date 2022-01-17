
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento
{
	public partial class FormEstadoUnidad : Form
	{
		#region VARIABLES
		private bool bandera1 = false;
		private bool bandera2 = false;
		private bool bandera3 = false;
		private bool bandera4 = false;
		private bool bandera5 = false;
		private bool bandera6 = false;
		private bool bandera7 = false;
		private bool bandera8 = false;
		private bool bandera9 = false;
		private bool bandera10 = false;
		private bool bandera11 = false;
		public int x;
		public int y;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormEstadoUnidad(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region CONTROL DESPLEGABLES
		void MoverPanelesAdyacentes(int panel, int cant)
		{	
			if(panel < 10){
				x = -2;
				y = (bandera9) ? pLlaves.Location.Y + cant : pExtras.Location.Y + 35;
				pLlaves.Location = new Point(x, y);
			}
			if(panel < 11){
				x = -2;
				y = (bandera10) ? pRodados.Location.Y + cant : pLlaves.Location.Y + 35;
				pRodados.Location = new Point(x, y);
			}
		}
		
		void LbDespl1Click(object sender, EventArgs e)
		{
			if(!bandera1)
			{
				gbCarroceriaE.BringToFront();
				gbCarroceriaE.AutoSize = true;
				lbDespl1.ForeColor = System.Drawing.Color.Red;
				lbDespl1.Text = "-";
				bandera1 = true;
			}
			else
			{
				gbCarroceriaE.SendToBack();
				gbCarroceriaE.AutoSize = false;
				gbCarroceriaE.Height = 10;
				lbDespl1.ForeColor = System.Drawing.Color.Green;
				lbDespl1.Text = "+";
				bandera1 = false;
			}
		}
		
		void LbDespl2Click(object sender, EventArgs e)
		{
			if(!bandera2)
			{	
				gbCarroceriaI.BringToFront();
				gbCarroceriaI.AutoSize = true;
				lbDespl2.ForeColor = System.Drawing.Color.Red;
				lbDespl2.Text = "-";
				bandera2 = true;
			}
			else
			{
				gbCarroceriaI.SendToBack();
				gbCarroceriaI.AutoSize = false;
				gbCarroceriaI.Height = 10;
				lbDespl2.ForeColor = System.Drawing.Color.Green;
				lbDespl2.Text = "+";
				bandera2 = false;
			}
		}
		
		void LbDespl3Click(object sender, EventArgs e)
		{
			if(!bandera3)
			{	
				gbVidrsYesps.BringToFront();
				gbVidrsYesps.AutoSize = true;
				lbDespl3.ForeColor = System.Drawing.Color.Red;
				lbDespl3.Text = "-";
				bandera3 = true;
			}
			else
			{
				gbVidrsYesps.SendToBack();
				gbVidrsYesps.AutoSize = false;
				gbVidrsYesps.Height = 10;
				lbDespl3.ForeColor = System.Drawing.Color.Green;
				lbDespl3.Text = "+";
				bandera3 = false;
			}
		}
		
		void LbDespl4Click(object sender, EventArgs e)
		{
			if(!bandera4)
			{	
				gbSeguridad.BringToFront();
				gbSeguridad.AutoSize = true;
				lbDespl4.ForeColor = System.Drawing.Color.Red;
				lbDespl4.Text = "-";
				bandera4 = true;
			}
			else
			{
				gbSeguridad.SendToBack();
				gbSeguridad.AutoSize = false;
				gbSeguridad.Height = 10;
				lbDespl4.ForeColor = System.Drawing.Color.Green;
				lbDespl4.Text = "+";
				bandera4 = false;
			}
		}
		
		void LbDespl5Click(object sender, EventArgs e)
		{
			if(!bandera5)
			{	
				gbLuces.BringToFront();
				gbLuces.AutoSize = true;
				lbDespl5.ForeColor = System.Drawing.Color.Red;
				lbDespl5.Text = "-";
				bandera5 = true;
			}
			else
			{
				gbLuces.SendToBack();
				gbLuces.AutoSize = false;
				gbLuces.Height = 10;
				lbDespl5.ForeColor = System.Drawing.Color.Green;
				lbDespl5.Text = "+";
				bandera5 = false;
			}
		}
		
		void LbDespl6Click(object sender, EventArgs e)
		{
			if(!bandera6)
			{	
				gbImagen.BringToFront();
				gbImagen.AutoSize = true;
				lbDespl6.ForeColor = System.Drawing.Color.Red;
				lbDespl6.Text = "-";
				bandera6 = true;
			}
			else
			{
				gbImagen.SendToBack();
				gbImagen.AutoSize = false;
				gbImagen.Height = 10;
				lbDespl6.ForeColor = System.Drawing.Color.Green;
				lbDespl6.Text = "+";
				bandera6 = false;
			}
		}
		
		void LbDespl7Click(object sender, EventArgs e)
		{
			if(!bandera7)
			{	
				gbAudioYvideo.BringToFront();
				gbAudioYvideo.AutoSize = true;
				lbDespl7.ForeColor = System.Drawing.Color.Red;
				lbDespl7.Text = "-";
				bandera7 = true;
			}
			else
			{
				gbAudioYvideo.SendToBack();
				gbAudioYvideo.AutoSize = false;
				gbAudioYvideo.Height = 10;
				lbDespl7.ForeColor = System.Drawing.Color.Green;
				lbDespl7.Text = "+";
				bandera7 = false;
			}
		}
		
		void LbDespl8Click(object sender, EventArgs e)
		{
			if(!bandera8)
			{	
				gbDocument.BringToFront();
				gbDocument.AutoSize = true;
				lbDespl8.ForeColor = System.Drawing.Color.Red;
				lbDespl8.Text = "-";
				bandera8 = true;
			}
			else
			{
				gbDocument.SendToBack();
				gbDocument.AutoSize = false;
				gbDocument.Height = 10;
				lbDespl8.ForeColor = System.Drawing.Color.Green;
				lbDespl8.Text = "+";
				bandera8 = false;
			}
		}
		
		void LbDespl9Click(object sender, EventArgs e)
		{
			if(!bandera9)
			{	
				gbExtras.BringToFront();
				gbExtras.Height = 49;
				MoverPanelesAdyacentes(9, gbExtras.Height);
				lbDespl9.ForeColor = System.Drawing.Color.Red;
				lbDespl9.Text = "-";
				bandera9 = true;
			}
			else
			{
				gbExtras.SendToBack();
				gbExtras.Height = 10;
				MoverPanelesAdyacentes(9, gbExtras.Height);
				lbDespl9.ForeColor = System.Drawing.Color.Green;
				lbDespl9.Text = "+";
				bandera9 = false;
			}
		}
		
		void LbDespl10Click(object sender, EventArgs e)
		{
			if(!bandera10)
			{	
				gbLlaves.BringToFront();
				gbLlaves.Height = 87;
				MoverPanelesAdyacentes(10, gbLlaves.Height);
				lbDespl10.ForeColor = System.Drawing.Color.Red;
				lbDespl10.Text = "-";
				bandera10 = true;
			}
			else
			{
				gbLlaves.SendToBack();
				gbLlaves.Height = 10;
				MoverPanelesAdyacentes(10, gbLlaves.Height);
				lbDespl10.ForeColor = System.Drawing.Color.Green;
				lbDespl10.Text = "+";
				bandera10 = false;
			}
		}
		
		void LbDespl11Click(object sender, EventArgs e)
		{
			if(!bandera11)
			{	
				gbRodados.BringToFront();
				gbRodados.Height = 150;
				lbDespl11.ForeColor = System.Drawing.Color.Red;
				lbDespl11.Text = "-";
				bandera11 = true;
			}
			else
			{
				gbRodados.SendToBack();
				gbRodados.Height = 10;
				lbDespl11.ForeColor = System.Drawing.Color.Green;
				lbDespl11.Text = "+";
				bandera11 = false;
			}
		}
		#endregion
	}
}
