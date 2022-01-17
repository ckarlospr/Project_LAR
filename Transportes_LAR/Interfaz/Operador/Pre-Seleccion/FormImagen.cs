using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormImagen : Form
	{		
		/*
		 Camisa	100	60	-90	-200
		 Pantalon	100	60	-90	-200
		 Limpieza Calzado	100	60	-90	-200
 		*/

 		#region INSTANCIAS
		private FormContratacion contratacion = null;
		#endregion
		
		#region CONSTRUCTORES
		public FormImagen(FormContratacion refprincipal)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
		}
		#endregion
		
		#region INICIO - FIN	
		void FormImagenLoad(object sender, EventArgs e)
		{
			if(contratacion.peinado == 100)
				 btnPeinado1.Enabled = false;
			else if(contratacion.peinado == 75)
				 btnPeinado2.Enabled = false;
			else if(contratacion.peinado == 50)
				 btnPeinado3.Enabled = false;
			else if(contratacion.peinado == 25)
				 btnPeinado4.Enabled = false;
			else{
				btnPeinado1.Enabled = true;
	            btnPeinado2.Enabled = true;
	            btnPeinado3.Enabled = true;
	            btnPeinado4.Enabled = true;
			}
			
			if(contratacion.pelo == 100)
				 btnPelo1.Enabled = false;
			else if(contratacion.pelo == 75)
				 btnPelo2.Enabled = false;
			else if(contratacion.pelo == 50)
				 btnPelo3.Enabled = false;
			else if(contratacion.pelo == 25)
				 btnPelo4.Enabled = false;
			else{
				btnPelo1.Enabled = true;
	            btnPelo2.Enabled = true;
	            btnPelo3.Enabled = true;
	            btnPelo4.Enabled = true;
			}
			
			if(contratacion.manosCara == 100)
				 btnManos1.Enabled = false;
			else if(contratacion.manosCara == 75)
				 btnManos2.Enabled = false;
			else if(contratacion.manosCara == 50)
				 btnManos3.Enabled = false;
			else if(contratacion.manosCara == 25)
				 btnManos4.Enabled = false;
			else{
				btnManos1.Enabled = true;
	            btnManos2.Enabled = true;
	            btnManos3.Enabled = true;
	            btnManos4.Enabled = true;
			}
			
			if(contratacion.rasurado == 100)
				 btnRasurado1.Enabled = false;
			else if(contratacion.rasurado == 0)
				 btnRasurado4.Enabled = false;
			else{
				btnRasurado1.Enabled = true;
	            btnRasurado4.Enabled = true;
			}
			
			if(contratacion.calzado == 100)
				 btnCalzado1.Enabled = false;
			else if(contratacion.calzado == 75)
				 btnCalzado2.Enabled = false;
			else if(contratacion.calzado == 50)
				 btnCalzado3.Enabled = false;
			else if(contratacion.calzado == 25)
				 btnCalzado4.Enabled = false;
			else{
				btnCalzado1.Enabled = true;
	            btnCalzado2.Enabled = true;
	            btnCalzado3.Enabled = true;
	            btnCalzado4.Enabled = true;
			}
					
			if(contratacion.ropa == 100)
				 btnRopa1.Enabled = false;
			else if(contratacion.ropa == 75)
				 btnRopa2.Enabled = false;
			else if(contratacion.ropa == 50)
				 btnRopa3.Enabled = false;
			else if(contratacion.ropa == 25)
				 btnRopa4.Enabled = false;
			else{
				btnRopa1.Enabled = true;
	            btnRopa2.Enabled = true;
	            btnRopa3.Enabled = true;
	            btnRopa4.Enabled = true;
			}
			
			if(contratacion.vestimenta == 100)
				 btnCorbata.Enabled = false;
			else if(contratacion.vestimenta == 75)
				 btnCamisa.Enabled = false;
			else if(contratacion.vestimenta == 50)
				 btnPlayera.Enabled = false;
			else if(contratacion.vestimenta == 25)
				 btnCamiseta.Enabled = false;
			else{	            
	            btnCorbata.Enabled = true;
	            btnCamisa.Enabled = true;
	            btnPlayera.Enabled = true;
	            btnCamiseta.Enabled = true;
			}			

			if(contratacion.presentacionCamisa1 == 100)
				 btnPlanchada.Enabled = false;
			else if(contratacion.presentacionCamisa1 == 0)
				 btnArrugado.Enabled = false;
			else{
				btnPlanchada.Enabled = true;
	            btnArrugado.Enabled = true;
			}

			if(contratacion.presentacionCamisa2 == 100)
				 btnAbotonado.Enabled = false;
			else if(contratacion.presentacionCamisa2 == 0)
				 btnDesabotonado.Enabled = false;
			else{
				btnPlanchada.Enabled = true;
	            btnDesabotonado.Enabled = true;
			}

			if(contratacion.presentacionCamisa3 == 100)
				 btnFajado.Enabled = false;
			else if(contratacion.presentacionCamisa3 == 0)
				 btnDesfajado.Enabled = false;
			else{
				btnFajado.Enabled = true;
	            btnDesfajado.Enabled = true;
			}
			
			if(contratacion.pantalon == 100)
				 btnVestir.Enabled = false;
			else if(contratacion.pantalon == 75)
				 btnCasual.Enabled = false;
			else if(contratacion.pantalon == 50)
				 btnMezclilla.Enabled = false;
			else if(contratacion.pantalon == 25)
				 btnShort.Enabled = false;
			else{	            
	            btnVestir.Enabled = true;
	            btnCasual.Enabled = true;
	            btnMezclilla.Enabled = true;
	            btnShort.Enabled = true;
			}
			
			if(contratacion.presentacionPantalon1 == 100)
				 btnSinAhujeros.Enabled = false;
			else if(contratacion.presentacionPantalon1 == 0)
				 btnConAhujeros.Enabled = false;
			else{
				btnSinAhujeros.Enabled = true;
	            btnConAhujeros.Enabled = true;
			}

			if(contratacion.zapato == 100)
				 btnZapato.Enabled = false;
			else if(contratacion.zapato == 75)
				 btnBota.Enabled = false;
			else if(contratacion.zapato == 50)
				 btnTennis.Enabled = false;
			else if(contratacion.zapato == 25)
				 btnSandalia.Enabled = false;
			else{	            
	            btnZapato.Enabled = true;
	            btnBota.Enabled = true;
	            btnTennis.Enabled = true;
	            btnSandalia.Enabled = true;
			}
			
			if(contratacion.peinado != 0 || contratacion.pelo != 0 || contratacion.manosCara != 0 || contratacion.rasurado != 0 || contratacion.ropa != 0 || contratacion.pantalon != 0 || contratacion.zapato != 0 || contratacion.calzado != 0 || contratacion.vestimenta != 0 || contratacion.presentacionCamisa1 != 0 || contratacion.presentacionCamisa2 != 0 || contratacion.presentacionCamisa3 != 0 || contratacion.presentacionPantalon1 != 0 )
				calculoImagen();
			else{
				btnPlanchada.Enabled = false;
				btnArrugado.Enabled = false;
				btnAbotonado.Enabled = false;
				btnDesabotonado.Enabled = false;
				btnFajado.Enabled = false;
				btnDesfajado.Enabled = false;
			}
			
			detailsLoad();
			
			if(contratacion.rasurado == 0){			
				btnRasurado1.Enabled = true;
	            btnRasurado4.Enabled = true;	
			}
			if(contratacion.presentacionCamisa1 == 0){	
				btnPlanchada.Enabled = true;
	            btnArrugado.Enabled = true;	
			}
			
			if(contratacion.presentacionCamisa2 == 0){			
				btnAbotonado.Enabled = true;
	            btnDesabotonado.Enabled = true;	
			}
			
			if(contratacion.presentacionCamisa3 == 0){	
				btnFajado.Enabled = true;
	            btnDesfajado.Enabled = true;
			}
						
			if(contratacion.presentacionPantalon1 == 0){	
				btnSinAhujeros.Enabled = true;
	            btnConAhujeros.Enabled = true;
			}
		}		
		#endregion
		
        #region BOTONES        
		void BtnPeinado1Click(object sender, EventArgs e)
        {
            btnPeinado1.Enabled = false;
            btnPeinado2.Enabled = true;
            btnPeinado3.Enabled = true;
            btnPeinado4.Enabled = true;
            
            contratacion.peinado = 100;
            calculoImagen();
        }
        
        void BtnPeinado2Click(object sender, EventArgs e)
        {            
            btnPeinado1.Enabled = true;
            btnPeinado2.Enabled = false;
            btnPeinado3.Enabled = true;
            btnPeinado4.Enabled = true;
            
            contratacion.peinado = 75;
            calculoImagen();
        }
        
        void BtnPeinado3Click(object sender, EventArgs e)
        {
            btnPeinado1.Enabled = true;
            btnPeinado2.Enabled = true;
            btnPeinado3.Enabled = false;
            btnPeinado4.Enabled = true;
            
            contratacion.peinado = 50;
            calculoImagen();
        }
        
        void BtnPeinado4Click(object sender, EventArgs e)
        {
            btnPeinado1.Enabled = true;
            btnPeinado2.Enabled = true;
            btnPeinado3.Enabled = true;
            btnPeinado4.Enabled = false;
            
            contratacion.peinado = 25;
            calculoImagen();
        }
        
        void BtnPelo1Click(object sender, EventArgs e)
        {
            btnPelo1.Enabled = false;
            btnPelo2.Enabled = true;
            btnPelo3.Enabled = true;
            btnPelo4.Enabled = true;
            
            contratacion.pelo = 100;
            calculoImagen();
        }
        
        void BtnPelo2Click(object sender, EventArgs e)
        {
            btnPelo1.Enabled = true;
            btnPelo2.Enabled = false;
            btnPelo3.Enabled = true;
            btnPelo4.Enabled = true;
            
            contratacion.pelo = 75;
            calculoImagen();
        }
        
        void BtnPelo3Click(object sender, EventArgs e)
        {
            btnPelo1.Enabled = true;
            btnPelo2.Enabled = true;
            btnPelo3.Enabled = false;
            btnPelo4.Enabled = true;
            
            contratacion.pelo = 50;
            calculoImagen();
        }
        
        void BtnPelo4Click(object sender, EventArgs e)
        {
            btnPelo1.Enabled = true;
            btnPelo2.Enabled = true;
            btnPelo3.Enabled = true;
            btnPelo4.Enabled = false;
            
            contratacion.pelo = 25;
            calculoImagen();
        }
        
        void BtnManos1Click(object sender, EventArgs e)
        {            
            btnManos1.Enabled = false;
            btnManos2.Enabled = true;
            btnManos3.Enabled = true;
            btnManos4.Enabled = true;
            
            contratacion.manosCara = 100;
            calculoImagen();
        }
        
        void BtnManos2Click(object sender, EventArgs e)
        {
            btnManos1.Enabled = true;
            btnManos2.Enabled = false;
            btnManos3.Enabled = true;
            btnManos4.Enabled = true;
            
            contratacion.manosCara = 75;
            calculoImagen();
        }
        
        void BtnManos3Click(object sender, EventArgs e)
        {
            btnManos1.Enabled = true;
            btnManos2.Enabled = true;
            btnManos3.Enabled = false;
            btnManos4.Enabled = true;
            
            contratacion.manosCara = 50;
            calculoImagen();
        }
        
        void BtnManos4Click(object sender, EventArgs e)
        {
            btnManos1.Enabled = true;
            btnManos2.Enabled = true;
            btnManos3.Enabled = true;
            btnManos4.Enabled = false;
            
            contratacion.manosCara = 25;
            calculoImagen();
        }
        
        void BtnRasurado1Click(object sender, EventArgs e)
        {
            btnRasurado1.Enabled = false;
            btnRasurado4.Enabled = true;
            
            contratacion.rasurado = 100;
            calculoImagen();
        }
        
        void BtnRasurado4Click(object sender, EventArgs e)
        {
            btnRasurado1.Enabled = true;
            btnRasurado4.Enabled = false;
            
            contratacion.rasurado = 0;
            calculoImagen();
        }
                
        void BtnCalzado1Click(object sender, EventArgs e)
        {
            btnCalzado1.Enabled = false;
            btnCalzado2.Enabled = true;
            btnCalzado3.Enabled = true;
            btnCalzado4.Enabled = true;
            
            contratacion.calzado = 100;
            calculoImagen();
        }
        
        void BtnCalzado2Click(object sender, EventArgs e)
        {
            btnCalzado1.Enabled = true;
            btnCalzado2.Enabled = false;
            btnCalzado3.Enabled = true;
            btnCalzado4.Enabled = true;
            
            contratacion.calzado = 75;
            calculoImagen();
        }
        
        void BtnCalzado3Click(object sender, EventArgs e)
        {
            btnCalzado1.Enabled = true;
            btnCalzado2.Enabled = true;
            btnCalzado3.Enabled = false;
            btnCalzado4.Enabled = true;
            
            contratacion.calzado = 50;
            calculoImagen();
        }
        
        void BtnCalzado4Click(object sender, EventArgs e)
        {
            btnCalzado1.Enabled = true;
            btnCalzado2.Enabled = true;
            btnCalzado3.Enabled = true;
            btnCalzado4.Enabled = false;
            
            contratacion.calzado = 25;
            calculoImagen();
        }
        
        void BtnRopa1Click(object sender, EventArgs e)
		{			
            btnRopa1.Enabled = false;
            btnRopa2.Enabled = true;
            btnRopa3.Enabled = true;
            btnRopa4.Enabled = true;
            
            contratacion.ropa = 100;
            calculoImagen();
		}
		
		void BtnRopa2Click(object sender, EventArgs e)
		{
            btnRopa1.Enabled = true;
            btnRopa2.Enabled = false;
            btnRopa3.Enabled = true;
            btnRopa4.Enabled = true;
            
            contratacion.ropa = 75;
            calculoImagen();
		}
		
		void BtnRopa3Click(object sender, EventArgs e)
		{
            btnRopa1.Enabled = true;
            btnRopa2.Enabled = true;
            btnRopa3.Enabled = false;
            btnRopa4.Enabled = true;
            
            contratacion.ropa = 50;
            calculoImagen();
		}
		
		void BtnRopa4Click(object sender, EventArgs e)
		{
            btnRopa1.Enabled = true;
            btnRopa2.Enabled = true;
            btnRopa3.Enabled = true;
            btnRopa4.Enabled = false;
            
            contratacion.ropa = 25;
            calculoImagen();
		}
		
		void BtnCorbataClick(object sender, EventArgs e)
		{
			btnCorbata.Enabled = false;
            btnCamisa.Enabled = true;
            btnPlayera.Enabled = true;
            btnCamiseta.Enabled = true;
            
            contratacion.vestimenta = 100;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnCamisaClick(object sender, EventArgs e)
		{
			btnCorbata.Enabled = true;
            btnCamisa.Enabled = false;
            btnPlayera.Enabled = true;
            btnCamiseta.Enabled = true;
            
            contratacion.vestimenta = 75;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnPlayeraClick(object sender, EventArgs e)
		{
			btnCorbata.Enabled = true;
            btnCamisa.Enabled = true;
            btnPlayera.Enabled = false;
            btnCamiseta.Enabled = true;
            
            contratacion.vestimenta = 50;
            calculoImagen();
            enableCamisas();   
		}
		
		void BtnCamisetaClick(object sender, EventArgs e)
		{
			btnCorbata.Enabled = true;
            btnCamisa.Enabled = true;
            btnPlayera.Enabled = true;
            btnCamiseta.Enabled = false;
            
            contratacion.vestimenta = 25;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnPlanchadaClick(object sender, EventArgs e)
		{
			btnPlanchada.Enabled = false;
            btnArrugado.Enabled = true;
            
            contratacion.presentacionCamisa1 = 100;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnArrugadoClick(object sender, EventArgs e)
		{
			btnPlanchada.Enabled = true;
            btnArrugado.Enabled = false;
            
            contratacion.presentacionCamisa1 = 0;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnAbotonadoClick(object sender, EventArgs e)
		{
			btnAbotonado.Enabled = false;
            btnDesabotonado.Enabled = true;
            
            contratacion.presentacionCamisa2 = 100;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnDesabotonadoClick(object sender, EventArgs e)
		{
			btnAbotonado.Enabled = true;
            btnDesabotonado.Enabled = false;
            
            contratacion.presentacionCamisa2 = 0;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnFajadoClick(object sender, EventArgs e)
		{
			btnFajado.Enabled = false;
            btnDesfajado.Enabled = true;
            
            contratacion.presentacionCamisa3 = 100;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnDesfajadoClick(object sender, EventArgs e)
		{
			btnFajado.Enabled = true;
            btnDesfajado.Enabled = false;
            
            contratacion.presentacionCamisa3 = 0;
            calculoImagen();
            enableCamisas();
		}
		
		void BtnVestirClick(object sender, EventArgs e)
		{
			btnVestir.Enabled = false;
            btnCasual.Enabled = true;
            btnMezclilla.Enabled = true;
            btnShort.Enabled = true;
            
            contratacion.pantalon = 100;
            calculoImagen();
		}
		
		void BtnCasualClick(object sender, EventArgs e)
		{
			btnVestir.Enabled = true;
            btnCasual.Enabled = false;
            btnMezclilla.Enabled = true;
            btnShort.Enabled = true;
            
            contratacion.pantalon = 75;
            calculoImagen();
		}
		
		void BtnMezclillaClick(object sender, EventArgs e)
		{
			btnVestir.Enabled = true;
            btnCasual.Enabled = true;
            btnMezclilla.Enabled = false;
            btnShort.Enabled = true;
            
            contratacion.pantalon = 50;
            calculoImagen();
		}
		
		void BtnShortClick(object sender, EventArgs e)
		{
			btnVestir.Enabled = true;
            btnCasual.Enabled = true;
            btnMezclilla.Enabled = true;
            btnShort.Enabled = false;
            
            contratacion.pantalon = 25;
            calculoImagen();
		}
		
		
		void BtnSinAhujerosClick(object sender, EventArgs e)
		{
			btnSinAhujeros.Enabled = false;
            btnConAhujeros.Enabled = true;
            
            contratacion.presentacionPantalon1 = 100;
            calculoImagen();
		}
		
		void BtnConAhujerosClick(object sender, EventArgs e)
		{
			btnSinAhujeros.Enabled = true;
            btnConAhujeros.Enabled = false;
            
            contratacion.presentacionPantalon1 = 0;
            calculoImagen();
		}
		
		void BtnZapatoClick(object sender, EventArgs e)
		{
			btnZapato.Enabled = false;
            btnBota.Enabled = true;
            btnTennis.Enabled = true;
            btnSandalia.Enabled = true;
            
            contratacion.zapato = 100;
            calculoImagen();
		}
		
		void BtnBotaClick(object sender, EventArgs e)
		{
			btnZapato.Enabled = true;
            btnBota.Enabled = false;
            btnTennis.Enabled = true;
            btnSandalia.Enabled = true;
            
            contratacion.zapato = 75;
            calculoImagen();
		}
		
		void BtnTennisClick(object sender, EventArgs e)
		{
			btnZapato.Enabled = true;
            btnBota.Enabled = true;
            btnTennis.Enabled = false;
            btnSandalia.Enabled = true;
            
            contratacion.zapato = 50;
            calculoImagen();
		}
		
		void BtnSandaliaClick(object sender, EventArgs e)
		{
			btnZapato.Enabled = true;
            btnBota.Enabled = true;
            btnTennis.Enabled = true;
            btnSandalia.Enabled = false;
            
            contratacion.zapato = 25;
            calculoImagen();
		}
        #endregion
        
        #region EVENTOS        
        void FormImagenKeyUp(object sender, KeyEventArgs e)
        {            
            if(e.KeyCode == Keys.Escape)
                this.Close();
        }
        #endregion
        
        #region METODOS
        private void calculoImagen(){
        	double resultado = ((contratacion.peinado + contratacion.pelo + contratacion.manosCara + contratacion.rasurado + contratacion.ropa + contratacion.calzado 
        	                     + contratacion.vestimenta + contratacion.pantalon + contratacion.zapato + contratacion.presentacionCamisa1  
        	                     + contratacion.presentacionCamisa2 + contratacion.presentacionCamisa3 + contratacion.presentacionPantalon1) * 100) / 1300;
        				
        	txtImagenPersonal.Text = resultado.ToString();
        	contratacion.txtImagenPersonal.Text = resultado.ToString();
        	
        	if( Convert.ToInt32(contratacion.txtImagenPersonal.Text) < Convert.ToInt32(contratacion.parametros.imagen))
        		contratacion.txtImagenPersonal.ForeColor = Color.Red;
        	else
				txtImagenPersonal.ResetForeColor();
        }
        
        private void detailsLoad(){
			toolTip1.SetToolTip(btnPeinado1, "Bien Peinado");
			toolTip1.SetToolTip(btnPeinado2, "Medio Peinado");
			toolTip1.SetToolTip(btnPeinado3, "Total Despeinado");
			toolTip1.SetToolTip(btnPeinado4, "Gorra");
			
			toolTip1.SetToolTip(btnPelo1, "Pelo Corto");
			toolTip1.SetToolTip(btnPelo2, "Pelo Medio Largo");
			toolTip1.SetToolTip(btnPelo3, "Pelo Largo");
			toolTip1.SetToolTip(btnPelo4, "Rastas o Recortes");
			
			toolTip1.SetToolTip(btnManos1, "Limpio");
			toolTip1.SetToolTip(btnManos2, "Medio Sucio");
			toolTip1.SetToolTip(btnManos3, "Sucio");
			toolTip1.SetToolTip(btnManos4, "Muy Sucio");
			
			toolTip1.SetToolTip(btnRasurado1, "Sin Barba");
			toolTip1.SetToolTip(btnRasurado4, "Con Barba");
			
			toolTip1.SetToolTip(btnRopa1, "Limpia");
			toolTip1.SetToolTip(btnRopa2, "Medio limpio");
			toolTip1.SetToolTip(btnRopa3, "Medio Sucio");
			toolTip1.SetToolTip(btnRopa4, "Demasiado Sucio");
						
			toolTip1.SetToolTip(btnCorbata, "Corbata");	
			toolTip1.SetToolTip(btnCamisa, "Camisa de Vestir");
			toolTip1.SetToolTip(btnPlayera, "Camisa Polo");
			toolTip1.SetToolTip(btnCamiseta, "Playera o Resaque");
			
			toolTip1.SetToolTip(btnPlanchada, "Planchada");
			toolTip1.SetToolTip(btnArrugado, "Arrugado");
			
			toolTip1.SetToolTip(btnAbotonado, "Abotonado");
			toolTip1.SetToolTip(btnDesabotonado, "Desabotonado");
			
			toolTip1.SetToolTip(btnFajado, "Fajado");
			toolTip1.SetToolTip(btnDesfajado, "Desfajado");
			
			toolTip1.SetToolTip(btnVestir, "Vestir");
			toolTip1.SetToolTip(btnCasual, "Casual");
			toolTip1.SetToolTip(btnMezclilla, "Mezclilla");
			toolTip1.SetToolTip(btnShort, "Short o Pans");
			
			toolTip1.SetToolTip(btnSinAhujeros, "Sin Ahujeros");
			toolTip1.SetToolTip(btnConAhujeros, "Con Ahujeros Roto.");
			
			toolTip1.SetToolTip(btnZapato, "Zapato");
			toolTip1.SetToolTip(btnBota, "Bota");
			toolTip1.SetToolTip(btnTennis, "Tennis");
			toolTip1.SetToolTip(btnSandalia, "Sandalia");
			
			toolTip1.SetToolTip(btnCalzado1, "Limpio");
			toolTip1.SetToolTip(btnCalzado2, "Medio Limpio");
			toolTip1.SetToolTip(btnCalzado3, "Medio Sucio");
			toolTip1.SetToolTip(btnCalzado4, "Sucio");
		}
        
		private void enableCamisas(){        
        	if(btnPlayera.Enabled == false || btnCamiseta.Enabled == false){
				btnArrugado.Enabled = false;
				btnDesabotonado.Enabled = false;
				btnDesfajado.Enabled = false;
				btnPlanchada.Enabled = true;
				btnAbotonado.Enabled = true;
				btnFajado.Enabled = true;
        	}else{
        		btnPlanchada.Enabled = true;
				btnArrugado.Enabled = true;
				btnAbotonado.Enabled = true;
				btnDesabotonado.Enabled = true;
				btnFajado.Enabled = true;
				btnDesfajado.Enabled = true;
        	}
		}
        #endregion
    }
}
