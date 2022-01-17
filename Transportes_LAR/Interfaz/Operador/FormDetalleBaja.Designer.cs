/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 22/07/2012
 * Time: 19:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormDetalleBaja
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleBaja));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rReconsiderable = new System.Windows.Forms.RadioButton();
			this.rNoRecontratable = new System.Windows.Forms.RadioButton();
			this.rContratable = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rNoRecomendable = new System.Windows.Forms.RadioButton();
			this.rRecomendable = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(409, 59);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(334, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Describa el motivo de la baja del operador:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.txtDescripcion);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 132);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Motivo";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
			this.txtDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(15, 22);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(360, 94);
			this.txtDescripcion.TabIndex = 0;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(321, 290);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 34);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.rReconsiderable);
			this.groupBox2.Controls.Add(this.rNoRecontratable);
			this.groupBox2.Controls.Add(this.rContratable);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(4, 65);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(237, 81);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recotratación";
			// 
			// rReconsiderable
			// 
			this.rReconsiderable.BackColor = System.Drawing.Color.Transparent;
			this.rReconsiderable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rReconsiderable.Location = new System.Drawing.Point(111, 21);
			this.rReconsiderable.Name = "rReconsiderable";
			this.rReconsiderable.Size = new System.Drawing.Size(120, 24);
			this.rReconsiderable.TabIndex = 2;
			this.rReconsiderable.TabStop = true;
			this.rReconsiderable.Text = "Reconsiderable";
			this.rReconsiderable.UseVisualStyleBackColor = false;
			this.rReconsiderable.CheckedChanged += new System.EventHandler(this.RContratableCheckedChanged);
			// 
			// rNoRecontratable
			// 
			this.rNoRecontratable.BackColor = System.Drawing.Color.Transparent;
			this.rNoRecontratable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rNoRecontratable.Location = new System.Drawing.Point(44, 51);
			this.rNoRecontratable.Name = "rNoRecontratable";
			this.rNoRecontratable.Size = new System.Drawing.Size(147, 24);
			this.rNoRecontratable.TabIndex = 1;
			this.rNoRecontratable.TabStop = true;
			this.rNoRecontratable.Text = "No Recomendable";
			this.rNoRecontratable.UseVisualStyleBackColor = false;
			this.rNoRecontratable.CheckedChanged += new System.EventHandler(this.RContratableCheckedChanged);
			// 
			// rContratable
			// 
			this.rContratable.BackColor = System.Drawing.Color.Transparent;
			this.rContratable.Checked = true;
			this.rContratable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rContratable.Location = new System.Drawing.Point(10, 21);
			this.rContratable.Name = "rContratable";
			this.rContratable.Size = new System.Drawing.Size(104, 24);
			this.rContratable.TabIndex = 0;
			this.rContratable.TabStop = true;
			this.rContratable.Text = "Contratable";
			this.rContratable.UseVisualStyleBackColor = false;
			this.rContratable.CheckedChanged += new System.EventHandler(this.RContratableCheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox3.Controls.Add(this.rNoRecomendable);
			this.groupBox3.Controls.Add(this.rRecomendable);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(247, 65);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(155, 81);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Recomendación";
			// 
			// rNoRecomendable
			// 
			this.rNoRecomendable.BackColor = System.Drawing.Color.Transparent;
			this.rNoRecomendable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rNoRecomendable.Location = new System.Drawing.Point(6, 51);
			this.rNoRecomendable.Name = "rNoRecomendable";
			this.rNoRecomendable.Size = new System.Drawing.Size(147, 24);
			this.rNoRecomendable.TabIndex = 1;
			this.rNoRecomendable.TabStop = true;
			this.rNoRecomendable.Text = "No Recomendable";
			this.rNoRecomendable.UseVisualStyleBackColor = false;
			this.rNoRecomendable.CheckedChanged += new System.EventHandler(this.RRecomendableCheckedChanged);
			// 
			// rRecomendable
			// 
			this.rRecomendable.BackColor = System.Drawing.Color.Transparent;
			this.rRecomendable.Checked = true;
			this.rRecomendable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rRecomendable.Location = new System.Drawing.Point(6, 21);
			this.rRecomendable.Name = "rRecomendable";
			this.rRecomendable.Size = new System.Drawing.Size(133, 24);
			this.rRecomendable.TabIndex = 0;
			this.rRecomendable.TabStop = true;
			this.rRecomendable.Text = "Recomendable";
			this.rRecomendable.UseVisualStyleBackColor = false;
			this.rRecomendable.CheckedChanged += new System.EventHandler(this.RRecomendableCheckedChanged);
			// 
			// FormDetalleBaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(410, 336);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDetalleBaja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Descripción de baja";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton rReconsiderable;
		private System.Windows.Forms.RadioButton rNoRecontratable;
		private System.Windows.Forms.RadioButton rContratable;
		private System.Windows.Forms.RadioButton rNoRecomendable;
		private System.Windows.Forms.RadioButton rRecomendable;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
