/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 09/10/2015
 * Time: 12:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormConfirmaServicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmaServicio));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCrucesD = new System.Windows.Forms.TextBox();
			this.txtReferenciaD = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtColoniaD = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtCalleD = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtCiudadD = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtReferenciaS = new System.Windows.Forms.TextBox();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCrucesS = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtColoniaS = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCalleS = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCiudadS = new System.Windows.Forms.TextBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.label51 = new System.Windows.Forms.Label();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.label52 = new System.Windows.Forms.Label();
			this.txtContacto = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label53 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblAgregarRazon = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbFactura = new System.Windows.Forms.GroupBox();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.lblAgregarMetodo = new System.Windows.Forms.Label();
			this.txtCuenta = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbMetodo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgMetodosF = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Elimina = new System.Windows.Forms.DataGridViewImageColumn();
			this.label17 = new System.Windows.Forms.Label();
			this.groupBox5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.gbFactura.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMetodosF)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnGuardar.Location = new System.Drawing.Point(354, 409);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 50);
			this.btnGuardar.TabIndex = 14;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.label12);
			this.groupBox5.Controls.Add(this.txtCrucesD);
			this.groupBox5.Controls.Add(this.txtReferenciaD);
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.txtColoniaD);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.txtCalleD);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Controls.Add(this.txtCiudadD);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(12, 254);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox5.Size = new System.Drawing.Size(293, 108);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Domicilio Destino";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(1, 85);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 15);
			this.label11.TabIndex = 35;
			this.label11.Text = "Referencia:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(11, 62);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 15);
			this.label12.TabIndex = 33;
			this.label12.Text = "Cruces:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCrucesD
			// 
			this.txtCrucesD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCrucesD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCrucesD.Location = new System.Drawing.Point(64, 60);
			this.txtCrucesD.Name = "txtCrucesD";
			this.txtCrucesD.Size = new System.Drawing.Size(222, 20);
			this.txtCrucesD.TabIndex = 11;
			this.txtCrucesD.Tag = "";
			// 
			// txtReferenciaD
			// 
			this.txtReferenciaD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferenciaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferenciaD.Location = new System.Drawing.Point(64, 82);
			this.txtReferenciaD.Name = "txtReferenciaD";
			this.txtReferenciaD.Size = new System.Drawing.Size(222, 20);
			this.txtReferenciaD.TabIndex = 12;
			this.txtReferenciaD.Tag = "";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(150, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 15);
			this.label14.TabIndex = 31;
			this.label14.Text = "Colonia:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtColoniaD
			// 
			this.txtColoniaD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColoniaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColoniaD.Location = new System.Drawing.Point(205, 16);
			this.txtColoniaD.Name = "txtColoniaD";
			this.txtColoniaD.Size = new System.Drawing.Size(81, 20);
			this.txtColoniaD.TabIndex = 9;
			this.txtColoniaD.Tag = "";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(11, 39);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(52, 15);
			this.label15.TabIndex = 29;
			this.label15.Text = "Calle:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCalleD
			// 
			this.txtCalleD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCalleD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalleD.Location = new System.Drawing.Point(64, 38);
			this.txtCalleD.Name = "txtCalleD";
			this.txtCalleD.Size = new System.Drawing.Size(222, 20);
			this.txtCalleD.TabIndex = 10;
			this.txtCalleD.Tag = "";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(11, 18);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 15);
			this.label16.TabIndex = 15;
			this.label16.Text = "Ciudad:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCiudadD
			// 
			this.txtCiudadD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCiudadD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCiudadD.Location = new System.Drawing.Point(64, 16);
			this.txtCiudadD.Name = "txtCiudadD";
			this.txtCiudadD.Size = new System.Drawing.Size(72, 20);
			this.txtCiudadD.TabIndex = 8;
			this.txtCiudadD.Tag = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtReferenciaS);
			this.groupBox1.Controls.Add(this.txtRuta);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtCrucesS);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtColoniaS);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtCalleS);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtCiudadS);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(293, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Domicilio de Salida";
			// 
			// txtReferenciaS
			// 
			this.txtReferenciaS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferenciaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferenciaS.Location = new System.Drawing.Point(64, 82);
			this.txtReferenciaS.Name = "txtReferenciaS";
			this.txtReferenciaS.Size = new System.Drawing.Size(222, 20);
			this.txtReferenciaS.TabIndex = 5;
			this.txtReferenciaS.Tag = "";
			// 
			// txtRuta
			// 
			this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(63, 106);
			this.txtRuta.MaxLength = 99999;
			this.txtRuta.Multiline = true;
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(223, 20);
			this.txtRuta.TabIndex = 114;
			this.txtRuta.DoubleClick += new System.EventHandler(this.TxtRutaDoubleClick);
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(27, 104);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(33, 20);
			this.label34.TabIndex = 113;
			this.label34.Text = "Ruta:";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(2, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 15);
			this.label6.TabIndex = 35;
			this.label6.Text = "Referencia:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(11, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 15);
			this.label7.TabIndex = 33;
			this.label7.Text = "Cruces:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCrucesS
			// 
			this.txtCrucesS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCrucesS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCrucesS.Location = new System.Drawing.Point(64, 60);
			this.txtCrucesS.Name = "txtCrucesS";
			this.txtCrucesS.Size = new System.Drawing.Size(222, 20);
			this.txtCrucesS.TabIndex = 4;
			this.txtCrucesS.Tag = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(150, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 15);
			this.label8.TabIndex = 31;
			this.label8.Text = "Colonia:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtColoniaS
			// 
			this.txtColoniaS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColoniaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColoniaS.Location = new System.Drawing.Point(205, 16);
			this.txtColoniaS.Name = "txtColoniaS";
			this.txtColoniaS.Size = new System.Drawing.Size(81, 20);
			this.txtColoniaS.TabIndex = 2;
			this.txtColoniaS.Tag = "";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 15);
			this.label9.TabIndex = 29;
			this.label9.Text = "Calle:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCalleS
			// 
			this.txtCalleS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCalleS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalleS.Location = new System.Drawing.Point(64, 38);
			this.txtCalleS.Name = "txtCalleS";
			this.txtCalleS.Size = new System.Drawing.Size(222, 20);
			this.txtCalleS.TabIndex = 3;
			this.txtCalleS.Tag = "";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 15);
			this.label10.TabIndex = 15;
			this.label10.Text = "Ciudad:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCiudadS
			// 
			this.txtCiudadS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCiudadS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCiudadS.Location = new System.Drawing.Point(64, 16);
			this.txtCiudadS.Name = "txtCiudadS";
			this.txtCiudadS.Size = new System.Drawing.Size(72, 20);
			this.txtCiudadS.TabIndex = 1;
			this.txtCiudadS.Tag = "";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.txtObservaciones);
			this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox11.Location = new System.Drawing.Point(11, 367);
			this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox11.Size = new System.Drawing.Size(293, 127);
			this.groupBox11.TabIndex = 3;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Observaciones del Servicio";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservaciones.Location = new System.Drawing.Point(9, 14);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(276, 108);
			this.txtObservaciones.TabIndex = 13;
			// 
			// label51
			// 
			this.label51.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label51.Location = new System.Drawing.Point(12, 248);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(292, 3);
			this.label51.TabIndex = 86;
			this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.label52);
			this.groupBox16.Controls.Add(this.txtContacto);
			this.groupBox16.Controls.Add(this.txtTelefono);
			this.groupBox16.Controls.Add(this.label53);
			this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox16.Location = new System.Drawing.Point(11, 177);
			this.groupBox16.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox16.Size = new System.Drawing.Size(294, 66);
			this.groupBox16.TabIndex = 1;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Responsable del Servicio";
			// 
			// label52
			// 
			this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label52.Location = new System.Drawing.Point(11, 40);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(52, 15);
			this.label52.TabIndex = 74;
			this.label52.Text = "Teléfono:";
			this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContacto
			// 
			this.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContacto.Location = new System.Drawing.Point(64, 18);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.Size = new System.Drawing.Size(204, 20);
			this.txtContacto.TabIndex = 6;
			this.txtContacto.Tag = "";
			// 
			// txtTelefono
			// 
			this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(64, 40);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(204, 20);
			this.txtTelefono.TabIndex = 7;
			this.txtTelefono.Tag = "";
			// 
			// label53
			// 
			this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label53.Location = new System.Drawing.Point(1, 20);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(62, 15);
			this.label53.TabIndex = 37;
			this.label53.Text = "Contacto:";
			this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(591, 23);
			this.label1.TabIndex = 81;
			this.label1.Text = "Detalles del Servicio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSalir.Location = new System.Drawing.Point(484, 409);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 50);
			this.btnSalir.TabIndex = 93;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// lblAgregarRazon
			// 
			this.lblAgregarRazon.BackColor = System.Drawing.Color.Transparent;
			this.lblAgregarRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAgregarRazon.Image = ((System.Drawing.Image)(resources.GetObject("lblAgregarRazon.Image")));
			this.lblAgregarRazon.Location = new System.Drawing.Point(267, 52);
			this.lblAgregarRazon.Name = "lblAgregarRazon";
			this.lblAgregarRazon.Size = new System.Drawing.Size(23, 17);
			this.lblAgregarRazon.TabIndex = 97;
			this.lblAgregarRazon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblAgregarRazon.Click += new System.EventHandler(this.LblAgregarRazonClick);
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRazonSocial.Location = new System.Drawing.Point(77, 50);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(189, 20);
			this.txtRazonSocial.TabIndex = 96;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 15);
			this.label2.TabIndex = 36;
			this.label2.Text = "Razon Social:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpFechaFactura
			// 
			this.dtpFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaFactura.Location = new System.Drawing.Point(154, 25);
			this.dtpFechaFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFechaFactura.Name = "dtpFechaFactura";
			this.dtpFechaFactura.Size = new System.Drawing.Size(80, 20);
			this.dtpFechaFactura.TabIndex = 98;
			this.dtpFechaFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(71, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 15);
			this.label3.TabIndex = 100;
			this.label3.Text = "Fecha Factura:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// gbFactura
			// 
			this.gbFactura.Controls.Add(this.txtMonto);
			this.gbFactura.Controls.Add(this.label13);
			this.gbFactura.Controls.Add(this.lblAgregarMetodo);
			this.gbFactura.Controls.Add(this.txtCuenta);
			this.gbFactura.Controls.Add(this.label5);
			this.gbFactura.Controls.Add(this.cbMetodo);
			this.gbFactura.Controls.Add(this.label4);
			this.gbFactura.Controls.Add(this.dgMetodosF);
			this.gbFactura.Controls.Add(this.txtRazonSocial);
			this.gbFactura.Controls.Add(this.label2);
			this.gbFactura.Controls.Add(this.dtpFechaFactura);
			this.gbFactura.Controls.Add(this.lblAgregarRazon);
			this.gbFactura.Controls.Add(this.label3);
			this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFactura.Location = new System.Drawing.Point(310, 42);
			this.gbFactura.Margin = new System.Windows.Forms.Padding(2);
			this.gbFactura.Name = "gbFactura";
			this.gbFactura.Padding = new System.Windows.Forms.Padding(2);
			this.gbFactura.Size = new System.Drawing.Size(293, 320);
			this.gbFactura.TabIndex = 101;
			this.gbFactura.TabStop = false;
			this.gbFactura.Text = "Facturación";
			// 
			// txtMonto
			// 
			this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMonto.Location = new System.Drawing.Point(53, 161);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(181, 20);
			this.txtMonto.TabIndex = 107;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(9, 163);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 15);
			this.label13.TabIndex = 108;
			this.label13.Text = "Monto:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAgregarMetodo
			// 
			this.lblAgregarMetodo.BackColor = System.Drawing.Color.Transparent;
			this.lblAgregarMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAgregarMetodo.Image = ((System.Drawing.Image)(resources.GetObject("lblAgregarMetodo.Image")));
			this.lblAgregarMetodo.Location = new System.Drawing.Point(240, 137);
			this.lblAgregarMetodo.Name = "lblAgregarMetodo";
			this.lblAgregarMetodo.Size = new System.Drawing.Size(41, 38);
			this.lblAgregarMetodo.TabIndex = 106;
			this.lblAgregarMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblAgregarMetodo.Click += new System.EventHandler(this.LblAgregarMetodoClick);
			// 
			// txtCuenta
			// 
			this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCuenta.Enabled = false;
			this.txtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuenta.Location = new System.Drawing.Point(53, 135);
			this.txtCuenta.Name = "txtCuenta";
			this.txtCuenta.Size = new System.Drawing.Size(181, 20);
			this.txtCuenta.TabIndex = 104;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 15);
			this.label5.TabIndex = 105;
			this.label5.Text = "Cuenta:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbMetodo
			// 
			this.cbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMetodo.FormattingEnabled = true;
			this.cbMetodo.Items.AddRange(new object[] {
									"Efectivo",
									"Cheque",
									"Transferencia",
									"Tarjetas de crédito",
									"Monederos electrónicos",
									"Dinero electrónico",
									"Tarjetas digitales",
									"Vales de despensa",
									"Bienes",
									"Servicio",
									"Por cuenta de tercero",
									"Dación en pago",
									"Pago por subrogación",
									"Pago por consignación",
									"Condonación",
									"Cancelación",
									"Compensación",
									"“NA”",
									"Otros"});
			this.cbMetodo.Location = new System.Drawing.Point(9, 109);
			this.cbMetodo.Name = "cbMetodo";
			this.cbMetodo.Size = new System.Drawing.Size(225, 21);
			this.cbMetodo.TabIndex = 103;
			this.cbMetodo.SelectedIndexChanged += new System.EventHandler(this.CbMetodoSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(276, 15);
			this.label4.TabIndex = 102;
			this.label4.Text = "Métodos";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgMetodosF
			// 
			this.dgMetodosF.AllowUserToAddRows = false;
			this.dgMetodosF.AllowUserToDeleteRows = false;
			this.dgMetodosF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMetodosF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgMetodosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMetodosF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Clave,
									this.Metodo,
									this.Cuenta,
									this.Monto,
									this.Elimina});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgMetodosF.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgMetodosF.Location = new System.Drawing.Point(5, 201);
			this.dgMetodosF.Name = "dgMetodosF";
			this.dgMetodosF.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMetodosF.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgMetodosF.RowHeadersVisible = false;
			this.dgMetodosF.Size = new System.Drawing.Size(276, 111);
			this.dgMetodosF.TabIndex = 101;
			this.dgMetodosF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgMetodosFCellDoubleClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Clave
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Clave.DefaultCellStyle = dataGridViewCellStyle2;
			this.Clave.FillWeight = 45.90687F;
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.ReadOnly = true;
			// 
			// Metodo
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Metodo.DefaultCellStyle = dataGridViewCellStyle3;
			this.Metodo.FillWeight = 125.1336F;
			this.Metodo.HeaderText = "Método";
			this.Metodo.Name = "Metodo";
			this.Metodo.ReadOnly = true;
			// 
			// Cuenta
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Cuenta.DefaultCellStyle = dataGridViewCellStyle4;
			this.Cuenta.FillWeight = 80F;
			this.Cuenta.HeaderText = "Cuenta";
			this.Cuenta.Name = "Cuenta";
			this.Cuenta.ReadOnly = true;
			// 
			// Monto
			// 
			this.Monto.FillWeight = 50F;
			this.Monto.HeaderText = "Monto";
			this.Monto.Name = "Monto";
			this.Monto.ReadOnly = true;
			// 
			// Elimina
			// 
			this.Elimina.FillWeight = 32.13481F;
			this.Elimina.HeaderText = "#";
			this.Elimina.Image = ((System.Drawing.Image)(resources.GetObject("Elimina.Image")));
			this.Elimina.Name = "Elimina";
			this.Elimina.ReadOnly = true;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(312, 465);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(292, 3);
			this.label17.TabIndex = 102;
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormConfirmaServicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 505);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.gbFactura);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox16);
			this.Controls.Add(this.groupBox11);
			this.Controls.Add(this.label51);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(530, 80);
			this.Name = "FormConfirmaServicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Confirma Servicio";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfirmaServicioFormClosing);
			this.Load += new System.EventHandler(this.FormConfirmaServicioLoad);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox16.ResumeLayout(false);
			this.groupBox16.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.gbFactura.ResumeLayout(false);
			this.gbFactura.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMetodosF)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCuenta;
		private System.Windows.Forms.Label lblAgregarMetodo;
		private System.Windows.Forms.ComboBox cbMetodo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewImageColumn Elimina;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Metodo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgMetodosF;
		private System.Windows.Forms.GroupBox gbFactura;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFechaFactura;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.Label lblAgregarRazon;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtContacto;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.TextBox txtCiudadS;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCalleS;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtColoniaS;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtReferenciaS;
		private System.Windows.Forms.TextBox txtCrucesS;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCiudadD;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtCalleD;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtColoniaD;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtReferenciaD;
		private System.Windows.Forms.TextBox txtCrucesD;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnGuardar;
	}
}
