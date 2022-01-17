/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 06/07/2013
 * Time: 12:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Cliente
{
	partial class FormHistorialEmpresa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialEmpresa));
			this.dgEmpresa = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.gbTipo = new System.Windows.Forms.GroupBox();
			this.rbIncidente = new System.Windows.Forms.RadioButton();
			this.rbFOperador = new System.Windows.Forms.RadioButton();
			this.rbFCoordina = new System.Windows.Forms.RadioButton();
			this.rbFaltaUnidad = new System.Windows.Forms.RadioButton();
			this.rbFUnidad = new System.Windows.Forms.RadioButton();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.lblComentario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgEmpresa)).BeginInit();
			this.gbTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgEmpresa
			// 
			this.dgEmpresa.AllowUserToAddRows = false;
			this.dgEmpresa.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.EMPRESA});
			this.dgEmpresa.Location = new System.Drawing.Point(12, 62);
			this.dgEmpresa.Name = "dgEmpresa";
			this.dgEmpresa.RowHeadersVisible = false;
			this.dgEmpresa.Size = new System.Drawing.Size(227, 307);
			this.dgEmpresa.TabIndex = 0;
			this.dgEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEmpresaCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 70;
			// 
			// EMPRESA
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EMPRESA.DefaultCellStyle = dataGridViewCellStyle2;
			this.EMPRESA.HeaderText = "EMPRESA";
			this.EMPRESA.Name = "EMPRESA";
			this.EMPRESA.ReadOnly = true;
			this.EMPRESA.Width = 200;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(227, 23);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Empresa";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpresa.Location = new System.Drawing.Point(12, 35);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(227, 21);
			this.txtEmpresa.TabIndex = 2;
			this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEmpresaKeyUp);
			// 
			// txtComentario
			// 
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(258, 230);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(284, 96);
			this.txtComentario.TabIndex = 3;
			// 
			// gbTipo
			// 
			this.gbTipo.Controls.Add(this.rbIncidente);
			this.gbTipo.Controls.Add(this.rbFOperador);
			this.gbTipo.Controls.Add(this.rbFCoordina);
			this.gbTipo.Controls.Add(this.rbFaltaUnidad);
			this.gbTipo.Controls.Add(this.rbFUnidad);
			this.gbTipo.Enabled = false;
			this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTipo.Location = new System.Drawing.Point(258, 18);
			this.gbTipo.Name = "gbTipo";
			this.gbTipo.Size = new System.Drawing.Size(283, 189);
			this.gbTipo.TabIndex = 9;
			this.gbTipo.TabStop = false;
			this.gbTipo.Text = "TIPO";
			// 
			// rbIncidente
			// 
			this.rbIncidente.Location = new System.Drawing.Point(49, 147);
			this.rbIncidente.Name = "rbIncidente";
			this.rbIncidente.Size = new System.Drawing.Size(189, 24);
			this.rbIncidente.TabIndex = 5;
			this.rbIncidente.TabStop = true;
			this.rbIncidente.Text = "Incidente";
			this.rbIncidente.UseVisualStyleBackColor = true;
			this.rbIncidente.CheckedChanged += new System.EventHandler(this.RbIncidenteCheckedChanged);
			// 
			// rbFOperador
			// 
			this.rbFOperador.Location = new System.Drawing.Point(49, 57);
			this.rbFOperador.Name = "rbFOperador";
			this.rbFOperador.Size = new System.Drawing.Size(189, 24);
			this.rbFOperador.TabIndex = 4;
			this.rbFOperador.TabStop = true;
			this.rbFOperador.Text = "Falla de operador";
			this.rbFOperador.UseVisualStyleBackColor = true;
			this.rbFOperador.CheckedChanged += new System.EventHandler(this.RbFOperadorCheckedChanged);
			// 
			// rbFCoordina
			// 
			this.rbFCoordina.Location = new System.Drawing.Point(49, 87);
			this.rbFCoordina.Name = "rbFCoordina";
			this.rbFCoordina.Size = new System.Drawing.Size(189, 24);
			this.rbFCoordina.TabIndex = 3;
			this.rbFCoordina.TabStop = true;
			this.rbFCoordina.Text = "Falla de coordinación";
			this.rbFCoordina.UseVisualStyleBackColor = true;
			this.rbFCoordina.CheckedChanged += new System.EventHandler(this.RbFCoordinaCheckedChanged);
			// 
			// rbFaltaUnidad
			// 
			this.rbFaltaUnidad.Location = new System.Drawing.Point(49, 117);
			this.rbFaltaUnidad.Name = "rbFaltaUnidad";
			this.rbFaltaUnidad.Size = new System.Drawing.Size(189, 24);
			this.rbFaltaUnidad.TabIndex = 2;
			this.rbFaltaUnidad.TabStop = true;
			this.rbFaltaUnidad.Text = "Falta de unidad";
			this.rbFaltaUnidad.UseVisualStyleBackColor = true;
			this.rbFaltaUnidad.CheckedChanged += new System.EventHandler(this.RbFaltaUnidadCheckedChanged);
			// 
			// rbFUnidad
			// 
			this.rbFUnidad.Location = new System.Drawing.Point(49, 26);
			this.rbFUnidad.Name = "rbFUnidad";
			this.rbFUnidad.Size = new System.Drawing.Size(189, 24);
			this.rbFUnidad.TabIndex = 0;
			this.rbFUnidad.TabStop = true;
			this.rbFUnidad.Text = "Falla de unidad";
			this.rbFUnidad.UseVisualStyleBackColor = true;
			this.rbFUnidad.CheckedChanged += new System.EventHandler(this.RbFUnidadCheckedChanged);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.Location = new System.Drawing.Point(448, 332);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(94, 37);
			this.cmdGuardar.TabIndex = 10;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// lblComentario
			// 
			this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComentario.Location = new System.Drawing.Point(258, 210);
			this.lblComentario.Name = "lblComentario";
			this.lblComentario.Size = new System.Drawing.Size(100, 17);
			this.lblComentario.TabIndex = 11;
			this.lblComentario.Text = "Comentarios:";
			this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormHistorialEmpresa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 381);
			this.Controls.Add(this.lblComentario);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.gbTipo);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.txtEmpresa);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.dgEmpresa);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(570, 419);
			this.Name = "FormHistorialEmpresa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reporte por empresa";
			this.Load += new System.EventHandler(this.FormHistorialEmpresaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgEmpresa)).EndInit();
			this.gbTipo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbFUnidad;
		private System.Windows.Forms.RadioButton rbFaltaUnidad;
		private System.Windows.Forms.RadioButton rbFCoordina;
		private System.Windows.Forms.RadioButton rbFOperador;
		private System.Windows.Forms.RadioButton rbIncidente;
		private System.Windows.Forms.Label lblComentario;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.GroupBox gbTipo;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgEmpresa;
	}
}
