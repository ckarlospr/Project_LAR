using System;
using System.Drawing;
using System.Windows.Forms;
using Transportes_LAR.Interfaz.Libro_Nuevo.Dato;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormCambiarAcuerdo : Form
	{
		#region VARIABLES
		int idprospecto = 0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.Libro_Nuevo.FormLibroViajes refLibro = null;
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
			
		#region CONSTRUCTOR			
		public FormCambiarAcuerdo(FormLibroViajes refLibro)
		{
			InitializeComponent();
			this.refLibro = refLibro;
		}
		
		public FormCambiarAcuerdo(FormLibroViajes refLibro, int id)
		{
			InitializeComponent();
			this.refLibro = refLibro;
			this.idprospecto = id;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCambiarAcuerdoLoad(object sender, EventArgs e)
		{
			txtDestino.Text = refLibro.txtEvento.Text;
			lblContacto.Text = refLibro.txtContacto.Text;
			dtpFechaAcuerdo.Value = DateTime.Now.AddDays(1);		
			
			if(idprospecto != 0){
				lblId.Text = "ID: "+idprospecto;
			}
		}
		
		void FormCambiarAcuerdoFormClosing(object sender, FormClosingEventArgs e)
		{			
			refLibro.dgCotizacionesRealizadas.ClearSelection();
			refLibro.modifcarCotizacion = false;		
			
			if(idprospecto != 0){
				refLibro.filtros();
				refLibro.limpiar();			
			}
		}
		#endregion
		
		#region BOTON		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(idprospecto == 0){
				refLibro.validarAcuerdo = true;
				refLibro.fechaAcuerdo = dtpFechaAcuerdo.Value.ToString("yyyy-MM-dd");
				this.Close();
			}else{
				connL.cambiarFechaAcuerdo(idprospecto, dtpFechaAcuerdo.Value.ToString("yyyy-MM-dd"));
				this.Close();
				refLibro.limpiaAccion();
			}			
		}
		#endregion				
	}
}
