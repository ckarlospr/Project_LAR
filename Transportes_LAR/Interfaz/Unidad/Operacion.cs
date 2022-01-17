using System;
using System.Drawing;

namespace Transportes_LAR.Interfaz.Unidad
{
	public class Operacion
	{
		private Interfaz.Unidad.FormUnidad unidad=null;
		
		public Operacion(Interfaz.Unidad.FormUnidad unidad){
			this.unidad=unidad;
		}

		public bool getValidarCampo(){
			unidad.txtPropietario.BackColor			=(unidad.txtPropietario.Text=="")?Color.LightPink:Color.White;
			unidad.txtMarca.BackColor				=(unidad.txtMarca.Text=="")?Color.LightPink:Color.White;
			unidad.txtAno.BackColor					=(unidad.txtAno.Text=="")?Color.LightPink:Color.White;
			unidad.txtModelo.BackColor				=(unidad.txtModelo.Text=="")?Color.LightPink:Color.White;
			unidad.txtNumSerie.BackColor			=(unidad.txtNumSerie.Text=="")?Color.LightPink:Color.White;
			unidad.txtNumAsiento.BackColor			=(unidad.txtNumAsiento.Text=="")?Color.LightPink:Color.White;
			unidad.txtNumUnidad.BackColor			=(unidad.txtNumUnidad.Text=="")?Color.LightPink:Color.White;
			unidad.txtPlacaEstatal.BackColor		=(unidad.txtPlacaEstatal.Text=="")?Color.LightPink:Color.White;
			unidad.txtPlacaFederal.BackColor		=(unidad.txtPlacaFederal.Text=="")?Color.LightPink:Color.White;
			unidad.txtMotor.BackColor				=(unidad.txtMotor.Text=="")?Color.LightPink:Color.White;
			unidad.txtModeloMotor.BackColor			=(unidad.txtModeloMotor.Text=="")?Color.LightPink:Color.White;
			unidad.txtNSerieMotor.BackColor			=(unidad.txtNSerieMotor.Text=="")?Color.LightPink:Color.White;
			unidad.txtPotencia.BackColor			=(unidad.txtPotencia.Text=="")?Color.LightPink:Color.White;
			unidad.txtTorque.BackColor				=(unidad.txtTorque.Text=="")?Color.LightPink:Color.White;
			unidad.txtRendimiento.BackColor			=(unidad.txtRendimiento.Text=="")?Color.LightPink:Color.White;
			unidad.txtTipoLlanta.BackColor			=(unidad.txtTipoLlanta.Text=="")?Color.LightPink:Color.White;
			unidad.txtPerimetroLlanta.BackColor		=(unidad.txtPerimetroLlanta.Text=="")?Color.LightPink:Color.White;
			unidad.txtMarcaCaja.BackColor			=(unidad.txtMarcaCaja.Text=="")?Color.LightPink:Color.White;
			unidad.txtModeloCaja.BackColor			=(unidad.txtModeloCaja.Text=="")?Color.LightPink:Color.White;
			unidad.txtURelacionCaja.BackColor		=(unidad.txtURelacionCaja.Text=="")?Color.LightPink:Color.White;
			unidad.txtMarccaDiferencial.BackColor	=(unidad.txtMarccaDiferencial.Text=="")?Color.LightPink:Color.White;
			unidad.txtPasoDiferencial.BackColor		=(unidad.txtPasoDiferencial.Text=="")?Color.LightPink:Color.White;
			unidad.txtCapacidad.BackColor			=(unidad.txtCapacidad.Text=="")?Color.LightPink:Color.White;
			return (unidad.txtPropietario.Text		==""||
			       	unidad.txtMarca.Text			==""||
			       	unidad.txtAno.Text				==""||
			       	unidad.txtModelo.Text			==""||
			       	unidad.txtNumSerie.Text			==""||
			       	unidad.txtNumAsiento.Text		==""||
			       	unidad.txtNumUnidad.Text		==""||
			       	unidad.txtPlacaEstatal.Text		==""||
			       	unidad.txtPlacaFederal.Text		==""||
			       	unidad.txtMotor.Text			==""||
			       	unidad.txtModeloMotor.Text		==""||
			       	unidad.txtNSerieMotor.Text		==""||
			       	unidad.txtPotencia.Text			==""||
			       	unidad.txtTorque.Text			==""||
			       	unidad.txtRendimiento.Text		==""||
			       	unidad.txtTipoLlanta.Text		==""||
			       	unidad.txtPerimetroLlanta.Text	==""||
			       	unidad.txtMarcaCaja.Text		==""||
			       	unidad.txtModeloCaja.Text		==""||
			       	unidad.txtURelacionCaja.Text	==""||
			       	unidad.txtMarccaDiferencial.Text==""||
			       	unidad.txtPasoDiferencial.Text	==""||
			       	unidad.txtCapacidad.Text		==""
			       )?true:false;
		}
		
		public void getLimpiarCampo(){
			unidad.txtPropietario.Text		="";
			unidad.txtMarca.Text			="";
			unidad.txtAno.Text				="";
			unidad.txtModelo.Text			="";
			unidad.txtNumSerie.Text			="";
			unidad.txtNumAsiento.Text		="";
			unidad.txtNumUnidad.Text		="";
			unidad.txtPlacaEstatal.Text		="";
			unidad.txtPlacaFederal.Text		="";
			unidad.txtMotor.Text			="";
			unidad.txtModeloMotor.Text		="";
			unidad.txtNSerieMotor.Text		="";
			unidad.txtPotencia.Text			="";
			unidad.txtTorque.Text			="";
			unidad.txtRendimiento.Text		="";
			unidad.txtTipoLlanta.Text		="";
			unidad.txtPerimetroLlanta.Text	="";
			unidad.txtMarcaCaja.Text		="";
			unidad.txtModeloCaja.Text		="";
			unidad.txtURelacionCaja.Text	="";
			unidad.txtMarccaDiferencial.Text="";
			unidad.txtPasoDiferencial.Text	="";
			unidad.txtCapacidad.Text		="";
			unidad.rbForaneo.Checked		=true;
			unidad.rbTipoCamion.Checked		=true;
			unidad.tabControl1.SelectedIndex = 0;
		}
		
	}
}
