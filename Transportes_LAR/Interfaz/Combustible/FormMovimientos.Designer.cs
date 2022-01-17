/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 03/11/2016
 * Time: 13:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormMovimientos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimientos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_MOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnValidar = new System.Windows.Forms.Button();
			this.lblProceso = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerar
			// 
			this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
			this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGenerar.Location = new System.Drawing.Point(90, 603);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(75, 30);
			this.btnGenerar.TabIndex = 12;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.BtnGenerarClick);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(10, 603);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(74, 26);
			this.txtCantidad.TabIndex = 11;
			this.txtCantidad.Text = "0";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.Location = new System.Drawing.Point(473, 603);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 30);
			this.btnAgregar.TabIndex = 10;
			this.btnAgregar.Text = "Guardar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Cuatro,
									this.ID_MOVIMIENTO});
			this.dgDatos.Location = new System.Drawing.Point(10, 24);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.Size = new System.Drawing.Size(538, 573);
			this.dgDatos.TabIndex = 9;
			this.dgDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgDatosKeyDown);
			// 
			// Column1
			// 
			this.Column1.FillWeight = 80F;
			this.Column1.HeaderText = "TIPO";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "NOMBRE";
			this.Column2.Name = "Column2";
			this.Column2.Width = 200;
			// 
			// Column3
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column3.FillWeight = 130F;
			this.Column3.HeaderText = "ID";
			this.Column3.Name = "Column3";
			this.Column3.Width = 70;
			// 
			// Cuatro
			// 
			this.Cuatro.HeaderText = "VALIDACION";
			this.Cuatro.Name = "Cuatro";
			this.Cuatro.Width = 95;
			// 
			// ID_MOVIMIENTO
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ID_MOVIMIENTO.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID_MOVIMIENTO.HeaderText = "ID MOV.";
			this.ID_MOVIMIENTO.Name = "ID_MOVIMIENTO";
			this.ID_MOVIMIENTO.Width = 70;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel4.Location = new System.Drawing.Point(3, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(551, 13);
			this.panel4.TabIndex = 105;
			// 
			// btnValidar
			// 
			this.btnValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
			this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnValidar.Location = new System.Drawing.Point(171, 603);
			this.btnValidar.Name = "btnValidar";
			this.btnValidar.Size = new System.Drawing.Size(75, 30);
			this.btnValidar.TabIndex = 106;
			this.btnValidar.Text = "Validar";
			this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValidar.UseVisualStyleBackColor = true;
			this.btnValidar.Click += new System.EventHandler(this.BtnValidarClick);
			// 
			// lblProceso
			// 
			this.lblProceso.Location = new System.Drawing.Point(332, 606);
			this.lblProceso.Name = "lblProceso";
			this.lblProceso.Size = new System.Drawing.Size(100, 23);
			this.lblProceso.TabIndex = 107;
			this.lblProceso.Text = "0/0";
			this.lblProceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormMovimientos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 641);
			this.Controls.Add(this.lblProceso);
			this.Controls.Add(this.btnValidar);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgDatos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(370, 680);
			this.Name = "FormMovimientos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Movimientos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMovimientosFormClosing);
			this.Load += new System.EventHandler(this.FormMovimientosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Label lblProceso;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOVIMIENTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cuatro;
		private System.Windows.Forms.Button btnValidar;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnGenerar;
	}
}
