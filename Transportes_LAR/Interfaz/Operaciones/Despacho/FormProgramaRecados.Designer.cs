/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 22/01/2014
 * Hora: 10:44 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	partial class FormProgramaRecados
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.dgMsj = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MENSAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.gbRepetir = new System.Windows.Forms.GroupBox();
			this.rbAnio = new System.Windows.Forms.RadioButton();
			this.rbMeses = new System.Windows.Forms.RadioButton();
			this.rbDosSem = new System.Windows.Forms.RadioButton();
			this.rbUnico = new System.Windows.Forms.RadioButton();
			this.rbSemanal = new System.Windows.Forms.RadioButton();
			this.rbDias = new System.Windows.Forms.RadioButton();
			this.cbActivar = new System.Windows.Forms.CheckBox();
			this.gbAvisar = new System.Windows.Forms.GroupBox();
			this.gbFecha = new System.Windows.Forms.GroupBox();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.cmdModificar = new System.Windows.Forms.Button();
			this.Agregar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOperadro = new System.Windows.Forms.TextBox();
			this.cbOperador = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgMsj)).BeginInit();
			this.gbRepetir.SuspendLayout();
			this.gbAvisar.SuspendLayout();
			this.gbFecha.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMensaje
			// 
			this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensaje.Location = new System.Drawing.Point(12, 275);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(356, 120);
			this.txtMensaje.TabIndex = 0;
			// 
			// dgMsj
			// 
			this.dgMsj.AllowUserToAddRows = false;
			this.dgMsj.AllowUserToResizeRows = false;
			this.dgMsj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgMsj.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMsj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgMsj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMsj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.MENSAJE,
									this.TIPO,
									this.FECHA_INICIO,
									this.ESTATUS,
									this.Operador});
			this.dgMsj.Location = new System.Drawing.Point(455, 12);
			this.dgMsj.MultiSelect = false;
			this.dgMsj.Name = "dgMsj";
			this.dgMsj.RowHeadersVisible = false;
			this.dgMsj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgMsj.Size = new System.Drawing.Size(540, 383);
			this.dgMsj.TabIndex = 1;
			this.dgMsj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgMsjCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// MENSAJE
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MENSAJE.DefaultCellStyle = dataGridViewCellStyle2;
			this.MENSAJE.HeaderText = "MENSAJE";
			this.MENSAJE.Name = "MENSAJE";
			this.MENSAJE.ReadOnly = true;
			this.MENSAJE.Width = 200;
			// 
			// TIPO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle3;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			// 
			// FECHA_INICIO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA_INICIO.DefaultCellStyle = dataGridViewCellStyle4;
			this.FECHA_INICIO.HeaderText = "FECHA";
			this.FECHA_INICIO.Name = "FECHA_INICIO";
			this.FECHA_INICIO.ReadOnly = true;
			// 
			// ESTATUS
			// 
			this.ESTATUS.HeaderText = "ESTATUS";
			this.ESTATUS.Name = "ESTATUS";
			this.ESTATUS.ReadOnly = true;
			this.ESTATUS.Visible = false;
			// 
			// Operador
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Operador.DefaultCellStyle = dataGridViewCellStyle5;
			this.Operador.HeaderText = "OPERADOR";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(49, 21);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(119, 22);
			this.dtpFecha.TabIndex = 2;
			// 
			// gbRepetir
			// 
			this.gbRepetir.Controls.Add(this.rbAnio);
			this.gbRepetir.Controls.Add(this.rbMeses);
			this.gbRepetir.Controls.Add(this.rbDosSem);
			this.gbRepetir.Controls.Add(this.rbUnico);
			this.gbRepetir.Controls.Add(this.rbSemanal);
			this.gbRepetir.Controls.Add(this.rbDias);
			this.gbRepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRepetir.Location = new System.Drawing.Point(12, 68);
			this.gbRepetir.Name = "gbRepetir";
			this.gbRepetir.Size = new System.Drawing.Size(356, 113);
			this.gbRepetir.TabIndex = 3;
			this.gbRepetir.TabStop = false;
			this.gbRepetir.Text = "Repetir";
			// 
			// rbAnio
			// 
			this.rbAnio.Location = new System.Drawing.Point(183, 81);
			this.rbAnio.Name = "rbAnio";
			this.rbAnio.Size = new System.Drawing.Size(149, 24);
			this.rbAnio.TabIndex = 5;
			this.rbAnio.Text = "Todos los años";
			this.rbAnio.UseVisualStyleBackColor = true;
			this.rbAnio.CheckedChanged += new System.EventHandler(this.RbAnioCheckedChanged);
			// 
			// rbMeses
			// 
			this.rbMeses.Location = new System.Drawing.Point(6, 81);
			this.rbMeses.Name = "rbMeses";
			this.rbMeses.Size = new System.Drawing.Size(149, 24);
			this.rbMeses.TabIndex = 4;
			this.rbMeses.Text = "Todos los meses";
			this.rbMeses.UseVisualStyleBackColor = true;
			this.rbMeses.CheckedChanged += new System.EventHandler(this.RbMesesCheckedChanged);
			// 
			// rbDosSem
			// 
			this.rbDosSem.Location = new System.Drawing.Point(183, 51);
			this.rbDosSem.Name = "rbDosSem";
			this.rbDosSem.Size = new System.Drawing.Size(165, 24);
			this.rbDosSem.TabIndex = 3;
			this.rbDosSem.Text = "Cada dos semanas";
			this.rbDosSem.UseVisualStyleBackColor = true;
			this.rbDosSem.CheckedChanged += new System.EventHandler(this.RbDosSemCheckedChanged);
			// 
			// rbUnico
			// 
			this.rbUnico.Location = new System.Drawing.Point(6, 21);
			this.rbUnico.Name = "rbUnico";
			this.rbUnico.Size = new System.Drawing.Size(104, 24);
			this.rbUnico.TabIndex = 2;
			this.rbUnico.Text = "Unico";
			this.rbUnico.UseVisualStyleBackColor = true;
			this.rbUnico.CheckedChanged += new System.EventHandler(this.RbUnicoCheckedChanged);
			// 
			// rbSemanal
			// 
			this.rbSemanal.Location = new System.Drawing.Point(6, 51);
			this.rbSemanal.Name = "rbSemanal";
			this.rbSemanal.Size = new System.Drawing.Size(163, 24);
			this.rbSemanal.TabIndex = 1;
			this.rbSemanal.Text = "Todas las semanas";
			this.rbSemanal.UseVisualStyleBackColor = true;
			this.rbSemanal.CheckedChanged += new System.EventHandler(this.RbSemanalCheckedChanged);
			// 
			// rbDias
			// 
			this.rbDias.Checked = true;
			this.rbDias.Location = new System.Drawing.Point(183, 21);
			this.rbDias.Name = "rbDias";
			this.rbDias.Size = new System.Drawing.Size(140, 24);
			this.rbDias.TabIndex = 0;
			this.rbDias.TabStop = true;
			this.rbDias.Text = "Todos los dias";
			this.rbDias.UseVisualStyleBackColor = true;
			this.rbDias.CheckedChanged += new System.EventHandler(this.RbDiasCheckedChanged);
			// 
			// cbActivar
			// 
			this.cbActivar.Checked = true;
			this.cbActivar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbActivar.Location = new System.Drawing.Point(27, 19);
			this.cbActivar.Name = "cbActivar";
			this.cbActivar.Size = new System.Drawing.Size(88, 24);
			this.cbActivar.TabIndex = 4;
			this.cbActivar.Text = "Activar";
			this.cbActivar.UseVisualStyleBackColor = true;
			// 
			// gbAvisar
			// 
			this.gbAvisar.Controls.Add(this.cbActivar);
			this.gbAvisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAvisar.Location = new System.Drawing.Point(12, 12);
			this.gbAvisar.Name = "gbAvisar";
			this.gbAvisar.Size = new System.Drawing.Size(127, 50);
			this.gbAvisar.TabIndex = 5;
			this.gbAvisar.TabStop = false;
			this.gbAvisar.Text = "Avisar";
			// 
			// gbFecha
			// 
			this.gbFecha.Controls.Add(this.dtpFecha);
			this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFecha.Location = new System.Drawing.Point(159, 12);
			this.gbFecha.Name = "gbFecha";
			this.gbFecha.Size = new System.Drawing.Size(209, 50);
			this.gbFecha.TabIndex = 6;
			this.gbFecha.TabStop = false;
			this.gbFecha.Text = "Fecha";
			// 
			// lblMensaje
			// 
			this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensaje.Location = new System.Drawing.Point(12, 254);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(100, 20);
			this.lblMensaje.TabIndex = 7;
			this.lblMensaje.Text = "Mensaje:";
			this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cmdModificar
			// 
			this.cmdModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdModificar.Location = new System.Drawing.Point(374, 177);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(75, 49);
			this.cmdModificar.TabIndex = 8;
			this.cmdModificar.Text = "Nuevo";
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// Agregar
			// 
			this.Agregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Agregar.Location = new System.Drawing.Point(374, 279);
			this.Agregar.Name = "Agregar";
			this.Agregar.Size = new System.Drawing.Size(75, 49);
			this.Agregar.TabIndex = 9;
			this.Agregar.Text = "Guardar";
			this.Agregar.UseVisualStyleBackColor = true;
			this.Agregar.Click += new System.EventHandler(this.AgregarClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(374, 79);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(75, 49);
			this.cmdEliminar.TabIndex = 10;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtOperadro);
			this.groupBox1.Controls.Add(this.cbOperador);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 187);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(355, 69);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Aviso a operador";
			// 
			// txtOperadro
			// 
			this.txtOperadro.Enabled = false;
			this.txtOperadro.Location = new System.Drawing.Point(183, 30);
			this.txtOperadro.Name = "txtOperadro";
			this.txtOperadro.Size = new System.Drawing.Size(132, 21);
			this.txtOperadro.TabIndex = 1;
			this.txtOperadro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperadro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadroKeyUp);
			// 
			// cbOperador
			// 
			this.cbOperador.Location = new System.Drawing.Point(51, 29);
			this.cbOperador.Name = "cbOperador";
			this.cbOperador.Size = new System.Drawing.Size(104, 24);
			this.cbOperador.TabIndex = 0;
			this.cbOperador.Text = "Operador";
			this.cbOperador.UseVisualStyleBackColor = true;
			this.cbOperador.CheckedChanged += new System.EventHandler(this.CbOperadorCheckedChanged);
			// 
			// FormProgramaRecados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 404);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.Agregar);
			this.Controls.Add(this.cmdModificar);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.gbFecha);
			this.Controls.Add(this.gbAvisar);
			this.Controls.Add(this.gbRepetir);
			this.Controls.Add(this.dgMsj);
			this.Controls.Add(this.txtMensaje);
			this.MinimumSize = new System.Drawing.Size(1023, 442);
			this.Name = "FormProgramaRecados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Programación";
			this.Load += new System.EventHandler(this.FormProgramaRecadosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgMsj)).EndInit();
			this.gbRepetir.ResumeLayout(false);
			this.gbAvisar.ResumeLayout(false);
			this.gbFecha.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.TextBox txtOperadro;
		private System.Windows.Forms.CheckBox cbOperador;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn MENSAJE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button Agregar;
		private System.Windows.Forms.Button cmdModificar;
		private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.GroupBox gbFecha;
		private System.Windows.Forms.GroupBox gbAvisar;
		private System.Windows.Forms.CheckBox cbActivar;
		private System.Windows.Forms.RadioButton rbDias;
		private System.Windows.Forms.RadioButton rbSemanal;
		private System.Windows.Forms.RadioButton rbUnico;
		private System.Windows.Forms.RadioButton rbDosSem;
		private System.Windows.Forms.RadioButton rbMeses;
		private System.Windows.Forms.RadioButton rbAnio;
		private System.Windows.Forms.GroupBox gbRepetir;
		private System.Windows.Forms.DataGridView dgMsj;
		private System.Windows.Forms.TextBox txtMensaje;
	}
}
