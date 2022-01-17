/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 08/01/2016
 * Hora: 10:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class Anticipos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anticipos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdRegresar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.label43 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdModificar = new System.Windows.Forms.Button();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID_ANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FORMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdRegresar);
			this.groupBox2.Controls.Add(this.cmdEliminar);
			this.groupBox2.Controls.Add(this.label43);
			this.groupBox2.Controls.Add(this.cmbTipo);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cmdModificar);
			this.groupBox2.Controls.Add(this.dtpFecha);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(22, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(439, 77);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Modificación";
			// 
			// cmdRegresar
			// 
			this.cmdRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRegresar.ForeColor = System.Drawing.Color.Blue;
			this.cmdRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdRegresar.Location = new System.Drawing.Point(343, 44);
			this.cmdRegresar.Name = "cmdRegresar";
			this.cmdRegresar.Size = new System.Drawing.Size(90, 29);
			this.cmdRegresar.TabIndex = 87;
			this.cmdRegresar.Text = "Regresar";
			this.cmdRegresar.UseVisualStyleBackColor = true;
			this.cmdRegresar.Click += new System.EventHandler(this.CmdRegresarClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.ForeColor = System.Drawing.Color.Red;
			this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdEliminar.Location = new System.Drawing.Point(343, 9);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(90, 29);
			this.cmdEliminar.TabIndex = 16;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label43.Location = new System.Drawing.Point(12, 20);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(55, 15);
			this.label43.TabIndex = 86;
			this.label43.Text = "Fecha:";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"EFECTIVO",
									"DEPOSITO"});
			this.cmbTipo.Location = new System.Drawing.Point(67, 44);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(140, 21);
			this.cmbTipo.TabIndex = 84;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 15);
			this.label2.TabIndex = 85;
			this.label2.Text = "Tipo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdModificar
			// 
			this.cmdModificar.Image = ((System.Drawing.Image)(resources.GetObject("cmdModificar.Image")));
			this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdModificar.Location = new System.Drawing.Point(232, 20);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(95, 45);
			this.cmdModificar.TabIndex = 8;
			this.cmdModificar.Text = "Modificar";
			this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(69, 18);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(138, 20);
			this.dtpFecha.TabIndex = 7;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(5, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(594, 39);
			this.lblTitulo.TabIndex = 11;
			this.lblTitulo.Text = "Pagos en Efectivo";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_ANT,
									this.FECHA,
									this.CANT,
									this.NUMERO,
									this.VAL,
									this.USUARIO,
									this.ID_U,
									this.FORMA,
									this.Comentario});
			this.dgDatos.Location = new System.Drawing.Point(5, 51);
			this.dgDatos.MultiSelect = false;
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgDatos.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(596, 183);
			this.dgDatos.TabIndex = 10;
			this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellClick);
			// 
			// ID_ANT
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_ANT.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID_ANT.HeaderText = "ID";
			this.ID_ANT.Name = "ID_ANT";
			this.ID_ANT.ReadOnly = true;
			this.ID_ANT.Visible = false;
			this.ID_ANT.Width = 80;
			// 
			// FECHA
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			this.FECHA.Width = 80;
			// 
			// CANT
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CANT.DefaultCellStyle = dataGridViewCellStyle4;
			this.CANT.HeaderText = "$";
			this.CANT.Name = "CANT";
			this.CANT.ReadOnly = true;
			this.CANT.Width = 70;
			// 
			// NUMERO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUMERO.DefaultCellStyle = dataGridViewCellStyle5;
			this.NUMERO.HeaderText = "NUMERO";
			this.NUMERO.Name = "NUMERO";
			this.NUMERO.ReadOnly = true;
			this.NUMERO.Width = 70;
			// 
			// VAL
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VAL.DefaultCellStyle = dataGridViewCellStyle6;
			this.VAL.HeaderText = "V";
			this.VAL.Name = "VAL";
			this.VAL.ReadOnly = true;
			this.VAL.Width = 30;
			// 
			// USUARIO
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.USUARIO.DefaultCellStyle = dataGridViewCellStyle7;
			this.USUARIO.HeaderText = "USUARIO";
			this.USUARIO.Name = "USUARIO";
			this.USUARIO.ReadOnly = true;
			// 
			// ID_U
			// 
			this.ID_U.HeaderText = "ID_U";
			this.ID_U.Name = "ID_U";
			this.ID_U.ReadOnly = true;
			this.ID_U.Visible = false;
			// 
			// FORMA
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FORMA.DefaultCellStyle = dataGridViewCellStyle8;
			this.FORMA.HeaderText = "FORMA";
			this.FORMA.Name = "FORMA";
			this.FORMA.ReadOnly = true;
			this.FORMA.Width = 130;
			// 
			// Comentario
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Comentario.DefaultCellStyle = dataGridViewCellStyle9;
			this.Comentario.HeaderText = "COMENTARIO";
			this.Comentario.Name = "Comentario";
			this.Comentario.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(467, 239);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Total:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(519, 240);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(82, 22);
			this.txtTotal.TabIndex = 14;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.Image")));
			this.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAceptar.Location = new System.Drawing.Point(519, 272);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(82, 39);
			this.cmdAceptar.TabIndex = 3;
			this.cmdAceptar.Text = "Salir";
			this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// Anticipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 319);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.dgDatos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(627, 358);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(627, 358);
			this.Name = "Anticipos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Anticipos";
			this.Load += new System.EventHandler(this.FormAnticiposLoad);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdRegresar;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
		private System.Windows.Forms.DataGridViewTextBoxColumn FORMA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_U;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn VAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_ANT;
		private System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button cmdModificar;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
