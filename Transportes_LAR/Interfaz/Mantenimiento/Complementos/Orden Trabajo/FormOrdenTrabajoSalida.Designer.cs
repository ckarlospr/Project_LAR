/*
 * Created by SharpDevelop.
 * User: lalo
 * Date: 26/06/2015
 * Time: 01:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormOrdenTrabajoSalida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajoSalida));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbCombustible = new System.Windows.Forms.ComboBox();
			this.txtKilometros = new System.Windows.Forms.TextBox();
			this.timeHoraSalida = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.txtComentarios = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblordent = new System.Windows.Forms.Label();
			this.dataFallas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Tipo_falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.cmbCombustible);
			this.groupBox3.Controls.Add(this.txtKilometros);
			this.groupBox3.Controls.Add(this.timeHoraSalida);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.dtpFechaSalida);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.txtComentarios);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.label25);
			this.groupBox3.Controls.Add(this.label26);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(7, 30);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(403, 142);
			this.groupBox3.TabIndex = 233;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Salida de Vehiculo";
			// 
			// cmbCombustible
			// 
			this.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCombustible.FormattingEnabled = true;
			this.cmbCombustible.Items.AddRange(new object[] {
									"Lleno",
									"vacío"});
			this.cmbCombustible.Location = new System.Drawing.Point(84, 51);
			this.cmbCombustible.Name = "cmbCombustible";
			this.cmbCombustible.Size = new System.Drawing.Size(108, 22);
			this.cmbCombustible.TabIndex = 252;
			// 
			// txtKilometros
			// 
			this.txtKilometros.Location = new System.Drawing.Point(283, 51);
			this.txtKilometros.Name = "txtKilometros";
			this.txtKilometros.Size = new System.Drawing.Size(108, 20);
			this.txtKilometros.TabIndex = 248;
			// 
			// timeHoraSalida
			// 
			this.timeHoraSalida.CustomFormat = "HH:mm";
			this.timeHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraSalida.Location = new System.Drawing.Point(283, 24);
			this.timeHoraSalida.Name = "timeHoraSalida";
			this.timeHoraSalida.ShowUpDown = true;
			this.timeHoraSalida.Size = new System.Drawing.Size(108, 20);
			this.timeHoraSalida.TabIndex = 2;
			this.timeHoraSalida.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(215, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 18);
			this.label5.TabIndex = 250;
			this.label5.Text = "Kilometraje";
			// 
			// dtpFechaSalida
			// 
			this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaSalida.Location = new System.Drawing.Point(84, 24);
			this.dtpFechaSalida.Name = "dtpFechaSalida";
			this.dtpFechaSalida.Size = new System.Drawing.Size(108, 20);
			this.dtpFechaSalida.TabIndex = 1;
			this.dtpFechaSalida.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(7, 53);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 18);
			this.label14.TabIndex = 249;
			this.label14.Text = "Combustible";
			// 
			// txtComentarios
			// 
			this.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtComentarios.Location = new System.Drawing.Point(84, 77);
			this.txtComentarios.Multiline = true;
			this.txtComentarios.Name = "txtComentarios";
			this.txtComentarios.Size = new System.Drawing.Size(307, 52);
			this.txtComentarios.TabIndex = 3;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(6, 79);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(92, 37);
			this.label24.TabIndex = 218;
			this.label24.Text = "Comentarios";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(8, 26);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(97, 18);
			this.label25.TabIndex = 215;
			this.label25.Text = "Fecha Salida";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(215, 26);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(85, 18);
			this.label26.TabIndex = 213;
			this.label26.Text = "Hora Salida";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(78, 183);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(93, 34);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(251, 182);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(94, 34);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// lblordent
			// 
			this.lblordent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblordent.Location = new System.Drawing.Point(7, 4);
			this.lblordent.Name = "lblordent";
			this.lblordent.Size = new System.Drawing.Size(403, 23);
			this.lblordent.TabIndex = 238;
			this.lblordent.Text = "Orden de Trabajo:";
			// 
			// dataFallas
			// 
			this.dataFallas.AllowUserToAddRows = false;
			this.dataFallas.AllowUserToResizeRows = false;
			this.dataFallas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataFallas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataFallas.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataFallas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Estado,
									this.Tipo_falla,
									this.Origen1,
									this.Descripcion_Falla,
									this.Origen,
									this.Nombre_Taller,
									this.Descripcion_Reparacion});
			this.dataFallas.Location = new System.Drawing.Point(416, 36);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(546, 189);
			this.dataFallas.TabIndex = 251;
			this.dataFallas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFallasCellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			this.ID.Width = 24;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "*";
			this.Estado.Name = "Estado";
			this.Estado.Width = 17;
			// 
			// Tipo_falla
			// 
			this.Tipo_falla.HeaderText = "Falla";
			this.Tipo_falla.Name = "Tipo_falla";
			this.Tipo_falla.Width = 54;
			// 
			// Origen1
			// 
			this.Origen1.HeaderText = "Origen";
			this.Origen1.Name = "Origen1";
			this.Origen1.Width = 63;
			// 
			// Descripcion_Falla
			// 
			this.Descripcion_Falla.HeaderText = "Descripción";
			this.Descripcion_Falla.Name = "Descripcion_Falla";
			this.Descripcion_Falla.Width = 88;
			// 
			// Origen
			// 
			this.Origen.HeaderText = "Tipo Taller";
			this.Origen.Name = "Origen";
			this.Origen.Width = 82;
			// 
			// Nombre_Taller
			// 
			this.Nombre_Taller.HeaderText = "Nombre_Taller";
			this.Nombre_Taller.Name = "Nombre_Taller";
			this.Nombre_Taller.Width = 101;
			// 
			// Descripcion_Reparacion
			// 
			this.Descripcion_Reparacion.HeaderText = "Descripción_Rep.";
			this.Descripcion_Reparacion.Name = "Descripcion_Reparacion";
			this.Descripcion_Reparacion.Width = 117;
			// 
			// FormOrdenTrabajoSalida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(969, 233);
			this.Controls.Add(this.dataFallas);
			this.Controls.Add(this.lblordent);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOrdenTrabajoSalida";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Salida de Vehiculo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenTrabajoSalidaFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenTrabajoSalidaLoad);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbCombustible;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataFallas;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtKilometros;
		private System.Windows.Forms.Label lblordent;
		private System.Windows.Forms.DateTimePicker timeHoraSalida;
		private System.Windows.Forms.DateTimePicker dtpFechaSalida;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtComentarios;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}
