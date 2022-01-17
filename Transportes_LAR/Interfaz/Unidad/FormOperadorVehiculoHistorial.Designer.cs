namespace Transportes_LAR.Interfaz.Unidad
{
	partial class FormOperadorVehiculoHistorial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperadorVehiculoHistorial));
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label44 = new System.Windows.Forms.Label();
			this.dgvHistorialOV = new System.Windows.Forms.DataGridView();
			this.DATAIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataIDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataApP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataApM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOV)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox9
			// 
			this.groupBox9.BackColor = System.Drawing.Color.White;
			this.groupBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox9.BackgroundImage")));
			this.groupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox9.Controls.Add(this.txtNombre);
			this.groupBox9.Controls.Add(this.label44);
			this.groupBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox9.Location = new System.Drawing.Point(12, 12);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(223, 42);
			this.groupBox9.TabIndex = 1;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Filtro Busqueda Avanzada";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(42, 16);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(171, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.Location = new System.Drawing.Point(7, 19);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(37, 14);
			this.label44.TabIndex = 6;
			this.label44.Text = "Alias:";
			// 
			// dgvHistorialOV
			// 
			this.dgvHistorialOV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvHistorialOV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvHistorialOV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvHistorialOV.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dgvHistorialOV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvHistorialOV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorialOV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.DATAIDO,
									this.dataIDV,
									this.dataFecha,
									this.dataHora,
									this.dataNombre,
									this.dataApP,
									this.dataApM,
									this.dataTipo,
									this.dataNumero,
									this.dataNSerie,
									this.dataDescripcion});
			this.dgvHistorialOV.Location = new System.Drawing.Point(12, 66);
			this.dgvHistorialOV.Name = "dgvHistorialOV";
			this.dgvHistorialOV.ReadOnly = true;
			this.dgvHistorialOV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistorialOV.Size = new System.Drawing.Size(1022, 527);
			this.dgvHistorialOV.TabIndex = 2;
			// 
			// DATAIDO
			// 
			this.DATAIDO.DataPropertyName = "ido";
			this.DATAIDO.HeaderText = "ID Operador";
			this.DATAIDO.Name = "DATAIDO";
			this.DATAIDO.ReadOnly = true;
			this.DATAIDO.Visible = false;
			// 
			// dataIDV
			// 
			this.dataIDV.DataPropertyName = "idv";
			this.dataIDV.HeaderText = "ID Vehiculo";
			this.dataIDV.Name = "dataIDV";
			this.dataIDV.ReadOnly = true;
			this.dataIDV.Visible = false;
			// 
			// dataFecha
			// 
			this.dataFecha.DataPropertyName = "fecha";
			this.dataFecha.HeaderText = "Fecha de Reporte";
			this.dataFecha.Name = "dataFecha";
			this.dataFecha.ReadOnly = true;
			this.dataFecha.Width = 108;
			// 
			// dataHora
			// 
			this.dataHora.DataPropertyName = "hora";
			this.dataHora.HeaderText = "Hora de Reporte";
			this.dataHora.Name = "dataHora";
			this.dataHora.ReadOnly = true;
			this.dataHora.Width = 102;
			// 
			// dataNombre
			// 
			this.dataNombre.DataPropertyName = "nombre";
			this.dataNombre.HeaderText = "Nombre de Operador";
			this.dataNombre.Name = "dataNombre";
			this.dataNombre.ReadOnly = true;
			this.dataNombre.Width = 120;
			// 
			// dataApP
			// 
			this.dataApP.DataPropertyName = "app";
			this.dataApP.HeaderText = "Apellido Paterno";
			this.dataApP.Name = "dataApP";
			this.dataApP.ReadOnly = true;
			// 
			// dataApM
			// 
			this.dataApM.DataPropertyName = "apm";
			this.dataApM.HeaderText = "Apellido Materno";
			this.dataApM.Name = "dataApM";
			this.dataApM.ReadOnly = true;
			this.dataApM.Width = 102;
			// 
			// dataTipo
			// 
			this.dataTipo.DataPropertyName = "tv";
			this.dataTipo.HeaderText = "Tipo de Unidad";
			this.dataTipo.Name = "dataTipo";
			this.dataTipo.ReadOnly = true;
			this.dataTipo.Width = 96;
			// 
			// dataNumero
			// 
			this.dataNumero.DataPropertyName = "nv";
			this.dataNumero.HeaderText = "Numero de Unidad";
			this.dataNumero.Name = "dataNumero";
			this.dataNumero.ReadOnly = true;
			this.dataNumero.Width = 111;
			// 
			// dataNSerie
			// 
			this.dataNSerie.DataPropertyName = "ns";
			this.dataNSerie.HeaderText = "Numero Serie Vehiculo";
			this.dataNSerie.Name = "dataNSerie";
			this.dataNSerie.ReadOnly = true;
			this.dataNSerie.Width = 128;
			// 
			// dataDescripcion
			// 
			this.dataDescripcion.DataPropertyName = "descripcion";
			this.dataDescripcion.HeaderText = "Descripción de Reporte";
			this.dataDescripcion.Name = "dataDescripcion";
			this.dataDescripcion.ReadOnly = true;
			this.dataDescripcion.Width = 97;
			// 
			// FormOperadorVehiculoHistorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1046, 605);
			this.Controls.Add(this.dgvHistorialOV);
			this.Controls.Add(this.groupBox9);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOperadorVehiculoHistorial";
			this.Text = "Transportes LAR - OperadorVehiculoHistorial";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOperadorVehiculoHistorialFormClosing);
			this.Load += new System.EventHandler(this.FormOperadorVehiculoHistorialLoad);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOV)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgvHistorialOV;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNSerie;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNumero;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataApM;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataApP;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataHora;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataIDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATAIDO;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.GroupBox groupBox9;
	}
}
