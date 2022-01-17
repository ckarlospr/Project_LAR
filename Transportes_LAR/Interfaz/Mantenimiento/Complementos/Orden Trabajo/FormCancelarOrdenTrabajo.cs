using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	
	public partial class FormCancelarOrdenTrabajo : Form
	{
		#region VARIABLES		
		int idordenT;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento conn= new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		Interfaz.Mantenimiento.FormOrdenTrabajo ordenTrabajo = null;	
		#endregion		
	
		#region CONSTRUCTOR		
		public FormCancelarOrdenTrabajo(int idOT, Interfaz.Mantenimiento.FormOrdenTrabajo OT)
		{			
			InitializeComponent();
			idordenT = idOT;
			ordenTrabajo = OT;	
		}	
		#endregion
		
		#region INICIO - SALIDA
		void FormCancelarOrdenTrabajoLoad(object sender, EventArgs e)
		{			
			lblordent.Text = "Orden de trabajo: " + idordenT;
			dtpFechanNueva.MinDate = DateTime.Now.Date;	
			dtpFechanNueva.Value = dtpFechanNueva.MinDate;		
			timeHoraNueva.Text = "08:00";			
		}
		
		void FormCancelarOrdenTrabajoFormClosing(object sender, FormClosingEventArgs e)
		{
			ordenTrabajo.cancelarordentrabajo = false;
			ordenTrabajo.LimpriarVariablesyTablasyCampos();
			ordenTrabajo.dataGenerada.ClearSelection();
			ordenTrabajo.dataOrdenTDIA.ClearSelection();
			ordenTrabajo.dataOrdenTQuedan.ClearSelection();		
			ordenTrabajo.dataFallasPendientes.ClearSelection();		
		}	
		#endregion
		
		#region BOTONES
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnCambiarClick(object sender, EventArgs e)
		{
			String fechaAnterior = conn.FechaOrdenTrabajo(idordenT);
		    String horaAnterior = conn.HoraOrdenTrabajo(idordenT);
				if(txtPersona.Text.Length > 0){		    	
			    	if(txtMotivos.Text.Length > 0){		    		
			    			conn.CancelarOrdenTrabajo(idordenT, fechaAnterior, horaAnterior, dtpFechanNueva.Value.ToString("dd/MM/yyyy"), timeHoraNueva.Value.ToString("HH:mm"), txtPersona.Text, txtMotivos.Text);
			    			this.Close();
			    	}else{ 
		    			txtMotivos.Focus();
		    		}			    	
				}else{
					txtPersona.Focus();
				}
		}
		#endregion			
	}
}
