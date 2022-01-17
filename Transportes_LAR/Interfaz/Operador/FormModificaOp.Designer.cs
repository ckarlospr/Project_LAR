/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 18/01/2014
 * Hora: 11:57 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	partial class FormModificaOp
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dgNumeros = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMunicipio = new System.Windows.Forms.TextBox();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbTelefonos = new System.Windows.Forms.GroupBox();
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtNumTelefono = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgNumeros)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.gbTelefonos.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(138, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Operador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgNumeros
			// 
			this.dgNumeros.AllowUserToAddRows = false;
			this.dgNumeros.AllowUserToResizeRows = false;
			this.dgNumeros.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id,
									this.tipo,
									this.numero,
									this.descripcion});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgNumeros.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgNumeros.Location = new System.Drawing.Point(6, 138);
			this.dgNumeros.MultiSelect = false;
			this.dgNumeros.Name = "dgNumeros";
			this.dgNumeros.RowHeadersVisible = false;
			this.dgNumeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgNumeros.Size = new System.Drawing.Size(357, 160);
			this.dgNumeros.TabIndex = 1;
			this.dgNumeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgNumerosCellClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Municipio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Colonia:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Numero:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Calle:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMunicipio.Location = new System.Drawing.Point(81, 22);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(282, 26);
			this.txtMunicipio.TabIndex = 6;
			this.txtMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtColonia
			// 
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(81, 54);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(282, 26);
			this.txtColonia.TabIndex = 7;
			this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(81, 118);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(282, 26);
			this.txtNumero.TabIndex = 9;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCalle
			// 
			this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalle.Location = new System.Drawing.Point(81, 86);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(282, 26);
			this.txtCalle.TabIndex = 8;
			this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNumero);
			this.groupBox1.Controls.Add(this.txtCalle);
			this.groupBox1.Controls.Add(this.txtColonia);
			this.groupBox1.Controls.Add(this.txtMunicipio);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(369, 158);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Domicilio";
			// 
			// gbTelefonos
			// 
			this.gbTelefonos.Controls.Add(this.cmdNuevo);
			this.gbTelefonos.Controls.Add(this.cmdEliminar);
			this.gbTelefonos.Controls.Add(this.cmdAgregar);
			this.gbTelefonos.Controls.Add(this.label8);
			this.gbTelefonos.Controls.Add(this.label7);
			this.gbTelefonos.Controls.Add(this.label6);
			this.gbTelefonos.Controls.Add(this.txtDescripcion);
			this.gbTelefonos.Controls.Add(this.txtNumTelefono);
			this.gbTelefonos.Controls.Add(this.cmbTipo);
			this.gbTelefonos.Controls.Add(this.dgNumeros);
			this.gbTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTelefonos.Location = new System.Drawing.Point(12, 207);
			this.gbTelefonos.Name = "gbTelefonos";
			this.gbTelefonos.Size = new System.Drawing.Size(368, 310);
			this.gbTelefonos.TabIndex = 11;
			this.gbTelefonos.TabStop = false;
			this.gbTelefonos.Text = "Telefonos";
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Location = new System.Drawing.Point(30, 109);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
			this.cmdNuevo.TabIndex = 15;
			this.cmdNuevo.Text = "Nuevo";
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Location = new System.Drawing.Point(262, 109);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
			this.cmdEliminar.TabIndex = 14;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Location = new System.Drawing.Point(150, 109);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
			this.cmdAgregar.TabIndex = 13;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(30, 81);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Descripción:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(150, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(187, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Numero de telefono";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(30, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tipo";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDescripcion.Location = new System.Drawing.Point(150, 83);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(187, 20);
			this.txtDescripcion.TabIndex = 4;
			this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNumTelefono
			// 
			this.txtNumTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumTelefono.Location = new System.Drawing.Point(150, 57);
			this.txtNumTelefono.Name = "txtNumTelefono";
			this.txtNumTelefono.Size = new System.Drawing.Size(187, 20);
			this.txtNumTelefono.TabIndex = 3;
			this.txtNumTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"FIJO",
									"CELULAR",
									"LAR"});
			this.cmbTipo.Location = new System.Drawing.Point(30, 57);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(104, 21);
			this.cmbTipo.TabIndex = 2;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(286, 519);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(94, 34);
			this.cmdGuardar.TabIndex = 16;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// tipo
			// 
			this.tipo.HeaderText = "TIPO";
			this.tipo.Name = "tipo";
			this.tipo.ReadOnly = true;
			// 
			// numero
			// 
			this.numero.HeaderText = "NUMERO";
			this.numero.Name = "numero";
			this.numero.ReadOnly = true;
			// 
			// descripcion
			// 
			this.descripcion.HeaderText = "DESCRIPCIÓN";
			this.descripcion.Name = "descripcion";
			this.descripcion.ReadOnly = true;
			// 
			// FormModificaOp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 557);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.gbTelefonos);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormModificaOp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificación";
			this.Load += new System.EventHandler(this.FormModificaOpLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgNumeros)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbTelefonos.ResumeLayout(false);
			this.gbTelefonos.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdNuevo;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TextBox txtMunicipio;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtNumTelefono;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.DataGridView dgNumeros;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.GroupBox gbTelefonos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
