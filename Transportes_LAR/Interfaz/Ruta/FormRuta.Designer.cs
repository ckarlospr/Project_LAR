namespace Transportes_LAR.Interfaz.Ruta
{
	partial class FormRuta
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) 
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRuta));
			this.panel4 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtIntinerario = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtCantidades = new System.Windows.Forms.TextBox();
			this.lblCantidades = new System.Windows.Forms.Label();
			this.cbSalida = new System.Windows.Forms.CheckBox();
			this.cbEntrada = new System.Windows.Forms.CheckBox();
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
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.cmbZona = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtKilometros = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtCompletoForaneo = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtSencilloForaneo = new System.Windows.Forms.TextBox();
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
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.gbDias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMinuto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Controls.Add(this.groupBox1);
			this.panel4.Controls.Add(this.tabControl1);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Location = new System.Drawing.Point(11, 61);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(349, 478);
			this.panel4.TabIndex = 211;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.txtIntinerario);
			this.groupBox1.Location = new System.Drawing.Point(22, 352);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(303, 95);
			this.groupBox1.TabIndex = 228;
			this.groupBox1.TabStop = false;
			// 
			// txtIntinerario
			// 
			this.txtIntinerario.BackColor = System.Drawing.SystemColors.Menu;
			this.txtIntinerario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIntinerario.Location = new System.Drawing.Point(6, 16);
			this.txtIntinerario.Multiline = true;
			this.txtIntinerario.Name = "txtIntinerario";
			this.txtIntinerario.Size = new System.Drawing.Size(291, 62);
			this.txtIntinerario.TabIndex = 9;
			this.txtIntinerario.Text = "Pendiente";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.ImageList = this.imageList;
			this.tabControl1.Location = new System.Drawing.Point(22, 18);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(303, 302);
			this.tabControl1.TabIndex = 227;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txtCantidades);
			this.tabPage1.Controls.Add(this.lblCantidades);
			this.tabPage1.Controls.Add(this.cbSalida);
			this.tabPage1.Controls.Add(this.cbEntrada);
			this.tabPage1.Controls.Add(this.cbForanea);
			this.tabPage1.Controls.Add(this.gbDias);
			this.tabPage1.Controls.Add(this.numMinuto);
			this.tabPage1.Controls.Add(this.numHora);
			this.tabPage1.Controls.Add(this.cmbTurno);
			this.tabPage1.Controls.Add(this.cmbZona);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtKilometros);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txtNombre);
			this.tabPage1.Controls.Add(this.label48);
			this.tabPage1.ImageIndex = 0;
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(295, 275);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ruta";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtCantidades
			// 
			this.txtCantidades.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidades.Location = new System.Drawing.Point(250, 119);
			this.txtCantidades.Name = "txtCantidades";
			this.txtCantidades.Size = new System.Drawing.Size(35, 20);
			this.txtCantidades.TabIndex = 242;
			this.txtCantidades.Text = "1";
			this.txtCantidades.Visible = false;
			// 
			// lblCantidades
			// 
			this.lblCantidades.AutoSize = true;
			this.lblCantidades.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidades.Location = new System.Drawing.Point(209, 122);
			this.lblCantidades.Name = "lblCantidades";
			this.lblCantidades.Size = new System.Drawing.Size(35, 14);
			this.lblCantidades.TabIndex = 241;
			this.lblCantidades.Text = "Cant.:";
			this.lblCantidades.Visible = false;
			// 
			// cbSalida
			// 
			this.cbSalida.Location = new System.Drawing.Point(199, 91);
			this.cbSalida.Name = "cbSalida";
			this.cbSalida.Size = new System.Drawing.Size(64, 24);
			this.cbSalida.TabIndex = 240;
			this.cbSalida.Text = "Salida";
			this.cbSalida.UseVisualStyleBackColor = true;
			// 
			// cbEntrada
			// 
			this.cbEntrada.Location = new System.Drawing.Point(123, 91);
			this.cbEntrada.Name = "cbEntrada";
			this.cbEntrada.Size = new System.Drawing.Size(70, 24);
			this.cbEntrada.TabIndex = 239;
			this.cbEntrada.Text = "Entrada";
			this.cbEntrada.UseVisualStyleBackColor = true;
			// 
			// cbForanea
			// 
			this.cbForanea.Location = new System.Drawing.Point(212, 145);
			this.cbForanea.Name = "cbForanea";
			this.cbForanea.Size = new System.Drawing.Size(81, 24);
			this.cbForanea.TabIndex = 238;
			this.cbForanea.Text = "Foranea";
			this.cbForanea.UseVisualStyleBackColor = true;
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
			this.gbDias.Location = new System.Drawing.Point(6, 201);
			this.gbDias.Name = "gbDias";
			this.gbDias.Size = new System.Drawing.Size(279, 67);
			this.gbDias.TabIndex = 8;
			this.gbDias.TabStop = false;
			this.gbDias.Text = "Días";
			// 
			// cbxDomingo
			// 
			this.cbxDomingo.Checked = true;
			this.cbxDomingo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxDomingo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDomingo.Location = new System.Drawing.Point(74, 39);
			this.cbxDomingo.Name = "cbxDomingo";
			this.cbxDomingo.Size = new System.Drawing.Size(38, 20);
			this.cbxDomingo.TabIndex = 6;
			this.cbxDomingo.Text = "D";
			this.cbxDomingo.UseVisualStyleBackColor = true;
			// 
			// cbxSabado
			// 
			this.cbxSabado.Checked = true;
			this.cbxSabado.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxSabado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSabado.Location = new System.Drawing.Point(30, 39);
			this.cbxSabado.Name = "cbxSabado";
			this.cbxSabado.Size = new System.Drawing.Size(38, 20);
			this.cbxSabado.TabIndex = 5;
			this.cbxSabado.Text = "S";
			this.cbxSabado.UseVisualStyleBackColor = true;
			// 
			// cbxViernes
			// 
			this.cbxViernes.Checked = true;
			this.cbxViernes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxViernes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxViernes.Location = new System.Drawing.Point(206, 13);
			this.cbxViernes.Name = "cbxViernes";
			this.cbxViernes.Size = new System.Drawing.Size(38, 20);
			this.cbxViernes.TabIndex = 4;
			this.cbxViernes.Text = "V";
			this.cbxViernes.UseVisualStyleBackColor = true;
			// 
			// cbxJueves
			// 
			this.cbxJueves.Checked = true;
			this.cbxJueves.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxJueves.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxJueves.Location = new System.Drawing.Point(162, 13);
			this.cbxJueves.Name = "cbxJueves";
			this.cbxJueves.Size = new System.Drawing.Size(38, 20);
			this.cbxJueves.TabIndex = 3;
			this.cbxJueves.Text = "J";
			this.cbxJueves.UseVisualStyleBackColor = true;
			this.cbxJueves.CheckedChanged += new System.EventHandler(this.CbxJuevesCheckedChanged);
			// 
			// cbxMiercoles
			// 
			this.cbxMiercoles.Checked = true;
			this.cbxMiercoles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxMiercoles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxMiercoles.Location = new System.Drawing.Point(118, 13);
			this.cbxMiercoles.Name = "cbxMiercoles";
			this.cbxMiercoles.Size = new System.Drawing.Size(48, 20);
			this.cbxMiercoles.TabIndex = 2;
			this.cbxMiercoles.Text = "Mi";
			this.cbxMiercoles.UseVisualStyleBackColor = true;
			// 
			// cbxMartes
			// 
			this.cbxMartes.Checked = true;
			this.cbxMartes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxMartes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxMartes.Location = new System.Drawing.Point(74, 13);
			this.cbxMartes.Name = "cbxMartes";
			this.cbxMartes.Size = new System.Drawing.Size(38, 20);
			this.cbxMartes.TabIndex = 1;
			this.cbxMartes.Text = "M";
			this.cbxMartes.UseVisualStyleBackColor = true;
			// 
			// cbxLunes
			// 
			this.cbxLunes.Checked = true;
			this.cbxLunes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxLunes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxLunes.Location = new System.Drawing.Point(30, 13);
			this.cbxLunes.Name = "cbxLunes";
			this.cbxLunes.Size = new System.Drawing.Size(38, 20);
			this.cbxLunes.TabIndex = 0;
			this.cbxLunes.Text = "L";
			this.cbxLunes.UseVisualStyleBackColor = true;
			// 
			// numMinuto
			// 
			this.numMinuto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numMinuto.Location = new System.Drawing.Point(147, 145);
			this.numMinuto.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.numMinuto.Name = "numMinuto";
			this.numMinuto.Size = new System.Drawing.Size(46, 20);
			this.numMinuto.TabIndex = 6;
			this.numMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numMinuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumFormatoKeyPress);
			// 
			// numHora
			// 
			this.numHora.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numHora.Location = new System.Drawing.Point(95, 145);
			this.numHora.Maximum = new decimal(new int[] {
									23,
									0,
									0,
									0});
			this.numHora.Name = "numHora";
			this.numHora.Size = new System.Drawing.Size(46, 20);
			this.numHora.TabIndex = 5;
			this.numHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumFormatoKeyPress);
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(95, 67);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(190, 22);
			this.cmbTurno.TabIndex = 2;
			// 
			// cmbZona
			// 
			this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZona.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbZona.FormattingEnabled = true;
			this.cmbZona.Location = new System.Drawing.Point(95, 171);
			this.cmbZona.Name = "cmbZona";
			this.cmbZona.Size = new System.Drawing.Size(190, 22);
			this.cmbZona.TabIndex = 7;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(48, 174);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(35, 14);
			this.label14.TabIndex = 237;
			this.label14.Text = "Zona:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 14);
			this.label5.TabIndex = 236;
			this.label5.Text = "Hora inicio:";
			// 
			// txtKilometros
			// 
			this.txtKilometros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKilometros.Location = new System.Drawing.Point(95, 119);
			this.txtKilometros.Name = "txtKilometros";
			this.txtKilometros.Size = new System.Drawing.Size(108, 20);
			this.txtKilometros.TabIndex = 4;
			this.txtKilometros.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 14);
			this.label4.TabIndex = 235;
			this.label4.Text = "Kilometros:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(37, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 14);
			this.label3.TabIndex = 234;
			this.label3.Text = "Sentido:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 14);
			this.label2.TabIndex = 233;
			this.label2.Text = "Turno";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 20);
			this.label1.TabIndex = 232;
			this.label1.Text = "Datos de la ruta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(95, 41);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(190, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(36, 44);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(47, 14);
			this.label48.TabIndex = 231;
			this.label48.Text = "Nombre:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtCompletoForaneo);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.txtSencilloForaneo);
			this.tabPage2.Controls.Add(this.txtCompletoCamioneta);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.txtSencilloCamioneta);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.txtSencilloCamion);
			this.tabPage2.Controls.Add(this.txtCompletoCamion);
			this.tabPage2.ImageIndex = 1;
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(295, 275);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Precio";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtCompletoForaneo
			// 
			this.txtCompletoForaneo.Location = new System.Drawing.Point(97, 225);
			this.txtCompletoForaneo.Name = "txtCompletoForaneo";
			this.txtCompletoForaneo.Size = new System.Drawing.Size(190, 20);
			this.txtCompletoForaneo.TabIndex = 17;
			this.txtCompletoForaneo.Text = "0";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(23, 228);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 14);
			this.label17.TabIndex = 245;
			this.label17.Text = "$ completo:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(31, 202);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(55, 14);
			this.label18.TabIndex = 244;
			this.label18.Text = "$ sencillo:";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 170);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(281, 20);
			this.label16.TabIndex = 243;
			this.label16.Text = "Foreaneo";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSencilloForaneo
			// 
			this.txtSencilloForaneo.Location = new System.Drawing.Point(97, 199);
			this.txtSencilloForaneo.Name = "txtSencilloForaneo";
			this.txtSencilloForaneo.Size = new System.Drawing.Size(190, 20);
			this.txtSencilloForaneo.TabIndex = 16;
			this.txtSencilloForaneo.Text = "0";
			// 
			// txtCompletoCamioneta
			// 
			this.txtCompletoCamioneta.Location = new System.Drawing.Point(97, 144);
			this.txtCompletoCamioneta.Name = "txtCompletoCamioneta";
			this.txtCompletoCamioneta.Size = new System.Drawing.Size(190, 20);
			this.txtCompletoCamioneta.TabIndex = 15;
			this.txtCompletoCamioneta.Text = "0";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 92);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(281, 20);
			this.label10.TabIndex = 242;
			this.label10.Text = "Camioneta";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(281, 20);
			this.label9.TabIndex = 239;
			this.label9.Text = "Camión";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSencilloCamioneta
			// 
			this.txtSencilloCamioneta.Location = new System.Drawing.Point(97, 118);
			this.txtSencilloCamioneta.Name = "txtSencilloCamioneta";
			this.txtSencilloCamioneta.Size = new System.Drawing.Size(190, 20);
			this.txtSencilloCamioneta.TabIndex = 14;
			this.txtSencilloCamioneta.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(33, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 14);
			this.label6.TabIndex = 237;
			this.label6.Text = "$ sencilo:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(23, 147);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 14);
			this.label11.TabIndex = 241;
			this.label11.Text = "$ completo:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(23, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 14);
			this.label7.TabIndex = 238;
			this.label7.Text = "$ completo:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(31, 121);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(55, 14);
			this.label15.TabIndex = 240;
			this.label15.Text = "$ sencillo:";
			// 
			// txtSencilloCamion
			// 
			this.txtSencilloCamion.Location = new System.Drawing.Point(97, 40);
			this.txtSencilloCamion.Name = "txtSencilloCamion";
			this.txtSencilloCamion.Size = new System.Drawing.Size(190, 20);
			this.txtSencilloCamion.TabIndex = 12;
			this.txtSencilloCamion.Text = "0";
			// 
			// txtCompletoCamion
			// 
			this.txtCompletoCamion.Location = new System.Drawing.Point(97, 66);
			this.txtCompletoCamion.Name = "txtCompletoCamion";
			this.txtCompletoCamion.Size = new System.Drawing.Size(190, 20);
			this.txtCompletoCamion.TabIndex = 13;
			this.txtCompletoCamion.Text = "0";
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Ruta_Icono.png");
			this.imageList.Images.SetKeyName(1, "precio.png");
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(22, 329);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(303, 20);
			this.label12.TabIndex = 221;
			this.label12.Text = "Intinerario de la ruta:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(10, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(54, 52);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 226;
			this.pictureBox2.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(70, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(164, 14);
			this.label8.TabIndex = 223;
			this.label8.Text = "Ingrese los datos  de la ruta:";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(270, 548);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(90, 27);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(178, 548);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(86, 27);
			this.btnAgregar.TabIndex = 10;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(-1, -2);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(371, 78);
			this.label13.TabIndex = 229;
			// 
			// FormRuta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(370, 584);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.label13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormRuta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Ruta";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRutaFormClosing);
			this.Load += new System.EventHandler(this.FormRutaLoad);
			this.panel4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.gbDias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numMinuto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblCantidades;
		public System.Windows.Forms.TextBox txtCantidades;
		private System.Windows.Forms.CheckBox cbEntrada;
		private System.Windows.Forms.CheckBox cbSalida;
		private System.Windows.Forms.CheckBox cbForanea;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox cbxLunes;
		private System.Windows.Forms.CheckBox cbxMartes;
		private System.Windows.Forms.CheckBox cbxMiercoles;
		private System.Windows.Forms.CheckBox cbxJueves;
		private System.Windows.Forms.CheckBox cbxViernes;
		private System.Windows.Forms.CheckBox cbxSabado;
		private System.Windows.Forms.CheckBox cbxDomingo;
		public System.Windows.Forms.GroupBox gbDias;
		public System.Windows.Forms.NumericUpDown numHora;
		public System.Windows.Forms.NumericUpDown numMinuto;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label17;
		public System.Windows.Forms.TextBox txtCompletoForaneo;
		public System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.TabPage tabPage1;
		public System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.TextBox txtSencilloForaneo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Button btnAgregar;
		public System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label48;
		public System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtCompletoCamion;
		public System.Windows.Forms.TextBox txtSencilloCamion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox txtKilometros;
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
		private System.Windows.Forms.Panel panel4;
	}
}
