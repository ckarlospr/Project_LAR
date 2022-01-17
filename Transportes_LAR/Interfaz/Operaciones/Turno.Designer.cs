/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 17/09/2012
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class Turno
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turno));
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dtpFechaDespacho = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(131, 109);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(102, 22);
			this.cmbTurno.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(81, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Turno:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(-1, -1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(332, 55);
			this.label2.TabIndex = 2;
			this.label2.Text = "Despacho";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(237, 140);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(81, 31);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Aceptar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// dtpFechaDespacho
			// 
			this.dtpFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDespacho.Location = new System.Drawing.Point(131, 77);
			this.dtpFechaDespacho.Name = "dtpFechaDespacho";
			this.dtpFechaDespacho.Size = new System.Drawing.Size(102, 20);
			this.dtpFechaDespacho.TabIndex = 203;
			this.dtpFechaDespacho.Value = new System.DateTime(2012, 12, 10, 9, 30, 45, 0);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(99, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 18);
			this.label3.TabIndex = 204;
			this.label3.Text = "Día:";
			// 
			// Turno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(330, 183);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpFechaDespacho);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbTurno);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Turno";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Turno";
			this.Load += new System.EventHandler(this.TurnoLoad);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurnoFormClosing);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFechaDespacho;
		public System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbTurno;
	}
}
