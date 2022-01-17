/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 03/09/2014
 * Hora: 01:39 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes.Cardex
{
	partial class FormOtros
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtros));
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.cmdGuarda = new System.Windows.Forms.Button();
			this.rbDormida = new System.Windows.Forms.RadioButton();
			this.rbTaller = new System.Windows.Forms.RadioButton();
			this.rbIncapacidad = new System.Windows.Forms.RadioButton();
			this.rbPermiso = new System.Windows.Forms.RadioButton();
			this.rbChoque = new System.Windows.Forms.RadioButton();
			this.rbExceso = new System.Windows.Forms.RadioButton();
			this.rbNoAutorizado = new System.Windows.Forms.RadioButton();
			this.rbCombustible = new System.Windows.Forms.RadioButton();
			this.lblOperaciones = new System.Windows.Forms.Label();
			this.lblOtros = new System.Windows.Forms.Label();
			this.lblComentario = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.dgOperador = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rbVentas = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).BeginInit();
			this.SuspendLayout();
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Location = new System.Drawing.Point(12, 12);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(134, 20);
			this.txtOperador.TabIndex = 0;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			// 
			// txtComentario
			// 
			this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Location = new System.Drawing.Point(165, 212);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(292, 76);
			this.txtComentario.TabIndex = 1;
			// 
			// cmdGuarda
			// 
			this.cmdGuarda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuarda.Location = new System.Drawing.Point(382, 294);
			this.cmdGuarda.Name = "cmdGuarda";
			this.cmdGuarda.Size = new System.Drawing.Size(75, 23);
			this.cmdGuarda.TabIndex = 2;
			this.cmdGuarda.Text = "Guardar";
			this.cmdGuarda.UseVisualStyleBackColor = true;
			this.cmdGuarda.Click += new System.EventHandler(this.CmdGuardaClick);
			// 
			// rbDormida
			// 
			this.rbDormida.Location = new System.Drawing.Point(165, 61);
			this.rbDormida.Name = "rbDormida";
			this.rbDormida.Size = new System.Drawing.Size(137, 17);
			this.rbDormida.TabIndex = 3;
			this.rbDormida.Text = "Dormida";
			this.rbDormida.UseVisualStyleBackColor = true;
			this.rbDormida.CheckedChanged += new System.EventHandler(this.RbDormidaCheckedChanged);
			// 
			// rbTaller
			// 
			this.rbTaller.Location = new System.Drawing.Point(165, 84);
			this.rbTaller.Name = "rbTaller";
			this.rbTaller.Size = new System.Drawing.Size(137, 17);
			this.rbTaller.TabIndex = 4;
			this.rbTaller.Text = "Taller";
			this.rbTaller.UseVisualStyleBackColor = true;
			this.rbTaller.CheckedChanged += new System.EventHandler(this.RbTallerCheckedChanged);
			// 
			// rbIncapacidad
			// 
			this.rbIncapacidad.Location = new System.Drawing.Point(165, 130);
			this.rbIncapacidad.Name = "rbIncapacidad";
			this.rbIncapacidad.Size = new System.Drawing.Size(137, 17);
			this.rbIncapacidad.TabIndex = 7;
			this.rbIncapacidad.Text = "Incapacidad";
			this.rbIncapacidad.UseVisualStyleBackColor = true;
			this.rbIncapacidad.CheckedChanged += new System.EventHandler(this.RbIncapacidadCheckedChanged);
			// 
			// rbPermiso
			// 
			this.rbPermiso.Location = new System.Drawing.Point(165, 107);
			this.rbPermiso.Name = "rbPermiso";
			this.rbPermiso.Size = new System.Drawing.Size(137, 17);
			this.rbPermiso.TabIndex = 8;
			this.rbPermiso.Text = "Permiso";
			this.rbPermiso.UseVisualStyleBackColor = true;
			this.rbPermiso.CheckedChanged += new System.EventHandler(this.RbPermisoCheckedChanged);
			// 
			// rbChoque
			// 
			this.rbChoque.Location = new System.Drawing.Point(320, 130);
			this.rbChoque.Name = "rbChoque";
			this.rbChoque.Size = new System.Drawing.Size(137, 17);
			this.rbChoque.TabIndex = 9;
			this.rbChoque.Text = "Choque";
			this.rbChoque.UseVisualStyleBackColor = true;
			this.rbChoque.CheckedChanged += new System.EventHandler(this.RbChoqueCheckedChanged);
			// 
			// rbExceso
			// 
			this.rbExceso.Location = new System.Drawing.Point(320, 107);
			this.rbExceso.Name = "rbExceso";
			this.rbExceso.Size = new System.Drawing.Size(149, 17);
			this.rbExceso.TabIndex = 10;
			this.rbExceso.Text = "Exceso de velocidad";
			this.rbExceso.UseVisualStyleBackColor = true;
			this.rbExceso.CheckedChanged += new System.EventHandler(this.RbExcesoCheckedChanged);
			// 
			// rbNoAutorizado
			// 
			this.rbNoAutorizado.Location = new System.Drawing.Point(320, 84);
			this.rbNoAutorizado.Name = "rbNoAutorizado";
			this.rbNoAutorizado.Size = new System.Drawing.Size(137, 17);
			this.rbNoAutorizado.TabIndex = 11;
			this.rbNoAutorizado.Text = "Mov. No Autorizado";
			this.rbNoAutorizado.UseVisualStyleBackColor = true;
			this.rbNoAutorizado.CheckedChanged += new System.EventHandler(this.RbNoAutorizadoCheckedChanged);
			// 
			// rbCombustible
			// 
			this.rbCombustible.Checked = true;
			this.rbCombustible.Location = new System.Drawing.Point(320, 61);
			this.rbCombustible.Name = "rbCombustible";
			this.rbCombustible.Size = new System.Drawing.Size(137, 17);
			this.rbCombustible.TabIndex = 12;
			this.rbCombustible.TabStop = true;
			this.rbCombustible.Text = "Combustible";
			this.rbCombustible.UseVisualStyleBackColor = true;
			this.rbCombustible.CheckedChanged += new System.EventHandler(this.RbCombustibleCheckedChanged);
			// 
			// lblOperaciones
			// 
			this.lblOperaciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblOperaciones.Location = new System.Drawing.Point(165, 41);
			this.lblOperaciones.Name = "lblOperaciones";
			this.lblOperaciones.Size = new System.Drawing.Size(137, 17);
			this.lblOperaciones.TabIndex = 13;
			this.lblOperaciones.Text = "Operaciones";
			this.lblOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOtros
			// 
			this.lblOtros.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblOtros.Location = new System.Drawing.Point(320, 41);
			this.lblOtros.Name = "lblOtros";
			this.lblOtros.Size = new System.Drawing.Size(137, 17);
			this.lblOtros.TabIndex = 14;
			this.lblOtros.Text = "Otros";
			this.lblOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblComentario
			// 
			this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblComentario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblComentario.Location = new System.Drawing.Point(165, 192);
			this.lblComentario.Name = "lblComentario";
			this.lblComentario.Size = new System.Drawing.Size(292, 17);
			this.lblComentario.TabIndex = 15;
			this.lblComentario.Text = "Comentario";
			this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(180, 12);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(109, 20);
			this.dtpFecha.TabIndex = 16;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Turno",
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(330, 12);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(121, 21);
			this.cmbTurno.TabIndex = 17;
			// 
			// dgOperador
			// 
			this.dgOperador.AllowUserToAddRows = false;
			this.dgOperador.AllowUserToResizeRows = false;
			this.dgOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgOperador.BackgroundColor = System.Drawing.Color.White;
			this.dgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.OPERADOR});
			this.dgOperador.Location = new System.Drawing.Point(12, 41);
			this.dgOperador.MultiSelect = false;
			this.dgOperador.Name = "dgOperador";
			this.dgOperador.RowHeadersVisible = false;
			this.dgOperador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgOperador.Size = new System.Drawing.Size(134, 276);
			this.dgOperador.TabIndex = 18;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle1;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			// 
			// rbVentas
			// 
			this.rbVentas.Location = new System.Drawing.Point(320, 153);
			this.rbVentas.Name = "rbVentas";
			this.rbVentas.Size = new System.Drawing.Size(137, 17);
			this.rbVentas.TabIndex = 19;
			this.rbVentas.Text = "Ventas";
			this.rbVentas.UseVisualStyleBackColor = true;
			this.rbVentas.CheckedChanged += new System.EventHandler(this.RbVentasCheckedChanged);
			// 
			// FormOtros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 329);
			this.Controls.Add(this.rbVentas);
			this.Controls.Add(this.dgOperador);
			this.Controls.Add(this.cmbTurno);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblComentario);
			this.Controls.Add(this.lblOtros);
			this.Controls.Add(this.lblOperaciones);
			this.Controls.Add(this.rbCombustible);
			this.Controls.Add(this.rbNoAutorizado);
			this.Controls.Add(this.rbExceso);
			this.Controls.Add(this.rbChoque);
			this.Controls.Add(this.rbPermiso);
			this.Controls.Add(this.rbIncapacidad);
			this.Controls.Add(this.rbTaller);
			this.Controls.Add(this.rbDormida);
			this.Controls.Add(this.cmdGuarda);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.txtOperador);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOtros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Cardex operador";
			this.Load += new System.EventHandler(this.FormOtrosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbVentas;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgOperador;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblComentario;
		private System.Windows.Forms.Label lblOtros;
		private System.Windows.Forms.Label lblOperaciones;
		private System.Windows.Forms.RadioButton rbCombustible;
		private System.Windows.Forms.RadioButton rbNoAutorizado;
		private System.Windows.Forms.RadioButton rbExceso;
		private System.Windows.Forms.RadioButton rbChoque;
		private System.Windows.Forms.RadioButton rbPermiso;
		private System.Windows.Forms.RadioButton rbIncapacidad;
		private System.Windows.Forms.RadioButton rbTaller;
		private System.Windows.Forms.RadioButton rbDormida;
		private System.Windows.Forms.Button cmdGuarda;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.TextBox txtOperador;
	}
}
