using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Unidad
{
	public partial class FormFotos : Form
	{
		int j=0;
		bool borrando=false;
		protected Graphics myGraphics;
		private ListViewItem lstItem = null;
		private int ID = 0;
		private Interfaz.Unidad.FormUnidad fu = null;
		private int indexanterior =999;
		private int index = 0;
		List<FotografiaU> foto = new List<FotografiaU>();
         protected String DESCRIPCION = "Si lo desea, añada una descripción.";
		public FormFotos(Interfaz.Unidad.FormUnidad fu)
		{
			this.fu = fu;
			this.ID = Convert.ToInt32(fu.idUnidad);
			
			InitializeComponent();
 			btnEliminarFoto();
 			this.BringToFront();
 			
 			fu.fotosabierto = true;
 			fu.Enabled = false;
 			if(this.ID!=0){
				foto = new Conexion_Servidor.Unidad.SQL_UnidadFotos().getDatosFotos(this.ID.ToString());
				j = foto.Count;
				if(j!=0){
					visualizar(index);
					cargarListas();
				}
			}
 			
		}
         
		private void cargarListas(){
			int c = 0;
			while(c<j){								
				imageList1.Images.Add(foto[c].image);
		        lstItem = new ListViewItem();
				lstItem.ImageIndex = c;
		       	listView1.Items.Add(lstItem);
		        c++;
			}
				listView1.LargeImageList = imageList1;
				btnEliminarFoto();	
		}
		
	    private void Button1Click(object sender, EventArgs e)        {

           OpenFileDialog openfilediaglog1 = new OpenFileDialog();
           openfilediaglog1.Title = "Fotografias del Vehiculo";
           openfilediaglog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
           openfilediaglog1.Multiselect = true;
			
         
          if (openfilediaglog1.ShowDialog() == DialogResult.OK)	{
           		int x = j;
		       	for(int c = 0; c < openfilediaglog1.FileNames.Length; c++)	{
               		Image i = Image.FromFile(openfilediaglog1.FileNames[c].ToString());
		      		foto.Add(new Interfaz.Unidad.FotografiaU(0,ID,"",i));
		            imageList1.Images.Add(foto[j].image);
		            lstItem = new ListViewItem();
					lstItem.ImageIndex = j;
		       		listView1.Items.Add(lstItem);
		            j++;
		       } 
		       listView1.LargeImageList = imageList1;
		       visualizar(x);
		       indexanterior = index;
		       index = x;
           }
           btnEliminarFoto();
        }
		
		
		private void btnEliminarFoto(){
			if(j==0) button2.Enabled = false;
			else button2.Enabled = true;
		}
		
		private void visualizar(int i){	
			if(foto.Count!=0){
			pbFotos.Image = foto[i].image;
			txtDescripcion.Text = foto[i].Descripcion;
			}else
				pbFotos.Image = null;
			if(txtDescripcion.Text == "")
				txtDescripcion.Text = DESCRIPCION;
			
			btnAgregaDescripcion.Enabled=false;
		}
		
		private void modDesc(){
			String msg ="";
			if((!foto[index].Descripcion.Equals(txtDescripcion.Text))&&(!DESCRIPCION.Equals(txtDescripcion.Text))){
				msg = foto[index].ID_Foto + "-"+foto[index].ID_Unidad + " '" +
		  		foto[index].Descripcion + "' cambiado por '" +
		  		txtDescripcion.Text + "'\n ";
					
		  		foto[index].Descripcion= txtDescripcion.Text;
		  		if(ID!=0){
		  			new Conexion_Servidor.Unidad.SQL_UnidadFotos().
		  				getModificarFoto(foto[index].ID_Foto.ToString(),
		  				                 foto[index].ID_Unidad.ToString(),
		  				                 foto[index].Descripcion);
		  			msg += "MODIFICADO EN BD";
		  		}
			}
			new Interfaz.FormMensaje("Datos Modificados Correctamente");
		}

		void ListView1ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e){
			if(!borrando){
			  	indexanterior = index;
			  	index = listView1.FocusedItem.Index;
		  		if(indexanterior!=index){
					if(indexanterior==999)
						indexanterior=index;
					visualizar(index);
			  		
		  		}
			}
		}
		
		void BtnAgregaDescripcionClick(object sender, EventArgs e){
			modDesc();
			btnAgregaDescripcion.Enabled = false;
		}
		
		void TxtDescripcionTextChanged(object sender, EventArgs e){
			if(foto[index].Descripcion.Equals(txtDescripcion.Text))
				btnAgregaDescripcion.Enabled = false;
			else
				btnAgregaDescripcion.Enabled = true;
		}
		
		
		void but(object sender, EventArgs e){
			try{
				borrando=true;
				if(!fu.guardar)
					new Conexion_Servidor.Unidad.SQL_UnidadFotos().getEliminarFoto(foto[index].ID_Unidad.ToString(),foto[index].ID_Foto.ToString());
				foto.RemoveAt(index);
				listView1.Items.Clear();
				imageList1.Images.Clear();
				j--;	
				indexanterior = index;
				if((index<=j)&&(j>=1)){
					if(index==j){
						index--;
					}
				}
				cargarListas();			
				listView1.LargeImageList = imageList1;
				borrando=false;
				btnEliminarFoto();
				visualizar(index);
			}catch(Exception ex){
				MessageBox.Show(ex.ToString(),"");
			}
		}
		
		
		void BtnAceptarClick(object sender, EventArgs e){
			new Conexion_Servidor.Unidad.SQL_UnidadFotos().getInsertarFoto(ID.ToString(),foto);
			this.Close();
		}
		
		void TxtDescripcionEnter(object sender, EventArgs e){
			txtDescripcion.SelectionStart = 0;
			txtDescripcion.SelectionLength = txtDescripcion.Text.Length;
		}
		
		void TxtDescripcionMouseDown(object sender, MouseEventArgs e){
			txtDescripcion.SelectionStart = 0;
			txtDescripcion.SelectionLength = txtDescripcion.Text.Length;
		}
		
		void FormFotosFormClosed(object sender, FormClosedEventArgs e){
			fu.Enabled=true;
			fu.fotosabierto= false;
			if(fu.guardar){			
				fu.limpianuevo();
				fu.BringToFront();
				new Interfaz.FormMensaje("Datos Guardados Correctamente");
			}else{
				fu.BringToFront();
			}
		}
		
	}
}
