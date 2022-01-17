﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Aseguradora.Dato
{

	public class SegurosAseguradoras
	{
		private Color rosita = Color.LightPink;
		private Color blanco = Color.White;
		
		public SegurosAseguradoras(){
		}
		
		#region limpiarCamposAseguradora
		public void limpiarCamposAseguradora(Interfaz.Aseguradora.FormAseguradoras f){
			f.txtNombre.Text = "";
			f.txtDomicilio.Text = "";
			f.txtTelefono.Text = "";
			
			f.txtNombre.BackColor = blanco;
			f.txtDomicilio.BackColor = blanco;
			f.txtTelefono.BackColor = blanco;
		}
		#endregion
		
		#region validarCamposSeguros
		public bool validarCamposSeguro(Interfaz.Aseguradora.FormSeguros fs){
			bool status = true;
			bool fecha = true;
			string sfecha ="Las fechas: ";
			string dato= "Favor de revisar los campos de : ";
			if((fs.txtCobertura.Text =="")||(fs.txtCobertura.Text.Length==0)){
				status = false;
				dato += "Covertura, ";
				fs.txtCobertura.BackColor = rosita;
			}else
				fs.txtCobertura.BackColor = blanco;
			
			if((fs.txtNumeroSeguro.Text =="")||(fs.txtNumeroSeguro.Text.Length==0)){
				status = false;
				dato += "Poliza de Seguros, ";
				fs.txtNumeroSeguro.BackColor = rosita;
			}else
				fs.txtNumeroSeguro.BackColor = blanco;
			
			
			DateTime Hoy = DateTime.Today;
			if(Hoy.CompareTo(Convert.ToDateTime(fs.dtpVencimiento.Text))>=0){
				fecha = false;
				sfecha += "de vencimiento son del mismo día o anterior ";
				fs.dtpVencimiento.CalendarForeColor = rosita;				
	
			}else
				fs.dtpVencimiento.CalendarTitleForeColor = blanco;

			if(!status)
				MessageBox.Show("Favor de Llenar todos los campos marcados antes de continuar.","Campos invalidos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			if(!fecha){
				MessageBox.Show(sfecha + "que a ingresado son incorrectas","Campos invalidos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

				status = fecha;
			}
			return status;
		}
		#endregion
		
		#region validarCamposAseguradora
		public bool validarCamposAseguradora(Interfaz.Aseguradora.FormAseguradoras f){
			bool status = true;
			
			if(f.txtNombre.Text ==""){
				status  = false;
				f.txtNombre.BackColor = rosita;
			}else
				f.txtNombre.BackColor = blanco;
			
			if(f.txtDomicilio.Text ==""){
				status  = false;
				f.txtDomicilio.BackColor = rosita;
			}else
				f.txtDomicilio.BackColor = blanco;
			
			if(f.txtTelefono.Text ==""){
				status  = false;
				f.txtTelefono.BackColor = rosita;
			}else
				f.txtTelefono.BackColor = blanco;
			if(!status)
				MessageBox.Show("Favor de Llenar todos los campos marcados antes de continuar.","campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			
			return status;	
		}
		#endregion
		
	}
}
