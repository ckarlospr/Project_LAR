using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormCancelacionCotizacion : Form
	{
		#region VARIABLES
		Int32 id_re = 0;
		Int32 id_c;
		string servicioContinua;
		#endregion
		
		#region INSTANCIAS
		Interfaz.Libro_Nuevo.FormLibroViajes refLibro = null;
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region CONSTRUCTOR
		public FormCancelacionCotizacion(FormLibroViajes libro, int id_co)
		{
			InitializeComponent();
			refLibro = libro;
			id_c = id_co;
		}
		
		public FormCancelacionCotizacion(FormLibroViajes libro, int id_co, int id_r)
		{
			InitializeComponent();
			refLibro = libro;
			id_c = id_co;
			id_re = id_r;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCancelacionCotizacionLoad(object sender, EventArgs e)
		{
			lblID.Text = "ID Cotización: "+id_c;
			txtDestino.Text = refLibro.txtEvento.Text;
		}
		
		void FormCancelacionCotizacionFormClosing(object sender, FormClosingEventArgs e)
		{			
			refLibro.modifcarCotizacion = false;
			refLibro.filtrosPrincipales();
			refLibro.filtros();
			refLibro.limpiar();
		}
		#endregion
		
		#region BOTONES 
		void BtnAceptarClick(object sender, EventArgs e)
		{		
			string observaciones1 = "";
			
			if(cbCantidadP.Checked == true)
				observaciones1 = cbCantidadP.Text;
			
			if(cbPrecio.Checked == true)
				observaciones1 = cbPrecio.Text;
			
			if(cbFactorE.Checked == true){				
				observaciones1 = txtFactorE.Text;
			}
			
			if(cbClaveEspecial.Checked == true)
				observaciones1 = cbClaveEspecial.Text;
			
			if(observaciones1 != ""){
				string ida = "";
				if(id_re == 0)
					ida = id_c.ToString();
				else
					 ida = refLibro.dgControlPRE[0,refLibro.dgControlPRE.CurrentRow.Index].Value.ToString();
				DialogResult respuesta = MessageBox.Show("¿Deseas Cancelar este servicio ? " + ida , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					if(id_re == 0){
						connL.cancelarProspecto(id_c,refLibro.principal.idUsuario, servicioContinua, observaciones1);
					}else{
						connL.cancelarServicio(refLibro.principal.idUsuario, servicioContinua, observaciones1, id_re, id_c);
						if(refLibro.dgControlPRE[11, refLibro.dgControlPRE.CurrentRow.Index].Value.ToString() == "2" || refLibro.dgControlPRE[11, refLibro.dgControlPRE.CurrentRow.Index].Value.ToString() == "3"){
							connL.EliminarFactura2(refLibro.dgControlPRE[0,refLibro.dgControlPRE.CurrentRow.Index].Value.ToString(), "0");								
						}
					}
				}						
				this.Close();
			}else{
				MessageBox.Show("Selecciona un factor por el cual se canceló la cotización o servicio.", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
		
		#region EVENTOS RADIOBUTONS
		void RbsiCheckedChanged(object sender, EventArgs e)
		{
			servicioContinua = rbsi.Text;
		}
		
		void RbNoCheckedChanged(object sender, EventArgs e)
		{
			servicioContinua = rbNo.Text;
		}
		#endregion		
		
		void CbFactorECheckedChanged(object sender, EventArgs e)
		{
			if(cbFactorE.Checked == true){
				txtFactorE.Enabled = true;
				txtFactorE.Text = "";
				txtFactorE.Focus();
			}else{				
				txtFactorE.Enabled = false;
				txtFactorE.Text = "";
			}
		}
	}
}
