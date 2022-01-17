/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 14/08/2014
 * Hora: 10:20 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Caja
{
	partial class FormResponsable
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ALIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAp_pat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAp_mat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.rbEmpleado = new System.Windows.Forms.RadioButton();
			this.rbArriaga = new System.Windows.Forms.RadioButton();
			this.rbExterno = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.ALIAS,
									this.TIPO,
									this.NOMBRE,
									this.TELEFONO,
									this.COMENTARIO});
			this.dgDatos.Location = new System.Drawing.Point(12, 160);
			this.dgDatos.MultiSelect = false;
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(724, 367);
			this.dgDatos.TabIndex = 12;
			this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// ALIAS
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ALIAS.DefaultCellStyle = dataGridViewCellStyle2;
			this.ALIAS.HeaderText = "ALIAS";
			this.ALIAS.Name = "ALIAS";
			this.ALIAS.ReadOnly = true;
			this.ALIAS.Width = 120;
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
			// NOMBRE
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle4;
			this.NOMBRE.HeaderText = "NOMBRE";
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			this.NOMBRE.Width = 200;
			// 
			// TELEFONO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TELEFONO.DefaultCellStyle = dataGridViewCellStyle5;
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			// 
			// COMENTARIO
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COMENTARIO.DefaultCellStyle = dataGridViewCellStyle6;
			this.COMENTARIO.HeaderText = "COMENTARIO";
			this.COMENTARIO.Name = "COMENTARIO";
			this.COMENTARIO.ReadOnly = true;
			this.COMENTARIO.Width = 150;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(193, 12);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(182, 22);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(193, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(374, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido paterno";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtAp_pat
			// 
			this.txtAp_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAp_pat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAp_pat.Location = new System.Drawing.Point(374, 12);
			this.txtAp_pat.Name = "txtAp_pat";
			this.txtAp_pat.Size = new System.Drawing.Size(182, 22);
			this.txtAp_pat.TabIndex = 2;
			this.txtAp_pat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(555, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Apellido materno";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtAp_mat
			// 
			this.txtAp_mat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAp_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAp_mat.Location = new System.Drawing.Point(555, 12);
			this.txtAp_mat.Name = "txtAp_mat";
			this.txtAp_mat.Size = new System.Drawing.Size(182, 22);
			this.txtAp_mat.TabIndex = 3;
			this.txtAp_mat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(182, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Alias";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtAlias
			// 
			this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(12, 12);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(182, 22);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// rbEmpleado
			// 
			this.rbEmpleado.Checked = true;
			this.rbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbEmpleado.Location = new System.Drawing.Point(7, 8);
			this.rbEmpleado.Name = "rbEmpleado";
			this.rbEmpleado.Size = new System.Drawing.Size(85, 17);
			this.rbEmpleado.TabIndex = 5;
			this.rbEmpleado.TabStop = true;
			this.rbEmpleado.Text = "Empleado";
			this.rbEmpleado.UseVisualStyleBackColor = true;
			// 
			// rbArriaga
			// 
			this.rbArriaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbArriaga.Location = new System.Drawing.Point(92, 8);
			this.rbArriaga.Name = "rbArriaga";
			this.rbArriaga.Size = new System.Drawing.Size(72, 17);
			this.rbArriaga.TabIndex = 6;
			this.rbArriaga.Text = "Arriaga";
			this.rbArriaga.UseVisualStyleBackColor = true;
			// 
			// rbExterno
			// 
			this.rbExterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExterno.Location = new System.Drawing.Point(170, 8);
			this.rbExterno.Name = "rbExterno";
			this.rbExterno.Size = new System.Drawing.Size(73, 17);
			this.rbExterno.TabIndex = 7;
			this.rbExterno.Text = "Externo";
			this.rbExterno.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbEmpleado);
			this.groupBox1.Controls.Add(this.rbExterno);
			this.groupBox1.Controls.Add(this.rbArriaga);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 28);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(264, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Teléfono";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtTelefono
			// 
			this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(264, 63);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(182, 22);
			this.txtTelefono.TabIndex = 8;
			this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(445, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(292, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Cometario";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(445, 63);
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(292, 22);
			this.txtComentario.TabIndex = 9;
			this.txtComentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(662, 116);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 38);
			this.cmdGuardar.TabIndex = 10;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdNuevo.Location = new System.Drawing.Point(325, 116);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(75, 38);
			this.cmdNuevo.TabIndex = 11;
			this.cmdNuevo.Text = "Nuevo";
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Location = new System.Drawing.Point(12, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(725, 4);
			this.label7.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label8.Location = new System.Drawing.Point(12, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(725, 4);
			this.label8.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 85);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(246, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Tipo";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormResponsable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 539);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmdNuevo);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAlias);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAp_mat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAp_pat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.dgDatos);
			this.Name = "FormResponsable";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Responsable";
			this.Load += new System.EventHandler(this.FormResponsableLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button cmdNuevo;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbExterno;
		private System.Windows.Forms.RadioButton rbArriaga;
		private System.Windows.Forms.RadioButton rbEmpleado;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ALIAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.TextBox txtAp_mat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAp_pat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataGridView dgDatos;
	}
}
