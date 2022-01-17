/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 02/08/2014
 * Hora: 01:56 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Ruta
{
	partial class FormProgramacion
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID_RUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SENTIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtSubNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbSalida = new System.Windows.Forms.CheckBox();
			this.cbEntrada = new System.Windows.Forms.CheckBox();
			this.txtHora = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblSentido = new System.Windows.Forms.Label();
			this.lblHora = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.lblDestino = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_RUTA,
									this.EMPRESA,
									this.NOMBRE,
									this.FECHA,
									this.TURNO,
									this.SENTIDO,
									this.HORA});
			this.dataGridView1.Location = new System.Drawing.Point(288, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(634, 323);
			this.dataGridView1.TabIndex = 0;
			// 
			// ID_RUTA
			// 
			this.ID_RUTA.HeaderText = "ID";
			this.ID_RUTA.Name = "ID_RUTA";
			this.ID_RUTA.ReadOnly = true;
			this.ID_RUTA.Visible = false;
			// 
			// EMPRESA
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EMPRESA.DefaultCellStyle = dataGridViewCellStyle2;
			this.EMPRESA.HeaderText = "EMPRESA";
			this.EMPRESA.Name = "EMPRESA";
			this.EMPRESA.ReadOnly = true;
			// 
			// NOMBRE
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle3;
			this.NOMBRE.HeaderText = "NOMBRE";
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			// 
			// FECHA
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle4;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// TURNO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TURNO.DefaultCellStyle = dataGridViewCellStyle5;
			this.TURNO.HeaderText = "TURNO";
			this.TURNO.Name = "TURNO";
			this.TURNO.ReadOnly = true;
			// 
			// SENTIDO
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SENTIDO.DefaultCellStyle = dataGridViewCellStyle6;
			this.SENTIDO.HeaderText = "TIPO";
			this.SENTIDO.Name = "SENTIDO";
			this.SENTIDO.ReadOnly = true;
			// 
			// HORA
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HORA.DefaultCellStyle = dataGridViewCellStyle7;
			this.HORA.HeaderText = "HORA";
			this.HORA.Name = "HORA";
			this.HORA.ReadOnly = true;
			// 
			// txtSubNombre
			// 
			this.txtSubNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSubNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubNombre.Location = new System.Drawing.Point(98, 27);
			this.txtSubNombre.Name = "txtSubNombre";
			this.txtSubNombre.Size = new System.Drawing.Size(168, 22);
			this.txtSubNombre.TabIndex = 38;
			this.txtSubNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 53;
			this.label5.Text = "SubNombre:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbSalida
			// 
			this.cbSalida.Checked = true;
			this.cbSalida.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSalida.Location = new System.Drawing.Point(213, 130);
			this.cbSalida.Name = "cbSalida";
			this.cbSalida.Size = new System.Drawing.Size(69, 24);
			this.cbSalida.TabIndex = 43;
			this.cbSalida.Text = "Salida";
			this.cbSalida.UseVisualStyleBackColor = true;
			// 
			// cbEntrada
			// 
			this.cbEntrada.Checked = true;
			this.cbEntrada.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEntrada.Location = new System.Drawing.Point(118, 131);
			this.cbEntrada.Name = "cbEntrada";
			this.cbEntrada.Size = new System.Drawing.Size(73, 24);
			this.cbEntrada.TabIndex = 42;
			this.cbEntrada.Text = "Entrada";
			this.cbEntrada.UseVisualStyleBackColor = true;
			// 
			// txtHora
			// 
			this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHora.Location = new System.Drawing.Point(68, 172);
			this.txtHora.Name = "txtHora";
			this.txtHora.Size = new System.Drawing.Size(69, 20);
			this.txtHora.TabIndex = 44;
			this.txtHora.Text = "00:00";
			this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label15.Location = new System.Drawing.Point(12, 12);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(260, 6);
			this.label15.TabIndex = 52;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label14.Location = new System.Drawing.Point(16, 200);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(256, 6);
			this.label14.TabIndex = 51;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(17, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(255, 6);
			this.label3.TabIndex = 50;
			// 
			// lblSentido
			// 
			this.lblSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSentido.Location = new System.Drawing.Point(23, 131);
			this.lblSentido.Name = "lblSentido";
			this.lblSentido.Size = new System.Drawing.Size(68, 23);
			this.lblSentido.TabIndex = 49;
			this.lblSentido.Text = "Sentido:";
			this.lblSentido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblHora
			// 
			this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.Location = new System.Drawing.Point(13, 170);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(52, 23);
			this.lblHora.TabIndex = 46;
			this.lblHora.Text = "Hora:";
			this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTurno
			// 
			this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurno.Location = new System.Drawing.Point(24, 81);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(68, 23);
			this.lblTurno.TabIndex = 48;
			this.lblTurno.Text = "Turno:";
			this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(98, 82);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(168, 21);
			this.cmbTurno.TabIndex = 40;
			// 
			// lblCantidad
			// 
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(157, 172);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(87, 23);
			this.lblCantidad.TabIndex = 47;
			this.lblCantidad.Text = "Cantidad:";
			this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(243, 172);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(29, 22);
			this.txtCantidad.TabIndex = 45;
			this.txtCantidad.Text = "1";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDestino
			// 
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(98, 54);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(168, 22);
			this.txtDestino.TabIndex = 39;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblDestino
			// 
			this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestino.Location = new System.Drawing.Point(36, 54);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.Size = new System.Drawing.Size(56, 23);
			this.lblDestino.TabIndex = 41;
			this.lblDestino.Text = "Destino:";
			this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(12, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 6);
			this.label1.TabIndex = 54;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 219);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(255, 20);
			this.dateTimePicker1.TabIndex = 55;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(16, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 6);
			this.label2.TabIndex = 56;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(191, 293);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 42);
			this.button1.TabIndex = 57;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker2.Location = new System.Drawing.Point(17, 245);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(255, 20);
			this.dateTimePicker2.TabIndex = 58;
			// 
			// FormProgramacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 347);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSubNombre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbSalida);
			this.Controls.Add(this.cbEntrada);
			this.Controls.Add(this.txtHora);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblSentido);
			this.Controls.Add(this.lblHora);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.cmbTurno);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.lblDestino);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormProgramacion";
			this.Text = "Programacion de rutas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.Label lblTurno;
		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.Label lblSentido;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtHora;
		private System.Windows.Forms.CheckBox cbEntrada;
		private System.Windows.Forms.CheckBox cbSalida;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSubNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SENTIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RUTA;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
