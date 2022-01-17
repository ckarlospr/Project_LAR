using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormMensajes : Form
	{
		#region VARIABLES
		private double contador1=0.0;
		private double contador2=1.0;
		#endregion
		
		#region CONSTRUCTOR
		public FormMensajes(String texto){
			InitializeComponent();
			timerMensaje.Enabled=true;
			txtMensaje.Text=texto;
		}
		#endregion
		
		#region EVENTO - TIMER
		void TimerMensajeTick(object sender, EventArgs e){
			if(contador1<6){
				this.Opacity=(contador1);
				contador1+=0.1;
			}else if(contador2>0.0){
				this.Opacity=(contador2);
				contador2-=0.1;
			}else{
				timerMensaje.Enabled=false;
				this.Close();
			}
		}
		#endregion		
	}
}
