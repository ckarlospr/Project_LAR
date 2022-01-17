/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 06/06/2015
 * Hora: 11:06 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Ruta
{
	partial class FormProgramaRutas
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
			this.gbForsac = new System.Windows.Forms.GroupBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dgForsac = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnManiana = new System.Windows.Forms.Button();
			this.btnTarde = new System.Windows.Forms.Button();
			this.dtpTarde = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpManiana = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbForsac.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgForsac)).BeginInit();
			this.SuspendLayout();
			// 
			// gbForsac
			// 
			this.gbForsac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.gbForsac.Controls.Add(this.btnEliminar);
			this.gbForsac.Controls.Add(this.label4);
			this.gbForsac.Controls.Add(this.dgForsac);
			this.gbForsac.Controls.Add(this.btnManiana);
			this.gbForsac.Controls.Add(this.btnTarde);
			this.gbForsac.Controls.Add(this.dtpTarde);
			this.gbForsac.Controls.Add(this.label3);
			this.gbForsac.Controls.Add(this.dtpManiana);
			this.gbForsac.Controls.Add(this.label2);
			this.gbForsac.Controls.Add(this.txtRuta);
			this.gbForsac.Controls.Add(this.label1);
			this.gbForsac.Location = new System.Drawing.Point(14, 12);
			this.gbForsac.Name = "gbForsac";
			this.gbForsac.Size = new System.Drawing.Size(436, 462);
			this.gbForsac.TabIndex = 0;
			this.gbForsac.TabStop = false;
			this.gbForsac.Text = "Especial forsac";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.Location = new System.Drawing.Point(329, 433);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(101, 23);
			this.btnEliminar.TabIndex = 13;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Visible = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(424, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Programado";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dgForsac
			// 
			this.dgForsac.AllowUserToAddRows = false;
			this.dgForsac.AllowUserToResizeRows = false;
			this.dgForsac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgForsac.BackgroundColor = System.Drawing.Color.White;
			this.dgForsac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgForsac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Nombre,
									this.fecha,
									this.Turno,
									this.Sentido});
			this.dgForsac.Location = new System.Drawing.Point(6, 108);
			this.dgForsac.MultiSelect = false;
			this.dgForsac.Name = "dgForsac";
			this.dgForsac.RowHeadersVisible = false;
			this.dgForsac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgForsac.Size = new System.Drawing.Size(425, 317);
			this.dgForsac.TabIndex = 8;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			// 
			// Turno
			// 
			this.Turno.HeaderText = "Turno";
			this.Turno.Name = "Turno";
			this.Turno.ReadOnly = true;
			// 
			// Sentido
			// 
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			// 
			// btnManiana
			// 
			this.btnManiana.Location = new System.Drawing.Point(199, 63);
			this.btnManiana.Name = "btnManiana";
			this.btnManiana.Size = new System.Drawing.Size(101, 23);
			this.btnManiana.TabIndex = 7;
			this.btnManiana.Text = "Agregar";
			this.btnManiana.UseVisualStyleBackColor = true;
			this.btnManiana.Click += new System.EventHandler(this.BtnManianaClick);
			// 
			// btnTarde
			// 
			this.btnTarde.Location = new System.Drawing.Point(329, 63);
			this.btnTarde.Name = "btnTarde";
			this.btnTarde.Size = new System.Drawing.Size(101, 23);
			this.btnTarde.TabIndex = 6;
			this.btnTarde.Text = "Agregar";
			this.btnTarde.UseVisualStyleBackColor = true;
			this.btnTarde.Click += new System.EventHandler(this.BtnTardeClick);
			// 
			// dtpTarde
			// 
			this.dtpTarde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTarde.Location = new System.Drawing.Point(329, 37);
			this.dtpTarde.Name = "dtpTarde";
			this.dtpTarde.Size = new System.Drawing.Size(101, 20);
			this.dtpTarde.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(329, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Entrada tarde";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpManiana
			// 
			this.dtpManiana.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpManiana.Location = new System.Drawing.Point(199, 37);
			this.dtpManiana.Name = "dtpManiana";
			this.dtpManiana.Size = new System.Drawing.Size(101, 20);
			this.dtpManiana.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(199, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Entrada mañana";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtRuta
			// 
			this.txtRuta.Enabled = false;
			this.txtRuta.Location = new System.Drawing.Point(6, 36);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(187, 20);
			this.txtRuta.TabIndex = 1;
			this.txtRuta.Text = "(B) ANGEL LEAÑO";
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// FormProgramaRutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 486);
			this.Controls.Add(this.gbForsac);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProgramaRutas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Programación de Rutas";
			this.Load += new System.EventHandler(this.FormProgramaRutasLoad);
			this.gbForsac.ResumeLayout(false);
			this.gbForsac.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgForsac)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpManiana;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpTarde;
		private System.Windows.Forms.Button btnTarde;
		private System.Windows.Forms.Button btnManiana;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgForsac;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.GroupBox gbForsac;
	}
}
