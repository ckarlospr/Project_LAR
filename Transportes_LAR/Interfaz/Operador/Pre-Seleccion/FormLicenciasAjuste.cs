using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormLicenciasAjuste : Form
	{
		#region VARIABLES
		string vigE = "", vigF = "", vigM = "";
		#endregion
		
		#region CONSTRUCTOR
		public FormLicenciasAjuste(FormContratacion refp)
		{
			InitializeComponent();
			contratacion = refp;
		}	
		#endregion
		
		#region INSTANCIAS
		FormContratacion contratacion = null;
		#endregion
		
		#region INICIO - FIN
		void FormLicenciasAjusteLoad(object sender, EventArgs e)
		{			
			adaptador();
			
			txtEstatal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtFederal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtMedico.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
				
		#region ADAPTADOR
		public void adaptador(){			
			if(contratacion.cmbTipoLicEstatal.SelectedIndex > 0){
				if(contratacion.lblTipoEstatal.ForeColor == Color.Red){	
					txtEstatal.ReadOnly = false;		
					lblVenceEstatal.Text = "Tipo Lic";
					txtEstatal.BackColor = Color.Red;
					vigE = "Tipo Lic";
				}else{
					TimeSpan tE = Convert.ToDateTime(contratacion.dtpVigenciaLicEstatal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					vigE = (Math.Round(diasE)).ToString();
					if(DateTime.Now.AddMonths(Convert.ToInt16(contratacion.parametros.vigEstatal)) >= contratacion.dtpVigenciaLicEstatal.Value){	
						if(diasE > 0)
							lblVenceEstatal.Text = "Vence en "+ Math.Round(diasE)+" Catorcena";
						else{
							lblVenceEstatal.Text = "Vencida";
							vigE = "Vencida";
						}
					}else{
						txtEstatal.Text = "";
						txtEstatal.BackColor = Color.LightGreen;
						txtEstatal.ReadOnly = true;
						lblVenceEstatal.Text = "Vence en "+diasE+" Catorcena";
					}
				}
			}else{
				txtEstatal.ReadOnly = true;		
				lblVenceEstatal.Text = "N/A";
			}
			
			if(contratacion.cmbTipoLicFederal.SelectedIndex > 0){
				if(contratacion.lblTipoFederal.ForeColor == Color.Red){					
					txtFederal.ReadOnly = false;		
					lblVenceFederal.Text = "Tipo Lic";
					vigF = "Tipo Lic";
					txtFederal.BackColor = Color.Red;
				}else{
					TimeSpan tF = Convert.ToDateTime(contratacion.dtpVigenciaLicFederal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasF =(tF.Days + 1)/14;
					vigF = (Math.Round(diasF)).ToString();
					if(DateTime.Now.AddMonths(Convert.ToInt16(contratacion.parametros.vigFederal)) >= contratacion.dtpVigenciaLicFederal.Value){
						if(diasF > 0)
							lblVenceFederal.Text = "Vence en "+ Math.Round(diasF)+" Catorcena";
						else{
							lblVenceFederal.Text = "Vencida";
							vigF = "Vencida";
						}
					}else{
						txtFederal.Text = "";
						txtFederal.BackColor = Color.LightGreen;
						txtFederal.ReadOnly = true;
						lblVenceFederal.Text = "Vence en "+diasF+" Catorcena";
					}
				}
			}else{
				txtFederal.ReadOnly = true;		
				lblVenceFederal.Text = "N/A";
			}
			
			if(contratacion.txtNumLicAptoMedico.Text.Length > 0){
				TimeSpan tM = Convert.ToDateTime(contratacion.dtpVigenciaLicAptoMedico.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
				double diasF =(tM.Days + 1)/14;
				vigM = (Math.Round(diasF)).ToString();
				if(DateTime.Now.AddMonths(Convert.ToInt16(contratacion.parametros.vigAptoMedico)) >= contratacion.dtpVigenciaLicAptoMedico.Value){
					if(diasF > 0)
						lblVenceMedico.Text = "Vence en "+ Math.Round(diasF)+" Catorcena";
					else{
						lblVenceMedico.Text = "Vencida";
						vigM = "Vencida";
					}
				}else{
					txtMedico.Text = "";
					txtMedico.BackColor = Color.LightGreen;
					txtMedico.ReadOnly = true;
					lblVenceMedico.Text = "Vence en "+diasF+" Catorcena";
				}
			}else{
				txtMedico.ReadOnly = true;		
				lblVenceMedico.Text = "N/A";
			}			
			
			if(contratacion.licAjuste == null)
				contratacion.licAjuste = new Dato.LicenciasAjuste();
			else{
				txtEstatal.Text = contratacion.licAjuste.estatal;
				txtFederal.Text = contratacion.licAjuste.federal;
				txtMedico.Text = contratacion.licAjuste.medico;
				txtObservaciones.Text = contratacion.licAjuste.observaciones;
			}
		}
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{	
			if(contratacion.licAjuste == null)
				contratacion.licAjuste = new Dato.LicenciasAjuste();
			
			contratacion.licAjuste.estatal = txtEstatal.Text;
			contratacion.licAjuste.estatal_vence = vigE.ToString();
			contratacion.licAjuste.federal = txtFederal.Text;
			contratacion.licAjuste.federal_vence = vigF.ToString();
			contratacion.licAjuste.medico = txtMedico.Text;
			contratacion.licAjuste.medico_vence = vigM.ToString();
			contratacion.licAjuste.observaciones = txtObservaciones.Text;
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}	
		#endregion
		
		#region EVENTOS
		void FormLicenciasAjusteKeyUp(object sender, KeyEventArgs e)
		{			
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
