/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 14/02/2015
 * Hora: 12:06 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Lector
{
	partial class FormReader_Select
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReader_Select));
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.cboReaders = new System.Windows.Forms.ComboBox();
			this.lblSelectReader = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSelect
			// 
			this.btnSelect.Enabled = false;
			this.btnSelect.Location = new System.Drawing.Point(12, 81);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(325, 23);
			this.btnSelect.TabIndex = 21;
			this.btnSelect.Text = "Selecciona";
			this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 52);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(325, 23);
			this.btnRefresh.TabIndex = 20;
			this.btnRefresh.Text = "Refrescar";
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// cboReaders
			// 
			this.cboReaders.Font = new System.Drawing.Font("Tahoma", 8F);
			this.cboReaders.Location = new System.Drawing.Point(12, 25);
			this.cboReaders.Name = "cboReaders";
			this.cboReaders.Size = new System.Drawing.Size(325, 21);
			this.cboReaders.TabIndex = 19;
			// 
			// lblSelectReader
			// 
			this.lblSelectReader.Location = new System.Drawing.Point(12, 9);
			this.lblSelectReader.Name = "lblSelectReader";
			this.lblSelectReader.Size = new System.Drawing.Size(266, 13);
			this.lblSelectReader.TabIndex = 18;
			this.lblSelectReader.Text = "Selecciona Lector";
			// 
			// FormReader_Select
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 117);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.cboReaders);
			this.Controls.Add(this.lblSelectReader);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReader_Select";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR  -Selección de Dispositivo";
			this.Load += new System.EventHandler(this.FormReader_SelectLoad);
			this.ResumeLayout(false);
		}
		internal System.Windows.Forms.Label lblSelectReader;
		internal System.Windows.Forms.ComboBox cboReaders;
		internal System.Windows.Forms.Button btnRefresh;
		internal System.Windows.Forms.Button btnSelect;
	}
}
