/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 11/09/2015
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes.Cardex
{
	partial class FormOtros2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtros2));
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmdGuarda = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rbNegarseHacerServicio = new System.Windows.Forms.RadioButton();
			this.rbInicioRutaTarde = new System.Windows.Forms.RadioButton();
			this.rbNoRespetaItinerario = new System.Windows.Forms.RadioButton();
			this.rbPermiso = new System.Windows.Forms.RadioButton();
			this.rbIncapacidad = new System.Windows.Forms.RadioButton();
			this.rbTaller = new System.Windows.Forms.RadioButton();
			this.rbDormida = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbMovNoAutorizado = new System.Windows.Forms.RadioButton();
			this.rbDiferenciaDiessel = new System.Windows.Forms.RadioButton();
			this.rbCargaFueradeHorario = new System.Windows.Forms.RadioButton();
			this.rbExceso = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbOtros = new System.Windows.Forms.RadioButton();
			this.rbImagenUnidad = new System.Windows.Forms.RadioButton();
			this.rbChoques = new System.Windows.Forms.RadioButton();
			this.rbActitud = new System.Windows.Forms.RadioButton();
			this.rbImagenOperador = new System.Windows.Forms.RadioButton();
			this.rbUniforme = new System.Windows.Forms.RadioButton();
			this.lblComentario = new System.Windows.Forms.Label();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.lblOtros = new System.Windows.Forms.Label();
			this.lblCombustible = new System.Windows.Forms.Label();
			this.lblOperaciones = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.rbAptoMedico = new System.Windows.Forms.RadioButton();
			this.rbLicencia = new System.Windows.Forms.RadioButton();
			this.rbIFE = new System.Windows.Forms.RadioButton();
			this.rbTCirculacion = new System.Windows.Forms.RadioButton();
			this.rbTarjetaFGDL = new System.Windows.Forms.RadioButton();
			this.lblUniforme = new System.Windows.Forms.Label();
			this.rbCamisa = new System.Windows.Forms.RadioButton();
			this.rbPantalones = new System.Windows.Forms.RadioButton();
			this.rbCorbata = new System.Windows.Forms.RadioButton();
			this.rbCortinas = new System.Windows.Forms.RadioButton();
			this.lblDocumentacion = new System.Windows.Forms.Label();
			this.rbSeguro = new System.Windows.Forms.RadioButton();
			this.ebPermisoM = new System.Windows.Forms.RadioButton();
			this.rbHolograma = new System.Windows.Forms.RadioButton();
			this.rbLetreros = new System.Windows.Forms.RadioButton();
			this.rbFundas = new System.Windows.Forms.RadioButton();
			this.rbBotiquin = new System.Windows.Forms.RadioButton();
			this.rbExtintor = new System.Windows.Forms.RadioButton();
			this.lblMaterial = new System.Windows.Forms.Label();
			this.lblOperador = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(135, 64);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(142, 21);
			this.cmbTurno.TabIndex = 3;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(135, 39);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(142, 20);
			this.dtpFecha.TabIndex = 2;
			// 
			// cmdGuarda
			// 
			this.cmdGuarda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuarda.Location = new System.Drawing.Point(111, 464);
			this.cmdGuarda.Name = "cmdGuarda";
			this.cmdGuarda.Size = new System.Drawing.Size(115, 47);
			this.cmdGuarda.TabIndex = 22;
			this.cmdGuarda.Text = "Guardar";
			this.cmdGuarda.UseVisualStyleBackColor = true;
			this.cmdGuarda.Click += new System.EventHandler(this.CmdGuardaClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 91);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(356, 544);
			this.tabControl1.TabIndex = 24;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.lblComentario);
			this.tabPage1.Controls.Add(this.txtComentario);
			this.tabPage1.Controls.Add(this.lblOtros);
			this.tabPage1.Controls.Add(this.cmdGuarda);
			this.tabPage1.Controls.Add(this.lblCombustible);
			this.tabPage1.Controls.Add(this.lblOperaciones);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(348, 518);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Cardex";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.rbNegarseHacerServicio);
			this.panel3.Controls.Add(this.rbInicioRutaTarde);
			this.panel3.Controls.Add(this.rbNoRespetaItinerario);
			this.panel3.Controls.Add(this.rbPermiso);
			this.panel3.Controls.Add(this.rbIncapacidad);
			this.panel3.Controls.Add(this.rbTaller);
			this.panel3.Controls.Add(this.rbDormida);
			this.panel3.Location = new System.Drawing.Point(9, 36);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(333, 97);
			this.panel3.TabIndex = 56;
			// 
			// rbNegarseHacerServicio
			// 
			this.rbNegarseHacerServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNegarseHacerServicio.Location = new System.Drawing.Point(178, 27);
			this.rbNegarseHacerServicio.Name = "rbNegarseHacerServicio";
			this.rbNegarseHacerServicio.Size = new System.Drawing.Size(137, 19);
			this.rbNegarseHacerServicio.TabIndex = 7;
			this.rbNegarseHacerServicio.Text = "Negarse hacer Servicio";
			this.rbNegarseHacerServicio.UseVisualStyleBackColor = true;
			this.rbNegarseHacerServicio.CheckedChanged += new System.EventHandler(this.RbNegarseHacerServicioCheckedChanged);
			// 
			// rbInicioRutaTarde
			// 
			this.rbInicioRutaTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbInicioRutaTarde.Location = new System.Drawing.Point(178, 4);
			this.rbInicioRutaTarde.Name = "rbInicioRutaTarde";
			this.rbInicioRutaTarde.Size = new System.Drawing.Size(137, 17);
			this.rbInicioRutaTarde.TabIndex = 5;
			this.rbInicioRutaTarde.Text = "Inició Ruta Tarde";
			this.rbInicioRutaTarde.UseVisualStyleBackColor = true;
			this.rbInicioRutaTarde.CheckedChanged += new System.EventHandler(this.RbInicioRutaTardeCheckedChanged);
			// 
			// rbNoRespetaItinerario
			// 
			this.rbNoRespetaItinerario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNoRespetaItinerario.Location = new System.Drawing.Point(178, 52);
			this.rbNoRespetaItinerario.Name = "rbNoRespetaItinerario";
			this.rbNoRespetaItinerario.Size = new System.Drawing.Size(137, 24);
			this.rbNoRespetaItinerario.TabIndex = 9;
			this.rbNoRespetaItinerario.Text = "No Respeta Itinerario";
			this.rbNoRespetaItinerario.UseVisualStyleBackColor = true;
			this.rbNoRespetaItinerario.CheckedChanged += new System.EventHandler(this.RbNoRespetaItinerarioCheckedChanged);
			// 
			// rbPermiso
			// 
			this.rbPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPermiso.Location = new System.Drawing.Point(18, 52);
			this.rbPermiso.Name = "rbPermiso";
			this.rbPermiso.Size = new System.Drawing.Size(137, 17);
			this.rbPermiso.TabIndex = 8;
			this.rbPermiso.Text = "Permiso";
			this.rbPermiso.UseVisualStyleBackColor = true;
			this.rbPermiso.CheckedChanged += new System.EventHandler(this.RbPermisoCheckedChanged);
			// 
			// rbIncapacidad
			// 
			this.rbIncapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbIncapacidad.Location = new System.Drawing.Point(18, 65);
			this.rbIncapacidad.Name = "rbIncapacidad";
			this.rbIncapacidad.Size = new System.Drawing.Size(137, 29);
			this.rbIncapacidad.TabIndex = 10;
			this.rbIncapacidad.Text = "Incapacidad";
			this.rbIncapacidad.UseVisualStyleBackColor = true;
			this.rbIncapacidad.CheckedChanged += new System.EventHandler(this.RbIncapacidadCheckedChanged);
			// 
			// rbTaller
			// 
			this.rbTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTaller.Location = new System.Drawing.Point(18, 29);
			this.rbTaller.Name = "rbTaller";
			this.rbTaller.Size = new System.Drawing.Size(137, 17);
			this.rbTaller.TabIndex = 6;
			this.rbTaller.Text = "Taller";
			this.rbTaller.UseVisualStyleBackColor = true;
			this.rbTaller.CheckedChanged += new System.EventHandler(this.RbTallerCheckedChanged);
			// 
			// rbDormida
			// 
			this.rbDormida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbDormida.Location = new System.Drawing.Point(18, 6);
			this.rbDormida.Name = "rbDormida";
			this.rbDormida.Size = new System.Drawing.Size(137, 17);
			this.rbDormida.TabIndex = 4;
			this.rbDormida.Text = "Dormida";
			this.rbDormida.UseVisualStyleBackColor = true;
			this.rbDormida.CheckedChanged += new System.EventHandler(this.RbDormidaCheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbMovNoAutorizado);
			this.panel2.Controls.Add(this.rbDiferenciaDiessel);
			this.panel2.Controls.Add(this.rbCargaFueradeHorario);
			this.panel2.Controls.Add(this.rbExceso);
			this.panel2.Location = new System.Drawing.Point(9, 156);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(333, 95);
			this.panel2.TabIndex = 56;
			// 
			// rbMovNoAutorizado
			// 
			this.rbMovNoAutorizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMovNoAutorizado.Location = new System.Drawing.Point(12, 51);
			this.rbMovNoAutorizado.Name = "rbMovNoAutorizado";
			this.rbMovNoAutorizado.Size = new System.Drawing.Size(137, 17);
			this.rbMovNoAutorizado.TabIndex = 13;
			this.rbMovNoAutorizado.Text = "Mov. No Autorizado";
			this.rbMovNoAutorizado.UseVisualStyleBackColor = true;
			this.rbMovNoAutorizado.CheckedChanged += new System.EventHandler(this.RbMovNoAutorizadoCheckedChanged);
			// 
			// rbDiferenciaDiessel
			// 
			this.rbDiferenciaDiessel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbDiferenciaDiessel.Location = new System.Drawing.Point(12, 5);
			this.rbDiferenciaDiessel.Name = "rbDiferenciaDiessel";
			this.rbDiferenciaDiessel.Size = new System.Drawing.Size(137, 17);
			this.rbDiferenciaDiessel.TabIndex = 11;
			this.rbDiferenciaDiessel.Text = "Diferencia Diessel";
			this.rbDiferenciaDiessel.UseVisualStyleBackColor = true;
			this.rbDiferenciaDiessel.CheckedChanged += new System.EventHandler(this.RbDiferenciaDiesselCheckedChanged);
			// 
			// rbCargaFueradeHorario
			// 
			this.rbCargaFueradeHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCargaFueradeHorario.Location = new System.Drawing.Point(12, 22);
			this.rbCargaFueradeHorario.Name = "rbCargaFueradeHorario";
			this.rbCargaFueradeHorario.Size = new System.Drawing.Size(240, 27);
			this.rbCargaFueradeHorario.TabIndex = 12;
			this.rbCargaFueradeHorario.Text = "Carga Fuera de Horario";
			this.rbCargaFueradeHorario.UseVisualStyleBackColor = true;
			this.rbCargaFueradeHorario.CheckedChanged += new System.EventHandler(this.RbCargaFueradeHorarioCheckedChanged);
			// 
			// rbExceso
			// 
			this.rbExceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExceso.Location = new System.Drawing.Point(12, 74);
			this.rbExceso.Name = "rbExceso";
			this.rbExceso.Size = new System.Drawing.Size(149, 17);
			this.rbExceso.TabIndex = 14;
			this.rbExceso.Text = "Exceso de velocidad";
			this.rbExceso.UseVisualStyleBackColor = true;
			this.rbExceso.CheckedChanged += new System.EventHandler(this.RbExcesoCheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbOtros);
			this.panel1.Controls.Add(this.rbImagenUnidad);
			this.panel1.Controls.Add(this.rbChoques);
			this.panel1.Controls.Add(this.rbActitud);
			this.panel1.Controls.Add(this.rbImagenOperador);
			this.panel1.Controls.Add(this.rbUniforme);
			this.panel1.Location = new System.Drawing.Point(9, 274);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(333, 85);
			this.panel1.TabIndex = 55;
			// 
			// rbOtros
			// 
			this.rbOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOtros.Location = new System.Drawing.Point(172, 53);
			this.rbOtros.Name = "rbOtros";
			this.rbOtros.Size = new System.Drawing.Size(149, 17);
			this.rbOtros.TabIndex = 20;
			this.rbOtros.Text = "Otros";
			this.rbOtros.UseVisualStyleBackColor = true;
			this.rbOtros.CheckedChanged += new System.EventHandler(this.RbOtrosCheckedChanged);
			// 
			// rbImagenUnidad
			// 
			this.rbImagenUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbImagenUnidad.Location = new System.Drawing.Point(172, 7);
			this.rbImagenUnidad.Name = "rbImagenUnidad";
			this.rbImagenUnidad.Size = new System.Drawing.Size(149, 22);
			this.rbImagenUnidad.TabIndex = 16;
			this.rbImagenUnidad.Text = "Imagen Unidad";
			this.rbImagenUnidad.UseVisualStyleBackColor = true;
			this.rbImagenUnidad.CheckedChanged += new System.EventHandler(this.RbImagenUnidadCheckedChanged);
			// 
			// rbChoques
			// 
			this.rbChoques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbChoques.Location = new System.Drawing.Point(12, 53);
			this.rbChoques.Name = "rbChoques";
			this.rbChoques.Size = new System.Drawing.Size(105, 25);
			this.rbChoques.TabIndex = 19;
			this.rbChoques.Text = "Choques";
			this.rbChoques.UseVisualStyleBackColor = true;
			this.rbChoques.CheckedChanged += new System.EventHandler(this.RbChoquesCheckedChanged);
			// 
			// rbActitud
			// 
			this.rbActitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbActitud.Location = new System.Drawing.Point(12, 30);
			this.rbActitud.Name = "rbActitud";
			this.rbActitud.Size = new System.Drawing.Size(105, 17);
			this.rbActitud.TabIndex = 17;
			this.rbActitud.Text = "Actitud";
			this.rbActitud.UseVisualStyleBackColor = true;
			this.rbActitud.CheckedChanged += new System.EventHandler(this.RbActitudCheckedChanged);
			// 
			// rbImagenOperador
			// 
			this.rbImagenOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbImagenOperador.Location = new System.Drawing.Point(172, 27);
			this.rbImagenOperador.Name = "rbImagenOperador";
			this.rbImagenOperador.Size = new System.Drawing.Size(149, 25);
			this.rbImagenOperador.TabIndex = 18;
			this.rbImagenOperador.Text = "Imagen Operador";
			this.rbImagenOperador.UseVisualStyleBackColor = true;
			this.rbImagenOperador.CheckedChanged += new System.EventHandler(this.RbImagenOperadorCheckedChanged);
			// 
			// rbUniforme
			// 
			this.rbUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbUniforme.Location = new System.Drawing.Point(12, 7);
			this.rbUniforme.Name = "rbUniforme";
			this.rbUniforme.Size = new System.Drawing.Size(105, 17);
			this.rbUniforme.TabIndex = 15;
			this.rbUniforme.Text = "Uniforme";
			this.rbUniforme.UseVisualStyleBackColor = true;
			this.rbUniforme.CheckedChanged += new System.EventHandler(this.RbUniformeCheckedChanged);
			// 
			// lblComentario
			// 
			this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblComentario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComentario.Location = new System.Drawing.Point(9, 362);
			this.lblComentario.Name = "lblComentario";
			this.lblComentario.Size = new System.Drawing.Size(333, 17);
			this.lblComentario.TabIndex = 54;
			this.lblComentario.Text = "Comentario";
			this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtComentario
			// 
			this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Location = new System.Drawing.Point(9, 382);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(333, 76);
			this.txtComentario.TabIndex = 21;
			// 
			// lblOtros
			// 
			this.lblOtros.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOtros.Location = new System.Drawing.Point(9, 254);
			this.lblOtros.Name = "lblOtros";
			this.lblOtros.Size = new System.Drawing.Size(336, 17);
			this.lblOtros.TabIndex = 49;
			this.lblOtros.Text = "Diversos";
			this.lblOtros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCombustible
			// 
			this.lblCombustible.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCombustible.Location = new System.Drawing.Point(9, 136);
			this.lblCombustible.Name = "lblCombustible";
			this.lblCombustible.Size = new System.Drawing.Size(336, 17);
			this.lblCombustible.TabIndex = 42;
			this.lblCombustible.Text = "Combustible";
			this.lblCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOperaciones
			// 
			this.lblOperaciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperaciones.Location = new System.Drawing.Point(6, 16);
			this.lblOperaciones.Name = "lblOperaciones";
			this.lblOperaciones.Size = new System.Drawing.Size(336, 17);
			this.lblOperaciones.TabIndex = 33;
			this.lblOperaciones.Text = "Operaciones";
			this.lblOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.rbAptoMedico);
			this.tabPage2.Controls.Add(this.rbLicencia);
			this.tabPage2.Controls.Add(this.rbIFE);
			this.tabPage2.Controls.Add(this.rbTCirculacion);
			this.tabPage2.Controls.Add(this.rbTarjetaFGDL);
			this.tabPage2.Controls.Add(this.lblUniforme);
			this.tabPage2.Controls.Add(this.rbCamisa);
			this.tabPage2.Controls.Add(this.rbPantalones);
			this.tabPage2.Controls.Add(this.rbCorbata);
			this.tabPage2.Controls.Add(this.rbCortinas);
			this.tabPage2.Controls.Add(this.lblDocumentacion);
			this.tabPage2.Controls.Add(this.rbSeguro);
			this.tabPage2.Controls.Add(this.ebPermisoM);
			this.tabPage2.Controls.Add(this.rbHolograma);
			this.tabPage2.Controls.Add(this.rbLetreros);
			this.tabPage2.Controls.Add(this.rbFundas);
			this.tabPage2.Controls.Add(this.rbBotiquin);
			this.tabPage2.Controls.Add(this.rbExtintor);
			this.tabPage2.Controls.Add(this.lblMaterial);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(348, 518);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Control Material";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// rbAptoMedico
			// 
			this.rbAptoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAptoMedico.Location = new System.Drawing.Point(18, 226);
			this.rbAptoMedico.Name = "rbAptoMedico";
			this.rbAptoMedico.Size = new System.Drawing.Size(137, 17);
			this.rbAptoMedico.TabIndex = 74;
			this.rbAptoMedico.Text = "Apto Medico";
			this.rbAptoMedico.UseVisualStyleBackColor = true;
			// 
			// rbLicencia
			// 
			this.rbLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbLicencia.Location = new System.Drawing.Point(18, 180);
			this.rbLicencia.Name = "rbLicencia";
			this.rbLicencia.Size = new System.Drawing.Size(137, 17);
			this.rbLicencia.TabIndex = 73;
			this.rbLicencia.Text = "Licencia";
			this.rbLicencia.UseVisualStyleBackColor = true;
			// 
			// rbIFE
			// 
			this.rbIFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbIFE.Location = new System.Drawing.Point(18, 203);
			this.rbIFE.Name = "rbIFE";
			this.rbIFE.Size = new System.Drawing.Size(137, 17);
			this.rbIFE.TabIndex = 72;
			this.rbIFE.Text = "IFE";
			this.rbIFE.UseVisualStyleBackColor = true;
			// 
			// rbTCirculacion
			// 
			this.rbTCirculacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTCirculacion.Location = new System.Drawing.Point(18, 249);
			this.rbTCirculacion.Name = "rbTCirculacion";
			this.rbTCirculacion.Size = new System.Drawing.Size(149, 17);
			this.rbTCirculacion.TabIndex = 71;
			this.rbTCirculacion.Text = "T. Circulación";
			this.rbTCirculacion.UseVisualStyleBackColor = true;
			// 
			// rbTarjetaFGDL
			// 
			this.rbTarjetaFGDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTarjetaFGDL.Location = new System.Drawing.Point(18, 316);
			this.rbTarjetaFGDL.Name = "rbTarjetaFGDL";
			this.rbTarjetaFGDL.Size = new System.Drawing.Size(137, 26);
			this.rbTarjetaFGDL.TabIndex = 70;
			this.rbTarjetaFGDL.Text = "Tarjeta FGDL";
			this.rbTarjetaFGDL.UseVisualStyleBackColor = true;
			// 
			// lblUniforme
			// 
			this.lblUniforme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUniforme.Location = new System.Drawing.Point(6, 387);
			this.lblUniforme.Name = "lblUniforme";
			this.lblUniforme.Size = new System.Drawing.Size(336, 17);
			this.lblUniforme.TabIndex = 69;
			this.lblUniforme.Text = "Uniforme";
			this.lblUniforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbCamisa
			// 
			this.rbCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCamisa.Location = new System.Drawing.Point(18, 413);
			this.rbCamisa.Name = "rbCamisa";
			this.rbCamisa.Size = new System.Drawing.Size(149, 17);
			this.rbCamisa.TabIndex = 68;
			this.rbCamisa.Text = "Camisas";
			this.rbCamisa.UseVisualStyleBackColor = true;
			// 
			// rbPantalones
			// 
			this.rbPantalones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPantalones.Location = new System.Drawing.Point(18, 436);
			this.rbPantalones.Name = "rbPantalones";
			this.rbPantalones.Size = new System.Drawing.Size(149, 17);
			this.rbPantalones.TabIndex = 67;
			this.rbPantalones.Text = "Pantalones";
			this.rbPantalones.UseVisualStyleBackColor = true;
			// 
			// rbCorbata
			// 
			this.rbCorbata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCorbata.Location = new System.Drawing.Point(18, 459);
			this.rbCorbata.Name = "rbCorbata";
			this.rbCorbata.Size = new System.Drawing.Size(161, 17);
			this.rbCorbata.TabIndex = 66;
			this.rbCorbata.Text = "Corbata";
			this.rbCorbata.UseVisualStyleBackColor = true;
			// 
			// rbCortinas
			// 
			this.rbCortinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCortinas.Location = new System.Drawing.Point(18, 126);
			this.rbCortinas.Name = "rbCortinas";
			this.rbCortinas.Size = new System.Drawing.Size(137, 17);
			this.rbCortinas.TabIndex = 64;
			this.rbCortinas.Text = "Cortinas";
			this.rbCortinas.UseVisualStyleBackColor = true;
			// 
			// lblDocumentacion
			// 
			this.lblDocumentacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblDocumentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumentacion.Location = new System.Drawing.Point(6, 156);
			this.lblDocumentacion.Name = "lblDocumentacion";
			this.lblDocumentacion.Size = new System.Drawing.Size(336, 17);
			this.lblDocumentacion.TabIndex = 62;
			this.lblDocumentacion.Text = "Documentación";
			this.lblDocumentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbSeguro
			// 
			this.rbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSeguro.Location = new System.Drawing.Point(18, 271);
			this.rbSeguro.Name = "rbSeguro";
			this.rbSeguro.Size = new System.Drawing.Size(137, 24);
			this.rbSeguro.TabIndex = 61;
			this.rbSeguro.Text = "Seguro";
			this.rbSeguro.UseVisualStyleBackColor = true;
			// 
			// ebPermisoM
			// 
			this.ebPermisoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ebPermisoM.Location = new System.Drawing.Point(18, 295);
			this.ebPermisoM.Name = "ebPermisoM";
			this.ebPermisoM.Size = new System.Drawing.Size(137, 17);
			this.ebPermisoM.TabIndex = 60;
			this.ebPermisoM.Text = "Permiso";
			this.ebPermisoM.UseVisualStyleBackColor = true;
			// 
			// rbHolograma
			// 
			this.rbHolograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHolograma.Location = new System.Drawing.Point(18, 341);
			this.rbHolograma.Name = "rbHolograma";
			this.rbHolograma.Size = new System.Drawing.Size(149, 23);
			this.rbHolograma.TabIndex = 59;
			this.rbHolograma.Text = "Holograma";
			this.rbHolograma.UseVisualStyleBackColor = true;
			// 
			// rbLetreros
			// 
			this.rbLetreros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbLetreros.Location = new System.Drawing.Point(18, 80);
			this.rbLetreros.Name = "rbLetreros";
			this.rbLetreros.Size = new System.Drawing.Size(137, 17);
			this.rbLetreros.TabIndex = 57;
			this.rbLetreros.Text = "Letreros";
			this.rbLetreros.UseVisualStyleBackColor = true;
			// 
			// rbFundas
			// 
			this.rbFundas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFundas.Location = new System.Drawing.Point(18, 103);
			this.rbFundas.Name = "rbFundas";
			this.rbFundas.Size = new System.Drawing.Size(137, 17);
			this.rbFundas.TabIndex = 56;
			this.rbFundas.Text = "Fundas";
			this.rbFundas.UseVisualStyleBackColor = true;
			// 
			// rbBotiquin
			// 
			this.rbBotiquin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbBotiquin.Location = new System.Drawing.Point(18, 57);
			this.rbBotiquin.Name = "rbBotiquin";
			this.rbBotiquin.Size = new System.Drawing.Size(137, 17);
			this.rbBotiquin.TabIndex = 55;
			this.rbBotiquin.Text = "Botiquin";
			this.rbBotiquin.UseVisualStyleBackColor = true;
			// 
			// rbExtintor
			// 
			this.rbExtintor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExtintor.Location = new System.Drawing.Point(18, 34);
			this.rbExtintor.Name = "rbExtintor";
			this.rbExtintor.Size = new System.Drawing.Size(137, 17);
			this.rbExtintor.TabIndex = 54;
			this.rbExtintor.Text = "Extintor";
			this.rbExtintor.UseVisualStyleBackColor = true;
			// 
			// lblMaterial
			// 
			this.lblMaterial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterial.Location = new System.Drawing.Point(6, 12);
			this.lblMaterial.Name = "lblMaterial";
			this.lblMaterial.Size = new System.Drawing.Size(336, 17);
			this.lblMaterial.TabIndex = 53;
			this.lblMaterial.Text = "Material";
			this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOperador
			// 
			this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(57, 13);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(72, 23);
			this.lblOperador.TabIndex = 26;
			this.lblOperador.Text = "Operador:";
			// 
			// lblFecha
			// 
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(58, 39);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(72, 23);
			this.lblFecha.TabIndex = 27;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblTurno
			// 
			this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurno.Location = new System.Drawing.Point(57, 62);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(72, 23);
			this.lblTurno.TabIndex = 28;
			this.lblTurno.Text = "Turno:";
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Location = new System.Drawing.Point(135, 12);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(142, 20);
			this.txtOperador.TabIndex = 1;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormOtros2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 638);
			this.Controls.Add(this.txtOperador);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblOperador);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.cmbTurno);
			this.Controls.Add(this.dtpFecha);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(389, 676);
			this.MinimumSize = new System.Drawing.Size(389, 676);
			this.Name = "FormOtros2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Cardex operador";
			this.Load += new System.EventHandler(this.FormOtros2Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label lblComentario;
		private System.Windows.Forms.Label lblMaterial;
		private System.Windows.Forms.RadioButton rbExtintor;
		private System.Windows.Forms.RadioButton rbBotiquin;
		private System.Windows.Forms.RadioButton rbFundas;
		private System.Windows.Forms.RadioButton rbLetreros;
		private System.Windows.Forms.RadioButton rbHolograma;
		private System.Windows.Forms.RadioButton ebPermisoM;
		private System.Windows.Forms.RadioButton rbSeguro;
		private System.Windows.Forms.Label lblDocumentacion;
		private System.Windows.Forms.RadioButton rbCortinas;
		private System.Windows.Forms.RadioButton rbCorbata;
		private System.Windows.Forms.RadioButton rbPantalones;
		private System.Windows.Forms.RadioButton rbCamisa;
		private System.Windows.Forms.Label lblUniforme;
		private System.Windows.Forms.RadioButton rbTarjetaFGDL;
		private System.Windows.Forms.RadioButton rbTCirculacion;
		private System.Windows.Forms.RadioButton rbIFE;
		private System.Windows.Forms.RadioButton rbLicencia;
		private System.Windows.Forms.RadioButton rbAptoMedico;
		private System.Windows.Forms.RadioButton rbNoRespetaItinerario;
		private System.Windows.Forms.RadioButton rbInicioRutaTarde;
		private System.Windows.Forms.RadioButton rbNegarseHacerServicio;
		private System.Windows.Forms.RadioButton rbChoques;
		private System.Windows.Forms.RadioButton rbActitud;
		private System.Windows.Forms.RadioButton rbUniforme;
		private System.Windows.Forms.Label lblOtros;
		private System.Windows.Forms.RadioButton rbMovNoAutorizado;
		private System.Windows.Forms.RadioButton rbImagenOperador;
		private System.Windows.Forms.RadioButton rbOtros;
		private System.Windows.Forms.RadioButton rbDormida;
		private System.Windows.Forms.RadioButton rbTaller;
		private System.Windows.Forms.RadioButton rbIncapacidad;
		private System.Windows.Forms.RadioButton rbPermiso;
		private System.Windows.Forms.RadioButton rbImagenUnidad;
		private System.Windows.Forms.RadioButton rbExceso;
		private System.Windows.Forms.RadioButton rbCargaFueradeHorario;
		private System.Windows.Forms.RadioButton rbDiferenciaDiessel;
		private System.Windows.Forms.Label lblCombustible;
		private System.Windows.Forms.Label lblOperaciones;
		private System.Windows.Forms.Label lblTurno;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button cmdGuarda;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cmbTurno;
	}
}
