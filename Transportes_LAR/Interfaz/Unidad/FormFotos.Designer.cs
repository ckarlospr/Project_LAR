/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 27/07/2012
 * Time: 11:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Unidad
{
	partial class FormFotos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFotos));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button2 = new System.Windows.Forms.Button();
			this.panelFoto = new System.Windows.Forms.Panel();
			this.pbFotos = new System.Windows.Forms.PictureBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAgregaDescripcion = new System.Windows.Forms.Button();
			this.panelFoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFotos)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(100, 80);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(106, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Cargar";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.listView1.BackColor = System.Drawing.SystemColors.Menu;
			this.listView1.Location = new System.Drawing.Point(12, 34);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(179, 266);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1ItemSelectionChanged);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(12, 306);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(79, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "Eliminar";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.but);
			// 
			// panelFoto
			// 
			this.panelFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panelFoto.AutoScroll = true;
			this.panelFoto.AutoScrollMargin = new System.Drawing.Size(562, 333);
			this.panelFoto.BackColor = System.Drawing.Color.LightGray;
			this.panelFoto.Controls.Add(this.pbFotos);
			this.panelFoto.Location = new System.Drawing.Point(198, 35);
			this.panelFoto.Name = "panelFoto";
			this.panelFoto.Size = new System.Drawing.Size(536, 381);
			this.panelFoto.TabIndex = 2;
			// 
			// pbFotos
			// 
			this.pbFotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbFotos.BackColor = System.Drawing.SystemColors.Menu;
			this.pbFotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbFotos.Location = new System.Drawing.Point(0, 0);
			this.pbFotos.Name = "pbFotos";
			this.pbFotos.Size = new System.Drawing.Size(536, 381);
			this.pbFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFotos.TabIndex = 0;
			this.pbFotos.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(648, 422);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(86, 27);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(12, 359);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(180, 57);
			this.txtDescripcion.TabIndex = 5;
			this.txtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcionTextChanged);
			this.txtDescripcion.Enter += new System.EventHandler(this.TxtDescripcionEnter);
			this.txtDescripcion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtDescripcionMouseDown);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Descripción:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Lista de Fotografías";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(198, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Visor";
			// 
			// btnAgregaDescripcion
			// 
			this.btnAgregaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgregaDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregaDescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregaDescripcion.Enabled = false;
			this.btnAgregaDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregaDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaDescripcion.Image")));
			this.btnAgregaDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregaDescripcion.Location = new System.Drawing.Point(106, 422);
			this.btnAgregaDescripcion.Name = "btnAgregaDescripcion";
			this.btnAgregaDescripcion.Size = new System.Drawing.Size(85, 27);
			this.btnAgregaDescripcion.TabIndex = 9;
			this.btnAgregaDescripcion.Text = "Agregar";
			this.btnAgregaDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregaDescripcion.UseVisualStyleBackColor = false;
			this.btnAgregaDescripcion.Click += new System.EventHandler(this.BtnAgregaDescripcionClick);
			// 
			// FormFotos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(746, 468);
			this.Controls.Add(this.btnAgregaDescripcion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.panelFoto);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormFotos";
			this.Text = "Transportes LAR - Fotografías del vehículo";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFotosFormClosed);
			this.panelFoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbFotos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAgregaDescripcion;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.PictureBox pbFotos;
		private System.Windows.Forms.Panel panelFoto;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ImageList imageList1;
	}
}
