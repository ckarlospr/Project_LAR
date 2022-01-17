/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 24/09/2013
 * Time: 09:57 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento
{
	partial class FormAlmacen
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Entrada de Artículos", "anadir-mas-icono-6734-48.png");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Salida de Artículos");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Existencias");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
									"Movimientos"}, 0, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Orden de Compra");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Catálogo", "(ninguno)");
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Proveedores");
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Grupos Mecánicos");
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Intervención");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacen));
			this.ltMenu = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pPrincipal = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ltMenu
			// 
			this.ltMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.ltMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ltMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ltMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ltMenu.FullRowSelect = true;
			this.ltMenu.GridLines = true;
			listViewItem1.Checked = true;
			listViewItem1.StateImageIndex = 12;
			listViewItem2.Checked = true;
			listViewItem2.StateImageIndex = 13;
			listViewItem3.Checked = true;
			listViewItem3.StateImageIndex = 3;
			listViewItem4.Checked = true;
			listViewItem4.StateImageIndex = 4;
			listViewItem5.Checked = true;
			listViewItem5.StateImageIndex = 6;
			listViewItem6.StateImageIndex = 0;
			listViewItem6.UseItemStyleForSubItems = false;
			listViewItem7.Checked = true;
			listViewItem7.StateImageIndex = 7;
			listViewItem8.Checked = true;
			listViewItem8.StateImageIndex = 9;
			listViewItem9.Checked = true;
			listViewItem9.StateImageIndex = 11;
			this.ltMenu.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1,
									listViewItem2,
									listViewItem3,
									listViewItem4,
									listViewItem5,
									listViewItem6,
									listViewItem7,
									listViewItem8,
									listViewItem9});
			this.ltMenu.Location = new System.Drawing.Point(0, 12);
			this.ltMenu.MultiSelect = false;
			this.ltMenu.Name = "ltMenu";
			this.ltMenu.Scrollable = false;
			this.ltMenu.Size = new System.Drawing.Size(195, 590);
			this.ltMenu.StateImageList = this.imageList1;
			this.ltMenu.TabIndex = 166;
			this.ltMenu.UseCompatibleStateImageBehavior = false;
			this.ltMenu.View = System.Windows.Forms.View.List;
			this.ltMenu.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LtMenuItemSelectionChanged);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Black;
			this.imageList1.Images.SetKeyName(0, "paquete-de-caja-icono-5182-48.png");
			this.imageList1.Images.SetKeyName(1, "anadir-mas-icono-6734-48.png");
			this.imageList1.Images.SetKeyName(2, "boton-rojo-menos-icono-5393-48.png");
			this.imageList1.Images.SetKeyName(3, "almacen-icono-5695-48.png");
			this.imageList1.Images.SetKeyName(4, "estadisticas-icono-6536-48.png");
			this.imageList1.Images.SetKeyName(5, "escritorio-remoto-icono-4812-32.png");
			this.imageList1.Images.SetKeyName(6, "hoja-de-calculo-excel-invoice-icono-5449-48.png");
			this.imageList1.Images.SetKeyName(7, "anadir-carrito-de-la-tienda-en-linea-de-comercio-electronico-icono-7379-48.png");
			this.imageList1.Images.SetKeyName(8, "escritorio-remoto-icono-4812-32.png");
			this.imageList1.Images.SetKeyName(9, "grupo-de-jabber-icono-8150-48.png");
			this.imageList1.Images.SetKeyName(10, "2.png");
			this.imageList1.Images.SetKeyName(11, "cover.png");
			this.imageList1.Images.SetKeyName(12, "Entrada.png");
			this.imageList1.Images.SetKeyName(13, "Salida.png");
			// 
			// pPrincipal
			// 
			this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pPrincipal.BackColor = System.Drawing.Color.Transparent;
			this.pPrincipal.Location = new System.Drawing.Point(195, 12);
			this.pPrincipal.Name = "pPrincipal";
			this.pPrincipal.Size = new System.Drawing.Size(806, 590);
			this.pPrincipal.TabIndex = 168;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1001, 20);
			this.label1.TabIndex = 165;
			// 
			// FormAlmacen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1001, 598);
			this.Controls.Add(this.pPrincipal);
			this.Controls.Add(this.ltMenu);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAlmacen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Almacén";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAlmacenFormClosing);
			this.Load += new System.EventHandler(this.FormAlmacenLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListView ltMenu;
		private System.Windows.Forms.Panel pPrincipal;
	}
}
