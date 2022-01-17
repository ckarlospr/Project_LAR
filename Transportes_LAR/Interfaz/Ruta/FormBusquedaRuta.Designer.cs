/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 19/07/2012
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Ruta
{
	partial class FormBusquedaRuta
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaRuta));
			this.btnAceptar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnAgreagar = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cbForanea = new System.Windows.Forms.CheckBox();
			this.gbDias = new System.Windows.Forms.GroupBox();
			this.cbxDomingo = new System.Windows.Forms.CheckBox();
			this.cbxSabado = new System.Windows.Forms.CheckBox();
			this.cbxViernes = new System.Windows.Forms.CheckBox();
			this.cbxJueves = new System.Windows.Forms.CheckBox();
			this.cbxMiercoles = new System.Windows.Forms.CheckBox();
			this.cbxMartes = new System.Windows.Forms.CheckBox();
			this.cbxLunes = new System.Windows.Forms.CheckBox();
			this.numMinuto = new System.Windows.Forms.NumericUpDown();
			this.numHora = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtIntinerario = new System.Windows.Forms.TextBox();
			this.cmbSentido = new System.Windows.Forms.ComboBox();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.cmbZona = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtKilometros = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.txtCompletoForaneo = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtSencilloForaneo = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCompletoCamioneta = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSencilloCamioneta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtSencilloCamion = new System.Windows.Forms.TextBox();
			this.txtCompletoCamion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataRuta = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.gbDias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMinuto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataRuta)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(779, 549);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(93, 29);
			this.btnAceptar.TabIndex = 18;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnBuscar);
			this.panel2.Controls.Add(this.btnAgreagar);
			this.panel2.Controls.Add(this.btnRemover);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataRuta);
			this.panel2.Location = new System.Drawing.Point(0, 70);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(896, 473);
			this.panel2.TabIndex = 209;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(186, 427);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(80, 31);
			this.btnBuscar.TabIndex = 22;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// btnAgreagar
			// 
			this.btnAgreagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgreagar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgreagar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgreagar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgreagar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgreagar.Image")));
			this.btnAgreagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgreagar.Location = new System.Drawing.Point(11, 427);
			this.btnAgreagar.Name = "btnAgreagar";
			this.btnAgreagar.Size = new System.Drawing.Size(80, 31);
			this.btnAgreagar.TabIndex = 20;
			this.btnAgreagar.Text = "Agregar";
			this.btnAgreagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgreagar.UseVisualStyleBackColor = false;
			this.btnAgreagar.Click += new System.EventHandler(this.BtnAgreagarClick);
			// 
			// btnRemover
			// 
			this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemover.BackColor = System.Drawing.Color.Transparent;
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
			this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.Location = new System.Drawing.Point(94, 427);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(89, 31);
			this.btnRemover.TabIndex = 21;
			this.btnRemover.Text = "Remover";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.cbForanea);
			this.panel4.Controls.Add(this.gbDias);
			this.panel4.Controls.Add(this.numMinuto);
			this.panel4.Controls.Add(this.numHora);
			this.panel4.Controls.Add(this.groupBox1);
			this.panel4.Controls.Add(this.cmbSentido);
			this.panel4.Controls.Add(this.cmbTurno);
			this.panel4.Controls.Add(this.cmbZona);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.txtKilometros);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txtNombre);
			this.panel4.Controls.Add(this.label48);
			this.panel4.Controls.Add(this.txtCompletoForaneo);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.txtSencilloForaneo);
			this.panel4.Controls.Add(this.panel3);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.txtCompletoCamioneta);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.txtSencilloCamioneta);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.txtSencilloCamion);
			this.panel4.Controls.Add(this.txtCompletoCamion);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Location = new System.Drawing.Point(287, 14);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(596, 445);
			this.panel4.TabIndex = 210;
			// 
			// cbForanea
			// 
			this.cbForanea.BackColor = System.Drawing.Color.Transparent;
			this.cbForanea.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbForanea.Location = new System.Drawing.Point(105, 207);
			this.cbForanea.Name = "cbForanea";
			this.cbForanea.Size = new System.Drawing.Size(104, 24);
			this.cbForanea.TabIndex = 265;
			this.cbForanea.Text = "Foranea";
			this.cbForanea.UseVisualStyleBackColor = false;
			// 
			// gbDias
			// 
			this.gbDias.BackColor = System.Drawing.Color.Transparent;
			this.gbDias.Controls.Add(this.cbxDomingo);
			this.gbDias.Controls.Add(this.cbxSabado);
			this.gbDias.Controls.Add(this.cbxViernes);
			this.gbDias.Controls.Add(this.cbxJueves);
			this.gbDias.Controls.Add(this.cbxMiercoles);
			this.gbDias.Controls.Add(this.cbxMartes);
			this.gbDias.Controls.Add(this.cbxLunes);
			this.gbDias.Location = new System.Drawing.Point(13, 252);
			this.gbDias.Name = "gbDias";
			this.gbDias.Size = new System.Drawing.Size(568, 39);
			this.gbDias.TabIndex = 14;
			this.gbDias.TabStop = false;
			this.gbDias.Text = "Días";
			// 
			// cbxDomingo
			// 
			this.cbxDomingo.Enabled = false;
			this.cbxDomingo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDomingo.Location = new System.Drawing.Point(482, 13);
			this.cbxDomingo.Name = "cbxDomingo";
			this.cbxDomingo.Size = new System.Drawing.Size(80, 20);
			this.cbxDomingo.TabIndex = 6;
			this.cbxDomingo.Text = "Domingo";
			this.cbxDomingo.UseVisualStyleBackColor = true;
			// 
			// cbxSabado
			// 
			this.cbxSabado.Enabled = false;
			this.cbxSabado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSabado.Location = new System.Drawing.Point(404, 13);
			this.cbxSabado.Name = "cbxSabado";
			this.cbxSabado.Size = new System.Drawing.Size(72, 20);
			this.cbxSabado.TabIndex = 5;
			this.cbxSabado.Text = "Sabado";
			this.cbxSabado.UseVisualStyleBackColor = true;
			// 
			// cbxViernes
			// 
			this.cbxViernes.Enabled = false;
			this.cbxViernes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxViernes.Location = new System.Drawing.Point(326, 13);
			this.cbxViernes.Name = "cbxViernes";
			this.cbxViernes.Size = new System.Drawing.Size(72, 20);
			this.cbxViernes.TabIndex = 4;
			this.cbxViernes.Text = "Viernes";
			this.cbxViernes.UseVisualStyleBackColor = true;
			// 
			// cbxJueves
			// 
			this.cbxJueves.Enabled = false;
			this.cbxJueves.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxJueves.Location = new System.Drawing.Point(257, 13);
			this.cbxJueves.Name = "cbxJueves";
			this.cbxJueves.Size = new System.Drawing.Size(72, 20);
			this.cbxJueves.TabIndex = 3;
			this.cbxJueves.Text = "Jueves";
			this.cbxJueves.UseVisualStyleBackColor = true;
			// 
			// cbxMiercoles
			// 
			this.cbxMiercoles.Enabled = false;
			this.cbxMiercoles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxMiercoles.Location = new System.Drawing.Point(170, 13);
			this.cbxMiercoles.Name = "cbxMiercoles";
			this.cbxMiercoles.Size = new System.Drawing.Size(81, 20);
			this.cbxMiercoles.TabIndex = 2;
			this.cbxMiercoles.Text = "Miercoles";
			this.cbxMiercoles.UseVisualStyleBackColor = true;
			// 
			// cbxMartes
			// 
			this.cbxMartes.Enabled = false;
			this.cbxMartes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxMartes.Location = new System.Drawing.Point(92, 13);
			this.cbxMartes.Name = "cbxMartes";
			this.cbxMartes.Size = new System.Drawing.Size(72, 20);
			this.cbxMartes.TabIndex = 1;
			this.cbxMartes.Text = "Martes";
			this.cbxMartes.UseVisualStyleBackColor = true;
			// 
			// cbxLunes
			// 
			this.cbxLunes.Enabled = false;
			this.cbxLunes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxLunes.Location = new System.Drawing.Point(14, 13);
			this.cbxLunes.Name = "cbxLunes";
			this.cbxLunes.Size = new System.Drawing.Size(72, 20);
			this.cbxLunes.TabIndex = 0;
			this.cbxLunes.Text = "Lunes";
			this.cbxLunes.UseVisualStyleBackColor = true;
			// 
			// numMinuto
			// 
			this.numMinuto.Enabled = false;
			this.numMinuto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numMinuto.Location = new System.Drawing.Point(158, 146);
			this.numMinuto.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.numMinuto.Name = "numMinuto";
			this.numMinuto.Size = new System.Drawing.Size(46, 20);
			this.numMinuto.TabIndex = 6;
			this.numMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numMinuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumHoraKeyPress);
			// 
			// numHora
			// 
			this.numHora.Enabled = false;
			this.numHora.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numHora.Location = new System.Drawing.Point(104, 146);
			this.numHora.Maximum = new decimal(new int[] {
									23,
									0,
									0,
									0});
			this.numHora.Name = "numHora";
			this.numHora.Size = new System.Drawing.Size(46, 20);
			this.numHora.TabIndex = 5;
			this.numHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumHoraKeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtIntinerario);
			this.groupBox1.Location = new System.Drawing.Point(13, 320);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(568, 72);
			this.groupBox1.TabIndex = 264;
			this.groupBox1.TabStop = false;
			// 
			// txtIntinerario
			// 
			this.txtIntinerario.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtIntinerario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIntinerario.Location = new System.Drawing.Point(6, 13);
			this.txtIntinerario.Multiline = true;
			this.txtIntinerario.Name = "txtIntinerario";
			this.txtIntinerario.Size = new System.Drawing.Size(556, 53);
			this.txtIntinerario.TabIndex = 15;
			// 
			// cmbSentido
			// 
			this.cmbSentido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSentido.Enabled = false;
			this.cmbSentido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSentido.FormattingEnabled = true;
			this.cmbSentido.Items.AddRange(new object[] {
									"Entrada",
									"Salida"});
			this.cmbSentido.Location = new System.Drawing.Point(104, 94);
			this.cmbSentido.Name = "cmbSentido";
			this.cmbSentido.Size = new System.Drawing.Size(190, 22);
			this.cmbSentido.TabIndex = 3;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Enabled = false;
			this.cmbTurno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(104, 68);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(190, 22);
			this.cmbTurno.TabIndex = 2;
			// 
			// cmbZona
			// 
			this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZona.Enabled = false;
			this.cmbZona.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbZona.FormattingEnabled = true;
			this.cmbZona.Location = new System.Drawing.Point(104, 172);
			this.cmbZona.Name = "cmbZona";
			this.cmbZona.Size = new System.Drawing.Size(190, 22);
			this.cmbZona.TabIndex = 7;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(57, 175);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(35, 14);
			this.label14.TabIndex = 262;
			this.label14.Text = "Zona:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 14);
			this.label5.TabIndex = 261;
			this.label5.Text = "Hora inicio:";
			// 
			// txtKilometros
			// 
			this.txtKilometros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKilometros.Location = new System.Drawing.Point(104, 120);
			this.txtKilometros.Name = "txtKilometros";
			this.txtKilometros.Size = new System.Drawing.Size(190, 20);
			this.txtKilometros.TabIndex = 4;
			this.txtKilometros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 14);
			this.label4.TabIndex = 260;
			this.label4.Text = "Kilometros:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(46, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 14);
			this.label3.TabIndex = 259;
			this.label3.Text = "Sentido:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 14);
			this.label2.TabIndex = 258;
			this.label2.Text = "Turno";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(104, 42);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(190, 20);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.BackColor = System.Drawing.Color.Transparent;
			this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(45, 45);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(47, 14);
			this.label48.TabIndex = 257;
			this.label48.Text = "Nombre:";
			// 
			// txtCompletoForaneo
			// 
			this.txtCompletoForaneo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCompletoForaneo.Location = new System.Drawing.Point(391, 226);
			this.txtCompletoForaneo.Name = "txtCompletoForaneo";
			this.txtCompletoForaneo.Size = new System.Drawing.Size(190, 20);
			this.txtCompletoForaneo.TabIndex = 13;
			this.txtCompletoForaneo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(317, 229);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 14);
			this.label17.TabIndex = 250;
			this.label17.Text = "$ completo:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(325, 203);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(55, 14);
			this.label18.TabIndex = 249;
			this.label18.Text = "$ sencillo:";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(300, 171);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(281, 20);
			this.label16.TabIndex = 248;
			this.label16.Text = "Foreaneo";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSencilloForaneo
			// 
			this.txtSencilloForaneo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSencilloForaneo.Location = new System.Drawing.Point(391, 200);
			this.txtSencilloForaneo.Name = "txtSencilloForaneo";
			this.txtSencilloForaneo.Size = new System.Drawing.Size(190, 20);
			this.txtSencilloForaneo.TabIndex = 12;
			this.txtSencilloForaneo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Controls.Add(this.checkBox1);
			this.panel3.Controls.Add(this.btnModificar);
			this.panel3.Location = new System.Drawing.Point(0, 401);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(592, 37);
			this.panel3.TabIndex = 223;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(346, 10);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(111, 18);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Modificar datos";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// btnModificar
			// 
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Enabled = false;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(488, 5);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(93, 28);
			this.btnModificar.TabIndex = 17;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 299);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(568, 20);
			this.label12.TabIndex = 221;
			this.label12.Text = "Intinerario de la ruta:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCompletoCamioneta
			// 
			this.txtCompletoCamioneta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCompletoCamioneta.Location = new System.Drawing.Point(391, 146);
			this.txtCompletoCamioneta.Name = "txtCompletoCamioneta";
			this.txtCompletoCamioneta.Size = new System.Drawing.Size(190, 20);
			this.txtCompletoCamioneta.TabIndex = 11;
			this.txtCompletoCamioneta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(300, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(281, 20);
			this.label10.TabIndex = 182;
			this.label10.Text = "Precio camioneta:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(300, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(281, 20);
			this.label9.TabIndex = 176;
			this.label9.Text = "Precio camión:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSencilloCamioneta
			// 
			this.txtSencilloCamioneta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSencilloCamioneta.Location = new System.Drawing.Point(391, 120);
			this.txtSencilloCamioneta.Name = "txtSencilloCamioneta";
			this.txtSencilloCamioneta.Size = new System.Drawing.Size(190, 20);
			this.txtSencilloCamioneta.TabIndex = 10;
			this.txtSencilloCamioneta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(327, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 14);
			this.label6.TabIndex = 172;
			this.label6.Text = "$ sencilo:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(317, 149);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 14);
			this.label11.TabIndex = 180;
			this.label11.Text = "$ completo:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(317, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 14);
			this.label7.TabIndex = 173;
			this.label7.Text = "$ completo:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(325, 123);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(55, 14);
			this.label15.TabIndex = 179;
			this.label15.Text = "$ sencillo:";
			// 
			// txtSencilloCamion
			// 
			this.txtSencilloCamion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSencilloCamion.Location = new System.Drawing.Point(391, 42);
			this.txtSencilloCamion.Name = "txtSencilloCamion";
			this.txtSencilloCamion.Size = new System.Drawing.Size(190, 20);
			this.txtSencilloCamion.TabIndex = 8;
			this.txtSencilloCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// txtCompletoCamion
			// 
			this.txtCompletoCamion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCompletoCamion.Location = new System.Drawing.Point(391, 68);
			this.txtCompletoCamion.Name = "txtCompletoCamion";
			this.txtCompletoCamion.Size = new System.Drawing.Size(190, 20);
			this.txtCompletoCamion.TabIndex = 9;
			this.txtCompletoCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 20);
			this.label1.TabIndex = 163;
			this.label1.Text = "Datos de la ruta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataRuta
			// 
			this.dataRuta.AllowUserToAddRows = false;
			this.dataRuta.AllowUserToDeleteRows = false;
			this.dataRuta.AllowUserToResizeColumns = false;
			this.dataRuta.AllowUserToResizeRows = false;
			this.dataRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataRuta.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataRuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2});
			this.dataRuta.Location = new System.Drawing.Point(11, 14);
			this.dataRuta.Name = "dataRuta";
			this.dataRuta.ReadOnly = true;
			this.dataRuta.RowHeadersVisible = false;
			this.dataRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataRuta.Size = new System.Drawing.Size(255, 404);
			this.dataRuta.TabIndex = 19;
			this.dataRuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataRutaCellClick);
			this.dataRuta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataRutaKeyUp);
			this.dataRuta.Layout += new System.Windows.Forms.LayoutEventHandler(this.DataRutaLayout);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Nombre";
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Width = 250;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.lblTitulo);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(896, 70);
			this.panel1.TabIndex = 208;
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(79, 24);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(731, 23);
			this.lblTitulo.TabIndex = 6;
			this.lblTitulo.Text = "Control de rutas del cliente:";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(11, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(62, 60);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(820, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 62);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// FormBusquedaRuta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(896, 590);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBusquedaRuta";
			this.Text = "Transportes LAR - Busqueda de la Ruta";
			this.Load += new System.EventHandler(this.FormBusquedaRutaLoad);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBusquedaRutaFormClosing);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.gbDias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numMinuto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataRuta)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox cbForanea;
		private System.Windows.Forms.CheckBox cbxJueves;
		private System.Windows.Forms.CheckBox cbxViernes;
		private System.Windows.Forms.CheckBox cbxSabado;
		private System.Windows.Forms.CheckBox cbxDomingo;
		private System.Windows.Forms.CheckBox cbxLunes;
		private System.Windows.Forms.CheckBox cbxMartes;
		private System.Windows.Forms.CheckBox cbxMiercoles;
		private System.Windows.Forms.GroupBox gbDias;
		private System.Windows.Forms.ErrorProvider error;
		public System.Windows.Forms.NumericUpDown numHora;
		public System.Windows.Forms.NumericUpDown numMinuto;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtKilometros;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.ComboBox cmbSentido;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox txtSencilloForaneo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		public System.Windows.Forms.TextBox txtCompletoForaneo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataRuta;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtCompletoCamion;
		public System.Windows.Forms.TextBox txtSencilloCamion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtSencilloCamioneta;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.TextBox txtCompletoCamioneta;
		private System.Windows.Forms.ComboBox cmbZona;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.TextBox txtIntinerario;
		public System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Button btnRemover;
		public System.Windows.Forms.Button btnAgreagar;
		public System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Button btnAceptar;
	}
}
