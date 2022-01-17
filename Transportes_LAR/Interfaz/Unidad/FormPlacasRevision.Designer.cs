/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 22/04/2017
 * Time: 11:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Unidad
{
	partial class FormPlacasRevision
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlacasRevision));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtVehiculo = new System.Windows.Forms.TextBox();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cbTodos = new System.Windows.Forms.CheckBox();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpIncio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PLACAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PLACAF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPOPLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PLACAREVISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PLACAESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REVISADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_MD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtVehiculo
			// 
			this.txtVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVehiculo.Location = new System.Drawing.Point(76, 17);
			this.txtVehiculo.Name = "txtVehiculo";
			this.txtVehiculo.Size = new System.Drawing.Size(147, 20);
			this.txtVehiculo.TabIndex = 65;
			// 
			// bntBuscar
			// 
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntBuscar.Location = new System.Drawing.Point(744, 6);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(95, 45);
			this.bntBuscar.TabIndex = 60;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 23);
			this.label4.TabIndex = 63;
			this.label4.Text = "Vehiculo:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbTodos
			// 
			this.cbTodos.AutoSize = true;
			this.cbTodos.Location = new System.Drawing.Point(637, 20);
			this.cbTodos.Name = "cbTodos";
			this.cbTodos.Size = new System.Drawing.Size(56, 17);
			this.cbTodos.TabIndex = 0;
			this.cbTodos.Text = "Todos";
			this.cbTodos.UseVisualStyleBackColor = true;
			this.cbTodos.CheckedChanged += new System.EventHandler(this.CbTodosCheckedChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Enabled = false;
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(527, 17);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 3;
			// 
			// dtpIncio
			// 
			this.dtpIncio.Enabled = false;
			this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIncio.Location = new System.Drawing.Point(396, 16);
			this.dtpIncio.Name = "dtpIncio";
			this.dtpIncio.Size = new System.Drawing.Size(100, 20);
			this.dtpIncio.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(496, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "al";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(305, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 15);
			this.label6.TabIndex = 18;
			this.label6.Text = "Revisión Del";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_A,
									this.ID_V,
									this.VEHICULO,
									this.OPERADORA,
									this.PLACAE,
									this.PLACAF,
									this.OPERADOR,
									this.FECHA,
									this.TIPOPLACA,
									this.PLACAREVISION,
									this.PLACAESTATUS,
									this.REVISADO,
									this.ID_MD});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgDatos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgDatos.Location = new System.Drawing.Point(4, 56);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgDatos.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(835, 337);
			this.dgDatos.TabIndex = 60;
			this.dgDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellDoubleClick);
			// 
			// ID_A
			// 
			this.ID_A.HeaderText = "ID_A";
			this.ID_A.Name = "ID_A";
			this.ID_A.ReadOnly = true;
			this.ID_A.Visible = false;
			// 
			// ID_V
			// 
			this.ID_V.HeaderText = "ID_V";
			this.ID_V.Name = "ID_V";
			this.ID_V.ReadOnly = true;
			this.ID_V.Visible = false;
			// 
			// VEHICULO
			// 
			this.VEHICULO.FillWeight = 70F;
			this.VEHICULO.HeaderText = "VEHICULO";
			this.VEHICULO.Name = "VEHICULO";
			this.VEHICULO.ReadOnly = true;
			// 
			// OPERADORA
			// 
			this.OPERADORA.FillWeight = 71.63F;
			this.OPERADORA.HeaderText = "OPERADOR ACTUAL";
			this.OPERADORA.Name = "OPERADORA";
			this.OPERADORA.ReadOnly = true;
			// 
			// PLACAE
			// 
			this.PLACAE.FillWeight = 71.63F;
			this.PLACAE.HeaderText = "PLACA ACTUAL E";
			this.PLACAE.Name = "PLACAE";
			this.PLACAE.ReadOnly = true;
			// 
			// PLACAF
			// 
			this.PLACAF.FillWeight = 71.63F;
			this.PLACAF.HeaderText = "PLACA ACTUAL F";
			this.PLACAF.Name = "PLACAF";
			this.PLACAF.ReadOnly = true;
			// 
			// OPERADOR
			// 
			this.OPERADOR.FillWeight = 71.63F;
			this.OPERADOR.HeaderText = "OPERADOR REVISO";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			// 
			// FECHA
			// 
			this.FECHA.FillWeight = 71.63F;
			this.FECHA.HeaderText = "FECHA REVISION";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// TIPOPLACA
			// 
			this.TIPOPLACA.FillWeight = 71.63F;
			this.TIPOPLACA.HeaderText = "TIPO PLACA REVISION";
			this.TIPOPLACA.Name = "TIPOPLACA";
			this.TIPOPLACA.ReadOnly = true;
			// 
			// PLACAREVISION
			// 
			this.PLACAREVISION.FillWeight = 71.63F;
			this.PLACAREVISION.HeaderText = "PLACA REVISION";
			this.PLACAREVISION.Name = "PLACAREVISION";
			this.PLACAREVISION.ReadOnly = true;
			// 
			// PLACAESTATUS
			// 
			this.PLACAESTATUS.FillWeight = 71.63F;
			this.PLACAESTATUS.HeaderText = "PLACA ESTATUS";
			this.PLACAESTATUS.Name = "PLACAESTATUS";
			this.PLACAESTATUS.ReadOnly = true;
			// 
			// REVISADO
			// 
			this.REVISADO.FillWeight = 50F;
			this.REVISADO.HeaderText = "REVISADO";
			this.REVISADO.Name = "REVISADO";
			this.REVISADO.ReadOnly = true;
			// 
			// ID_MD
			// 
			this.ID_MD.HeaderText = "ID_MD";
			this.ID_MD.Name = "ID_MD";
			this.ID_MD.ReadOnly = true;
			this.ID_MD.Visible = false;
			// 
			// FormPlacasRevision
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 396);
			this.Controls.Add(this.txtVehiculo);
			this.Controls.Add(this.dgDatos);
			this.Controls.Add(this.bntBuscar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpIncio);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbTodos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(860, 435);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(860, 435);
			this.Name = "FormPlacasRevision";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Revisión de Placas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlacasRevisionFormClosing);
			this.Load += new System.EventHandler(this.FormPlacasRevisionLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPlacasRevisionKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MD;
		private System.Windows.Forms.DataGridViewTextBoxColumn REVISADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_V;
		private System.Windows.Forms.DataGridViewTextBoxColumn PLACAESTATUS;
		private System.Windows.Forms.DataGridViewTextBoxColumn PLACAREVISION;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPLACA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn PLACAF;
		private System.Windows.Forms.DataGridViewTextBoxColumn PLACAE;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADORA;
		private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_A;
		public System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIncio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.CheckBox cbTodos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.TextBox txtVehiculo;
	}
}
