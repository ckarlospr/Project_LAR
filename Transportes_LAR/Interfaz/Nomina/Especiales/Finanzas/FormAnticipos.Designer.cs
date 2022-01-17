/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 15/08/2013
 * Time: 01:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	partial class FormAnticipos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.cmdValidar = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmdModificar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
									this.ID_ANT,
									this.FECHA,
									this.CANT,
									this.NUMERO,
									this.VAL,
									this.USUARIO,
									this.ID_U,
									this.FORMA,
									this.Comentario});
			this.dgDatos.Location = new System.Drawing.Point(12, 51);
			this.dgDatos.MultiSelect = false;
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(614, 183);
			this.dgDatos.TabIndex = 0;
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
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(74, 16);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(82, 20);
			this.txtTotal.TabIndex = 1;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Location = new System.Drawing.Point(95, 42);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
			this.cmdAceptar.TabIndex = 3;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// cmdValidar
			// 
			this.cmdValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdValidar.Location = new System.Drawing.Point(14, 42);
			this.cmdValidar.Name = "cmdValidar";
			this.cmdValidar.Size = new System.Drawing.Size(75, 23);
			this.cmdValidar.TabIndex = 4;
			this.cmdValidar.Text = "Validar";
			this.cmdValidar.UseVisualStyleBackColor = true;
			this.cmdValidar.Click += new System.EventHandler(this.CmdValidarClick);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(614, 39);
			this.lblTitulo.TabIndex = 5;
			this.lblTitulo.Text = "Pagos en efectivo";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cmdValidar);
			this.groupBox1.Controls.Add(this.cmdAceptar);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtTotal);
			this.groupBox1.Location = new System.Drawing.Point(440, 240);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(185, 77);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(23, 19);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(100, 20);
			this.dtpFecha.TabIndex = 7;
			// 
			// cmdModificar
			// 
			this.cmdModificar.Location = new System.Drawing.Point(23, 45);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(100, 23);
			this.cmdModificar.TabIndex = 8;
			this.cmdModificar.Text = "Modificar";
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdModificar);
			this.groupBox2.Controls.Add(this.dtpFecha);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 77);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Modificación";
			// 
			// FormAnticipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 329);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.dgDatos);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAnticipos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pagos anticipados";
			this.Load += new System.EventHandler(this.FormAnticiposLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button cmdModificar;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn FORMA;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_U;
		private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn VAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_ANT;
		private System.Windows.Forms.DataGridView dgDatos;
	}
}
