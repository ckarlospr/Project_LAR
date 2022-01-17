/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 08/07/2013
 * Time: 12:10 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Ruta
{
	partial class FormRutasExtras
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRutasExtras));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.txtAutoriza = new System.Windows.Forms.TextBox();
			this.gbDatosDom = new System.Windows.Forms.GroupBox();
			this.cmdAgregarUsuario = new System.Windows.Forms.Button();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblDestino = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lblHora = new System.Windows.Forms.Label();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.lblTurno = new System.Windows.Forms.Label();
			this.lblSentido = new System.Windows.Forms.Label();
			this.gbDatosPrinc = new System.Windows.Forms.GroupBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtSubNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbVelada = new System.Windows.Forms.CheckBox();
			this.cbForanea = new System.Windows.Forms.CheckBox();
			this.cbSalida = new System.Windows.Forms.CheckBox();
			this.cbEntrada = new System.Windows.Forms.CheckBox();
			this.txtHora = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbDomiciliada = new System.Windows.Forms.CheckBox();
			this.gbCriterios = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.rbPendiente = new System.Windows.Forms.RadioButton();
			this.rbExtLarga = new System.Windows.Forms.RadioButton();
			this.rbLarga = new System.Windows.Forms.RadioButton();
			this.rbMediana = new System.Windows.Forms.RadioButton();
			this.rbNormal = new System.Windows.Forms.RadioButton();
			this.label16 = new System.Windows.Forms.Label();
			this.cbCobrar = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.dgUsuarios = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOMICILIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COLONIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdEliminarUsuario = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbDatosDom.SuspendLayout();
			this.gbDatosPrinc.SuspendLayout();
			this.gbCriterios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Location = new System.Drawing.Point(463, 275);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(71, 48);
			this.cmdAgregar.TabIndex = 10;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// txtDestino
			// 
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(89, 50);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(168, 22);
			this.txtDestino.TabIndex = 2;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAutoriza
			// 
			this.txtAutoriza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAutoriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAutoriza.Location = new System.Drawing.Point(81, 9);
			this.txtAutoriza.Name = "txtAutoriza";
			this.txtAutoriza.Size = new System.Drawing.Size(162, 22);
			this.txtAutoriza.TabIndex = 1;
			this.txtAutoriza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAutorizaKeyUp);
			// 
			// gbDatosDom
			// 
			this.gbDatosDom.Controls.Add(this.cmdAgregarUsuario);
			this.gbDatosDom.Controls.Add(this.txtColonia);
			this.gbDatosDom.Controls.Add(this.label1);
			this.gbDatosDom.Controls.Add(this.txtTelefono);
			this.gbDatosDom.Controls.Add(this.label4);
			this.gbDatosDom.Controls.Add(this.label7);
			this.gbDatosDom.Controls.Add(this.label8);
			this.gbDatosDom.Controls.Add(this.txtUsuario);
			this.gbDatosDom.Controls.Add(this.txtDomicilio);
			this.gbDatosDom.Controls.Add(this.txtComentario);
			this.gbDatosDom.Controls.Add(this.txtAutoriza);
			this.gbDatosDom.Controls.Add(this.label2);
			this.gbDatosDom.Enabled = false;
			this.gbDatosDom.Location = new System.Drawing.Point(285, 15);
			this.gbDatosDom.Name = "gbDatosDom";
			this.gbDatosDom.Size = new System.Drawing.Size(249, 245);
			this.gbDatosDom.TabIndex = 4;
			this.gbDatosDom.TabStop = false;
			this.gbDatosDom.Enter += new System.EventHandler(this.GbDatosDomEnter);
			// 
			// cmdAgregarUsuario
			// 
			this.cmdAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarUsuario.Image")));
			this.cmdAgregarUsuario.Location = new System.Drawing.Point(207, 173);
			this.cmdAgregarUsuario.Name = "cmdAgregarUsuario";
			this.cmdAgregarUsuario.Size = new System.Drawing.Size(36, 64);
			this.cmdAgregarUsuario.TabIndex = 13;
			this.cmdAgregarUsuario.UseVisualStyleBackColor = true;
			this.cmdAgregarUsuario.Click += new System.EventHandler(this.CmdAgregarUsuarioClick);
			// 
			// txtColonia
			// 
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(81, 140);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(162, 22);
			this.txtColonia.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 21);
			this.label1.TabIndex = 11;
			this.label1.Text = "Colonia:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTelefono
			// 
			this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(81, 75);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(162, 22);
			this.txtTelefono.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Telefono:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "Domicilio:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(19, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "Usuario:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(81, 42);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(162, 22);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioKeyUp);
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(81, 107);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(162, 22);
			this.txtDomicilio.TabIndex = 3;
			// 
			// txtComentario
			// 
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(7, 178);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(195, 59);
			this.txtComentario.TabIndex = 6;
			this.txtComentario.Text = "Comentario";
			this.txtComentario.Click += new System.EventHandler(this.TxtComentarioClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Autoriza:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDestino
			// 
			this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestino.Location = new System.Drawing.Point(30, 50);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.Size = new System.Drawing.Size(56, 23);
			this.lblDestino.TabIndex = 3;
			this.lblDestino.Text = "Destino:";
			this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCantidad
			// 
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(129, 197);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(87, 23);
			this.lblCantidad.TabIndex = 17;
			this.lblCantidad.Text = "Cantidad:";
			this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(217, 197);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(29, 22);
			this.txtCantidad.TabIndex = 7;
			this.txtCantidad.Text = "1";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadKeyPress);
			// 
			// lblHora
			// 
			this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.Location = new System.Drawing.Point(9, 197);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(52, 23);
			this.lblHora.TabIndex = 15;
			this.lblHora.Text = "Hora:";
			this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Enabled = false;
			this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(89, 132);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(168, 21);
			this.cmbTurno.TabIndex = 3;
			// 
			// lblTurno
			// 
			this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurno.Location = new System.Drawing.Point(15, 131);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(68, 23);
			this.lblTurno.TabIndex = 18;
			this.lblTurno.Text = "Turno:";
			this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSentido
			// 
			this.lblSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSentido.Location = new System.Drawing.Point(18, 172);
			this.lblSentido.Name = "lblSentido";
			this.lblSentido.Size = new System.Drawing.Size(68, 23);
			this.lblSentido.TabIndex = 19;
			this.lblSentido.Text = "Sentido:";
			this.lblSentido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbDatosPrinc
			// 
			this.gbDatosPrinc.Controls.Add(this.txtDescripcion);
			this.gbDatosPrinc.Controls.Add(this.txtSubNombre);
			this.gbDatosPrinc.Controls.Add(this.label5);
			this.gbDatosPrinc.Controls.Add(this.cbVelada);
			this.gbDatosPrinc.Controls.Add(this.cbForanea);
			this.gbDatosPrinc.Controls.Add(this.cbSalida);
			this.gbDatosPrinc.Controls.Add(this.cbEntrada);
			this.gbDatosPrinc.Controls.Add(this.txtHora);
			this.gbDatosPrinc.Controls.Add(this.label15);
			this.gbDatosPrinc.Controls.Add(this.label14);
			this.gbDatosPrinc.Controls.Add(this.label3);
			this.gbDatosPrinc.Controls.Add(this.lblSentido);
			this.gbDatosPrinc.Controls.Add(this.lblHora);
			this.gbDatosPrinc.Controls.Add(this.lblTurno);
			this.gbDatosPrinc.Controls.Add(this.cmbTurno);
			this.gbDatosPrinc.Controls.Add(this.lblCantidad);
			this.gbDatosPrinc.Controls.Add(this.txtCantidad);
			this.gbDatosPrinc.Controls.Add(this.txtDestino);
			this.gbDatosPrinc.Controls.Add(this.lblDestino);
			this.gbDatosPrinc.Location = new System.Drawing.Point(11, -4);
			this.gbDatosPrinc.Name = "gbDatosPrinc";
			this.gbDatosPrinc.Size = new System.Drawing.Size(268, 268);
			this.gbDatosPrinc.TabIndex = 1;
			this.gbDatosPrinc.TabStop = false;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(12, 76);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(247, 52);
			this.txtDescripcion.TabIndex = 14;
			this.txtDescripcion.Text = "Descripcion";
			// 
			// txtSubNombre
			// 
			this.txtSubNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSubNombre.Enabled = false;
			this.txtSubNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubNombre.Location = new System.Drawing.Point(89, 23);
			this.txtSubNombre.Name = "txtSubNombre";
			this.txtSubNombre.Size = new System.Drawing.Size(168, 22);
			this.txtSubNombre.TabIndex = 1;
			this.txtSubNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSubNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSubNombreKeyUp);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 37;
			this.label5.Text = "SubNombre:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbVelada
			// 
			this.cbVelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbVelada.Location = new System.Drawing.Point(177, 242);
			this.cbVelada.Name = "cbVelada";
			this.cbVelada.Size = new System.Drawing.Size(68, 24);
			this.cbVelada.TabIndex = 9;
			this.cbVelada.Text = "Velada";
			this.cbVelada.UseVisualStyleBackColor = true;
			this.cbVelada.CheckedChanged += new System.EventHandler(this.CbVeladaCheckedChanged);
			// 
			// cbForanea
			// 
			this.cbForanea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbForanea.Location = new System.Drawing.Point(32, 242);
			this.cbForanea.Name = "cbForanea";
			this.cbForanea.Size = new System.Drawing.Size(74, 24);
			this.cbForanea.TabIndex = 8;
			this.cbForanea.Text = "Foranea";
			this.cbForanea.UseVisualStyleBackColor = true;
			// 
			// cbSalida
			// 
			this.cbSalida.Checked = true;
			this.cbSalida.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSalida.Location = new System.Drawing.Point(183, 171);
			this.cbSalida.Name = "cbSalida";
			this.cbSalida.Size = new System.Drawing.Size(69, 24);
			this.cbSalida.TabIndex = 5;
			this.cbSalida.Text = "Salida";
			this.cbSalida.UseVisualStyleBackColor = true;
			// 
			// cbEntrada
			// 
			this.cbEntrada.Checked = true;
			this.cbEntrada.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEntrada.Location = new System.Drawing.Point(92, 172);
			this.cbEntrada.Name = "cbEntrada";
			this.cbEntrada.Size = new System.Drawing.Size(73, 24);
			this.cbEntrada.TabIndex = 4;
			this.cbEntrada.Text = "Entrada";
			this.cbEntrada.UseVisualStyleBackColor = true;
			// 
			// txtHora
			// 
			this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHora.Location = new System.Drawing.Point(64, 199);
			this.txtHora.Name = "txtHora";
			this.txtHora.Size = new System.Drawing.Size(69, 20);
			this.txtHora.TabIndex = 6;
			this.txtHora.Text = "00:00";
			this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHora.Click += new System.EventHandler(this.TxtHoraClick);
			this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoraKeyPress);
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label15.Location = new System.Drawing.Point(12, 8);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(242, 6);
			this.label15.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label14.Location = new System.Drawing.Point(12, 158);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(242, 6);
			this.label14.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(12, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 6);
			this.label3.TabIndex = 21;
			// 
			// cbDomiciliada
			// 
			this.cbDomiciliada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDomiciliada.Location = new System.Drawing.Point(365, 2);
			this.cbDomiciliada.Name = "cbDomiciliada";
			this.cbDomiciliada.Size = new System.Drawing.Size(95, 18);
			this.cbDomiciliada.TabIndex = 3;
			this.cbDomiciliada.Text = "Domiciliada";
			this.cbDomiciliada.UseVisualStyleBackColor = true;
			this.cbDomiciliada.CheckedChanged += new System.EventHandler(this.CbDomiciliadaCheckedChanged);
			// 
			// gbCriterios
			// 
			this.gbCriterios.Controls.Add(this.label17);
			this.gbCriterios.Controls.Add(this.rbPendiente);
			this.gbCriterios.Controls.Add(this.rbExtLarga);
			this.gbCriterios.Controls.Add(this.rbLarga);
			this.gbCriterios.Controls.Add(this.rbMediana);
			this.gbCriterios.Controls.Add(this.rbNormal);
			this.gbCriterios.Controls.Add(this.label16);
			this.gbCriterios.Controls.Add(this.cbCobrar);
			this.gbCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCriterios.Location = new System.Drawing.Point(11, 266);
			this.gbCriterios.Name = "gbCriterios";
			this.gbCriterios.Size = new System.Drawing.Size(446, 53);
			this.gbCriterios.TabIndex = 2;
			this.gbCriterios.TabStop = false;
			this.gbCriterios.Text = "Criterios";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label17.Location = new System.Drawing.Point(139, 9);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(199, 20);
			this.label17.TabIndex = 33;
			this.label17.Text = "KM aprox. del servicio";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbPendiente
			// 
			this.rbPendiente.Checked = true;
			this.rbPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPendiente.ForeColor = System.Drawing.Color.DarkOrange;
			this.rbPendiente.Location = new System.Drawing.Point(344, 9);
			this.rbPendiente.Name = "rbPendiente";
			this.rbPendiente.Size = new System.Drawing.Size(85, 20);
			this.rbPendiente.TabIndex = 6;
			this.rbPendiente.TabStop = true;
			this.rbPendiente.Text = "Pendiente";
			this.rbPendiente.UseVisualStyleBackColor = true;
			this.rbPendiente.CheckedChanged += new System.EventHandler(this.RbPendienteCheckedChanged);
			// 
			// rbExtLarga
			// 
			this.rbExtLarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExtLarga.Location = new System.Drawing.Point(344, 28);
			this.rbExtLarga.Name = "rbExtLarga";
			this.rbExtLarga.Size = new System.Drawing.Size(85, 20);
			this.rbExtLarga.TabIndex = 5;
			this.rbExtLarga.Text = "Extra Larga";
			this.toolTip1.SetToolTip(this.rbExtLarga, "Mas de 70 Kms");
			this.rbExtLarga.UseVisualStyleBackColor = true;
			this.rbExtLarga.CheckedChanged += new System.EventHandler(this.RbExtLargaCheckedChanged);
			// 
			// rbLarga
			// 
			this.rbLarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbLarga.Location = new System.Drawing.Point(285, 28);
			this.rbLarga.Name = "rbLarga";
			this.rbLarga.Size = new System.Drawing.Size(53, 20);
			this.rbLarga.TabIndex = 4;
			this.rbLarga.Text = "Larga";
			this.toolTip1.SetToolTip(this.rbLarga, "50-70 Kms");
			this.rbLarga.UseVisualStyleBackColor = true;
			this.rbLarga.CheckedChanged += new System.EventHandler(this.RbLargaCheckedChanged);
			// 
			// rbMediana
			// 
			this.rbMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMediana.Location = new System.Drawing.Point(212, 28);
			this.rbMediana.Name = "rbMediana";
			this.rbMediana.Size = new System.Drawing.Size(67, 20);
			this.rbMediana.TabIndex = 3;
			this.rbMediana.Text = "Mediana";
			this.toolTip1.SetToolTip(this.rbMediana, "30-50 Kms");
			this.rbMediana.UseVisualStyleBackColor = true;
			this.rbMediana.CheckedChanged += new System.EventHandler(this.RbMedianaCheckedChanged);
			// 
			// rbNormal
			// 
			this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNormal.Location = new System.Drawing.Point(139, 28);
			this.rbNormal.Name = "rbNormal";
			this.rbNormal.Size = new System.Drawing.Size(67, 20);
			this.rbNormal.TabIndex = 2;
			this.rbNormal.Text = "Normal";
			this.toolTip1.SetToolTip(this.rbNormal, "0-30 kms");
			this.rbNormal.UseVisualStyleBackColor = true;
			this.rbNormal.CheckedChanged += new System.EventHandler(this.RbNormalCheckedChanged);
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label16.Location = new System.Drawing.Point(113, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(6, 40);
			this.label16.TabIndex = 27;
			// 
			// cbCobrar
			// 
			this.cbCobrar.Location = new System.Drawing.Point(16, 19);
			this.cbCobrar.Name = "cbCobrar";
			this.cbCobrar.Size = new System.Drawing.Size(90, 24);
			this.cbCobrar.TabIndex = 1;
			this.cbCobrar.Text = "No Factura";
			this.cbCobrar.UseVisualStyleBackColor = true;
			// 
			// dgUsuarios
			// 
			this.dgUsuarios.AllowUserToAddRows = false;
			this.dgUsuarios.AllowUserToResizeRows = false;
			this.dgUsuarios.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.USUARIO,
									this.TELEFONO,
									this.DOMICILIO,
									this.COLONIA,
									this.COMENTARIO});
			this.dgUsuarios.Location = new System.Drawing.Point(540, 47);
			this.dgUsuarios.Name = "dgUsuarios";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgUsuarios.RowHeadersVisible = false;
			this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgUsuarios.Size = new System.Drawing.Size(305, 276);
			this.dgUsuarios.TabIndex = 12;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// USUARIO
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.USUARIO.DefaultCellStyle = dataGridViewCellStyle2;
			this.USUARIO.HeaderText = "USUARIO";
			this.USUARIO.Name = "USUARIO";
			this.USUARIO.ReadOnly = true;
			// 
			// TELEFONO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TELEFONO.DefaultCellStyle = dataGridViewCellStyle3;
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			// 
			// DOMICILIO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DOMICILIO.DefaultCellStyle = dataGridViewCellStyle4;
			this.DOMICILIO.HeaderText = "DOMICILIO";
			this.DOMICILIO.Name = "DOMICILIO";
			this.DOMICILIO.ReadOnly = true;
			// 
			// COLONIA
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COLONIA.DefaultCellStyle = dataGridViewCellStyle5;
			this.COLONIA.HeaderText = "COLONIA";
			this.COLONIA.Name = "COLONIA";
			this.COLONIA.ReadOnly = true;
			// 
			// COMENTARIO
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COMENTARIO.DefaultCellStyle = dataGridViewCellStyle6;
			this.COMENTARIO.HeaderText = "COMENTARIO";
			this.COMENTARIO.Name = "COMENTARIO";
			this.COMENTARIO.ReadOnly = true;
			// 
			// cmdEliminarUsuario
			// 
			this.cmdEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarUsuario.Image")));
			this.cmdEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdEliminarUsuario.Location = new System.Drawing.Point(659, 7);
			this.cmdEliminarUsuario.Name = "cmdEliminarUsuario";
			this.cmdEliminarUsuario.Size = new System.Drawing.Size(75, 34);
			this.cmdEliminarUsuario.TabIndex = 13;
			this.cmdEliminarUsuario.Text = "Eliminar";
			this.cmdEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdEliminarUsuario.UseVisualStyleBackColor = true;
			this.cmdEliminarUsuario.Click += new System.EventHandler(this.CmdEliminarUsuarioClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormRutasExtras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 331);
			this.Controls.Add(this.cmdEliminarUsuario);
			this.Controls.Add(this.dgUsuarios);
			this.Controls.Add(this.gbCriterios);
			this.Controls.Add(this.cbDomiciliada);
			this.Controls.Add(this.gbDatosPrinc);
			this.Controls.Add(this.gbDatosDom);
			this.Controls.Add(this.cmdAgregar);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRutasExtras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Viajes";
			this.Load += new System.EventHandler(this.FormRutasExtrasLoad);
			this.gbDatosDom.ResumeLayout(false);
			this.gbDatosDom.PerformLayout();
			this.gbDatosPrinc.ResumeLayout(false);
			this.gbDatosPrinc.PerformLayout();
			this.gbCriterios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.DataGridView dgUsuarios;
		private System.Windows.Forms.Button cmdEliminarUsuario;
		private System.Windows.Forms.Button cmdAgregarUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn COLONIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOMICILIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSubNombre;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.CheckBox cbForanea;
		private System.Windows.Forms.CheckBox cbVelada;
		private System.Windows.Forms.CheckBox cbEntrada;
		private System.Windows.Forms.CheckBox cbSalida;
		private System.Windows.Forms.TextBox txtHora;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.RadioButton rbLarga;
		private System.Windows.Forms.RadioButton rbExtLarga;
		private System.Windows.Forms.RadioButton rbPendiente;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox cbDomiciliada;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox gbDatosPrinc;
		private System.Windows.Forms.Label lblSentido;
		private System.Windows.Forms.Label lblTurno;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.CheckBox cbCobrar;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.GroupBox gbCriterios;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.RadioButton rbMediana;
		private System.Windows.Forms.RadioButton rbNormal;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox gbDatosDom;
		private System.Windows.Forms.TextBox txtAutoriza;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Button cmdAgregar;
	}
}
