/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 01/07/2013
 * Time: 01:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormFacturaEsp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturaEsp));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tcDatos = new System.Windows.Forms.TabControl();
			this.tpEspeciales = new System.Windows.Forms.TabPage();
			this.dgEspeciales = new System.Windows.Forms.DataGridView();
			this.cbFacturados = new System.Windows.Forms.CheckBox();
			this.cmdRealizado = new System.Windows.Forms.Button();
			this.cmdDatos = new System.Windows.Forms.Button();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcDatos.SuspendLayout();
			this.tpEspeciales.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEspeciales)).BeginInit();
			this.SuspendLayout();
			// 
			// tcDatos
			// 
			this.tcDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tcDatos.Controls.Add(this.tpEspeciales);
			this.tcDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcDatos.Location = new System.Drawing.Point(12, 44);
			this.tcDatos.Name = "tcDatos";
			this.tcDatos.SelectedIndex = 0;
			this.tcDatos.Size = new System.Drawing.Size(841, 407);
			this.tcDatos.TabIndex = 0;
			// 
			// tpEspeciales
			// 
			this.tpEspeciales.Controls.Add(this.dgEspeciales);
			this.tpEspeciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpEspeciales.Location = new System.Drawing.Point(4, 22);
			this.tpEspeciales.Name = "tpEspeciales";
			this.tpEspeciales.Padding = new System.Windows.Forms.Padding(3);
			this.tpEspeciales.Size = new System.Drawing.Size(833, 381);
			this.tpEspeciales.TabIndex = 0;
			this.tpEspeciales.Text = "Especiales";
			this.tpEspeciales.UseVisualStyleBackColor = true;
			// 
			// dgEspeciales
			// 
			this.dgEspeciales.AllowUserToAddRows = false;
			this.dgEspeciales.AllowUserToResizeRows = false;
			this.dgEspeciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgEspeciales.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEspeciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEspeciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_RE,
									this.RAZON,
									this.DESTINO,
									this.CLIENTE,
									this.RESPONSABLE,
									this.Fecha,
									this.CANTIDAD,
									this.TIPO,
									this.FACTURADO});
			this.dgEspeciales.Location = new System.Drawing.Point(6, 6);
			this.dgEspeciales.MultiSelect = false;
			this.dgEspeciales.Name = "dgEspeciales";
			this.dgEspeciales.RowHeadersVisible = false;
			this.dgEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEspeciales.Size = new System.Drawing.Size(821, 369);
			this.dgEspeciales.TabIndex = 0;
			this.dgEspeciales.DoubleClick += new System.EventHandler(this.DgEspecialesDoubleClick);
			// 
			// cbFacturados
			// 
			this.cbFacturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFacturados.Location = new System.Drawing.Point(12, 12);
			this.cbFacturados.Name = "cbFacturados";
			this.cbFacturados.Size = new System.Drawing.Size(118, 24);
			this.cbFacturados.TabIndex = 1;
			this.cbFacturados.Text = "Facturados";
			this.cbFacturados.UseVisualStyleBackColor = true;
			this.cbFacturados.CheckedChanged += new System.EventHandler(this.CbFacturadosCheckedChanged);
			// 
			// cmdRealizado
			// 
			this.cmdRealizado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRealizado.Image = ((System.Drawing.Image)(resources.GetObject("cmdRealizado.Image")));
			this.cmdRealizado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdRealizado.Location = new System.Drawing.Point(743, 12);
			this.cmdRealizado.Name = "cmdRealizado";
			this.cmdRealizado.Size = new System.Drawing.Size(109, 39);
			this.cmdRealizado.TabIndex = 2;
			this.cmdRealizado.Text = "Realizado";
			this.cmdRealizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdRealizado.UseVisualStyleBackColor = true;
			this.cmdRealizado.Click += new System.EventHandler(this.CmdRealizadoClick);
			// 
			// cmdDatos
			// 
			this.cmdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDatos.Image = ((System.Drawing.Image)(resources.GetObject("cmdDatos.Image")));
			this.cmdDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdDatos.Location = new System.Drawing.Point(397, 12);
			this.cmdDatos.Name = "cmdDatos";
			this.cmdDatos.Size = new System.Drawing.Size(109, 39);
			this.cmdDatos.TabIndex = 4;
			this.cmdDatos.Text = "        Datos";
			this.cmdDatos.UseVisualStyleBackColor = true;
			this.cmdDatos.Click += new System.EventHandler(this.CmdDatosClick);
			// 
			// ID_RE
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_RE.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID_RE.HeaderText = "ID";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Width = 40;
			// 
			// RAZON
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RAZON.DefaultCellStyle = dataGridViewCellStyle3;
			this.RAZON.HeaderText = "RAZON SOCIAL";
			this.RAZON.Name = "RAZON";
			this.RAZON.ReadOnly = true;
			this.RAZON.Width = 150;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle4;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			this.DESTINO.Width = 150;
			// 
			// CLIENTE
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle5;
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			this.CLIENTE.Width = 120;
			// 
			// RESPONSABLE
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RESPONSABLE.DefaultCellStyle = dataGridViewCellStyle6;
			this.RESPONSABLE.HeaderText = "RESPONSABLE";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			this.RESPONSABLE.Width = 120;
			// 
			// Fecha
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Fecha.DefaultCellStyle = dataGridViewCellStyle7;
			this.Fecha.HeaderText = "FECHA";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Width = 80;
			// 
			// CANTIDAD
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle8;
			this.CANTIDAD.HeaderText = "CANT.";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			this.CANTIDAD.Width = 60;
			// 
			// TIPO
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle9;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			this.TIPO.Width = 70;
			// 
			// FACTURADO
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FACTURADO.DefaultCellStyle = dataGridViewCellStyle10;
			this.FACTURADO.HeaderText = "FACT";
			this.FACTURADO.Name = "FACTURADO";
			this.FACTURADO.ReadOnly = true;
			this.FACTURADO.Visible = false;
			this.FACTURADO.Width = 40;
			// 
			// FormFacturaEsp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 463);
			this.Controls.Add(this.cmdDatos);
			this.Controls.Add(this.cmdRealizado);
			this.Controls.Add(this.cbFacturados);
			this.Controls.Add(this.tcDatos);
			this.Name = "FormFacturaEsp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Facturación";
			this.Load += new System.EventHandler(this.FormFacturaEspLoad);
			this.tcDatos.ResumeLayout(false);
			this.tpEspeciales.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgEspeciales)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.Button cmdDatos;
		private System.Windows.Forms.Button cmdRealizado;
		private System.Windows.Forms.CheckBox cbFacturados;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridView dgEspeciales;
		private System.Windows.Forms.TabPage tpEspeciales;
		private System.Windows.Forms.TabControl tcDatos;
	}
}
