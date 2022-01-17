/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 10/11/2015
 * Time: 9:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormOrdenFactura
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenFactura));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFacturar = new System.Windows.Forms.Button();
			this.label56 = new System.Windows.Forms.Label();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZONSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuOrden = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.razónSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.porCantUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSalir = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dgFactura = new System.Windows.Forms.DataGridView();
			this.ID_RES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cant1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON_SOCIAL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONTRIBUYENTE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ORDEN_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FORMA_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.MenuOrden.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFacturar
			// 
			this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
			this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFacturar.Location = new System.Drawing.Point(241, 359);
			this.btnFacturar.Name = "btnFacturar";
			this.btnFacturar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnFacturar.Size = new System.Drawing.Size(130, 41);
			this.btnFacturar.TabIndex = 3;
			this.btnFacturar.Text = "Facturar";
			this.btnFacturar.UseVisualStyleBackColor = true;
			this.btnFacturar.Click += new System.EventHandler(this.BtnFacturarClick);
			// 
			// label56
			// 
			this.label56.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label56.Location = new System.Drawing.Point(4, 193);
			this.label56.Name = "label56";
			this.label56.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label56.Size = new System.Drawing.Size(1076, 6);
			this.label56.TabIndex = 139;
			this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
									this.ID_RE,
									this.dataGridViewTextBoxColumn17,
									this.CLIENTE,
									this.dataGridViewTextBoxColumn19,
									this.Column26,
									this.dataGridViewTextBoxColumn20,
									this.dataGridViewTextBoxColumn21,
									this.RAZONSOCIAL});
			this.dgDatos.ContextMenuStrip = this.MenuOrden;
			this.dgDatos.Location = new System.Drawing.Point(23, 12);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(1028, 165);
			this.dgDatos.TabIndex = 1;
			// 
			// ID_RE
			// 
			this.ID_RE.FillWeight = 60F;
			this.ID_RE.HeaderText = "ID_RE";
			this.ID_RE.Name = "ID_RE";
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.FillWeight = 80F;
			this.dataGridViewTextBoxColumn17.HeaderText = "FECHA";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			// 
			// CLIENTE
			// 
			this.CLIENTE.FillWeight = 80F;
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			// 
			// dataGridViewTextBoxColumn19
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn19.FillWeight = 150F;
			this.dataGridViewTextBoxColumn19.HeaderText = "DESTINO";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			// 
			// Column26
			// 
			this.Column26.FillWeight = 50F;
			this.Column26.HeaderText = "CANT";
			this.Column26.Name = "Column26";
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.FillWeight = 80F;
			this.dataGridViewTextBoxColumn20.HeaderText = "VEHÍCULO";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			// 
			// dataGridViewTextBoxColumn21
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn21.FillWeight = 80F;
			this.dataGridViewTextBoxColumn21.HeaderText = "IMPORTE";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			// 
			// RAZONSOCIAL
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.RAZONSOCIAL.DefaultCellStyle = dataGridViewCellStyle4;
			this.RAZONSOCIAL.FillWeight = 150F;
			this.RAZONSOCIAL.HeaderText = "RAZON SOCIAL";
			this.RAZONSOCIAL.Name = "RAZONSOCIAL";
			// 
			// MenuOrden
			// 
			this.MenuOrden.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.razónSocialToolStripMenuItem,
									this.porCantUnidadesToolStripMenuItem});
			this.MenuOrden.Name = "MenuOrden";
			this.MenuOrden.Size = new System.Drawing.Size(173, 48);
			// 
			// razónSocialToolStripMenuItem
			// 
			this.razónSocialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("razónSocialToolStripMenuItem.Image")));
			this.razónSocialToolStripMenuItem.Name = "razónSocialToolStripMenuItem";
			this.razónSocialToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.razónSocialToolStripMenuItem.Text = "Mixta";
			this.razónSocialToolStripMenuItem.Click += new System.EventHandler(this.RazónSocialToolStripMenuItemClick);
			// 
			// porCantUnidadesToolStripMenuItem
			// 
			this.porCantUnidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porCantUnidadesToolStripMenuItem.Image")));
			this.porCantUnidadesToolStripMenuItem.Name = "porCantUnidadesToolStripMenuItem";
			this.porCantUnidadesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.porCantUnidadesToolStripMenuItem.Text = "Por Cant Unidades";
			this.porCantUnidadesToolStripMenuItem.Click += new System.EventHandler(this.PorCantUnidadesToolStripMenuItemClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.Location = new System.Drawing.Point(440, 359);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSalir.Size = new System.Drawing.Size(130, 41);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(623, 359);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(130, 41);
			this.button1.TabIndex = 5;
			this.button1.Text = "Nueva Razon Social";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dgFactura
			// 
			this.dgFactura.AllowUserToAddRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_RES,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn4,
									this.VEHICULO,
									this.cant1,
									this.dataGridViewTextBoxColumn6,
									this.IVA,
									this.TOTAL,
									this.RAZON_SOCIAL1,
									this.ID_RFC,
									this.CONTRIBUYENTE1,
									this.ID_C,
									this.COMENTARIO,
									this.ORDEN_COMPRA,
									this.FORMA_F});
			this.dgFactura.Location = new System.Drawing.Point(5, 202);
			this.dgFactura.MultiSelect = false;
			this.dgFactura.Name = "dgFactura";
			this.dgFactura.RowHeadersVisible = false;
			this.dgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgFactura.Size = new System.Drawing.Size(1075, 141);
			this.dgFactura.TabIndex = 2;
			this.dgFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgFacturaCellValueChanged);
			this.dgFactura.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgFacturaEditingControlShowing);
			// 
			// ID_RES
			// 
			this.ID_RES.HeaderText = "ID_RES";
			this.ID_RES.Name = "ID_RES";
			this.ID_RES.ReadOnly = true;
			this.ID_RES.Width = 70;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "FECHAS";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 80;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "CLIENTE";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// VEHICULO
			// 
			this.VEHICULO.HeaderText = "VEHICULO";
			this.VEHICULO.Name = "VEHICULO";
			this.VEHICULO.Width = 80;
			// 
			// cant1
			// 
			this.cant1.HeaderText = "CANT";
			this.cant1.Name = "cant1";
			this.cant1.Width = 40;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "IMPORTE";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 80;
			// 
			// IVA
			// 
			this.IVA.HeaderText = "IVA";
			this.IVA.Name = "IVA";
			this.IVA.ReadOnly = true;
			this.IVA.Width = 80;
			// 
			// TOTAL
			// 
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			this.TOTAL.Width = 85;
			// 
			// RAZON_SOCIAL1
			// 
			this.RAZON_SOCIAL1.HeaderText = "RFC_CLIENTE";
			this.RAZON_SOCIAL1.Name = "RAZON_SOCIAL1";
			this.RAZON_SOCIAL1.Width = 230;
			// 
			// ID_RFC
			// 
			this.ID_RFC.HeaderText = "ID_RFC";
			this.ID_RFC.Name = "ID_RFC";
			this.ID_RFC.Visible = false;
			// 
			// CONTRIBUYENTE1
			// 
			this.CONTRIBUYENTE1.HeaderText = "CONTRIBUYENTE";
			this.CONTRIBUYENTE1.Name = "CONTRIBUYENTE1";
			this.CONTRIBUYENTE1.Width = 125;
			// 
			// ID_C
			// 
			this.ID_C.HeaderText = "ID_C";
			this.ID_C.Name = "ID_C";
			this.ID_C.Visible = false;
			// 
			// COMENTARIO
			// 
			this.COMENTARIO.HeaderText = "COMENTARIO";
			this.COMENTARIO.Name = "COMENTARIO";
			// 
			// ORDEN_COMPRA
			// 
			this.ORDEN_COMPRA.HeaderText = "ORDEN COMPRA";
			this.ORDEN_COMPRA.Name = "ORDEN_COMPRA";
			// 
			// FORMA_F
			// 
			this.FORMA_F.HeaderText = "FORMA_F";
			this.FORMA_F.Name = "FORMA_F";
			this.FORMA_F.Visible = false;
			// 
			// FormOrdenFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 407);
			this.Controls.Add(this.dgFactura);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnFacturar);
			this.Controls.Add(this.label56);
			this.Controls.Add(this.dgDatos);
			this.Controls.Add(this.btnSalir);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1102, 446);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1102, 446);
			this.Name = "FormOrdenFactura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orden Factura";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenFacturaFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenFacturaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.MenuOrden.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZONSOCIAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_C;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RFC;
		private System.Windows.Forms.DataGridViewTextBoxColumn FORMA_F;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN_COMPRA;
		private System.Windows.Forms.DataGridViewTextBoxColumn cant1;
		private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
		private System.Windows.Forms.ToolStripMenuItem porCantUnidadesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem razónSocialToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuOrden;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONTRIBUYENTE1;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RES;
		private System.Windows.Forms.DataGridView dgFactura;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Button btnFacturar;
	}
}
