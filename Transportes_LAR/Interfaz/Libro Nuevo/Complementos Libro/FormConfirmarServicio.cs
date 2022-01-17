using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormConfirmarServicio : Form
	{
		#region VARIABLES
		int id_re;
		string contacto;
		#endregion
		
		#region INSTANCIAS		
		public FormLibroViajes Libro = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();		
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region CONTRUCTOR
		public FormConfirmarServicio(FormLibroViajes reflibro, Int32 id_r, string nombre)
		{
			InitializeComponent();
			Libro = reflibro;
			id_re = id_r;
			contacto = nombre;				
		}
		#endregion		
		
		#region INICIO - FIN
		void FormConfirmarServicioLoad(object sender, EventArgs e)
		{
			txtConfirma.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CONF_CLIENTE FROM RUTA_ESPECIAL", "CONF_CLIENTE");
           	txtConfirma.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtConfirma.AutoCompleteSource = AutoCompleteSource.CustomSource;  
            txtConfirma.Text = contacto;  
		}
		
		void FormConfirmarServicioFormClosing(object sender, FormClosingEventArgs e)
		{        
		  	Libro.filtrosPrincipales();
		 	Libro.filtrosImprimir();   
		}
		#endregion
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{		 
			if(txtConfirma.Text != "")
			{
				new Conexion_Servidor.Libros.SQL_Libros().confirmaViajeNuevo(txtConfirma.Text, Libro.principal.idUsuario, id_re);
				this.Close();
			}
			else
			{
				MessageBox.Show("Ingrese el nombre de la persona que confirma");
			} 			
		}
		#endregion
		
	}
}
